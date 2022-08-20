private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const float DEFAULT_SUSPENSION_POWER = 100f;
private const float DEFAULT_SUSPENSION_SPEED_LIMIT = 999;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";

//************ DO NOT MODIFY BELLOW HERE ************

enum TireCompound
{
    Ultra,  //100% ~5 minutes
    Soft,   //90%  ~8 minutes
    Medium, //75%  ~13 minutes
    Hard    //60%  ~21 minutes
}

private class RaceData
{
    public int Position { get; set; }
    public int Laps { get; set; }
    public string CurrentLapTime { get; set; } = "--:--.---";
    public string BestLapTime { get; set; } = "--:--.---";

    public void Map(string data)
    {
        try
        {
            var values = data.Split(';');

            Laps = Convert.ToInt32(values[0]);
            Position = Convert.ToInt32(values[1]);
            CurrentLapTime = values[2];
            BestLapTime = values[3];
        }
        catch (Exception) { }
    }
}

private readonly string CODE_VERSION = "6.1.0";
private const int CONNECTION_TIMEOUT = 3000;
private List<IMyMotorSuspension> _suspensions;
private IMyCockpit _mainController;
private List<IMyTextSurface> _displays;
private bool _isPitLimiterActive;
private bool _isDrsActive;
private StringBuilder _stringBuilder;
private RaceData _data;
private List<IMyTerminalBlock> _brakelights;
private TireCompound _currentTireCompound;
private List<IMyThrust> _thrusters;
private float _minTireFriction = 0;
private float _maxTireFriction = 100;
private float _tireWearFactor = 1;
private float _friction = 100;
private long _address = -1;
private IMyBroadcastListener _broadcastListener;
private int _connectionTimeout;

