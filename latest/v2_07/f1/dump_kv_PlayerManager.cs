	Строка  147253: public sealed class PlayerManager.zj : MulticastDelegate // TypeDefIndex: 3735
	Строка  147271: public class PlayerManager : LazySingleton<PlayerManager> // TypeDefIndex: 3736
	Строка  147284: 	private PlayerManager.zj cfoj; // 0x58
	Строка  147286: 	private PlayerManager.zj cfok; // 0x60
	Строка  147321: 	public void off(PlayerManager.zj a) { }
	Строка  147325: 	public void ofg(PlayerManager.zj a) { }
	Строка  147329: 	public void ofh(PlayerManager.zj a) { }
	Строка  147333: 	public void ofi(PlayerManager.zj a) { }
	Строка  214780: 	private PlayerManager cmkf; // 0x28
	Строка  217620: 	private readonly PlayerManager cmqr; // 0x20
	Строка  217625: 	public void .ctor(PlayerManager a) { }
	Строка  240423: 	private readonly PlayerManager cowy; // 0x18
	Строка  240432: 	public void .ctor(Camera a, PlayerManager b, EspSettings c) { }

// CLASSES WITH PlayerManager

public class cvh // TypeDefIndex: 6150
{
	// Fields
	private const float cowt = 0,075;
	private const float cowu = 99;
	private const float cowv = 15;
	private const float coww = 80;
	private readonly Camera cowx; // 0x10
	private readonly PlayerManager cowy; // 0x18
	private readonly EspSettings cowz; // 0x20
	private AimEspCheatParameters coxa; // 0x28
	private float coxb; // 0x30
	private bool coxc; // 0x34

	// Methods

	// RVA: 0x11D2360 Offset: 0x11D1360 VA: 0x1811D2360
	public void .ctor(Camera a, PlayerManager b, EspSettings c) { }

	// RVA: 0x5B6270 Offset: 0x5B5270 VA: 0x1805B6270
	public void bcfw(AimEspCheatParameters a) { }

	// RVA: 0x11D24D0 Offset: 0x11D14D0 VA: 0x1811D24D0
	public void bcfx() { }

	// RVA: 0x11D2810 Offset: 0x11D1810 VA: 0x1811D2810
	public void bcfy() { }

	// RVA: 0x11D2F70 Offset: 0x11D1F70 VA: 0x1811D2F70
	private static void bcfz(Transform a, Quaternion b) { }

	// RVA: 0x11D2FF0 Offset: 0x11D1FF0 VA: 0x1811D2FF0
	private void bcga(PlayerController a) { }

	// RVA: 0x11D34B0 Offset: 0x11D24B0 VA: 0x1811D34B0
	private void bcgb(PlayerController a, Color b) { }

	// RVA: 0x11D3840 Offset: 0x11D2840 VA: 0x1811D3840
	private void bcgc(Transform a, Transform b, Color c, float d) { }

	// RVA: 0x11D3A40 Offset: 0x11D2A40 VA: 0x1811D3A40
	private Color bcgd(edq a) { }

	// RVA: 0x11D3BD0 Offset: 0x11D2BD0 VA: 0x1811D3BD0
	private Color bcge() { }
}

// Namespace: Chillow.StandChillow.Player
public class PlayerManager : LazySingleton<PlayerManager> // TypeDefIndex: 3736
{
	// Fields
	private static readonly dgb cfob; // 0x0
	private int cfoc; // 0x20
	private readonly Dictionary<int, PlayerController> cfod; // 0x28
	private readonly Dictionary<Material, Material> cfoe; // 0x30
	private readonly HashSet<ze> cfof; // 0x38
	[CompilerGenerated]
	private PlayerController <cfog>k__BackingField; // 0x40
	private Dictionary<Team, zm> cfoh; // 0x48
	private Dictionary<string, PlayerController> cfoi; // 0x50
	[CompilerGenerated]
	private PlayerManager.zj cfoj; // 0x58
	[CompilerGenerated]
	private PlayerManager.zj cfok; // 0x60
	[CompilerGenerated]
	private Action<PlayerController, PlayerSnapshot> cfol; // 0x68

