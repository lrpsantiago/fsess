private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private const bool AUTO_ERS = false;                                    //Activates ERS whenever it's 100% Charge (true or false)
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private readonly string LEAGUE = "F2";                                  //Select your league ("F1" or "F2")

enum ò{ó,ô,õ,ö}enum ø{ù,ú,û,ü}class ý{public int ÿ{get;set;}public int þ{get;set;}public int ñ{get;set;}public int ï{get
;set;}public string Ù{get;set;}="--:--.---";public string Ú{get;set;}="--:--.---";public ø Û{get;set;}public void Ü(
string Ý){try{var Ç=Ý.Split(';');ñ=Convert.ToInt32(Ç[0]);ÿ=Convert.ToInt32(Ç[1]);Ù=Ç[2];Ú=Ç[3];þ=Convert.ToInt32(Ç[4]);ï=
Convert.ToInt32(Ç[5]);Û=(ø)Convert.ToInt32(Ç[6]);}catch(Exception){}}}string Þ="9.0.0";const int ß=3000;const int à=1000;const
int á=1000;const float â=80f;const float ã=95f;const char ä='\u2191';const char å='\u2193';const char æ='\u2588';const char
ç='\u2592';const char è='\u2591';List<IMyMotorSuspension>é;IMyCockpit ê;List<IMyTextSurface>ë;List<IMySoundBlock>ì;
IMyRadioAntenna í;IMySensorBlock î;bool Ø;bool Ā;bool ā;StringBuilder ė;ý Ę;List<IMyTerminalBlock>ę;List<IMyLightingBlock>Ě;List<
IMyLightingBlock>ě;ò Ĝ;float ĝ=0;float Ğ=100;float ğ=1;float Ġ=100;long ġ=-1;IMyBroadcastListener Ģ;int ģ;int Ĥ;DateTime ĥ;float Ħ;float
ħ=1f;bool Ĩ=false;int ĩ;Program(){Ę=new ý();C();D();F();G();R();S();P();Ë();Æ();Î();Ã();Å();Runtime.UpdateFrequency=
UpdateFrequency.Update1;ĥ=DateTime.Now;}void Save(){}void Main(string Ñ,UpdateType Ī){var Ĭ=DateTime.Now;Ħ=(float)(Ĭ-ĥ).
TotalMilliseconds/1000;Echo($"Running FSESS {Þ}");Ð(Ñ);W();Z();ī();m();k();e();Ă();Ć();j();B();ĥ=Ĭ;}void ī(){switch(Ę.Û){case ø.ú:Ė();
break;case ø.û:Ĕ();break;default:if(!Ø){ê.HandBrake=false;n(ã);}break;}}void Ė(){Ā=false;ā=false;ê.HandBrake=ê.GetShipSpeed()
>50;n(50f);}void Ĕ(){Ā=false;ā=false;Ø=false;ê.HandBrake=true;}void Ă(){var ă=IGC.UnicastListener;if(!ă.HasPendingMessage
){ģ-=(int)(Ħ*1000);if(Ģ.HasPendingMessage&&ģ<=0){var Ą=Ģ.AcceptMessage();if(Ą.Tag=="Address"){ġ=Convert.ToInt64(Ą.Data.
ToString());IGC.SendUnicastMessage(ġ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ă.HasPendingMessage){var ą
=ă.AcceptMessage();if(ą.Tag=="RaceData"){Ę.Ü(ą.Data.ToString());}if(ą.Tag=="Argument"){Ð(ą.Data.ToString());}}ģ=ß;}void Ć
(){ė.Clear();var V=ê.GetShipSpeed();var ć=((Ġ-ĝ)/(Ğ-ĝ))*100f;var Ĉ=t();var ĉ=((int)Math.Floor(ć)).ToString();var Ċ=
$"{V:F0}m/s";var µ=y();var Ą=string.Empty;if(Ø){Ą="PIT LIMITER";}else{if(Ā&&Ĩ){Ą="DRAFTING (DRS)";}else if(Ā){Ą="DRS ON";}else if(Ĩ)
{Ą="DRAFTING";}}ė.AppendLine(Ċ+µ.PadLeft(16-Ċ.Length));ė.AppendLine(Ą);ė.AppendLine(
$"P:{Ę.ÿ:00}/{Ę.þ:00}  L:{(Ę.ñ):00}/{Ę.ï:00}");ė.AppendLine($"TYRE ({Ĉ})..: {ĉ,3}%");ė.AppendLine($"TIME.: {Ę.Ù}");ė.AppendLine($"BEST.: {Ę.Ú}");if(ģ<=0){ė.
AppendLine($"NO CONNECTION");}var ċ=ė.ToString();foreach(var I in ë){var Č=I.DrawFrame();var č=Color.Black;var Ď=
DEFAULT_FONT_COLOR;switch(Ę.Û){case ø.ú:č=Color.Yellow;Ď=Color.Black;break;case ø.û:č=Color.Red;Ď=Color.White;break;case ø.ü:č=Color.Blue;
Ď=Color.White;break;}I.BackgroundColor=č;I.ScriptBackgroundColor=č;I.FontColor=Ď;var ď=MySprite.CreateText(ċ,"Monospace",
Ď,0.75f);ď.Position=new Vector2(128,18);Č.Add(ď);var Đ=MathHelper.Clamp(Math.Round(V/(100f/15)),0,100);for(int Y=0;Y<Đ;Y
++){var đ=8f;var Ē=2f;var ē=(256/2)-((15f*đ+14f*Ē)/2)+đ/2;var ĕ=new Vector2(ē+(đ+Ē)*Y,đ+Ē);var Ö=new Vector2(đ);var U=
MySprite.CreateSprite("Circle",ĕ,Ö);if(Y<5){U.Color=Color.Lime;}else if(Y<10){U.Color=Color.Red;}else{U.Color=Color.Blue;}Č.Add(
U);}Č.Dispose();}}void m(){if(!Ø){foreach(var A in é){A.Power=â;A.SetValueFloat("Speed Limit",ã*3.6f);}return;}foreach(
var A in é){A.Power=20f;A.SetValueFloat("Speed Limit",26f*3.6f);}var V=ê.GetShipSpeed();ê.HandBrake=V>24;}void W(){var X=ê.
MoveIndicator.Z>0||ê.MoveIndicator.Y>0||ê.HandBrake;if(X||LEAGUE=="F2"){Ā=false;}for(int Y=0;Y<é.Count;Y++){var A=é[Y];A.Strength=!Ā?
DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var M in ě){M.Color=Ā?Color.Blue:Color.Black;M.Enabled=Ā;}}void Z(){if(AUTO_ERS&&ħ==1){ā=true;}if(Ø){ā=
false;}var a=ê.MoveIndicator.Z<0;var V=ê.GetShipSpeed();if(V>1){if(!ā){var c=(float)MathHelper.Clamp(V/100,0,1);ħ+=(1f/240)*c
*Ħ;}else if(a){var c=(float)MathHelper.Clamp(V/100,1,0);ħ-=(1f/120)*c*Ħ;}}ħ=MathHelper.Clamp(ħ,0,1);if(ħ<=0){ā=false;}
foreach(var A in é){A.Power=!ā?â:100;}foreach(var M in Ě){M.Color=ā?Color.Lime:Color.Red;}}void e(){var V=ê.GetShipSpeed();if(V
<1){return;}var f=(float)MathHelper.Clamp(V,0,90)/90;var g=ğ*f*Ħ;Ġ-=g;Ġ=MathHelper.Clamp(Ġ,ĝ,Ğ);foreach(var A in é){A.
Friction=Ġ;}if(Ġ<=ĝ){if(é.All(A=>A.IsAttached)){var h=new Random().Next(4);é[h].Detach();}}p();}void j(){if(í==null){return;}í.
HudText=$"P{Ę.ÿ}";}void k(){if(î==null){return;}var T=!î.Closed&&î.IsActive&&ê.GetShipSpeed()>=70;if(T){ĩ=á;}if(Ø){ĩ=0;}Ĩ=ĩ>0;
foreach(var A in é){A.Power=ð();var J=Á();A.SetValueFloat("Speed Limit",J*3.6f);}ĩ-=(int)(Ħ*1000);}void B(){foreach(var A in ì)
{}}void C(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");}if(
LEAGUE!="F1"&&LEAGUE!="F2"){throw new Exception("LEAGUE should be F1 or F2");}Me.CubeGrid.CustomName=
$"{LEAGUE} #{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void D(){var E=new List<IMyCockpit>();GridTerminalSystem.GetBlocksOfType(E);ê=E.FirstOrDefault();if(ê==null){throw new
Exception("No cockpit!");}}void F(){é=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(é,A=>A.CubeGrid==Me.
CubeGrid);if(é==null||é.Count!=4){throw new Exception("Need 4 suspensions!");}}void G(){ė=new StringBuilder();ë=new List<
IMyTextSurface>{Me.GetSurface(0)};var H=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(H!=null){ë.Add(H);}if(
COCKPIT_DISPLAY_INDEX.HasValue){var I=ê.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(I!=null){ë.Add(I);}}foreach(var I in ë){I.
ContentType=ContentType.SCRIPT;I.Alignment=TextAlignment.CENTER;I.Font="Monospace";}}void R(){var K=new List<IMyTerminalBlock>();
GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(K,L=>L.CubeGrid==Me.CubeGrid);ę=new List<IMyTerminalBlock>();
foreach(var M in K){if(M is IMyLightingBlock){var N=(IMyLightingBlock)M;N.Intensity=5f;N.BlinkLength=0f;N.BlinkIntervalSeconds=
0f;}else if(M is IMyTextPanel){var O=(IMyTextPanel)M;O.ContentType=ContentType.TEXT_AND_IMAGE;O.WriteText("",false);}ę.Add
(M);}}void P(){ě=new List<IMyLightingBlock>();var K=new List<IMyTerminalBlock>();var Q=GridTerminalSystem.
GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.GetBlocks(K,L=>L.CubeGrid==Me.CubeGrid);foreach(var M in K){var N=(
IMyLightingBlock)M;ě.Add(N);}}void S(){Ě=new List<IMyLightingBlock>();var K=new List<IMyTerminalBlock>();var Q=GridTerminalSystem.
GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.GetBlocks(K,L=>L.CubeGrid==Me.CubeGrid);foreach(var M in K){var N=(
IMyLightingBlock)M;N.Radius=4f;N.Intensity=10f;N.BlinkLength=50f;N.BlinkIntervalSeconds=0.5f;Ě.Add(N);}}void Ã(){var Ä=(IMySensorBlock)
GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(Ä==null){return;}î=Ä;î.TopExtend=50;î.BottomExtend=0;î.RightExtend=2.25f;î.
LeftExtend=2.25f;î.FrontExtend=0;î.BackExtend=2;î.DetectSmallShips=true;î.DetectLargeShips=false;î.DetectStations=false;î.
DetectSubgrids=false;î.DetectAsteroids=false;î.DetectPlayers=false;}void Å(){ì=new List<IMySoundBlock>();GridTerminalSystem.
GetBlocksOfType(ì,L=>L.CubeGrid==Me.CubeGrid);}void Æ(){if(string.IsNullOrWhiteSpace(Me.CustomData)){Ô(ò.ó);return;}var Ç=Me.CustomData
.Split(';');if(Ç.Length<3){Ô(ò.ó);return;}var È=Convert.ToChar(Ç[0]);var É=(float)Convert.ToDouble(Ç[1]);var Ê=(float)
Convert.ToDouble(Ç[2]);switch(È){case'S':Ô(ò.ó);break;case'M':Ô(ò.ô);break;case'H':Ô(ò.õ);break;case'X':Ô(ò.ö);break;default:Ô(
ò.ó);break;}Ġ=É;ħ=Ê;}void Ë(){var Ì=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Ì);var Í=Ì.
FirstOrDefault();if(Í==null){return;}Í.Enabled=true;Í.Radius=5000;Í.EnableBroadcasting=true;Í.HudText=
$"(P{Ę.ÿ}) {DRIVER_NAME}-{DRIVER_NUMBER}";í=Í;}void Î(){IGC.RegisterBroadcastListener("Address");var Ï=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners
(Ï);Ģ=Ï.FirstOrDefault();}void Ð(string Ñ){if(Ñ.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){Ø=!Ø;return;}
if(Ñ.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){Ø=true;return;}if(Ñ.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){Ø=false;return;}if(Ñ.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){if(LEAGUE=="F1"){Ā=!Ā;}return;}if(Ñ.
Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){ā=!ā;return;}if(Ñ.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){Ò(ò.ó);return;}if(Ñ.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Ò(ò.ô);return;}if(Ñ.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){Ò(ò.õ);return;}if(Ñ.Equals("EXTRA",StringComparison.InvariantCultureIgnoreCase)){Ò(ò.ö);
return;}if(Ñ.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){º(ø.ù);return;}if(Ñ.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){º(ø.ú);return;}if(Ñ.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){º(ø.û);
return;}}void Ò(ò Ó){if(!Ø||ê.GetShipSpeed()>1){return;}Ô(Ó);p(true);}void Ô(ò Ó){var Õ=Color.White;switch(Ó){case ò.ó:Ğ=100;ĝ
=37.5f;ğ=(Ğ-ĝ)/(60*8);Õ=Color.Red;break;case ò.ô:Ğ=75;ĝ=43.75f;ğ=(Ğ-ĝ)/(60*13);Õ=Color.Yellow;break;case ò.õ:Ğ=60;ĝ=47.5f
;ğ=(Ğ-ĝ)/(60*21);Õ=Color.White;break;case ò.ö:Ğ=55;ĝ=48.75f;ğ=(Ğ-ĝ)/(60*34);Õ=Color.Cyan;break;default:break;}Ġ=Ğ;Ĝ=Ó;Â(Õ
);foreach(var A in é){A.ApplyAction("Add Top Part");}}void Â(Color x){foreach(var M in ę){if(M is IMyLightingBlock){var N
=(IMyLightingBlock)M;N.Color=x;}else if(M is IMyTextPanel){var O=(IMyTextPanel)M;O.BackgroundColor=x;}}}void n(float o){
foreach(var A in é){A.SetValueFloat("Speed Limit",o*3.6f);}}void p(bool q=false){Ĥ-=(int)(Ħ*1000);if(!q&&Ĥ>0){return;}var r=t()
;Me.CustomData=$"{r};{Ġ};{ħ}";Ĥ=à;}char t(){var r='S';switch(Ĝ){case ò.ó:r='S';break;case ò.ô:r='M';break;case ò.õ:r='H';
break;case ò.ö:r='X';break;}return r;}string u(){var v=string.Empty;switch(Ę.Û){case ø.ü:v="Blue";break;case ø.ù:v="Green";
break;case ø.û:v="Red";break;case ø.ú:v="Yellow";break;}return v;}Color w(){var x=Color.Black;switch(Ę.Û){case ø.ü:x=Color.
Blue;break;case ø.ù:x=Color.Green;break;case ø.û:x=Color.Red;break;case ø.ú:x=Color.Yellow;break;}return x;}string y(){const
int z=6;var ª=ā?å:ħ<1?ä:'-';var µ=ª+"E:";for(int Y=0;Y<z;Y++){var c=1f/z;if(ħ>c*Y){if(ħ<c*(Y+1)){µ+=ç;continue;}µ+=æ;}else{
µ+=è;}}return µ;}void º(ø À){if(ġ<=0){return;}IGC.SendUnicastMessage(ġ,"Flag",$"{(int)À}");}float ð(){if(Ø){return 20f;}
if(Ĩ||ā){return 100f;}return â;}float Á(){if(Ø){return 26;}if(Ę.Û==ø.ú){return 45;}if(Ĩ){return 999;}return ã;}