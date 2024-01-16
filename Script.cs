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

enum ĺ{Ĺ,Ļ,ő,ŏ,Ŏ,ō,Ō}enum ŋ{Ŋ,ŉ,ň,Ň}enum ņ{Ņ,ń}enum Ń{ł,Ł,ŀ,Ŀ}class ľ{public int Ľ{get;set;}public int ļ{get;set;}public
int Ő{get;set;}public int ĸ{get;set;}public string ķ{get;set;}="--:--.---";public string Ĩ{get;set;}="--:--.---";public ŋ ħ
{get;set;}public ņ Ħ{get;set;}public int ĥ{get;set;}public int Ĥ{get;set;}public string ģ{get;set;}public void Ģ(string ġ
){try{var ù=ġ.Split(';');Ő=Convert.ToInt32(ù[0]);Ľ=Convert.ToInt32(ù[1]);ķ=ù[2];Ĩ=ù[3];ļ=Convert.ToInt32(ù[4]);ĸ=Convert.
ToInt32(ù[5]);ħ=(ŋ)Convert.ToInt32(ù[6]);Ħ=(ņ)Convert.ToInt32(ù[7]);ĥ=Convert.ToInt32(ù[8]);Ĥ=Convert.ToInt32(ù[9]);ģ=ù[10];}
catch(Exception){}}}class Ġ{private float Ğ;public char ĝ{get;private set;}public float Ĝ{get;set;}public float ě{get;private
set;}public float Ě{get;private set;}public float ę{get;private set;}public float Ę{get;private set;}public float ė{get{
return((Ĝ-Ě)/(ě-Ě))*100f;}}public int ğ{get;private set;}public bool Ė{get;private set;}public Color ĩ{get;private set;}
private Ġ(float Ķ,int ĵ,float Ĵ,float ĳ,char Ĳ,Color ä,bool ı=true){ě=Ķ;Ĝ=ě;ğ=ĵ;ę=Ĵ;Ę=ĳ;Ě=(float)Math.Round(ę-((ě-ę)/(100-Ę))*Ę
,2);ĝ=Ĳ;ĩ=ä;Ė=ı;Ğ=(ě-Ě)/(60*ğ);}public void İ(IMyShipController į,IMyMotorSuspension[]h,List<IMyLightingBlock>Į,List<
IMyLightingBlock>ĭ,ľ ġ,float Ĭ){var m=į.GetShipSpeed();if(m<1){return;}var ī=(float)MathHelper.Clamp(m,0,90)/90;var Ī=Ğ*ī*Ĭ;Ĝ-=Ī;Ĝ=
MathHelper.Clamp(Ĝ,Ě,ě);foreach(var G in h){G.Friction=!(Ė&&ġ.Ħ==ņ.ń)?Ĝ:Ĝ/2;}if(ė<=Ę){if(ĭ.Any(M=>M.BlinkIntervalSeconds<=0)){
foreach(var M in Į){M.BlinkIntervalSeconds=0.25f;}foreach(var M in ĭ){M.BlinkIntervalSeconds=0.25f;}}}else{if(ĭ.Any(M=>M.
BlinkIntervalSeconds>0)){foreach(var M in Į){M.BlinkIntervalSeconds=0f;}foreach(var M in ĭ){M.BlinkIntervalSeconds=0f;}}}if(Ĝ<=Ě){if(h.All(G
=>G.IsAttached)){var ƈ=new Random().Next(4);h[ƈ].Detach();}}}public static Ġ Ƈ(){return new Ġ(100,5,60,20,'U',new Color(
192,0,255));}public static Ġ Ɔ(){return new Ġ(100,8,50,20,'S',Color.Red);}public static Ġ ƅ(){return new Ġ(75,13,50,20,'M',
Color.Yellow);}public static Ġ Ƅ(){return new Ġ(60,21,50,20,'H',Color.White);}public static Ġ ƃ(){return new Ġ(55,34,50,20,
'X',new Color(255,32,0));}public static Ġ Ƃ(){return new Ġ(60,8,40,10,'I',Color.Green,false);}public static Ġ Ɓ(){return
new Ġ(50,21,40,10,'W',new Color(0,16,255),false);}}string ƀ="12.4.0";const int ſ=3000;const int ž=1000;const int Ž=1200;
const float ż=80f;const float Ż=95f;char ź='\u25BC';char Ź='\u25B2';char Ÿ='\u25BA';char Ɖ='\u25C4';const char Ɗ='\u2588';
const char Ɵ='\u2592';const char Ơ='\u2591';const float ƞ=1.7f;bool Ɲ;IMyMotorSuspension[]Ɯ;IMyShipController ƛ;List<
IMyTextSurface>ƚ;IMyTextSurface ƙ;IMyTextSurface Ƙ;IMyTextSurface Ɨ;IMyRadioAntenna Ɩ;IMySensorBlock ƕ;IMySensorBlock Ɣ;IMySensorBlock
Ɠ;List<IMyGyro>ƒ;bool Ƒ;bool Ɛ;bool Ə;StringBuilder Ǝ;ľ ƍ;List<IMyLightingBlock>ƌ;List<IMyLightingBlock>Ƌ;List<
IMyLightingBlock>Ŷ;List<IMyLightingBlock>Ţ;Ġ ŵ;long Š=-1;IMyBroadcastListener ş;int Ş;int ŝ;DateTime Ŝ;float ś;float Ś=1f;bool ř=false;
int š;bool Ř;List<MyDetectedEntityInfo>Ŗ;List<MyDetectedEntityInfo>ŕ;Program(){ƍ=new ľ();try{E();C();k();Z();T();ā();Ă();Ĕ(
);Ŕ();ú();Đ();þ();ü();}catch(Exception ex){Ɲ=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.
Update1;Ŝ=DateTime.Now;}void Ŕ(){Ŗ=new List<MyDetectedEntityInfo>();Ɣ=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(
MIRROR_SENSOR_RIGHT_NAME);if(Ɣ!=null){Ɣ.DetectSmallShips=true;Ɣ.DetectLargeShips=false;Ɣ.DetectPlayers=false;Ɣ.LeftExtend=12.5f;Ɣ.RightExtend=
0.5f;Ɣ.FrontExtend=50;Ɣ.BackExtend=5;Ɣ.TopExtend=5;Ɣ.BottomExtend=5;}Ɠ=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(
MIRROR_SENSOR_LEFT_NAME);if(Ɠ!=null){Ɠ.DetectSmallShips=true;Ɠ.DetectLargeShips=false;Ɠ.DetectPlayers=false;Ɠ.LeftExtend=0.5f;Ɠ.RightExtend=
12.5f;Ɠ.FrontExtend=50;Ɠ.BackExtend=5;Ɠ.TopExtend=5;Ɠ.BottomExtend=5;}}void Save(){}void Main(string č,UpdateType œ){if(Ɲ){
return;}var ŗ=DateTime.Now;ś=(float)(ŗ-Ŝ).TotalMilliseconds/1000;Echo($"Running FSESS {ƀ}");Ď(č);Í();Æ();Ŵ();Î();K();L();ű();ŭ
();Q();Œ();Ŝ=ŗ;}void Œ(){if(!Ř){return;}if(Vector3D.Dot(ƛ.GetNaturalGravity(),ƛ.WorldMatrix.Up)>0){for(int u=0;u<ƒ.Count;
u++){ƒ[u].GyroOverride=true;}return;}if(ƒ[0].GyroOverride){for(int u=0;u<ƒ.Count;u++){ƒ[u].GyroOverride=false;}Ř=false;}}
void Ŵ(){switch(ƍ.ħ){case ŋ.ŉ:ų();break;case ŋ.ň:Ų();break;default:if(!Ƒ){ƛ.HandBrake=false;Ĉ(Ż);}break;}}void ų(){Ɛ=false;Ə
=false;ƛ.HandBrake=ƛ.GetShipSpeed()>50;Ĉ(50f);}void Ų(){Ɛ=false;Ə=false;Ƒ=false;ƛ.HandBrake=true;}void ű(){var Ű=IGC.
UnicastListener;if(!Ű.HasPendingMessage){Ş-=(int)(ś*1000);if(ş.HasPendingMessage&&Ş<=0){var ů=ş.AcceptMessage();if(ů.Tag=="Address"){Š=
Convert.ToInt64(ů.Data.ToString());IGC.SendUnicastMessage(Š,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(Ű.
HasPendingMessage){var Ů=Ű.AcceptMessage();if(Ů.Tag=="RaceData"){ƍ.Ģ(Ů.Data.ToString());}if(Ů.Tag=="Argument"){Ď(Ů.Data.ToString());}}Ş=ſ
;}void ŭ(){Ǝ.Clear();const int Ŭ=21;const int ū=8;const int Ū=Ŭ-6;var ũ=new char[Ŭ,ū];var m=ƛ.GetShipSpeed();var Ũ=ŵ.ĝ;
var ŧ=$"{Math.Floor(m)}m/s";var à=æ('E',6,Ś,1);var Ŧ=æ(Ũ,6,ŵ.ė,100);var ť=ƍ.Ħ==ņ.Ņ?"<CLEAR>":"<RAIN>";var Ť=ƍ.ĥ<100?
$"RoR:{ƍ.ĥ,2}%":$"RoR:{ƍ.ĥ,3}";var ţ=ƍ.Ĥ<=0?$"{ť} {Ť.PadLeft(Ū-1-ť.Length)}":$" <RAIN IN {ƍ.Ĥ,2}s> ";var ŷ=(Ɛ?"DRS":"   ")+" "+(Ə?"ERS"
:"   ")+" "+(ř?"DFT":"   ")+" "+(Ƒ?"PIT":"   ");var ĕ=ê(true);var ø=ê(false);var Â=ø.PadRight((int)Math.Ceiling((float)Ū/
2)-(int)Math.Ceiling((float)ŧ.Length/2))+ŧ+ĕ.PadLeft((int)Math.Floor((float)Ū/2)-(int)Math.Floor((float)ŧ.Length/2));var
Á=new string[8]{$"   {Â}   ",$"   {ŷ}   ",$"   P:{ƍ.Ľ:00}/{ƍ.ļ:00} L:{(ƍ.Ő):00}/{ƍ.ĸ:00}   ",$"   TIME: {ƍ.ķ}   ",
$"   BEST: {ƍ.Ĩ}   ",$"    S1-  S2-  S3-    ",$"   {ţ}   ",(Ş<=0)?$"    NO CONNECTION    ":$"                     "};for(int u=0;u<Á.Length;
u++){Ǝ.AppendLine(Á[u]);}var À=Ǝ.ToString();foreach(var W in ƚ){var º=W.DrawFrame();var µ=Color.Black;var ª=
DEFAULT_FONT_COLOR;switch(ƍ.ħ){case ŋ.ŉ:µ=Color.Yellow;ª=Color.Black;break;case ŋ.ň:µ=Color.Red;ª=Color.White;break;case ŋ.Ň:µ=Color.Blue;
ª=Color.White;break;}W.BackgroundColor=µ;W.ScriptBackgroundColor=µ;W.FontColor=ª;var Ã=W.SurfaceSize.X/256;var z=Ã*0.6f;
var w=MySprite.CreateText(À,"Monospace",ª,z);w.Position=new Vector2(128*Ã,18*Ã);º.Add(w);var v=MathHelper.Clamp(Math.Round(
m/(100f/15)),0,100);for(int u=0;u<v;u++){var t=8f*Ã;var r=2f*Ã;var q=(W.SurfaceSize.X/2)-((15f*t+14f*r)/2)+t/2;var p=new
Vector2(q+(t+r)*u,t+r);var o=new Vector2(t);var y=MySprite.CreateSprite("Circle",p,o);if(u<5){y.Color=Color.Lime;}else if(u<10)
{y.Color=Color.Red;}else{y.Color=Color.Blue;}º.Add(y);}var n=MySprite.CreateSprite("Circle",new Vector2(22,12+8+4),new
Vector2(22));n.Color=ŵ.ĩ;var Å=MySprite.CreateSprite("Circle",new Vector2(22,12+8+4),new Vector2(20));Å.Color=Color.Black;var Õ
=MySprite.CreateText(ŵ.ĝ.ToString(),"DEBUG",Color.White,0.5f*Ã);Õ.Position=new Vector2(22,12+4);var Ó=MySprite.
CreateSprite("SquareSimple",new Vector2(22,106),new Vector2(18,128));Ó.Color=new Color(32,32,32);var Ò=Ó.Size.GetValueOrDefault().Y;
var Ñ=Ò*(ŵ.ė/100);var Ð=MySprite.CreateSprite("SquareSimple",new Vector2(22,42+(Ò-Ñ/2)),new Vector2(18,Ñ));Ð.Color=ŵ.ĩ;var
Ï=MySprite.CreateText($"{Math.Floor(ŵ.ė)}%","DEBUG",Color.White,z);Ï.Position=new Vector2(22,176);n.Position*=Ã;n.Size*=Ã
;º.Add(n);Å.Position*=Ã;Å.Size*=Ã;º.Add(Å);Õ.Position*=Ã;Õ.Size*=Ã;º.Add(Õ);Ó.Position*=Ã;Ó.Size*=Ã;º.Add(Ó);Ð.Position*=
Ã;Ð.Size*=Ã;º.Add(Ð);Ï.Position*=Ã;Ï.Size*=Ã;º.Add(Ï);n=MySprite.CreateSprite("IconEnergy",new Vector2(256-22,12+8+4),new
Vector2(24));n.Color=Color.Cyan;Ó=MySprite.CreateSprite("SquareSimple",new Vector2(256-22,106),new Vector2(18,128));Ó.Color=new
Color(32,32,32);Ò=Ó.Size.GetValueOrDefault().Y;Ñ=Ò*Ś;Ð=MySprite.CreateSprite("SquareSimple",new Vector2(256-22,42+(Ò-Ñ/2)),
new Vector2(18,Ñ));Ð.Color=Color.Cyan;Ï=MySprite.CreateText($"{Math.Floor(Ś*100)}%","DEBUG",Color.White,z);Ï.Position=new
Vector2(256-22,176);n.Position*=Ã;n.Size*=Ã;º.Add(n);Ó.Position*=Ã;Ó.Size*=Ã;º.Add(Ó);Ð.Position*=Ã;Ð.Size*=Ã;º.Add(Ð);Ï.
Position*=Ã;Ï.Size*=Ã;º.Add(Ï);º.Dispose();}Ǝ.Clear();for(int u=0;u<Á.Length;u++){var M=Á[u].Substring(3,15);Ǝ.AppendLine(
$"{Ŧ[u]}{M}{à[u]}");}À=Ǝ.ToString();Ƙ?.WriteText(À);ƙ?.WriteText(À);if(Ɨ!=null&&ƍ!=null&&ƍ.ģ!=null){Ɨ.WriteText(ƍ.ģ);}}void Î(){if(!Ƒ){
foreach(var G in Ɯ){G.Power=ż;G.SetValueFloat("Speed Limit",Ż*3.6f);}return;}foreach(var G in Ɯ){G.Power=20f;G.SetValueFloat(
"Speed Limit",26f*3.6f);}var m=ƛ.GetShipSpeed();ƛ.HandBrake=m>24;}void Í(){var Ì=ƛ.MoveIndicator.Z>0||ƛ.MoveIndicator.Y>0||ƛ.
HandBrake;if(Ì){Ɛ=false;}var Ë=ò(Ń.ł);var Ê=ò(Ń.Ł);var É=ò(Ń.ŀ);var È=ò(Ń.Ŀ);var Ç=(!Ɛ?-150f:150f)*ś;Ë.Strength=MathHelper.Clamp(
Ë.Strength+Ç,DEFAULT_SUSPENSION_STRENGTH_F,100);Ê.Strength=MathHelper.Clamp(Ê.Strength+Ç,DEFAULT_SUSPENSION_STRENGTH_F,
100);É.Strength=MathHelper.Clamp(É.Strength+Ç,DEFAULT_SUSPENSION_STRENGTH_R,100);È.Strength=MathHelper.Clamp(È.Strength+Ç,
DEFAULT_SUSPENSION_STRENGTH_R,100);foreach(var M in Ŷ){M.Color=Ɛ?Color.Blue:Color.Black;M.Enabled=Ɛ;}}void Æ(){if(Ƒ){Ə=false;}var Ô=ƛ.MoveIndicator.Z
<0;var m=ƛ.GetShipSpeed();const float j=1f/135;const float P=1f/45;if(m>=1){if(!Ə||(Ə&&!Ô)){var O=(float)MathHelper.Clamp
(m/Ż,0f,1f);Ś+=j*O*ś;}else{var O=1;Ś-=P*O*ś;}}Ś=MathHelper.Clamp(Ś,0,1);if(Ś<=0){Ə=false;}foreach(var G in Ɯ){G.Power=õ()
;}var F=ó();Ĉ(F);var N=Ə&&Ô?ƞ:0;ï(N);foreach(var M in Ƌ){M.Color=Ə?Color.Cyan:Color.Black;}}void L(){ŵ.İ(ƛ,Ɯ,ƌ,Ţ,ƍ,ś);Ć()
;}void Q(){if(Ɩ==null){return;}Ɩ.HudText=$"P{ƍ.Ľ}";}void K(){ŕ.Clear();if(ƕ==null||ƕ.Closed){ř=false;return;}ƕ.
DetectedEntities(ŕ);var I=ŕ.Any(H=>!H.IsEmpty()&&H.Type==MyDetectedEntityType.SmallGrid&&!H.Name.Contains("Grid")&&H.Velocity.Length()>=
70);if(I){š=Ž;}if(Ƒ){š=0;}ř=š>0;foreach(var G in Ɯ){G.Power=õ();var F=ó();G.SetValueFloat("Speed Limit",F*3.6f);}š-=(int)(
ś*1000);}void E(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");
}var D=TEAM_TAG;if(TEAM_TAG==string.Empty){D="XXX";}D=D.Trim().Substring(0,3).ToUpper();Me.CubeGrid.CustomName=
$"{D} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void C(){var B=new List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(B);var J=B.FirstOrDefault(A=>A is
IMyRemoteControl)??B.FirstOrDefault(A=>A is IMyCockpit);if(J==null){throw new Exception("No cockpit or remote control!");}ƛ=J;}void k(){
var h=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(h,G=>G.CubeGrid==Me.CubeGrid);if(h==null||h.Count!=
4){throw new Exception("Need 4 suspensions!");}var g=h.FirstOrDefault(G=>G.CustomName.Contains("FL"));if(g==null)throw
new Exception("FL suspension not found.");var f=h.FirstOrDefault(G=>G.CustomName.Contains("FR"));if(f==null)throw new
Exception("FR suspension not found.");var e=h.FirstOrDefault(G=>G.CustomName.Contains("RL"));if(e==null)throw new Exception(
"RL suspension not found.");var a=h.FirstOrDefault(G=>G.CustomName.Contains("RR"));if(a==null)throw new Exception("RR suspension not found.");Ɯ=
new IMyMotorSuspension[4];ñ(Ń.Ł,g);ñ(Ń.ł,f);ñ(Ń.Ŀ,e);ñ(Ń.ŀ,a);}void Z(){Ǝ=new StringBuilder();ƚ=new List<IMyTextSurface>{Me
.GetSurface(0)};var Y=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(Y!=null){ƚ.Add(Y);}foreach(var
W in ƚ){W.ContentType=ContentType.SCRIPT;W.Alignment=TextAlignment.CENTER;W.Script=string.Empty;}if(COCKPIT_DISPLAY_INDEX
.HasValue){var X=ƛ as IMyCockpit;if(X!=null){var W=X.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(W!=null){W.
WriteText(string.Empty);W.ContentType=ContentType.TEXT_AND_IMAGE;W.Alignment=TextAlignment.CENTER;W.Font="Monospace";ƙ=W;}}}var V
=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(V!=null){V.WriteText(string.Empty);V.
ContentType=ContentType.TEXT_AND_IMAGE;V.Alignment=TextAlignment.CENTER;V.Font="Monospace";((IMyTerminalBlock)V).CustomData=
TEXT_DISPLAY_HUDLCD;Ƙ=V;}var U=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(U!=null){U.WriteText(string.Empty)
;U.ContentType=ContentType.TEXT_AND_IMAGE;U.Alignment=TextAlignment.CENTER;U.Font="Monospace";((IMyTerminalBlock)U).
CustomData=RANK_DISPLAY_HUDLCD;Ɨ=U;}}void T(){var S=new List<IMyLightingBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocksOfType<IMyLightingBlock>(S,R=>R.CubeGrid==Me.CubeGrid);if(S.Count<=0){throw new Exception(
$"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}ƌ=new List<IMyLightingBlock>();foreach(var M in S){M.Intensity=5f;M.BlinkLength=50f;M.BlinkIntervalSeconds=0f;ƌ.Add(M
);}Ţ=new List<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(Ţ,R=>R.CubeGrid!=Me.CubeGrid);foreach(var M in Ţ){M.
BlinkLength=50f;M.BlinkIntervalSeconds=0;}}void Ă(){Ŷ=new List<IMyLightingBlock>();var S=new List<IMyTerminalBlock>();var Ā=
GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(Ā==null){return;}Ā.GetBlocks(S,R=>R.CubeGrid==Me.CubeGrid);foreach(var
M in S){var ÿ=(IMyLightingBlock)M;Ŷ.Add(ÿ);}}void ā(){Ƌ=new List<IMyLightingBlock>();var S=new List<IMyTerminalBlock>();
var Ā=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(Ā==null){return;}Ā.GetBlocks(S,R=>R.CubeGrid==Me.
CubeGrid);foreach(var M in S){var ÿ=(IMyLightingBlock)M;ÿ.Radius=4f;ÿ.Intensity=10f;ÿ.BlinkLength=50f;ÿ.BlinkIntervalSeconds=
0.5f;Ƌ.Add(ÿ);}}void þ(){var ý=(IMySensorBlock)GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(ý==null){return;
}ƕ=ý;ƕ.TopExtend=50;ƕ.BottomExtend=0;ƕ.RightExtend=2.25f;ƕ.LeftExtend=2.25f;ƕ.FrontExtend=0;ƕ.BackExtend=2;ƕ.
DetectSmallShips=true;ƕ.DetectLargeShips=false;ƕ.DetectStations=false;ƕ.DetectSubgrids=false;ƕ.DetectAsteroids=false;ƕ.DetectPlayers=
false;ŕ=new List<MyDetectedEntityInfo>();}void ü(){var û=new List<IMyGyro>();GridTerminalSystem.GetBlocksOfType(û,H=>H.
CubeGrid==Me.CubeGrid);if(û.Count<=0){throw new Exception("No gyroscope found.");}ƒ=û;}void ú(){if(string.IsNullOrWhiteSpace(Me.
CustomData)){ċ(ĺ.Ļ);return;}var ù=Me.CustomData.Split(';');if(ù.Length<3){ċ(ĺ.Ļ);return;}var ă=Convert.ToChar(ù[0]);var Ą=(float)
Convert.ToDouble(ù[1]);var ē=(float)Convert.ToDouble(ù[2]);switch(ă){case'U':ċ(ĺ.Ĺ);break;case'S':ċ(ĺ.Ļ);break;case'M':ċ(ĺ.ő);
break;case'H':ċ(ĺ.ŏ);break;case'X':ċ(ĺ.Ŏ);break;case'I':ċ(ĺ.ō);break;case'W':ċ(ĺ.Ō);break;default:ċ(ĺ.Ļ);break;}ŵ.Ĝ=Ą;Ś=ē;}
void Ĕ(){var Ē=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(Ē);var đ=Ē.FirstOrDefault();if(đ==null){throw
new Exception("No antenna!");}đ.Enabled=true;đ.Radius=5000;đ.EnableBroadcasting=true;đ.HudText=
$"(P{ƍ.Ľ}) {DRIVER_NAME}-{DRIVER_NUMBER}";Ɩ=đ;}void Đ(){IGC.RegisterBroadcastListener("Address");var ď=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners
(ď);ş=ď.FirstOrDefault();}void Ď(string č){if(č.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){Ƒ=!Ƒ;return;}
if(č.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){Ƒ=true;return;}if(č.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){Ƒ=false;return;}if(č.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){Ɛ=!Ɛ;return;}if(č.Equals("DRS_ON",
StringComparison.InvariantCultureIgnoreCase)){Ɛ=true;return;}if(č.Equals("DRS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ɛ=false
;return;}if(č.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ə=!Ə;return;}if(č.Equals("ERS_ON",
StringComparison.InvariantCultureIgnoreCase)){Ə=true;return;}if(č.Equals("ERS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ə=false
;return;}if(č.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){Č(ĺ.Ĺ);return;}if(č.Equals("SOFT",
StringComparison.InvariantCultureIgnoreCase)){Č(ĺ.Ļ);return;}if(č.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Č(ĺ.ő);
return;}if(č.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){Č(ĺ.ŏ);return;}if(č.Equals("EXTRA",StringComparison.
InvariantCultureIgnoreCase)){Č(ĺ.Ŏ);return;}if(č.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){Č(ĺ.ō);return;}if(č.Equals("WET",
StringComparison.InvariantCultureIgnoreCase)){Č(ĺ.Ō);return;}if(č.Equals("FLIP",StringComparison.InvariantCultureIgnoreCase)){Ř=true;
return;}if(č.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){Ö(ŋ.Ŋ);return;}if(č.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){Ö(ŋ.ŉ);return;}if(č.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){Ö(ŋ.ň);
return;}}void Č(ĺ Ċ){if(!Ƒ||ƛ.GetShipSpeed()>1){return;}ċ(Ċ);Ć(true);}void ċ(ĺ Ċ){switch(Ċ){case ĺ.Ĺ:ŵ=Ġ.Ƈ();break;case ĺ.Ļ:ŵ=
Ġ.Ɔ();break;case ĺ.ő:ŵ=Ġ.ƅ();break;case ĺ.ŏ:ŵ=Ġ.Ƅ();break;case ĺ.Ŏ:ŵ=Ġ.ƃ();break;case ĺ.ō:ŵ=Ġ.Ƃ();break;case ĺ.Ō:ŵ=Ġ.Ɓ();
break;default:break;}ĉ(ŵ.ĩ);foreach(var G in Ɯ){G.ApplyAction("Add Top Part");G.Friction=ŵ.ě;}}void ĉ(Color ä){foreach(var M
in ƌ){M.Color=ä;M.BlinkIntervalSeconds=0;}foreach(var M in Ţ){if(M.IsSameConstructAs(Me)){M.Color=ä;M.BlinkIntervalSeconds
=0;}}}void Ĉ(float ć){foreach(var G in Ɯ){G.SetValueFloat("Speed Limit",ć*3.6f);}}void Ć(bool ą=false){ŝ-=(int)(ś*1000);
if(!ą&&ŝ>0){return;}var ö=ŵ.ĝ;Me.CustomData=$"{ö};{ŵ.Ĝ};{Ś}";ŝ=ž;}string ç(){var ô=string.Empty;switch(ƍ.ħ){case ŋ.Ň:ô=
"Blue";break;case ŋ.Ŋ:ô="Green";break;case ŋ.ň:ô="Red";break;case ŋ.ŉ:ô="Yellow";break;}return ô;}Color å(){var ä=Color.Black;
switch(ƍ.ħ){case ŋ.Ň:ä=Color.Blue;break;case ŋ.Ŋ:ä=Color.Green;break;case ŋ.ň:ä=Color.Red;break;case ŋ.ŉ:ä=Color.Yellow;break;
}return ä;}string ã(){const int â=6;var á=Ə?ź:Ś<1?Ź:'-';var à=á+"E:";for(int u=0;u<â;u++){var O=1f/â;if(Ś>O*u){if(Ś<O*(u+
1)){à+=Ɵ;continue;}à+=Ɗ;}else{à+=Ơ;}}return à;}string[]æ(char ß,int Ý,float Ü,float Û){var Ú=new string[Ý+2];Ú[0]=
$"┌{ß}┐";var Ù=Math.Floor(100*Ü/Û);for(int u=1;u<Ú.Length-1;u++){var Ø=u-1;var O=100f/Ý;var Þ=Ú.Length-1-u;if(Ù>O*Ø){if(Ù<O*(Ø+1
)){Ú[Þ]=$"│{Ɵ}│";continue;}Ú[Þ]=$"│{Ɗ}│";}else{Ú[Þ]=$"│{Ơ}│";}}Ú[Ú.Length-1]=Ù<100?$"{Ù+"%",3}":$"{Ù}";return Ú;}void Ö(ŋ
è){if(Š<=0){return;}IGC.SendUnicastMessage(Š,"Flag",$"{(int)è}");}float õ(){if(Ƒ){return 20f;}if(ř||Ə){return 100f;}
return ż;}float ó(){if(Ƒ){return 26;}if(ƍ.ħ==ŋ.ŉ){return 45;}if(ř){return 999;}if(Ə){return 98f;}return Ż;}IMyMotorSuspension
ò(Ń p){return Ɯ[(int)p];}void ñ(Ń p,IMyMotorSuspension ð){if(ð==null){return;}Ɯ[(int)p]=ð;}void ï(float î){var g=ò(Ń.Ł);
var f=ò(Ń.ł);var e=ò(Ń.Ŀ);var a=ò(Ń.ŀ);g.PropulsionOverride=î;f.PropulsionOverride=-î;e.PropulsionOverride=î;a.
PropulsionOverride=-î;}float í(IMySensorBlock ì){if(ì==null||ì.Closed||!ì.IsActive){return float.MaxValue;}Ŗ.Clear();ì.DetectedEntities(Ŗ)
;if(Ŗ.Count<=0){return float.MaxValue;}var p=Me.CubeGrid.GetPosition();var ë=Ŗ.Select(H=>Vector3.Distance(p,H.Position)).
Min();return ë;}string ê(bool é){var Ä=í(é?Ɣ:Ɠ);if(Ä==float.MaxValue){return string.Empty;}var á=é?Ÿ:Ɖ;if(Ä<15){return
$"{á}{á}{á}";}if(Ä<30){return$"{á}{á}";}return$"{á}";}