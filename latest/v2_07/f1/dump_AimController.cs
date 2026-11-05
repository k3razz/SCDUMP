Строка  146523: [RequireComponent(typeof(AimController))]
	Строка  146570: 	private AimController <cflw>k__BackingField; // 0xD0
	Строка  146630: 	public AimController cflw { get; set; }
	Строка  146712: 	public AimController oad() { }
	Строка  146716: 	private void oae(AimController a) { }
	Строка  153431: private enum AimController.bcb // TypeDefIndex: 3875
	Строка  153435: 	public const AimController.bcb NotSet = 0;
	Строка  153436: 	public const AimController.bcb AimingControl = 1;
	Строка  153437: 	public const AimController.bcb FPSControl = 2;
	Строка  153438: 	public const AimController.bcb TPSControl = 3;
	Строка  153442: public enum AimController.bcc // TypeDefIndex: 3876
	Строка  153446: 	public const AimController.bcc NotStated = 0;
	Строка  153447: 	public const AimController.bcc Translation = 1;
	Строка  153451: public enum AimController.bcd // TypeDefIndex: 3877
	Строка  153455: 	public const AimController.bcd NotStated = 0;
	Строка  153456: 	public const AimController.bcd Crouch = 1;
	Строка  153457: 	public const AimController.bcd Stand = 2;
	Строка  153458: 	public const AimController.bcd FinishedCrouch = 3;
	Строка  153459: 	public const AimController.bcd FinishedStand = 4;
	Строка  153464: public class AimController.AimingParameters.GeneralData // TypeDefIndex: 3878
	Строка  153479: public class AimController.AimingParameters // TypeDefIndex: 3879
	Строка  153495: 	public AimController.AimingParameters.GeneralData generalData; // 0x78
	Строка  153509: public class AimController.bce // TypeDefIndex: 3880
	Строка  153523: public class AimController.TuningParams // TypeDefIndex: 3881
	Строка  153539: public class AimController : Controller, zc<AimSnapshot, bca>, zu, bat, bdc, bbd // TypeDefIndex: 3882
	Строка  153549: 	public AimController.AimingParameters aimingParameters; // 0x88
	Строка  153554: 	public AimController.bce interpolatorsBunch; // 0xA8
	Строка  153555: 	public AimController.TuningParams tuningParams; // 0xB0
	Строка  153570: 	private readonly dgj<AimController.bcc> cgjm; // 0x130
	Строка  153571: 	private readonly dgj<AimController.bcd> cgjn; // 0x138
	Строка  153579: 	private AimController.bcb cgjv; // 0x178
	Строка  271357: 	private AimController csdo; // 0xD0
// Namespace: Chillow.StandChillow.Player.Aim
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(MecanimController))]
[RequireComponent(typeof(MovementController))]
public class AimController : Controller, zc<AimSnapshot, bca>, zu, bat, bdc, bbd // TypeDefIndex: 3882
{
	// Fields
	private bdd cgiy; // 0x58
	public float sensitivityY; // 0x5C
	public Transform spineDirector; // 0x60
	public Transform FPSCamera; // 0x68
	private Transform cgiz; // 0x70
	public Transform camTransform; // 0x78
	public AimingData aimingData; // 0x80
	public AimController.AimingParameters aimingParameters; // 0x88
	public float sensitivityX; // 0x90
	public float minimumX; // 0x94
	public float maximumX; // 0x98
	public GameObject FPSP_go; // 0xA0
	public AimController.bce interpolatorsBunch; // 0xA8
	public AimController.TuningParams tuningParams; // 0xB0
	[SerializeField]
	private Vector3 _headDirectiveAngles; // 0xB8
	private PlayerController cgja; // 0xC8
	private MovementController cgjb; // 0xD0
	private Transform cgjc; // 0xD8
	private MecanimController cgjd; // 0xE0
	private Transform cgje; // 0xE8
	private Transform cgjf; // 0xF0
	private Transform cgjg; // 0xF8
	private Transform cgjh; // 0x100
	private bool cgji; // 0x108
	private bca cgjj; // 0x110
	private readonly dgj<zt> cgjk; // 0x118
	private Vector3 cgjl; // 0x120
	private readonly dgj<AimController.bcc> cgjm; // 0x130
	private readonly dgj<AimController.bcd> cgjn; // 0x138
	private readonly TransformTR cgjo; // 0x140
	private readonly TransformTR cgjp; // 0x148
	private readonly TransformTR cgjq; // 0x150
	private readonly TransformTR cgjr; // 0x158
	private readonly TransformTR cgjs; // 0x160
	private readonly TransformTR cgjt; // 0x168
	private readonly AimSnapshot cgju; // 0x170
	private AimController.bcb cgjv; // 0x178
	private Transform cgjw; // 0x180
	private Transform cgjx; // 0x188
	private zb cgjy; // 0x190
	private float cgjz; // 0x198
	private float cgka; // 0x19C
	private bci[] cgkb; // 0x1A0
	[CompilerGenerated]
	private float <cgkc>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private float <cgkd>k__BackingField; // 0x1AC

