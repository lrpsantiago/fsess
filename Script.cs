private readonly string TEAM_TAG = "XXX";                               //Your Team Tag (3 chracters), if you are not in a team yet, keep this as it is.
private readonly string DRIVER_NAME = "Guest";                          //Your name
private readonly int DRIVER_NUMBER = 99;                                //Your number (0-99)
private const float DEFAULT_SUSPENSION_STRENGTH = 20f;                  //Setup your default suspensions strength
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const string DRAFTING_SENSOR_NAME = "Drafting Sensor";
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null)
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)
private const string TEXT_DISPLAY_NAME = "Text LCD";                    //Optional Text-Based LCD, for HudLcd Plugin
private const string RANK_DISPLAY_NAME = "Rank LCD";                    //Optional Text-Based LCD, for HudLcd Plugin

enum Ċ{Č,ě,č,Ď,ď}enum Đ{đ,Ē,ē,Ĕ}enum ĕ{Ė,ė}enum Ę{ę,Ě,Ĝ,ĉ}class ê{public int Ĉ{get;set;}public int ë{get;set;}public int
ì{get;set;}public int í{get;set;}public string î{get;set;}="--:--.---";public string ï{get;set;}="--:--.---";public Đ ð{
get;set;}public ĕ ñ{get;set;}public int ò{get;set;}public int ó{get;set;}public string ô{get;set;}public void õ(string ö){
try{var Ù=ö.Split(';');ì=Convert.ToInt32(Ù[0]);Ĉ=Convert.ToInt32(Ù[1]);î=Ù[2];ï=Ù[3];ë=Convert.ToInt32(Ù[4]);í=Convert.
ToInt32(Ù[5]);ð=(Đ)Convert.ToInt32(Ù[6]);ñ=(ĕ)Convert.ToInt32(Ù[7]);ò=Convert.ToInt32(Ù[8]);ó=Convert.ToInt32(Ù[9]);ô=Ù[10];}
catch(Exception){}}}string ø="11.1.0";const int ù=3000;const int ú=1000;const int û=1200;const float ü=80f;const float ý=96f;
const char þ='\u2191';const char ÿ='\u2193';const char Ā='\u2588';const char ā='\u2592';const char Ă='\u2591';const float ă=
1.7f;bool Ą;IMyMotorSuspension[]ą;IMyShipController Ć;List<IMyTextSurface>ć;IMyTextSurface ċ;IMyTextSurface ĝ;List<
IMySoundBlock>Ň;IMyRadioAntenna ĸ;IMySensorBlock Ĺ;bool ĺ;bool Ļ;bool ļ;StringBuilder Ľ;ê ľ;List<IMyTerminalBlock>Ŀ;List<
IMyLightingBlock>ŀ;List<IMyLightingBlock>Ł;List<IMyLightingBlock>ł;Ċ Ń;float ń=0;float Ņ=100;float ņ=1;float ň=100;long œ=-1;
IMyBroadcastListener ŉ;int Ŋ;int ŋ;DateTime Ō;float ō;float Ŏ=1f;bool ŏ=false;int Ő;Program(){ľ=new ê();try{u();w();B();I();O();Þ();U();Ý();
Ø();à();Ô();Ö();}catch(Exception ex){Ą=true;Echo(ex.Message);return;}Runtime.UpdateFrequency=UpdateFrequency.Update1;Ō=
DateTime.Now;}void Save(){}void Main(string ã,UpdateType ő){if(Ą){return;}var Œ=DateTime.Now;ō=(float)(Œ-Ō).TotalMilliseconds/
1000;Echo($"Running FSESS {ø}");â(ã);W();a();Ŕ();ĵ();p();j();Ķ();Ģ();o();t();Ō=Œ;}void Ŕ(){switch(ľ.ð){case Đ.Ē:ķ();break;
case Đ.ē:Ğ();break;default:if(!ĺ){Ć.HandBrake=false;z(ý);}break;}}void ķ(){Ļ=false;ļ=false;Ć.HandBrake=Ć.GetShipSpeed()>50;z
(50f);}void Ğ(){Ļ=false;ļ=false;ĺ=false;Ć.HandBrake=true;}void Ķ(){var ğ=IGC.UnicastListener;if(!ğ.HasPendingMessage){Ŋ-=
(int)(ō*1000);if(ŉ.HasPendingMessage&&Ŋ<=0){var Ġ=ŉ.AcceptMessage();if(Ġ.Tag=="Address"){œ=Convert.ToInt64(Ġ.Data.
ToString());IGC.SendUnicastMessage(œ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ğ.HasPendingMessage){var ġ
=ğ.AcceptMessage();if(ġ.Tag=="RaceData"){ľ.õ(ġ.Data.ToString());}if(ġ.Tag=="Argument"){â(ġ.Data.ToString());}}Ŋ=ù;}void Ģ
(){Ľ.Clear();var f=Ć.GetShipSpeed();var ģ=((ň-ń)/(Ņ-ń))*100f;var Ĥ=À();var ĥ=((int)Math.Floor(ģ)).ToString();var Ħ=
$"{f:F0}m/s";var È=Å();var ħ=ľ.ñ==ĕ.Ė?"<CLEAR>":"<RAIN>";var Ĩ=$"RoR: {ľ.ò}%";var ĩ=ľ.ó<=0?$"{ħ} {Ĩ.PadLeft(15-ħ.Length)}":
$"<RAIN IN {ľ.ó}s>";var Ġ=string.Empty;if(ĺ){Ġ="PIT LIMITER";}else{if(Ļ&&ŏ){Ġ="DRAFTING (DRS)";}else if(Ļ){Ġ="DRS ON";}else if(ŏ){Ġ=
"DRAFTING";}}Ľ.AppendLine(Ħ+È.PadLeft(16-Ħ.Length));Ľ.AppendLine(Ġ);Ľ.AppendLine($"P:{ľ.Ĉ:00}/{ľ.ë:00}  L:{(ľ.ì):00}/{ľ.í:00}");Ľ.
AppendLine($"TYRE ({Ĥ})..: {ĥ,3}%");Ľ.AppendLine($"TIME.: {ľ.î}");Ľ.AppendLine($"BEST.: {ľ.ï}");Ľ.AppendLine(ĩ);if(Ŋ<=0){Ľ.
AppendLine($"NO CONNECTION");}var Ī=Ľ.ToString();ċ?.WriteText(Ī);foreach(var L in ć){var ī=L.DrawFrame();var Ĭ=Color.Black;var ĭ=
DEFAULT_FONT_COLOR;switch(ľ.ð){case Đ.Ē:Ĭ=Color.Yellow;ĭ=Color.Black;break;case Đ.ē:Ĭ=Color.Red;ĭ=Color.White;break;case Đ.Ĕ:Ĭ=Color.Blue;
ĭ=Color.White;break;}L.BackgroundColor=Ĭ;L.ScriptBackgroundColor=Ĭ;L.FontColor=ĭ;var Į=MySprite.CreateText(Ī,"Monospace",
ĭ,0.75f);Į.Position=new Vector2(128,18);ī.Add(Į);var į=MathHelper.Clamp(Math.Round(f/(100f/15)),0,100);for(int Z=0;Z<į;Z
++){var İ=8f;var ı=2f;var Ĳ=(256/2)-((15f*İ+14f*ı)/2)+İ/2;var Î=new Vector2(Ĳ+(İ+ı)*Z,İ+ı);var ĳ=new Vector2(İ);var Ĵ=
MySprite.CreateSprite("Circle",Î,ĳ);if(Z<5){Ĵ.Color=Color.Lime;}else if(Z<10){Ĵ.Color=Color.Red;}else{Ĵ.Color=Color.Blue;}ī.Add(
Ĵ);}ī.Dispose();}if(ĝ!=null&&ľ!=null&&ľ.ô!=null){ĝ.WriteText(ľ.ô);}}void ĵ(){if(!ĺ){foreach(var D in ą){D.Power=ü;D.
SetValueFloat("Speed Limit",ý*3.6f);}return;}foreach(var D in ą){D.Power=20f;D.SetValueFloat("Speed Limit",26f*3.6f);}var f=Ć.
GetShipSpeed();Ć.HandBrake=f>24;}void W(){var Y=Ć.MoveIndicator.Z>0||Ć.MoveIndicator.Y>0||Ć.HandBrake;if(Y){Ļ=false;}for(int Z=0;Z<ą
.Length;Z++){var D=ą[Z];D.Strength=!Ļ?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var R in Ł){R.Color=Ļ?Color.Blue:Color.
Black;R.Enabled=Ļ;}}void a(){if(ĺ){ļ=false;}var e=Ć.MoveIndicator.Z<0;var f=Ć.GetShipSpeed();if(f>=1){if(!ļ){var g=(float)
MathHelper.Clamp(f/ý,0f,1f);Ŏ+=(1f/120)*g*ō;}else if(e){var g=1;Ŏ-=(1f/30)*g*ō;}}Ŏ=MathHelper.Clamp(Ŏ,0,1);if(Ŏ<=0){ļ=false;}
foreach(var D in ą){D.Power=Ë();}var h=ļ&&e?ă:0;Ñ(h);foreach(var R in ŀ){R.Color=ļ?Color.Cyan:Color.Black;}}void j(){var f=Ć.
GetShipSpeed();if(f<1){return;}var k=(float)MathHelper.Clamp(f,0,90)/90;var x=ņ*k*ō;ň-=x;ň=MathHelper.Clamp(ň,ń,Ņ);var m=Ń==Ċ.Č||Ń==
Ċ.ě||Ń==Ċ.č;foreach(var D in ą){D.Friction=!(m&&ľ.ñ==ĕ.ė)?ň:ň/2;}if(ň<=ń){if(ą.All(D=>D.IsAttached)){var n=new Random().
Next(4);ą[n].Detach();}}ª();}void o(){if(ĸ==null){return;}ĸ.HudText=$"P{ľ.Ĉ}";}void p(){if(Ĺ==null){return;}var q=!Ĺ.Closed
&&Ĺ.IsActive&&Ć.GetShipSpeed()>=70;if(q){Ő=û;}if(ĺ){Ő=0;}ŏ=Ő>0;foreach(var D in ą){D.Power=Ë();var r=Ì();D.SetValueFloat(
"Speed Limit",r*3.6f);}Ő-=(int)(ō*1000);}void t(){foreach(var D in Ň){}}void u(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new
Exception("DRIVER_NUMBER should be between 1 and 99");}var v=TEAM_TAG;if(TEAM_TAG==string.Empty){v="XXX";}v=v.Trim().Substring(0,
3).ToUpper();Me.CubeGrid.CustomName=$"{v} #{DRIVER_NUMBER:00}-{DRIVER_NAME.Trim()}";}void w(){var y=new List<
IMyShipController>();GridTerminalSystem.GetBlocksOfType(y);var X=y.FirstOrDefault(A=>A is IMyRemoteControl)??y.FirstOrDefault(A=>A is
IMyCockpit);if(X==null){throw new Exception("No cockpit or remote control!");}Ć=X;}void B(){var C=new List<IMyMotorSuspension>();
GridTerminalSystem.GetBlocksOfType(C,D=>D.CubeGrid==Me.CubeGrid);if(C==null||C.Count!=4){throw new Exception("Need 4 suspensions!");}var E
=C.FirstOrDefault(D=>D.CustomName.Contains("FL"));if(E==null)throw new Exception("FL suspension not found.");var F=C.
FirstOrDefault(D=>D.CustomName.Contains("FR"));if(F==null)throw new Exception("FR suspension not found.");var G=C.FirstOrDefault(D=>D.
CustomName.Contains("RL"));if(G==null)throw new Exception("RL suspension not found.");var H=C.FirstOrDefault(D=>D.CustomName.
Contains("RR"));if(H==null)throw new Exception("RR suspension not found.");ą=new IMyMotorSuspension[4];Ï(Ę.Ě,E);Ï(Ę.ę,F);Ï(Ę.ĉ,G
);Ï(Ę.Ĝ,H);}void I(){Ľ=new StringBuilder();ć=new List<IMyTextSurface>{Me.GetSurface(0)};var J=(IMyTextSurface)
GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(J!=null){ć.Add(J);}if(COCKPIT_DISPLAY_INDEX.HasValue){var K=Ć as IMyCockpit;if(K!=
null){var L=K.GetSurface(COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(L!=null){ć.Add(L);}}}foreach(var L in ć){L.
ContentType=ContentType.SCRIPT;L.Alignment=TextAlignment.CENTER;L.Font="Monospace";}var M=(IMyTextSurface)GridTerminalSystem.
GetBlockWithName(TEXT_DISPLAY_NAME);if(M!=null){M.WriteText(string.Empty);M.ContentType=ContentType.TEXT_AND_IMAGE;M.Alignment=
TextAlignment.CENTER;M.Font="Monospace";((IMyTerminalBlock)M).CustomData="hudlcd:-0.7:-0.45:0.9:White:1";ċ=M;}var N=(IMyTextSurface)
GridTerminalSystem.GetBlockWithName(RANK_DISPLAY_NAME);if(N!=null){N.WriteText(string.Empty);N.ContentType=ContentType.TEXT_AND_IMAGE;N.
Alignment=TextAlignment.CENTER;N.Font="Monospace";((IMyTerminalBlock)N).CustomData="hudlcd:0.45:0.9:1:White:1";ĝ=N;}}void O(){var
P=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(P,Q=>Q.CubeGrid
==Me.CubeGrid);if(P.Count<=0){throw new Exception($"\"{BRAKELIGHT_GROUP_NAME}\" group not set.");}Ŀ=new List<
IMyTerminalBlock>();foreach(var R in P){if(R is IMyLightingBlock){var S=(IMyLightingBlock)R;S.Intensity=5f;S.BlinkLength=0f;S.
BlinkIntervalSeconds=0f;}else if(R is IMyTextPanel){var T=(IMyTextPanel)R;T.ContentType=ContentType.TEXT_AND_IMAGE;T.WriteText("",false);}Ŀ.
Add(R);}ł=new List<IMyLightingBlock>();GridTerminalSystem.GetBlocksOfType(ł,Q=>Q.CubeGrid!=Me.CubeGrid);}void U(){Ł=new
List<IMyLightingBlock>();var P=new List<IMyTerminalBlock>();var V=GridTerminalSystem.GetBlockGroupWithName(
DRS_LIGHTS_GROUP_NAME);if(V==null){return;}V.GetBlocks(P,Q=>Q.CubeGrid==Me.CubeGrid);foreach(var R in P){var S=(IMyLightingBlock)R;Ł.Add(S);}
}void Þ(){ŀ=new List<IMyLightingBlock>();var P=new List<IMyTerminalBlock>();var V=GridTerminalSystem.
GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(V==null){return;}V.GetBlocks(P,Q=>Q.CubeGrid==Me.CubeGrid);foreach(var R in P){var S=(
IMyLightingBlock)R;S.Radius=4f;S.Intensity=10f;S.BlinkLength=50f;S.BlinkIntervalSeconds=0.5f;ŀ.Add(S);}}void Ô(){var Õ=(IMySensorBlock)
GridTerminalSystem.GetBlockWithName(DRAFTING_SENSOR_NAME);if(Õ==null){return;}Ĺ=Õ;Ĺ.TopExtend=50;Ĺ.BottomExtend=0;Ĺ.RightExtend=2.25f;Ĺ.
LeftExtend=2.25f;Ĺ.FrontExtend=0;Ĺ.BackExtend=2;Ĺ.DetectSmallShips=true;Ĺ.DetectLargeShips=false;Ĺ.DetectStations=false;Ĺ.
DetectSubgrids=false;Ĺ.DetectAsteroids=false;Ĺ.DetectPlayers=false;}void Ö(){Ň=new List<IMySoundBlock>();GridTerminalSystem.
GetBlocksOfType(Ň,Q=>Q.CubeGrid==Me.CubeGrid);}void Ø(){if(string.IsNullOrWhiteSpace(Me.CustomData)){æ(Ċ.Č);return;}var Ù=Me.CustomData
.Split(';');if(Ù.Length<3){æ(Ċ.Č);return;}var Ú=Convert.ToChar(Ù[0]);var Û=(float)Convert.ToDouble(Ù[1]);var Ü=(float)
Convert.ToDouble(Ù[2]);switch(Ú){case'S':æ(Ċ.Č);break;case'M':æ(Ċ.ě);break;case'H':æ(Ċ.č);break;case'I':æ(Ċ.Ď);break;case'W':æ(
Ċ.ď);break;default:æ(Ċ.Č);break;}ň=Û;Ŏ=Ü;}void Ý(){var ß=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(ß
);var é=ß.FirstOrDefault();if(é==null){throw new Exception("No antenna!");}é.Enabled=true;é.Radius=5000;é.
EnableBroadcasting=true;é.HudText=$"(P{ľ.Ĉ}) {DRIVER_NAME}-{DRIVER_NUMBER}";ĸ=é;}void à(){IGC.RegisterBroadcastListener("Address");var á=
new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(á);ŉ=á.FirstOrDefault();}void â(string ã){if(ã.Equals("LMT",
StringComparison.InvariantCultureIgnoreCase)){ĺ=!ĺ;return;}if(ã.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){ĺ=true;
return;}if(ã.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){ĺ=false;return;}if(ã.Equals("DRS",StringComparison
.InvariantCultureIgnoreCase)){Ļ=!Ļ;return;}if(ã.Equals("DRS_ON",StringComparison.InvariantCultureIgnoreCase)){Ļ=true;
return;}if(ã.Equals("DRS_OFF",StringComparison.InvariantCultureIgnoreCase)){Ļ=false;return;}if(ã.Equals("ERS",StringComparison
.InvariantCultureIgnoreCase)){ļ=!ļ;return;}if(ã.Equals("ERS_ON",StringComparison.InvariantCultureIgnoreCase)){ļ=true;
return;}if(ã.Equals("ERS_OFF",StringComparison.InvariantCultureIgnoreCase)){ļ=false;return;}if(ã.Equals("SOFT",
StringComparison.InvariantCultureIgnoreCase)){ä(Ċ.Č);return;}if(ã.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){ä(Ċ.ě);
return;}if(ã.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){ä(Ċ.č);return;}if(ã.Equals("INT",StringComparison.
InvariantCultureIgnoreCase)){ä(Ċ.Ď);return;}if(ã.Equals("WET",StringComparison.InvariantCultureIgnoreCase)){ä(Ċ.ď);return;}if(ã.Equals("FLAG_G",
StringComparison.InvariantCultureIgnoreCase)){É(Đ.đ);return;}if(ã.Equals("FLAG_Y",StringComparison.InvariantCultureIgnoreCase)){É(Đ.Ē);
return;}if(ã.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){É(Đ.ē);return;}}void ä(Ċ å){if(!ĺ||Ć.GetShipSpeed()
>1){return;}æ(å);ª(true);}void æ(Ċ å){var ç=Color.White;switch(å){case Ċ.Č:Ņ=100;ń=33.33f;ņ=(Ņ-ń)/(60*8);ç=Color.Red;
break;case Ċ.ě:Ņ=75;ń=36.11f;ņ=(Ņ-ń)/(60*13);ç=Color.Yellow;break;case Ċ.č:Ņ=60;ń=37.78f;ņ=(Ņ-ń)/(60*21);ç=Color.White;break;
case Ċ.Ď:Ņ=55;ń=38.33f;ņ=(Ņ-ń)/(60*8);ç=Color.Lime;break;case Ċ.ď:Ņ=45;ń=39.44f;ņ=(Ņ-ń)/(60*21);ç=Color.Blue;break;default:
break;}ň=Ņ;Ń=å;è(ç);foreach(var D in ą){D.ApplyAction("Add Top Part");}}void è(Color Ä){foreach(var R in Ŀ){if(R is
IMyLightingBlock){var S=(IMyLightingBlock)R;S.Color=Ä;}else if(R is IMyTextPanel){var T=(IMyTextPanel)R;T.BackgroundColor=Ä;}}foreach(
var R in ł){if(R.IsSameConstructAs(Me)){R.Color=Ä;}}}void z(float Ó){foreach(var D in ą){D.SetValueFloat("Speed Limit",Ó*
3.6f);}}void ª(bool µ=false){ŋ-=(int)(ō*1000);if(!µ&&ŋ>0){return;}var º=À();Me.CustomData=$"{º};{ň};{Ŏ}";ŋ=ú;}char À(){var º
='S';switch(Ń){case Ċ.Č:º='S';break;case Ċ.ě:º='M';break;case Ċ.č:º='H';break;case Ċ.Ď:º='I';break;case Ċ.ď:º='W';break;}
return º;}string Á(){var Â=string.Empty;switch(ľ.ð){case Đ.Ĕ:Â="Blue";break;case Đ.đ:Â="Green";break;case Đ.ē:Â="Red";break;
case Đ.Ē:Â="Yellow";break;}return Â;}Color Ã(){var Ä=Color.Black;switch(ľ.ð){case Đ.Ĕ:Ä=Color.Blue;break;case Đ.đ:Ä=Color.
Green;break;case Đ.ē:Ä=Color.Red;break;case Đ.Ē:Ä=Color.Yellow;break;}return Ä;}string Å(){const int Æ=6;var Ç=ļ?ÿ:Ŏ<1?þ:'-';
var È=Ç+"E:";for(int Z=0;Z<Æ;Z++){var g=1f/Æ;if(Ŏ>g*Z){if(Ŏ<g*(Z+1)){È+=ā;continue;}È+=Ā;}else{È+=Ă;}}return È;}void É(Đ Ê)
{if(œ<=0){return;}IGC.SendUnicastMessage(œ,"Flag",$"{(int)Ê}");}float Ë(){if(ĺ){return 20f;}if(ŏ||ļ){return 100f;}return
ü;}float Ì(){if(ĺ){return 26;}if(ľ.ð==Đ.Ē){return 45;}if(ŏ){return 999;}return ý;}IMyMotorSuspension Í(Ę Î){return ą[(int
)Î];}void Ï(Ę Î,IMyMotorSuspension Ð){if(Ð==null){return;}ą[(int)Î]=Ð;}void Ñ(float Ò){var E=Í(Ę.Ě);var F=Í(Ę.ę);var G=Í(
Ę.ĉ);var H=Í(Ę.Ĝ);E.PropulsionOverride=Ò;F.PropulsionOverride=-Ò;G.PropulsionOverride=Ò;H.PropulsionOverride=-Ò;}