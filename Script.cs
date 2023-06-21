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

enum ć{Ĉ,ĉ,Ċ,ċ,Č}enum č{Ď,ď,Đ,đ}enum Ē{ē,Ĕ}enum ĕ{Ė,Ę,Ć,ç}class ô{public int è{get;set;}public int é{get;set;}public int
ê{get;set;}public int ë{get;set;}public string ì{get;set;}="--:--.---";public string í{get;set;}="--:--.---";public č î{
get;set;}public Ē ï{get;set;}public int ð{get;set;}public void ñ(string ò){try{var Õ=ò.Split(';');ê=Convert.ToInt32(Õ[0]);è
=Convert.ToInt32(Õ[1]);ì=Õ[2];í=Õ[3];é=Convert.ToInt32(Õ[4]);ë=Convert.ToInt32(Õ[5]);î=(č)Convert.ToInt32(Õ[6]);ï=(Ē)
Convert.ToInt32(Õ[7]);ð=Convert.ToInt32(Õ[8]);}catch(Exception){}}}string ó="10.1.0";const int õ=3000;const int Ą=1000;const
int ö=1000;const float ø=80f;const float ù=96f;const char ú='\u2191';const char û='\u2193';const char ü='\u2588';const char
ý='\u2592';const char þ='\u2591';const float ÿ=1.7f;bool Ā;IMyMotorSuspension[]ā;IMyShipController Ă;List<IMyTextSurface>
ă;IMyTextSurface ė;List<IMySoundBlock>ę;IMyRadioAntenna ŋ;IMySensorBlock ı;bool Ĳ;bool ĳ;bool Ĵ;StringBuilder ĵ;ô Ķ;List<
IMyTerminalBlock>ķ;List<IMyLightingBlock>ĸ;List<IMyLightingBlock>Ĺ;List<IMyLightingBlock>ĺ;ć Ļ;float ļ=0;float Ľ=100;float ľ=1;float Ŀ=
100;long ŀ=-1;IMyBroadcastListener Ł;int ł;int Ń;DateTime ń;float Ņ;float ņ=1f;bool Ň=false;int ň;Program(){Ķ=new ô();try{q
();r();A();G();L();v();R();Ú();Ô();Ý();Ñ();Ó();}catch(Exception ex){Ā=true;Echo(ex.Message);return;}Runtime.
UpdateFrequency=UpdateFrequency.Update1;ń=DateTime.Now;}void Save(){}void Main(string à,UpdateType ŉ){if(Ā){return;}var Ŋ=DateTime.Now;
Ņ=(float)(Ŋ-ń).TotalMilliseconds/1000;Echo($"Running FSESS {ó}");ß(à);ą();W();Ō();Į();m();e();Ĥ();Ğ();k();p();ń=Ŋ;}void Ō
(){switch(Ķ.î){case č.ď:İ();break;case č.Đ:Ě();break;default:if(!Ĳ){Ă.HandBrake=false;Ð(ù);}break;}}void İ(){ĳ=false;Ĵ=
false;Ă.HandBrake=Ă.GetShipSpeed()>50;Ð(50f);}void Ě(){ĳ=false;Ĵ=false;Ĳ=false;Ă.HandBrake=true;}void Ĥ(){var ě=IGC.
UnicastListener;if(!ě.HasPendingMessage){ł-=(int)(Ņ*1000);if(Ł.HasPendingMessage&&ł<=0){var Ĝ=Ł.AcceptMessage();if(Ĝ.Tag=="Address"){ŀ=
Convert.ToInt64(Ĝ.Data.ToString());IGC.SendUnicastMessage(ŀ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ě.
HasPendingMessage){var ĝ=ě.AcceptMessage();if(ĝ.Tag=="RaceData"){Ķ.ñ(ĝ.Data.ToString());}if(ĝ.Tag=="Argument"){ß(ĝ.Data.ToString());}}ł=õ
;}void Ğ(){ĵ.Clear();var Y=Ă.GetShipSpeed();var ğ=((Ŀ-ļ)/(Ľ-ļ))*100f;var Ġ=ª();var ġ=((int)Math.Floor(ğ)).ToString();var
Ģ=$"{Y:F0}m/s";var Å=Â();var Ĝ=string.Empty;if(Ĳ){Ĝ="PIT LIMITER";}else{if(ĳ&&Ň){Ĝ="DRAFTING (DRS)";}else if(ĳ){Ĝ=
"DRS ON";}else if(Ň){Ĝ="DRAFTING";}}ĵ.AppendLine(Ģ+Å.PadLeft(16-Ģ.Length));ĵ.AppendLine(Ĝ);ĵ.AppendLine(
$"P:{Ķ.è:00}/{Ķ.é:00}  L:{(Ķ.ê):00}/{Ķ.ë:00}");ĵ.AppendLine($"TYRE ({Ġ})..: {ġ,3}%");ĵ.AppendLine($"TIME.: {Ķ.ì}");ĵ.AppendLine($"BEST.: {Ķ.í}");ĵ.AppendLine(
$"<SUNNY> RoR: 50%");if(ł<=0){ĵ.AppendLine($"NO CONNECTION");}var ģ=ĵ.ToString();ė?.WriteText(ģ);foreach(var J in ă){var ĥ=J.DrawFrame();
var į=Color.Black;var Ħ=DEFAULT_FONT_COLOR;switch(Ķ.î){case č.ď:į=Color.Yellow;Ħ=Color.Black;break;case č.Đ:į=Color.Red;Ħ=
Color.White;break;case č.đ:į=Color.Blue;Ħ=Color.White;break;}J.BackgroundColor=į;J.ScriptBackgroundColor=į;J.FontColor=Ħ;var
ħ=MySprite.CreateText(ģ,"Monospace",Ħ,0.75f);ħ.Position=new Vector2(128,18);ĥ.Add(ħ);var Ĩ=MathHelper.Clamp(Math.Round(Y/
(100f/15)),0,100);for(int U=0;U<Ĩ;U++){var ĩ=8f;var Ī=2f;var ī=(256/2)-((15f*ĩ+14f*Ī)/2)+ĩ/2;var Ë=new Vector2(ī+(ĩ+Ī)*U,
ĩ+Ī);var Ĭ=new Vector2(ĩ);var ĭ=MySprite.CreateSprite("Circle",Ë,Ĭ);if(U<5){ĭ.Color=Color.Lime;}else if(U<10){ĭ.Color=
Color.Red;}else{ĭ.Color=Color.Blue;}ĥ.Add(ĭ);}ĥ.Dispose();}}void Į(){if(!Ĳ){foreach(var B in ā){B.Power=ø;B.SetValueFloat(
"Speed Limit",ù*3.6f);}return;}foreach(var B in ā){B.Power=20f;B.SetValueFloat("Speed Limit",26f*3.6f);}var Y=Ă.GetShipSpeed();Ă.
HandBrake=Y>24;}void ą(){var æ=Ă.MoveIndicator.Z>0||Ă.MoveIndicator.Y>0||Ă.HandBrake;if(æ||LEAGUE=="F2"){ĳ=false;}for(int U=0;U<ā
.Length;U++){var B=ā[U];B.Strength=!ĳ?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var O in Ĺ){O.Color=ĳ?Color.Blue:Color.
Black;O.Enabled=ĳ;}}void W(){if(AUTO_ERS&&ņ==1){Ĵ=true;}if(Ĳ){Ĵ=false;}var X=Ă.MoveIndicator.Z<0;var Y=Ă.GetShipSpeed();if(Y
>=1){if(!Ĵ){var Z=(float)MathHelper.Clamp(Y/ù,0f,1f);ņ+=(1f/120)*Z*Ņ;}else if(X){var Z=1;ņ-=(1f/30)*Z*Ņ;}}ņ=MathHelper.
Clamp(ņ,0,1);if(ņ<=0){Ĵ=false;}foreach(var B in ā){B.Power=È();}var a=Ĵ&&X?ÿ:0;Î(a);foreach(var O in ĸ){O.Color=Ĵ?Color.Cyan:
Color.Black;}}void e(){var Y=Ă.GetShipSpeed();if(Y<1){return;}var f=(float)MathHelper.Clamp(Y,0,90)/90;var g=ľ*f*Ņ;Ŀ-=g;Ŀ=
MathHelper.Clamp(Ŀ,ļ,Ľ);var h=Ļ==ć.Ĉ||Ļ==ć.ĉ||Ļ==ć.Ċ;foreach(var B in ā){B.Friction=!(h&&Ķ.ï==Ē.Ĕ)?Ŀ:Ŀ/2;}if(Ŀ<=ļ){if(ā.All(B=>B.
IsAttached)){var j=new Random().Next(4);ā[j].Detach();}}x();}void k(){if(ŋ==null){return;}ŋ.HudText=$"P{Ķ.è}";}void m(){if(ı==null
){return;}var n=!ı.Closed&&ı.IsActive&&Ă.GetShipSpeed()>=60;if(n){ň=ö;}if(Ĳ){ň=0;}Ň=ň>0;foreach(var B in ā){B.Power=È();
var o=É();B.SetValueFloat("Speed Limit",o*3.6f);}ň-=(int)(Ņ*1000);}void p(){foreach(var B in ę){}}void q(){if(DRIVER_NUMBER
<=0&&DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");}if(LEAGUE!="F1"&&LEAGUE!="F2"){
throw new Exception("LEAGUE should be F1 or F2");}Me.CubeGrid.CustomName=$"{LEAGUE} #{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}
void r(){var t=new List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(t);var u=t.FirstOrDefault(V=>V is
IMyRemoteControl)??t.FirstOrDefault(V=>V is IMyCockpit);if(u==null){throw new Exception("No cockpit or remote control!");}Ă=u;}void A(){
var K=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(K,B=>B.CubeGrid==Me.CubeGrid);if(K==null||K.Count!=
4){throw new Exception("Need 4 suspensions!");}var C=K.FirstOrDefault(B=>B.CustomName.Contains("FL"));if(C==null)throw
new Exception("FL suspension not found.");var D=K.FirstOrDefault(B=>B.CustomName.Contains("FR"));if(D==null)throw new
Exception("FR suspension not found.");var E=K.FirstOrDefault(B=>B.CustomName.Contains("RL"));if(E==null)throw new Exception(
"RL suspension not found.");var F=K.FirstOrDefault(B=>B.CustomName.Contains("RR"));if(F==null)throw new Exception("RR suspension not found.");ā=
new IMyMotorSuspension[4];Ì(ĕ.Ę,C);Ì(ĕ.Ė,D);Ì(ĕ.ç,E);Ì(ĕ.Ć,F);}void G(){ĵ=new StringBuilder();ă=new List<IMyTextSurface>{Me
.GetSurface(0)};var H=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(H!=null){ă.Add(H);}if(
COCKPIT_DISPLAY_INDEX.HasValue){var I=Ă as IMyCockpit;if(I!=null){var J=I.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(J!=null){ă
.Add(J);}}}foreach(var J in ă){J.ContentType=ContentType.SCRIPT;J.Alignment=TextAlignment.CENTER;J.Font="Monospace";}var
T=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(T!=null){T.ContentType=ContentType.
TEXT_AND_IMAGE;T.Alignment=TextAlignment.CENTER;T.Font="Monospace";ė=T;}}void L(){var M=new List<IMyTerminalBlock>();
GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(M,N=>N.CubeGrid==Me.CubeGrid);if(M.Count<=0){throw new Exception
($"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}ķ=new List<IMyTerminalBlock>();foreach(var O in M){if(O is
IMyLightingBlock){var P=(IMyLightingBlock)O;P.Intensity=5f;P.BlinkLength=0f;P.BlinkIntervalSeconds=0f;}else if(O is IMyTextPanel){var Q=
(IMyTextPanel)O;Q.ContentType=ContentType.TEXT_AND_IMAGE;Q.WriteText("",false);}ķ.Add(O);}ĺ=new List<IMyLightingBlock>();
GridTerminalSystem.GetBlocksOfType(ĺ,N=>N.CubeGrid!=Me.CubeGrid);}void R(){Ĺ=new List<IMyLightingBlock>();var M=new List<IMyTerminalBlock>
();var S=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(S==null){return;}S.GetBlocks(M,N=>N.CubeGrid
==Me.CubeGrid);foreach(var O in M){var P=(IMyLightingBlock)O;Ĺ.Add(P);}}void v(){ĸ=new List<IMyLightingBlock>();var M=new
List<IMyTerminalBlock>();var S=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(S==null){return;}S.
GetBlocks(M,N=>N.CubeGrid==Me.CubeGrid);foreach(var O in M){var P=(IMyLightingBlock)O;P.Radius=4f;P.Intensity=10f;P.BlinkLength=
50f;P.BlinkIntervalSeconds=0.5f;ĸ.Add(P);}}void Ñ(){var Ò=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(
DRAFTING_SENSOR_NAME);if(Ò==null){return;}ı=Ò;ı.TopExtend=50;ı.BottomExtend=0;ı.RightExtend=2.25f;ı.LeftExtend=2.25f;ı.FrontExtend=0;ı.
BackExtend=2;ı.DetectSmallShips=true;ı.DetectLargeShips=false;ı.DetectStations=false;ı.DetectSubgrids=false;ı.DetectAsteroids=
false;ı.DetectPlayers=false;}void Ó(){ę=new List<IMySoundBlock>();GridTerminalSystem.GetBlocksOfType(ę,N=>N.CubeGrid==Me.
CubeGrid);}void Ô(){if(string.IsNullOrWhiteSpace(Me.CustomData)){ã(ć.Ĉ);return;}var Õ=Me.CustomData.Split(';');if(Õ.Length<3){ã(
ć.Ĉ);return;}var Ö=Convert.ToChar(Õ[0]);var Ø=(float)Convert.ToDouble(Õ[1]);var Ù=(float)Convert.ToDouble(Õ[2]);switch(Ö)
{case'S':ã(ć.Ĉ);break;case'M':ã(ć.ĉ);break;case'H':ã(ć.Ċ);break;case'I':ã(ć.ċ);break;case'W':ã(ć.Č);break;default:ã(ć.Ĉ);
break;}Ŀ=Ø;ņ=Ù;}void Ú(){var Û=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Û);var Ü=Û.FirstOrDefault();if(
Ü==null){throw new Exception("No antenna!");}Ü.Enabled=true;Ü.Radius=5000;Ü.EnableBroadcasting=true;Ü.HudText=
$"(P{Ķ.è}) {DRIVER_NAME}-{DRIVER_NUMBER}";ŋ=Ü;}void Ý(){IGC.RegisterBroadcastListener("Address");var Þ=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners
(Þ);Ł=Þ.FirstOrDefault();}void ß(string à){if(à.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){Ĳ=!Ĳ;return;}
if(à.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){Ĳ=true;return;}if(à.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){Ĳ=false;return;}if(à.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){if(LEAGUE=="F1"){ĳ=!ĳ;}return;}if(à.
Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ĵ=!Ĵ;return;}if(à.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){á(ć.Ĉ);return;}if(à.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){á(ć.ĉ);return;}if(à.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){á(ć.Ċ);return;}if(à.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){á(ć.ċ);
return;}if(à.Equals("WET",StringComparison.InvariantCultureIgnoreCase)){á(ć.Č);return;}if(à.Equals("FLAG_G",StringComparison.
InvariantCultureIgnoreCase)){Æ(č.Ď);return;}if(à.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){Æ(č.ď);return;}if(à.Equals("FLAG_R"
,StringComparison.InvariantCultureIgnoreCase)){Æ(č.Đ);return;}}void á(ć â){if(!Ĳ||Ă.GetShipSpeed()>1){return;}ã(â);x(true
);}void ã(ć â){var ä=Color.White;switch(â){case ć.Ĉ:Ľ=100;ļ=33.33f;ľ=(Ľ-ļ)/(60*8);ä=Color.Red;break;case ć.ĉ:Ľ=75;ļ=
36.11f;ľ=(Ľ-ļ)/(60*13);ä=Color.Yellow;break;case ć.Ċ:Ľ=60;ļ=37.78f;ľ=(Ľ-ļ)/(60*21);ä=Color.White;break;case ć.ċ:Ľ=55;ļ=38.33f;
ľ=(Ľ-ļ)/(60*8);ä=Color.Lime;break;case ć.Č:Ľ=45;ļ=39.44f;ľ=(Ľ-ļ)/(60*21);ä=Color.Blue;break;default:break;}Ŀ=Ľ;Ļ=â;å(ä);
foreach(var B in ā){B.ApplyAction("Add Top Part");}}void å(Color Á){foreach(var O in ķ){if(O is IMyLightingBlock){var P=(
IMyLightingBlock)O;P.Color=Á;}else if(O is IMyTextPanel){var Q=(IMyTextPanel)O;Q.BackgroundColor=Á;}}foreach(var O in ĺ){O.Color=Á;}}
void Ð(float w){foreach(var B in ā){B.SetValueFloat("Speed Limit",w*3.6f);}}void x(bool y=false){Ń-=(int)(Ņ*1000);if(!y&&Ń>0
){return;}var z=ª();Me.CustomData=$"{z};{Ŀ};{ņ}";Ń=Ą;}char ª(){var z='S';switch(Ļ){case ć.Ĉ:z='S';break;case ć.ĉ:z='M';
break;case ć.Ċ:z='H';break;case ć.ċ:z='I';break;case ć.Č:z='W';break;}return z;}string µ(){var º=string.Empty;switch(Ķ.î){
case č.đ:º="Blue";break;case č.Ď:º="Green";break;case č.Đ:º="Red";break;case č.ď:º="Yellow";break;}return º;}Color À(){var Á
=Color.Black;switch(Ķ.î){case č.đ:Á=Color.Blue;break;case č.Ď:Á=Color.Green;break;case č.Đ:Á=Color.Red;break;case č.ď:Á=
Color.Yellow;break;}return Á;}string Â(){const int Ã=6;var Ä=Ĵ?û:ņ<1?ú:'-';var Å=Ä+"E:";for(int U=0;U<Ã;U++){var Z=1f/Ã;if(ņ>
Z*U){if(ņ<Z*(U+1)){Å+=ý;continue;}Å+=ü;}else{Å+=þ;}}return Å;}void Æ(č Ç){if(ŀ<=0){return;}IGC.SendUnicastMessage(ŀ,
"Flag",$"{(int)Ç}");}float È(){if(Ĳ){return 20f;}if(Ň||Ĵ){return 100f;}return ø;}float É(){if(Ĳ){return 26;}if(Ķ.î==č.ď){
return 45;}if(Ň){return 999;}return ù;}IMyMotorSuspension Ê(ĕ Ë){return ā[(int)Ë];}void Ì(ĕ Ë,IMyMotorSuspension Í){if(Í==null
){return;}ā[(int)Ë]=Í;}void Î(float Ï){var C=Ê(ĕ.Ę);var D=Ê(ĕ.Ė);var E=Ê(ĕ.ç);var F=Ê(ĕ.Ć);C.PropulsionOverride=Ï;D.
PropulsionOverride=-Ï;E.PropulsionOverride=Ï;F.PropulsionOverride=-Ï;}