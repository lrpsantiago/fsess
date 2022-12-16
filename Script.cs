private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private const bool AUTO_ERS = false;                                    //Activates ERS whenever it's 100% Charge (true or false)
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null);
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)

enum ì{í,î,ï,ð}enum ñ{ò,ó,ô,õ}class ø{public int ö{get;set;}public int ë{get;set;}public int é{get;set;}public int Ô{get
;set;}public string Õ{get;set;}="--:--.---";public string Ö{get;set;}="--:--.---";public ñ Ø{get;set;}public void Ù(
string Ú){try{var Â=Ú.Split(';');é=Convert.ToInt32(Â[0]);ö=Convert.ToInt32(Â[1]);Õ=Â[2];Ö=Â[3];ë=Convert.ToInt32(Â[4]);Ô=
Convert.ToInt32(Â[5]);Ø=(ñ)Convert.ToInt32(Â[6]);}catch(Exception){}}}string Û="8.0.0";const int Ü=3000;const int Ý=1000;const
float Þ=80f;const float ß=95f;const char à='\u2191';const char á='\u2193';const char â='\u2588';const char ã='\u2592';const
char ä='\u2591';List<IMyMotorSuspension>å;IMyCockpit æ;List<IMyTextSurface>ç;List<IMySoundBlock>è;IMyRadioAntenna Ó;
IMySensorBlock ù;bool ú;bool Č;bool č;StringBuilder Ď;ø ď;List<IMyTerminalBlock>Đ;List<IMyLightingBlock>đ;List<IMyLightingBlock>Ē;ì ē;
float Ĕ=0;float ĕ=100;float Ė=1;float ė=100;long Ę=-1;IMyBroadcastListener ę;int Ě;int ě;DateTime Ĝ;float ĝ;float Ğ=1f;bool ğ
=false;Program(){ď=new ø();g();Q();B();D();G();N();L();Æ();Á();É();µ();À();Runtime.UpdateFrequency=UpdateFrequency.
Update1;Ĝ=DateTime.Now;}void Save(){}void Main(string Ì,UpdateType ċ){var Ċ=DateTime.Now;ĝ=(float)(Ċ-Ĝ).TotalMilliseconds/1000;
Echo($"Running FSESS {Û}");Ë(Ì);ê();S();û();ĉ();c();W();þ();Ă();a();f();Ĝ=Ċ;}void û(){switch(ď.Ø){case ñ.ó:ü();break;case ñ.
ô:ý();break;default:if(!ú){æ.HandBrake=false;h(ß);}break;}}void ü(){Č=false;č=false;æ.HandBrake=æ.GetShipSpeed()>50;h(50f
);}void ý(){Č=false;č=false;ú=false;æ.HandBrake=true;}void þ(){var ÿ=IGC.UnicastListener;if(!ÿ.HasPendingMessage){Ě-=(int
)(ĝ*1000);if(ę.HasPendingMessage&&Ě<=0){var Ā=ę.AcceptMessage();if(Ā.Tag=="Address"){Ę=Convert.ToInt64(Ā.Data.ToString())
;IGC.SendUnicastMessage(Ę,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ÿ.HasPendingMessage){var ā=ÿ.
AcceptMessage();if(ā.Tag=="RaceData"){ď.Ù(ā.Data.ToString());}if(ā.Tag=="Argument"){Ë(ā.Data.ToString());}}Ě=Ü;}void Ă(){Ď.Clear();
var U=æ.GetShipSpeed();var ă=((ė-Ĕ)/(ĕ-Ĕ))*100f;var Ą=o();var ą=((int)Math.Floor(ă)).ToString();var Ć=$"{U:F0}m/s";var x=u(
);var Ā=ú?"PIT LIMITER":Č?"DRS ON":"";Ď.AppendLine(Ć+x.PadLeft(16-Ć.Length));Ď.AppendLine(Ā);Ď.AppendLine(
$"P:{ď.ö:00}/{ď.ë:00}  L:{(ď.é):00}/{ď.Ô:00}");Ď.AppendLine($"TYRE ({Ą})..: {ą,3}%");Ď.AppendLine($"TIME.: {ď.Õ}");Ď.AppendLine($"BEST.: {ď.Ö}");if(Ě<=0){Ď.
AppendLine($"NO CONNECTION");}foreach(var F in ç){F.WriteText(Ď);var ć=Color.Black;var Ĉ=DEFAULT_FONT_COLOR;switch(ď.Ø){case ñ.ó:ć
=Color.Yellow;Ĉ=Color.Black;break;case ñ.ô:ć=Color.Red;Ĉ=Color.White;break;case ñ.õ:ć=Color.Blue;Ĉ=Color.White;break;}F.
BackgroundColor=ć;F.ScriptBackgroundColor=ć;F.FontColor=Ĉ;}}void ĉ(){if(!ú){foreach(var C in å){C.Power=Þ;C.SetValueFloat("Speed Limit"
,ß*3.6f);}return;}foreach(var C in å){C.Power=20f;C.SetValueFloat("Speed Limit",26f*3.6f);}var U=æ.GetShipSpeed();æ.
HandBrake=U>24;}void ê(){var Ò=æ.MoveIndicator.Z>0||æ.MoveIndicator.Y>0||æ.HandBrake;if(Ò){Č=false;}for(int P=0;P<å.Count;P++){
var C=å[P];C.Strength=!Č?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var I in Ē){I.Color=Č?Color.Blue:Color.Black;I.Enabled=Č;
}}void S(){if(AUTO_ERS&&Ğ==1){č=true;}if(ú){č=false;}var T=æ.MoveIndicator.Z<0;var U=æ.GetShipSpeed();if(U>1){if(!č){var
V=(float)MathHelper.Clamp(U/100,0,1);Ğ+=(1f/240)*V*ĝ;}else if(T){var V=(float)MathHelper.Clamp(U/100,1,0);Ğ-=(1f/120)*V*ĝ
;}}Ğ=MathHelper.Clamp(Ğ,0,1);if(Ğ<=0){č=false;}foreach(var C in å){C.Power=!č?Þ:100;}foreach(var I in đ){I.Color=č?Color.
Lime:Color.Red;}}void W(){var U=æ.GetShipSpeed();if(U<1){return;}var X=(float)MathHelper.Clamp(U,0,90)/90;var Y=Ė*X*ĝ;ė-=Y;ė
=MathHelper.Clamp(ė,Ĕ,ĕ);foreach(var C in å){C.Friction=ė;}if(ė<=Ĕ){if(å.All(C=>C.IsAttached)){var Z=new Random().Next(4)
;å[Z].Detach();}}k();}void a(){if(Ó==null){return;}Ó.HudText=$"P{ď.ö}";}void c(){if(ù==null){return;}ğ=!ù.Closed&&ù.
IsActive&&æ.GetShipSpeed()>=70&&!ú;foreach(var C in å){C.Power=R();var e=ª();C.SetValueFloat("Speed Limit",e*3.6f);}}void f(){
foreach(var C in è){}}void g(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}Me.CubeGrid.CustomName=$"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void Q(){var O=new List<IMyCockpit>();
GridTerminalSystem.GetBlocksOfType(O);æ=O.FirstOrDefault();if(æ==null){throw new Exception("No cockpit!");}}void B(){å=new List<
IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(å,C=>C.CubeGrid==Me.CubeGrid);if(å==null||å.Count!=4){throw new Exception(
"Need 4 suspensions!");}}void D(){Ď=new StringBuilder();ç=new List<IMyTextSurface>{Me.GetSurface(0)};var E=(IMyTextSurface)GridTerminalSystem
.GetBlockWithName(DISPLAY_NAME);if(E!=null){ç.Add(E);}if(COCKPIT_DISPLAY_INDEX.HasValue){var F=æ.GetSurface(
COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(F!=null){ç.Add(F);}}foreach(var F in ç){F.ContentType=ContentType.TEXT_AND_IMAGE;F.Alignment=
TextAlignment.CENTER;F.Font="Monospace";}}void G(){var H=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocks(H,A=>A.CubeGrid==Me.CubeGrid);Đ=new List<IMyTerminalBlock>();foreach(var I in H){if(I is IMyLightingBlock){
var J=(IMyLightingBlock)I;J.Intensity=5f;J.BlinkLength=0f;J.BlinkIntervalSeconds=0f;}else if(I is IMyTextPanel){var K=(
IMyTextPanel)I;K.ContentType=ContentType.TEXT_AND_IMAGE;K.WriteText("",false);}Đ.Add(I);}}void L(){Ē=new List<IMyLightingBlock>();
var H=new List<IMyTerminalBlock>();var M=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(M==null){return
;}M.GetBlocks(H,A=>A.CubeGrid==Me.CubeGrid);foreach(var I in H){var J=(IMyLightingBlock)I;Ē.Add(J);}}void N(){đ=new List<
IMyLightingBlock>();var H=new List<IMyTerminalBlock>();var M=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(M==null)
{return;}M.GetBlocks(H,A=>A.CubeGrid==Me.CubeGrid);foreach(var I in H){var J=(IMyLightingBlock)I;J.Radius=4f;J.Intensity=
10f;J.BlinkLength=50f;J.BlinkIntervalSeconds=0.5f;đ.Add(J);}}void µ(){var º=(IMySensorBlock)GridTerminalSystem.
GetBlockWithName(DRAFTING_SENSOR_NAME);if(º==null){return;}ù=º;ù.TopExtend=50;ù.BottomExtend=0;ù.RightExtend=2.25f;ù.LeftExtend=2.25f;ù.
FrontExtend=0;ù.BackExtend=2;ù.DetectSmallShips=true;ù.DetectLargeShips=false;ù.DetectStations=false;ù.DetectSubgrids=false;ù.
DetectAsteroids=false;ù.DetectPlayers=false;}void À(){è=new List<IMySoundBlock>();GridTerminalSystem.GetBlocksOfType(è,A=>A.CubeGrid==
Me.CubeGrid);}void Á(){if(string.IsNullOrWhiteSpace(Me.CustomData)){Ï(ì.í);return;}var Â=Me.CustomData.Split(';');if(Â.
Length<3){Ï(ì.í);return;}var Ã=Convert.ToChar(Â[0]);var Ä=(float)Convert.ToDouble(Â[1]);var Å=(float)Convert.ToDouble(Â[2]);
switch(Ã){case'S':Ï(ì.í);break;case'M':Ï(ì.î);break;case'H':Ï(ì.ï);break;case'X':Ï(ì.ð);break;default:Ï(ì.í);break;}ė=Ä;Ğ=Å;}
void Æ(){var Ç=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Ç);var È=Ç.FirstOrDefault();if(È==null){return
;}È.Enabled=true;È.Radius=5000;È.EnableBroadcasting=true;È.HudText=$"(P{ď.ö}) {DRIVER_NAME}-{DRIVER_NUMBER}";Ó=È;}void É(
){IGC.RegisterBroadcastListener("Address");var Ê=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(Ê);ę=Ê.
FirstOrDefault();}void Ë(string Ì){if(Ì.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){ú=!ú;return;}if(Ì.Equals("LMT_ON",
StringComparison.InvariantCultureIgnoreCase)){ú=true;return;}if(Ì.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){ú=false
;return;}if(Ì.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){Č=!Č;return;}if(Ì.Equals("ERS",StringComparison.
InvariantCultureIgnoreCase)){č=!č;return;}if(Ì.Equals("SOFT",StringComparison.InvariantCultureIgnoreCase)){Í(ì.í);return;}if(Ì.Equals("MEDIUM",
StringComparison.InvariantCultureIgnoreCase)){Í(ì.î);return;}if(Ì.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){Í(ì.ï);
return;}if(Ì.Equals("EXTRA",StringComparison.InvariantCultureIgnoreCase)){Í(ì.ð);return;}if(Ì.Equals("FLAG_G",StringComparison
.InvariantCultureIgnoreCase)){y(ñ.ò);return;}if(Ì.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){y(ñ.ó);
return;}if(Ì.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){y(ñ.ô);return;}}void Í(ì Î){if(!ú||æ.GetShipSpeed()
>1){return;}Ï(Î);k(true);}void Ï(ì Î){var Ð=Color.White;switch(Î){case ì.í:ĕ=100;Ĕ=37.5f;Ė=(ĕ-Ĕ)/(60*8);Ð=Color.Red;break
;case ì.î:ĕ=75;Ĕ=43.75f;Ė=(ĕ-Ĕ)/(60*13);Ð=Color.Yellow;break;case ì.ï:ĕ=60;Ĕ=47.5f;Ė=(ĕ-Ĕ)/(60*21);Ð=Color.White;break;
case ì.ð:ĕ=55;Ĕ=48.75f;Ė=(ĕ-Ĕ)/(60*34);Ð=Color.Cyan;break;default:break;}ė=ĕ;ē=Î;Ñ(Ð);foreach(var C in å){C.ApplyAction(
"Add Top Part");}}void Ñ(Color t){foreach(var I in Đ){if(I is IMyLightingBlock){var J=(IMyLightingBlock)I;J.Color=t;}else if(I is
IMyTextPanel){var K=(IMyTextPanel)I;K.BackgroundColor=t;}}}void h(float j){foreach(var C in å){C.SetValueFloat("Speed Limit",j*3.6f)
;}}void k(bool m=false){ě-=(int)(ĝ*1000);if(!m&&ě>0){return;}var n=o();Me.CustomData=$"{n};{ė};{Ğ}";ě=Ý;}char o(){var n=
'S';switch(ē){case ì.í:n='S';break;case ì.î:n='M';break;case ì.ï:n='H';break;case ì.ð:n='X';break;}return n;}string p(){var
q=string.Empty;switch(ď.Ø){case ñ.õ:q="Blue";break;case ñ.ò:q="Green";break;case ñ.ô:q="Red";break;case ñ.ó:q="Yellow";
break;}return q;}Color r(){var t=Color.Black;switch(ď.Ø){case ñ.õ:t=Color.Blue;break;case ñ.ò:t=Color.Green;break;case ñ.ô:t=
Color.Red;break;case ñ.ó:t=Color.Yellow;break;}return t;}string u(){const int v=6;var w=č?á:Ğ<1?à:'-';var x=w+"E:";for(int P=
0;P<v;P++){var V=1f/v;if(Ğ>V*P){if(Ğ<V*(P+1)){x+=ã;continue;}x+=â;}else{x+=ä;}}return x;}void y(ñ z){if(Ę<=0){return;}IGC
.SendUnicastMessage(Ę,"Flag",$"{(int)z}");}float R(){if(ú){return 20f;}if(ğ||č){return 100f;}return Þ;}float ª(){if(ú){
return 26;}if(ď.Ø==ñ.ó){return 45;}if(ğ){return 999;}return ß;}