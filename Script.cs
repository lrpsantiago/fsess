private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const float DEFAULT_SUSPENSION_SPEED_LIMIT = 999;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const bool AUTO_ERS = false; //Activates ERS whenever it's 100% Charge (true or false)

enum ç{ß,à,á,â,ã,}enum ä{å,æ,è,Þ}class Ý{public int Ñ{get;set;}public int É{get;set;}public int Ê{get;set;}public int Ë{
get;set;}public string Ì{get;set;}="--:--.---";public string Í{get;set;}="--:--.---";public ä Î{get;set;}=ä.å;public void Ï
(string Ð){try{var x=Ð.Split(';');Ê=Convert.ToInt32(x[0]);Ñ=Convert.ToInt32(x[1]);Ì=x[2];Í=x[3];É=Convert.ToInt32(x[4]);Ë
=Convert.ToInt32(x[5]);Î=(ä)Convert.ToInt32(x[6]);}catch(Exception){}}}string Û="7.0.0 Beta 6";const int Ò=3000;const int
Ó=500;const float Ô=80f;const char Õ='\u2191';const char Ö='\u2193';const char Ø='\u2588';const char Ù='\u2592';const
char Ú='\u2591';List<IMyMotorSuspension>È;IMyCockpit é;List<IMyTextSurface>ê;bool ù;bool ú;bool û;StringBuilder ü;Ý ý;List<
IMyTerminalBlock>þ;List<IMyLightingBlock>ÿ;List<IMyLightingBlock>Ā;ç ā;float Ă=0;float ċ=100;float ă=1;float Ą=100;long ą=-1;
IMyBroadcastListener Ć;int ć;int Ĉ;DateTime ĉ;float Ċ;float Č=1f;Program(){ý=new Ý();B();C();E();G();K();f();O();Æ();w();Á();Runtime.
UpdateFrequency=UpdateFrequency.Update10;ĉ=DateTime.Now;}void Save(){}void Main(string Ä,UpdateType ë){var ì=DateTime.Now;Ċ=(float)(ì-ĉ
).TotalMilliseconds/1000;Echo($"Running FSESS {Û}");Ã(Ä);V();c();T();Z();ð();í();ò();ĉ=ì;}void í(){switch(ý.Î){case ä.æ:î
();break;case ä.è:ï();break;default:break;}}void î(){ú=false;û=false;ù=false;foreach(var F in È){F.SetValueFloat(
"Speed Limit",50f*3.6f);}}void ï(){ú=false;û=false;ù=false;foreach(var F in È){F.IsParkingEnabled=true;}}void ð(){var ø=IGC.
UnicastListener;if(!ø.HasPendingMessage){ć-=(int)(Ċ*1000);if(Ć.HasPendingMessage&&ć<=0){var Ü=Ć.AcceptMessage();if(Ü.Tag=="Address"){ą=
Convert.ToInt64(Ü.Data.ToString());IGC.SendUnicastMessage(ą,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ø.
HasPendingMessage){var ñ=ø.AcceptMessage();if(ñ.Tag=="RaceData"){ý.Ï(ñ.Data.ToString());}if(ñ.Tag=="Argument"){Ã(ñ.Data.ToString());}}ć=Ò
;}void ò(){ü.Clear();var U=é.GetShipSpeed();var ó=((Ą-Ă)/(ċ-Ă))*100f;var ô=m();var õ=((int)Math.Floor(ó)).ToString();var
ö=$"{U:F0}m/s";var u=q();var Ü=ù?"PIT LIMITER":ú?"DRS ON":"";ü.AppendLine(ö+u.PadLeft(16-ö.Length));ü.AppendLine(Ü);ü.
AppendLine($"P:{ý.Ñ:00}/{ý.É:00}  L:{(ý.Ê):00}/{ý.Ë:00}");ü.AppendLine($"TYRE ({ô})..: {õ,3}%");ü.AppendLine($"TIME.: {ý.Ì}");ü.
AppendLine($"BEST.: {ý.Í}");if(ć<=0){ü.AppendLine($"NO CONNECTION");}foreach(var I in ê){I.WriteText(ü);var R=ý.Î!=ä.å?p():Color.
Black;I.BackgroundColor=R;I.ScriptBackgroundColor=R;}}void T(){if(!ù){foreach(var F in È){F.Power=Ô;F.SetValueFloat(
"Speed Limit",DEFAULT_SUSPENSION_SPEED_LIMIT*3.6f);}return;}foreach(var F in È){F.Power=20f;F.SetValueFloat("Speed Limit",26f*3.6f);}
var U=é.GetShipSpeed();é.HandBrake=U>24;}void V(){var W=é.MoveIndicator.Z>0||é.MoveIndicator.Y>0||é.HandBrake;if(W){ú=false
;}for(int S=0;S<È.Count;S++){var F=È[S];F.Strength=!ú?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var A in Ā){A.Enabled=ú;}}
void c(){if(AUTO_ERS&&Č==1){û=true;}if(ù){û=false;}var X=é.MoveIndicator.Z<0;var U=é.GetShipSpeed();var Y=(float)MathHelper.
Clamp(U/90,0,1);if(U>1){if(!û){Č+=(1f/240)*Y*Ċ;}else if(X){Č+=-(1f/120)*Y*Ċ;}}Č=MathHelper.Clamp(Č,0,1);if(Č<=0){û=false;}
foreach(var F in È){F.Power=!û?Ô:100;}foreach(var A in ÿ){A.Color=û?Color.Lime:Color.Red;}}void Z(){var U=é.GetShipSpeed();if(U
<1){return;}var a=(float)MathHelper.Clamp(U,0,90)/90;var e=ă*a*Ċ;Ą-=e;Ą=MathHelper.Clamp(Ą,Ă,ċ);foreach(var F in È){F.
Friction=Ą;}if(Ą<=Ă){if(È.All(F=>F.IsAttached)){var J=new Random().Next(4);È[J].Detach();}}h();}void B(){if(DRIVER_NUMBER<=0&&
DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");}Me.CubeGrid.CustomName=
$"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void C(){var D=new List<IMyCockpit>();GridTerminalSystem.GetBlocksOfType(D);é=D.FirstOrDefault();if(é==null){throw new
Exception("No cockpit!");}}void E(){È=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(È,F=>F.CubeGrid==Me.
CubeGrid);if(È==null||È.Count!=4){throw new Exception("Need 4 suspensions!");}}void G(){ü=new StringBuilder();ê=new List<
IMyTextSurface>{Me.GetSurface(0)};var H=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(H!=null){ê.Add(H);}
foreach(var I in ê){I.ContentType=ContentType.TEXT_AND_IMAGE;I.Alignment=TextAlignment.CENTER;I.Font="Monospace";}}void K(){var
P=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(P,L=>L.CubeGrid
==Me.CubeGrid);þ=new List<IMyTerminalBlock>();foreach(var A in P){if(A is IMyLightingBlock){var M=(IMyLightingBlock)A;M.
Intensity=5f;M.BlinkLength=0f;M.BlinkIntervalSeconds=0f;}else if(A is IMyTextPanel){var N=(IMyTextPanel)A;N.ContentType=
ContentType.TEXT_AND_IMAGE;N.WriteText("",false);}þ.Add(A);}}void O(){Ā=new List<IMyLightingBlock>();var P=new List<
IMyTerminalBlock>();var Q=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.GetBlocks(P,L=>L.
CubeGrid==Me.CubeGrid);foreach(var A in P){var M=(IMyLightingBlock)A;Ā.Add(M);}}void f(){ÿ=new List<IMyLightingBlock>();var P=
new List<IMyTerminalBlock>();var Q=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.
GetBlocks(P,L=>L.CubeGrid==Me.CubeGrid);foreach(var A in P){var M=(IMyLightingBlock)A;M.Radius=4f;M.Intensity=10f;M.BlinkLength=
50f;M.BlinkIntervalSeconds=0.5f;ÿ.Add(M);}}void w(){if(string.IsNullOrWhiteSpace(Me.CustomData)){Ç(ç.ß);return;}var x=Me.
CustomData.Split(';');if(x.Length<3){Ç(ç.ß);return;}var y=Convert.ToChar(x[0]);var z=(float)Convert.ToDouble(x[1]);var µ=(float)
Convert.ToDouble(x[2]);switch(y){case'U':Ç(ç.ß);break;case'S':Ç(ç.à);break;case'M':Ç(ç.á);break;case'H':Ç(ç.â);break;default:Ç(
ç.ß);break;}Ą=z;Č=µ;}void Æ(){var º=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(º);var À=º.
FirstOrDefault();if(À==null){return;}À.Radius=5000;À.EnableBroadcasting=true;À.HudText=$"{DRIVER_NUMBER}-{DRIVER_NAME}";}void Á(){IGC.
RegisterBroadcastListener("Address");var Â=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(Â);Ć=Â.FirstOrDefault();}void Ã(string Ä){
if(Ä.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){ù=!ù;return;}if(Ä.Equals("LMT_ON",StringComparison.
InvariantCultureIgnoreCase)){ù=true;return;}if(Ä.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){ù=false;return;}if(Ä.Equals("DRS",
StringComparison.InvariantCultureIgnoreCase)){ú=!ú;return;}if(Ä.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){û=!û;return;}
if(Ä.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){Å(ç.ß);return;}if(Ä.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){Å(ç.à);return;}if(Ä.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Å(ç.á);return;}if(Ä.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){Å(ç.â);return;}if(Ä.Equals("EXTRA",StringComparison.InvariantCultureIgnoreCase)){Å(ç.ã);
return;}}void Å(ç ª){if(!ù||é.GetShipSpeed()>1){return;}Ç(ª);h(true);}void Ç(ç ª){var v=Color.White;switch(ª){case ç.ß:ċ=100;Ă
=37.5f;ă=(ċ-Ă)/(60*5);v=Color.Magenta;break;case ç.à:ċ=90;Ă=40;ă=(ċ-Ă)/(60*8);v=Color.Red;break;case ç.á:ċ=75;Ă=43.75f;ă=
(ċ-Ă)/(60*13);v=Color.Yellow;break;case ç.â:ċ=60;Ă=47.5f;ă=(ċ-Ă)/(60*21);v=Color.White;break;case ç.ã:ċ=55;Ă=48.75f;ă=(ċ-
Ă)/(60*34);v=Color.DarkOrange;break;default:break;}Ą=ċ;ā=ª;g(v);foreach(var F in È){F.ApplyAction("Add Top Part");}}void
g(Color R){foreach(var A in þ){if(A is IMyLightingBlock){var M=(IMyLightingBlock)A;M.Color=R;}else if(A is IMyTextPanel){
var N=(IMyTextPanel)A;N.BackgroundColor=R;}}}void h(bool j=false){Ĉ-=(int)(Ċ*1000);if(!j&&Ĉ>0){return;}var k=m();Me.
CustomData=$"{k};{Ą};{Č}";Ĉ=Ó;}char m(){var k='U';switch(ā){case ç.ß:k='U';break;case ç.à:k='S';break;case ç.á:k='M';break;case ç.
â:k='H';break;case ç.ã:k='X';break;}return k;}string n(){var o=string.Empty;switch(ý.Î){case ä.Þ:o="Blue";break;case ä.å:
o="Green";break;case ä.è:o="Red";break;case ä.æ:o="Yellow";break;}return o;}Color p(){var R=Color.Black;switch(ý.Î){case
ä.Þ:R=Color.Blue;break;case ä.å:R=Color.Green;break;case ä.è:R=Color.Red;break;case ä.æ:R=Color.Yellow;break;}return R;}
string q(){const int r=6;var t=û?Ö:Č<1?Õ:'-';var u=t+"E:";for(int S=0;S<r;S++){var Y=1f/r;if(Č>Y*S){if(Č<Y*(S+1)){u+=Ù;
continue;}u+=Ø;}else{u+=Ú;}}return u;}