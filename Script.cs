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

enum Ą{Ē,ą,Ć,ć,Ĉ}enum ĉ{Ċ,ċ,Č,č}enum Ď{ď,Đ}enum đ{ē,ă,Ă,ñ}class å{public int æ{get;set;}public int ç{get;set;}public int
è{get;set;}public int é{get;set;}public string ê{get;set;}="--:--.---";public string ë{get;set;}="--:--.---";public ĉ ì{
get;set;}public Ď í{get;set;}public int î{get;set;}public void ï(string ð){try{var Ò=ð.Split(';');è=Convert.ToInt32(Ò[0]);æ
=Convert.ToInt32(Ò[1]);ê=Ò[2];ë=Ò[3];ç=Convert.ToInt32(Ò[4]);é=Convert.ToInt32(Ò[5]);ì=(ĉ)Convert.ToInt32(Ò[6]);í=(Ď)
Convert.ToInt32(Ò[7]);î=Convert.ToInt32(Ò[8]);}catch(Exception){}}}string ò="10.0.2";const int ā=3000;const int ó=1000;const
int ô=1000;const float õ=80f;const float ö=96f;const char ø='\u2191';const char ù='\u2193';const char ú='\u2588';const char
û='\u2592';const char ü='\u2591';const float ý=1.7f;bool þ;IMyMotorSuspension[]ÿ;IMyCockpit Ā;List<IMyTextSurface>ä;
IMyTextSurface Ĕ;List<IMySoundBlock>ĕ;IMyRadioAntenna Į;IMySensorBlock į;bool İ;bool ı;bool Ĳ;StringBuilder ĳ;å Ĵ;List<
IMyTerminalBlock>ĵ;List<IMyLightingBlock>Ķ;List<IMyLightingBlock>ķ;List<IMyLightingBlock>ĸ;Ą Ĺ;float ĺ=0;float Ļ=100;float Ľ=1;float Ň=
100;long ľ=-1;IMyBroadcastListener Ŀ;int ŀ;int Ł;DateTime ł;float Ń;float ń=1f;bool Ņ=false;int ņ;Program(){Ĵ=new å();try{q
();t();U();G();S();R();P();Ö();Ñ();Û();Î();Ð();}catch(Exception ex){þ=true;Echo(ex.Message);return;}Runtime.
UpdateFrequency=UpdateFrequency.Update1;ł=DateTime.Now;}void Save(){}void Main(string Ý,UpdateType ň){if(þ){return;}var ļ=DateTime.Now;
Ń=(float)(ļ-ł).TotalMilliseconds/1000;Echo($"Running FSESS {ò}");Ü(Ý);T();X();ĭ();Ĭ();m();e();ė();ě();k();p();ł=ļ;}void ĭ
(){switch(Ĵ.ì){case ĉ.ċ:Ġ();break;case ĉ.Č:Ė();break;default:if(!İ){Ā.HandBrake=false;Ú(ö);}break;}}void Ġ(){ı=false;Ĳ=
false;Ā.HandBrake=Ā.GetShipSpeed()>50;Ú(50f);}void Ė(){ı=false;Ĳ=false;İ=false;Ā.HandBrake=true;}void ė(){var Ę=IGC.
UnicastListener;if(!Ę.HasPendingMessage){ŀ-=(int)(Ń*1000);if(Ŀ.HasPendingMessage&&ŀ<=0){var ę=Ŀ.AcceptMessage();if(ę.Tag=="Address"){ľ=
Convert.ToInt64(ę.Data.ToString());IGC.SendUnicastMessage(ľ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(Ę.
HasPendingMessage){var Ě=Ę.AcceptMessage();if(Ě.Tag=="RaceData"){Ĵ.ï(Ě.Data.ToString());}if(Ě.Tag=="Argument"){Ü(Ě.Data.ToString());}}ŀ=ā
;}void ě(){ĳ.Clear();var Z=Ā.GetShipSpeed();var Ĝ=((Ň-ĺ)/(Ļ-ĺ))*100f;var ĝ=x();var Ğ=((int)Math.Floor(Ĝ)).ToString();var
ğ=$"{Z:F0}m/s";var Â=º();var ę=string.Empty;if(İ){ę="PIT LIMITER";}else{if(ı&&Ņ){ę="DRAFTING (DRS)";}else if(ı){ę=
"DRS ON";}else if(Ņ){ę="DRAFTING";}}ĳ.AppendLine(ğ+Â.PadLeft(16-ğ.Length));ĳ.AppendLine(ę);ĳ.AppendLine(
$"P:{Ĵ.æ:00}/{Ĵ.ç:00}  L:{(Ĵ.è):00}/{Ĵ.é:00}");ĳ.AppendLine($"TYRE ({ĝ})..: {Ğ,3}%");ĳ.AppendLine($"TIME.: {Ĵ.ê}");ĳ.AppendLine($"BEST.: {Ĵ.ë}");ĳ.AppendLine(
$"<SUNNY> RoR: 50%");if(ŀ<=0){ĳ.AppendLine($"NO CONNECTION");}var ġ=ĳ.ToString();Ĕ?.WriteText(ġ);foreach(var I in ä){var Ģ=I.DrawFrame();
var ģ=Color.Black;var Ĥ=DEFAULT_FONT_COLOR;switch(Ĵ.ì){case ĉ.ċ:ģ=Color.Yellow;Ĥ=Color.Black;break;case ĉ.Č:ģ=Color.Red;Ĥ=
Color.White;break;case ĉ.č:ģ=Color.Blue;Ĥ=Color.White;break;}I.BackgroundColor=ģ;I.ScriptBackgroundColor=ģ;I.FontColor=Ĥ;var
ĥ=MySprite.CreateText(ġ,"Monospace",Ĥ,0.75f);ĥ.Position=new Vector2(128,18);Ģ.Add(ĥ);var Ħ=MathHelper.Clamp(Math.Round(Z/
(100f/15)),0,100);for(int W=0;W<Ħ;W++){var ħ=8f;var Ĩ=2f;var ĩ=(256/2)-((15f*ħ+14f*Ĩ)/2)+ħ/2;var È=new Vector2(ĩ+(ħ+Ĩ)*W,
ħ+Ĩ);var Ī=new Vector2(ħ);var ī=MySprite.CreateSprite("Circle",È,Ī);if(W<5){ī.Color=Color.Lime;}else if(W<10){ī.Color=
Color.Red;}else{ī.Color=Color.Blue;}Ģ.Add(ī);}Ģ.Dispose();}}void Ĭ(){if(!İ){foreach(var B in ÿ){B.Power=õ;B.SetValueFloat(
"Speed Limit",ö*3.6f);}return;}foreach(var B in ÿ){B.Power=20f;B.SetValueFloat("Speed Limit",26f*3.6f);}var Z=Ā.GetShipSpeed();Ā.
HandBrake=Z>24;}void T(){var V=Ā.MoveIndicator.Z>0||Ā.MoveIndicator.Y>0||Ā.HandBrake;if(V||LEAGUE=="F2"){ı=false;}for(int W=0;W<ÿ
.Length;W++){var B=ÿ[W];B.Strength=!ı?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var M in ķ){M.Color=ı?Color.Blue:Color.
Black;M.Enabled=ı;}}void X(){if(AUTO_ERS&&ń==1){Ĳ=true;}if(İ){Ĳ=false;}var Y=Ā.MoveIndicator.Z<0;var Z=Ā.GetShipSpeed();if(Z>
1){if(!Ĳ){var a=(float)MathHelper.Clamp(Z/100,0,1);ń+=(1f/120)*a*Ń;}else if(Y){var a=(float)MathHelper.Clamp(Z/100,1,0);ń
-=(1f/30)*a*Ń;}}ń=MathHelper.Clamp(ń,0,1);if(ń<=0){Ĳ=false;}foreach(var B in ÿ){B.Power=Å();}var c=Ĳ&&Y?ý:0;Ë(c);foreach(
var M in Ķ){M.Color=Ĳ?Color.Cyan:Color.Red;}}void e(){var Z=Ā.GetShipSpeed();if(Z<1){return;}var r=(float)MathHelper.Clamp(
Z,0,90)/90;var g=Ľ*r*Ń;Ň-=g;Ň=MathHelper.Clamp(Ň,ĺ,Ļ);var h=Ĺ==Ą.Ē||Ĺ==Ą.ą||Ĺ==Ą.Ć;foreach(var B in ÿ){B.Friction=!(h&&Ĵ.
í==Ď.Đ)?Ň:Ň/2;}if(Ň<=ĺ){if(ÿ.All(B=>B.IsAttached)){var j=new Random().Next(4);ÿ[j].Detach();}}u();}void k(){if(Į==null){
return;}Į.HudText=$"P{Ĵ.æ}";}void m(){if(į==null){return;}var n=!į.Closed&&į.IsActive&&Ā.GetShipSpeed()>=60;if(n){ņ=ô;}if(İ){ņ
=0;}Ņ=ņ>0;foreach(var B in ÿ){B.Power=Å();var o=Æ();B.SetValueFloat("Speed Limit",o*3.6f);}ņ-=(int)(Ń*1000);}void p(){
foreach(var B in ĕ){}}void q(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}if(LEAGUE!="F1"&&LEAGUE!="F2"){throw new Exception("LEAGUE should be F1 or F2");}Me.CubeGrid.CustomName=
$"{LEAGUE} #{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void t(){var f=new List<IMyCockpit>();GridTerminalSystem.GetBlocksOfType(f);Ā=f.FirstOrDefault();if(Ā==null){throw new
Exception("No cockpit!");}}void U(){var J=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(J,B=>B.CubeGrid==Me.
CubeGrid);if(J==null||J.Count!=4){throw new Exception("Need 4 suspensions!");}var C=J.FirstOrDefault(B=>B.CustomName.Contains(
"FL"));if(C==null)throw new Exception("FL suspension not found.");var D=J.FirstOrDefault(B=>B.CustomName.Contains("FR"));if(
D==null)throw new Exception("FR suspension not found.");var E=J.FirstOrDefault(B=>B.CustomName.Contains("RL"));if(E==null
)throw new Exception("RL suspension not found.");var F=J.FirstOrDefault(B=>B.CustomName.Contains("RR"));if(F==null)throw
new Exception("RR suspension not found.");ÿ=new IMyMotorSuspension[4];É(đ.ă,C);É(đ.ē,D);É(đ.ñ,E);É(đ.Ă,F);}void G(){ĳ=new
StringBuilder();ä=new List<IMyTextSurface>{Me.GetSurface(0)};var H=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);
if(H!=null){ä.Add(H);}if(COCKPIT_DISPLAY_INDEX.HasValue){var I=Ā.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(
I!=null){ä.Add(I);}}foreach(var I in ä){I.ContentType=ContentType.SCRIPT;I.Alignment=TextAlignment.CENTER;I.Font=
"Monospace";}var K=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(K!=null){K.ContentType=ContentType.
TEXT_AND_IMAGE;K.Alignment=TextAlignment.CENTER;K.Font="Monospace";Ĕ=K;}}void S(){var A=new List<IMyTerminalBlock>();
GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(A,L=>L.CubeGrid==Me.CubeGrid);if(A.Count<=0){throw new Exception
($"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}ĵ=new List<IMyTerminalBlock>();foreach(var M in A){if(M is
IMyLightingBlock){var N=(IMyLightingBlock)M;N.Intensity=5f;N.BlinkLength=0f;N.BlinkIntervalSeconds=0f;}else if(M is IMyTextPanel){var O=
(IMyTextPanel)M;O.ContentType=ContentType.TEXT_AND_IMAGE;O.WriteText("",false);}ĵ.Add(M);}ĸ=new List<IMyLightingBlock>();
GridTerminalSystem.GetBlocksOfType(ĸ,L=>L.CubeGrid!=Me.CubeGrid);}void P(){ķ=new List<IMyLightingBlock>();var A=new List<IMyTerminalBlock>
();var Q=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.GetBlocks(A,L=>L.CubeGrid
==Me.CubeGrid);foreach(var M in A){var N=(IMyLightingBlock)M;ķ.Add(N);}}void R(){Ķ=new List<IMyLightingBlock>();var A=new
List<IMyTerminalBlock>();var Q=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.
GetBlocks(A,L=>L.CubeGrid==Me.CubeGrid);foreach(var M in A){var N=(IMyLightingBlock)M;N.Radius=4f;N.Intensity=10f;N.BlinkLength=
50f;N.BlinkIntervalSeconds=0.5f;Ķ.Add(N);}}void Î(){var Ï=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(
DRAFTING_SENSOR_NAME);if(Ï==null){return;}į=Ï;į.TopExtend=50;į.BottomExtend=0;į.RightExtend=2.25f;į.LeftExtend=2.25f;į.FrontExtend=0;į.
BackExtend=2;į.DetectSmallShips=true;į.DetectLargeShips=false;į.DetectStations=false;į.DetectSubgrids=false;į.DetectAsteroids=
false;į.DetectPlayers=false;}void Ð(){ĕ=new List<IMySoundBlock>();GridTerminalSystem.GetBlocksOfType(ĕ,L=>L.CubeGrid==Me.
CubeGrid);}void Ñ(){if(string.IsNullOrWhiteSpace(Me.CustomData)){à(Ą.Ē);return;}var Ò=Me.CustomData.Split(';');if(Ò.Length<3){à(
Ą.Ē);return;}var Ó=Convert.ToChar(Ò[0]);var Ô=(float)Convert.ToDouble(Ò[1]);var Õ=(float)Convert.ToDouble(Ò[2]);switch(Ó)
{case'S':à(Ą.Ē);break;case'M':à(Ą.ą);break;case'H':à(Ą.Ć);break;case'I':à(Ą.ć);break;case'W':à(Ą.Ĉ);break;default:à(Ą.Ē);
break;}Ň=Ô;ń=Õ;}void Ö(){var Ø=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Ø);var Ù=Ø.FirstOrDefault();if(
Ù==null){return;}Ù.Enabled=true;Ù.Radius=5000;Ù.EnableBroadcasting=true;Ù.HudText=
$"(P{Ĵ.æ}) {DRIVER_NAME}-{DRIVER_NUMBER}";Į=Ù;}void Û(){IGC.RegisterBroadcastListener("Address");var ã=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners
(ã);Ŀ=ã.FirstOrDefault();}void Ü(string Ý){if(Ý.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){İ=!İ;return;}
if(Ý.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){İ=true;return;}if(Ý.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){İ=false;return;}if(Ý.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){if(LEAGUE=="F1"){ı=!ı;}return;}if(Ý.
Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ĳ=!Ĳ;return;}if(Ý.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){Þ(Ą.Ē);return;}if(Ý.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Þ(Ą.ą);return;}if(Ý.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){Þ(Ą.Ć);return;}if(Ý.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){Þ(Ą.ć);
return;}if(Ý.Equals("WET",StringComparison.InvariantCultureIgnoreCase)){Þ(Ą.Ĉ);return;}if(Ý.Equals("FLAG_G",StringComparison.
InvariantCultureIgnoreCase)){Ã(ĉ.Ċ);return;}if(Ý.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){Ã(ĉ.ċ);return;}if(Ý.Equals("FLAG_R"
,StringComparison.InvariantCultureIgnoreCase)){Ã(ĉ.Č);return;}}void Þ(Ą ß){if(!İ||Ā.GetShipSpeed()>1){return;}à(ß);u(true
);}void à(Ą ß){var á=Color.White;switch(ß){case Ą.Ē:Ļ=100;ĺ=33.33f;Ľ=(Ļ-ĺ)/(60*8);á=Color.Red;break;case Ą.ą:Ļ=75;ĺ=
36.11f;Ľ=(Ļ-ĺ)/(60*13);á=Color.Yellow;break;case Ą.Ć:Ļ=60;ĺ=37.78f;Ľ=(Ļ-ĺ)/(60*21);á=Color.White;break;case Ą.ć:Ļ=55;ĺ=32.78f;
Ľ=(Ļ-ĺ)/(60*8);á=Color.Lime;break;case Ą.Ĉ:Ļ=40;ĺ=34.44f;Ľ=(Ļ-ĺ)/(60*21);á=Color.Blue;break;default:break;}Ň=Ļ;Ĺ=ß;â(á);
foreach(var B in ÿ){B.ApplyAction("Add Top Part");}}void â(Color µ){foreach(var M in ĵ){if(M is IMyLightingBlock){var N=(
IMyLightingBlock)M;N.Color=µ;}else if(M is IMyTextPanel){var O=(IMyTextPanel)M;O.BackgroundColor=µ;}}foreach(var M in ĸ){M.Color=µ;}}
void Ú(float Í){foreach(var B in ÿ){B.SetValueFloat("Speed Limit",Í*3.6f);}}void u(bool v=false){Ł-=(int)(Ń*1000);if(!v&&Ł>0
){return;}var w=x();Me.CustomData=$"{w};{Ň};{ń}";Ł=ó;}char x(){var w='S';switch(Ĺ){case Ą.Ē:w='S';break;case Ą.ą:w='M';
break;case Ą.Ć:w='H';break;case Ą.ć:w='I';break;case Ą.Ĉ:w='W';break;}return w;}string y(){var z=string.Empty;switch(Ĵ.ì){
case ĉ.č:z="Blue";break;case ĉ.Ċ:z="Green";break;case ĉ.Č:z="Red";break;case ĉ.ċ:z="Yellow";break;}return z;}Color ª(){var µ
=Color.Black;switch(Ĵ.ì){case ĉ.č:µ=Color.Blue;break;case ĉ.Ċ:µ=Color.Green;break;case ĉ.Č:µ=Color.Red;break;case ĉ.ċ:µ=
Color.Yellow;break;}return µ;}string º(){const int À=6;var Á=Ĳ?ù:ń<1?ø:'-';var Â=Á+"E:";for(int W=0;W<À;W++){var a=1f/À;if(ń>
a*W){if(ń<a*(W+1)){Â+=û;continue;}Â+=ú;}else{Â+=ü;}}return Â;}void Ã(ĉ Ä){if(ľ<=0){return;}IGC.SendUnicastMessage(ľ,
"Flag",$"{(int)Ä}");}float Å(){if(İ){return 20f;}if(Ņ||Ĳ){return 100f;}return õ;}float Æ(){if(İ){return 26;}if(Ĵ.ì==ĉ.ċ){
return 45;}if(Ņ){return 999;}return ö;}IMyMotorSuspension Ç(đ È){return ÿ[(int)È];}void É(đ È,IMyMotorSuspension Ê){if(Ê==null
){return;}ÿ[(int)È]=Ê;}void Ë(float Ì){var C=Ç(đ.ă);var D=Ç(đ.ē);var E=Ç(đ.ñ);var F=Ç(đ.Ă);C.PropulsionOverride=Ì;D.
PropulsionOverride=-Ì;E.PropulsionOverride=Ì;F.PropulsionOverride=-Ì;}