	// Properties
	public float cgkc { get; set; }
	public float cgkd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1333B60 Offset: 0x1332B60 VA: 0x181333B60
	public float pgr() { }

	[CompilerGenerated]
	// RVA: 0x1333B70 Offset: 0x1332B70 VA: 0x181333B70
	private void pgs(float a) { }

	[CompilerGenerated]
	// RVA: 0x1333B80 Offset: 0x1332B80 VA: 0x181333B80
	public float pgt() { }

	[CompilerGenerated]
	// RVA: 0x1333B90 Offset: 0x1332B90 VA: 0x181333B90
	private void pgu(float a) { }

	// RVA: 0x1332680 Offset: 0x1331680 VA: 0x181332680 Slot: 5
	public override void nxw() { }

	// RVA: 0x1333BA0 Offset: 0x1332BA0 VA: 0x181333BA0
	private void pgv() { }

	// RVA: 0x1332D50 Offset: 0x1331D50 VA: 0x181332D50 Slot: 6
	public override void nxx(Team a) { }

	// RVA: 0x1333CA0 Offset: 0x1332CA0 VA: 0x181333CA0
	public void pgw(Vector3 a) { }

	// RVA: 0x1333CF0 Offset: 0x1332CF0 VA: 0x181333CF0
	public Vector3 pgx() { }

	// RVA: 0x1332F60 Offset: 0x1331F60 VA: 0x181332F60 Slot: 8
	public override void nxz() { }

	// RVA: 0x1332F80 Offset: 0x1331F80 VA: 0x181332F80 Slot: 12
	public override void nye(BipedMap a) { }

	// RVA: 0x1332FF0 Offset: 0x1331FF0 VA: 0x181332FF0 Slot: 13
	public override void nyf(BipedMap a) { }

	// RVA: 0x1333200 Offset: 0x1332200 VA: 0x181333200 Slot: 14
	public override void nyg(zt a) { }

	// RVA: 0x1333470 Offset: 0x1332470 VA: 0x181333470 Slot: 17
	public void nyx(bca a, float b, float c) { }

	// RVA: 0x1333D30 Offset: 0x1332D30 VA: 0x181333D30
	private void pgy() { }

	// RVA: 0x1333270 Offset: 0x1332270 VA: 0x181333270 Slot: 15
	public void nyv(AimSnapshot a) { }

	// RVA: 0x1333370 Offset: 0x1332370 VA: 0x181333370 Slot: 16
	public AimSnapshot nyw() { }

	// RVA: 0x1332660 Offset: 0x1331660 VA: 0x181332660 Slot: 26
	public void nwx() { }

