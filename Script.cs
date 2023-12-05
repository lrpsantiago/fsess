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
private const string TEXT_DISPLAY_HUDLCD = "hudlcd:-0.7:-0.45:0.9:White:1";
private const string RANK_DISPLAY_HUDLCD = "hudlcd:0.45:0.9:1:White:1";

enum ĥ{Ħ,Ĺ,ķ,Ķ,ĵ,Ĵ,ĳ}enum Ĳ{ı,ĸ,İ,Į}enum ĭ{Ĭ,ī}enum Ī{ĩ,Ĩ,ħ,į}class Ĥ{public int Ě{get;set;}public int đ{get;set;}public
int Đ{get;set;}public int ď{get;set;}public string Ď{get;set;}="--:--.---";public string č{get;set;}="--:--.---";public Ĳ Č
{get;set;}public ĭ ċ{get;set;}public int Ċ{get;set;}public int ĉ{get;set;}public string Ĉ{get;set;}public void ć(string Ć
){try{var û=Ć.Split(';');Đ=Convert.ToInt32(û[0]);Ě=Convert.ToInt32(û[1]);Ď=û[2];č=û[3];đ=Convert.ToInt32(û[4]);ď=Convert.
ToInt32(û[5]);Č=(Ĳ)Convert.ToInt32(û[6]);ċ=(ĭ)Convert.ToInt32(û[7]);Ċ=Convert.ToInt32(û[8]);ĉ=Convert.ToInt32(û[9]);Ĉ=û[10];}
catch(Exception){}}}class ą{private float Ą;public char Ē{get;private set;}public float ă{get;set;}public float ē{get;private
set;}public float ģ{get;private set;}public float ġ{get;private set;}public float Ġ{get;private set;}public float ğ{get{
return((ă-ģ)/(ē-ģ))*100f;}}public int Ğ{get;private set;}public bool ĝ{get;private set;}public Color Ĝ{get;private set;}
private ą(float Ģ,int ě,float ę,float Ę,char ė,Color Ö,bool Ė=true){ē=Ģ;ă=ē;Ğ=ě;ġ=ę;Ġ=Ę;ģ=(float)Math.Round(ġ-((ē-ġ)/(100-Ġ))*Ġ
,2);Ē=ė;Ĝ=Ö;ĝ=Ė;Ą=(ē-ģ)/(60*Ğ);}public void ĕ(IMyShipController Ĕ,IMyMotorSuspension[]W,List<IMyLightingBlock>ĺ,List<
IMyLightingBlock>Ō,Ĥ Ć,float Ţ){var L=Ĕ.GetShipSpeed();if(L<1){return;}var š=(float)MathHelper.Clamp(L,0,90)/90;var Š=Ą*š*Ţ;ă-=Š;ă=
MathHelper.Clamp(ă,ģ,ē);foreach(var D in W){D.Friction=!(ĝ&&Ć.ċ==ĭ.ī)?ă:ă/2;}if(ğ<=Ġ){if(Ō.Any(I=>I.BlinkIntervalSeconds<=0)){
foreach(var I in ĺ){I.BlinkIntervalSeconds=0.25f;}foreach(var I in Ō){I.BlinkIntervalSeconds=0.25f;}}}else{if(Ō.Any(I=>I.
BlinkIntervalSeconds>0)){foreach(var I in ĺ){I.BlinkIntervalSeconds=0f;}foreach(var I in Ō){I.BlinkIntervalSeconds=0f;}}}if(ă<=ģ){if(W.All(D
=>D.IsAttached)){var ş=new Random().Next(4);W[ş].Detach();}}}public static ą Ş(){return new ą(100,5,60,20,'U',new Color(
192,0,255));}public static ą ŝ(){return new ą(100,8,50,20,'S',Color.Red);}public static ą ţ(){return new ą(75,13,50,20,'M',
Color.Yellow);}public static ą Ŝ(){return new ą(60,21,50,20,'H',Color.White);}public static ą Ť(){return new ą(55,34,50,20,
'X',new Color(255,32,0));}public static ą ŷ(){return new ą(60,8,40,10,'I',Color.Green,false);}public static ą ŵ(){return
new ą(50,21,40,10,'W',new Color(0,16,255),false);}}string Ŵ="12.2.0";const int ų=3000;const int Ų=1000;const int ű=1200;
const float Ű=80f;const float ů=95f;const char Ŷ='\u2191';const char Ů='\u2193';const char Ŭ='\u2588';const char ū='\u2592';
const char Ū='\u2591';const float ũ=1.7f;bool Ũ;IMyMotorSuspension[]ŧ;IMyShipController Ŧ;List<IMyTextSurface>ť;
IMyTextSurface ŭ;IMyTextSurface ś;IMyRadioAntenna Ŕ;IMySensorBlock Ŋ;List<IMyGyro>ŉ;bool ň;bool Ň;bool ņ;StringBuilder Ņ;Ĥ ń;List<
IMyLightingBlock>Ń;List<IMyLightingBlock>ł;List<IMyLightingBlock>Ł;List<IMyLightingBlock>ŀ;ą Ŀ;long ľ=-1;IMyBroadcastListener Ľ;int ļ;
int ŋ;DateTime Ļ;float ō;float Ś=1f;bool Ř=false;int ŗ;bool Ŗ;Program(){ń=new Ĥ();try{B();O();X();R();í();é();ì();ö();ü();ó
();ā();ÿ();}catch(Exception ex){Ũ=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.Update1;Ļ=
DateTime.Now;}void Save(){}void Main(string ð,UpdateType ř){if(Ũ){return;}var ŕ=DateTime.Now;ō=(float)(ŕ-Ļ).TotalMilliseconds/
1000;Echo($"Running FSESS {Ŵ}");ñ(ð);Â();A();Œ();Ë();F();H();ŏ();Ú();G();œ();Ļ=ŕ;}void œ(){if(!Ŗ){return;}if(Vector3D.Dot(Ŧ.
GetNaturalGravity(),Ŧ.WorldMatrix.Up)>0){for(int Ê=0;Ê<ŉ.Count;Ê++){ŉ[Ê].GyroOverride=true;}return;}if(ŉ[0].GyroOverride){for(int Ê=0;Ê<ŉ
.Count;Ê++){ŉ[Ê].GyroOverride=false;}Ŗ=false;}}void Œ(){switch(ń.Č){case Ĳ.ĸ:ő();break;case Ĳ.İ:Ő();break;default:if(!ň){
Ŧ.HandBrake=false;Õ(ů);}break;}}void ő(){Ň=false;ņ=false;Ŧ.HandBrake=Ŧ.GetShipSpeed()>50;Õ(50f);}void Ő(){Ň=false;ņ=false
;ň=false;Ŧ.HandBrake=true;}void ŏ(){var Ŏ=IGC.UnicastListener;if(!Ŏ.HasPendingMessage){ļ-=(int)(ō*1000);if(Ľ.
HasPendingMessage&&ļ<=0){var m=Ľ.AcceptMessage();if(m.Tag=="Address"){ľ=Convert.ToInt64(m.Data.ToString());IGC.SendUnicastMessage(ľ,
"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(Ŏ.HasPendingMessage){var y=Ŏ.AcceptMessage();if(y.Tag=="RaceData"
){ń.ć(y.Data.ToString());}if(y.Tag=="Argument"){ñ(y.Data.ToString());}}ļ=ų;}void Ú(){Ņ.Clear();var L=Ŧ.GetShipSpeed();var
v=Ŀ.ğ;var u=Ŀ.Ē;var t=((int)Math.Floor(v)).ToString();var r=$"{Math.Floor(L)}m/s";var q=Í();var p=ń.ċ==ĭ.Ĭ?"<CLEAR>":
"<RAIN>";var o=$"RoR: {ń.Ċ}%";var n=ń.ĉ<=0?$"{p} {o.PadLeft(15-p.Length)}":$"<RAIN IN {ń.ĉ}s>";var m=string.Empty;if(ň){m=
"PIT LIMITER";}else{if(Ň&&Ř){m="DRAFTING (DRS)";}else if(Ň){m="DRS ON";}else if(Ř){m="DRAFTING";}}Ņ.AppendLine(r+q.PadLeft(16-r.
Length));Ņ.AppendLine(m);Ņ.AppendLine($"P:{ń.Ě:00}/{ń.đ:00}  L:{(ń.Đ):00}/{ń.ď:00}");Ņ.AppendLine($"TYRE ({u})..: {t,3}%");Ņ.
AppendLine($"TIME.: {ń.Ď}");Ņ.AppendLine($"BEST.: {ń.č}");Ņ.AppendLine(n);if(ļ<=0){Ņ.AppendLine($"NO CONNECTION");}var k=Ņ.
ToString();ŭ?.WriteText(k);foreach(var P in ť){var j=P.DrawFrame();var h=Color.Black;var g=DEFAULT_FONT_COLOR;switch(ń.Č){case Ĳ
.ĸ:h=Color.Yellow;g=Color.Black;break;case Ĳ.İ:h=Color.Red;g=Color.White;break;case Ĳ.Į:h=Color.Blue;g=Color.White;break;
}P.BackgroundColor=h;P.ScriptBackgroundColor=h;P.FontColor=g;var w=P.SurfaceSize.X/256;var f=w*0.75f;var z=MySprite.
CreateText(k,"Monospace",g,f);z.Position=new Vector2(128*w,18*w);j.Add(z);var Ì=MathHelper.Clamp(Math.Round(L/(100f/15)),0,100);
for(int Ê=0;Ê<Ì;Ê++){var É=8f*w;var È=2f*w;var Ç=(P.SurfaceSize.X/2)-((15f*É+14f*È)/2)+É/2;var Æ=new Vector2(Ç+(É+È)*Ê,É+È)
;var Å=new Vector2(É);var Ä=MySprite.CreateSprite("Circle",Æ,Å);if(Ê<5){Ä.Color=Color.Lime;}else if(Ê<10){Ä.Color=Color.
Red;}else{Ä.Color=Color.Blue;}j.Add(Ä);}j.Dispose();}if(ś!=null&&ń!=null&&ń.Ĉ!=null){ś.WriteText(ń.Ĉ);}}void Ë(){if(!ň){
foreach(var D in ŧ){D.Power=Ű;D.SetValueFloat("Speed Limit",ů*3.6f);}return;}foreach(var D in ŧ){D.Power=20f;D.SetValueFloat(
"Speed Limit",26f*3.6f);}var L=Ŧ.GetShipSpeed();Ŧ.HandBrake=L>24;}void Â(){var Á=Ŧ.MoveIndicator.Z>0||Ŧ.MoveIndicator.Y>0||Ŧ.
HandBrake;if(Á){Ň=false;}var À=å(Ī.ĩ);var º=å(Ī.Ĩ);var µ=å(Ī.ħ);var ª=å(Ī.į);var e=(!Ň?-150f:150f)*ō;À.Strength=MathHelper.Clamp(
À.Strength+e,DEFAULT_SUSPENSION_STRENGTH_F,100);º.Strength=MathHelper.Clamp(º.Strength+e,DEFAULT_SUSPENSION_STRENGTH_F,
100);µ.Strength=MathHelper.Clamp(µ.Strength+e,DEFAULT_SUSPENSION_STRENGTH_R,100);ª.Strength=MathHelper.Clamp(ª.Strength+e,
DEFAULT_SUSPENSION_STRENGTH_R,100);foreach(var I in Ł){I.Color=Ň?Color.Blue:Color.Black;I.Enabled=Ň;}}void A(){if(ň){ņ=false;}var M=Ŧ.MoveIndicator.Z
<0;var L=Ŧ.GetShipSpeed();if(L>=1){if(!ņ){var K=(float)MathHelper.Clamp(L/ů,0f,1f);Ś+=(1f/135)*K*ō;}else if(M){var K=1;Ś
-=(1f/45)*K*ō;}}Ś=MathHelper.Clamp(Ś,0,1);if(Ś<=0){ņ=false;}foreach(var D in ŧ){D.Power=â();}var C=á();Õ(C);var J=ņ&&M?ũ:0
;Ý(J);foreach(var I in ł){I.Color=ņ?Color.Cyan:Color.Black;}}void H(){Ŀ.ĕ(Ŧ,ŧ,Ń,ŀ,ń,ō);Ó();}void G(){if(Ŕ==null){return;}
Ŕ.HudText=$"P{ń.Ě}";}void F(){if(Ŋ==null){return;}var E=!Ŋ.Closed&&Ŋ.IsActive&&Ŧ.GetShipSpeed()>=70;if(E){ŗ=ű;}if(ň){ŗ=0;
}Ř=ŗ>0;foreach(var D in ŧ){D.Power=â();var C=á();D.SetValueFloat("Speed Limit",C*3.6f);}ŗ-=(int)(ō*1000);}void B(){if(
DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");}var N=TEAM_TAG;if(TEAM_TAG==
string.Empty){N="XXX";}N=N.Trim().Substring(0,3).ToUpper();Me.CubeGrid.CustomName=
$"{N} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void O(){var Z=new List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(Z);var a=Z.FirstOrDefault(Y=>Y is
IMyRemoteControl)??Z.FirstOrDefault(Y=>Y is IMyCockpit);if(a==null){throw new Exception("No cockpit or remote control!");}Ŧ=a;}void X(){
var W=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(W,D=>D.CubeGrid==Me.CubeGrid);if(W==null||W.Count!=
4){throw new Exception("Need 4 suspensions!");}var V=W.FirstOrDefault(D=>D.CustomName.Contains("FL"));if(V==null)throw
new Exception("FL suspension not found.");var U=W.FirstOrDefault(D=>D.CustomName.Contains("FR"));if(U==null)throw new
Exception("FR suspension not found.");var T=W.FirstOrDefault(D=>D.CustomName.Contains("RL"));if(T==null)throw new Exception(
"RL suspension not found.");var S=W.FirstOrDefault(D=>D.CustomName.Contains("RR"));if(S==null)throw new Exception("RR suspension not found.");this
.ŧ=new IMyMotorSuspension[4];ß(Ī.Ĩ,V);ß(Ī.ĩ,U);ß(Ī.į,T);ß(Ī.ħ,S);}void R(){Ņ=new StringBuilder();ť=new List<
IMyTextSurface>{Me.GetSurface(0)};var Q=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(Q!=null){ť.Add(Q);}if(
COCKPIT_DISPLAY_INDEX.HasValue){var Ã=Ŧ as IMyCockpit;if(Ã!=null){var P=Ã.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(P!=null){ť
.Add(P);}}}foreach(var P in ť){P.ContentType=ContentType.SCRIPT;P.Alignment=TextAlignment.CENTER;P.Script="None";P.Font=
"Monospace";}var ï=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(ï!=null){ï.WriteText(string.Empty);ï.
ContentType=ContentType.TEXT_AND_IMAGE;ï.Alignment=TextAlignment.CENTER;ï.Font="Monospace";((IMyTerminalBlock)ï).CustomData=
TEXT_DISPLAY_HUDLCD;ŭ=ï;}var î=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(î!=null){î.WriteText(string.Empty)
;î.ContentType=ContentType.TEXT_AND_IMAGE;î.Alignment=TextAlignment.CENTER;î.Font="Monospace";((IMyTerminalBlock)î).
CustomData=RANK_DISPLAY_HUDLCD;ś=î;}}void í(){var è=new List<IMyLightingBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocksOfType<IMyLightingBlock>(è,ç=>ç.CubeGrid==Me.CubeGrid);if(è.Count<=0){throw new Exception(
$"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}Ń=new List<IMyLightingBlock>();foreach(var I in è){I.Intensity=5f;I.BlinkLength=50f;I.BlinkIntervalSeconds=0f;Ń.Add(I
);}ŀ=new List<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(ŀ,ç=>ç.CubeGrid!=Me.CubeGrid);foreach(var I in ŀ){I.
BlinkLength=50f;I.BlinkIntervalSeconds=0;}}void ì(){Ł=new List<IMyLightingBlock>();var è=new List<IMyTerminalBlock>();var ë=
GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(ë==null){return;}ë.GetBlocks(è,ç=>ç.CubeGrid==Me.CubeGrid);foreach(var
I in è){var ê=(IMyLightingBlock)I;Ł.Add(ê);}}void é(){ł=new List<IMyLightingBlock>();var è=new List<IMyTerminalBlock>();
var ë=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(ë==null){return;}ë.GetBlocks(è,ç=>ç.CubeGrid==Me.
CubeGrid);foreach(var I in è){var ê=(IMyLightingBlock)I;ê.Radius=4f;ê.Intensity=10f;ê.BlinkLength=50f;ê.BlinkIntervalSeconds=
0.5f;ł.Add(ê);}}void ā(){var Ā=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(Ā==null){return;
}Ŋ=Ā;Ŋ.TopExtend=50;Ŋ.BottomExtend=0;Ŋ.RightExtend=2.25f;Ŋ.LeftExtend=2.25f;Ŋ.FrontExtend=0;Ŋ.BackExtend=2;Ŋ.
DetectSmallShips=true;Ŋ.DetectLargeShips=false;Ŋ.DetectStations=false;Ŋ.DetectSubgrids=false;Ŋ.DetectAsteroids=false;Ŋ.DetectPlayers=
false;}void ÿ(){var þ=new List<IMyGyro>();GridTerminalSystem.GetBlocksOfType(þ,ý=>ý.CubeGrid==Me.CubeGrid);if(þ.Count<=0){
throw new Exception("No gyroscope found.");}ŉ=þ;}void ü(){if(string.IsNullOrWhiteSpace(Me.CustomData)){à(ĥ.Ĺ);return;}var û=
Me.CustomData.Split(';');if(û.Length<3){à(ĥ.Ĺ);return;}var Ă=Convert.ToChar(û[0]);var ú=(float)Convert.ToDouble(û[1]);var
ø=(float)Convert.ToDouble(û[2]);switch(Ă){case'U':à(ĥ.Ħ);break;case'S':à(ĥ.Ĺ);break;case'M':à(ĥ.ķ);break;case'H':à(ĥ.Ķ);
break;case'X':à(ĥ.ĵ);break;case'I':à(ĥ.Ĵ);break;case'W':à(ĥ.ĳ);break;default:à(ĥ.Ĺ);break;}Ŀ.ă=ú;Ś=ø;}void ö(){var õ=new List
<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(õ);var ô=õ.FirstOrDefault();if(ô==null){throw new Exception(
"No antenna!");}ô.Enabled=true;ô.Radius=5000;ô.EnableBroadcasting=true;ô.HudText=$"(P{ń.Ě}) {DRIVER_NAME}-{DRIVER_NUMBER}";Ŕ=ô;}void
ó(){IGC.RegisterBroadcastListener("Address");var ò=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(ò);Ľ=ò.
FirstOrDefault();}void ñ(string ð){if(ð.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){ň=!ň;return;}if(ð.Equals("LMT_ON",
StringComparison.InvariantCultureIgnoreCase)){ň=true;return;}if(ð.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){ň=false
;return;}if(ð.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){Ň=!Ň;return;}if(ð.Equals("DRS_ON",
StringComparison.InvariantCultureIgnoreCase)){Ň=true;return;}if(ð.Equals("DRS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ň=false
;return;}if(ð.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){ņ=!ņ;return;}if(ð.Equals("ERS_ON",
StringComparison.InvariantCultureIgnoreCase)){ņ=true;return;}if(ð.Equals("ERS_OFF",StringComparison.InvariantCultureIgnoreCase)){ņ=false
;return;}if(ð.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){ù(ĥ.Ħ);return;}if(ð.Equals("SOFT",
StringComparison.InvariantCultureIgnoreCase)){ù(ĥ.Ĺ);return;}if(ð.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){ù(ĥ.ķ);
return;}if(ð.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){ù(ĥ.Ķ);return;}if(ð.Equals("EXTRA",StringComparison.
InvariantCultureIgnoreCase)){ù(ĥ.ĵ);return;}if(ð.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){ù(ĥ.Ĵ);return;}if(ð.Equals("WET",
StringComparison.InvariantCultureIgnoreCase)){ù(ĥ.ĳ);return;}if(ð.Equals("FLIP",StringComparison.InvariantCultureIgnoreCase)){Ŗ=true;
return;}if(ð.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){ä(Ĳ.ı);return;}if(ð.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){ä(Ĳ.ĸ);return;}if(ð.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){ä(Ĳ.İ);
return;}}void ù(ĥ Ù){if(!ň||Ŧ.GetShipSpeed()>1){return;}à(Ù);Ó(true);}void à(ĥ Ù){switch(Ù){case ĥ.Ħ:Ŀ=ą.Ş();break;case ĥ.Ĺ:Ŀ=
ą.ŝ();break;case ĥ.ķ:Ŀ=ą.ţ();break;case ĥ.Ķ:Ŀ=ą.Ŝ();break;case ĥ.ĵ:Ŀ=ą.Ť();break;case ĥ.Ĵ:Ŀ=ą.ŷ();break;case ĥ.ĳ:Ŀ=ą.ŵ();
break;default:break;}Ø(Ŀ.Ĝ);foreach(var D in ŧ){D.ApplyAction("Add Top Part");D.Friction=Ŀ.ē;}}void Ø(Color Ö){foreach(var I
in Ń){I.Color=Ö;I.BlinkIntervalSeconds=0;}foreach(var I in ŀ){if(I.IsSameConstructAs(Me)){I.Color=Ö;I.BlinkIntervalSeconds
=0;}}}void Õ(float Ô){foreach(var D in ŧ){D.SetValueFloat("Speed Limit",Ô*3.6f);}}void Ó(bool Ò=false){ŋ-=(int)(ō*1000);
if(!Ò&&ŋ>0){return;}var Ñ=Ŀ.Ē;Me.CustomData=$"{Ñ};{Ŀ.ă};{Ś}";ŋ=Ų;}string Ð(){var Ï=string.Empty;switch(ń.Č){case Ĳ.Į:Ï=
"Blue";break;case Ĳ.ı:Ï="Green";break;case Ĳ.İ:Ï="Red";break;case Ĳ.ĸ:Ï="Yellow";break;}return Ï;}Color Î(){var Ö=Color.Black;
switch(ń.Č){case Ĳ.Į:Ö=Color.Blue;break;case Ĳ.ı:Ö=Color.Green;break;case Ĳ.İ:Ö=Color.Red;break;case Ĳ.ĸ:Ö=Color.Yellow;break;
}return Ö;}string Í(){const int Û=6;var æ=ņ?Ů:Ś<1?Ŷ:'-';var q=æ+"E:";for(int Ê=0;Ê<Û;Ê++){var K=1f/Û;if(Ś>K*Ê){if(Ś<K*(Ê+
1)){q+=ū;continue;}q+=Ŭ;}else{q+=Ū;}}return q;}void ä(Ĳ ã){if(ľ<=0){return;}IGC.SendUnicastMessage(ľ,"Flag",$"{(int)ã}");
}float â(){if(ň){return 20f;}if(Ř||ņ){return 100f;}return Ű;}float á(){if(ň){return 26;}if(ń.Č==Ĳ.ĸ){return 45;}if(Ř){
return 999;}if(ņ){return 98f;}return ů;}IMyMotorSuspension å(Ī Æ){return ŧ[(int)Æ];}void ß(Ī Æ,IMyMotorSuspension Þ){if(Þ==
null){return;}ŧ[(int)Æ]=Þ;}void Ý(float Ü){var V=å(Ī.Ĩ);var U=å(Ī.ĩ);var T=å(Ī.į);var S=å(Ī.ħ);V.PropulsionOverride=Ü;U.
PropulsionOverride=-Ü;T.PropulsionOverride=Ü;S.PropulsionOverride=-Ü;}