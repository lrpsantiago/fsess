private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const float DEFAULT_SUSPENSION_SPEED_LIMIT = 999;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";

enum Õ{Ý,Ö,Ø,Ù}enum Ú{Û,Ü,Þ,Ô}class Ó{public int Ê{get;set;}public int Ä{get;set;}public int Å{get;set;}public string Æ{
get;set;}="--:--.---";public string Ç{get;set;}="--:--.---";public Ú È{get;set;}public void É(string Ë){try{var r=Ë.Split(
';');Ä=Convert.ToInt32(r[0]);Ê=Convert.ToInt32(r[1]);Æ=r[2];Ç=r[3];}catch(Exception){}}}string Ì="7.0.0 Beta";const int Í=
3000;const int Î=500;const float Ï=90f;const char Ð='\u2191';const char Ñ='\u2193';const char Ã='\u2588';const char ß=
'\u2592';const char à='\u2591';List<IMyMotorSuspension>í;IMyCockpit î;List<IMyTextSurface>ï;bool ð;bool ñ;bool ò;StringBuilder ó
;Ó õ;List<IMyTerminalBlock>ý;Õ ö;float ø=0;float ù=100;float ú=1;float û=100;long ü=-1;IMyBroadcastListener þ;int ô;int ì
;DateTime ã;float á;float â=0.5f;Program(){õ=new Ó();F();H();I();J();M();v();q();y();Runtime.UpdateFrequency=
UpdateFrequency.Update10;ã=DateTime.Now;}void Save(){}void Main(string µ,UpdateType ä){var ê=DateTime.Now;á=(float)(ê-ã).
TotalMilliseconds/1000;Echo($"Running FSESS {Ì}");ª(µ);T();X();V();P();å();é();ã=ê;}void å(){var æ=IGC.UnicastListener;if(!æ.
HasPendingMessage){ô-=(int)(á*1000);if(þ.HasPendingMessage&&ô<=0){var ç=þ.AcceptMessage();if(ç.Tag=="Address"){ü=Convert.ToInt64(ç.Data.
ToString());IGC.SendUnicastMessage(ü,"Register",$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(æ.HasPendingMessage){var è
=æ.AcceptMessage();if(è.Tag=="RaceData"){õ.É(è.Data.ToString());}if(è.Tag=="Argument"){ª(è.Data.ToString());}}ô=Í;}void é
(){ó.Clear();var G=î.GetShipSpeed();var ë=((û-ø)/(ù-ø))*100f;var Ò=j();var Â=((int)Math.Floor(ë)).ToString();var O=
$"{G:F0}m/s";var R=m();ó.AppendLine(O+R.PadLeft(16-O.Length));ó.AppendLine(ð?"PIT LIMITER":ë<20?"TIRES WORN":"");ó.AppendLine(
$"P:{õ.Ê:00}     L:{õ.Ä:00}/{õ.Å:00}");ó.AppendLine($"TYRE ({Ò})..: {Â,3}%");ó.AppendLine($"TIME.: {õ.Æ}");ó.AppendLine($"BEST.: {õ.Ç}");if(ô<=0)ó.AppendLine
($"NO CONNECTION");foreach(var L in ï){L.WriteText(ó);var S=!ñ?Color.Black:G<100?Color.DarkBlue:Color.DarkRed;L.
BackgroundColor=S;L.ScriptBackgroundColor=S;}}void T(){if(!ð){foreach(var D in í){D.Power=Ï;D.SetValueFloat("Speed Limit",
DEFAULT_SUSPENSION_SPEED_LIMIT*3.6f);}return;}foreach(var D in í){D.Power=20f;D.SetValueFloat("Speed Limit",26f*3.6f);}var G=î.GetShipSpeed();î.
HandBrake=G>24;}void X(){var U=î.MoveIndicator.Z>0||î.MoveIndicator.Y>0||î.HandBrake||õ.Ê==1;if(U){ñ=false;}for(int Q=0;Q<í.Count
;Q++){var D=í[Q];D.Strength=!ñ?DEFAULT_SUSPENSION_STRENGTH:100;}}void V(){if(ð){ò=false;}var W=î.MoveIndicator.Z<0;var G=
î.GetShipSpeed();var Y=(float)MathHelper.Clamp(G/90,0,1);if(G>1){if(!ò){â+=(1f/240)*Y*á;}else if(W){â+=-(1f/120)*Y*á;}}â=
MathHelper.Clamp(â,0,1);if(â<=0){ò=false;}foreach(var D in í){D.Power=!ò?Ï:100;}}void P(){var G=î.GetShipSpeed();if(G<1){return;}
var B=(float)MathHelper.Clamp(G,0,90)/90;var C=ú*B*á;û-=C;û=MathHelper.Clamp(û,ø,ù);foreach(var D in í){D.Friction=û;}if(û
<=ø){if(í.All(D=>D.IsAttached)){var E=new Random().Next(4);í[E].Detach();}}g();}void F(){if(DRIVER_NUMBER<=0&&
DRIVER_NUMBER>99){throw new Exception("DRIVER_NUMBER should be between 1 and 99");}Me.CubeGrid.CustomName=
$"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void H(){var N=new List<IMyCockpit>();GridTerminalSystem.GetBlocksOfType(N);î=N.FirstOrDefault();if(î==null){throw new
Exception("No cockpit!");}}void I(){í=new List<IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(í,D=>D.CubeGrid==Me.
CubeGrid);if(í==null||í.Count!=4){throw new Exception("Need 4 suspensions!");}}void J(){ó=new StringBuilder();ï=new List<
IMyTextSurface>{Me.GetSurface(0)};var K=(IMyTextSurface)GridTerminalSystem.GetBlockWithName(DISPLAY_NAME);if(K!=null){ï.Add(K);}
foreach(var L in ï){L.ContentType=ContentType.TEXT_AND_IMAGE;L.Alignment=TextAlignment.CENTER;L.Font="Monospace";}}void M(){var
A=new List<IMyTerminalBlock>();GridTerminalSystem.GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(A,Z=>Z.CubeGrid
==Me.CubeGrid);ý=new List<IMyTerminalBlock>();foreach(var a in A){if(a is IMyLightingBlock){var e=(IMyLightingBlock)a;e.
Intensity=5f;e.BlinkLength=0f;e.BlinkIntervalSeconds=0f;}else if(a is IMyTextPanel){var f=(IMyTextPanel)a;f.ContentType=
ContentType.TEXT_AND_IMAGE;f.WriteText("",false);}ý.Add(a);}}void q(){if(string.IsNullOrWhiteSpace(Me.CustomData)){Á(Õ.Ý);return;}
var r=Me.CustomData.Split(';');if(r.Length<2){Á(Õ.Ý);return;}var t=Convert.ToChar(r[0]);var u=(float)Convert.ToDouble(r[1])
;switch(t){case'U':Á(Õ.Ý);break;case'S':Á(Õ.Ö);break;case'M':Á(Õ.Ø);break;case'H':Á(Õ.Ù);break;default:Á(Õ.Ý);break;}û=u;
}void v(){var x=new List<IMyRadioAntenna>();GridTerminalSystem.GetBlocksOfType(x);var À=x.FirstOrDefault();if(À==null){
return;}À.Radius=5000;À.EnableBroadcasting=true;À.HudText=$"{DRIVER_NUMBER}-{DRIVER_NAME}";}void y(){IGC.
RegisterBroadcastListener("Address");var z=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(z);þ=z.FirstOrDefault();}void ª(string µ){
if(µ.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){ð=!ð;return;}if(µ.Equals("LMT_ON",StringComparison.
InvariantCultureIgnoreCase)){ð=true;return;}if(µ.Equals("LMT_OFF",StringComparison.InvariantCultureIgnoreCase)){ð=false;return;}if(µ.Equals("DRS",
StringComparison.InvariantCultureIgnoreCase)){ñ=!ñ;return;}if(µ.Equals("ERS",StringComparison.InvariantCultureIgnoreCase)){ò=!ò;return;}
if(µ.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){º(Õ.Ý);return;}if(µ.Equals("SOFT",StringComparison.
InvariantCultureIgnoreCase)){º(Õ.Ö);return;}if(µ.Equals("MEDIUM",StringComparison.InvariantCultureIgnoreCase)){º(Õ.Ø);return;}if(µ.Equals("HARD",
StringComparison.InvariantCultureIgnoreCase)){º(Õ.Ù);return;}}void º(Õ w){if(!ð||î.GetShipSpeed()>1){return;}Á(w);g(true);}void Á(Õ w){
var p=Color.White;switch(w){case Õ.Ý:ù=100;ø=37.5f;ú=(ù-ø)/(60*5);p=Color.Magenta;break;case Õ.Ö:ù=90;ø=40;ú=(ù-ø)/(60*8);p
=Color.Red;break;case Õ.Ø:ù=75;ø=43.75f;ú=(ù-ø)/(60*13);p=Color.Yellow;break;case Õ.Ù:ù=60;ø=47.5f;ú=(ù-ø)/(60*21);p=
Color.White;break;default:break;}û=ù;ö=w;c(p);foreach(var D in í){D.ApplyAction("Add Top Part");}}void c(Color S){foreach(var
a in ý){if(a is IMyLightingBlock){var e=(IMyLightingBlock)a;e.Color=S;}else if(a is IMyTextPanel){var f=(IMyTextPanel)a;f
.BackgroundColor=S;}}}void g(bool h=false){ì-=(int)(á*1000);if(!h&&ì>0){return;}var k=j();Me.CustomData=$"{k};{û}";ì=Î;}
char j(){var k='U';switch(ö){case Õ.Ý:k='U';break;case Õ.Ö:k='S';break;case Õ.Ø:k='M';break;case Õ.Ù:k='H';break;}return k;}
string m(){const int n=6;var o=ò?Ñ:â<1?Ð:'-';var R=o+"E:";for(int Q=0;Q<n;Q++){var Y=1f/n;if(â>Y*Q){if(â<Y*(Q+1)){R+=ß;
continue;}R+=Ã;}else{R+=à;}}return R;}