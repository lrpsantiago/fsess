private readonly string DRIVER_NAME = "Guest";
private readonly int DRIVER_NUMBER = 99;
private const float DEFAULT_SUSPENSION_STRENGTH = 10f;
private const float DEFAULT_SUSPENSION_SPEED_LIMIT = 999;
private const string DISPLAY_NAME = "Driver LCD";
private const string BRAKELIGHT_GROUP_NAME = "Brakelight";
private const string DRS_LIGHTS_GROUP_NAME = "DRS Lights";
private const string ERS_LIGHTS_GROUP_NAME = "ERS Lights";
private const bool AUTO_ERS = false; //Activates ERS whenever it's 100% Charge (true or false)

enum Ø{Ù,Ú,Û,Ü}enum Ý{Þ,ß,á,Ö}class Å{public int Í{get;set;}public int Æ{get;set;}public int Ç{get;set;}public string È{
get;set;}="--:--.---";public string É{get;set;}="--:--.---";public Ý Ê{get;set;}public void Ë(string Ì){try{var v=Ì.Split(
';');Æ=Convert.ToInt32(v[0]);Í=Convert.ToInt32(v[1]);È=v[2];É=v[3];}catch(Exception){}}}string Õ="7.0.0 Beta 3";const int Î
=3000;const int Ï=500;const float Ð=80f;const char Ñ='\u2191';const char Ò='\u2193';const char Ó='\u2588';const char Ô=
'\u2592';const char à='\u2591';List<IMyMotorSuspension>â;IMyCockpit ă;List<IMyTextSurface>ð;bool ñ;bool ò;bool ó;StringBuilder ô
;Å õ;List<IMyTerminalBlock>ö;List<IMyLightingBlock>ø;List<IMyLightingBlock>ù;Ø ú;float û=0;float ü=100;float ý=1;float þ=
100;long ÿ=-1;IMyBroadcastListener Ā;int ā;int Ă;DateTime Ą;float ï;float ã=1f;Program(){õ=new Å();I();B();D();F();J();t();
O();z();u();º();Runtime.UpdateFrequency=UpdateFrequency.Update10;Ą=DateTime.Now;}void Save(){}void Main(string Â,
UpdateType ä){var å=DateTime.Now;ï=(float)(å-Ą).TotalMilliseconds/1000;Echo($"Running FSESS {Õ}");Á(Â);Ä();T();V();Y();æ();é();Ą=å
;}void æ(){var ç=IGC.UnicastListener;if(!ç.HasPendingMessage){ā-=(int)(ï*1000);if(Ā.HasPendingMessage&&ā<=0){var è=Ā.
AcceptMessage();if(è.Tag=="Address"){ÿ=Convert.ToInt64(è.Data.ToString());IGC.SendUnicastMessage(ÿ,"Register",
$"{Me.CubeGrid.CustomName};{IGC.Me}");}}return;}while(ç.HasPendingMessage){var î=ç.AcceptMessage();if(î.Tag=="RaceData"){õ.Ë(î.Data.ToString());}if(î.Tag==
"Argument"){Á(î.Data.ToString());}}ā=Î;}void é(){ô.Clear();var S=ă.GetShipSpeed();var ê=((þ-û)/(ü-û))*100f;var ë=m();var ì=((int)
Math.Floor(ê)).ToString();var í=$"{S:F0}m/s";var q=n();ô.AppendLine(í+q.PadLeft(16-í.Length));ô.AppendLine(ñ?"PIT LIMITER":ê
<20?"TIRES WORN":"");ô.AppendLine($"P:{õ.Í:00}     L:{õ.Æ:00}/{õ.Ç:00}");ô.AppendLine($"TYRE ({ë})..: {ì,3}%");ô.
AppendLine($"TIME.: {õ.È}");ô.AppendLine($"BEST.: {õ.É}");if(ā<=0)ô.AppendLine($"NO CONNECTION");foreach(var H in ð){H.WriteText(ô
);var g=!ò?Color.Black:S<100?Color.DarkBlue:Color.DarkRed;H.BackgroundColor=g;H.ScriptBackgroundColor=g;}}void Ä(){if(!ñ)
{foreach(var E in â){E.Power=Ð;E.SetValueFloat("Speed Limit",DEFAULT_SUSPENSION_SPEED_LIMIT*3.6f);}return;}foreach(var E
in â){E.Power=20f;E.SetValueFloat("Speed Limit",26f*3.6f);}var S=ă.GetShipSpeed();ă.HandBrake=S>24;}void T(){var U=ă.
MoveIndicator.Z>0||ă.MoveIndicator.Y>0||ă.HandBrake||õ.Í==1;if(U){ò=false;}for(int R=0;R<â.Count;R++){var E=â[R];E.Strength=!ò?
DEFAULT_SUSPENSION_STRENGTH:100;}foreach(var L in ù){L.Enabled=ò;}}void V(){if(AUTO_ERS&&ã==1){ó=true;}if(ñ){ó=false;}var W=ă.MoveIndicator.Z<0;var
S=ă.GetShipSpeed();var X=(float)MathHelper.Clamp(S/90,0,1);if(S>1){if(!ó){ã+=(1f/240)*X*ï;}else if(W){ã+=-(1f/120)*X*ï;}}
ã=MathHelper.Clamp(ã,0,1);if(ã<=0){ó=false;}foreach(var E in â){E.Power=!ó?Ð:100;}foreach(var L in ø){L.Color=ó?Color.
Lime:Color.DarkRed;}}void Y(){var S=ă.GetShipSpeed();if(S<1){return;}var Z=(float)MathHelper.Clamp(S,0,90)/90;var a=ý*Z*ï;þ
-=a;þ=MathHelper.Clamp(þ,û,ü);foreach(var E in â){E.Friction=þ;}if(þ<=û){if(â.All(E=>E.IsAttached)){var A=new Random().
Next(4);â[A].Detach();}}j();}void I(){if(DRIVER_NUMBER<=0&&DRIVER_NUMBER>99){throw new Exception(
"DRIVER_NUMBER should be between 1 and 99");}Me.CubeGrid.CustomName=$"{DRIVER_NUMBER}-{DRIVER_NAME.Trim()}";}void B(){var C=new List<IMyCockpit>();
GridTerminalSystem.GetBlocksOfType(C);ă=C.FirstOrDefault();if(ă==null){throw new Exception("No cockpit!");}}void D(){â=new List<
IMyMotorSuspension>();GridTerminalSystem.GetBlocksOfType(â,E=>E.CubeGrid==Me.CubeGrid);if(â==null||â.Count!=4){throw new Exception(
"Need 4 suspensions!");}}void F(){ô=new StringBuilder();ð=new List<IMyTextSurface>{Me.GetSurface(0)};var G=(IMyTextSurface)GridTerminalSystem
.GetBlockWithName(DISPLAY_NAME);if(G!=null){ð.Add(G);}foreach(var H in ð){H.ContentType=ContentType.TEXT_AND_IMAGE;H.
Alignment=TextAlignment.CENTER;H.Font="Monospace";}}void J(){var P=new List<IMyTerminalBlock>();GridTerminalSystem.
GetBlockGroupWithName(BRAKELIGHT_GROUP_NAME).GetBlocks(P,K=>K.CubeGrid==Me.CubeGrid);ö=new List<IMyTerminalBlock>();foreach(var L in P){if(L
is IMyLightingBlock){var M=(IMyLightingBlock)L;M.Intensity=5f;M.BlinkLength=0f;M.BlinkIntervalSeconds=0f;}else if(L is
IMyTextPanel){var N=(IMyTextPanel)L;N.ContentType=ContentType.TEXT_AND_IMAGE;N.WriteText("",false);}ö.Add(L);}}void O(){ù=new List<
IMyLightingBlock>();var P=new List<IMyTerminalBlock>();var Q=GridTerminalSystem.GetBlockGroupWithName(DRS_LIGHTS_GROUP_NAME);if(Q==null)
{return;}Q.GetBlocks(P,K=>K.CubeGrid==Me.CubeGrid);foreach(var L in P){var M=(IMyLightingBlock)L;ù.Add(M);}}void t(){ø=
new List<IMyLightingBlock>();var P=new List<IMyTerminalBlock>();var Q=GridTerminalSystem.GetBlockGroupWithName(
ERS_LIGHTS_GROUP_NAME);if(Q==null){return;}Q.GetBlocks(P,K=>K.CubeGrid==Me.CubeGrid);foreach(var L in P){var M=(IMyLightingBlock)L;M.Radius=
0.1f;M.Intensity=4f;M.BlinkLength=0f;M.BlinkIntervalSeconds=0f;ø.Add(M);}}void u(){if(string.IsNullOrWhiteSpace(Me.
CustomData)){c(Ø.Ù);return;}var v=Me.CustomData.Split(';');if(v.Length<3){c(Ø.Ù);return;}var w=Convert.ToChar(v[0]);var x=(float)
Convert.ToDouble(v[1]);var y=(float)Convert.ToDouble(v[2]);switch(w){case'U':c(Ø.Ù);break;case'S':c(Ø.Ú);break;case'M':c(Ø.Û);
break;case'H':c(Ø.Ü);break;default:c(Ø.Ù);break;}þ=x;ã=y;}void z(){var ª=new List<IMyRadioAntenna>();GridTerminalSystem.
GetBlocksOfType(ª);var µ=ª.FirstOrDefault();if(µ==null){return;}µ.Radius=5000;µ.EnableBroadcasting=true;µ.HudText=
$"{DRIVER_NUMBER}-{DRIVER_NAME}";}void º(){IGC.RegisterBroadcastListener("Address");var À=new List<IMyBroadcastListener>();IGC.GetBroadcastListeners(À);
Ā=À.FirstOrDefault();}void Á(string Â){if(Â.Equals("LMT",StringComparison.InvariantCultureIgnoreCase)){ñ=!ñ;return;}if(Â.
Equals("LMT_ON",StringComparison.InvariantCultureIgnoreCase)){ñ=true;return;}if(Â.Equals("LMT_OFF",StringComparison.
InvariantCultureIgnoreCase)){ñ=false;return;}if(Â.Equals("DRS",StringComparison.InvariantCultureIgnoreCase)){ò=!ò;return;}if(Â.Equals("ERS",
StringComparison.InvariantCultureIgnoreCase)){ó=!ó;return;}if(Â.Equals("ULTRA",StringComparison.InvariantCultureIgnoreCase)){Ã(Ø.Ù);
return;}if(Â.Equals("SOFT",StringComparison.InvariantCultureIgnoreCase)){Ã(Ø.Ú);return;}if(Â.Equals("MEDIUM",StringComparison.
InvariantCultureIgnoreCase)){Ã(Ø.Û);return;}if(Â.Equals("HARD",StringComparison.InvariantCultureIgnoreCase)){Ã(Ø.Ü);return;}}void Ã(Ø h){if(!ñ||ă.
GetShipSpeed()>1){return;}c(h);j(true);}void c(Ø h){var e=Color.White;switch(h){case Ø.Ù:ü=100;û=37.5f;ý=(ü-û)/(60*5);e=Color.
Magenta;break;case Ø.Ú:ü=90;û=40;ý=(ü-û)/(60*8);e=Color.Red;break;case Ø.Û:ü=75;û=43.75f;ý=(ü-û)/(60*13);e=Color.Yellow;break;
case Ø.Ü:ü=60;û=47.5f;ý=(ü-û)/(60*21);e=Color.White;break;default:break;}þ=ü;ú=h;f(e);foreach(var E in â){E.ApplyAction(
"Add Top Part");}}void f(Color g){foreach(var L in ö){if(L is IMyLightingBlock){var M=(IMyLightingBlock)L;M.Color=g;}else if(L is
IMyTextPanel){var N=(IMyTextPanel)L;N.BackgroundColor=g;}}}void j(bool r=false){Ă-=(int)(ï*1000);if(!r&&Ă>0){return;}var k=m();Me.
CustomData=$"{k};{þ};{ã}";Ă=Ï;}char m(){var k='U';switch(ú){case Ø.Ù:k='U';break;case Ø.Ú:k='S';break;case Ø.Û:k='M';break;case Ø.
Ü:k='H';break;}return k;}string n(){const int o=6;var p=ó?Ò:ã<1?Ñ:'-';var q=p+"E:";for(int R=0;R<o;R++){var X=1f/o;if(ã>X
*R){if(ã<X*(R+1)){q+=Ô;continue;}q+=Ó;}else{q+=à;}}return q;}