	// Properties
	public Dictionary<int, PlayerController> dpkx { get; }
	public PlayerController cfog { get; set; }
	public PlayerController dpky { get; }
	public IReadOnlyDictionary<Team, zm> dpkz { get; }
	public IReadOnlyDictionary<string, PlayerController> dpla { get; }

	// Methods

	// RVA: 0x5B6260 Offset: 0x5B5260 VA: 0x1805B6260
	public Dictionary<int, PlayerController> oez() { }

	[CompilerGenerated]
	// RVA: 0x5FF100 Offset: 0x5FE100 VA: 0x1805FF100
	public PlayerController ofa() { }

	[CompilerGenerated]
	// RVA: 0x5FF1B0 Offset: 0x5FE1B0 VA: 0x1805FF1B0
	private void ofb(PlayerController a) { }

	// RVA: 0x12EF4F0 Offset: 0x12EE4F0 VA: 0x1812EF4F0
	public PlayerController ofc() { }

	// RVA: 0x694C80 Offset: 0x693C80 VA: 0x180694C80
	public IReadOnlyDictionary<Team, zm> ofd() { }

	// RVA: 0x66CD00 Offset: 0x66BD00 VA: 0x18066CD00
	public IReadOnlyDictionary<string, PlayerController> ofe() { }

	[CompilerGenerated]
	// RVA: 0x12EF560 Offset: 0x12EE560 VA: 0x1812EF560
	public void off(PlayerManager.zj a) { }

	[CompilerGenerated]
	// RVA: 0x12EF600 Offset: 0x12EE600 VA: 0x1812EF600
	public void ofg(PlayerManager.zj a) { }

	[CompilerGenerated]
	// RVA: 0x12EF6A0 Offset: 0x12EE6A0 VA: 0x1812EF6A0
	public void ofh(PlayerManager.zj a) { }

	[CompilerGenerated]
	// RVA: 0x12EF740 Offset: 0x12EE740 VA: 0x1812EF740
	public void ofi(PlayerManager.zj a) { }

	[CompilerGenerated]
	// RVA: 0x12EF7E0 Offset: 0x12EE7E0 VA: 0x1812EF7E0
	public void ofj(Action<PlayerController, PlayerSnapshot> a) { }

	[CompilerGenerated]
	// RVA: 0x12EF890 Offset: 0x12EE890 VA: 0x1812EF890
	public void ofk(Action<PlayerController, PlayerSnapshot> a) { }

	// RVA: 0x12EEE80 Offset: 0x12EDE80 VA: 0x1812EEE80
	private void Awake() { }

	// RVA: 0x12EF940 Offset: 0x12EE940 VA: 0x1812EF940
	public void ofl(Team a, int b, Type[] c, string d = "player/player") { }

	// RVA: 0x12EFAB0 Offset: 0x12EEAB0 VA: 0x1812EFAB0
	public void ofm(ze a) { }

	// RVA: 0x12EFB10 Offset: 0x12EEB10 VA: 0x1812EFB10
	public void ofn(ze a) { }

	// RVA: 0x12EFB70 Offset: 0x12EEB70 VA: 0x1812EFB70
	private void ofo() { }

	// RVA: 0x12EFD10 Offset: 0x12EED10 VA: 0x1812EFD10
	private void ofp() { }

	// RVA: 0x12EFEC0 Offset: 0x12EEEC0 VA: 0x1812EFEC0
	public void ofq(edq a, Team b, Vector3 c, Quaternion d, int e = 100, int f = 100, bool g = True, bool h = False, float i = 3,4028235E+38) { }

	// RVA: 0x12F0150 Offset: 0x12EF150 VA: 0x1812F0150
	public void ofr(PlayerController a) { }

	// RVA: 0x12F0320 Offset: 0x12EF320 VA: 0x1812F0320
	public void ofs(PlayerController a) { }

	// RVA: 0x12F0350 Offset: 0x12EF350 VA: 0x1812F0350
	public void oft(PlayerController a) { }

	// RVA: 0x12F0530 Offset: 0x12EF530 VA: 0x1812F0530
	private void ofu(PlayerController a) { }

