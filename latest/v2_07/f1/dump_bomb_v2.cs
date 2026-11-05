	Строка  138141: 	public bool DebugInfoBombManagerEnabled; // 0x2A
	Строка  155144: private struct BombManager.bdg : IAsyncStateMachine // TypeDefIndex: 3926
	Строка  155148: 	public faf<BombManager> cgqi; // 0x8
	Строка  155164: public class BombManager : efa<BombManager> // TypeDefIndex: 3927
	Строка  155511: 	|-BombManager.pqv<object>
	Строка  155519: 	|-BombManager.pqw<object>
	Строка  155556: 	[AsyncStateMachine(typeof(BombManager.bdg))]
	Строка  155558: 	public static UniTask<BombManager> prf(CancellationToken a) { }
	Строка  155562: 	internal static BombManager prg(fiu a, short b, string c, eek d) { }
	Строка  155566: 	private static BombManager prh(short a, string b, eek c) { }
	Строка  267586: 	private BombManager crop; // 0x1C0
	Строка  937817: 	|-faf<object>.bnmd<eqy.eqx, BombManager.bdg>
	Строка  937997: 	|-faf<object>.Start<BombManager.bdg>
	Строка  942323: 	|-fan.<>c<BombManager.bdg, object>..cctor
	Строка  942389: 	|-fan.<>c<BombManager.bdg, object>..ctor
	Строка  942457: 	|-fan.<>c<BombManager.bdg, object>.bnnl
	Строка  942546: 	|-fan<BombManager.bdg, object>.bnmt
	Строка  942616: 	|-fan<BombManager.bdg, object>..ctor
	Строка  942798: 	|-fan<BombManager.bdg, object>.bnnm
	Строка  942978: 	|-fan<BombManager.bdg, object>.bklp
	Строка  943072: 	|-fan<BombManager.bdg, object>..cctor
	Строка  943252: 	|-fan<BombManager.bdg, object>.bnnn
	Строка  943368: 	|-fan<BombManager.bdg, object>.bnno
	Строка  943487: 	|-fan<BombManager.bdg, object>.bnnp
	Строка  943668: 	|-fan<BombManager.bdg, object>.bnmu
	Строка  943765: 	|-fan<BombManager.bdg, object>.bnmv
	Строка  943882: 	|-fan<BombManager.bdg, object>.bnmw
	Строка  944001: 	|-fan<BombManager.bdg, object>.GetResult
	Строка  944184: 	|-fan<BombManager.bdg, object>.bnnq
	Строка  944365: 	|-fan<BombManager.bdg, object>.bkhq
	Строка  944482: 	|-fan<BombManager.bdg, object>.bkhr
	Строка  944599: 	|-fan<BombManager.bdg, object>.bkhp

  // Namespace: Chillow.StandChillow.Settings.SpecialAbilities
[ReflectableSettings]
[Serializable]
public class SpecialAbilitiesSettings // TypeDefIndex: 3496
{
	// Fields
	[ReflectSetting(ceso = "Enable Debug Console (Ins - Open/Close on pc)")]
	public bool DebugConsoleEnabled; // 0x10
	[ReflectSetting(ceso = "StandChillow/SpecialAbilities/ShowSkinIDInInspectField")]
	public bool ShowSkinIdInInspect; // 0x11
	[ReflectSetting(ceso = "StandChillow/SpecialAbilities/ShowItemIDInInventory")]
	public bool ShowInventoryItemIds; // 0x12
	[ReflectSetting(ceso = "Enable Force Disconnect Button In Online")]
	public bool EnableForceDisconnectButton; // 0x13
	[ReflectSetting(ceso = "Show bot debug info in marker")]
	public bool ShowBotDebugInfoInMarker; // 0x14
	[ReflectSetting(ceso = "Show bot stucked chat message")]
	public bool ShowBotStuckedChatMessage; // 0x15
	[ReflectSetting(ceso = "Start offline/lan matches immediate")]
	public bool StartOfflineLanMatchesImmediate; // 0x16
	[ReflectSetting(ceso = "Disable position marker cooldown (offline only)")]
	public bool DisablePositionMarkerCooldown; // 0x17
	[ReflectSetting(ceso = "Log detailed FMOD statistics (every 5s)")]
	public bool IsFmodStatsLogEnabled; // 0x18
	[ReflectSetting(ceso = "Enable Lan Lobby Debug Messages")]
	public bool LanLobbyDebugEnabled; // 0x19
	[ReflectSetting(ceso = "Force fallback remote config")]
	public bool ForceFallbackRemoteConfig; // 0x1A
	[ReflectSetting(ceso = "Enable Pause Debug Buttons")]
	public bool EnablePauseDebugButtons; // 0x1B
	[ReflectSetting(ceso = "Enable Unfinished Spectator Mode")]
	public bool EnableUnfinishedSpectatorMode; // 0x1C
	[ReflectSetting(ceso = "Disable Workshop Index Caching")]
	public bool DisableWorkshopIndexCaching; // 0x1D
	[ReflectSetting(ceso = "Disable Workshop Media Caching")]
	public bool DisableWorkshopMediaCaching; // 0x1E
	[ReflectSetting(ceso = "Verbose Splash Screen")]
	public bool VerboseSplashScreen; // 0x1F
	[ReflectSetting(ceso = "Debug Info: Enabled")]
	public bool DebugInfoViewEnabled; // 0x20
	[ReflectSetting(ceso = "Debug Info: Graphics Device")]
	public bool DebugInfoGraphicsDeviceCategoryEnabled; // 0x21
	[ReflectSetting(ceso = "Debug Info: FMOD")]
	public bool DebugInfoFmodEnabled; // 0x22
	[ReflectSetting(ceso = "Debug Info: Auth")]
	public bool DebugInfoAuthCategoryEnabled; // 0x23
	[ReflectSetting(ceso = "Debug Info: Game Controller")]
	public bool DebugInfoGameControllerCategoryEnabled; // 0x24
	[ReflectSetting(ceso = "Debug Info: Netcode Client")]
	public bool DebugInfoNetcodeClientCategoryEnabled; // 0x25
	[ReflectSetting(ceso = "Debug Info: Netcode Dedicated Server")]
	public bool DebugInfoNetcodeDedicatedServerCategoryEnabled; // 0x26
	[ReflectSetting(ceso = "Debug Info: Netcode Lan")]
	public bool DebugInfoNetcodeLanDiscoveryEnabled; // 0x27
	[ReflectSetting(ceso = "Debug Info: Occluder")]
	public bool DebugInfoOccluderCategoryEnabled; // 0x28
	[ReflectSetting(ceso = "Debug Info: Spectating bot / local player simulated as bot debug info")]
	public bool DebugInfoSpectatingBotOrLocalPlayer; // 0x29
	[ReflectSetting(ceso = "Debug Info: Bomb Manager")]
	public bool DebugInfoBombManagerEnabled; // 0x2A
	[ReflectSetting(ceso = "Debug Info: Weapon Drop Manager")]
	public bool DebugWeaponDropManagerEnabled; // 0x2B