	// RVA: 0x1332670 Offset: 0x1331670 VA: 0x181332670 Slot: 24
	public void nwy() { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0 Slot: 25
	public void nwz() { }

	// RVA: 0x13338A0 Offset: 0x13328A0 VA: 0x1813338A0 Slot: 27
	public void ojx() { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0 Slot: 28
	public void ojy() { }

	// RVA: 0x1333DC0 Offset: 0x1332DC0 VA: 0x181333DC0
	public void pgz() { }

	// RVA: 0x1333E20 Offset: 0x1332E20 VA: 0x181333E20
	private void pha() { }

	// RVA: 0x1333FB0 Offset: 0x1332FB0 VA: 0x181333FB0
	private void phb() { }

	// RVA: 0x1334050 Offset: 0x1333050 VA: 0x181334050
	private void phc() { }

	// RVA: 0x1334830 Offset: 0x1333830 VA: 0x181334830
	public bool phd(float a) { }

	// RVA: 0x1334850 Offset: 0x1333850 VA: 0x181334850
	private void phe() { }

	// RVA: 0x1334EF0 Offset: 0x1333EF0 VA: 0x181334EF0
	private void phf() { }

	// RVA: 0x1335010 Offset: 0x1334010 VA: 0x181335010
	private void phg() { }

	// RVA: 0x1335120 Offset: 0x1334120 VA: 0x181335120
	private void phh() { }

	// RVA: 0x13360C0 Offset: 0x13350C0 VA: 0x1813360C0
	public bool phi(float a) { }

	// RVA: 0x13360E0 Offset: 0x13350E0 VA: 0x1813360E0
	private void phj() { }

	// RVA: 0x1336130 Offset: 0x1335130 VA: 0x181336130
	private void phk() { }

	// RVA: 0x1336490 Offset: 0x1335490 VA: 0x181336490
	private void phl() { }

	// RVA: 0x1332260 Offset: 0x1331260 VA: 0x181332260
	public void .ctor() { }

	// RVA: 0x1333940 Offset: 0x1332940 VA: 0x181333940 Slot: 19
	public void oov() { }

	// RVA: 0x1333980 Offset: 0x1332980 VA: 0x181333980 Slot: 20
	public void oox() { }

	// RVA: 0x13339F0 Offset: 0x13329F0 VA: 0x1813339F0 Slot: 21
	public void ooy(float a) { }

	// RVA: 0x1333A80 Offset: 0x1332A80 VA: 0x181333A80 Slot: 22
	public void ooz() { }

	// RVA: 0x1333AF0 Offset: 0x1332AF0 VA: 0x181333AF0 Slot: 23
	public void opa() { }

	// RVA: 0x13334F0 Offset: 0x13324F0 VA: 0x1813334F0 Slot: 18
	public void oip(WeaponController a) { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0
	public void phm(WeaponController a) { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0
	public void phn(WeaponController a) { }
}

// Namespace: Chillow.StandChillow.Player.Aim
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(MecanimController))]
[RequireComponent(typeof(MovementController))]
public class AimController : Controller, zc<AimSnapshot, bca>, zu, bat, bdc, bbd // TypeDefIndex: 3882
{
	// Fields
	private bdd cgiy; // 0x58
	public float sensitivityY; // 0x5C
	public Transform spineDirector; // 0x60
	public Transform FPSCamera; // 0x68
	private Transform cgiz; // 0x70
	public Transform camTransform; // 0x78
	public AimingData aimingData; // 0x80
	public AimController.AimingParameters aimingParameters; // 0x88
	public float sensitivityX; // 0x90
	public float minimumX; // 0x94
	public float maximumX; // 0x98
	public GameObject FPSP_go; // 0xA0
	public AimController.bce interpolatorsBunch; // 0xA8
	public AimController.TuningParams tuningParams; // 0xB0
	[SerializeField]
	private Vector3 _headDirectiveAngles; // 0xB8
	private PlayerController cgja; // 0xC8
	private MovementController cgjb; // 0xD0
	private Transform cgjc; // 0xD8
	private MecanimController cgjd; // 0xE0
	private Transform cgje; // 0xE8
	private Transform cgjf; // 0xF0
	private Transform cgjg; // 0xF8
	private Transform cgjh; // 0x100
	private bool cgji; // 0x108
	private bca cgjj; // 0x110
	private readonly dgj<zt> cgjk; // 0x118
	private Vector3 cgjl; // 0x120
	private readonly dgj<AimController.bcc> cgjm; // 0x130
	private readonly dgj<AimController.bcd> cgjn; // 0x138
	private readonly TransformTR cgjo; // 0x140
	private readonly TransformTR cgjp; // 0x148
	private readonly TransformTR cgjq; // 0x150
	private readonly TransformTR cgjr; // 0x158
	private readonly TransformTR cgjs; // 0x160
	private readonly TransformTR cgjt; // 0x168
	private readonly AimSnapshot cgju; // 0x170
	private AimController.bcb cgjv; // 0x178
	private Transform cgjw; // 0x180
	private Transform cgjx; // 0x188
	private zb cgjy; // 0x190
	private float cgjz; // 0x198
	private float cgka; // 0x19C
	private bci[] cgkb; // 0x1A0
	[CompilerGenerated]
	private float <cgkc>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private float <cgkd>k__BackingField; // 0x1AC

	// Properties
	public float cgkc { get; set; }
	public float cgkd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1333B60 Offset: 0x1332B60 VA: 0x181333B60
	public float pgr() { }

	[CompilerGenerated]
	// RVA: 0x1333B70 Offset: 0x1332B70 VA: 0x181333B70
	private void pgs(float a) { }

	[CompilerGenerated]
	// RVA: 0x1333B80 Offset: 0x1332B80 VA: 0x181333B80
	public float pgt() { }

	[CompilerGenerated]
	// RVA: 0x1333B90 Offset: 0x1332B90 VA: 0x181333B90
	private void pgu(float a) { }

	// RVA: 0x1332680 Offset: 0x1331680 VA: 0x181332680 Slot: 5
	public override void nxw() { }

	// RVA: 0x1333BA0 Offset: 0x1332BA0 VA: 0x181333BA0
	private void pgv() { }

	// RVA: 0x1332D50 Offset: 0x1331D50 VA: 0x181332D50 Slot: 6
	public override void nxx(Team a) { }

	// RVA: 0x1333CA0 Offset: 0x1332CA0 VA: 0x181333CA0
	public void pgw(Vector3 a) { }

	// RVA: 0x1333CF0 Offset: 0x1332CF0 VA: 0x181333CF0
	public Vector3 pgx() { }

	// RVA: 0x1332F60 Offset: 0x1331F60 VA: 0x181332F60 Slot: 8
	public override void nxz() { }

	// RVA: 0x1332F80 Offset: 0x1331F80 VA: 0x181332F80 Slot: 12
	public override void nye(BipedMap a) { }

	// RVA: 0x1332FF0 Offset: 0x1331FF0 VA: 0x181332FF0 Slot: 13
	public override void nyf(BipedMap a) { }

	// RVA: 0x1333200 Offset: 0x1332200 VA: 0x181333200 Slot: 14
	public override void nyg(zt a) { }

	// RVA: 0x1333470 Offset: 0x1332470 VA: 0x181333470 Slot: 17
	public void nyx(bca a, float b, float c) { }

	// RVA: 0x1333D30 Offset: 0x1332D30 VA: 0x181333D30
	private void pgy() { }

	// RVA: 0x1333270 Offset: 0x1332270 VA: 0x181333270 Slot: 15
	public void nyv(AimSnapshot a) { }

	// RVA: 0x1333370 Offset: 0x1332370 VA: 0x181333370 Slot: 16
	public AimSnapshot nyw() { }

	// RVA: 0x1332660 Offset: 0x1331660 VA: 0x181332660 Slot: 26
	public void nwx() { }

	// RVA: 0x1332670 Offset: 0x1331670 VA: 0x181332670 Slot: 24
	public void nwy() { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0 Slot: 25
	public void nwz() { }

	// RVA: 0x13338A0 Offset: 0x13328A0 VA: 0x1813338A0 Slot: 27
	public void ojx() { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0 Slot: 28
	public void ojy() { }

	// RVA: 0x1333DC0 Offset: 0x1332DC0 VA: 0x181333DC0
	public void pgz() { }

	// RVA: 0x1333E20 Offset: 0x1332E20 VA: 0x181333E20
	private void pha() { }

	// RVA: 0x1333FB0 Offset: 0x1332FB0 VA: 0x181333FB0
	private void phb() { }

	// RVA: 0x1334050 Offset: 0x1333050 VA: 0x181334050
	private void phc() { }

	// RVA: 0x1334830 Offset: 0x1333830 VA: 0x181334830
	public bool phd(float a) { }

	// RVA: 0x1334850 Offset: 0x1333850 VA: 0x181334850
	private void phe() { }

	// RVA: 0x1334EF0 Offset: 0x1333EF0 VA: 0x181334EF0
	private void phf() { }

	// RVA: 0x1335010 Offset: 0x1334010 VA: 0x181335010
	private void phg() { }

	// RVA: 0x1335120 Offset: 0x1334120 VA: 0x181335120
	private void phh() { }

	// RVA: 0x13360C0 Offset: 0x13350C0 VA: 0x1813360C0
	public bool phi(float a) { }

	// RVA: 0x13360E0 Offset: 0x13350E0 VA: 0x1813360E0
	private void phj() { }

	// RVA: 0x1336130 Offset: 0x1335130 VA: 0x181336130
	private void phk() { }

	// RVA: 0x1336490 Offset: 0x1335490 VA: 0x181336490
	private void phl() { }

	// RVA: 0x1332260 Offset: 0x1331260 VA: 0x181332260
	public void .ctor() { }

	// RVA: 0x1333940 Offset: 0x1332940 VA: 0x181333940 Slot: 19
	public void oov() { }

	// RVA: 0x1333980 Offset: 0x1332980 VA: 0x181333980 Slot: 20
	public void oox() { }

	// RVA: 0x13339F0 Offset: 0x13329F0 VA: 0x1813339F0 Slot: 21
	public void ooy(float a) { }

	// RVA: 0x1333A80 Offset: 0x1332A80 VA: 0x181333A80 Slot: 22
	public void ooz() { }

	// RVA: 0x1333AF0 Offset: 0x1332AF0 VA: 0x181333AF0 Slot: 23
	public void opa() { }

	// RVA: 0x13334F0 Offset: 0x13324F0 VA: 0x1813334F0 Slot: 18
	public void oip(WeaponController a) { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0
	public void phm(WeaponController a) { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0
	public void phn(WeaponController a) { }
}

// Namespace: Chillow.StandChillow.Player.Aim
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(MecanimController))]
[RequireComponent(typeof(MovementController))]
public class AimController : Controller, zc<AimSnapshot, bca>, zu, bat, bdc, bbd // TypeDefIndex: 3882
{
	// Fields
	private bdd cgiy; // 0x58
	public float sensitivityY; // 0x5C
	public Transform spineDirector; // 0x60
	public Transform FPSCamera; // 0x68
	private Transform cgiz; // 0x70
	public Transform camTransform; // 0x78
	public AimingData aimingData; // 0x80
	public AimController.AimingParameters aimingParameters; // 0x88
	public float sensitivityX; // 0x90
	public float minimumX; // 0x94
	public float maximumX; // 0x98
	public GameObject FPSP_go; // 0xA0
	public AimController.bce interpolatorsBunch; // 0xA8
	public AimController.TuningParams tuningParams; // 0xB0
	[SerializeField]
	private Vector3 _headDirectiveAngles; // 0xB8
	private PlayerController cgja; // 0xC8
	private MovementController cgjb; // 0xD0
	private Transform cgjc; // 0xD8
	private MecanimController cgjd; // 0xE0
	private Transform cgje; // 0xE8
	private Transform cgjf; // 0xF0
	private Transform cgjg; // 0xF8
	private Transform cgjh; // 0x100
	private bool cgji; // 0x108
	private bca cgjj; // 0x110
	private readonly dgj<zt> cgjk; // 0x118
	private Vector3 cgjl; // 0x120
	private readonly dgj<AimController.bcc> cgjm; // 0x130
	private readonly dgj<AimController.bcd> cgjn; // 0x138
	private readonly TransformTR cgjo; // 0x140
	private readonly TransformTR cgjp; // 0x148
	private readonly TransformTR cgjq; // 0x150
	private readonly TransformTR cgjr; // 0x158
	private readonly TransformTR cgjs; // 0x160
	private readonly TransformTR cgjt; // 0x168
	private readonly AimSnapshot cgju; // 0x170
	private AimController.bcb cgjv; // 0x178
	private Transform cgjw; // 0x180
	private Transform cgjx; // 0x188
	private zb cgjy; // 0x190
	private float cgjz; // 0x198
	private float cgka; // 0x19C
	private bci[] cgkb; // 0x1A0
	[CompilerGenerated]
	private float <cgkc>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private float <cgkd>k__BackingField; // 0x1AC

	// Properties
	public float cgkc { get; set; }
	public float cgkd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1333B60 Offset: 0x1332B60 VA: 0x181333B60
	public float pgr() { }

	[CompilerGenerated]
	// RVA: 0x1333B70 Offset: 0x1332B70 VA: 0x181333B70
	private void pgs(float a) { }

	[CompilerGenerated]
	// RVA: 0x1333B80 Offset: 0x1332B80 VA: 0x181333B80
	public float pgt() { }

	[CompilerGenerated]
	// RVA: 0x1333B90 Offset: 0x1332B90 VA: 0x181333B90
	private void pgu(float a) { }

	// RVA: 0x1332680 Offset: 0x1331680 VA: 0x181332680 Slot: 5
	public override void nxw() { }

	// RVA: 0x1333BA0 Offset: 0x1332BA0 VA: 0x181333BA0
	private void pgv() { }

	// RVA: 0x1332D50 Offset: 0x1331D50 VA: 0x181332D50 Slot: 6
	public override void nxx(Team a) { }

	// RVA: 0x1333CA0 Offset: 0x1332CA0 VA: 0x181333CA0
	public void pgw(Vector3 a) { }

	// RVA: 0x1333CF0 Offset: 0x1332CF0 VA: 0x181333CF0
	public Vector3 pgx() { }

	// RVA: 0x1332F60 Offset: 0x1331F60 VA: 0x181332F60 Slot: 8
	public override void nxz() { }

	// RVA: 0x1332F80 Offset: 0x1331F80 VA: 0x181332F80 Slot: 12
	public override void nye(BipedMap a) { }

	// RVA: 0x1332FF0 Offset: 0x1331FF0 VA: 0x181332FF0 Slot: 13
	public override void nyf(BipedMap a) { }

	// RVA: 0x1333200 Offset: 0x1332200 VA: 0x181333200 Slot: 14
	public override void nyg(zt a) { }

	// RVA: 0x1333470 Offset: 0x1332470 VA: 0x181333470 Slot: 17
	public void nyx(bca a, float b, float c) { }

	// RVA: 0x1333D30 Offset: 0x1332D30 VA: 0x181333D30
	private void pgy() { }

	// RVA: 0x1333270 Offset: 0x1332270 VA: 0x181333270 Slot: 15
	public void nyv(AimSnapshot a) { }

	// RVA: 0x1333370 Offset: 0x1332370 VA: 0x181333370 Slot: 16
	public AimSnapshot nyw() { }

	// RVA: 0x1332660 Offset: 0x1331660 VA: 0x181332660 Slot: 26
	public void nwx() { }

	// RVA: 0x1332670 Offset: 0x1331670 VA: 0x181332670 Slot: 24
	public void nwy() { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0 Slot: 25
	public void nwz() { }

	// RVA: 0x13338A0 Offset: 0x13328A0 VA: 0x1813338A0 Slot: 27
	public void ojx() { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0 Slot: 28
	public void ojy() { }

	// RVA: 0x1333DC0 Offset: 0x1332DC0 VA: 0x181333DC0
	public void pgz() { }

	// RVA: 0x1333E20 Offset: 0x1332E20 VA: 0x181333E20
	private void pha() { }

	// RVA: 0x1333FB0 Offset: 0x1332FB0 VA: 0x181333FB0
	private void phb() { }

	// RVA: 0x1334050 Offset: 0x1333050 VA: 0x181334050
	private void phc() { }

	// RVA: 0x1334830 Offset: 0x1333830 VA: 0x181334830
	public bool phd(float a) { }

	// RVA: 0x1334850 Offset: 0x1333850 VA: 0x181334850
	private void phe() { }

	// RVA: 0x1334EF0 Offset: 0x1333EF0 VA: 0x181334EF0
	private void phf() { }

	// RVA: 0x1335010 Offset: 0x1334010 VA: 0x181335010
	private void phg() { }

	// RVA: 0x1335120 Offset: 0x1334120 VA: 0x181335120
	private void phh() { }

	// RVA: 0x13360C0 Offset: 0x13350C0 VA: 0x1813360C0
	public bool phi(float a) { }

	// RVA: 0x13360E0 Offset: 0x13350E0 VA: 0x1813360E0
	private void phj() { }

	// RVA: 0x1336130 Offset: 0x1335130 VA: 0x181336130
	private void phk() { }

	// RVA: 0x1336490 Offset: 0x1335490 VA: 0x181336490
	private void phl() { }

	// RVA: 0x1332260 Offset: 0x1331260 VA: 0x181332260
	public void .ctor() { }

	// RVA: 0x1333940 Offset: 0x1332940 VA: 0x181333940 Slot: 19
	public void oov() { }

	// RVA: 0x1333980 Offset: 0x1332980 VA: 0x181333980 Slot: 20
	public void oox() { }

	// RVA: 0x13339F0 Offset: 0x13329F0 VA: 0x1813339F0 Slot: 21
	public void ooy(float a) { }

	// RVA: 0x1333A80 Offset: 0x1332A80 VA: 0x181333A80 Slot: 22
	public void ooz() { }

	// RVA: 0x1333AF0 Offset: 0x1332AF0 VA: 0x181333AF0 Slot: 23
	public void opa() { }

	// RVA: 0x13334F0 Offset: 0x13324F0 VA: 0x1813334F0 Slot: 18
	public void oip(WeaponController a) { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0
	public void phm(WeaponController a) { }

	// RVA: 0x5B76B0 Offset: 0x5B66B0 VA: 0x1805B76B0
	public void phn(WeaponController a) { }
}
