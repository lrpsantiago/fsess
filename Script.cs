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

enum Ġ{ġ,ğ,Ģ,Ĵ,Ĳ,ı}enum İ{į,Į,ĭ,Ĭ}enum ĳ{ī,Ī}enum ĩ{Ĩ,ħ,Ħ,ĥ}class Ĥ{public int ģ{get;set;}public int Ğ{get;set;}public
int č{get;set;}public int ý{get;set;}public string ċ{get;set;}="--:--.---";public string Ċ{get;set;}="--:--.---";public İ ĉ
{get;set;}public ĳ Ĉ{get;set;}public int ć{get;set;}public int Ć{get;set;}public string ą{get;set;}public void Ą(string ă
){try{var ö=ă.Split(';');č=Convert.ToInt32(ö[0]);ģ=Convert.ToInt32(ö[1]);ċ=ö[2];Ċ=ö[3];Ğ=Convert.ToInt32(ö[4]);ý=Convert.
ToInt32(ö[5]);ĉ=(İ)Convert.ToInt32(ö[6]);Ĉ=(ĳ)Convert.ToInt32(ö[7]);ć=Convert.ToInt32(ö[8]);Ć=Convert.ToInt32(ö[9]);ą=ö[10];}
catch(Exception){}}}class Ă{private float ā;public char Ā{get;private set;}public float ÿ{get;set;}public float þ{get;private
set;}public float Č{get;private set;}public float Ď{get;private set;}public float Ĝ{get;private set;}public float ĝ{get{
return((ÿ-Č)/(þ-Č))*100f;}}public int ě{get;private set;}public bool Ě{get;private set;}public Color ę{get;private set;}
private Ă(float Ę,int ė,float Ė,float ĕ,char Ĕ,Color Ë,bool ē=true){þ=Ę;ÿ=þ;ě=ė;Ď=Ė;Ĝ=ĕ;Č=(float)Math.Round(Ď-((þ-Ď)/(100-Ĝ))*Ĝ
,2);Ā=Ĕ;ę=Ë;Ě=ē;ā=(þ-Č)/(60*ě);}public void Ē(IMyShipController đ,IMyMotorSuspension[]O,List<IMyLightingBlock>Đ,Ĥ ă,float
ĵ){var À=đ.GetShipSpeed();if(À<1){return;}var ş=(float)MathHelper.Clamp(À,0,90)/90;var ŝ=ā*ş*ĵ;ÿ-=ŝ;ÿ=MathHelper.Clamp(ÿ,
Č,þ);foreach(var I in O){I.Friction=!(Ě&&ă.Ĉ==ĳ.Ī)?ÿ:ÿ/2;}if(ĝ<=Ĝ){if(Đ.Any(P=>P.BlinkIntervalSeconds<=0)){foreach(var P
in Đ){P.BlinkIntervalSeconds=0.25f;}}}else{if(Đ.Any(P=>P.BlinkIntervalSeconds>0)){foreach(var P in Đ){P.
BlinkIntervalSeconds=0f;}}}if(ÿ<=Č){if(O.All(I=>I.IsAttached)){var Ŝ=new Random().Next(4);O[Ŝ].Detach();}}}public static Ă ś(){return new Ă(
100,8,50,20,'S',Color.Red);}public static Ă Ś(){return new Ă(75,13,50,20,'M',Color.Yellow);}public static Ă ř(){return new
Ă(60,21,50,20,'H',Color.White);}public static Ă Ř(){return new Ă(55,34,50,20,'X',new Color(255,32,0));}public static Ă ŗ(
){return new Ă(60,8,40,10,'I',Color.Green,false);}public static Ă Ŗ(){return new Ă(50,21,40,10,'W',new Color(0,16,255),
false);}}string ŕ="12.0.0";const int Ş=3000;const int Ŕ=1000;const int Š=1200;const float Ų=80f;const float Ű=96f;const char
ů='\u2191';const char Ů='\u2193';const char ŭ='\u2588';const char Ŭ='\u2592';const char ū='\u2591';const float Ū=1.7f;
bool ű;IMyMotorSuspension[]ũ;IMyShipController Ũ;List<IMyTextSurface>ŧ;IMyTextSurface Ŧ;IMyTextSurface ť;List<IMySoundBlock>
Ť;IMyRadioAntenna ţ;IMySensorBlock Ţ;List<IMyGyro>š;bool œ;bool Ň;bool Ķ;StringBuilder Ņ;Ĥ ń;List<IMyTerminalBlock>Ń;List
<IMyLightingBlock>ł;List<IMyLightingBlock>Ł;List<IMyLightingBlock>ŀ;Ă Ŀ;long ľ=-1;IMyBroadcastListener Ľ;int ļ;int Ļ;
DateTime ĺ;float Ĺ;float ĸ=1f;bool ķ=false;int ņ;bool ň;Program(){ń=new Ĥ();try{H();F();B();Y();S();ç();è();ú();ø();ð();å();ä();
ù();}catch(Exception ex){ű=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.Update1;ĺ=DateTime.Now;}
void Save(){}void Main(string í,UpdateType Œ){if(ű){return;}var ő=DateTime.Now;Ĺ=(float)(ő-ĺ).TotalMilliseconds/1000;Echo(
$"Running FSESS {ŕ}");î(í);Æ();Â();ŏ();Ç();M();A();Ō();ŉ();N();Ő();J();ĺ=ő;}void Ő(){if(!ň){return;}if(Vector3D.Dot(Ũ.GetNaturalGravity(),Ũ.
WorldMatrix.Up)>0){for(int k=0;k<š.Count;k++){š[k].GyroOverride=true;}return;}if(š[0].GyroOverride){for(int k=0;k<š.Count;k++){š[k]
.GyroOverride=false;}ň=false;}}void ŏ(){switch(ń.ĉ){case İ.Į:Ŏ();break;case İ.ĭ:ō();break;default:if(!œ){Ũ.HandBrake=
false;Ó(Ű);}break;}}void Ŏ(){Ň=false;Ķ=false;Ũ.HandBrake=Ũ.GetShipSpeed()>50;Ó(50f);}void ō(){Ň=false;Ķ=false;œ=false;Ũ.
HandBrake=true;}void Ō(){var ŋ=IGC.UnicastListener;if(!ŋ.HasPendingMessage){ļ-=(int)(Ĺ*1000);if(Ľ.HasPendingMessage&&ļ<=0){var t=
Ľ.AcceptMessage();if(t.Tag=="Address"){ľ=Convert.ToInt64(t.Data.ToString());IGC.SendUnicastMessage(ľ,"Register",
$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ŋ.HasPendingMessage){var Ŋ=ŋ.AcceptMessage();if(Ŋ.Tag=="RaceData"){ń.Ą(Ŋ.Data.ToString());}if(Ŋ.Tag==
"Argument"){î(Ŋ.Data.ToString());}}ļ=Ş;}void ŉ(){Ņ.Clear();var À=Ũ.GetShipSpeed();var ď=Ŀ.ĝ;var ü=Ŀ.Ā;var Q=((int)Math.Floor(ď)).
ToString();var z=$"{À:F0}m/s";var y=Ö();var w=ń.Ĉ==ĳ.ī?"<CLEAR>":"<RAIN>";var v=$"RoR: {ń.ć}%";var u=ń.Ć<=0?
$"{w} {v.PadLeft(15-w.Length)}":$"<RAIN IN {ń.Ć}s>";var t=string.Empty;if(œ){t="PIT LIMITER";}else{if(Ň&&ķ){t="DRAFTING (DRS)";}else if(Ň){t="DRS ON";}
else if(ķ){t="DRAFTING";}}Ņ.AppendLine(z+y.PadLeft(16-z.Length));Ņ.AppendLine(t);Ņ.AppendLine(
$"P:{ń.ģ:00}/{ń.Ğ:00}  L:{(ń.č):00}/{ń.ý:00}");Ņ.AppendLine($"TYRE ({ü})..: {Q,3}%");Ņ.AppendLine($"TIME.: {ń.ċ}");Ņ.AppendLine($"BEST.: {ń.Ċ}");Ņ.AppendLine(u);if(ļ
<=0){Ņ.AppendLine($"NO CONNECTION");}var r=Ņ.ToString();Ŧ?.WriteText(r);foreach(var V in ŧ){var q=V.DrawFrame();var p=
Color.Black;var o=DEFAULT_FONT_COLOR;switch(ń.ĉ){case İ.Į:p=Color.Yellow;o=Color.Black;break;case İ.ĭ:p=Color.Red;o=Color.
White;break;case İ.Ĭ:p=Color.Blue;o=Color.White;break;}V.BackgroundColor=p;V.ScriptBackgroundColor=p;V.FontColor=o;var n=
MySprite.CreateText(r,"Monospace",o,0.75f);n.Position=new Vector2(128,18);q.Add(n);var m=MathHelper.Clamp(Math.Round(À/(100f/15)
),0,100);for(int k=0;k<m;k++){var j=8f;var ª=2f;var h=(256/2)-((15f*j+14f*ª)/2)+j/2;var µ=new Vector2(h+(j+ª)*k,j+ª);var
É=new Vector2(j);var È=MySprite.CreateSprite("Circle",µ,É);if(k<5){È.Color=Color.Lime;}else if(k<10){È.Color=Color.Red;}
else{È.Color=Color.Blue;}q.Add(È);}q.Dispose();}if(ť!=null&&ń!=null&&ń.ą!=null){ť.WriteText(ń.ą);}}void Ç(){if(!œ){foreach(
var I in ũ){I.Power=Ų;I.SetValueFloat("Speed Limit",Ű*3.6f);}return;}foreach(var I in ũ){I.Power=20f;I.SetValueFloat(
"Speed Limit",26f*3.6f);}var À=Ũ.GetShipSpeed();Ũ.HandBrake=À>24;}void Æ(){var Å=Ũ.MoveIndicator.Z>0||Ũ.MoveIndicator.Y>0||Ũ.
HandBrake;if(Å){Ň=false;}for(int k=0;k<ũ.Length;k++){var I=ũ[k];var Ã=DEFAULT_SUSPENSION_STRENGTH_R;if(k==(int)ĩ.Ĩ||k==(int)ĩ.ħ){
Ã=DEFAULT_SUSPENSION_STRENGTH_F;}I.Strength=!Ň?Ã:100;}foreach(var P in Ł){P.Color=Ň?Color.Blue:Color.Black;P.Enabled=Ň;}}
void Â(){if(œ){Ķ=false;}var Á=Ũ.MoveIndicator.Z<0;var À=Ũ.GetShipSpeed();if(À>=1){if(!Ķ){var º=(float)MathHelper.Clamp(À/Ű,
0f,1f);ĸ+=(1f/120)*º*Ĺ;}else if(Á){var º=1;ĸ-=(1f/30)*º*Ĺ;}}ĸ=MathHelper.Clamp(ĸ,0,1);if(ĸ<=0){Ķ=false;}foreach(var I in ũ
){I.Power=ß();}var g=Ķ&&Á?Ū:0;Ú(g);foreach(var P in ł){P.Color=Ķ?Color.Cyan:Color.Black;}}void A(){Ŀ.Ē(Ũ,ũ,ŀ,ń,Ĺ);Ñ();}
void N(){if(ţ==null){return;}ţ.HudText=$"P{ń.ģ}";}void M(){if(Ţ==null){return;}var L=!Ţ.Closed&&Ţ.IsActive&&Ũ.GetShipSpeed()
>=70;if(L){ņ=Š;}if(œ){ņ=0;}ķ=ņ>0;foreach(var I in ũ){I.Power=ß();var K=Þ();I.SetValueFloat("Speed Limit",K*3.6f);}ņ-=(int)
(Ĺ*1000);}void J(){foreach(var I in Ť){}}void H(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}var G=TEAM_TAG;if(TEAM_TAG==string.Empty){G="XXX";}G=G.Trim().Substring(0,3).ToUpper();Me.CubeGrid.CustomName=
$"{G} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void F(){var E=new List<IMyShipController>();GridTerminalSystem.GetBlocksOfType(E);var D=E.FirstOrDefault(C=>C is
IMyRemoteControl)??E.FirstOrDefault(C=>C is IMyCockpit);if(D==null){throw new Exception("No cockpit or remote control!");}Ũ=D;}void B(){
var O=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(O,I=>I.CubeGrid==Me.CubeGrid);if(O==null||O.Count!=
4){throw new Exception("Need 4 suspensions!");}var f=O.FirstOrDefault(I=>I.CustomName.Contains("FL"));if(f==null)throw
new Exception("FL suspension not found.");var e=O.FirstOrDefault(I=>I.CustomName.Contains("FR"));if(e==null)throw new
Exception("FR suspension not found.");var a=O.FirstOrDefault(I=>I.CustomName.Contains("RL"));if(a==null)throw new Exception(
"RL suspension not found.");var Z=O.FirstOrDefault(I=>I.CustomName.Contains("RR"));if(Z==null)throw new Exception("RR suspension not found.");this
.ũ=new IMyMotorSuspension[4];Ü(ĩ.ħ,f);Ü(ĩ.Ĩ,e);Ü(ĩ.ĥ,a);Ü(ĩ.Ħ,Z);}void Y(){Ņ=new StringBuilder();ŧ=new List<
IMyTextSurface>{Me.GetSurface(0)};var X=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(X!=null){ŧ.Add(X);}if(
COCKPIT_DISPLAY_INDEX.HasValue){var W=Ũ as IMyCockpit;if(W!=null){var V=W.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(V!=null){ŧ
.Add(V);}}}foreach(var V in ŧ){V.ContentType=ContentType.SCRIPT;V.Alignment=TextAlignment.CENTER;V.Font="Monospace";}var
U=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(TEXT_DISPLAY_NAME);if(U!=null){U.WriteText(string.Empty);U.
ContentType=ContentType.TEXT_AND_IMAGE;U.Alignment=TextAlignment.CENTER;U.Font="Monospace";((IMyTerminalBlock)U).CustomData=
"hudlcd:-0.7:-0.45:0.9:White:1";Ŧ=U;}var T=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(T!=null){T.WriteText(string.Empty)
;T.ContentType=ContentType.TEXT_AND_IMAGE;T.Alignment=TextAlignment.CENTER;T.Font="Monospace";((IMyTerminalBlock)T).
CustomData="hudlcd:0.45:0.9:1:White:1";ť=T;}}void S(){var R=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocks(R,Ä=>Ä.CubeGrid==Me.CubeGrid);if(R.Count<=0){throw new Exception(
$"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}Ń=new List<IMyTerminalBlock>();foreach(var P in R){if(P is IMyLightingBlock){var Õ=(IMyLightingBlock)P;Õ.Intensity=5f
;Õ.BlinkLength=0f;Õ.BlinkIntervalSeconds=0f;}else if(P is IMyTextPanel){var Ô=(IMyTextPanel)P;Ô.ContentType=ContentType.
TEXT_AND_IMAGE;Ô.WriteText("",false);}Ń.Add(P);}ŀ=new List<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(ŀ,Ä=>Ä.CubeGrid!=Me.
CubeGrid);foreach(var P in ŀ){P.BlinkIntervalSeconds=0;P.BlinkLength=50f;}}void è(){Ł=new List<IMyLightingBlock>();var R=new
List<IMyTerminalBlock>();var æ=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(æ==null){return;}æ.
GetBlocks(R,Ä=>Ä.CubeGrid==Me.CubeGrid);foreach(var P in R){var Õ=(IMyLightingBlock)P;Ł.Add(Õ);}}void ç(){ł=new List<
IMyLightingBlock>();var R=new List<IMyTerminalBlock>();var æ=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(æ==null)
{return;}æ.GetBlocks(R,Ä=>Ä.CubeGrid==Me.CubeGrid);foreach(var P in R){var Õ=(IMyLightingBlock)P;Õ.Radius=4f;Õ.Intensity=
10f;Õ.BlinkLength=50f;Õ.BlinkIntervalSeconds=0.5f;ł.Add(Õ);}}void å(){var é=(IMySensorBlock)GridTerminalSystem.
GetBlockWithName(DRAFTING_SENSOR_NAME);if(é==null){return;}Ţ=é;Ţ.TopExtend=50;Ţ.BottomExtend=0;Ţ.RightExtend=2.25f;Ţ.LeftExtend=2.25f;Ţ.
FrontExtend=0;Ţ.BackExtend=2;Ţ.DetectSmallShips=true;Ţ.DetectLargeShips=false;Ţ.DetectStations=false;Ţ.DetectSubgrids=false;Ţ.
DetectAsteroids=false;Ţ.DetectPlayers=false;}void ä(){var ê=new List<IMyGyro>();GridTerminalSystem.GetBlocksOfType(ê,û=>û.CubeGrid==Me.
CubeGrid);if(ê.Count<=0){throw new Exception("No gyroscope found.");}š=ê;}void ù(){Ť=new List<IMySoundBlock>();
GridTerminalSystem.GetBlocksOfType(Ť,Ä=>Ä.CubeGrid==Me.CubeGrid);}void ø(){if(string.IsNullOrWhiteSpace(Me.CustomData)){ë(Ġ.ġ);return;}var
ö=Me.CustomData.Split(';');if(ö.Length<3){ë(Ġ.ġ);return;}var õ=Convert.ToChar(ö[0]);var ô=(float)Convert.ToDouble(ö[1]);
var ó=(float)Convert.ToDouble(ö[2]);switch(õ){case'S':ë(Ġ.ġ);break;case'M':ë(Ġ.ğ);break;case'H':ë(Ġ.Ģ);break;case'X':ë(Ġ.Ĵ)
;break;case'I':ë(Ġ.Ĳ);break;case'W':ë(Ġ.ı);break;default:ë(Ġ.ġ);break;}Ŀ.ÿ=ô;ĸ=ó;}void ú(){var ò=new List<IMyRadioAntenna
>();GridTerminalSystem.GetBlocksOfType(ò);var ñ=ò.FirstOrDefault();if(ñ==null){throw new Exception("No antenna!");}ñ.
Enabled=true;ñ.Radius=5000;ñ.EnableBroadcasting=true;ñ.HudText=$"(P{ń.ģ}) {DRIVER_NAME}-{DRIVER_NUMBER}";ţ=ñ;}void ð(){IGC.
RegisterBroadcastListener("Address");var ï=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(ï);Ľ=ï.FirstOrDefault();}void î(string í){
if(í.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){œ=!œ;return;}if(í.Equals("LMT_ON",StringComparison.
InvariantCultureIgnoreCase)){œ=true;return;}if(í.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){œ=false;return;}if(í.Equals("DRS",
StringComparison.InvariantCultureIgnoreCase)){Ň=!Ň;return;}if(í.Equals("DRS_ON",StringComparison.InvariantCultureIgnoreCase)){Ň=true;
return;}if(í.Equals("DRS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ň=false;return;}if(í.Equals("ERS",StringComparison
.InvariantCultureIgnoreCase)){Ķ=!Ķ;return;}if(í.Equals("ERS_ON",StringComparison.InvariantCultureIgnoreCase)){Ķ=true;
return;}if(í.Equals("ERS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ķ=false;return;}if(í.Equals("SOFT",
StringComparison.InvariantCultureIgnoreCase)){ì(Ġ.ġ);return;}if(í.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){ì(Ġ.ğ);
return;}if(í.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){ì(Ġ.Ģ);return;}if(í.Equals("EXTRA",StringComparison.
InvariantCultureIgnoreCase)){ì(Ġ.Ĵ);return;}if(í.Equals("INT",StringComparison.InvariantCultureIgnoreCase)){ì(Ġ.Ĳ);return;}if(í.Equals("WET",
StringComparison.InvariantCultureIgnoreCase)){ì(Ġ.ı);return;}if(í.Equals("FLIP",StringComparison.InvariantCultureIgnoreCase)){ň=true;
return;}if(í.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){á(İ.į);return;}if(í.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){á(İ.Į);return;}if(í.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){á(İ.ĭ);
return;}}void ì(Ġ ã){if(!œ||Ũ.GetShipSpeed()>1){return;}ë(ã);Ñ(true);}void ë(Ġ ã){switch(ã){case Ġ.ġ:Ŀ=Ă.ś();break;case Ġ.ğ:Ŀ=
Ă.Ś();break;case Ġ.Ģ:Ŀ=Ă.ř();break;case Ġ.Ĵ:Ŀ=Ă.Ř();break;case Ġ.Ĳ:Ŀ=Ă.ŗ();break;case Ġ.ı:Ŀ=Ă.Ŗ();break;default:break;}Ê(
Ŀ.ę);foreach(var I in ũ){I.ApplyAction("Add Top Part");I.Friction=Ŀ.þ;}}void Ê(Color Ë){foreach(var P in Ń){if(P is
IMyLightingBlock){var Õ=(IMyLightingBlock)P;Õ.Color=Ë;}else if(P is IMyTextPanel){var Ô=(IMyTextPanel)P;Ô.BackgroundColor=Ë;}}foreach(
var P in ŀ){if(P.IsSameConstructAs(Me)){P.Color=Ë;P.BlinkIntervalSeconds=0;}}}void Ó(float Ò){foreach(var I in ũ){I.
SetValueFloat("Speed Limit",Ò*3.6f);}}void Ñ(bool Ð=false){Ļ-=(int)(Ĺ*1000);if(!Ð&&Ļ>0){return;}var Ï=Ŀ.Ā;Me.CustomData=
$"{Ï};{Ŀ.ÿ};{ĸ}";Ļ=Ŕ;}string Î(){var Í=string.Empty;switch(ń.ĉ){case İ.Ĭ:Í="Blue";break;case İ.į:Í="Green";break;case İ.ĭ:Í="Red";break;
case İ.Į:Í="Yellow";break;}return Í;}Color Ì(){var Ë=Color.Black;switch(ń.ĉ){case İ.Ĭ:Ë=Color.Blue;break;case İ.į:Ë=Color.
Green;break;case İ.ĭ:Ë=Color.Red;break;case İ.Į:Ë=Color.Yellow;break;}return Ë;}string Ö(){const int Ø=6;var â=Ķ?Ů:ĸ<1?ů:'-';
var y=â+"E:";for(int k=0;k<Ø;k++){var º=1f/Ø;if(ĸ>º*k){if(ĸ<º*(k+1)){y+=Ŭ;continue;}y+=ŭ;}else{y+=ū;}}return y;}void á(İ à)
{if(ľ<=0){return;}IGC.SendUnicastMessage(ľ,"Flag",$"{(int)à}");}float ß(){if(œ){return 20f;}if(ķ||Ķ){return 100f;}return
Ų;}float Þ(){if(œ){return 26;}if(ń.ĉ==İ.Į){return 45;}if(ķ){return 999;}return Ű;}IMyMotorSuspension Ý(ĩ µ){return ũ[(int
)µ];}void Ü(ĩ µ,IMyMotorSuspension Û){if(Û==null){return;}ũ[(int)µ]=Û;}void Ú(float Ù){var f=Ý(ĩ.ħ);var e=Ý(ĩ.Ĩ);var a=Ý(
ĩ.ĥ);var Z=Ý(ĩ.Ħ);f.PropulsionOverride=Ù;e.PropulsionOverride=-Ù;a.PropulsionOverride=Ù;Z.PropulsionOverride=-Ù;}