	// RVA: 0x12F06A0 Offset: 0x12EF6A0 VA: 0x1812F06A0
	internal void ofv(PlayerController a) { }

	// RVA: 0x12F0930 Offset: 0x12EF930 VA: 0x1812F0930
	internal void ofw(PlayerController a, int b) { }

	// RVA: 0x12F0AE0 Offset: 0x12EFAE0 VA: 0x1812F0AE0
	public void ofx(PlayerController a, PlayerSnapshot b) { }

	// RVA: 0x12F0B00 Offset: 0x12EFB00 VA: 0x1812F0B00
	public PlayerController ofy(int a) { }

	// RVA: 0x12F0B80 Offset: 0x12EFB80 VA: 0x1812F0B80
	public bool ofz(int a) { }

	// RVA: 0x12F0BE0 Offset: 0x12EFBE0 VA: 0x1812F0BE0
	public PlayerController oga(ber a, string b, Vector3 c, Quaternion d, string e) { }

	// RVA: 0x12F0E60 Offset: 0x12EFE60 VA: 0x1812F0E60
	public void ogb(PlayerController a) { }

	// RVA: 0x12F0FD0 Offset: 0x12EFFD0 VA: 0x1812F0FD0
	private zm ogc(Team a) { }

	// RVA: 0x12F1110 Offset: 0x12F0110 VA: 0x1812F1110
	public string ogd(Team a) { }

	// RVA: 0x12F1150 Offset: 0x12F0150 VA: 0x1812F1150
	public Material oge(Material material, Material untouchableMaterial) { }

	// RVA: 0x12EEF80 Offset: 0x12EDF80 VA: 0x1812EEF80
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x12EF000 Offset: 0x12EE000 VA: 0x1812EF000
	private void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x12EF080 Offset: 0x12EE080 VA: 0x1812EF080 Slot: 4
	protected override void OnDestroy() { }

	// RVA: 0x12EF340 Offset: 0x12EE340 VA: 0x1812EF340
	public void .ctor() { }

	// RVA: 0x12EF2D0 Offset: 0x12EE2D0 VA: 0x1812EF2D0
	private static void .cctor() { }
}

// Namespace: 
public class cvh // TypeDefIndex: 6150
{
	// Fields
	private const float cowt = 0,075;
	private const float cowu = 99;
	private const float cowv = 15;
	private const float coww = 80;
	private readonly Camera cowx; // 0x10
	private readonly PlayerManager cowy; // 0x18
	private readonly EspSettings cowz; // 0x20
	private AimEspCheatParameters coxa; // 0x28
	private float coxb; // 0x30
	private bool coxc; // 0x34

	// Methods

	// RVA: 0x11D2360 Offset: 0x11D1360 VA: 0x1811D2360
	public void .ctor(Camera a, PlayerManager b, EspSettings c) { }

	// RVA: 0x5B6270 Offset: 0x5B5270 VA: 0x1805B6270
	public void bcfw(AimEspCheatParameters a) { }

	// RVA: 0x11D24D0 Offset: 0x11D14D0 VA: 0x1811D24D0
	public void bcfx() { }

	// RVA: 0x11D2810 Offset: 0x11D1810 VA: 0x1811D2810
	public void bcfy() { }

	// RVA: 0x11D2F70 Offset: 0x11D1F70 VA: 0x1811D2F70
	private static void bcfz(Transform a, Quaternion b) { }

	// RVA: 0x11D2FF0 Offset: 0x11D1FF0 VA: 0x1811D2FF0
	private void bcga(PlayerController a) { }

	// RVA: 0x11D34B0 Offset: 0x11D24B0 VA: 0x1811D34B0
	private void bcgb(PlayerController a, Color b) { }

	// RVA: 0x11D3840 Offset: 0x11D2840 VA: 0x1811D3840
	private void bcgc(Transform a, Transform b, Color c, float d) { }

	// RVA: 0x11D3A40 Offset: 0x11D2A40 VA: 0x1811D3A40
	private Color bcgd(edq a) { }

	// RVA: 0x11D3BD0 Offset: 0x11D2BD0 VA: 0x1811D3BD0
	private Color bcge() { }
}