	// Methods

	// RVA: 0x1297C50 Offset: 0x1296C50 VA: 0x181297C50
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct BombManager.bdg : IAsyncStateMachine // TypeDefIndex: 3926
{
	// Fields
	public int cgqh; // 0x0
	public faf<BombManager> cgqi; // 0x8
	public CancellationToken cgqj; // 0x20
	private eqy.eqx cgqk; // 0x28

	// Methods

	// RVA: 0x1352AA0 Offset: 0x1351AA0 VA: 0x181352AA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1352D50 Offset: 0x1351D50 VA: 0x181352D50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Chillow.StandChillow.Netcode.SceneManagers
[SceneManager(251)]
public class BombManager : efa<BombManager> // TypeDefIndex: 3927
{
	// Fields
	[CompilerGenerated]
	private short <cgql>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <cgqm>k__BackingField; // 0x3A
	[CompilerGenerated]
	private BombSite[] <cgqn>k__BackingField; // 0x40
	[CompilerGenerated]
	private BombSitesContainer[] <cgqo>k__BackingField; // 0x48
	private Vector3 cgqp; // 0x50
	private Vector3 cgqq; // 0x5C
	private float cgqr; // 0x68
	private cks cgqs; // 0x70
	private PlantedBombController cgqt; // 0x78
	private byte cgqu; // 0x80
	private byte cgqv; // 0x81
	private BombParameters cgqw; // 0x88
	private BombSoundParameters cgqx; // 0x90
	private BombExtendedParameters cgqy; // 0x98
	private bool cgqz; // 0xA0
	private bool cgra; // 0xA1
	[CompilerGenerated]
	private bool <cgrb>k__BackingField; // 0xA2
	[CompilerGenerated]
	private double <cgrc>k__BackingField; // 0xA8
	[CompilerGenerated]
	private double <cgrd>k__BackingField; // 0xB0
	[CompilerGenerated]
	private double <cgre>k__BackingField; // 0xB8
	[CompilerGenerated]
	private bool <cgrf>k__BackingField; // 0xC0
	private Transform cgrg; // 0xC8

	// Properties
	public short cgql { get; set; }
	public short cgqm { get; set; }
	public BombSite[] cgqn { get; set; }
	public bool dpoi { get; }
	public BombSitesContainer[] cgqo { get; set; }
	public byte dpoj { get; }
	public byte dpok { get; }
	public bool cgrb { get; set; }
	public double cgrc { get; set; }
	public double cgrd { get; set; }
	public double cgre { get; set; }
	public bool cgrf { get; set; }
	public double dpol { get; }
	public double dpom { get; }
	public double dpon { get; }
	public edq dpoo { get; }
	public edq dpop { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x11F2F00 Offset: 0x11F1F00 VA: 0x1811F2F00
	public short pnl() { }

	[CompilerGenerated]
	// RVA: 0x13387E0 Offset: 0x13377E0 VA: 0x1813387E0
	private void pnm(short a) { }

	[CompilerGenerated]
	// RVA: 0x13387F0 Offset: 0x13377F0 VA: 0x1813387F0
	public short pnn() { }

	[CompilerGenerated]
	// RVA: 0x1338800 Offset: 0x1337800 VA: 0x181338800
	private void pno(short a) { }

	[CompilerGenerated]
	// RVA: 0x5FF100 Offset: 0x5FE100 VA: 0x1805FF100
	public BombSite[] pnp() { }

	[CompilerGenerated]
	// RVA: 0x5FF1B0 Offset: 0x5FE1B0 VA: 0x1805FF1B0
	private void pnq(BombSite[] a) { }

	// RVA: 0x1338810 Offset: 0x1337810 VA: 0x181338810
	public bool pnr() { }

	[CompilerGenerated]
	// RVA: 0x694C80 Offset: 0x693C80 VA: 0x180694C80
	public BombSitesContainer[] pns() { }

	[CompilerGenerated]
	// RVA: 0x694C90 Offset: 0x693C90 VA: 0x180694C90
	private void pnt(BombSitesContainer[] a) { }

	// RVA: 0x1338830 Offset: 0x1337830 VA: 0x181338830
	public byte pnu() { }

	// RVA: 0x1338890 Offset: 0x1337890 VA: 0x181338890
	public byte pnv() { }

	[CompilerGenerated]
	// RVA: 0x13388F0 Offset: 0x13378F0 VA: 0x1813388F0
	public bool pnw() { }

	[CompilerGenerated]
	// RVA: 0x1338900 Offset: 0x1337900 VA: 0x181338900
	private void pnx(bool a) { }

	[CompilerGenerated]
	// RVA: 0x12E9990 Offset: 0x12E8990 VA: 0x1812E9990
	public double pny() { }

	[CompilerGenerated]
	// RVA: 0x12E99A0 Offset: 0x12E89A0 VA: 0x1812E99A0
	private void pnz(double a) { }

	[CompilerGenerated]
	// RVA: 0x1338910 Offset: 0x1337910 VA: 0x181338910
	public double poa() { }

	[CompilerGenerated]
	// RVA: 0x1338920 Offset: 0x1337920 VA: 0x181338920
	private void pob(double a) { }

	[CompilerGenerated]
	// RVA: 0x1338930 Offset: 0x1337930 VA: 0x181338930
	public double poc() { }

	[CompilerGenerated]
	// RVA: 0x1338940 Offset: 0x1337940 VA: 0x181338940
	private void pod(double a) { }

	[CompilerGenerated]
	// RVA: 0x10C6750 Offset: 0x10C5750 VA: 0x1810C6750
	public bool poe() { }

	[CompilerGenerated]
	// RVA: 0x1338950 Offset: 0x1337950 VA: 0x181338950
	private void pof(bool a) { }

	// RVA: 0x1338960 Offset: 0x1337960 VA: 0x181338960
	public double pog() { }

	// RVA: 0x1338A00 Offset: 0x1337A00 VA: 0x181338A00
	public double poh() { }

	// RVA: 0x1338A90 Offset: 0x1337A90 VA: 0x181338A90
	public double poi() { }

	// RVA: 0x1338B10 Offset: 0x1337B10 VA: 0x181338B10
	public edq poj() { }

	// RVA: 0x1338B80 Offset: 0x1337B80 VA: 0x181338B80
	public edq pok() { }

	[SpawnArgs]
	// RVA: 0x1338BF0 Offset: 0x1337BF0 VA: 0x181338BF0
	private void pol() { }

	// RVA: 0x13391A0 Offset: 0x13381A0 VA: 0x1813391A0 Slot: 7
	protected override void pom() { }

	// RVA: 0x13394E0 Offset: 0x13384E0 VA: 0x1813394E0
	private void pon() { }

	// RVA: 0x5E63F0 Offset: 0x5E53F0 VA: 0x1805E63F0
	public void poo(cks a) { }

	// RVA: 0x13395D0 Offset: 0x13385D0 VA: 0x1813395D0
	private void pop() { }

	// RVA: 0x1339620 Offset: 0x1338620 VA: 0x181339620
	private void poq(WeaponDropController a, cki b) { }

	// RVA: 0x1339660 Offset: 0x1338660 VA: 0x181339660
	private void por(ckn a, cki b) { }

	// RVA: 0x1339700 Offset: 0x1338700 VA: 0x181339700
	public void pot() { }

	// RVA: 0x1339760 Offset: 0x1338760 VA: 0x181339760
	public void pou(edq a) { }

	[Rpc(1)]
	// RVA: 0x1339AA0 Offset: 0x1338AA0 VA: 0x181339AA0
	private void pov(short a, Vector3 b, Vector3 c) { }

	// RVA: 0x1339B30 Offset: 0x1338B30 VA: 0x181339B30
	public bool pow() { }

	// RVA: 0x1339B40 Offset: 0x1338B40 VA: 0x181339B40
	public void pox(edq a) { }

	// RVA: 0x1339BF0 Offset: 0x1338BF0 VA: 0x181339BF0
	public void poy(edq a) { }

	// RVA: 0x13387E0 Offset: 0x13377E0 VA: 0x1813387E0
	private void poz(short a) { }

	// RVA: 0x1339CC0 Offset: 0x1338CC0 VA: 0x181339CC0
	private void ppa() { }

	[Rpc(2)]
	// RVA: 0x1339F20 Offset: 0x1338F20 VA: 0x181339F20
	private void ppb(short a, Vector3 b, Vector3 c) { }

	// RVA: 0x133A080 Offset: 0x1339080 VA: 0x18133A080
	private WeaponryController ppc() { }

	// RVA: 0x133A170 Offset: 0x1339170 VA: 0x18133A170
	public bool ppd(edq a, BombController b) { }

	// RVA: 0x133A310 Offset: 0x1339310 VA: 0x18133A310
	public bool ppe(Transform a) { }

	// RVA: 0x133A3F0 Offset: 0x13393F0 VA: 0x18133A3F0
	public void ppf(edq a, Vector3 b, float c, bool d) { }

	[Rpc(3)]
	// RVA: 0x133A540 Offset: 0x1339540 VA: 0x18133A540
	private void ppg(int a, Vector3 b, float c, bool d, efb e) { }

	// RVA: 0x133A7F0 Offset: 0x13397F0 VA: 0x18133A7F0
	public bool pph(edq a, float b, bool c = False) { }

	// RVA: 0x133AA10 Offset: 0x1339A10 VA: 0x18133AA10
	public void ppi(edq a, float b, float c) { }

	[Rpc(4)]
	// RVA: 0x133ABC0 Offset: 0x1339BC0 VA: 0x18133ABC0
	private void ppj(short a, short b, float c, efb d) { }

	// RVA: 0x133ADB0 Offset: 0x1339DB0 VA: 0x18133ADB0
	private void ppk() { }

	// RVA: 0x133AE60 Offset: 0x1339E60 VA: 0x18133AE60
	public void ppl(edq a) { }

	// RVA: 0x133AFB0 Offset: 0x1339FB0 VA: 0x18133AFB0
	public void ppm(int a) { }

	[Rpc(5)]
	// RVA: 0x133B0F0 Offset: 0x133A0F0 VA: 0x18133B0F0
	private void ppn(int a, efb b) { }

	// RVA: 0x133B130 Offset: 0x133A130 VA: 0x18133B130
	public bool ppo(edq a) { }

	// RVA: 0x133B1B0 Offset: 0x133A1B0 VA: 0x18133B1B0
	public bool ppp(edq a) { }

	// RVA: 0x133B210 Offset: 0x133A210 VA: 0x18133B210
	public bool ppq(int a) { }

	// RVA: 0x133B260 Offset: 0x133A260 VA: 0x18133B260
	public bool ppr(int a) { }

	// RVA: 0x133B310 Offset: 0x133A310 VA: 0x18133B310
	private bool pps() { }

	// RVA: 0x133B3F0 Offset: 0x133A3F0 VA: 0x18133B3F0
	public void ppt(edq a) { }

	// RVA: 0x133B410 Offset: 0x133A410 VA: 0x18133B410
	public void ppu(int a) { }

	// RVA: 0x133B590 Offset: 0x133A590 VA: 0x18133B590
	private void ppv(int a) { }

	// RVA: 0x133B680 Offset: 0x133A680 VA: 0x18133B680
	private bool ppw() { }

	// RVA: 0x133B710 Offset: 0x133A710 VA: 0x18133B710
	public void ppx() { }

	// RVA: 0x133B8A0 Offset: 0x133A8A0 VA: 0x18133B8A0
	private bool ppy() { }

	// RVA: 0x133B910 Offset: 0x133A910 VA: 0x18133B910
	private bool ppz() { }

	// RVA: 0x133B990 Offset: 0x133A990 VA: 0x18133B990
	private void pqa(bool a, double b) { }

	[Rpc(6)]
	// RVA: 0x133BAF0 Offset: 0x133AAF0 VA: 0x18133BAF0
	private void pqb(bool a, byte b, float c, efb d) { }

	// RVA: 0x133BC00 Offset: 0x133AC00 VA: 0x18133BC00
	private void pqc(byte a, float b) { }

	// RVA: 0x133BCE0 Offset: 0x133ACE0 VA: 0x18133BCE0
	private void pqd() { }

	// RVA: 0x133BE80 Offset: 0x133AE80 VA: 0x18133BE80
	private void pqe(edq a) { }

	// RVA: 0x133C0E0 Offset: 0x133B0E0 VA: 0x18133C0E0
	private void pqf(WeaponryController a, PlayerHitController b, edq c) { }

	// RVA: 0x133C600 Offset: 0x133B600 VA: 0x18133C600
	public bool pqg() { }

	// RVA: 0x133C690 Offset: 0x133B690 VA: 0x18133C690
	public Vector3 pqh() { }

	// RVA: 0x133C7A0 Offset: 0x133B7A0 VA: 0x18133C7A0
	public BombSite pqi() { }

	// RVA: 0x133C890 Offset: 0x133B890 VA: 0x18133C890
	public BombSitesContainer pqj() { }

	// RVA: 0x133C980 Offset: 0x133B980 VA: 0x18133C980
	public Transform pqk() { }

	// RVA: 0x133CA50 Offset: 0x133BA50 VA: 0x18133CA50
	public bool pql() { }

	// RVA: 0x133CA60 Offset: 0x133BA60 VA: 0x18133CA60
	public bool pqm() { }

	// RVA: 0x133CA80 Offset: 0x133BA80 VA: 0x18133CA80
	public bool pqn() { }

	// RVA: 0x133CAA0 Offset: 0x133BAA0 VA: 0x18133CAA0
	public WeaponDropController pqo() { }

	// RVA: 0x133CC30 Offset: 0x133BC30 VA: 0x18133CC30
	public BombSite pqp(cfs a) { }

	// RVA: 0x133CD60 Offset: 0x133BD60 VA: 0x18133CD60
	public StaticMapZone pqq(cfs a) { }

	// RVA: 0x133CF20 Offset: 0x133BF20 VA: 0x18133CF20
	public BombSitesContainer pqr(cfs a) { }

	// RVA: 0x133D050 Offset: 0x133C050 VA: 0x18133D050
	public bool pqs(cfs a) { }

	// RVA: 0x133D100 Offset: 0x133C100 VA: 0x18133D100
	private BombSite pqt(cfs a) { }

	// RVA: 0x133D170 Offset: 0x133C170 VA: 0x18133D170
	private BombSitesContainer pqu(cfs a) { }

	// RVA: -1 Offset: -1
	private static a pqv<a>(a[] a, Vector3 b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15AB270 Offset: 0x15AA270 VA: 0x1815AB270
	|-BombManager.pqv<object>
	*/

	// RVA: -1 Offset: -1
	private static b[] pqw<b>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15AB310 Offset: 0x15AA310 VA: 0x1815AB310
	|-BombManager.pqw<object>
	*/

	// RVA: 0x133D1E0 Offset: 0x133C1E0 VA: 0x18133D1E0
	private bool pqx(int a, out WeaponryController b) { }

	[NullableContext(1)]
	// RVA: 0x133D2B0 Offset: 0x133C2B0 VA: 0x18133D2B0
	protected void pqy(edq a, fjg b, short c, Vector3 d, Vector3 e) { }

	[NullableContext(1)]
	// RVA: 0x133D5B0 Offset: 0x133C5B0 VA: 0x18133D5B0
	protected void pqz(edq a, fjg b, short c, Vector3 d, Vector3 e) { }

	[NullableContext(1)]
	// RVA: 0x133D860 Offset: 0x133C860 VA: 0x18133D860
	protected void pra(edq a, fjg b, int c, Vector3 d, float e, bool f) { }

	[NullableContext(1)]
	// RVA: 0x133DB50 Offset: 0x133CB50 VA: 0x18133DB50
	protected void prb(edq a, fjg b, short c, short d, float e) { }

	[NullableContext(1)]
	// RVA: 0x133DD80 Offset: 0x133CD80 VA: 0x18133DD80
	protected void prc(edq a, fjg b, int c) { }

	[NullableContext(1)]
	// RVA: 0x133DF60 Offset: 0x133CF60 VA: 0x18133DF60
	protected void prd(edq a, fjg b, bool c, byte d, float e) { }

	[NullableContext(1)]
	// RVA: 0x13383D0 Offset: 0x13373D0 VA: 0x1813383D0 Slot: 6
	public override void pne(short a, fiu b, in efb info) { }

	// RVA: 0x133E190 Offset: 0x133D190 VA: 0x18133E190
	public static void pre() { }

	[AsyncStateMachine(typeof(BombManager.bdg))]
	// RVA: 0x133E340 Offset: 0x133D340 VA: 0x18133E340
	public static UniTask<BombManager> prf(CancellationToken a) { }

	[NullableContext(1)]
	// RVA: 0x133E430 Offset: 0x133D430 VA: 0x18133E430
	internal static BombManager prg(fiu a, short b, string c, eek d) { }

	[NullableContext(1)]
	// RVA: 0x133E450 Offset: 0x133D450 VA: 0x18133E450
	private static BombManager prh(short a, string b, eek c) { }

	// RVA: 0x1338750 Offset: 0x1337750 VA: 0x181338750 Slot: 4
	protected override void pnj() { }

	// RVA: 0x13387B0 Offset: 0x13377B0 VA: 0x1813387B0 Slot: 5
	protected override void pnk() { }

	// RVA: 0x1338390 Offset: 0x1337390 VA: 0x181338390
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x133E5E0 Offset: 0x133D5E0 VA: 0x18133E5E0
	private void pri() { }
}

	/* GenericInstMethod :
	|
	|-RVA: 0x15AB310 Offset: 0x15AA310 VA: 0x1815AB310
	|-BombManager.pqw<object>
	*/

// Namespace: 
public class dke : diq // TypeDefIndex: 6867
{
	// Fields
	private const float crmg = 4,25;
	private const float crmh = 48;
	private const float crmi = 1,5;
	private const float crmj = 16;
	private const float crmk = 0,35;
	private const float crml = 0,8;
	private const float crmm = 1,777;
	private const int crmn = 8;
	private const int crmo = 30;
	private const int crmp = 40;
	private const float crmq = 0,55;
	private const float crmr = 0,0035;
	private const float crms = 25;
	private const float crmt = 0,4;
	private const float crmu = 1,2;
	private const float crmv = 20;
	private const float crmw = 40;
	private const float crmx = 50;
	private const float crmy = 14;
	private const float crmz = 30;
	private const float crna = 40;
	private const float crnb = 12;
	private const float crnc = 2;
	private const float crnd = 3;
	private const int crne = 35;
	private const int crnf = 3;
	private const int crng = 80;
	private const int crnh = 40;
	private const bool crni = False;
	private const float crnj = 6;
	private const float crnk = 18;
	private const int crnl = 40;
	private const float crnm = 8;
	private const float crnn = 0,75;
	private const float crno = 1,4;
	private const float crnp = 3,5;
	private const float crnq = 12;
	private const float crnr = 5;
	private const float crns = 12;
	private const float crnt = 3;
	private const float crnu = 3;
	private const float crnv = 2;
	private const float crnw = 1;
	private const int crnx = 25;
	private const int crny = 85;
	private const float crnz = 3;
	private const float croa = 0,75;
	[CompilerGenerated]
	private cfs <crob>k__BackingField; // 0x168
	[CompilerGenerated]
	private dkf <croc>k__BackingField; // 0x169
	[CompilerGenerated]
	private dkb <crod>k__BackingField; // 0x16A
	[CompilerGenerated]
	private int <croe>k__BackingField; // 0x16C
	[CompilerGenerated]
	private dgf <crof>k__BackingField; // 0x170
	[CompilerGenerated]
	private dhc <crog>k__BackingField; // 0x178
	[CompilerGenerated]
	private dhl <croh>k__BackingField; // 0x180
	[CompilerGenerated]
	private dhg <croi>k__BackingField; // 0x188
	[CompilerGenerated]
	private dhe <croj>k__BackingField; // 0x190
	[CompilerGenerated]
	private dhf <crok>k__BackingField; // 0x198
	[CompilerGenerated]
	private dhq <crol>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private dhh <crom>k__BackingField; // 0x1A8
	private readonly DefuseController cron; // 0x1B0
	private readonly BotDefuseLogicSettings croo; // 0x1B8
	private BombManager crop; // 0x1C0
	private cfs croq; // 0x1C8
	private float cror; // 0x1CC
	private const float cros = 0,2;
	private readonly dgf crot; // 0x1D0
	private readonly dgf crou; // 0x1D8
	private readonly dgf crov; // 0x1E0
	private readonly dgf crow; // 0x1E8
	private readonly dgf crox; // 0x1F0
	private readonly dgf croy; // 0x1F8
	private bool croz; // 0x200
	private bool crpa; // 0x201
	private bool crpb; // 0x202
	private bool crpc; // 0x203
	private bool crpd; // 0x204
	private bool crpe; // 0x205
	private bool crpf; // 0x206
	private bool crpg; // 0x207
	private Nullable<Vector3> crph; // 0x208
	private float crpi; // 0x218
	private float crpj; // 0x21C
	private bool crpk; // 0x220
	private bool crpl; // 0x221

	// Properties
	public cfs crob { get; set; }
	public dkf croc { get; set; }
	public dkb crod { get; set; }
	public int croe { get; set; }
	public dgf crof { get; set; }
	public dhc crog { get; set; }
	public dhl croh { get; set; }
	public dhg croi { get; set; }
	public dhe croj { get; set; }
	public dhf crok { get; set; }
	public dhq crol { get; set; }
	public dhh crom { get; set; }
	public bool dsox { get; }
	public bool dsoy { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5E2D40 Offset: 0x5E1D40 VA: 0x1805E2D40
	public cfs bfzw() { }

	[CompilerGenerated]
	// RVA: 0x5E3230 Offset: 0x5E2230 VA: 0x1805E3230
	private void bfzx(cfs a) { }

	[CompilerGenerated]
	// RVA: 0x1277E90 Offset: 0x1276E90 VA: 0x181277E90
	public dkf bfzy() { }

	[CompilerGenerated]
	// RVA: 0x1277EA0 Offset: 0x1276EA0 VA: 0x181277EA0
	private void bfzz(dkf a) { }

	[CompilerGenerated]
	// RVA: 0x1277EB0 Offset: 0x1276EB0 VA: 0x181277EB0
	public dkb bgaa() { }

	[CompilerGenerated]
	// RVA: 0x1277EC0 Offset: 0x1276EC0 VA: 0x181277EC0
	private void bgab(dkb a) { }

	[CompilerGenerated]
	// RVA: 0x1277ED0 Offset: 0x1276ED0 VA: 0x181277ED0
	public int bgac() { }

	[CompilerGenerated]
	// RVA: 0x1277EE0 Offset: 0x1276EE0 VA: 0x181277EE0
	private void bgad(int a) { }

	[CompilerGenerated]
	// RVA: 0x5E2D50 Offset: 0x5E1D50 VA: 0x1805E2D50
	public dgf bgae() { }

	[CompilerGenerated]
	// RVA: 0x5E3240 Offset: 0x5E2240 VA: 0x1805E3240
	private void bgaf(dgf a) { }

	[CompilerGenerated]
	// RVA: 0x10F8C30 Offset: 0x10F7C30 VA: 0x1810F8C30
	public dhc bgag() { }

	[CompilerGenerated]
	// RVA: 0x1277EF0 Offset: 0x1276EF0 VA: 0x181277EF0
	private void bgah(dhc a) { }

	[CompilerGenerated]
	// RVA: 0x10F8C40 Offset: 0x10F7C40 VA: 0x1810F8C40
	public dhl bgai() { }

	[CompilerGenerated]
	// RVA: 0x1277F10 Offset: 0x1276F10 VA: 0x181277F10
	private void bgaj(dhl a) { }

	[CompilerGenerated]
	// RVA: 0x10F8C50 Offset: 0x10F7C50 VA: 0x1810F8C50
	public dhg bgak() { }

	[CompilerGenerated]
	// RVA: 0x1277F30 Offset: 0x1276F30 VA: 0x181277F30
	private void bgal(dhg a) { }

	[CompilerGenerated]
	// RVA: 0x10F8C60 Offset: 0x10F7C60 VA: 0x1810F8C60
	public dhe bgam() { }

	[CompilerGenerated]
	// RVA: 0x1277F50 Offset: 0x1276F50 VA: 0x181277F50
	private void bgan(dhe a) { }

	[CompilerGenerated]
	// RVA: 0x10F8C70 Offset: 0x10F7C70 VA: 0x1810F8C70
	public dhf bgao() { }

	[CompilerGenerated]
	// RVA: 0x1277F70 Offset: 0x1276F70 VA: 0x181277F70
	private void bgap(dhf a) { }

	[CompilerGenerated]
	// RVA: 0x1277F90 Offset: 0x1276F90 VA: 0x181277F90
	public dhq bgaq() { }

	[CompilerGenerated]
	// RVA: 0x1277FA0 Offset: 0x1276FA0 VA: 0x181277FA0
	private void bgar(dhq a) { }

	[CompilerGenerated]
	// RVA: 0x6828A0 Offset: 0x6818A0 VA: 0x1806828A0
	public dhh bgas() { }

	[CompilerGenerated]
	// RVA: 0x682B70 Offset: 0x681B70 VA: 0x180682B70
	private void bgat(dhh a) { }

	// RVA: 0x1274BD0 Offset: 0x1273BD0 VA: 0x181274BD0
	public void .ctor(DefuseController a) { }

	// RVA: 0x1276910 Offset: 0x1275910 VA: 0x181276910 Slot: 17
	public override void bfty() { }

	// RVA: 0x12755F0 Offset: 0x12745F0 VA: 0x1812755F0 Slot: 4
	public override void bfba(BotPlayerController a) { }

	// RVA: 0x1274DC0 Offset: 0x1273DC0 VA: 0x181274DC0 Slot: 5
	public override void bewv() { }

	// RVA: 0x1277D70 Offset: 0x1276D70 VA: 0x181277D70 Slot: 50
	public virtual void bfza() { }

	// RVA: 0x12766F0 Offset: 0x12756F0 VA: 0x1812766F0 Slot: 16
	public override void bftx(PlayerController a) { }

	// RVA: 0x1277C10 Offset: 0x1276C10 VA: 0x181277C10 Slot: 44
	public override void bfvt(in dlh ev) { }

	// RVA: 0x1277FC0 Offset: 0x1276FC0 VA: 0x181277FC0
	private bool bgau() { }

	// RVA: 0x1278150 Offset: 0x1277150 VA: 0x181278150
	private void bgav() { }

	// RVA: 0x12769F0 Offset: 0x12759F0 VA: 0x1812769F0 Slot: 18
	protected override void bftz() { }

	// RVA: 0x1276A20 Offset: 0x1275A20 VA: 0x181276A20 Slot: 19
	protected override int bfua() { }

	// RVA: 0x1276BC0 Offset: 0x1275BC0 VA: 0x181276BC0 Slot: 20
	protected override int bfub() { }

	// RVA: 0x12777D0 Offset: 0x12767D0 VA: 0x1812777D0 Slot: 41
	protected override int bfvm() { }

	// RVA: 0x1278210 Offset: 0x1277210 VA: 0x181278210 Slot: 51
	protected virtual void bgaw() { }

	// RVA: 0x1278310 Offset: 0x1277310 VA: 0x181278310
	protected void bgax() { }

	// RVA: 0x1278360 Offset: 0x1277360 VA: 0x181278360
	public bool bgay() { }

	// RVA: 0x1278420 Offset: 0x1277420 VA: 0x181278420
	public void bgaz(HashSet<dgz> a) { }

	// RVA: 0x1278670 Offset: 0x1277670 VA: 0x181278670
	public dgz bgba(Vector3 a, float b) { }

	// RVA: 0x1278820 Offset: 0x1277820 VA: 0x181278820
	public bool bgbb() { }

	// RVA: 0x12789F0 Offset: 0x12779F0 VA: 0x1812789F0
	private float bgbc() { }

	// RVA: 0x1278A90 Offset: 0x1277A90 VA: 0x181278A90
	public void bgbd(bool a = False) { }

	// RVA: 0x1277420 Offset: 0x1276420 VA: 0x181277420 Slot: 25
	protected override dgt bfuk() { }

	// RVA: 0x1275940 Offset: 0x1274940 VA: 0x181275940 Slot: 12
	protected override IEnumerable<dja> bftt() { }

	// RVA: 0x1276560 Offset: 0x1275560 VA: 0x181276560 Slot: 14
	protected override dja bftv() { }

	// RVA: 0x1278E40 Offset: 0x1277E40 VA: 0x181278E40
	public bool bgbe() { }

	// RVA: 0x1278F30 Offset: 0x1277F30 VA: 0x181278F30
	public void bgbf() { }

	// RVA: 0x1278F40 Offset: 0x1277F40 VA: 0x181278F40
	public bool bgbg() { }

	// RVA: 0x1278F70 Offset: 0x1277F70 VA: 0x181278F70
	public bool bgbh() { }

	// RVA: 0x1278FB0 Offset: 0x1277FB0 VA: 0x181278FB0
	public void bgbi() { }

	// RVA: 0x1278FF0 Offset: 0x1277FF0 VA: 0x181278FF0
	public bool bgbj() { }

	// RVA: 0x12764E0 Offset: 0x12754E0 VA: 0x1812764E0 Slot: 13
	protected override bool bftu() { }

	// RVA: 0x1276D40 Offset: 0x1275D40 VA: 0x181276D40 Slot: 22
	public override void bfug(dhv a) { }

	// RVA: 0x1279110 Offset: 0x1278110 VA: 0x181279110
	private bool bgbk() { }

	// RVA: 0x1279210 Offset: 0x1278210 VA: 0x181279210
	private void bgbl() { }

	// RVA: 0x1279490 Offset: 0x1278490 VA: 0x181279490
	private bool bgbm() { }

	// RVA: 0x1275830 Offset: 0x1274830 VA: 0x181275830 Slot: 8
	protected override dlr bftp() { }

	// RVA: 0x1277280 Offset: 0x1276280 VA: 0x181277280 Slot: 23
	public override bool bfuh() { }

	// RVA: 0x1279500 Offset: 0x1278500 VA: 0x181279500
	public bool bgbn() { }

	// RVA: 0x1277C70 Offset: 0x1276C70 VA: 0x181277C70 Slot: 45
	protected override bool bfvv() { }

	// RVA: 0x1277A00 Offset: 0x1276A00 VA: 0x181277A00 Slot: 42
	public override void bfvp(dmf a) { }

	// RVA: 0x12795C0 Offset: 0x12785C0 VA: 0x1812795C0 Slot: 52
	protected virtual bool bgbo(dmf a) { }

	// RVA: 0x12796E0 Offset: 0x12786E0 VA: 0x1812796E0 Slot: 53
	protected virtual bool bgbp(dmf a) { }

	[AsyncStateMachine(typeof(dke.dkd))]
	// RVA: 0x1279850 Offset: 0x1278850 VA: 0x181279850
	private UniTask bgbq(dmf a) { }

	// RVA: 0x1279940 Offset: 0x1278940 VA: 0x181279940
	protected void bgbr(dmf a) { }

	// RVA: 0x1279CD0 Offset: 0x1278CD0 VA: 0x181279CD0
	private void bgbs(dli a) { }

	// RVA: 0x127A090 Offset: 0x1279090 VA: 0x18127A090
	private void bgbt(dlg a) { }

	// RVA: 0x127A290 Offset: 0x1279290 VA: 0x18127A290
	private void bgbu(dlg a) { }

	// RVA: 0x127A350 Offset: 0x1279350 VA: 0x18127A350
	private bool bgbv(in dli ev) { }

	// RVA: 0x127A550 Offset: 0x1279550 VA: 0x18127A550
	private void bgbw(dkx a) { }

	// RVA: 0x127A7A0 Offset: 0x12797A0 VA: 0x18127A7A0
	private void bgbx() { }

	// RVA: 0x127A990 Offset: 0x1279990 VA: 0x18127A990
	private void bgby(dla a) { }

	// RVA: 0x127AB60 Offset: 0x1279B60 VA: 0x18127AB60
	private void bgbz() { }

	// RVA: 0x127AC40 Offset: 0x1279C40 VA: 0x18127AC40 Slot: 54
	protected virtual void bgca(dld a) { }

	// RVA: 0x127ACC0 Offset: 0x1279CC0 VA: 0x18127ACC0
	public void bgcb() { }

	// RVA: 0x127AD70 Offset: 0x1279D70 VA: 0x18127AD70
	public cfs bgcc() { }

	// RVA: 0x127AE00 Offset: 0x1279E00 VA: 0x18127AE00
	private cfs bgcd() { }

	// RVA: 0x127B180 Offset: 0x127A180 VA: 0x18127B180
	private bool bgce(cfs a) { }

	// RVA: 0x127B2B0 Offset: 0x127A2B0 VA: 0x18127B2B0
	private cfs bgcf() { }

	// RVA: 0x127B450 Offset: 0x127A450 VA: 0x18127B450
	private bool bgcg(out float a) { }

	// RVA: 0x127B570 Offset: 0x127A570 VA: 0x18127B570
	public cfs bgch() { }

	// RVA: 0x1274F30 Offset: 0x1273F30 VA: 0x181274F30 Slot: 26
	public override void beww(float a) { }

	// RVA: 0x127B870 Offset: 0x127A870 VA: 0x18127B870
	private void bgci() { }

	// RVA: 0x127BCF0 Offset: 0x127ACF0 VA: 0x18127BCF0
	private void bgcj(Vector3 a) { }

	// RVA: 0x127BD90 Offset: 0x127AD90 VA: 0x18127BD90
	private void bgck() { }

	// RVA: 0x127BDD0 Offset: 0x127ADD0 VA: 0x18127BDD0
	private static bool bgcl(cjp a, Vector3 b, out Vector3 c) { }

	// RVA: 0x127BE90 Offset: 0x127AE90 VA: 0x18127BE90 Slot: 55
	protected virtual bool bgcm(Vector3 a) { }

	// RVA: 0x1277690 Offset: 0x1276690 VA: 0x181277690 Slot: 27
	public override void bfuu(bool a) { }

	// RVA: 0x127BF40 Offset: 0x127AF40 VA: 0x18127BF40
	private void bgcn() { }

	// RVA: 0x127C230 Offset: 0x127B230 VA: 0x18127C230
	private bool bgco() { }

	// RVA: 0x127C2E0 Offset: 0x127B2E0 VA: 0x18127C2E0
	private void bgcp(dlc a) { }

	// RVA: 0x127C340 Offset: 0x127B340 VA: 0x18127C340
	private void bgcq(float a) { }

	// RVA: 0x127C420 Offset: 0x127B420 VA: 0x18127C420
	private void bgcr() { }

	// RVA: 0x127C550 Offset: 0x127B550 VA: 0x18127C550
	private void bgcs(in dlh ev) { }

	// RVA: 0x127C7F0 Offset: 0x127B7F0 VA: 0x18127C7F0
	private void bgct() { }

	// RVA: 0x127C8F0 Offset: 0x127B8F0 VA: 0x18127C8F0
	private void bgcu() { }

	// RVA: 0x61E700 Offset: 0x61D700 VA: 0x18061E700
	private bool bgcv(in dlh ev) { }

	// RVA: 0x12776E0 Offset: 0x12766E0 VA: 0x1812776E0 Slot: 29
	public override void bfuw(Vector3 a) { }

	// RVA: 0x127CC10 Offset: 0x127BC10 VA: 0x18127CC10
	private bool bgcw() { }

	// RVA: 0x127CD40 Offset: 0x127BD40 VA: 0x18127CD40
	private void bgcx() { }

	// RVA: 0x1277D00 Offset: 0x1276D00 VA: 0x181277D00 Slot: 46
	public override void bfwb(in dle ev) { }

	// RVA: 0x1276690 Offset: 0x1275690 VA: 0x181276690 Slot: 15
	public override void bftw(dlz a) { }

	// RVA: 0x127CE40 Offset: 0x127BE40 VA: 0x18127CE40
	private void bgcy() { }

	// RVA: 0x127D510 Offset: 0x127C510 VA: 0x18127D510
	private bool bgcz() { }

	// RVA: 0x127D670 Offset: 0x127C670 VA: 0x18127D670
	private bool bgda() { }

	// RVA: 0x127D860 Offset: 0x127C860 VA: 0x18127D860
	private bool bgdb() { }

	// RVA: 0x127D970 Offset: 0x127C970 VA: 0x18127D970
	private bool bgdc() { }

	// RVA: 0x127DA60 Offset: 0x127CA60 VA: 0x18127DA60
	private float bgdd(Vector3 a, float b) { }

	// RVA: 0x127DC60 Offset: 0x127CC60 VA: 0x18127DC60 Slot: 56
	protected virtual bool bgde() { }

	// RVA: 0x127DD10 Offset: 0x127CD10 VA: 0x18127DD10
	private void bgdf() { }

	// RVA: 0x127DE10 Offset: 0x127CE10 VA: 0x18127DE10
	private bool bgdg() { }

	// RVA: 0x127E0B0 Offset: 0x127D0B0 VA: 0x18127E0B0
	private float bgdh() { }

	// RVA: 0x12754A0 Offset: 0x12744A0 VA: 0x1812754A0 Slot: 36
	protected override bool bewx() { }

	// RVA: 0x12777B0 Offset: 0x12767B0 VA: 0x1812777B0 Slot: 37
	protected override bool bfve() { }

	// RVA: 0x1277390 Offset: 0x1276390 VA: 0x181277390 Slot: 24
	protected override Nullable<float> bfuj() { }

	// RVA: 0x1277740 Offset: 0x1276740 VA: 0x181277740 Slot: 34
	public override void bfvc(dhx a) { }

	// RVA: 0x127E210 Offset: 0x127D210 VA: 0x18127E210 Slot: 57
	public virtual bool bgdi() { }

	// RVA: 0x1277D20 Offset: 0x1276D20 VA: 0x181277D20 Slot: 49
	public override bool bfwe() { }

	[CompilerGenerated]
	// RVA: 0x127E2B0 Offset: 0x127D2B0 VA: 0x18127E2B0
	private bool bgdj() { }
}


	/* GenericInstMethod :
	|
	|-RVA: 0x25DBFF0 Offset: 0x25DAFF0 VA: 0x1825DBFF0
	|-fan<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.bkhp
	|
	|-RVA: 0x25DBC00 Offset: 0x25DAC00 VA: 0x1825DBC00
	|-fan<ArmsRaceRpcHelper.bdf, object>.bkhp
	|-fan<BombManager.bdg, object>.bkhp
	|-fan<ChatManager.bdj, object>.bkhp
	|-fan<GameManager.cml, object>.bkhp
	|-fan<GameRpcHelper.bdk, object>.bkhp
	|-fan<LevelResourceManager.cfk, object>.bkhp
	|-fan<LevelResourceManager.cfl, object>.bkhp
	|-fan<LevelResourceManager.cfm, object>.bkhp
	|-fan<NextLevelVoteRpcHelper.bdq, object>.bkhp
	|-fan<RadarManager.bdr, object>.bkhp
	|-fan<WaitForNextGameRpcHelper.bds, object>.bkhp
	|
	|-RVA: 0x25DBF00 Offset: 0x25DAF00 VA: 0x1825DBF00
	|-fan<BotCreator.dlp, object>.bkhp
	|
	|-RVA: 0x25DBDE0 Offset: 0x25DADE0 VA: 0x1825DBDE0
	|-fan<GameController.clt, bool>.bkhp
	|-fan<GameController.clu, bool>.bkhp
	|-fan<byh.byg, bool>.bkhp
	|
	|-RVA: 0x25DBEA0 Offset: 0x25DAEA0 VA: 0x1825DBEA0
	|-fan<GrenadeManager.bdm, object>.bkhp
	|-fan<WeaponDropManager.bdt, object>.bkhp
	|
	|-RVA: 0x25DBD80 Offset: 0x25DAD80 VA: 0x1825DBD80
	|-fan<etl.esz, bool>.bkhp
	|
	|-RVA: 0x25DBD50 Offset: 0x25DAD50 VA: 0x1825DBD50
	|-fan<frx.fqj, double>.bkhp
	|-fan<frx.fql, double>.bkhp
	|-fan<frx.fqz, double>.bkhp
	|
	|-RVA: 0x25DBDB0 Offset: 0x25DADB0 VA: 0x1825DBDB0
	|-fan<frx.fqn, Decimal>.bkhp
	|
	|-RVA: 0x25DBCF0 Offset: 0x25DACF0 VA: 0x1825DBCF0
	|-fan<frx.fqp, Nullable<double>>.bkhp
	|-fan<ggl.gfj, Nullable<double>>.bkhp
	|
	|-RVA: 0x25DBC60 Offset: 0x25DAC60 VA: 0x1825DBC60
	|-fan<frx.fqr, Nullable<double>>.bkhp
	|-fan<frx.fqv, Nullable<double>>.bkhp
	|
	|-RVA: 0x25DC070 Offset: 0x25DB070 VA: 0x1825DC070
	|-fan<frx.fqt, Nullable<float>>.bkhp
	|-fan<fzl.fyf, Nullable<float>>.bkhp
	|-fan<gbi.gac, Nullable<float>>.bkhp
	|
	|-RVA: 0x25DBF30 Offset: 0x25DAF30 VA: 0x1825DBF30
	|-fan<frx.fqx, Nullable<Decimal>>.bkhp
	|
	|-RVA: 0x25DBE10 Offset: 0x25DAE10 VA: 0x1825DBE10
	|-fan<frx.frb, float>.bkhp
	|
	|-RVA: 0x25DBD20 Offset: 0x25DAD20 VA: 0x1825DBD20
	|-fan<fzl.fxv, float>.bkhp
	|-fan<gbi.fzs, float>.bkhp
	|-fan<ggl.gfp, float>.bkhp
	|
	|-RVA: 0x25DBC90 Offset: 0x25DAC90 VA: 0x1825DBC90
	|-fan<fzl.fxx, double>.bkhp
	|-fan<gbi.fzu, double>.bkhp
	|-fan<ggl.gez, double>.bkhp
	|
	|-RVA: 0x25DBBD0 Offset: 0x25DABD0 VA: 0x1825DBBD0
	|-fan<fzl.fxz, Decimal>.bkhp
	|-fan<gbi.fzw, Decimal>.bkhp
	|-fan<ggl.gfb, Decimal>.bkhp
	|
	|-RVA: 0x25DBC30 Offset: 0x25DAC30 VA: 0x1825DBC30
	|-fan<fzl.fyb, Nullable<int>>.bkhp
	|-fan<gbi.fzy, Nullable<int>>.bkhp
	|
	|-RVA: 0x25DBE40 Offset: 0x25DAE40 VA: 0x1825DBE40
	|-fan<fzl.fyd, Nullable<long>>.bkhp
	|-fan<gbi.gaa, Nullable<long>>.bkhp
	|
	|-RVA: 0x25DBED0 Offset: 0x25DAED0 VA: 0x1825DBED0
	|-fan<fzl.fyh, Nullable<double>>.bkhp
	|-fan<gbi.gae, Nullable<double>>.bkhp
	|
	|-RVA: 0x25DBE70 Offset: 0x25DAE70 VA: 0x1825DBE70
	|-fan<fzl.fyj, int>.bkhp
	|-fan<gbi.gag, int>.bkhp
	|-fan<ggl.gex, int>.bkhp
	|
	|-RVA: 0x25DBF60 Offset: 0x25DAF60 VA: 0x1825DBF60
	|-fan<fzl.fyk, Nullable<Decimal>>.bkhp
	|-fan<gbi.gah, Nullable<Decimal>>.bkhp
	|
	|-RVA: 0x25DC0A0 Offset: 0x25DB0A0 VA: 0x1825DC0A0
	|-fan<fzl.fyn, long>.bkhp
	|-fan<gbi.gak, long>.bkhp
	|-fan<ggl.gfn, long>.bkhp
	|
	|-RVA: 0x25DBCC0 Offset: 0x25DACC0 VA: 0x1825DBCC0
	|-fan<ggl.gfd, Nullable<int>>.bkhp
	|
	|-RVA: 0x25DC0D0 Offset: 0x25DB0D0 VA: 0x1825DC0D0
	|-fan<ggl.gff, Nullable<long>>.bkhp
	|
	|-RVA: 0x25DBF90 Offset: 0x25DAF90 VA: 0x1825DBF90
	|-fan<ggl.gfh, Nullable<float>>.bkhp
	|
	|-RVA: 0x25DBFC0 Offset: 0x25DAFC0 VA: 0x1825DBFC0
	|-fan<ggl.gfl, Nullable<Decimal>>.bkhp
	*/
}