public Program()
{
    _data = new RaceData();

    SetupGridName();
    SetupController();
    SetupSuspensions();
    SetupDisplay();
    SetupBrakelights();
    SetupThrusters();
    SetupAntenna();
    LoadTires();
    SetupBroadcastListener();

    Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

public void Save()
{
    // Called when the program needs to save its state. Use
    // this method to save your state to the Storage field
    // or some other means. 
    // 
    // This method is optional and can be removed if not
    // needed.
}

public void Main(string argument, UpdateType updateSource)
{
    Echo($"Running FSESS {CODE_VERSION}");

    HandleArgument(argument);
    UpdateDownforce();
    UpdatePitLimiter();
    UpdateDrs();
    UpdateTireDegradation();
    UpdateCommunication();
    UpdateDisplays();
}

private void UpdateDownforce()
{
    var speed = _mainController.GetShipSpeed();
    var thrustPerc = (float)(MathHelper.Clamp(speed, 0, 100) / 100);

    foreach (var t in _thrusters)
    {
        t.ThrustOverridePercentage = thrustPerc;
    }
}

private void UpdateCommunication()
{
    var unisource = IGC.UnicastListener;

    if (!unisource.HasPendingMessage)
    {
        _connectionTimeout -= (int)Runtime.TimeSinceLastRun.TotalMilliseconds;

        if (_broadcastListener.HasPendingMessage && _connectionTimeout <= 0)
        {
            var message = _broadcastListener.AcceptMessage();

            if (message.Tag == "Address")
            {
                _address = Convert.ToInt64(message.Data.ToString());
                IGC.SendUnicastMessage(_address, "Register", $"{Me.CubeGrid.CustomName};{IGC.Me}");
            }
        }

        return;
    }

    while (unisource.HasPendingMessage)
    {
        var messageUni = unisource.AcceptMessage();

        if (messageUni.Tag == "RaceData")
        {
            _data.Map(messageUni.Data.ToString());
        }

        if (messageUni.Tag == "Argument")
        {
            HandleArgument(messageUni.Data.ToString());
        }
    }

    _connectionTimeout = CONNECTION_TIMEOUT;
}

private void UpdateDisplays()
{
    _stringBuilder.Clear();

    var speed = _mainController.GetShipSpeed();
    var tireWear = ((_friction - _minTireFriction) / (_maxTireFriction - _minTireFriction)) * 100f;
    var tireCompoundIndicator = _currentTireCompound.ToString().First();
    var strTireWear = ((int)Math.Floor(tireWear)).ToString();

    _stringBuilder.AppendLine($"{speed:F2} m/s");
    _stringBuilder.AppendLine(_isPitLimiterActive ? "PIT LIMITER" : tireWear < 20 ? "TIRES WORN" : "");
    _stringBuilder.AppendLine($"POS: {_data.Position:00}  LAP: {_data.Laps:00}");
    _stringBuilder.AppendLine($"TIRE ({tireCompoundIndicator})..: {strTireWear,3}%");
    _stringBuilder.AppendLine($"TIME.: {_data.CurrentLapTime}");
    _stringBuilder.AppendLine($"BEST.: {_data.BestLapTime}");
    if (_connectionTimeout <= 0) _stringBuilder.AppendLine($"NO CONNECTION");

    foreach (var d in _displays)
    {
        d.WriteText(_stringBuilder);

        var color = !_isDrsActive
            ? Color.Black
            : speed < 100
                ? Color.DarkBlue
                : Color.DarkRed;

        d.BackgroundColor = color;
        d.ScriptBackgroundColor = color;
    }
}

private void UpdatePitLimiter()
{
    if (!_isPitLimiterActive)
    {
        foreach (var s in _suspensions)
        {
            s.Power = DEFAULT_SUSPENSION_POWER;
            s.SetValueFloat("Speed Limit", DEFAULT_SUSPENSION_SPEED_LIMIT * 3.6f);
        }

        return;
    }

    foreach (var s in _suspensions)
    {
        s.Power = 20f;
        s.SetValueFloat("Speed Limit", 26f * 3.6f);
    }

    var speed = _mainController.GetShipSpeed();
    _mainController.HandBrake = speed > 24;
}

private void UpdateDrs()
{
    var isBreaking = _mainController.MoveIndicator.Z > 0
        || _mainController.MoveIndicator.Y > 0
        || _mainController.HandBrake;

    if (isBreaking)
    {
        _isDrsActive = false;
    }

    for (int i = 0; i < _suspensions.Count; i++)
    {
        var s = _suspensions[i];
        s.Strength = !_isDrsActive ? DEFAULT_SUSPENSION_STRENGTH : 100;
    }
}

private void UpdateTireDegradation()
{
    var speed = _mainController.GetShipSpeed();

    if (speed < 1)
    {
        return;
    }

    var speedFactor = (float)MathHelper.Clamp(speed, 0, 90) / 90;
    var wearRate = _tireWearFactor * speedFactor * ((float)Runtime.TimeSinceLastRun.Milliseconds / 1000);

    _friction -= wearRate;
    _friction = MathHelper.Clamp(_friction, _minTireFriction, _maxTireFriction);

    foreach (var s in _suspensions)
    {
        s.Friction = _friction;
    }

    if (_friction <= _minTireFriction)
    {
        if (_suspensions.All(s => s.IsAttached))
        {
            var rand = new Random().Next(4);
            _suspensions[rand].Detach();
        }
    }

    SaveTires();
}

private void SetupGridName()
{
    if (DRIVER_NUMBER <= 0 && DRIVER_NUMBER > 99)
    {
        throw new Exception("DRIVER_NUMBER should be between 1 and 99");
    }

    Me.CubeGrid.CustomName = $"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";
}

private void SetupController()
{
    var controllerList = new List<IMyCockpit>();
    GridTerminalSystem.GetBlocksOfType(controllerList);
    _mainController = controllerList.FirstOrDefault();

    if (_mainController == null)
    {
        throw new Exception("No cockpit!");
    }
}

private void SetupSuspensions()
{
    _suspensions = new List<IMyMotorSuspension>();
    GridTerminalSystem.GetBlocksOfType(_suspensions, s => s.CubeGrid == Me.CubeGrid);

    if (_suspensions == null || _suspensions.Count != 4)
    {
        throw new Exception("Need 4 suspensions!");
    }
}

private void SetupDisplay()
{
    _stringBuilder = new StringBuilder();
    _displays = new List<IMyTextSurface>
    {
        Me.GetSurface(0)
    };

    var display = (IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);

    if (display != null)
    {
        _displays.Add(display);
    }

    foreach (var d in _displays)
    {
        d.ContentType = ContentType.TEXT_AND_IMAGE;
        d.Alignment = TextAlignment.CENTER;
        d.Font = "Monospace";
    }
}

private void SetupBrakelights()
{
    var lights = new List<IMyTerminalBlock>();

    GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME)
        .GetBlocks(lights, b => b.CubeGrid == Me.CubeGrid);

    _brakelights = new List<IMyTerminalBlock>();

    foreach (var l in lights)
    {
        if (l is IMyLightingBlock)
        {
            var light = (IMyLightingBlock)l;
            light.Intensity = 5f;
            light.BlinkLength = 0f;
            light.BlinkIntervalSeconds = 0f;
        }
        else if (l is IMyTextPanel)
        {
            var lcd = (IMyTextPanel)l;
            lcd.ContentType = ContentType.TEXT_AND_IMAGE;
            lcd.WriteText("", false);
        }

        _brakelights.Add(l);
    }
}

