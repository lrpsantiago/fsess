private readonly string TEAM_TAG = "XXX";                               //Your Team Tag (3 chracters), if you are not in a team yet, keep this as it is.
private readonly string DRIVER_NAME = "Guest";                          //Your name
private readonly int DRIVER_NUMBER = 99;                                //Your number (0-99)
private const float DEFAULT_SUSPENSION_STRENGTH_F = 20f;                //Setup your default suspensions strength
private const float DEFAULT_SUSPENSION_STRENGTH_R = 20f;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private const string TEXT_DISPLAY_NAME = "Text LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string RANK_DISPLAY_NAME = "Rank LCD";                    //Optional Text-Based LCD, for HudLcd Plugin

enum Ħ{ħ,ĥ,Ĩ,Ļ,Ĺ,ĸ,ķ}enum Ķ{ĵ,Ĵ,ĳ,ĺ}enum Ĳ{İ,į}enum Į{ĭ,Ĭ,ī,Ī}class ĩ{public int ı{get;set;}public int Ĥ{get;set;}public
int Ě{get;set;}public int đ{get;set;}public string Đ{get;set;}="--:--.---";public string ď{get;set;}="--:--.---";public Ķ Ď
{get;set;}public Ĳ č{get;set;}public int Č{get;set;}public int ċ{get;set;}public string Ċ{get;set;}public void ĉ(string Ĉ
){try{var ú=Ĉ.Split(';');Ě=Convert.ToInt32(ú[0]);ı=Convert.ToInt32(ú[1]);Đ=ú[2];ď=ú[3];Ĥ=Convert.ToInt32(ú[4]);đ=Convert.
ToInt32(ú[5]);Ď=(Ķ)Convert.ToInt32(ú[6]);č=(Ĳ)Convert.ToInt32(ú[7]);Č=Convert.ToInt32(ú[8]);ċ=Convert.ToInt32(ú[9]);Ċ=ú[10];}
catch(Exception){}}}class ć{private float Ć;public char ą{get;private set;}public float Ą{get;set;}public float Ē{get;private
set;}public float ă{get;private set;}public float Ĕ{get;private set;}public float ģ{get;private set;}public float ġ{get{
return((Ą-ă)/(Ē-ă))*100f;}}public int Ġ{get;private set;}public bool ğ{get;private set;}public Color Ğ{get;private set;}
private ć(float ĝ,int Ĝ,float Ģ,float ě,char ę,Color Ø,bool Ę=true){Ē=ĝ;Ą=Ē;Ġ=Ĝ;Ĕ=Ģ;ģ=ě;ă=(float)Math.Round(Ĕ-((Ē-Ĕ)/(100-ģ))*ģ
,2);ą=ę;Ğ=Ø;ğ=Ę;Ć=(Ē-ă)/(60*Ġ);}public void ė(IMyShipController Ė,IMyMotorSuspension[]Z,List<IMyLightingBlock>ĕ,List<
IMyLightingBlock>ē,ĩ Ĉ,float ō){var O=Ė.GetShipSpeed();if(O<1){return;}var ţ=(float)MathHelper.Clamp(O,0,90)/90;var Ţ=Ć*ţ*ō;Ą-=Ţ;Ą=
MathHelper.Clamp(Ą,ă,Ē);foreach(var E in Z){E.Friction=!(ğ&&Ĉ.č==Ĳ.į)?Ą:Ą/2;}if(ġ<=ģ){if(ē.Any(L=>L.BlinkIntervalSeconds<=0)){
foreach(var L in ĕ){L.BlinkIntervalSeconds=0.25f;}foreach(var L in ē){L.BlinkIntervalSeconds=0.25f;}}}else{if(ē.Any(L=>L.
BlinkIntervalSeconds>0)){foreach(var L in ĕ){L.BlinkIntervalSeconds=0f;}foreach(var L in ē){L.BlinkIntervalSeconds=0f;}}}if(Ą<=ă){if(Z.All(E
=>E.IsAttached)){var š=new Random().Next(4);Z[š].Detach();}}}public static ć Š(){return new ć(100,5,60,20,'U',new Color(
192,0,255));}public static ć ş(){return new ć(100,8,50,20,'S',Color.Red);}public static ć Ş(){return new ć(75,13,50,20,'M',
Color.Yellow);}public static ć ŝ(){return new ć(60,21,50,20,'H',Color.White);}public static ć Ť(){return new ć(55,34,50,20,
'X',new Color(255,32,0));}public static ć Ŝ(){return new ć(60,8,40,10,'I',Color.Green,false);}public static ć ť(){return
new ć(50,21,40,10,'W',new Color(0,16,255),false);}}string Ÿ="12.1.0";const int Ŷ=3000;const int ŵ=1000;const int Ŵ=1200;
const float ų=80f;const float Ų=96f;const char ű='\u2191';const char Ű='\u2193';const char ŷ='\u2588';const char ů='\u2592';
const char ŭ='\u2591';const float Ŭ=1.7f;bool ū;IMyMotorSuspension[]Ū;IMyShipController ũ;List<IMyTextSurface>Ũ;
IMyTextSurface ŧ;IMyTextSurface Ŧ;List<IMySoundBlock>Ů;IMyRadioAntenna ś;IMySensorBlock Ŕ;List<IMyGyro>ŋ;bool Ŋ;bool ŉ;bool ň;
StringBuilder Ň;ĩ ņ;List<IMyLightingBlock>Ņ;List<IMyLightingBlock>ń;List<IMyLightingBlock>Ń;List<IMyLightingBlock>ł;ć Ł;long ŀ=-1;
IMyBroadcastListener Ŀ;int ľ;int Ľ;DateTime Ō;float ļ;float Ŏ=1f;bool Ś=false;int Ř;bool ŗ;Program(){ņ=new ĩ();try{D();B();a();U();í();ë();ì
();õ();û();ò();î();ÿ();ü();}catch(Exception ex){ū=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.
Update1;Ō=DateTime.Now;}void Save(){}void Main(string ï,UpdateType Ŗ){if(ū){return;}var ř=DateTime.Now;ļ=(float)(ř-Ō).
TotalMilliseconds/1000;Echo($"Running FSESS {Ÿ}");ð(ï);Æ();º();œ();Ç();I();K();Ő();ª();J();ŕ();F();Ō=ř;}void ŕ(){if(!ŗ){return;}if(
Vector3D.Dot(ũ.GetNaturalGravity(),ũ.WorldMatrix.Up)>0){for(int g=0;g<ŋ.Count;g++){ŋ[g].GyroOverride=true;}return;}if(ŋ[0].
GyroOverride){for(int g=0;g<ŋ.Count;g++){ŋ[g].GyroOverride=false;}ŗ=false;}}void œ(){switch(ņ.Ď){case Ķ.Ĵ:Œ();break;case Ķ.ĳ:ő();
break;default:if(!Ŋ){ũ.HandBrake=false;Ö(Ų);}break;}}void Œ(){ŉ=false;ň=false;ũ.HandBrake=ũ.GetShipSpeed()>50;Ö(50f);}void ő(
){ŉ=false;ň=false;Ŋ=false;ũ.HandBrake=true;}void Ő(){var ŏ=IGC.UnicastListener;if(!ŏ.HasPendingMessage){ľ-=(int)(ļ*1000);
if(Ŀ.HasPendingMessage&&ľ<=0){var o=Ŀ.AcceptMessage();if(o.Tag=="Address"){ŀ=Convert.ToInt64(o.Data.ToString());IGC.
SendUnicastMessage(ŀ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ŏ.HasPendingMessage){var Ă=ŏ.AcceptMessage();if(Ă.
Tag=="RaceData"){ņ.ĉ(Ă.Data.ToString());}if(Ă.Tag=="Argument"){ð(Ă.Data.ToString());}}ľ=Ŷ;}void ª(){Ň.Clear();var O=ũ.
GetShipSpeed();var y=Ł.ġ;var w=Ł.ą;var v=((int)Math.Floor(y)).ToString();var u=$"{O:F0}m/s";var t=Î();var r=ņ.č==Ĳ.İ?"<CLEAR>":
"<RAIN>";var q=$"RoR: {ņ.Č}%";var p=ņ.ċ<=0?$"{r} {q.PadLeft(15-r.Length)}":$"<RAIN IN {ņ.ċ}s>";var o=string.Empty;if(Ŋ){o=
"PIT LIMITER";}else{if(ŉ&&Ś){o="DRAFTING (DRS)";}else if(ŉ){o="DRS ON";}else if(Ś){o="DRAFTING";}}Ň.AppendLine(u+t.PadLeft(16-u.
Length));Ň.AppendLine(o);Ň.AppendLine($"P:{ņ.ı:00}/{ņ.Ĥ:00}  L:{(ņ.Ě):00}/{ņ.đ:00}");Ň.AppendLine($"TYRE ({w})..: {v,3}%");Ň.
AppendLine($"TIME.: {ņ.Đ}");Ň.AppendLine($"BEST.: {ņ.ď}");Ň.AppendLine(p);if(ľ<=0){Ň.AppendLine($"NO CONNECTION");}var n=Ň.
ToString();ŧ?.WriteText(n);foreach(var R in Ũ){var m=R.DrawFrame();var k=Color.Black;var j=DEFAULT_FONT_COLOR;switch(ņ.Ď){case Ķ
.Ĵ:k=Color.Yellow;j=Color.Black;break;case Ķ.ĳ:k=Color.Red;j=Color.White;break;case Ķ.ĺ:k=Color.Blue;j=Color.White;break;
}R.BackgroundColor=k;R.ScriptBackgroundColor=k;R.FontColor=j;var h=MySprite.CreateText(n,"Monospace",j,0.75f);h.Position=
new Vector2(128,18);m.Add(h);var z=MathHelper.Clamp(Math.Round(O/(100f/15)),0,100);for(int g=0;g<z;g++){var µ=8f;var Ì=2f;
var Ë=(256/2)-((15f*µ+14f*Ì)/2)+µ/2;var Ê=new Vector2(Ë+(µ+Ì)*g,µ+Ì);var É=new Vector2(µ);var È=MySprite.CreateSprite(
"Circle",Ê,É);if(g<5){È.Color=Color.Lime;}else if(g<10){È.Color=Color.Red;}else{È.Color=Color.Blue;}m.Add(È);}m.Dispose();}if(Ŧ
!=null&&ņ!=null&&ņ.Ċ!=null){Ŧ.WriteText(ņ.Ċ);}}void Ç(){if(!Ŋ){foreach(var E in Ū){E.Power=ų;E.SetValueFloat("Speed Limit"
,Ų*3.6f);}return;}foreach(var E in Ū){E.Power=20f;E.SetValueFloat("Speed Limit",26f*3.6f);}var O=ũ.GetShipSpeed();ũ.
HandBrake=O>24;}void Æ(){var Å=ũ.MoveIndicator.Z>0||ũ.MoveIndicator.Y>0||ũ.HandBrake;if(Å){ŉ=false;}var Ä=å(Į.ĭ);var Ã=å(Į.Ĭ);var
Â=å(Į.ī);var Á=å(Į.Ī);var À=(!ŉ?-150f:150f)*ļ;Ä.Strength=MathHelper.Clamp(Ä.Strength+À,DEFAULT_SUSPENSION_STRENGTH_F,100)
;Ã.Strength=MathHelper.Clamp(Ã.Strength+À,DEFAULT_SUSPENSION_STRENGTH_F,100);Â.Strength=MathHelper.Clamp(Â.Strength+À,
DEFAULT_SUSPENSION_STRENGTH_R,100);Á.Strength=MathHelper.Clamp(Á.Strength+À,DEFAULT_SUSPENSION_STRENGTH_R,100);foreach(var L in Ń){L.Color=ŉ?Color.
Blue:Color.Black;L.Enabled=ŉ;}}void º(){if(Ŋ){ň=false;}var f=ũ.MoveIndicator.Z<0;var O=ũ.GetShipSpeed();if(O>=1){if(!ň){var
A=(float)MathHelper.Clamp(O/Ų,0f,1f);Ŏ+=(1f/120)*A*ļ;}else if(f){var A=1;Ŏ-=(1f/30)*A*ļ;}}Ŏ=MathHelper.Clamp(Ŏ,0,1);if(Ŏ
<=0){ň=false;}foreach(var E in Ū){E.Power=â();}var M=ň&&f?Ŭ:0;Ý(M);foreach(var L in ń){L.Color=ň?Color.Cyan:Color.Black;}}
void K(){Ł.ė(ũ,Ū,Ņ,ł,ņ,ļ);Ô();}void J(){if(ś==null){return;}ś.HudText=$"P{ņ.ı}";}void I(){if(Ŕ==null){return;}var H=!Ŕ.
Closed&&Ŕ.IsActive&&ũ.GetShipSpeed()>=70;if(H){Ř=Ŵ;}if(Ŋ){Ř=0;}Ś=Ř>0;foreach(var E in Ū){E.Power=â();var G=á();E.SetValueFloat
("Speed Limit",G*3.6f);}Ř-=(int)(ļ*1000);}void F(){foreach(var E in Ů){}}void D(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){
throw new Exception("DRIVER_NUMBER should be between 1 and 99");}var C=TEAM_TAG;if(TEAM_TAG==string.Empty){C="XXX";}C=C.Trim(
).Substring(0,3).ToUpper();Me.CubeGrid.CustomName=$"{C} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void B(){var N=new
List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(N);var P=N.FirstOrDefault(e=>e is IMyRemoteControl)??N.
FirstOrDefault(e=>e is IMyCockpit);if(P==null){throw new Exception("No cockpit or remote control!");}ũ=P;}void a(){var Z=new List<
IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(Z,E=>E.CubeGrid==Me.CubeGrid);if(Z==null||Z.Count!=4){throw new Exception(
"Need 4 suspensions!");}var Y=Z.FirstOrDefault(E=>E.CustomName.Contains("FL"));if(Y==null)throw new Exception("FL suspension not found.");var
X=Z.FirstOrDefault(E=>E.CustomName.Contains("FR"));if(X==null)throw new Exception("FR suspension not found.");var W=Z.
FirstOrDefault(E=>E.CustomName.Contains("RL"));if(W==null)throw new Exception("RL suspension not found.");var V=Z.FirstOrDefault(E=>E.
CustomName.Contains("RR"));if(V==null)throw new Exception("RR suspension not found.");this.Ū=new IMyMotorSuspension[4];ß(Į.Ĭ,Y);ß(
Į.ĭ,X);ß(Į.Ī,W);ß(Į.ī,V);}void U(){Ň=new StringBuilder();Ũ=new List<IMyTextSurface>{Me.GetSurface(0)};var T=(
IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(T!=null){Ũ.Add(T);}if(COCKPIT_DISPLAY_INDEX.HasValue){var S=ũ as
IMyCockpit;if(S!=null){var R=S.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(R!=null){Ũ.Add(R);}}}foreach(var R in Ũ){R
.ContentType=ContentType.SCRIPT;R.Alignment=TextAlignment.CENTER;R.Font="Monospace";}var Q=(IMyTextSurface)
GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(Q!=null){Q.WriteText(string.Empty);Q.ContentType=ContentType.TEXT_AND_IMAGE;Q.
Alignment=TextAlignment.CENTER;Q.Font="Monospace";((IMyTerminalBlock)Q).CustomData="hudlcd:-0.7:-0.45:0.9:White:1";ŧ=Q;}var Í=(
IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(Í!=null){Í.WriteText(string.Empty);Í.ContentType=ContentType.
TEXT_AND_IMAGE;Í.Alignment=TextAlignment.CENTER;Í.Font="Monospace";((IMyTerminalBlock)Í).CustomData="hudlcd:0.45:0.9:1:White:1";Ŧ=Í;}}
void í(){var ê=new List<IMyLightingBlock>();GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocksOfType<
IMyLightingBlock>(ê,è=>è.CubeGrid==Me.CubeGrid);if(ê.Count<=0){throw new Exception($"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}Ņ=new
List<IMyLightingBlock>();foreach(var L in ê){L.Intensity=5f;L.BlinkLength=50f;L.BlinkIntervalSeconds=0f;Ņ.Add(L);}ł=new List
<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(ł,è=>è.CubeGrid!=Me.CubeGrid);foreach(var L in ł){L.BlinkLength=
50f;L.BlinkIntervalSeconds=0;}}void ì(){Ń=new List<IMyLightingBlock>();var ê=new List<IMyTerminalBlock>();var é=
GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(é==null){return;}é.GetBlocks(ê,è=>è.CubeGrid==Me.CubeGrid);foreach(var
L in ê){var ç=(IMyLightingBlock)L;Ń.Add(ç);}}void ë(){ń=new List<IMyLightingBlock>();var ê=new List<IMyTerminalBlock>();
var é=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(é==null){return;}é.GetBlocks(ê,è=>è.CubeGrid==Me.
CubeGrid);foreach(var L in ê){var ç=(IMyLightingBlock)L;ç.Radius=4f;ç.Intensity=10f;ç.BlinkLength=50f;ç.BlinkIntervalSeconds=
0.5f;ń.Add(ç);}}void î(){var ā=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(ā==null){return;
}Ŕ=ā;Ŕ.TopExtend=50;Ŕ.BottomExtend=0;Ŕ.RightExtend=2.25f;Ŕ.LeftExtend=2.25f;Ŕ.FrontExtend=0;Ŕ.BackExtend=2;Ŕ.
DetectSmallShips=true;Ŕ.DetectLargeShips=false;Ŕ.DetectStations=false;Ŕ.DetectSubgrids=false;Ŕ.DetectAsteroids=false;Ŕ.DetectPlayers=
false;}void ÿ(){var þ=new List<IMyGyro>();GridTerminalSystem.GetBlocksOfType(þ,ý=>ý.CubeGrid==Me.CubeGrid);if(þ.Count<=0){
throw new Exception("No gyroscope found.");}ŋ=þ;}void ü(){Ů=new List<IMySoundBlock>();GridTerminalSystem.GetBlocksOfType(Ů,è
=>è.CubeGrid==Me.CubeGrid);}void û(){if(string.IsNullOrWhiteSpace(Me.CustomData)){à(Ħ.ĥ);return;}var ú=Me.CustomData.Split
(';');if(ú.Length<3){à(Ħ.ĥ);return;}var Ā=Convert.ToChar(ú[0]);var ù=(float)Convert.ToDouble(ú[1]);var ö=(float)Convert.
ToDouble(ú[2]);switch(Ā){case'U':à(Ħ.ħ);break;case'S':à(Ħ.ĥ);break;case'M':à(Ħ.Ĩ);break;case'H':à(Ħ.Ļ);break;case'X':à(Ħ.Ĺ);
break;case'I':à(Ħ.ĸ);break;case'W':à(Ħ.ķ);break;default:à(Ħ.ĥ);break;}Ł.Ą=ù;Ŏ=ö;}void õ(){var ô=new List<IMyRadioAntenna>();
GridTerminalSystem.GetBlocksOfType(ô);var ó=ô.FirstOrDefault();if(ó==null){throw new Exception("No antenna!");}ó.Enabled=true;ó.Radius=
5000;ó.EnableBroadcasting=true;ó.HudText=$"(P{ņ.ı}) {DRIVER_NAME}-{DRIVER_NUMBER}";ś=ó;}void ò(){IGC.
RegisterBroadcastListener("Address");var ñ=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(ñ);Ŀ=ñ.FirstOrDefault();}void ð(string ï){
if(ï.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){Ŋ=!Ŋ;return;}if(ï.Equals("LMT_ON",StringComparison.
InvariantCultureIgnoreCase)){Ŋ=true;return;}if(ï.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){Ŋ=false;return;}if(ï.Equals("DRS",
StringComparison.InvariantCultureIgnoreCase)){ŉ=!ŉ;return;}if(ï.Equals("DRS_ON",StringComparison.InvariantCultureIgnoreCase)){ŉ=true;
return;}if(ï.Equals("DRS_OFF",StringComparison.InvariantCultureIgnoreCase)){ŉ=false;return;}if(ï.Equals("ERS",StringComparison
.InvariantCultureIgnoreCase)){ň=!ň;return;}if(ï.Equals("ERS_ON",StringComparison.InvariantCultureIgnoreCase)){ň=true;
return;}if(ï.Equals("ERS_OFF",StringComparison.InvariantCultureIgnoreCase)){ň=false;return;}if(ï.Equals("ULTRA",
StringComparison.InvariantCultureIgnoreCase)){ø(Ħ.ħ);return;}if(ï.Equals("SOFT",StringComparison.InvariantCultureIgnoreCase)){ø(Ħ.ĥ);
return;}if(ï.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){ø(Ħ.Ĩ);return;}if(ï.Equals("HARD",StringComparison.
InvariantCultureIgnoreCase)){ø(Ħ.Ļ);return;}if(ï.Equals("EXTRA",StringComparison.InvariantCultureIgnoreCase)){ø(Ħ.Ĺ);return;}if(ï.Equals("INT",
StringComparison.InvariantCultureIgnoreCase)){ø(Ħ.ĸ);return;}if(ï.Equals("WET",StringComparison.InvariantCultureIgnoreCase)){ø(Ħ.ķ);
return;}if(ï.Equals("FLIP",StringComparison.InvariantCultureIgnoreCase)){ŗ=true;return;}if(ï.Equals("FLAG_G",StringComparison.
InvariantCultureIgnoreCase)){ä(Ķ.ĵ);return;}if(ï.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){ä(Ķ.Ĵ);return;}if(ï.Equals("FLAG_R"
,StringComparison.InvariantCultureIgnoreCase)){ä(Ķ.ĳ);return;}}void ø(Ħ Ú){if(!Ŋ||ũ.GetShipSpeed()>1){return;}à(Ú);Ô(true
);}void à(Ħ Ú){switch(Ú){case Ħ.ħ:Ł=ć.Š();break;case Ħ.ĥ:Ł=ć.ş();break;case Ħ.Ĩ:Ł=ć.Ş();break;case Ħ.Ļ:Ł=ć.ŝ();break;case
Ħ.Ĺ:Ł=ć.Ť();break;case Ħ.ĸ:Ł=ć.Ŝ();break;case Ħ.ķ:Ł=ć.ť();break;default:break;}Ù(Ł.Ğ);foreach(var E in Ū){E.ApplyAction(
"Add Top Part");E.Friction=Ł.Ē;}}void Ù(Color Ø){foreach(var L in Ņ){L.Color=Ø;L.BlinkIntervalSeconds=0;}foreach(var L in ł){if(L.
IsSameConstructAs(Me)){L.Color=Ø;L.BlinkIntervalSeconds=0;}}}void Ö(float Õ){foreach(var E in Ū){E.SetValueFloat("Speed Limit",Õ*3.6f);}}
void Ô(bool Ó=false){Ľ-=(int)(ļ*1000);if(!Ó&&Ľ>0){return;}var Ò=Ł.ą;Me.CustomData=$"{Ò};{Ł.Ą};{Ŏ}";Ľ=ŵ;}string Ñ(){var Ð=
string.Empty;switch(ņ.Ď){case Ķ.ĺ:Ð="Blue";break;case Ķ.ĵ:Ð="Green";break;case Ķ.ĳ:Ð="Red";break;case Ķ.Ĵ:Ð="Yellow";break;}
return Ð;}Color Ï(){var Ø=Color.Black;switch(ņ.Ď){case Ķ.ĺ:Ø=Color.Blue;break;case Ķ.ĵ:Ø=Color.Green;break;case Ķ.ĳ:Ø=Color.
Red;break;case Ķ.Ĵ:Ø=Color.Yellow;break;}return Ø;}string Î(){const int Û=6;var æ=ň?Ű:Ŏ<1?ű:'-';var t=æ+"E:";for(int g=0;g<
Û;g++){var A=1f/Û;if(Ŏ>A*g){if(Ŏ<A*(g+1)){t+=ů;continue;}t+=ŷ;}else{t+=ŭ;}}return t;}void ä(Ķ ã){if(ŀ<=0){return;}IGC.
SendUnicastMessage(ŀ,"Flag",$"{(int)ã}");}float â(){if(Ŋ){return 20f;}if(Ś||ň){return 100f;}return ų;}float á(){if(Ŋ){return 26;}if(ņ.Ď==Ķ
.Ĵ){return 45;}if(Ś){return 999;}return Ų;}IMyMotorSuspension å(Į Ê){return Ū[(int)Ê];}void ß(Į Ê,IMyMotorSuspension Þ){
if(Þ==null){return;}Ū[(int)Ê]=Þ;}void Ý(float Ü){var Y=å(Į.Ĭ);var X=å(Į.ĭ);var W=å(Į.Ī);var V=å(Į.ī);Y.PropulsionOverride=
Ü;X.PropulsionOverride=-Ü;W.PropulsionOverride=Ü;V.PropulsionOverride=-Ü;}