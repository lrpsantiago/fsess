private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 20f;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private const string TEXT_DISPLAY_NAME = "Text LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string RANK_DISPLAY_NAME = "Rank LCD";                    //Optional Text-Based LCD, for HudLcd Plugin

enum Ċ{ċ,Č,č,Ď,ď}enum Đ{đ,Ē,ē,Ĕ}enum ĕ{Ė,ė}enum Ę{ę,Ě,Ĝ,ě}class ĉ{public int ć{get;set;}public int ê{get;set;}public int
ë{get;set;}public int ì{get;set;}public string í{get;set;}="--:--.---";public string î{get;set;}="--:--.---";public Đ ï{
get;set;}public ĕ ð{get;set;}public int ñ{get;set;}public int ò{get;set;}public string ó{get;set;}public void ô(string õ){
try{var Ø=õ.Split(';');ë=Convert.ToInt32(Ø[0]);ć=Convert.ToInt32(Ø[1]);í=Ø[2];î=Ø[3];ê=Convert.ToInt32(Ø[4]);ì=Convert.
ToInt32(Ø[5]);ï=(Đ)Convert.ToInt32(Ø[6]);ð=(ĕ)Convert.ToInt32(Ø[7]);ñ=Convert.ToInt32(Ø[8]);ò=Convert.ToInt32(Ø[9]);ó=Ø[10];}
catch(Exception){}}}string ö="11.0.0";const int ø=3000;const int ù=1000;const int ú=1200;const float û=80f;const float ü=96f;
const char ý='\u2191';const char þ='\u2193';const char ÿ='\u2588';const char Ā='\u2592';const char ā='\u2591';const float Ă=
1.7f;bool ă;IMyMotorSuspension[]Ą;IMyShipController ą;List<IMyTextSurface>Ć;IMyTextSurface é;IMyTextSurface Ĉ;List<
IMySoundBlock>ĝ;IMyRadioAntenna ĸ;IMySensorBlock Ĺ;bool ĺ;bool Ļ;bool ļ;StringBuilder Ľ;ĉ ľ;List<IMyTerminalBlock>Ŀ;List<
IMyLightingBlock>ŀ;List<IMyLightingBlock>Ł;List<IMyLightingBlock>ł;Ċ Ń;float ń=0;float Ņ=100;float ņ=1;float Ň=100;long Œ=-1;
IMyBroadcastListener ň;int ŉ;int Ŋ;DateTime ŋ;float Ō;float ō=1f;bool Ŏ=false;int ŏ;Program(){ľ=new ĉ();try{t();u();B();I();O();x();T();Ü();
Ö();ß();Ó();Õ();}catch(Exception ex){ă=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.Update1;ŋ=
DateTime.Now;}void Save(){}void Main(string â,UpdateType Ő){if(ă){return;}var ő=DateTime.Now;Ō=(float)(ő-ŋ).TotalMilliseconds/
1000;Echo($"Running FSESS {ö}");á(â);Ý();Y();œ();ĵ();o();g();Ķ();Ģ();n();r();ŋ=ő;}void œ(){switch(ľ.ï){case Đ.Ē:ķ();break;
case Đ.ē:Ğ();break;default:if(!ĺ){ą.HandBrake=false;y(ü);}break;}}void ķ(){Ļ=false;ļ=false;ą.HandBrake=ą.GetShipSpeed()>50;y
(50f);}void Ğ(){Ļ=false;ļ=false;ĺ=false;ą.HandBrake=true;}void Ķ(){var ğ=IGC.UnicastListener;if(!ğ.HasPendingMessage){ŉ-=
(int)(Ō*1000);if(ň.HasPendingMessage&&ŉ<=0){var Ġ=ň.AcceptMessage();if(Ġ.Tag=="Address"){Œ=Convert.ToInt64(Ġ.Data.
ToString());IGC.SendUnicastMessage(Œ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ğ.HasPendingMessage){var ġ
=ğ.AcceptMessage();if(ġ.Tag=="RaceData"){ľ.ô(ġ.Data.ToString());}if(ġ.Tag=="Argument"){á(ġ.Data.ToString());}}ŉ=ø;}void Ģ
(){Ľ.Clear();var a=ą.GetShipSpeed();var ģ=((Ň-ń)/(Ņ-ń))*100f;var Ĥ=º();var ĥ=((int)Math.Floor(ģ)).ToString();var Ħ=
$"{a:F0}m/s";var Ç=Ä();var ħ=ľ.ð==ĕ.Ė?"<CLEAR>":"<RAIN>";var Ĩ=$"RoR: {ľ.ñ}%";var ĩ=ľ.ò<=0?$"{ħ} {Ĩ.PadLeft(15-ħ.Length)}":
$"<RAIN IN {ľ.ò}s>";var Ġ=string.Empty;if(ĺ){Ġ="PIT LIMITER";}else{if(Ļ&&Ŏ){Ġ="DRAFTING (DRS)";}else if(Ļ){Ġ="DRS ON";}else if(Ŏ){Ġ=
"DRAFTING";}}Ľ.AppendLine(Ħ+Ç.PadLeft(16-Ħ.Length));Ľ.AppendLine(Ġ);Ľ.AppendLine($"P:{ľ.ć:00}/{ľ.ê:00}  L:{(ľ.ë):00}/{ľ.ì:00}");Ľ.
AppendLine($"TYRE ({Ĥ})..: {ĥ,3}%");Ľ.AppendLine($"TIME.: {ľ.í}");Ľ.AppendLine($"BEST.: {ľ.î}");Ľ.AppendLine(ĩ);if(ŉ<=0){Ľ.
AppendLine($"NO CONNECTION");}var Ī=Ľ.ToString();é?.WriteText(Ī);foreach(var L in Ć){var ī=L.DrawFrame();var Ĭ=Color.Black;var ĭ=
DEFAULT_FONT_COLOR;switch(ľ.ï){case Đ.Ē:Ĭ=Color.Yellow;ĭ=Color.Black;break;case Đ.ē:Ĭ=Color.Red;ĭ=Color.White;break;case Đ.Ĕ:Ĭ=Color.Blue;
ĭ=Color.White;break;}L.BackgroundColor=Ĭ;L.ScriptBackgroundColor=Ĭ;L.FontColor=ĭ;var Į=MySprite.CreateText(Ī,"Monospace",
ĭ,0.75f);Į.Position=new Vector2(128,18);ī.Add(Į);var į=MathHelper.Clamp(Math.Round(a/(100f/15)),0,100);for(int X=0;X<į;X
++){var İ=8f;var ı=2f;var Ĳ=(256/2)-((15f*İ+14f*ı)/2)+İ/2;var Í=new Vector2(Ĳ+(İ+ı)*X,İ+ı);var ĳ=new Vector2(İ);var Ĵ=
MySprite.CreateSprite("Circle",Í,ĳ);if(X<5){Ĵ.Color=Color.Lime;}else if(X<10){Ĵ.Color=Color.Red;}else{Ĵ.Color=Color.Blue;}ī.Add(
Ĵ);}ī.Dispose();}if(Ĉ!=null&&ľ!=null&&ľ.ó!=null){Ĉ.WriteText(ľ.ó);}}void ĵ(){if(!ĺ){foreach(var D in Ą){D.Power=û;D.
SetValueFloat("Speed Limit",ü*3.6f);}return;}foreach(var D in Ą){D.Power=20f;D.SetValueFloat("Speed Limit",26f*3.6f);}var a=ą.
GetShipSpeed();ą.HandBrake=a>24;}void Ý(){var W=ą.MoveIndicator.Z>0||ą.MoveIndicator.Y>0||ą.HandBrake;if(W){Ļ=false;}for(int X=0;X<Ą
.Length;X++){var D=Ą[X];D.Strength=!Ļ?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var A in Ł){A.Color=Ļ?Color.Blue:Color.
Black;A.Enabled=Ļ;}}void Y(){if(ĺ){ļ=false;}var Z=ą.MoveIndicator.Z<0;var a=ą.GetShipSpeed();if(a>=1){if(!ļ){var e=(float)
MathHelper.Clamp(a/ü,0f,1f);ō+=(1f/120)*e*Ō;}else if(Z){var e=1;ō-=(1f/30)*e*Ō;}}ō=MathHelper.Clamp(ō,0,1);if(ō<=0){ļ=false;}
foreach(var D in Ą){D.Power=Ê();}var f=ļ&&Z?Ă:0;Ð(f);foreach(var A in ŀ){A.Color=ļ?Color.Cyan:Color.Black;}}void g(){var a=ą.
GetShipSpeed();if(a<1){return;}var h=(float)MathHelper.Clamp(a,0,90)/90;var j=ņ*h*Ō;Ň-=j;Ň=MathHelper.Clamp(Ň,ń,Ņ);var k=Ń==Ċ.ċ||Ń==
Ċ.Č||Ń==Ċ.č;foreach(var D in Ą){D.Friction=!(k&&ľ.ð==ĕ.ė)?Ň:Ň/2;}if(Ň<=ń){if(Ą.All(D=>D.IsAttached)){var m=new Random().
Next(4);Ą[m].Detach();}}z();}void n(){if(ĸ==null){return;}ĸ.HudText=$"P{ľ.ć}";}void o(){if(Ĺ==null){return;}var p=!Ĺ.Closed
&&Ĺ.IsActive&&ą.GetShipSpeed()>=70;if(p){ŏ=ú;}if(ĺ){ŏ=0;}Ŏ=ŏ>0;foreach(var D in Ą){D.Power=Ê();var q=Ë();D.SetValueFloat(
"Speed Limit",q*3.6f);}ŏ-=(int)(Ō*1000);}void r(){foreach(var D in ĝ){}}void t(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new
Exception("DRIVER_NUMBER should be between 1 and 99");}Me.CubeGrid.CustomName=$"#{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void u
(){var w=new List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(w);var v=w.FirstOrDefault(V=>V is
IMyRemoteControl)??w.FirstOrDefault(V=>V is IMyCockpit);if(v==null){throw new Exception("No cockpit or remote control!");}ą=v;}void B(){
var C=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(C,D=>D.CubeGrid==Me.CubeGrid);if(C==null||C.Count!=
4){throw new Exception("Need 4 suspensions!");}var E=C.FirstOrDefault(D=>D.CustomName.Contains("FL"));if(E==null)throw
new Exception("FL suspension not found.");var F=C.FirstOrDefault(D=>D.CustomName.Contains("FR"));if(F==null)throw new
Exception("FR suspension not found.");var G=C.FirstOrDefault(D=>D.CustomName.Contains("RL"));if(G==null)throw new Exception(
"RL suspension not found.");var H=C.FirstOrDefault(D=>D.CustomName.Contains("RR"));if(H==null)throw new Exception("RR suspension not found.");Ą=
new IMyMotorSuspension[4];Î(Ę.Ě,E);Î(Ę.ę,F);Î(Ę.ě,G);Î(Ę.Ĝ,H);}void I(){Ľ=new StringBuilder();Ć=new List<IMyTextSurface>{Me
.GetSurface(0)};var J=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(J!=null){Ć.Add(J);}if(
COCKPIT_DISPLAY_INDEX.HasValue){var K=ą as IMyCockpit;if(K!=null){var L=K.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(L!=null){Ć
.Add(L);}}}foreach(var L in Ć){L.ContentType=ContentType.SCRIPT;L.Alignment=TextAlignment.CENTER;L.Font="Monospace";}var
M=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(M!=null){M.WriteText(string.Empty);M.
ContentType=ContentType.TEXT_AND_IMAGE;M.Alignment=TextAlignment.CENTER;M.Font="Monospace";((IMyTerminalBlock)M).CustomData=
"hudlcd:-0.97:-0.28:0.9:White:1";é=M;}var N=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(N!=null){N.WriteText(string.Empty)
;N.ContentType=ContentType.TEXT_AND_IMAGE;N.Alignment=TextAlignment.CENTER;N.Font="Monospace";((IMyTerminalBlock)N).
CustomData="hudlcd:0.45:0.9:1:White:1";Ĉ=N;}}void O(){var P=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocks(P,Q=>Q.CubeGrid==Me.CubeGrid);if(P.Count<=0){throw new Exception(
$"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}Ŀ=new List<IMyTerminalBlock>();foreach(var A in P){if(A is IMyLightingBlock){var R=(IMyLightingBlock)A;R.Intensity=5f
;R.BlinkLength=0f;R.BlinkIntervalSeconds=0f;}else if(A is IMyTextPanel){var S=(IMyTextPanel)A;S.ContentType=ContentType.
TEXT_AND_IMAGE;S.WriteText("",false);}Ŀ.Add(A);}ł=new List<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(ł,Q=>Q.CubeGrid!=Me.
CubeGrid);}void T(){Ł=new List<IMyLightingBlock>();var P=new List<IMyTerminalBlock>();var U=GridTerminalSystem.
GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(U==null){return;}U.GetBlocks(P,Q=>Q.CubeGrid==Me.CubeGrid);foreach(var A in P){var R=(
IMyLightingBlock)A;Ł.Add(R);}}void x(){ŀ=new List<IMyLightingBlock>();var P=new List<IMyTerminalBlock>();var U=GridTerminalSystem.
GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(U==null){return;}U.GetBlocks(P,Q=>Q.CubeGrid==Me.CubeGrid);foreach(var A in P){var R=(
IMyLightingBlock)A;R.Radius=4f;R.Intensity=10f;R.BlinkLength=50f;R.BlinkIntervalSeconds=0.5f;ŀ.Add(R);}}void Ó(){var Ô=(IMySensorBlock)
GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(Ô==null){return;}Ĺ=Ô;Ĺ.TopExtend=50;Ĺ.BottomExtend=0;Ĺ.RightExtend=2.25f;Ĺ.
LeftExtend=2.25f;Ĺ.FrontExtend=0;Ĺ.BackExtend=2;Ĺ.DetectSmallShips=true;Ĺ.DetectLargeShips=false;Ĺ.DetectStations=false;Ĺ.
DetectSubgrids=false;Ĺ.DetectAsteroids=false;Ĺ.DetectPlayers=false;}void Õ(){ĝ=new List<IMySoundBlock>();GridTerminalSystem.
GetBlocksOfType(ĝ,Q=>Q.CubeGrid==Me.CubeGrid);}void Ö(){if(string.IsNullOrWhiteSpace(Me.CustomData)){å(Ċ.ċ);return;}var Ø=Me.CustomData
.Split(';');if(Ø.Length<3){å(Ċ.ċ);return;}var Ù=Convert.ToChar(Ø[0]);var Ú=(float)Convert.ToDouble(Ø[1]);var Û=(float)
Convert.ToDouble(Ø[2]);switch(Ù){case'S':å(Ċ.ċ);break;case'M':å(Ċ.Č);break;case'H':å(Ċ.č);break;case'I':å(Ċ.Ď);break;case'W':å(
Ċ.ď);break;default:å(Ċ.ċ);break;}Ň=Ú;ō=Û;}void Ü(){var Þ=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Þ
);var è=Þ.FirstOrDefault();if(è==null){throw new Exception("No antenna!");}è.Enabled=true;è.Radius=5000;è.
EnableBroadcasting=true;è.HudText=$"(P{ľ.ć}) {DRIVER_NAME}-{DRIVER_NUMBER}";ĸ=è;}void ß(){IGC.RegisterBroadcastListener("Address");var à=
new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(à);ň=à.FirstOrDefault();}void á(string â){if(â.Equals("LMT",
StringComparison.InvariantCultureIgnoreCase)){ĺ=!ĺ;return;}if(â.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){ĺ=true;
return;}if(â.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){ĺ=false;return;}if(â.Equals("DRS",StringComparison
.InvariantCultureIgnoreCase)){Ļ=!Ļ;return;}if(â.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){ļ=!ļ;return;}
if(â.Equals("SOFT",StringComparison.InvariantCultureIgnoreCase)){ã(Ċ.ċ);return;}if(â.Equals("MEDIUM",StringComparison.
InvariantCultureIgnoreCase)){ã(Ċ.Č);return;}if(â.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){ã(Ċ.č);return;}if(â.Equals("INT",
StringComparison.InvariantCultureIgnoreCase)){ã(Ċ.Ď);return;}if(â.Equals("WET",StringComparison.InvariantCultureIgnoreCase)){ã(Ċ.ď);
return;}if(â.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){È(Đ.đ);return;}if(â.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){È(Đ.Ē);return;}if(â.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){È(Đ.ē);
return;}}void ã(Ċ ä){if(!ĺ||ą.GetShipSpeed()>1){return;}å(ä);z(true);}void å(Ċ ä){var æ=Color.White;switch(ä){case Ċ.ċ:Ņ=100;ń
=33.33f;ņ=(Ņ-ń)/(60*8);æ=Color.Red;break;case Ċ.Č:Ņ=75;ń=36.11f;ņ=(Ņ-ń)/(60*13);æ=Color.Yellow;break;case Ċ.č:Ņ=60;ń=
37.78f;ņ=(Ņ-ń)/(60*21);æ=Color.White;break;case Ċ.Ď:Ņ=55;ń=38.33f;ņ=(Ņ-ń)/(60*8);æ=Color.Lime;break;case Ċ.ď:Ņ=45;ń=39.44f;ņ=(
Ņ-ń)/(60*21);æ=Color.Blue;break;default:break;}Ň=Ņ;Ń=ä;ç(æ);foreach(var D in Ą){D.ApplyAction("Add Top Part");}}void ç(
Color Ã){foreach(var A in Ŀ){if(A is IMyLightingBlock){var R=(IMyLightingBlock)A;R.Color=Ã;}else if(A is IMyTextPanel){var S=
(IMyTextPanel)A;S.BackgroundColor=Ã;}}foreach(var A in ł){if(A.IsSameConstructAs(Me)){A.Color=Ã;}}}void y(float Ò){
foreach(var D in Ą){D.SetValueFloat("Speed Limit",Ò*3.6f);}}void z(bool ª=false){Ŋ-=(int)(Ō*1000);if(!ª&&Ŋ>0){return;}var µ=º()
;Me.CustomData=$"{µ};{Ň};{ō}";Ŋ=ù;}char º(){var µ='S';switch(Ń){case Ċ.ċ:µ='S';break;case Ċ.Č:µ='M';break;case Ċ.č:µ='H';
break;case Ċ.Ď:µ='I';break;case Ċ.ď:µ='W';break;}return µ;}string À(){var Á=string.Empty;switch(ľ.ï){case Đ.Ĕ:Á="Blue";break;
case Đ.đ:Á="Green";break;case Đ.ē:Á="Red";break;case Đ.Ē:Á="Yellow";break;}return Á;}Color Â(){var Ã=Color.Black;switch(ľ.ï)
{case Đ.Ĕ:Ã=Color.Blue;break;case Đ.đ:Ã=Color.Green;break;case Đ.ē:Ã=Color.Red;break;case Đ.Ē:Ã=Color.Yellow;break;}
return Ã;}string Ä(){const int Å=6;var Æ=ļ?þ:ō<1?ý:'-';var Ç=Æ+"E:";for(int X=0;X<Å;X++){var e=1f/Å;if(ō>e*X){if(ō<e*(X+1)){Ç
+=Ā;continue;}Ç+=ÿ;}else{Ç+=ā;}}return Ç;}void È(Đ É){if(Œ<=0){return;}IGC.SendUnicastMessage(Œ,"Flag",$"{(int)É}");}float
Ê(){if(ĺ){return 20f;}if(Ŏ||ļ){return 100f;}return û;}float Ë(){if(ĺ){return 26;}if(ľ.ï==Đ.Ē){return 45;}if(Ŏ){return 999
;}return ü;}IMyMotorSuspension Ì(Ę Í){return Ą[(int)Í];}void Î(Ę Í,IMyMotorSuspension Ï){if(Ï==null){return;}Ą[(int)Í]=Ï;
}void Ð(float Ñ){var E=Ì(Ę.Ě);var F=Ì(Ę.ę);var G=Ì(Ę.ě);var H=Ì(Ę.Ĝ);E.PropulsionOverride=Ñ;F.PropulsionOverride=-Ñ;G.
PropulsionOverride=Ñ;H.PropulsionOverride=-Ñ;}