private void LoadTires()
{
    if (string.IsNullOrWhiteSpace(Me.CustomData))
    {
        SetTires(TireCompound.Ultra);
        return;
    }

    var values = Me.CustomData.Split(';');

    if (values.Length < 2)
    {
        SetTires(TireCompound.Ultra);
        return;
    }

    var compoundChar = Convert.ToChar(values[0]);
    var friction = (float)Convert.ToDouble(values[1]);

    switch (compoundChar)
    {
        case 'U': SetTires(TireCompound.Ultra); break;
        case 'S': SetTires(TireCompound.Soft); break;
        case 'M': SetTires(TireCompound.Medium); break;
        case 'H': SetTires(TireCompound.Hard); break;
        default: SetTires(TireCompound.Ultra); break;
    }

    _friction = friction;
}

private void SetupThrusters()
{
    _thrusters = new List<IMyThrust>();
    GridTerminalSystem.GetBlocksOfType(_thrusters, t => t.CubeGrid == Me.CubeGrid);
}

private void SetupAntenna()
{
    var antennas = new List<IMyRadioAntenna>();
    GridTerminalSystem.GetBlocksOfType(antennas);
    var antenna = antennas.FirstOrDefault();

    if (antenna == null)
    {
        return;
    }

    antenna.Radius = 5000;
    antenna.EnableBroadcasting = true;
    antenna.HudText = $"{DRIVER_NUMBER}-{DRIVER_NAME}";
}

private void SetupBroadcastListener()
{
    IGC.RegisterBroadcastListener("Address");
    var listeners = new List<IMyBroadcastListener>();
    IGC.GetBroadcastListeners(listeners);
    _broadcastListener = listeners.FirstOrDefault();
}

private void HandleArgument(string argument)
{
    if (argument.Equals("LMT", StringComparison.InvariantCultureIgnoreCase))
    {
        _isPitLimiterActive = !_isPitLimiterActive;
        return;
    }

    if (argument.Equals("LMT_ON", StringComparison.InvariantCultureIgnoreCase))
    {
        _isPitLimiterActive = true;
        return;
    }

    if (argument.Equals("LMT_OFF", StringComparison.InvariantCultureIgnoreCase))
    {
        _isPitLimiterActive = false;
        return;
    }

    if (argument.Equals("DRS", StringComparison.InvariantCultureIgnoreCase))
    {
        _isDrsActive = !_isDrsActive;
        return;
    }

    if (argument.Equals("ULTRA", StringComparison.InvariantCultureIgnoreCase))
    {
        ChangeTires(TireCompound.Ultra);
    }

    if (argument.Equals("SOFT", StringComparison.InvariantCultureIgnoreCase))
    {
        ChangeTires(TireCompound.Soft);
    }

    if (argument.Equals("MEDIUM", StringComparison.InvariantCultureIgnoreCase))
    {
        ChangeTires(TireCompound.Medium);
    }

    if (argument.Equals("HARD", StringComparison.InvariantCultureIgnoreCase))
    {
        ChangeTires(TireCompound.Hard);
    }
}

private void ChangeTires(TireCompound compound)
{
    if (!_isPitLimiterActive || _mainController.GetShipSpeed() > 1)
    {
        return;
    }

    SetTires(compound);
    SaveTires();
}

private void SetTires(TireCompound compound)
{
    var lightColor = Color.White;

    switch (compound)
    {
        case TireCompound.Ultra:
            _maxTireFriction = 100;
            _minTireFriction = 37.5f;
            _tireWearFactor = (_maxTireFriction - _minTireFriction) / (60 * 5);
            lightColor = Color.Magenta;
            break;

        case TireCompound.Soft:
            _maxTireFriction = 90;
            _minTireFriction = 40;
            _tireWearFactor = (_maxTireFriction - _minTireFriction) / (60 * 8);
            lightColor = Color.Red;
            break;

        case TireCompound.Medium:
            _maxTireFriction = 75;
            _minTireFriction = 43.75f;
            _tireWearFactor = (_maxTireFriction - _minTireFriction) / (60 * 13);
            lightColor = Color.Yellow;
            break;

        case TireCompound.Hard:
            _maxTireFriction = 60;
            _minTireFriction = 47.5f;
            _tireWearFactor = (_maxTireFriction - _minTireFriction) / (60 * 21);
            lightColor = Color.White;
            break;

        default:
            break;
    }

    _friction = _maxTireFriction;
    _currentTireCompound = compound;

    SetBrakelightColor(lightColor);

    foreach (var s in _suspensions)
    {
        s.ApplyAction("Add Top Part");
    }
}

private void SetBrakelightColor(Color color)
{
    foreach (var l in _brakelights)
    {
        if (l is IMyLightingBlock)
        {
            var light = (IMyLightingBlock)l;
            light.Color = color;
        }
        else if (l is IMyTextPanel)
        {
            var lcd = (IMyTextPanel)l;
            lcd.BackgroundColor = color;
        }
    }
}

private void SaveTires()
{
    Me.CustomData = $"{_currentTireCompound.ToString().First()};{_friction}";
}