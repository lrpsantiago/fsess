private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const float DEFAULT_SUSPENSION_SPEED_LIMIT = 999;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const bool AUTO_ERS = false;                                    //Activates ERS whenever it's 100% Charge (true or false)
private readonly int? COCKPIT_DISPLAY_INDEX = null;                     //If you wanna use a cockpit display to show dashboard info (0, 1, 2, 3 or null);
private readonly Color DEFAULT_FONT_COLOR = new Color(255, 255, 255);   //Font Color (R, G, B)

enum á{â,ã,ä,å,æ}enum ç{è,ê,é,à}class ß{public int Ì{get;set;}public int Í{get;set;}public int Î{get;set;}public int Ï{
get;set;}public string Ð{get;set;}="--:--.---";public string Ñ{get;set;}="--:--.---";public ç Ò{get;set;}=ç.è;public void Ó
(string Ô){try{var y=Ô.Split(';');Î=Convert.ToInt32(y[0]);Ì=Convert.ToInt32(y[1]);Ð=y[2];Ñ=y[3];Í=Convert.ToInt32(y[4]);Ï
=Convert.ToInt32(y[5]);Ò=(ç)Convert.ToInt32(y[6]);}catch(Exception){}}}string Õ="7.0.0";const int Ö=3000;const int Ø=500;
const float Ù=80f;const char Ú='\u2191';const char Û='\u2193';const char Ü='\u2588';const char Ý='\u2592';const char Þ=
'\u2591';List<IMyMotorSuspension>Ë;IMyCockpit ë;List<IMyTextSurface>ì;IMyRadioAntenna ý;bool þ;bool ÿ;bool Ā;StringBuilder ā;ß Ă
;List<IMyTerminalBlock>ă;List<IMyLightingBlock>Ą;List<IMyLightingBlock>ą;á Ć;float ć=0;float Ĉ=100;float ĉ=1;float Ċ=100;
long ċ=-1;IMyBroadcastListener Č;int č;int Ď;DateTime ď;float Đ;float đ=1f;Program(){Ă=new ß();A();I();C();E();H();Q();N();º
();x();Â();Runtime.UpdateFrequency=UpdateFrequency.Update10;ď=DateTime.Now;}void Save(){}void Main(string Å,UpdateType í)
{var î=DateTime.Now;Đ=(float)(î-ď).TotalMilliseconds/1000;Echo($"Running FSESS {Õ}");Ä(Å);T();W();Ê();Z();ñ();õ();R();ď=î
;}void ï(){ÿ=false;Ā=false;f(50f);}void ð(){ÿ=false;Ā=false;ë.HandBrake=true;}void ñ(){var ò=IGC.UnicastListener;if(!ò.
HasPendingMessage){č-=(int)(Đ*1000);if(Č.HasPendingMessage&&č<=0){var ó=Č.AcceptMessage();if(ó.Tag=="Address"){ċ=Convert.ToInt64(ó.Data.
ToString());IGC.SendUnicastMessage(ċ,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ò.HasPendingMessage){var ô
=ò.AcceptMessage();if(ô.Tag=="RaceData"){Ă.Ó(ô.Data.ToString());}if(ô.Tag=="Argument"){Ä(ô.Data.ToString());}}č=Ö;}void õ
(){ā.Clear();var S=ë.GetShipSpeed();var ö=((Ċ-ć)/(Ĉ-ć))*100f;var ø=m();var ù=((int)Math.Floor(ö)).ToString();var ú=
$"{S:F0}m/s";var v=r();var ó=þ?"PIT LIMITER":ÿ?"DRS ON":"";ā.AppendLine(ú+v.PadLeft(16-ú.Length));ā.AppendLine(ó);ā.AppendLine(
$"P:{Ă.Ì:00}/{Ă.Í:00}  L:{(Ă.Î):00}/{Ă.Ï:00}");ā.AppendLine($"TYRE ({ø})..: {ù,3}%");ā.AppendLine($"TIME.: {Ă.Ð}");ā.AppendLine($"BEST.: {Ă.Ñ}");if(č<=0){ā.
AppendLine($"NO CONNECTION");}foreach(var G in ì){G.WriteText(ā);var û=Color.Black;var ü=DEFAULT_FONT_COLOR;switch(Ă.Ò){case ç.ê:û
=Color.Yellow;ü=Color.Black;break;case ç.é:û=Color.Red;ü=Color.White;break;case ç.à:û=Color.Blue;ü=Color.White;break;}G.
BackgroundColor=û;G.ScriptBackgroundColor=û;G.FontColor=ü;}}void Ê(){if(!þ){foreach(var D in Ë){D.Power=Ù;D.SetValueFloat("Speed Limit"
,DEFAULT_SUSPENSION_SPEED_LIMIT*3.6f);}return;}foreach(var D in Ë){D.Power=20f;D.SetValueFloat("Speed Limit",26f*3.6f);}
var S=ë.GetShipSpeed();ë.HandBrake=S>24;}void T(){var U=ë.MoveIndicator.Z>0||ë.MoveIndicator.Y>0||ë.HandBrake;if(U){ÿ=false
;}for(int V=0;V<Ë.Count;V++){var D=Ë[V];D.Strength=!ÿ?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var K in ą){K.Color=ÿ?
Color.Blue:Color.Black;K.Enabled=ÿ;}}void W(){if(AUTO_ERS&&đ==1){Ā=true;}if(þ){Ā=false;}var X=ë.MoveIndicator.Z<0;var S=ë.
GetShipSpeed();if(S>1){if(!Ā){var Y=(float)MathHelper.Clamp(S/100,0,1);đ+=(1f/240)*Y*Đ;}else if(X){var Y=(float)MathHelper.Clamp(S/
100,1,0);đ-=(1f/120)*Y*Đ;}}đ=MathHelper.Clamp(đ,0,1);if(đ<=0){Ā=false;}foreach(var D in Ë){D.Power=!Ā?Ù:100;}foreach(var K
in Ą){K.Color=Ā?Color.Lime:Color.Red;}}void Z(){var S=ë.GetShipSpeed();if(S<1){return;}var a=(float)MathHelper.Clamp(S,0,
90)/90;var c=ĉ*a*Đ;Ċ-=c;Ċ=MathHelper.Clamp(Ċ,ć,Ĉ);foreach(var D in Ë){D.Friction=Ċ;}if(Ċ<=ć){if(Ë.All(D=>D.IsAttached)){
var e=new Random().Next(4);Ë[e].Detach();}}h();}void R(){if(ý==null){return;}ý.HudText=
$"(P{Ă.Ì}) {DRIVER_NAME}-{DRIVER_NUMBER}";}void A(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");}Me.
CubeGrid.CustomName=$"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void I(){var B=new List<IMyCockpit>();GridTerminalSystem.
GetBlocksOfType(B);ë=B.FirstOrDefault();if(ë==null){throw new Exception("No cockpit!");}}void C(){Ë=new List<IMyMotorSuspension>();
GridTerminalSystem.GetBlocksOfType(Ë,D=>D.CubeGrid==Me.CubeGrid);if(Ë==null||Ë.Count!=4){throw new Exception("Need 4 suspensions!");}}void
E(){ā=new StringBuilder();ì=new List<IMyTextSurface>{Me.GetSurface(0)};var F=(IMyTextSurface)GridTerminalSystem.
GetBlockWithName(DISPLAY_NAME);if(F!=null){ì.Add(F);}if(COCKPIT_DISPLAY_INDEX.HasValue){var G=ë.GetSurface(COCKPIT_DISPLAY_INDEX.
GetValueOrDefault());if(G!=null){ì.Add(G);}}foreach(var G in ì){G.ContentType=ContentType.TEXT_AND_IMAGE;G.Alignment=TextAlignment.CENTER
;G.Font="Monospace";}}void H(){var J=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocks(J,P=>P.CubeGrid==Me.CubeGrid);ă=new List<IMyTerminalBlock>();foreach(var K in J){if(K is IMyLightingBlock){
var L=(IMyLightingBlock)K;L.Intensity=5f;L.BlinkLength=0f;L.BlinkIntervalSeconds=0f;}else if(K is IMyTextPanel){var M=(
IMyTextPanel)K;M.ContentType=ContentType.TEXT_AND_IMAGE;M.WriteText("",false);}ă.Add(K);}}void N(){ą=new List<IMyLightingBlock>();
var J=new List<IMyTerminalBlock>();var O=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(O==null){return
;}O.GetBlocks(J,P=>P.CubeGrid==Me.CubeGrid);foreach(var K in J){var L=(IMyLightingBlock)K;ą.Add(L);}}void Q(){Ą=new List<
IMyLightingBlock>();var J=new List<IMyTerminalBlock>();var O=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(O==null)
{return;}O.GetBlocks(J,P=>P.CubeGrid==Me.CubeGrid);foreach(var K in J){var L=(IMyLightingBlock)K;L.Radius=4f;L.Intensity=
10f;L.BlinkLength=50f;L.BlinkIntervalSeconds=0.5f;Ą.Add(L);}}void x(){if(string.IsNullOrWhiteSpace(Me.CustomData)){È(á.â);
return;}var y=Me.CustomData.Split(';');if(y.Length<3){È(á.â);return;}var z=Convert.ToChar(y[0]);var ª=(float)Convert.ToDouble(
y[1]);var µ=(float)Convert.ToDouble(y[2]);switch(z){case'U':È(á.â);break;case'S':È(á.ã);break;case'M':È(á.ä);break;case
'H':È(á.å);break;case'X':È(á.æ);break;default:È(á.â);break;}Ċ=ª;đ=µ;}void º(){var À=new List<IMyRadioAntenna>();
GridTerminalSystem.GetBlocksOfType(À);var Á=À.FirstOrDefault();if(Á==null){return;}Á.Enabled=true;Á.Radius=5000;Á.EnableBroadcasting=true;
Á.HudText=$"(P{Ă.Ì}) {DRIVER_NAME}-{DRIVER_NUMBER}";ý=Á;}void Â(){IGC.RegisterBroadcastListener("Address");var Ã=new List
<IMyBroadcastListener>();IGC.GetBroadcastListeners(Ã);Č=Ã.FirstOrDefault();}void Ä(string Å){if(Å.Equals("LMT",
StringComparison.InvariantCultureIgnoreCase)){þ=!þ;return;}if(Å.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){þ=true;
return;}if(Å.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){þ=false;return;}if(Å.Equals("DRS",StringComparison
.InvariantCultureIgnoreCase)){ÿ=!ÿ;return;}if(Å.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ā=!Ā;return;}
if(Å.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){Æ(á.â);return;}if(Å.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){Æ(á.ã);return;}if(Å.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Æ(á.ä);return;}if(Å.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){Æ(á.å);return;}if(Å.Equals("EXTRA",StringComparison.InvariantCultureIgnoreCase)){Æ(á.æ);
return;}}void Æ(á Ç){if(!þ||ë.GetShipSpeed()>1){return;}È(Ç);h(true);}void È(á Ç){var É=Color.White;switch(Ç){case á.â:Ĉ=100;ć
=37.5f;ĉ=(Ĉ-ć)/(60*5);É=Color.Magenta;break;case á.ã:Ĉ=90;ć=40;ĉ=(Ĉ-ć)/(60*8);É=Color.Red;break;case á.ä:Ĉ=75;ć=43.75f;ĉ=
(Ĉ-ć)/(60*13);É=Color.Yellow;break;case á.å:Ĉ=60;ć=47.5f;ĉ=(Ĉ-ć)/(60*21);É=Color.White;break;case á.æ:Ĉ=55;ć=48.75f;ĉ=(Ĉ-
ć)/(60*34);É=Color.Cyan;break;default:break;}Ċ=Ĉ;Ć=Ç;w(É);foreach(var D in Ë){D.ApplyAction("Add Top Part");}}void w(
Color q){foreach(var K in ă){if(K is IMyLightingBlock){var L=(IMyLightingBlock)K;L.Color=q;}else if(K is IMyTextPanel){var M=
(IMyTextPanel)K;M.BackgroundColor=q;}}}void f(float g){foreach(var D in Ë){D.SetValueFloat("Speed Limit",g*3.6f);}}void h
(bool j=false){Ď-=(int)(Đ*1000);if(!j&&Ď>0){return;}var k=m();Me.CustomData=$"{k};{Ċ};{đ}";Ď=Ø;}char m(){var k='U';switch
(Ć){case á.â:k='U';break;case á.ã:k='S';break;case á.ä:k='M';break;case á.å:k='H';break;case á.æ:k='X';break;}return k;}
string n(){var o=string.Empty;switch(Ă.Ò){case ç.à:o="Blue";break;case ç.è:o="Green";break;case ç.é:o="Red";break;case ç.ê:o=
"Yellow";break;}return o;}Color p(){var q=Color.Black;switch(Ă.Ò){case ç.à:q=Color.Blue;break;case ç.è:q=Color.Green;break;case
ç.é:q=Color.Red;break;case ç.ê:q=Color.Yellow;break;}return q;}string r(){const int t=6;var u=Ā?Û:đ<1?Ú:'-';var v=u+"E:";
for(int V=0;V<t;V++){var Y=1f/t;if(đ>Y*V){if(đ<Y*(V+1)){v+=Ý;continue;}v+=Ü;}else{v+=Þ;}}return v;}