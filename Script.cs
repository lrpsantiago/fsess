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

enum ã{ä,å,æ,ç,è}enum é{ê,ì,ë,â}class à{public int Í{get;set;}public int Î{get;set;}public int Ï{get;set;}public int Ð{
get;set;}public string Ñ{get;set;}="--:--.---";public string Ò{get;set;}="--:--.---";public é Ó{get;set;}public void Ô(
string Õ){try{var z=Õ.Split(';');Ï=Convert.ToInt32(z[0]);Í=Convert.ToInt32(z[1]);Ñ=z[2];Ò=z[3];Î=Convert.ToInt32(z[4]);Ð=
Convert.ToInt32(z[5]);Ó=(é)Convert.ToInt32(z[6]);}catch(Exception){}}}string Ö="7.1.0";const int Ø=3000;const int Ù=1000;const
float Ú=80f;const char Û='\u2191';const char Ü='\u2193';const char Ý='\u2588';const char Þ='\u2592';const char ß='\u2591';
List<IMyMotorSuspension>Ì;IMyCockpit á;List<IMyTextSurface>í;IMyRadioAntenna ÿ;bool Ā;bool ā;bool Ă;StringBuilder ă;à Ą;List
<IMyTerminalBlock>ą;List<IMyLightingBlock>Ć;List<IMyLightingBlock>ć;ã Ĉ;float Ċ=0;float Ĕ=100;float ċ=1;float Č=100;long
č=-1;IMyBroadcastListener Ď;int ď;int Đ;DateTime đ;float Ē;float ē=1f;Program(){Ą=new à();Q();P();C();E();H();A();N();À()
;y();Ê();Runtime.UpdateFrequency=UpdateFrequency.Update1;đ=DateTime.Now;}void Save(){}void Main(string Å,UpdateType î){
var ï=DateTime.Now;Ē=(float)(ï-đ).TotalMilliseconds/1000;Echo($"Running FSESS {Ö}");Ä(Å);T();W();ð();ĉ();Z();ó();ø();e();đ=
ï;}void ð(){switch(Ą.Ó){case é.ì:ñ();break;case é.ë:ò();break;default:if(!Ā){á.HandBrake=false;g(
DEFAULT_SUSPENSION_SPEED_LIMIT);}break;}}void ñ(){ā=false;Ă=false;á.HandBrake=á.GetShipSpeed()>50;g(50f);}void ò(){ā=false;Ă=false;Ā=false;á.HandBrake
=true;}void ó(){var ô=IGC.UnicastListener;if(!ô.HasPendingMessage){ď-=(int)(Ē*1000);if(Ď.HasPendingMessage&&ď<=0){var õ=Ď
.AcceptMessage();if(õ.Tag=="Address"){č=Convert.ToInt64(õ.Data.ToString());IGC.SendUnicastMessage(č,"Register",
$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ô.HasPendingMessage){var ö=ô.AcceptMessage();if(ö.Tag=="RaceData"){Ą.Ô(ö.Data.ToString());}if(ö.Tag==
"Argument"){Ä(ö.Data.ToString());}}ď=Ø;}void ø(){ă.Clear();var S=á.GetShipSpeed();var ù=((Č-Ċ)/(Ĕ-Ċ))*100f;var ú=n();var û=((int)
Math.Floor(ù)).ToString();var ü=$"{S:F0}m/s";var w=t();var õ=Ā?"PIT LIMITER":ā?"DRS ON":"";ă.AppendLine(ü+w.PadLeft(16-ü.
Length));ă.AppendLine(õ);ă.AppendLine($"P:{Ą.Í:00}/{Ą.Î:00}  L:{(Ą.Ï):00}/{Ą.Ð:00}");ă.AppendLine($"TYRE ({ú})..: {û,3}%");ă.
AppendLine($"TIME.: {Ą.Ñ}");ă.AppendLine($"BEST.: {Ą.Ò}");if(ď<=0){ă.AppendLine($"NO CONNECTION");}foreach(var G in í){G.WriteText
(ă);var ý=Color.Black;var þ=DEFAULT_FONT_COLOR;switch(Ą.Ó){case é.ì:ý=Color.Yellow;þ=Color.Black;break;case é.ë:ý=Color.
Red;þ=Color.White;break;case é.â:ý=Color.Blue;þ=Color.White;break;}G.BackgroundColor=ý;G.ScriptBackgroundColor=ý;G.
FontColor=þ;}}void ĉ(){if(!Ā){foreach(var D in Ì){D.Power=Ú;D.SetValueFloat("Speed Limit",DEFAULT_SUSPENSION_SPEED_LIMIT*3.6f);}
return;}foreach(var D in Ì){D.Power=20f;D.SetValueFloat("Speed Limit",26f*3.6f);}var S=á.GetShipSpeed();á.HandBrake=S>24;}void
T(){var U=á.MoveIndicator.Z>0||á.MoveIndicator.Y>0||á.HandBrake;if(U){ā=false;}for(int V=0;V<Ì.Count;V++){var D=Ì[V];D.
Strength=!ā?DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var K in ć){K.Color=ā?Color.Blue:Color.Black;K.Enabled=ā;}}void W(){if(
AUTO_ERS&&ē==1){Ă=true;}if(Ā){Ă=false;}var X=á.MoveIndicator.Z<0;var S=á.GetShipSpeed();if(S>1){if(!Ă){var Y=(float)MathHelper.
Clamp(S/100,0,1);ē+=(1f/240)*Y*Ē;}else if(X){var Y=(float)MathHelper.Clamp(S/100,1,0);ē-=(1f/120)*Y*Ē;}}ē=MathHelper.Clamp(ē,
0,1);if(ē<=0){Ă=false;}foreach(var D in Ì){D.Power=!Ă?Ú:100;}foreach(var K in Ć){K.Color=Ă?Color.Lime:Color.Red;}}void Z(
){var S=á.GetShipSpeed();if(S<1){return;}var a=(float)MathHelper.Clamp(S,0,90)/90;var c=ċ*a*Ē;Č-=c;Č=MathHelper.Clamp(Č,Ċ
,Ĕ);foreach(var D in Ì){D.Friction=Č;}if(Č<=Ċ){if(Ì.All(D=>D.IsAttached)){var f=new Random().Next(4);Ì[f].Detach();}}j();
}void e(){if(ÿ==null){return;}ÿ.HudText=$"P{Ą.Í}";}void Q(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}Me.CubeGrid.CustomName=$"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void P(){var B=new List<IMyCockpit>();
GridTerminalSystem.GetBlocksOfType(B);á=B.FirstOrDefault();if(á==null){throw new Exception("No cockpit!");}}void C(){Ì=new List<
IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(Ì,D=>D.CubeGrid==Me.CubeGrid);if(Ì==null||Ì.Count!=4){throw new Exception(
"Need 4 suspensions!");}}void E(){ă=new StringBuilder();í=new List<IMyTextSurface>{Me.GetSurface(0)};var F=(IMyTextSurface)GridTerminalSystem
.GetBlockWithName(DISPLAY_NAME);if(F!=null){í.Add(F);}if(COCKPIT_DISPLAY_INDEX.HasValue){var G=á.GetSurface(
COCKPIT_DISPLAY_INDEX.GetValueOrDefault());if(G!=null){í.Add(G);}}foreach(var G in í){G.ContentType=ContentType.TEXT_AND_IMAGE;G.Alignment=
TextAlignment.CENTER;G.Font="Monospace";}}void H(){var I=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(
BRAKELIGHT_GROUP_NAME).GetBlocks(I,J=>J.CubeGrid==Me.CubeGrid);ą=new List<IMyTerminalBlock>();foreach(var K in I){if(K is IMyLightingBlock){
var L=(IMyLightingBlock)K;L.Intensity=5f;L.BlinkLength=0f;L.BlinkIntervalSeconds=0f;}else if(K is IMyTextPanel){var M=(
IMyTextPanel)K;M.ContentType=ContentType.TEXT_AND_IMAGE;M.WriteText("",false);}ą.Add(K);}}void N(){ć=new List<IMyLightingBlock>();
var I=new List<IMyTerminalBlock>();var O=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(O==null){return
;}O.GetBlocks(I,J=>J.CubeGrid==Me.CubeGrid);foreach(var K in I){var L=(IMyLightingBlock)K;ć.Add(L);}}void A(){Ć=new List<
IMyLightingBlock>();var I=new List<IMyTerminalBlock>();var O=GridTerminalSystem.GetBlockGroupWithName(ERS_LIGHTS_GROUP_NAME);if(O==null)
{return;}O.GetBlocks(I,J=>J.CubeGrid==Me.CubeGrid);foreach(var K in I){var L=(IMyLightingBlock)K;L.Radius=4f;L.Intensity=
10f;L.BlinkLength=50f;L.BlinkIntervalSeconds=0.5f;Ć.Add(L);}}void y(){if(string.IsNullOrWhiteSpace(Me.CustomData)){È(ã.ä);
return;}var z=Me.CustomData.Split(';');if(z.Length<3){È(ã.ä);return;}var ª=Convert.ToChar(z[0]);var µ=(float)Convert.ToDouble(
z[1]);var º=(float)Convert.ToDouble(z[2]);switch(ª){case'U':È(ã.ä);break;case'S':È(ã.å);break;case'M':È(ã.æ);break;case
'H':È(ã.ç);break;case'X':È(ã.è);break;default:È(ã.ä);break;}Č=µ;ē=º;}void À(){var Á=new List<IMyRadioAntenna>();
GridTerminalSystem.GetBlocksOfType(Á);var Â=Á.FirstOrDefault();if(Â==null){return;}Â.Enabled=true;Â.Radius=5000;Â.EnableBroadcasting=true;
Â.HudText=$"(P{Ą.Í}) {DRIVER_NAME}-{DRIVER_NUMBER}";ÿ=Â;}void Ê(){IGC.RegisterBroadcastListener("Address");var Ã=new List
<IMyBroadcastListener>();IGC.GetBroadcastListeners(Ã);Ď=Ã.FirstOrDefault();}void Ä(string Å){if(Å.Equals("LMT",
StringComparison.InvariantCultureIgnoreCase)){Ā=!Ā;return;}if(Å.Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){Ā=true;
return;}if(Å.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){Ā=false;return;}if(Å.Equals("DRS",StringComparison
.InvariantCultureIgnoreCase)){ā=!ā;return;}if(Å.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){Ă=!Ă;return;}
if(Å.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){Æ(ã.ä);return;}if(Å.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){Æ(ã.å);return;}if(Å.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){Æ(ã.æ);return;}if(Å.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){Æ(ã.ç);return;}if(Å.Equals("EXTRA",StringComparison.InvariantCultureIgnoreCase)){Æ(ã.è);
return;}if(Å.Equals("FLAG_G",StringComparison.InvariantCultureIgnoreCase)){R(é.ê);return;}if(Å.Equals("FLAG_Y",
StringComparison.InvariantCultureIgnoreCase)){R(é.ì);return;}if(Å.Equals("FLAG_R",StringComparison.InvariantCultureIgnoreCase)){R(é.ë);
return;}}void Æ(ã Ç){if(!Ā||á.GetShipSpeed()>1){return;}È(Ç);j(true);}void È(ã Ç){var É=Color.White;switch(Ç){case ã.ä:Ĕ=100;Ċ
=37.5f;ċ=(Ĕ-Ċ)/(60*5);É=Color.Magenta;break;case ã.å:Ĕ=90;Ċ=40;ċ=(Ĕ-Ċ)/(60*8);É=Color.Red;break;case ã.æ:Ĕ=75;Ċ=43.75f;ċ=
(Ĕ-Ċ)/(60*13);É=Color.Yellow;break;case ã.ç:Ĕ=60;Ċ=47.5f;ċ=(Ĕ-Ċ)/(60*21);É=Color.White;break;case ã.è:Ĕ=55;Ċ=48.75f;ċ=(Ĕ-
Ċ)/(60*34);É=Color.Cyan;break;default:break;}Č=Ĕ;Ĉ=Ç;Ë(É);foreach(var D in Ì){D.ApplyAction("Add Top Part");}}void Ë(
Color r){foreach(var K in ą){if(K is IMyLightingBlock){var L=(IMyLightingBlock)K;L.Color=r;}else if(K is IMyTextPanel){var M=
(IMyTextPanel)K;M.BackgroundColor=r;}}}void g(float h){foreach(var D in Ì){D.SetValueFloat("Speed Limit",h*3.6f);}}void j
(bool k=false){Đ-=(int)(Ē*1000);if(!k&&Đ>0){return;}var m=n();Me.CustomData=$"{m};{Č};{ē}";Đ=Ù;}char n(){var m='U';switch
(Ĉ){case ã.ä:m='U';break;case ã.å:m='S';break;case ã.æ:m='M';break;case ã.ç:m='H';break;case ã.è:m='X';break;}return m;}
string o(){var p=string.Empty;switch(Ą.Ó){case é.â:p="Blue";break;case é.ê:p="Green";break;case é.ë:p="Red";break;case é.ì:p=
"Yellow";break;}return p;}Color q(){var r=Color.Black;switch(Ą.Ó){case é.â:r=Color.Blue;break;case é.ê:r=Color.Green;break;case
é.ë:r=Color.Red;break;case é.ì:r=Color.Yellow;break;}return r;}string t(){const int u=6;var v=Ă?Ü:ē<1?Û:'-';var w=v+"E:";
for(int V=0;V<u;V++){var Y=1f/u;if(ē>Y*V){if(ē<Y*(V+1)){w+=Þ;continue;}w+=Ý;}else{w+=ß;}}return w;}void R(é x){if(č<=0){
return;}IGC.SendUnicastMessage(č,"Flag",$"{(int)x}");}