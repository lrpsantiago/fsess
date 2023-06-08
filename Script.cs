private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 20f;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private const bool AUTO_ERS = false;                                    //Activates ERS whenever it's 100% Charge (true or false)
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private readonly string LEAGUE = "F2";                                  //Select your league ("F1" or "F2")
private const string TEXT_DISPLAY_NAME = "Text LCD";                    //Optional Text-Based LCD, for HudLcd Plugin

enum Ą{Ē,ą,Ć,ć,Ĉ}enum ĉ{Ċ,ċ,Č,č}enum Ď{ď,Đ}enum đ{ē,Ă,ä,Ā}class å{public int æ{get;set;}public int ç{get;set;}public int
è{get;set;}public int é{get;set;}public string ê{get;set;}="--:--.---";public string ë{get;set;}="--:--.---";public ĉ ì{
get;set;}public Ď í{get;set;}public int î{get;set;}public void ï(string ð){try{var Ò=ð.Split(';');è=Convert.ToInt32(Ò[0]);æ
=Convert.ToInt32(Ò[1]);ê=Ò[2];ë=Ò[3];ç=Convert.ToInt32(Ò[4]);é=Convert.ToInt32(Ò[5]);ì=(ĉ)Convert.ToInt32(Ò[6]);í=(Ď)
Convert.ToInt32(Ò[7]);î=Convert.ToInt32(Ò[8]);}catch(Exception){}}}string ñ="10.0.0";const int ò=3000;const int ó=1000;const
int ô=1000;const float õ=80f;const float ö=999f;const char ø='\u2191';const char ù='\u2193';const char ú='\u2588';const
char û='\u2592';const char ü='\u2591';const float ý=1.15f;bool þ;IMyMotorSuspension[]ÿ;IMyCockpit ă;List<IMyTextSurface>ā;
IMyTextSurface Ĕ;List<IMySoundBlock>ĭ;IMyRadioAntenna Į;IMySensorBlock į;bool İ;bool ı;bool Ĳ;StringBuilder ĳ;å Ĵ;List<
IMyTerminalBlock>ĵ;List<IMyLightingBlock>Ķ;List<IMyLightingBlock>ķ;Ą ĸ;float Ĺ=0;float ĺ=100;float ļ=1;float ņ=100;long Ľ=-1;
IMyBroadcastListener ľ;int Ŀ;int ŀ;DateTime Ł;float ł;float Ń=1f;bool ń=false;int Ņ;Program(){Ĵ=new å();try{q();t();A();G();K();S();Q();Ö();
Ñ();Ú();Î();Ð();}catch(Exception ex){þ=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.Update1;Ł=
DateTime.Now;}void Save(){}void Main(string Ü,UpdateType Ň){if(þ){return;}var Ļ=DateTime.Now;ł=(float)(Ļ-Ł).TotalMilliseconds/
1000;Echo($"Running FSESS {ñ}");Û(Ü);U();Z();Ĭ();ī();m();f();Ė();Ě();k();p();Ł=Ļ;}void Ĭ(){switch(Ĵ.ì){case ĉ.ċ:ğ();break;
case ĉ.Č:ĕ();break;default:if(!İ){ă.HandBrake=false;ã(ö);}break;}}void ğ(){ı=false;Ĳ=false;ă.HandBrake=ă.GetShipSpeed()>50;ã
(50f);}void ĕ(){ı=false;Ĳ=false;İ=false;ă.HandBrake=true;}void Ė(){var ė=IGC.UnicastListener;if(!ė.HasPendingMessage){Ŀ-=
(int)(ł*1000);if(ľ.HasPendingMessage&&Ŀ<=0){var Ę=ľ.AcceptMessage();if(Ę.Tag=="Address"){Ľ=Convert.ToInt64(Ę.Data.
ToString());IGC.SendUnicastMessage(Ľ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ė.HasPendingMessage){var ę
=ė.AcceptMessage();if(ę.Tag=="RaceData"){Ĵ.ï(ę.Data.ToString());}if(ę.Tag=="Argument"){Û(ę.Data.ToString());}}Ŀ=ò;}void Ě
(){ĳ.Clear();var W=ă.GetShipSpeed();var ě=((ņ-Ĺ)/(ĺ-Ĺ))*100f;var Ĝ=w();var ĝ=((int)Math.Floor(ě)).ToString();var Ğ=
$"{W:F0}m/s";var Á=µ();var Ę=string.Empty;if(İ){Ę="PIT LIMITER";}else{if(ı&&ń){Ę="DRAFTING (DRS)";}else if(ı){Ę="DRS ON";}else if(ń)
{Ę="DRAFTING";}}ĳ.AppendLine(Ğ+Á.PadLeft(16-Ğ.Length));ĳ.AppendLine(Ę);ĳ.AppendLine(
$"P:{Ĵ.æ:00}/{Ĵ.ç:00}  L:{(Ĵ.è):00}/{Ĵ.é:00}");ĳ.AppendLine($"TYRE ({Ĝ})..: {ĝ,3}%");ĳ.AppendLine($"TIME.: {Ĵ.ê}");ĳ.AppendLine($"BEST.: {Ĵ.ë}");ĳ.AppendLine(
$"<SUNNY> RoR: 50%");if(Ŀ<=0){ĳ.AppendLine($"NO CONNECTION");}var Ġ=ĳ.ToString();Ĕ?.WriteText(Ġ);foreach(var I in ā){var ġ=I.DrawFrame();
var Ģ=Color.Black;var ģ=DEFAULT_FONT_COLOR;switch(Ĵ.ì){case ĉ.ċ:Ģ=Color.Yellow;ģ=Color.Black;break;case ĉ.Č:Ģ=Color.Red;ģ=
Color.White;break;case ĉ.č:Ģ=Color.Blue;ģ=Color.White;break;}I.BackgroundColor=Ģ;I.ScriptBackgroundColor=Ģ;I.FontColor=ģ;var
Ĥ=MySprite.CreateText(Ġ,"Monospace",ģ,0.75f);Ĥ.Position=new Vector2(128,18);ġ.Add(Ĥ);var ĥ=MathHelper.Clamp(Math.Round(W/
(100f/15)),0,100);for(int Y=0;Y<ĥ;Y++){var Ħ=8f;var ħ=2f;var Ĩ=(256/2)-((15f*Ħ+14f*ħ)/2)+Ħ/2;var Ç=new Vector2(Ĩ+(Ħ+ħ)*Y,
Ħ+ħ);var ĩ=new Vector2(Ħ);var Ī=MySprite.CreateSprite("Circle",Ç,ĩ);if(Y<5){Ī.Color=Color.Lime;}else if(Y<10){Ī.Color=
Color.Red;}else{Ī.Color=Color.Blue;}ġ.Add(Ī);}ġ.Dispose();}}void ī(){if(!İ){foreach(var B in ÿ){B.Power=õ;B.SetValueFloat(
"Speed Limit",ö*3.6f);}return;}foreach(var B in ÿ){B.Power=20f;B.SetValueFloat("Speed Limit",26f*3.6f);}var W=ă.GetShipSpeed();ă.
HandBrake=W>24;}void U(){var X=ă.MoveIndicator.Z>0||ă.MoveIndicator.Y>0||ă.HandBrake;if(X||LEAGUE=="F2"){ı=false;}for(int Y=0;Y<ÿ
.Length;Y++){var B=ÿ[Y];B.Strength=!ı?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var N in ķ){N.Color=ı?Color.Blue:Color.
Black;N.Enabled=ı;}}void Z(){if(AUTO_ERS&&Ń==1){Ĳ=true;}if(İ){Ĳ=false;}var a=ă.MoveIndicator.Z<0;var W=ă.GetShipSpeed();if(W>
1){if(!Ĳ){var c=(float)MathHelper.Clamp(W/100,0,1);Ń+=(1f/120)*c*ł;}else if(a){var c=(float)MathHelper.Clamp(W/100,1,0);Ń
-=(1f/30)*c*ł;}}Ń=MathHelper.Clamp(Ń,0,1);if(Ń<=0){Ĳ=false;}foreach(var B in ÿ){B.Power=Ä();}var e=Ĳ&&a?ý:0;Ê(e);foreach(
var N in Ķ){N.Color=Ĳ?Color.Cyan:Color.Red;}}void f(){var W=ă.GetShipSpeed();if(W<1){return;}var r=(float)MathHelper.Clamp(
W,0,90)/90;var g=ļ*r*ł;ņ-=g;ņ=MathHelper.Clamp(ņ,Ĺ,ĺ);var h=ĸ==Ą.Ē||ĸ==Ą.ą||ĸ==Ą.Ć;foreach(var B in ÿ){B.Friction=!(h&&Ĵ.
í==Ď.Đ)?ņ:ņ/2;}if(ņ<=Ĺ){if(ÿ.All(B=>B.IsAttached)){var j=new Random().Next(4);ÿ[j].Detach();}}Ì();}void k(){if(Į==null){
return;}Į.HudText=$"P{Ĵ.æ}";}void m(){if(į==null){return;}var n=!į.Closed&&į.IsActive&&ă.GetShipSpeed()>=60;if(n){Ņ=ô;}if(İ){Ņ
=0;}ń=Ņ>0;foreach(var B in ÿ){B.Power=Ä();var o=Å();B.SetValueFloat("Speed Limit",o*3.6f);}Ņ-=(int)(ł*1000);}void p(){
foreach(var B in ĭ){}}void q(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}if(LEAGUE!="F1"&&LEAGUE!="F2"){throw new Exception("LEAGUE should be F1 or F2");}Me.CubeGrid.CustomName=
$"{LEAGUE} #{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void t(){var V=new List<IMyCockpit>();GridTerminalSystem.GetBlocksOfType(V);ă=V.FirstOrDefault();if(ă==null){throw new
Exception("No cockpit!");}}void A(){var T=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(T,B=>B.CubeGrid==Me.
CubeGrid);if(T==null||T.Count!=4){throw new Exception("Need 4 suspensions!");}var C=T.FirstOrDefault(B=>B.CustomName.Contains(
"FL"));if(C==null)throw new Exception("FL suspension not found.");var D=T.FirstOrDefault(B=>B.CustomName.Contains("FR"));if(
D==null)throw new Exception("FR suspension not found.");var E=T.FirstOrDefault(B=>B.CustomName.Contains("RL"));if(E==null
)throw new Exception("RL suspension not found.");var F=T.FirstOrDefault(B=>B.CustomName.Contains("RR"));if(F==null)throw
new Exception("RR suspension not found.");ÿ=new IMyMotorSuspension[4];È(đ.Ă,C);È(đ.ē,D);È(đ.Ā,E);È(đ.ä,F);}void G(){ĳ=new
StringBuilder();ā=new List<IMyTextSurface>{Me.GetSurface(0)};var H=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);
if(H!=null){ā.Add(H);}if(COCKPIT_DISPLAY_INDEX.HasValue){var I=ă.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(
I!=null){ā.Add(I);}}foreach(var I in ā){I.ContentType=ContentType.SCRIPT;I.Alignment=TextAlignment.CENTER;I.Font=
"Monospace";}var J=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(J!=null){J.ContentType=ContentType.
TEXT_AND_IMAGE;J.Alignment=TextAlignment.CENTER;J.Font="Monospace";Ĕ=J;}}void K(){var L=new List<IMyTerminalBlock>();
GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(L,M=>M.CubeGrid==Me.CubeGrid);ĵ=new List<IMyTerminalBlock>();
foreach(var N in L){if(N is IMyLightingBlock){var O=(IMyLightingBlock)N;O.Intensity=5f;O.BlinkLength=0f;O.BlinkIntervalSeconds=
0f;}else if(N is IMyTextPanel){var P=(IMyTextPanel)N;P.ContentType=ContentType.TEXT_AND_IMAGE;P.WriteText("",false);}ĵ.Add
(N);}}void Q(){ķ=new List<IMyLightingBlock>();var L=new List<IMyTerminalBlock>();var R=GridTerminalSystem.
GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(R==null){return;}R.GetBlocks(L,M=>M.CubeGrid==Me.CubeGrid);foreach(var N in L){var O=(
IMyLightingBlock)N;ķ.Add(O);}}void S(){Ķ=new List<IMyLightingBlock>();var L=new List<IMyTerminalBlock>();var R=GridTerminalSystem.
GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(R==null){return;}R.GetBlocks(L,M=>M.CubeGrid==Me.CubeGrid);foreach(var N in L){var O=(
IMyLightingBlock)N;O.Radius=4f;O.Intensity=10f;O.BlinkLength=50f;O.BlinkIntervalSeconds=0.5f;Ķ.Add(O);}}void Î(){var Ï=(IMySensorBlock)
GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(Ï==null){return;}į=Ï;į.TopExtend=50;į.BottomExtend=0;į.RightExtend=2.25f;į.
LeftExtend=2.25f;į.FrontExtend=0;į.BackExtend=2;į.DetectSmallShips=true;į.DetectLargeShips=false;į.DetectStations=false;į.
DetectSubgrids=false;į.DetectAsteroids=false;į.DetectPlayers=false;}void Ð(){ĭ=new List<IMySoundBlock>();GridTerminalSystem.
GetBlocksOfType(ĭ,M=>M.CubeGrid==Me.CubeGrid);}void Ñ(){if(string.IsNullOrWhiteSpace(Me.CustomData)){ß(Ą.Ē);return;}var Ò=Me.CustomData
.Split(';');if(Ò.Length<3){ß(Ą.Ē);return;}var Ó=Convert.ToChar(Ò[0]);var Ô=(float)Convert.ToDouble(Ò[1]);var Õ=(float)
Convert.ToDouble(Ò[2]);switch(Ó){case'S':ß(Ą.Ē);break;case'M':ß(Ą.ą);break;case'H':ß(Ą.Ć);break;case'I':ß(Ą.ć);break;case'W':ß(
Ą.Ĉ);break;default:ß(Ą.Ē);break;}ņ=Ô;Ń=Õ;}void Ö(){var Ø=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Ø
);var Ù=Ø.FirstOrDefault();if(Ù==null){return;}Ù.Enabled=true;Ù.Radius=5000;Ù.EnableBroadcasting=true;Ù.HudText=
$"(P{Ĵ.æ}) {DRIVER_NAME}-{DRIVER_NUMBER}";Į=Ù;}void Ú(){IGC.RegisterBroadcastListener("Address");var â=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners
(â);ľ=â.FirstOrDefault();}void Û(string Ü){if(Ü.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){İ=!İ;return;}
if(Ü.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){İ=true;return;}if(Ü.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){İ=false;return;}if(Ü.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){if(LEAGUE=="F1"){ı=!ı;}return;}if(Ü.
Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ĳ=!Ĳ;return;}if(Ü.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){Ý(Ą.Ē);return;}if(Ü.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Ý(Ą.ą);return;}if(Ü.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){Ý(Ą.Ć);return;}if(Ü.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){Ý(Ą.ć);
return;}if(Ü.Equals("WET",StringComparison.InvariantCultureIgnoreCase)){Ý(Ą.Ĉ);return;}if(Ü.Equals("FLAG_G",StringComparison.
InvariantCultureIgnoreCase)){Â(ĉ.Ċ);return;}if(Ü.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){Â(ĉ.ċ);return;}if(Ü.Equals("FLAG_R"
,StringComparison.InvariantCultureIgnoreCase)){Â(ĉ.Č);return;}}void Ý(Ą Þ){if(!İ||ă.GetShipSpeed()>1){return;}ß(Þ);Ì(true
);}void ß(Ą Þ){var à=Color.White;switch(Þ){case Ą.Ē:ĺ=100;Ĺ=33.33f;ļ=(ĺ-Ĺ)/(60*8);à=Color.Red;break;case Ą.ą:ĺ=75;Ĺ=
36.11f;ļ=(ĺ-Ĺ)/(60*13);à=Color.Yellow;break;case Ą.Ć:ĺ=60;Ĺ=37.78f;ļ=(ĺ-Ĺ)/(60*21);à=Color.White;break;case Ą.ć:ĺ=55;Ĺ=32.78f;
ļ=(ĺ-Ĺ)/(60*8);à=Color.Lime;break;case Ą.Ĉ:ĺ=40;Ĺ=34.44f;ļ=(ĺ-Ĺ)/(60*21);à=Color.Blue;break;default:break;}ņ=ĺ;ĸ=Þ;á(à);
foreach(var B in ÿ){B.ApplyAction("Add Top Part");}}void á(Color ª){foreach(var N in ĵ){if(N is IMyLightingBlock){var O=(
IMyLightingBlock)N;O.Color=ª;}else if(N is IMyTextPanel){var P=(IMyTextPanel)N;P.BackgroundColor=ª;}}}void ã(float Í){foreach(var B in ÿ
){B.SetValueFloat("Speed Limit",Í*3.6f);}}void Ì(bool u=false){ŀ-=(int)(ł*1000);if(!u&&ŀ>0){return;}var v=w();Me.
CustomData=$"{v};{ņ};{Ń}";ŀ=ó;}char w(){var v='S';switch(ĸ){case Ą.Ē:v='S';break;case Ą.ą:v='M';break;case Ą.Ć:v='H';break;case Ą.
ć:v='I';break;case Ą.Ĉ:v='W';break;}return v;}string x(){var y=string.Empty;switch(Ĵ.ì){case ĉ.č:y="Blue";break;case ĉ.Ċ:
y="Green";break;case ĉ.Č:y="Red";break;case ĉ.ċ:y="Yellow";break;}return y;}Color z(){var ª=Color.Black;switch(Ĵ.ì){case
ĉ.č:ª=Color.Blue;break;case ĉ.Ċ:ª=Color.Green;break;case ĉ.Č:ª=Color.Red;break;case ĉ.ċ:ª=Color.Yellow;break;}return ª;}
string µ(){const int º=6;var À=Ĳ?ù:Ń<1?ø:'-';var Á=À+"E:";for(int Y=0;Y<º;Y++){var c=1f/º;if(Ń>c*Y){if(Ń<c*(Y+1)){Á+=û;
continue;}Á+=ú;}else{Á+=ü;}}return Á;}void Â(ĉ Ã){if(Ľ<=0){return;}IGC.SendUnicastMessage(Ľ,"Flag",$"{(int)Ã}");}float Ä(){if(İ)
{return 20f;}if(ń||Ĳ){return 100f;}return õ;}float Å(){if(İ){return 26;}if(Ĵ.ì==ĉ.ċ){return 45;}if(ń){return 999;}return
ö;}IMyMotorSuspension Æ(đ Ç){return ÿ[(int)Ç];}void È(đ Ç,IMyMotorSuspension É){if(É==null){return;}ÿ[(int)Ç]=É;}void Ê(
float Ë){var C=Æ(đ.Ă);var D=Æ(đ.ē);var E=Æ(đ.Ā);var F=Æ(đ.ä);C.PropulsionOverride=Ë;D.PropulsionOverride=-Ë;E.
PropulsionOverride=Ë;F.PropulsionOverride=-Ë;}