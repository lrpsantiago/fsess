private readonly string TEAM_TAG = "XXX";                               //Your Team Tag (3 chracters), if you are not in a team yet, keep this as it is.
private readonly string DRIVER_NAME = "Guest";                          //Your name
private readonly int DRIVER_NUMBER = 99;                                //Your number (0-99)
private const float DEFAULT_SUSPENSION_STRENGTH_F = 20f;                //Setup your default front suspensions strength
private const float DEFAULT_SUSPENSION_STRENGTH_R = 20f;                //Setup your default rear suspensions strength
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private const string MIRROR_SENSOR_RIGHT_NAME = "Mirror Sensor Right";
private const string MIRROR_SENSOR_LEFT_NAME = "Mirror Sensor Left";
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private const string TEXT_DISPLAY_NAME = "Text LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string RANK_DISPLAY_NAME = "Rank LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string TEXT_DISPLAY_HUDLCD = "hudlcd:-0.7:-0.43:0.9:White:1";
private const string RANK_DISPLAY_HUDLCD = "hudlcd:0.45:0.9:1:White:1";

enum ķ{ĸ,ł,ō,ŋ,Ŋ,ŉ,ň}enum Ň{ņ,Ņ,ń,Ō}enum Ń{Ł,ŀ}enum Ŀ{ľ,Ľ,ļ,Ļ}class ĺ{public int Ĺ{get;set;}public int ĵ{get;set;}public
int ģ{get;set;}public int ī{get;set;}public string ġ{get;set;}="--:--.---";public string Ġ{get;set;}="--:--.---";public Ň ğ
{get;set;}public Ń Ğ{get;set;}public int ĝ{get;set;}public int Ĝ{get;set;}public string ě{get;set;}public void Ě(string ę
){try{var ø=ę.Split(';');ģ=Convert.ToInt32(ø[0]);Ĺ=Convert.ToInt32(ø[1]);ġ=ø[2];Ġ=ø[3];ĵ=Convert.ToInt32(ø[4]);ī=Convert.
ToInt32(ø[5]);ğ=(Ň)Convert.ToInt32(ø[6]);Ğ=(Ń)Convert.ToInt32(ø[7]);ĝ=Convert.ToInt32(ø[8]);Ĝ=Convert.ToInt32(ø[9]);ě=ø[10];}
catch(Exception){}}}class Ę{private float ė;public char Ė{get;private set;}public float ĕ{get;set;}public float Ĕ{get;private
set;}public float ē{get;private set;}public float Ē{get;private set;}public float Ģ{get;private set;}public float đ{get{
return((ĕ-ē)/(Ĕ-ē))*100f;}}public int Ĥ{get;private set;}public bool Ĵ{get;private set;}public Color Ĳ{get;private set;}
private Ę(float ı,int İ,float į,float Į,char ĭ,Color ë,bool ĳ=true){Ĕ=ı;ĕ=Ĕ;Ĥ=İ;Ē=į;Ģ=Į;ē=(float)Math.Round(Ē-((Ĕ-Ē)/(100-Ģ))*Ģ
,2);Ė=ĭ;Ĳ=ë;Ĵ=ĳ;ė=(Ĕ-ē)/(60*Ĥ);}public void Ĭ(IMyShipController Ī,IMyMotorSuspension[]B,List<IMyLightingBlock>ĩ,List<
IMyLightingBlock>Ĩ,ĺ ę,float ħ){var Å=Ī.GetShipSpeed();if(Å<1){return;}var Ħ=(float)MathHelper.Clamp(Å,0,90)/90;var Ķ=ė*Ħ*ħ;ĕ-=Ķ;ĕ=
MathHelper.Clamp(ĕ,ē,Ĕ);foreach(var K in B){K.Friction=!(Ĵ&&ę.Ğ==Ń.ŀ)?ĕ:ĕ/2;}if(đ<=Ģ){if(Ĩ.Any(P=>P.BlinkIntervalSeconds<=0)){
foreach(var P in ĩ){P.BlinkIntervalSeconds=0.25f;}foreach(var P in Ĩ){P.BlinkIntervalSeconds=0.25f;}}}else{if(Ĩ.Any(P=>P.
BlinkIntervalSeconds>0)){foreach(var P in ĩ){P.BlinkIntervalSeconds=0f;}foreach(var P in Ĩ){P.BlinkIntervalSeconds=0f;}}}if(ĕ<=ē){if(B.All(K
=>K.IsAttached)){var ž=new Random().Next(4);B[ž].Detach();}}}public static Ę Ž(){return new Ę(100,5,60,20,'U',new Color(
192,0,255));}public static Ę ż(){return new Ę(100,8,50,20,'S',Color.Red);}public static Ę ſ(){return new Ę(75,13,50,20,'M',
Color.Yellow);}public static Ę Ż(){return new Ę(60,21,50,20,'H',Color.White);}public static Ę Ź(){return new Ę(55,34,50,20,
'X',new Color(255,32,0));}public static Ę Ÿ(){return new Ę(60,8,40,10,'I',Color.Green,false);}public static Ę ŷ(){return
new Ę(50,21,40,10,'W',new Color(0,16,255),false);}}string Ŷ="12.3.0";const int ŵ=3000;const int Ŵ=1000;const int ų=1200;
const float Ų=80f;const float ź=95f;char ƀ='\u25BC';char Ɗ='\u25B2';char ƕ='\u25BA';char Ɠ='\u25C4';const char ƒ='\u2588';
const char Ƒ='\u2592';const char Ɛ='\u2591';const float Ə=1.7f;bool Ǝ;IMyMotorSuspension[]ƍ;IMyShipController ƌ;List<
IMyTextSurface>Ɣ;IMyTextSurface Ƌ;IMyTextSurface Ɖ;IMyRadioAntenna ƈ;IMySensorBlock Ƈ;IMySensorBlock Ɔ;IMySensorBlock ƅ;List<IMyGyro>Ƅ
;bool ƃ;bool Ƃ;bool Ɓ;StringBuilder ű;ĺ Ş;List<IMyLightingBlock>ŧ;List<IMyLightingBlock>ŝ;List<IMyLightingBlock>Ŝ;List<
IMyLightingBlock>ś;Ę Ś;long ř=-1;IMyBroadcastListener Ř;int ŗ;int Ŗ;DateTime ŕ;float Ŕ;float œ=1f;bool Œ=false;int ő;bool Ő;List<
MyDetectedEntityInfo>ŏ;Program(){Ş=new ĺ();try{I();G();C();Z();U();ÿ();R();ü();Ŏ();ù();Đ();Ā();û();}catch(Exception ex){Ǝ=true;Echo(ex.
Message);return;}Runtime.UpdateFrequency=UpdateFrequency.Update1;ŕ=DateTime.Now;}void Ŏ(){ŏ=new List<MyDetectedEntityInfo>();Ɔ=
(IMySensorBlock)GridTerminalSystem.GetBlockWithName(MIRROR_SENSOR_RIGHT_NAME);if(Ɔ!=null){Ɔ.DetectSmallShips=true;Ɔ.
DetectLargeShips=false;Ɔ.DetectPlayers=false;Ɔ.LeftExtend=12.5f;Ɔ.RightExtend=0.5f;Ɔ.FrontExtend=50;Ɔ.BackExtend=5;Ɔ.TopExtend=5;Ɔ.
BottomExtend=5;}ƅ=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(MIRROR_SENSOR_LEFT_NAME);if(ƅ!=null){ƅ.DetectSmallShips=true;ƅ
.DetectLargeShips=false;ƅ.DetectPlayers=false;ƅ.LeftExtend=0.5f;ƅ.RightExtend=12.5f;ƅ.FrontExtend=50;ƅ.BackExtend=5;ƅ.
TopExtend=5;ƅ.BottomExtend=5;}}void Save(){}void Main(string Č,UpdateType Ű){if(Ǝ){return;}var Ů=DateTime.Now;Ŕ=(float)(Ů-ŕ).
TotalMilliseconds/1000;Echo($"Running FSESS {Ŷ}");č(Č);Í();Ç();Ŭ();Î();M();O();ũ();ť();N();ŭ();ŕ=Ů;}void ŭ(){if(!Ő){return;}if(Vector3D.
Dot(ƌ.GetNaturalGravity(),ƌ.WorldMatrix.Up)>0){for(int k=0;k<Ƅ.Count;k++){Ƅ[k].GyroOverride=true;}return;}if(Ƅ[0].
GyroOverride){for(int k=0;k<Ƅ.Count;k++){Ƅ[k].GyroOverride=false;}Ő=false;}}void Ŭ(){switch(Ş.ğ){case Ň.Ņ:ū();break;case Ň.ń:Ū();
break;default:if(!ƃ){ƌ.HandBrake=false;ć(ź);}break;}}void ū(){Ƃ=false;Ɓ=false;ƌ.HandBrake=ƌ.GetShipSpeed()>50;ć(50f);}void Ū(
){Ƃ=false;Ɓ=false;ƃ=false;ƌ.HandBrake=true;}void ũ(){var ů=IGC.UnicastListener;if(!ů.HasPendingMessage){ŗ-=(int)(Ŕ*1000);
if(Ř.HasPendingMessage&&ŗ<=0){var Ũ=Ř.AcceptMessage();if(Ũ.Tag=="Address"){ř=Convert.ToInt64(Ũ.Data.ToString());IGC.
SendUnicastMessage(ř,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ů.HasPendingMessage){var Ŧ=ů.AcceptMessage();if(Ŧ.
Tag=="RaceData"){Ş.Ě(Ŧ.Data.ToString());}if(Ŧ.Tag=="Argument"){č(Ŧ.Data.ToString());}}ŗ=ŵ;}void ť(){ű.Clear();const int Ť=
21;const int ţ=8;const int Ţ=Ť-6;var š=new char[Ť,ţ];var Å=ƌ.GetShipSpeed();var Š=Ś.Ė;var ş=$"{Math.Floor(Å)}m/s";var Þ=Ý(
'E',6,œ,1);var À=Ý(Š,6,Ś.đ,100);var ó=Ş.Ğ==Ń.Ł?"<CLEAR>":"<RAIN>";var µ=Ş.ĝ<100?$"RoR:{Ş.ĝ,2}%":$"RoR:{Ş.ĝ,3}";var ª=Ş.Ĝ<=0
?$"{ó} {µ.PadLeft(Ţ-1-ó.Length)}":$" <RAIN IN {Ş.Ĝ,2}s> ";var z=(Ƃ?"DRS":"   ")+" "+(Ɓ?"ERS":"   ")+" "+(Œ?"DFT":"   ")+
" "+(ƃ?"PIT":"   ");var y=æ(true);var w=æ(false);var v=w.PadRight((int)Math.Ceiling((float)Ţ/2)-(int)Math.Ceiling((float)ş.
Length/2))+ş+y.PadLeft((int)Math.Floor((float)Ţ/2)-(int)Math.Floor((float)ş.Length/2));ű.AppendLine($"{À[0]}{v}{Þ[0]}");ű.
AppendLine($"{À[1]}{z}{Þ[1]}");ű.AppendLine($"{À[2]}P:{Ş.Ĺ:00}/{Ş.ĵ:00} L:{(Ş.ģ):00}/{Ş.ī:00}{Þ[2]}");ű.AppendLine(
$"{À[3]}TIME: {Ş.ġ}{Þ[3]}");ű.AppendLine($"{À[4]}BEST: {Ş.Ġ}{Þ[4]}");ű.AppendLine($"{À[5]} S1-  S2-  S3- {Þ[5]}");ű.AppendLine($"{À[6]}{ª}{Þ[6]}")
;if(ŗ<=0){ű.AppendLine($"{À[7]} NO CONNECTION {Þ[7]}");}else{ű.AppendLine($"{À[7]}               {Þ[7]}");}var u=ű.
ToString();Ƌ?.WriteText(u);foreach(var X in Ɣ){var t=X.DrawFrame();var r=Color.Black;var q=DEFAULT_FONT_COLOR;switch(Ş.ğ){case Ň
.Ņ:r=Color.Yellow;q=Color.Black;break;case Ň.ń:r=Color.Red;q=Color.White;break;case Ň.Ō:r=Color.Blue;q=Color.White;break;
}X.BackgroundColor=r;X.ScriptBackgroundColor=r;X.FontColor=q;var p=X.SurfaceSize.X/256;var o=p*0.6f;var n=MySprite.
CreateText(u,"Monospace",q,o);n.Position=new Vector2(128*p,18*p);t.Add(n);var m=MathHelper.Clamp(Math.Round(Å/(100f/15)),0,100);
for(int k=0;k<m;k++){var j=8f*p;var º=2f*p;var h=(X.SurfaceSize.X/2)-((15f*j+14f*º)/2)+j/2;var Á=new Vector2(h+(j+º)*k,j+º)
;var Ñ=new Vector2(j);var Ï=MySprite.CreateSprite("Circle",Á,Ñ);if(k<5){Ï.Color=Color.Lime;}else if(k<10){Ï.Color=Color.
Red;}else{Ï.Color=Color.Blue;}t.Add(Ï);}t.Dispose();}if(Ɖ!=null&&Ş!=null&&Ş.ě!=null){Ɖ.WriteText(Ş.ě);}}void Î(){if(!ƃ){
foreach(var K in ƍ){K.Power=Ų;K.SetValueFloat("Speed Limit",ź*3.6f);}return;}foreach(var K in ƍ){K.Power=20f;K.SetValueFloat(
"Speed Limit",26f*3.6f);}var Å=ƌ.GetShipSpeed();ƌ.HandBrake=Å>24;}void Í(){var Ì=ƌ.MoveIndicator.Z>0||ƌ.MoveIndicator.Y>0||ƌ.
HandBrake;if(Ì){Ƃ=false;}var Ë=ð(Ŀ.ľ);var Ð=ð(Ŀ.Ľ);var Ê=ð(Ŀ.ļ);var É=ð(Ŀ.Ļ);var È=(!Ƃ?-150f:150f)*Ŕ;Ë.Strength=MathHelper.Clamp(
Ë.Strength+È,DEFAULT_SUSPENSION_STRENGTH_F,100);Ð.Strength=MathHelper.Clamp(Ð.Strength+È,DEFAULT_SUSPENSION_STRENGTH_F,
100);Ê.Strength=MathHelper.Clamp(Ê.Strength+È,DEFAULT_SUSPENSION_STRENGTH_R,100);É.Strength=MathHelper.Clamp(É.Strength+È,
DEFAULT_SUSPENSION_STRENGTH_R,100);foreach(var P in Ŝ){P.Color=Ƃ?Color.Blue:Color.Black;P.Enabled=Ƃ;}}void Ç(){if(ƃ){Ɓ=false;}var Æ=ƌ.MoveIndicator.Z
<0;var Å=ƌ.GetShipSpeed();const float Ä=1f/135;const float Ã=1f/45;if(Å>=1){if(!Ɓ||(Ɓ&&!Æ)){var Â=(float)MathHelper.Clamp
(Å/ź,0f,1f);œ+=Ä*Â*Ŕ;}else{var Â=1;œ-=Ã*Â*Ŕ;}}œ=MathHelper.Clamp(œ,0,1);if(œ<=0){Ɓ=false;}foreach(var K in ƍ){K.Power=ä()
;}var J=ñ();ć(J);var Q=Ɓ&&Æ?Ə:0;í(Q);foreach(var P in ŝ){P.Color=Ɓ?Color.Cyan:Color.Black;}}void O(){Ś.Ĭ(ƌ,ƍ,ŧ,ś,Ş,Ŕ);ą()
;}void N(){if(ƈ==null){return;}ƈ.HudText=$"P{Ş.Ĺ}";}void M(){if(Ƈ==null){return;}var L=!Ƈ.Closed&&Ƈ.IsActive&&ƌ.
GetShipSpeed()>=70;if(L){ő=ų;}if(ƃ){ő=0;}Œ=ő>0;foreach(var K in ƍ){K.Power=ä();var J=ñ();K.SetValueFloat("Speed Limit",J*3.6f);}ő-=(
int)(Ŕ*1000);}void I(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}var H=TEAM_TAG;if(TEAM_TAG==string.Empty){H="XXX";}H=H.Trim().Substring(0,3).ToUpper();Me.CubeGrid.CustomName=
$"{H} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void G(){var F=new List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(F);var E=F.FirstOrDefault(D=>D is
IMyRemoteControl)??F.FirstOrDefault(D=>D is IMyCockpit);if(E==null){throw new Exception("No cockpit or remote control!");}ƌ=E;}void C(){
var B=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(B,K=>K.CubeGrid==Me.CubeGrid);if(B==null||B.Count!=
4){throw new Exception("Need 4 suspensions!");}var A=B.FirstOrDefault(K=>K.CustomName.Contains("FL"));if(A==null)throw
new Exception("FL suspension not found.");var g=B.FirstOrDefault(K=>K.CustomName.Contains("FR"));if(g==null)throw new
Exception("FR suspension not found.");var e=B.FirstOrDefault(K=>K.CustomName.Contains("RL"));if(e==null)throw new Exception(
"RL suspension not found.");var a=B.FirstOrDefault(K=>K.CustomName.Contains("RR"));if(a==null)throw new Exception("RR suspension not found.");ƍ=
new IMyMotorSuspension[4];ï(Ŀ.Ľ,A);ï(Ŀ.ľ,g);ï(Ŀ.Ļ,e);ï(Ŀ.ļ,a);}void Z(){ű=new StringBuilder();Ɣ=new List<IMyTextSurface>{Me
.GetSurface(0)};var Y=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(Y!=null){Ɣ.Add(Y);}foreach(var
X in Ɣ){X.ContentType=ContentType.SCRIPT;X.Alignment=TextAlignment.CENTER;X.Script="None";X.Font="Monospace";}if(
COCKPIT_DISPLAY_INDEX.HasValue){var f=ƌ as IMyCockpit;if(f!=null){var X=f.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(X!=null){Ɣ
.Add(X);}}}var W=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(W!=null){W.WriteText(string.
Empty);W.ContentType=ContentType.TEXT_AND_IMAGE;W.Alignment=TextAlignment.CENTER;W.Font="Monospace";((IMyTerminalBlock)W).
CustomData=TEXT_DISPLAY_HUDLCD;Ƌ=W;}var V=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(V!=null){V.
WriteText(string.Empty);V.ContentType=ContentType.TEXT_AND_IMAGE;V.Alignment=TextAlignment.CENTER;V.Font="Monospace";((
IMyTerminalBlock)V).CustomData=RANK_DISPLAY_HUDLCD;Ɖ=V;}}void U(){var S=new List<IMyLightingBlock>();GridTerminalSystem.
GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocksOfType<IMyLightingBlock>(S,T=>T.CubeGrid==Me.CubeGrid);if(S.Count<=0){throw new
Exception($"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}ŧ=new List<IMyLightingBlock>();foreach(var P in S){P.Intensity=5f;P.
BlinkLength=50f;P.BlinkIntervalSeconds=0f;ŧ.Add(P);}ś=new List<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(ś,T=>T.
CubeGrid!=Me.CubeGrid);foreach(var P in ś){P.BlinkLength=50f;P.BlinkIntervalSeconds=0;}}void R(){Ŝ=new List<IMyLightingBlock>();
var S=new List<IMyTerminalBlock>();var Ò=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(Ò==null){return
;}Ò.GetBlocks(S,T=>T.CubeGrid==Me.CubeGrid);foreach(var P in S){var þ=(IMyLightingBlock)P;Ŝ.Add(þ);}}void ÿ(){ŝ=new List<
IMyLightingBlock>();var S=new List<IMyTerminalBlock>();var Ò=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(Ò==null)
{return;}Ò.GetBlocks(S,T=>T.CubeGrid==Me.CubeGrid);foreach(var P in S){var þ=(IMyLightingBlock)P;þ.Radius=4f;þ.Intensity=
10f;þ.BlinkLength=50f;þ.BlinkIntervalSeconds=0.5f;ŝ.Add(þ);}}void Ā(){var ý=(IMySensorBlock)GridTerminalSystem.
GetBlockWithName(DRAFTING_SENSOR_NAME);if(ý==null){return;}Ƈ=ý;Ƈ.TopExtend=50;Ƈ.BottomExtend=0;Ƈ.RightExtend=2.25f;Ƈ.LeftExtend=2.25f;Ƈ.
FrontExtend=0;Ƈ.BackExtend=2;Ƈ.DetectSmallShips=true;Ƈ.DetectLargeShips=false;Ƈ.DetectStations=false;Ƈ.DetectSubgrids=false;Ƈ.
DetectAsteroids=false;Ƈ.DetectPlayers=false;}void û(){var ú=new List<IMyGyro>();GridTerminalSystem.GetBlocksOfType(ú,ç=>ç.CubeGrid==Me.
CubeGrid);if(ú.Count<=0){throw new Exception("No gyroscope found.");}Ƅ=ú;}void ù(){if(string.IsNullOrWhiteSpace(Me.CustomData)){
Ċ(ķ.ł);return;}var ø=Me.CustomData.Split(';');if(ø.Length<3){Ċ(ķ.ł);return;}var ö=Convert.ToChar(ø[0]);var õ=(float)
Convert.ToDouble(ø[1]);var ô=(float)Convert.ToDouble(ø[2]);switch(ö){case'U':Ċ(ķ.ĸ);break;case'S':Ċ(ķ.ł);break;case'M':Ċ(ķ.ō);
break;case'H':Ċ(ķ.ŋ);break;case'X':Ċ(ķ.Ŋ);break;case'I':Ċ(ķ.ŉ);break;case'W':Ċ(ķ.ň);break;default:Ċ(ķ.ł);break;}Ś.ĕ=õ;œ=ô;}
void ü(){var ā=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(ā);var Ĉ=ā.FirstOrDefault();if(Ĉ==null){throw
new Exception("No antenna!");}Ĉ.Enabled=true;Ĉ.Radius=5000;Ĉ.EnableBroadcasting=true;Ĉ.HudText=
$"(P{Ş.Ĺ}) {DRIVER_NAME}-{DRIVER_NUMBER}";ƈ=Ĉ;}void Đ(){IGC.RegisterBroadcastListener("Address");var Ď=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners
(Ď);Ř=Ď.FirstOrDefault();}void č(string Č){if(Č.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){ƃ=!ƃ;return;}
if(Č.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){ƃ=true;return;}if(Č.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){ƃ=false;return;}if(Č.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){Ƃ=!Ƃ;return;}if(Č.Equals("DRS_ON",
StringComparison.InvariantCultureIgnoreCase)){Ƃ=true;return;}if(Č.Equals("DRS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ƃ=false
;return;}if(Č.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ɓ=!Ɓ;return;}if(Č.Equals("ERS_ON",
StringComparison.InvariantCultureIgnoreCase)){Ɓ=true;return;}if(Č.Equals("ERS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ɓ=false
;return;}if(Č.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){ċ(ķ.ĸ);return;}if(Č.Equals("SOFT",
StringComparison.InvariantCultureIgnoreCase)){ċ(ķ.ł);return;}if(Č.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){ċ(ķ.ō);
return;}if(Č.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){ċ(ķ.ŋ);return;}if(Č.Equals("EXTRA",StringComparison.
InvariantCultureIgnoreCase)){ċ(ķ.Ŋ);return;}if(Č.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){ċ(ķ.ŉ);return;}if(Č.Equals("WET",
StringComparison.InvariantCultureIgnoreCase)){ċ(ķ.ň);return;}if(Č.Equals("FLIP",StringComparison.InvariantCultureIgnoreCase)){Ő=true;
return;}if(Č.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){â(Ň.ņ);return;}if(Č.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){â(Ň.Ņ);return;}if(Č.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){â(Ň.ń);
return;}}void ċ(ķ ĉ){if(!ƃ||ƌ.GetShipSpeed()>1){return;}Ċ(ĉ);ą(true);}void Ċ(ķ ĉ){switch(ĉ){case ķ.ĸ:Ś=Ę.Ž();break;case ķ.ł:Ś=
Ę.ż();break;case ķ.ō:Ś=Ę.ſ();break;case ķ.ŋ:Ś=Ę.Ż();break;case ķ.Ŋ:Ś=Ę.Ź();break;case ķ.ŉ:Ś=Ę.Ÿ();break;case ķ.ň:Ś=Ę.ŷ();
break;default:break;}ď(Ś.Ĳ);foreach(var K in ƍ){K.ApplyAction("Add Top Part");K.Friction=Ś.Ĕ;}}void ď(Color ë){foreach(var P
in ŧ){P.Color=ë;P.BlinkIntervalSeconds=0;}foreach(var P in ś){if(P.IsSameConstructAs(Me)){P.Color=ë;P.BlinkIntervalSeconds
=0;}}}void ć(float Ć){foreach(var K in ƍ){K.SetValueFloat("Speed Limit",Ć*3.6f);}}void ą(bool Ą=false){Ŗ-=(int)(Ŕ*1000);
if(!Ą&&Ŗ>0){return;}var ă=Ś.Ė;Me.CustomData=$"{ă};{Ś.ĕ};{œ}";Ŗ=Ŵ;}string Ă(){var ò=string.Empty;switch(Ş.ğ){case Ň.Ō:ò=
"Blue";break;case Ň.ņ:ò="Green";break;case Ň.ń:ò="Red";break;case Ň.Ņ:ò="Yellow";break;}return ò;}Color ã(){var ë=Color.Black;
switch(Ş.ğ){case Ň.Ō:ë=Color.Blue;break;case Ň.ņ:ë=Color.Green;break;case Ň.ń:ë=Color.Red;break;case Ň.Ņ:ë=Color.Yellow;break;
}return ë;}string á(){const int à=6;var ß=Ɓ?ƀ:œ<1?Ɗ:'-';var Þ=ß+"E:";for(int k=0;k<à;k++){var Â=1f/à;if(œ>Â*k){if(œ<Â*(k+
1)){Þ+=Ƒ;continue;}Þ+=ƒ;}else{Þ+=Ɛ;}}return Þ;}string[]Ý(char Ü,int Û,float Ú,float Ù){var Ø=new string[Û+2];Ø[0]=
$"┌{Ü}┐";var Ö=Math.Floor(100*Ú/Ù);for(int k=1;k<Ø.Length-1;k++){var Õ=k-1;var Â=100f/Û;var Ô=Ø.Length-1-k;if(Ö>Â*Õ){if(Ö<Â*(Õ+1
)){Ø[Ô]=$"│{Ƒ}│";continue;}Ø[Ô]=$"│{ƒ}│";}else{Ø[Ô]=$"│{Ɛ}│";}}Ø[Ø.Length-1]=Ö<100?$"{Ö+"%",3}":$"{Ö}";return Ø;}void â(Ň
Ó){if(ř<=0){return;}IGC.SendUnicastMessage(ř,"Flag",$"{(int)Ó}");}float ä(){if(ƃ){return 20f;}if(Œ||Ɓ){return 100f;}
return Ų;}float ñ(){if(ƃ){return 26;}if(Ş.ğ==Ň.Ņ){return 45;}if(Œ){return 999;}if(Ɓ){return 98f;}return ź;}IMyMotorSuspension
ð(Ŀ Á){return ƍ[(int)Á];}void ï(Ŀ Á,IMyMotorSuspension î){if(î==null){return;}ƍ[(int)Á]=î;}void í(float ì){var A=ð(Ŀ.Ľ);
var g=ð(Ŀ.ľ);var e=ð(Ŀ.Ļ);var a=ð(Ŀ.ļ);A.PropulsionOverride=ì;g.PropulsionOverride=-ì;e.PropulsionOverride=ì;a.
PropulsionOverride=-ì;}float ê(IMySensorBlock é){if(é==null||é.Closed||!é.IsActive){return float.MaxValue;}ŏ.Clear();é.DetectedEntities(ŏ)
;if(ŏ.Count<=0){return float.MaxValue;}var Á=Me.CubeGrid.GetPosition();var è=ŏ.Select(ç=>Vector3.Distance(Á,ç.Position)).
Min();return è;}string æ(bool å){var ĥ=ê(å?Ɔ:ƅ);if(ĥ==float.MaxValue){return string.Empty;}var ß=å?ƕ:Ɠ;if(ĥ<15){return
$"{ß}{ß}{ß}";}if(ĥ<30){return$"{ß}{ß}";}return$"{ß}";}