// Filtered reference dump: ESP boxes, aim, client cosmetics and hit feedback.
// Partial declarations and metadata; no native executable or cheat implementation.

// Namespace: 
public class AHFDHFFDEDDCAAF : SerializableMessage // TypeDefIndex: 179
{
	// Fields
	public float FBDFBDEAHDFEAEE; // 0x10
	public float ADCEDCADHEADBFH; // 0x14
	public Vector3 EEGBCDDBFAABFEC; // 0x18
	public Vector3 ACHFGEBDHADDCHE; // 0x24
	public TransformTR ACCEAFFBCGCDGFA; // 0x30
	public TransformTR BEFHECHAFEGCEDE; // 0x38
	public TransformTR BCFCAAHEHDCEBBG; // 0x40
	public float EDGCBAFHDCGCFAE; // 0x48
	public float GGACCDHFEHAACGG; // 0x4C

	// Methods

	// RVA: 0xEFC1E0 Offset: 0xEFC1E0 VA: 0xEFC1E0
	public void .ctor() { }

	// RVA: 0xEFC300 Offset: 0xEFC300 VA: 0xEFC300
	public AHFDHFFDEDDCAAF BFCGECAFAAHDHHH() { }

	// RVA: 0xEFC380 Offset: 0xEFC380 VA: 0xEFC380 Slot: 4
	public override void Deserialize(BinaryStream DGHEFDCECCBHFBH) { }

	// RVA: 0xEFC494 Offset: 0xEFC494 VA: 0xEFC494 Slot: 5
	public override void Serialize(BinaryStream CEAAEGCDHFHBFAA) { }
}

// Namespace: 
public class DHHFDEABDDCFDGD : DGHACFAABHCHFFH // TypeDefIndex: 751
{
	// Fields
	public Vector3 GDDCEEEDAAGCBCA; // 0x14
	public Vector3 ACFEDAAECFDHHFG; // 0x20
	public Vector3 FEEAEGHCBCBCBDG; // 0x2C
	public byte GGEGHHADBEGABFG; // 0x38
	public float ADAGCCEBBFFAFCC; // 0x3C
	public HHHAABFGEBGDADF<CEEBAHFBDECFCEB>[] AGCHHCGFBDHCCAH; // 0x40

	// Methods

	// RVA: 0x13AB940 Offset: 0x13AB940 VA: 0x13AB940 Slot: 4
	public override void Deserialize(BinaryStream DGHEFDCECCBHFBH) { }

	// RVA: 0x13ABC78 Offset: 0x13ABC78 VA: 0x13ABC78 Slot: 5
	public override void Serialize(BinaryStream CEAAEGCDHFHBFAA) { }

	// RVA: 0x13ABFA4 Offset: 0x13ABFA4 VA: 0x13ABFA4
	public void .ctor() { }
}

// Namespace: 
public enum HAACHBDEFGBGEEH // TypeDefIndex: 1293
{
	// Fields
	public int value__; // 0x0
	public const HAACHBDEFGBGEEH None = 0;
	public const HAACHBDEFGBGEEH Invisible = 1;
	public const HAACHBDEFGBGEEH Visible = 2;
}

// Namespace: Axlebolt.Standoff.Player
public class ArmsLodGroup : SkinnedMeshLodGroup // TypeDefIndex: 2771
{
	// Fields
	[SerializeField]
	private SkinnedMeshRenderer _armsMeshRenderer; // 0x30
	[SerializeField]
	private SkinnedMeshRenderer _glovesMeshRenderer; // 0x38
	private string CCHHCEFAGHCHHAG; // 0x40
	private Mesh AHBHGFBGCGBFFGC; // 0x48

	// Methods

	// RVA: 0x10EF7E8 Offset: 0x10EF7E8 VA: 0x10EF7E8
	public void BFFHCFGEBDCCBHE(string GGGDHDBHCCBFHAG) { }

	// RVA: 0x10EF808 Offset: 0x10EF808 VA: 0x10EF808 Slot: 4
	protected override void EHHAGBCCGBAHDGD(int ADDFDBBECCEGEAH) { }

	// RVA: 0x10EFA18 Offset: 0x10EFA18 VA: 0x10EFA18
	private SkinnedMeshRenderer AGDCDBEEBGDAHEA(int ADDFDBBECCEGEAH) { }

	// RVA: 0x10EFC30 Offset: 0x10EFC30 VA: 0x10EFC30
	private SkinnedMeshRenderer FGHFEFHDCHCFABC(int ADDFDBBECCEGEAH) { }

	// RVA: 0x10EFE48 Offset: 0x10EFE48 VA: 0x10EFE48 Slot: 5
	protected override void HAEFAGDFGBDGCGB() { }

	// RVA: 0x10EFF54 Offset: 0x10EFF54 VA: 0x10EFF54 Slot: 6
	public override void CCAFBGBACGBGHAC(Material[] ABHAFHEGAHFBGEF) { }

	// RVA: 0x10F0064 Offset: 0x10F0064 VA: 0x10F0064 Slot: 7
	public override void CFEDFDGCHAEADFE(Material ABHAFHEGAHFBGEF) { }

	// RVA: 0x10F0068 Offset: 0x10F0068 VA: 0x10F0068 Slot: 8
	public override void FBCHHBABHDBHFBA() { }

	// RVA: 0x10F006C Offset: 0x10F006C VA: 0x10F006C Slot: 9
	public override void HDFGFFHBFAFFHGH(bool EEBCHBHEBGCADGB) { }

	// RVA: 0x10F0148 Offset: 0x10F0148 VA: 0x10F0148
	public void BFBDFBDCDGDHHHE(Mesh CAFHBDBBFBAACCH, Material ABHAFHEGAHFBGEF) { }

	// RVA: 0x10F021C Offset: 0x10F021C VA: 0x10F021C
	public void DDEEABGCHFDAHGG() { }

	// RVA: 0x10F0320 Offset: 0x10F0320 VA: 0x10F0320
	public void .ctor() { }
}

// Namespace: 
public enum BipedMap.HHECCBDEGAAEGAB // TypeDefIndex: 2773
{
	// Fields
	public int value__; // 0x0
	public const BipedMap.HHECCBDEGAAEGAB Head = 0;
	public const BipedMap.HHECCBDEGAAEGAB Neck = 1;
	public const BipedMap.HHECCBDEGAAEGAB Spine1 = 2;
	public const BipedMap.HHECCBDEGAAEGAB Spine2 = 3;
	public const BipedMap.HHECCBDEGAAEGAB LeftUpperarm = 4;
	public const BipedMap.HHECCBDEGAAEGAB LeftForearm = 5;
	public const BipedMap.HHECCBDEGAAEGAB LeftHand = 6;
	public const BipedMap.HHECCBDEGAAEGAB LeftShoulder = 7;
	public const BipedMap.HHECCBDEGAAEGAB RightShoulder = 8;
	public const BipedMap.HHECCBDEGAAEGAB RightUpperarm = 9;
	public const BipedMap.HHECCBDEGAAEGAB RightForearm = 10;
	public const BipedMap.HHECCBDEGAAEGAB RightHand = 11;
	public const BipedMap.HHECCBDEGAAEGAB Hip = 12;
	public const BipedMap.HHECCBDEGAAEGAB LeftThigh = 13;
	public const BipedMap.HHECCBDEGAAEGAB LeftCalf = 14;
	public const BipedMap.HHECCBDEGAAEGAB LeftFoot = 15;
	public const BipedMap.HHECCBDEGAAEGAB RightThigh = 16;
	public const BipedMap.HHECCBDEGAAEGAB RightCalf = 17;
	public const BipedMap.HHECCBDEGAAEGAB RightFoot = 18;
	public const BipedMap.HHECCBDEGAAEGAB RightThumb0 = 19;
	public const BipedMap.HHECCBDEGAAEGAB LeftThumb0 = 20;
}

// Namespace: Axlebolt.Standoff.Player
[ExecuteInEditMode]
public class BipedMap : MonoBehaviour // TypeDefIndex: 2774
{
	// Fields
	public const string HeadNaming = "BipBase Head";
	public const string NeckNaming = "BipBase Neck1";
	public const string Spine1Naming = "BipBase Spine1";
	public const string Spine2Naming = "BipBase Spine2";
	public const string Left1ShoulderNaming = "BipBase L Clavicle";
	public const string LeftUpperarmNaming = "BipBase L UpperArm";
	public const string LeftForearmNaming = "BipBase L Forearm";
	public const string LeftHandNaming = "BipBase L Hand";
	public const string RightShoulderNaming = "BipBase R Clavicle";
	public const string RightUpperarmNaming = "BipBase R UpperArm";
	public const string RightForearmNaming = "BipBase R Forearm";
	public const string RightHandNaming = "BipBase R Hand";
	public const string HipNaming = "BipBase Pelvis";
	public const string LeftThighNaming = "BipBase L Thigh";
	public const string LeftCalfNaming = "BipBase L Calf";
	public const string LeftFootNaming = "BipBase L Foot";
	public const string RightThighNaming = "BipBase R Thigh";
	public const string RightCalfNaming = "BipBase R Calf";
	public const string RightFootNaming = "BipBase R Foot";
	public const string RFinger0Naming = "BipBase R Finger0";
	public const string RFinger1Naming = "BipBase R Finger1";
	public const string RFinger2Naming = "BipBase R Finger2";
	public const string RFinger3Naming = "BipBase R Finger3";
	public const string RFinger4Naming = "BipBase R Finger4";
	public Transform Head; // 0x18
	public Transform Neck; // 0x20
	public Transform Spine1; // 0x28
	public Transform Spine2; // 0x30
	public Transform LeftShoulder; // 0x38
	public Transform LeftUpperarm; // 0x40
	public Transform LeftForearm; // 0x48
	public Transform LeftHand; // 0x50
	public Transform RightShoulder; // 0x58
	public Transform RightUpperarm; // 0x60
	public Transform RightForearm; // 0x68
	public Transform RightHand; // 0x70
	public Transform Hip; // 0x78
	public Transform LeftThigh; // 0x80
	public Transform LeftCalf; // 0x88
	public Transform LeftFoot; // 0x90
	public Transform RightThigh; // 0x98
	public Transform RightCalf; // 0xA0
	public Transform RightFoot; // 0xA8
	public Transform RightThumb0; // 0xB0
	public Transform LeftThumb0; // 0xB8
	public Transform RFinger0; // 0xC0
	public Transform RFinger1; // 0xC8
	public Transform RFinger2; // 0xD0
	public Transform RFinger3; // 0xD8
	public Transform RFinger4; // 0xE0
	public static IReadOnlyList<BipedMap.HHECCBDEGAAEGAB> RagdollBones; // 0x0

	// Properties
	public Transform HDACACBCAGACCGH { get; }
	public Transform CBBECCGBADADGDF { get; }
	public Transform FEACBEBBCDBEEED { get; }
	public Transform DAACAAFDGGCACHC { get; }
	public Transform EFADEAEGCFAGFEH { get; }

	// Methods

	// RVA: 0x10F03E8 Offset: 0x10F03E8 VA: 0x10F03E8
	public Transform get_HDACACBCAGACCGH() { }

	// RVA: 0x10F03F0 Offset: 0x10F03F0 VA: 0x10F03F0
	public Transform get_CBBECCGBADADGDF() { }

	// RVA: 0x10F03F8 Offset: 0x10F03F8 VA: 0x10F03F8
	public Transform get_FEACBEBBCDBEEED() { }

	// RVA: 0x10F0400 Offset: 0x10F0400 VA: 0x10F0400
	public Transform get_DAACAAFDGGCACHC() { }

	// RVA: 0x10F0408 Offset: 0x10F0408 VA: 0x10F0408
	public Transform get_EFADEAEGCFAGFEH() { }

	// RVA: 0x10F0410 Offset: 0x10F0410 VA: 0x10F0410
	private void OnEnable() { }

	// RVA: 0x10F0414 Offset: 0x10F0414 VA: 0x10F0414
	private void OnDisable() { }

	// RVA: 0x10F0418 Offset: 0x10F0418 VA: 0x10F0418
	public static IReadOnlyList<BipedMap.HHECCBDEGAAEGAB> BHCEEGCCGEFHBFE() { }

	// RVA: 0x10F0470 Offset: 0x10F0470 VA: 0x10F0470
	private void HBAEGCEDABCCCHH() { }

	// RVA: 0x10F0A58 Offset: 0x10F0A58 VA: 0x10F0A58
	private void BCCHHAFBEDAACBH(BipedMap AFBDGGFFBABAFHE, bool BBDGCHCHEDBBHCB) { }

	// RVA: 0x10F0F58 Offset: 0x10F0F58 VA: 0x10F0F58
	public void GEADCGHCGDDCEGF(BipedMap AFBDGGFFBABAFHE, bool DEFBCBGBAEEAHAG, bool BBDGCHCHEDBBHCB = False) { }

	// RVA: 0x10F0E80 Offset: 0x10F0E80 VA: 0x10F0E80
	public Transform BAEEHDAEFEFEAHA(BipedMap.HHECCBDEGAAEGAB HHBAFGEEDCCCHHB) { }

	// RVA: 0x10F10C4 Offset: 0x10F10C4 VA: 0x10F10C4
	public Transform FHEEDABCADAHDDA() { }

	// RVA: 0x10F10CC Offset: 0x10F10CC VA: 0x10F10CC
	public Transform DAGCFHCHHBCCBAH() { }

	// RVA: 0x10F10D4 Offset: 0x10F10D4 VA: 0x10F10D4
	public Transform EHGBBCEDABGCGBF() { }

	// RVA: 0x10F10DC Offset: 0x10F10DC VA: 0x10F10DC
	public Transform FFAAHBCABBAEAFD() { }

	// RVA: 0x10F10E4 Offset: 0x10F10E4 VA: 0x10F10E4
	public Transform GHHGGFGEAGFBAGA() { }

	// RVA: 0x10F10EC Offset: 0x10F10EC VA: 0x10F10EC
	public static bool AEDFAFGDCCFACCC(BipedMap.HHECCBDEGAAEGAB HHBAFGEEDCCCHHB) { }

	// RVA: 0x10F10F8 Offset: 0x10F10F8 VA: 0x10F10F8
	public static bool BFHDAFBDHEHCEFG(BipedMap.HHECCBDEGAAEGAB HHBAFGEEDCCCHHB) { }

	// RVA: 0x10F1108 Offset: 0x10F1108 VA: 0x10F1108
	public static bool FACEAAACDAHHCGG(BipedMap.HHECCBDEGAAEGAB HHBAFGEEDCCCHHB) { }

	// RVA: 0x10F1120 Offset: 0x10F1120 VA: 0x10F1120
	public static bool BFDEAEBCDFBEAGE(BipedMap.HHECCBDEGAAEGAB HHBAFGEEDCCCHHB) { }

	// RVA: 0x10F1130 Offset: 0x10F1130 VA: 0x10F1130
	public static bool EADFCDGFHGCHGEH(BipedMap.HHECCBDEGAAEGAB HHBAFGEEDCCCHHB) { }

	// RVA: 0x10F1140 Offset: 0x10F1140 VA: 0x10F1140
	public void .ctor() { }

	// RVA: 0x10F1148 Offset: 0x10F1148 VA: 0x10F1148
	private static void .cctor() { }
}

// Namespace: Axlebolt.Standoff.Player
public abstract class Controller : PhotonBehavior // TypeDefIndex: 2779
{
	// Fields
	private BAAFADDFCADEHEA AGBDDHFFGFGDBAH; // 0x20
	private Team AGACDDDCBFFGEHF; // 0x24
	private BipedMap AEDCBHEBDGCDBBB; // 0x28
	private Transform CBCBGACGGECGEAA; // 0x30
	private PhotonPlayer GEGCBHCBBCAEHFF; // 0x38
	private int GEGDGCHACDCGEAA; // 0x40
	private int CCCFDBEFFEHCCCH; // 0x44
	private bool HEAFFDHGFEBEGGA; // 0x48
	private bool CCHAAFFFDFCCDEH; // 0x49
	private bool GAEAEFBHGBCHEGG; // 0x4A

	// Properties
	protected BAAFADDFCADEHEA GECAGBEAEBCFFAC { get; }
	protected Team CGGHFHCAFFBBCBB { get; }
	protected BipedMap FBHEHABCGEFGGAC { get; }
	public Transform FAFCFFABDEEBFAH { get; }
	public bool EDGHHCAGFGDBABD { get; set; }
	public bool EBEABDDAEGGDCAH { get; set; }
	public PhotonPlayer HBBBCEFBCFEFBBA { get; }
	public int HDEEAEBEFHFHHDB { get; }
	public int BDGCHEBACHBFCGD { get; }
	public bool HHEFDBHAAABFBFB { get; }

	// Methods

	// RVA: 0x10F26FC Offset: 0x10F26FC VA: 0x10F26FC
	protected BAAFADDFCADEHEA get_GECAGBEAEBCFFAC() { }

	// RVA: 0x10F2760 Offset: 0x10F2760 VA: 0x10F2760
	protected Team get_CGGHFHCAFFBBCBB() { }

	// RVA: 0x10F27C4 Offset: 0x10F27C4 VA: 0x10F27C4
	protected BipedMap get_FBHEHABCGEFGGAC() { }

	// RVA: 0x10F2880 Offset: 0x10F2880 VA: 0x10F2880 Slot: 62
	public Transform get_FAFCFFABDEEBFAH() { }

	// RVA: 0x10F2914 Offset: 0x10F2914 VA: 0x10F2914
	public bool get_EDGHHCAGFGDBABD() { }

	// RVA: 0x10F291C Offset: 0x10F291C VA: 0x10F291C
	private void set_EDGHHCAGFGDBABD(bool value) { }

	// RVA: 0x10F2928 Offset: 0x10F2928 VA: 0x10F2928
	public bool get_EBEABDDAEGGDCAH() { }

	// RVA: 0x10F2930 Offset: 0x10F2930 VA: 0x10F2930
	private void set_EBEABDDAEGGDCAH(bool value) { }

	// RVA: 0x10F293C Offset: 0x10F293C VA: 0x10F293C
	public PhotonPlayer get_HBBBCEFBCFEFBBA() { }

	// RVA: 0x10F29A0 Offset: 0x10F29A0 VA: 0x10F29A0
	public int get_HDEEAEBEFHFHHDB() { }

	// RVA: 0x10F2A08 Offset: 0x10F2A08 VA: 0x10F2A08
	public int get_BDGCHEBACHBFCGD() { }

	// RVA: 0x10F2A10 Offset: 0x10F2A10 VA: 0x10F2A10
	public bool get_HHEFDBHAAABFBFB() { }

	// RVA: 0x10F2A18 Offset: 0x10F2A18 VA: 0x10F2A18 Slot: 63
	public virtual void FDEDFCDHCDGCCCD() { }

	// RVA: 0x10F2A1C Offset: 0x10F2A1C VA: 0x10F2A1C Slot: 64
	public virtual void BGCCFHHGDFGCFEB(Team FCFFBABADHDCFHG) { }

	// RVA: 0x10F2A2C Offset: 0x10F2A2C VA: 0x10F2A2C Slot: 44
	public override void OnPhotonInstantiate(PhotonMessageInfo BGGCCDEBDDEBDCB) { }

	// RVA: 0x10F2AB4 Offset: 0x10F2AB4 VA: 0x10F2AB4 Slot: 65
	public virtual void GBEDCDHFFBAFDHA() { }

	// RVA: 0x10F2AC0 Offset: 0x10F2AC0 VA: 0x10F2AC0 Slot: 66
	public virtual void AAEDEDCEDCADEBG() { }

	// RVA: 0x10F2B04 Offset: 0x10F2B04 VA: 0x10F2B04 Slot: 67
	public virtual void AFGHDFFFGGABBHA() { }

	// RVA: 0x10F2B08 Offset: 0x10F2B08 VA: 0x10F2B08 Slot: 68
	public virtual void EFCGDBEGHECDGDF() { }

	// RVA: 0x10F2700 Offset: 0x10F2700 VA: 0x10F2700
	protected BAAFADDFCADEHEA BGFDHCBAHHEBEHE() { }

	// RVA: 0x10F2764 Offset: 0x10F2764 VA: 0x10F2764
	protected Team DFHFCADHGBFBACG() { }

	// RVA: 0x10F27C8 Offset: 0x10F27C8 VA: 0x10F27C8
	protected BipedMap CGFDDDAEAAEGDFF() { }

	// RVA: 0x10F2884 Offset: 0x10F2884 VA: 0x10F2884 Slot: 69
	public Transform EDCEFGEGAHEAAEG() { }

	// RVA: 0x10F2B0C Offset: 0x10F2B0C VA: 0x10F2B0C
	public bool FFGGHGAAAEBFHBA() { }

	// RVA: 0x10F2B14 Offset: 0x10F2B14 VA: 0x10F2B14
	private void AGAACGFGABHFDCG(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x10F2B20 Offset: 0x10F2B20 VA: 0x10F2B20
	public bool ACDGAFHAGCEGGAA() { }

	// RVA: 0x10F2B28 Offset: 0x10F2B28 VA: 0x10F2B28
	private void FHFGBAEEFHEEBEB(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x10F2940 Offset: 0x10F2940 VA: 0x10F2940
	public PhotonPlayer HAAGEDGBEHBBGFB() { }

	// RVA: 0x10F29A4 Offset: 0x10F29A4 VA: 0x10F29A4
	public int CDDBCBFGHBAADBC() { }

	// RVA: 0x10F2B34 Offset: 0x10F2B34 VA: 0x10F2B34
	public int HFGGCEAEDHGEGGA() { }

	// RVA: 0x10F2B3C Offset: 0x10F2B3C VA: 0x10F2B3C
	public bool GBEDBGCAFFDECAF() { }

	// RVA: 0x10F2B44 Offset: 0x10F2B44 VA: 0x10F2B44
	public bool CCGBEGHFGFFEAEE() { }

	// RVA: 0x10F2B5C Offset: 0x10F2B5C VA: 0x10F2B5C Slot: 70
	public virtual void FBHAEBEFFDGFFCE(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x10F2B60 Offset: 0x10F2B60 VA: 0x10F2B60 Slot: 71
	public virtual void GEGDBCCAFCDHEAH(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x10F2B64 Offset: 0x10F2B64 VA: 0x10F2B64 Slot: 72
	public virtual void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x10F2B6C Offset: 0x10F2B6C VA: 0x10F2B6C Slot: 73
	public virtual void CGEHBBBHECABDEB(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x10F2BCC Offset: 0x10F2BCC VA: 0x10F2BCC
	protected void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Player
[RequireComponent(typeof(ArmsAnimationController))]
[RequireComponent(typeof(WeaponryController))]
[RequireComponent(typeof(MovementController))]
[RequireComponent(typeof(MecanimController))]
[RequireComponent(typeof(AimController))]
[RequireComponent(typeof(PhotonView))]
public class PlayerController : PunBehaviour, FFGBGHGBFHFBBFE // TypeDefIndex: 2782
{
	// Fields
	private static readonly FDFDGBABCCCGEFE EDDFBAGEBAHEDCE; // 0x0
	public static int MaxCtHealth; // 0x8
	public static int MaxCtArmor; // 0xC
	public static int MaxTrHealth; // 0x10
	public static int MaxTrArmor; // 0x14
	[SerializeField]
	private Transform _mainCameraHolder; // 0x20
	[SerializeField]
	private GameObject _fpsCameraHolder; // 0x28
	[SerializeField]
	private BipedMap _characterBiped; // 0x30
	[SerializeField]
	private BipedMap _armsBiped; // 0x38
	[SerializeField]
	private GameObject _fpsDirective; // 0x40
	[SerializeField]
	private PluggableOverrideController _pluggableOverrider; // 0x48
	private PlayerLevelZonesController FGDHBFDCHFFCEBC; // 0x50
	private bool ACEFEFGCBDDEFBD; // 0x58
	private Team AGACDDDCBFFGEHF; // 0x59
	private float CHDAEHHBGDDDEAD; // 0x5C
	private AimController GDGACHFHBGFBGAF; // 0x60
	private WeaponryController GHGDCEFBAAHEEDA; // 0x68
	private MecanimController EBAGHECBEHABGGG; // 0x70
	private MovementController BAFFBHDEFECHDBE; // 0x78
	private ArmsAnimationController FEFADEAEFCGEGDB; // 0x80
	private PlayerHitController FBABAGBHGCBGGAB; // 0x88
	private PlayerOcclusionController GEAEFBDAFAFCFBA; // 0x90
	private NetworkController EHCDDHHEBDBEHEA; // 0x98
	private ArmsLodGroup ADAEBHHDGAGGHGD; // 0xA0
	private BipedMap BCAHGECGCFFGAAC; // 0xA8
	private bool ADACCGADFECEFAF; // 0xB0
	private bool FECHGEAEAABDCBH; // 0xB1
	private float FAFGEAHDBABGDGC; // 0xB4
	private PlayerSoundController EFAEBFAAEGCFDEH; // 0xB8
	private PlayerMainCamera CEHBGAFBGBCFCAC; // 0xC0
	private PlayerFPSCamera EFBEEGGDBEEHHHG; // 0xC8
	private PlayerMarkerTrigger BACEGEEGFHGDCAD; // 0xD0
	private Transform CBCBGACGGECGEAA; // 0xD8
	private Controller[] FBHAHGDECHGBHEE; // 0xE0
	private Dictionary<Type, Controller> CEGGDGBCBECAEDE; // 0xE8
	private CharacterController DEGCCGAHBFABFHB; // 0xF0
	private SkinnedMeshLodGroup FEDFHBBFDAAFAAH; // 0xF8
	private CharacterLodGroup FAEEDAAACDEAEHD; // 0x100
	private bool DHCHGFHFFBCHGEB; // 0x108
	private bool GAEAEFBHGBCHEGG; // 0x109
	private BAAFADDFCADEHEA HDBCDBAHHCDFEEA; // 0x10C
	private Nullable<int> DFDHECHGHHABFED; // 0x110
	private Nullable<bool> GAFDCBBGEGDFFDH; // 0x118
	private PhotonView HHDBBBDEBCGEEAE; // 0x120
	private int GCCFDFCBAFABEBF; // 0x128
	private int GBHCCAFHDCBBDDB; // 0x12C
	private PhotonPlayer HHCCEADDHBAFECD; // 0x130

	// Properties
	public float AEGGFHEGDACDBDD { get; set; }
	public AimController DHHBDHHFDEEHDDA { get; set; }
	public WeaponryController HDFDDHHEAGCFFFG { get; set; }
	public MecanimController DFCFCCABBACFHGA { get; set; }
	public MovementController BCEHBACHDCBGDDA { get; set; }
	public ArmsAnimationController HGHEDCDCECBEBFH { get; set; }
	public PlayerHitController AGADEFBAEEHCDFF { get; set; }
	public PlayerOcclusionController DHCDCBAGBDBFDGA { get; set; }
	public NetworkController FBBAFHADGDGFCAF { get; set; }
	public ArmsLodGroup GFHDBGEEDCDEDDE { get; set; }
	public BipedMap FBHEHABCGEFGGAC { get; set; }
	public GameObject GGBFBEGHHGCCBGD { get; }
	public Transform FCFFFCDEGHDGGBB { get; }
	public BipedMap BBHGHCAEBEDFDGE { get; }
	public bool BDAGBEGGBDAEAGC { get; set; }
	public bool AHEGCAADDHFCHDH { get; set; }
	public float DDCGCDDAHCFGAAA { get; set; }
	public PlayerSoundController EBGAGEHBBCBACAB { get; set; }
	public PlayerMainCamera EBBGHCEGFEGADCC { get; }
	public PlayerFPSCamera HDEEHEHCBECFHBA { get; }
	public SkinnedMeshLodGroup EGHCBHHCCBGEGAF { get; set; }
	public CharacterLodGroup HGAHDFGGHAFGEFB { get; set; }
	public bool CCGFHBGBCBDBFDD { get; set; }
	public bool EBEABDDAEGGDCAH { get; set; }
	public bool BEAGHGCHBCAGGDH { get; }
	public Transform FAFCFFABDEEBFAH { get; }
	public BAAFADDFCADEHEA GECAGBEAEBCFFAC { get; set; }
	public PhotonView FBDCEGCEGEBCACB { get; set; }
	public int HDEEAEBEFHFHHDB { get; set; }
	public int DDAAEECEBADEDBF { get; set; }
	public PhotonPlayer HBBBCEFBCFEFBBA { get; set; }

	// Methods

	// RVA: 0x10F3A74 Offset: 0x10F3A74 VA: 0x10F3A74
	public float get_AEGGFHEGDACDBDD() { }

	// RVA: 0x10F3A7C Offset: 0x10F3A7C VA: 0x10F3A7C
	private void set_AEGGFHEGDACDBDD(float value) { }

	// RVA: 0x10F3A84 Offset: 0x10F3A84 VA: 0x10F3A84
	public AimController get_DHHBDHHFDEEHDDA() { }

	// RVA: 0x10F3A8C Offset: 0x10F3A8C VA: 0x10F3A8C
	private void set_DHHBDHHFDEEHDDA(AimController value) { }

	// RVA: 0x10F3A94 Offset: 0x10F3A94 VA: 0x10F3A94
	public WeaponryController get_HDFDDHHEAGCFFFG() { }

	// RVA: 0x10F3A9C Offset: 0x10F3A9C VA: 0x10F3A9C
	private void set_HDFDDHHEAGCFFFG(WeaponryController value) { }

	// RVA: 0x10F3AA4 Offset: 0x10F3AA4 VA: 0x10F3AA4
	public MecanimController get_DFCFCCABBACFHGA() { }

	// RVA: 0x10F3AAC Offset: 0x10F3AAC VA: 0x10F3AAC
	private void set_DFCFCCABBACFHGA(MecanimController value) { }

	// RVA: 0x10F3858 Offset: 0x10F3858 VA: 0x10F3858
	public MovementController get_BCEHBACHDCBGDDA() { }

	// RVA: 0x10F3AB4 Offset: 0x10F3AB4 VA: 0x10F3AB4
	private void set_BCEHBACHDCBGDDA(MovementController value) { }

	// RVA: 0x10F3ABC Offset: 0x10F3ABC VA: 0x10F3ABC
	public ArmsAnimationController get_HGHEDCDCECBEBFH() { }

	// RVA: 0x10F3AC4 Offset: 0x10F3AC4 VA: 0x10F3AC4
	private void set_HGHEDCDCECBEBFH(ArmsAnimationController value) { }

	// RVA: 0x10F3ACC Offset: 0x10F3ACC VA: 0x10F3ACC
	public PlayerHitController get_AGADEFBAEEHCDFF() { }

	// RVA: 0x10F3AD4 Offset: 0x10F3AD4 VA: 0x10F3AD4
	private void set_AGADEFBAEEHCDFF(PlayerHitController value) { }

	// RVA: 0x10F3ADC Offset: 0x10F3ADC VA: 0x10F3ADC
	public PlayerOcclusionController get_DHCDCBAGBDBFDGA() { }

	// RVA: 0x10F3AE4 Offset: 0x10F3AE4 VA: 0x10F3AE4
	private void set_DHCDCBAGBDBFDGA(PlayerOcclusionController value) { }

	// RVA: 0x10F3AEC Offset: 0x10F3AEC VA: 0x10F3AEC
	public NetworkController get_FBBAFHADGDGFCAF() { }

	// RVA: 0x10F3AF4 Offset: 0x10F3AF4 VA: 0x10F3AF4
	private void set_FBBAFHADGDGFCAF(NetworkController value) { }

	// RVA: 0x10F3AFC Offset: 0x10F3AFC VA: 0x10F3AFC
	public ArmsLodGroup get_GFHDBGEEDCDEDDE() { }

	// RVA: 0x10F3B04 Offset: 0x10F3B04 VA: 0x10F3B04
	private void set_GFHDBGEEDCDEDDE(ArmsLodGroup value) { }

	// RVA: 0x10F3B0C Offset: 0x10F3B0C VA: 0x10F3B0C
	public BipedMap get_FBHEHABCGEFGGAC() { }

	// RVA: 0x10F3B14 Offset: 0x10F3B14 VA: 0x10F3B14
	private void set_FBHEHABCGEFGGAC(BipedMap value) { }

	// RVA: 0x10F3B1C Offset: 0x10F3B1C VA: 0x10F3B1C
	public GameObject get_GGBFBEGHHGCCBGD() { }

	// RVA: 0x10F3B24 Offset: 0x10F3B24 VA: 0x10F3B24
	public Transform get_FCFFFCDEGHDGGBB() { }

	// RVA: 0x10F3B2C Offset: 0x10F3B2C VA: 0x10F3B2C
	public BipedMap get_BBHGHCAEBEDFDGE() { }

	// RVA: 0x10F3B34 Offset: 0x10F3B34 VA: 0x10F3B34
	public bool get_BDAGBEGGBDAEAGC() { }

	// RVA: 0x10F3B3C Offset: 0x10F3B3C VA: 0x10F3B3C
	private void set_BDAGBEGGBDAEAGC(bool value) { }

	// RVA: 0x10F3B48 Offset: 0x10F3B48 VA: 0x10F3B48
	public bool get_AHEGCAADDHFCHDH() { }

	// RVA: 0x10F3B50 Offset: 0x10F3B50 VA: 0x10F3B50
	public void set_AHEGCAADDHFCHDH(bool value) { }

	// RVA: 0x10F3B5C Offset: 0x10F3B5C VA: 0x10F3B5C
	public float get_DDCGCDDAHCFGAAA() { }

	// RVA: 0x10F3B64 Offset: 0x10F3B64 VA: 0x10F3B64
	private void set_DDCGCDDAHCFGAAA(float value) { }

	// RVA: 0x10F3B6C Offset: 0x10F3B6C VA: 0x10F3B6C
	public PlayerSoundController get_EBGAGEHBBCBACAB() { }

	// RVA: 0x10F3B74 Offset: 0x10F3B74 VA: 0x10F3B74
	private void set_EBGAGEHBBCBACAB(PlayerSoundController value) { }

	// RVA: 0x10F3B7C Offset: 0x10F3B7C VA: 0x10F3B7C
	public PlayerMainCamera get_EBBGHCEGFEGADCC() { }

	// RVA: 0x10F3B84 Offset: 0x10F3B84 VA: 0x10F3B84
	public PlayerFPSCamera get_HDEEHEHCBECFHBA() { }

	// RVA: 0x10F3B8C Offset: 0x10F3B8C VA: 0x10F3B8C
	public SkinnedMeshLodGroup get_EGHCBHHCCBGEGAF() { }

	// RVA: 0x10F3B94 Offset: 0x10F3B94 VA: 0x10F3B94
	private void set_EGHCBHHCCBGEGAF(SkinnedMeshLodGroup value) { }

	// RVA: 0x10F3B9C Offset: 0x10F3B9C VA: 0x10F3B9C
	public CharacterLodGroup get_HGAHDFGGHAFGEFB() { }

	// RVA: 0x10F3BA4 Offset: 0x10F3BA4 VA: 0x10F3BA4
	private void set_HGAHDFGGHAFGEFB(CharacterLodGroup value) { }

	// RVA: 0x10F3BB4 Offset: 0x10F3BB4 VA: 0x10F3BB4
	public bool get_CCGFHBGBCBDBFDD() { }

	// RVA: 0x10F3BBC Offset: 0x10F3BBC VA: 0x10F3BBC
	private void set_CCGFHBGBCBDBFDD(bool value) { }

	// RVA: 0x10F3BC8 Offset: 0x10F3BC8 VA: 0x10F3BC8
	public bool get_EBEABDDAEGGDCAH() { }

	// RVA: 0x10F3BD0 Offset: 0x10F3BD0 VA: 0x10F3BD0
	private void set_EBEABDDAEGGDCAH(bool value) { }

	// RVA: 0x10F3BDC Offset: 0x10F3BDC VA: 0x10F3BDC
	public bool get_BEAGHGCHBCAGGDH() { }

	// RVA: 0x10F3C98 Offset: 0x10F3C98 VA: 0x10F3C98
	public Transform get_FAFCFFABDEEBFAH() { }

	// RVA: 0x10F3D2C Offset: 0x10F3D2C VA: 0x10F3D2C
	public BAAFADDFCADEHEA get_GECAGBEAEBCFFAC() { }

	// RVA: 0x10F3D34 Offset: 0x10F3D34 VA: 0x10F3D34
	private void set_GECAGBEAEBCFFAC(BAAFADDFCADEHEA value) { }

	// RVA: 0x10F3D3C Offset: 0x10F3D3C VA: 0x10F3D3C
	public PhotonView get_FBDCEGCEGEBCACB() { }

	// RVA: 0x10F3D44 Offset: 0x10F3D44 VA: 0x10F3D44
	private void set_FBDCEGCEGEBCACB(PhotonView value) { }

	// RVA: 0x10F3D54 Offset: 0x10F3D54 VA: 0x10F3D54
	public int get_HDEEAEBEFHFHHDB() { }

	// RVA: 0x10F3D5C Offset: 0x10F3D5C VA: 0x10F3D5C
	private void set_HDEEAEBEFHFHHDB(int value) { }

	// RVA: 0x10F3D64 Offset: 0x10F3D64 VA: 0x10F3D64
	public int get_DDAAEECEBADEDBF() { }

	// RVA: 0x10F3D6C Offset: 0x10F3D6C VA: 0x10F3D6C
	private void set_DDAAEECEBADEDBF(int value) { }

	// RVA: 0x10F3D74 Offset: 0x10F3D74 VA: 0x10F3D74
	public PhotonPlayer get_HBBBCEFBCFEFBBA() { }

	// RVA: 0x10F3D7C Offset: 0x10F3D7C VA: 0x10F3D7C
	private void set_HBBBCEFBCFEFBBA(PhotonPlayer value) { }

	// RVA: 0x10F3D8C Offset: 0x10F3D8C VA: 0x10F3D8C
	private static void .cctor() { }

	// RVA: 0x10F3E80 Offset: 0x10F3E80 VA: 0x10F3E80
	public float DGFGBABDHABEBDH() { }

	// RVA: 0x10F3E88 Offset: 0x10F3E88 VA: 0x10F3E88
	private void FGFAGDBGCEEAGCF(float HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3E90 Offset: 0x10F3E90 VA: 0x10F3E90
	public AimController HEFEDBDABADHDGC() { }

	// RVA: 0x10F3E98 Offset: 0x10F3E98 VA: 0x10F3E98
	private void BHHHAGBEBCDGGDF(AimController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3EA0 Offset: 0x10F3EA0 VA: 0x10F3EA0
	public WeaponryController HGDFACGHFDFDABE() { }

	// RVA: 0x10F3EA8 Offset: 0x10F3EA8 VA: 0x10F3EA8
	private void EBCHAHGHAGBBGDH(WeaponryController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3EB0 Offset: 0x10F3EB0 VA: 0x10F3EB0
	public MecanimController BFDECBEAGBGCCDB() { }

	// RVA: 0x10F3EB8 Offset: 0x10F3EB8 VA: 0x10F3EB8
	private void AADFFDGDFHBBECG(MecanimController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3EC0 Offset: 0x10F3EC0 VA: 0x10F3EC0
	public MovementController AHGEHCDACDDCDCG() { }

	// RVA: 0x10F3EC8 Offset: 0x10F3EC8 VA: 0x10F3EC8
	private void GACHEEHCGHHAHAG(MovementController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3ED0 Offset: 0x10F3ED0 VA: 0x10F3ED0
	public ArmsAnimationController DCCACAHADAHHEEA() { }

	// RVA: 0x10F3ED8 Offset: 0x10F3ED8 VA: 0x10F3ED8
	private void ECEFFHDAGEFHHDC(ArmsAnimationController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3EE0 Offset: 0x10F3EE0 VA: 0x10F3EE0
	public PlayerHitController GEEBFDHEDBDEDFB() { }

	// RVA: 0x10F3EE8 Offset: 0x10F3EE8 VA: 0x10F3EE8
	private void CHGAHFGGCEAEGGA(PlayerHitController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3EF0 Offset: 0x10F3EF0 VA: 0x10F3EF0
	public PlayerOcclusionController GGGGEABGEGEGGBD() { }

	// RVA: 0x10F3EF8 Offset: 0x10F3EF8 VA: 0x10F3EF8
	private void HBEFHDHGAADBDCH(PlayerOcclusionController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F00 Offset: 0x10F3F00 VA: 0x10F3F00
	public NetworkController CFGCDEGDBCCDAGC() { }

	// RVA: 0x10F3F08 Offset: 0x10F3F08 VA: 0x10F3F08
	private void ECACGAGGHFBEGBA(NetworkController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F10 Offset: 0x10F3F10 VA: 0x10F3F10
	public ArmsLodGroup GEDCDABGFFCDCEE() { }

	// RVA: 0x10F3F18 Offset: 0x10F3F18 VA: 0x10F3F18
	private void AHBGGEHHBCDCBAH(ArmsLodGroup HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F20 Offset: 0x10F3F20 VA: 0x10F3F20
	public BipedMap CGFDDDAEAAEGDFF() { }

	// RVA: 0x10F3F28 Offset: 0x10F3F28 VA: 0x10F3F28
	private void GEBBBBBHCEHGDFH(BipedMap HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F30 Offset: 0x10F3F30 VA: 0x10F3F30
	public GameObject GEBCGGEBCGDFCFH() { }

	// RVA: 0x10F3F38 Offset: 0x10F3F38 VA: 0x10F3F38
	public Transform HEBEACABDGHDCDG() { }

	// RVA: 0x10F3F40 Offset: 0x10F3F40 VA: 0x10F3F40
	public BipedMap HDACGADFHEFHDGB() { }

	// RVA: 0x10F3F48 Offset: 0x10F3F48 VA: 0x10F3F48
	public bool GADGBDDEHGFGHGA() { }

	// RVA: 0x10F3F50 Offset: 0x10F3F50 VA: 0x10F3F50
	private void FAEFFAHCGEEGBHE(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F5C Offset: 0x10F3F5C VA: 0x10F3F5C
	public bool FHAGDGHGECDCDHF() { }

	// RVA: 0x10F3F64 Offset: 0x10F3F64 VA: 0x10F3F64
	public void CGBCHEEBBEEFAEH(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F70 Offset: 0x10F3F70 VA: 0x10F3F70
	public float GEEEGCHHEGFGEAH() { }

	// RVA: 0x10F3F78 Offset: 0x10F3F78 VA: 0x10F3F78
	private void AGCAABCABEFCDAD(float HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F80 Offset: 0x10F3F80 VA: 0x10F3F80
	public PlayerSoundController AFDGHFBEFADEFCE() { }

	// RVA: 0x10F3F88 Offset: 0x10F3F88 VA: 0x10F3F88
	private void HGEBEGCBADCAFCH(PlayerSoundController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3F90 Offset: 0x10F3F90 VA: 0x10F3F90
	public PlayerMainCamera GCFDFHFEBHGAGGA() { }

	// RVA: 0x10F3F98 Offset: 0x10F3F98 VA: 0x10F3F98
	public PlayerFPSCamera EAFEBDCCCGACBDE() { }

	// RVA: 0x10F3FA0 Offset: 0x10F3FA0 VA: 0x10F3FA0
	public SkinnedMeshLodGroup HEFDFAHBEGGHFGC() { }

	// RVA: 0x10F3FA8 Offset: 0x10F3FA8 VA: 0x10F3FA8
	private void ACEDAHEBFHBDGBA(SkinnedMeshLodGroup HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3FB0 Offset: 0x10F3FB0 VA: 0x10F3FB0
	public CharacterLodGroup EAHAHEEEBFDEDEE() { }

	// RVA: 0x10F3FB8 Offset: 0x10F3FB8 VA: 0x10F3FB8
	private void DDFEDAHEAFCDFCE(CharacterLodGroup HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3FC8 Offset: 0x10F3FC8 VA: 0x10F3FC8
	public bool DEBHCBCBGCFFEGD() { }

	// RVA: 0x10F3FD0 Offset: 0x10F3FD0 VA: 0x10F3FD0
	private void GCFCCCCBCBCFFEB(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3FDC Offset: 0x10F3FDC VA: 0x10F3FDC
	public bool ACDGAFHAGCEGGAA() { }

	// RVA: 0x10F3FE4 Offset: 0x10F3FE4 VA: 0x10F3FE4
	private void FHFGBAEEFHEEBEB(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x10F3FF0 Offset: 0x10F3FF0 VA: 0x10F3FF0
	public void GGFHGHDEHFFEHHA(BipedMap EBFBCHHHDACHBGC, BipedMap GEDHBHHBCFFDBBA) { }

	// RVA: 0x10F4724 Offset: 0x10F4724 VA: 0x10F4724
	private void FBHAEBEFFDGFFCE(BipedMap GEDHBHHBCFFDBBA) { }

	// RVA: 0x10F4594 Offset: 0x10F4594 VA: 0x10F4594
	private void GEGDBCCAFCDHEAH(BipedMap EBFBCHHHDACHBGC) { }

	// RVA: 0x10F48B4 Offset: 0x10F48B4 VA: 0x10F48B4
	public void CGEGDGDACCBGCBH(Team FCFFBABADHDCFHG) { }

	// RVA: 0x10F2428 Offset: 0x10F2428 VA: 0x10F2428
	public void CCCFBGFEEHECFDB() { }

	// RVA: 0x10F3BE0 Offset: 0x10F3BE0 VA: 0x10F3BE0
	public bool EBAFBAAAFBBBAEE() { }

	// RVA: 0x10F5008 Offset: 0x10F5008 VA: 0x10F5008
	public void GECBFGCDEEHCDHB() { }

	// RVA: 0x10F4948 Offset: 0x10F4948 VA: 0x10F4948
	public void BECHDBFGDADCGDD() { }

	// RVA: 0x10F533C Offset: 0x10F533C VA: 0x10F533C
	public void GEHGCABBEEFBACE() { }

	// RVA: 0x10F503C Offset: 0x10F503C VA: 0x10F503C
	private void CEDCECGCDFGHDDG(BipedMap DGADAHHHACHEHBE) { }

	// RVA: 0x10F5258 Offset: 0x10F5258 VA: 0x10F5258
	private void GGADDHHDAFHCHGD(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x10F4A3C Offset: 0x10F4A3C VA: 0x10F4A3C
	public void EDAHHFEDHEEABHD(bool EEBCHBHEBGCADGB) { }

	// RVA: -1 Offset: -1
	public T CDBFBGCCBCGHFEC<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A1812C Offset: 0x1A1812C VA: 0x1A1812C
	|-PlayerController.CDBFBGCCBCGHFEC<object>
	*/

	// RVA: 0x10F3C9C Offset: 0x10F3C9C VA: 0x10F3C9C
	public Transform EDCEFGEGAHEAAEG() { }

	// RVA: 0x10F5368 Offset: 0x10F5368 VA: 0x10F5368
	public void AAEDEDCEDCADEBG() { }

	// RVA: 0x10F5C14 Offset: 0x10F5C14 VA: 0x10F5C14
	public void GEBAGADCEGCGHBG() { }

	// RVA: 0x10F5D98 Offset: 0x10F5D98 VA: 0x10F5D98 Slot: 64
	public void CHHEHCHAHBHCDEB() { }

	// RVA: 0x10F5E04 Offset: 0x10F5E04 VA: 0x10F5E04 Slot: 65
	public void HFEDGHGHGCGFDGF() { }

	// RVA: 0x10F5E08 Offset: 0x10F5E08 VA: 0x10F5E08 Slot: 66
	public void DBHBDCGBHBEHDBE() { }

	// RVA: 0x10F5E0C Offset: 0x10F5E0C VA: 0x10F5E0C Slot: 62
	public void EBHBHGBABFGFHBC() { }

	// RVA: 0x10F5E90 Offset: 0x10F5E90 VA: 0x10F5E90 Slot: 63
	public void GEEEAABCFDACEAG() { }

	// RVA: 0x10F5E94 Offset: 0x10F5E94 VA: 0x10F5E94
	public void CGHFFBCFCHHCAAA(Camera EGDFFCEBDFEEADG) { }

	// RVA: 0x10F6174 Offset: 0x10F6174 VA: 0x10F6174
	public void FGDEHHDDEDFFEBB() { }

	// RVA: 0x10F6180 Offset: 0x10F6180 VA: 0x10F6180
	public void FCFEGFHHFHHBDDE(Camera FHDGCAFCAEFCEHE) { }

	// RVA: 0x10F62D4 Offset: 0x10F62D4 VA: 0x10F62D4
	public void DHEEAEBCFCFBBDG() { }

	// RVA: 0x10F62E0 Offset: 0x10F62E0 VA: 0x10F62E0
	public void AHBCDFDCDAGBHEG(FBHDDCEBDBGFDEC AEECDFEGHHHBHHA, float GBGBBEFGCGEABGC) { }

	// RVA: 0x10F257C Offset: 0x10F257C VA: 0x10F257C
	public void HAEEFHHBFEEGFHH(ECEAGBDEHCHEGAA GGEEBBBHEHACHFF) { }

	// RVA: 0x10F3860 Offset: 0x10F3860 VA: 0x10F3860
	public ECEAGBDEHCHEGAA CCHAAGHDDABHDDC() { }

	// RVA: 0x10F6590 Offset: 0x10F6590 VA: 0x10F6590
	public BAAFADDFCADEHEA BGFDHCBAHHEBEHE() { }

	// RVA: 0x10F6598 Offset: 0x10F6598 VA: 0x10F6598
	private void DDDCEAABGBHDADC(BAAFADDFCADEHEA HFACGHHBHBFFFDE) { }

	// RVA: 0x10F65A0 Offset: 0x10F65A0 VA: 0x10F65A0
	private void EGAECDFFFDEBFGH(HACDCDGHHBCEHBG HBCFHACHFHBHDEH) { }

	// RVA: 0x10F6798 Offset: 0x10F6798 VA: 0x10F6798
	private void Update() { }

	// RVA: 0x10F6800 Offset: 0x10F6800 VA: 0x10F6800
	private void LateUpdate() { }

	// RVA: 0x10F6868 Offset: 0x10F6868 VA: 0x10F6868 Slot: 44
	public override void OnPhotonInstantiate(PhotonMessageInfo BGGCCDEBDDEBDCB) { }

	// RVA: 0x10F6AC4 Offset: 0x10F6AC4 VA: 0x10F6AC4
	public void AFFBBFBAEAFDCEA(int CFGBEEBFDDFHABB, int HDEDCHBADEECAGE, bool EHFACDFBHGGHAFA, bool FAHADAFBBBADHGA, float GGAFDFECFHFAGEH) { }

	[PunRPC]
	// RVA: 0x10F6E78 Offset: 0x10F6E78 VA: 0x10F6E78
	private void InstantiateViaServer(int CFGBEEBFDDFHABB, int HDEDCHBADEECAGE, bool EHFACDFBHGGHAFA, bool FAHADAFBBBADHGA, float GGAFDFECFHFAGEH, PhotonMessageInfo EFGAFHBBGFDFDDF) { }

	// RVA: 0x10F7030 Offset: 0x10F7030 VA: 0x10F7030
	public void EHGGBFABBAHFGHF(int HDEDCHBADEECAGE, bool EHFACDFBHGGHAFA) { }

	[PunRPC]
	// RVA: 0x10F741C Offset: 0x10F741C VA: 0x10F741C
	public void SetArmorViaServer(int HDEDCHBADEECAGE, bool EHFACDFBHGGHAFA) { }

	// RVA: 0x10F74C0 Offset: 0x10F74C0 VA: 0x10F74C0
	public void CCHHFFDCBDCECBH() { }

	[PunRPC]
	// RVA: 0x10F75E0 Offset: 0x10F75E0 VA: 0x10F75E0
	private void CancelUntouchableViaServer() { }

	// RVA: 0x10F7678 Offset: 0x10F7678 VA: 0x10F7678
	public PhotonView CCDECEHHGCFFDEH() { }

	// RVA: 0x10F7680 Offset: 0x10F7680 VA: 0x10F7680
	private void AGHBECABDHEGGCA(PhotonView HFACGHHBHBFFFDE) { }

	// RVA: 0x10F7690 Offset: 0x10F7690 VA: 0x10F7690
	public int CDDBCBFGHBAADBC() { }

	// RVA: 0x10F7698 Offset: 0x10F7698 VA: 0x10F7698
	private void GHGGFEBBHCHGHHB(int HFACGHHBHBFFFDE) { }

	// RVA: 0x10F76A0 Offset: 0x10F76A0 VA: 0x10F76A0
	public int CGEGCDHHGGAGFFE() { }

	// RVA: 0x10F76A8 Offset: 0x10F76A8 VA: 0x10F76A8
	private void HAFACGEGCGBBDGF(int HFACGHHBHBFFFDE) { }

	// RVA: 0x10F76B0 Offset: 0x10F76B0 VA: 0x10F76B0
	public PhotonPlayer HAAGEDGBEHBBGFB() { }

	// RVA: 0x10F76B8 Offset: 0x10F76B8 VA: 0x10F76B8
	private void AAFDCHHGCDHDHGG(PhotonPlayer HFACGHHBHBFFFDE) { }

	// RVA: 0x10F6E04 Offset: 0x10F6E04 VA: 0x10F6E04
	public int DBFFGFDBGBFGEEE() { }

	// RVA: 0x10F76C8 Offset: 0x10F76C8 VA: 0x10F76C8
	public int HHBBHBBAHDDFFCC() { }

	// RVA: 0x10F773C Offset: 0x10F773C VA: 0x10F773C
	public bool BFHCBGHEGHCFFAC() { }

	// RVA: 0x10F77D0 Offset: 0x10F77D0 VA: 0x10F77D0
	public int AHAAFHEDHGHGHCE() { }

	// RVA: 0x10F785C Offset: 0x10F785C VA: 0x10F785C
	public bool AECDGDFACEDFACG() { }

	// RVA: 0x10F78D0 Offset: 0x10F78D0 VA: 0x10F78D0
	public bool BHAHEDHEEEEGECG() { }

	// RVA: 0x10F7950 Offset: 0x10F7950 VA: 0x10F7950
	public Team GAHGFGCGCCDBCGG() { }

	// RVA: 0x10F6FC0 Offset: 0x10F6FC0 VA: 0x10F6FC0
	public int BDEGEBDHDCHFCFA() { }

	// RVA: 0x10F7958 Offset: 0x10F7958 VA: 0x10F7958
	public int CCBDHDDFCGHCCDH() { }

	// RVA: 0x10F79C8 Offset: 0x10F79C8 VA: 0x10F79C8
	public void FBGHECCHCBFAFFF() { }

	// RVA: 0x10F7A80 Offset: 0x10F7A80 VA: 0x10F7A80
	public void GFDEHGCFHEBEDFE() { }

	[PunRPC]
	// RVA: 0x10F7B30 Offset: 0x10F7B30 VA: 0x10F7B30
	private void DieViaServer() { }

	// RVA: 0x10F7BFC Offset: 0x10F7BFC VA: 0x10F7BFC
	public void FAEDFHHCADCEEDH(Vector3 EBGFBCHAABCEHGF) { }

	// RVA: 0x10F7D24 Offset: 0x10F7D24 VA: 0x10F7D24
	public void CCFDHEAEADHBCCD() { }

	// RVA: 0x10F7E04 Offset: 0x10F7E04 VA: 0x10F7E04
	public void CDFCBABEBBCEDCE(Team FCFFBABADHDCFHG) { }

	// RVA: 0x10F7E0C Offset: 0x10F7E0C VA: 0x10F7E0C
	public bool EEHDFBEACDDBFEG(out FHACHBCDFGEGCFF AFAEGEBEFCDBHDH) { }

	// RVA: 0x10F7EEC Offset: 0x10F7EEC VA: 0x10F7EEC
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Player
public class PlayerMainCamera : MonoBehaviour // TypeDefIndex: 2783
{
	// Fields
	private static PlayerMainCamera GFEDEBEDGGFGCHA; // 0x0
	private Camera HBDEBCBFEEGABFB; // 0x18
	private CameraScopeZoomer BBDDGBFCGHAEBDF; // 0x20
	private CameraAnimationController CECFDHDAHCHADDH; // 0x28
	private Transform CBCBGACGGECGEAA; // 0x30
	private MainCamera CEHBGAFBGBCFCAC; // 0x38
	private PlayerController EBEGGBGAEAHAGFC; // 0x40

	// Properties
	public static PlayerMainCamera HGGHFBCAGEEGBDH { get; }
	public static bool FGADBEBDBFFCGDF { get; }
	public bool AEHAFADHHCDCBFH { get; }
	public Transform FAFCFFABDEEBFAH { get; }
	public Camera CBCAFCBCCBHHBHB { get; }
	public PlayerController FDGHEEAGGDGCGAE { get; set; }

	// Methods

	// RVA: 0x10F7EF4 Offset: 0x10F7EF4 VA: 0x10F7EF4
	public static PlayerMainCamera get_HGGHFBCAGEEGBDH() { }

	// RVA: 0x10F8038 Offset: 0x10F8038 VA: 0x10F8038
	public static bool get_FGADBEBDBFFCGDF() { }

	// RVA: 0x10F80B4 Offset: 0x10F80B4 VA: 0x10F80B4
	public bool get_AEHAFADHHCDCBFH() { }

	// RVA: 0x10F8118 Offset: 0x10F8118 VA: 0x10F8118
	public Transform get_FAFCFFABDEEBFAH() { }

	// RVA: 0x10F81AC Offset: 0x10F81AC VA: 0x10F81AC
	public Camera get_CBCAFCBCCBHHBHB() { }

	// RVA: 0x10F81B4 Offset: 0x10F81B4 VA: 0x10F81B4
	public PlayerController get_FDGHEEAGGDGCGAE() { }

	// RVA: 0x10F81BC Offset: 0x10F81BC VA: 0x10F81BC
	private void set_FDGHEEAGGDGCGAE(PlayerController value) { }

	// RVA: 0x10F7EF8 Offset: 0x10F7EF8 VA: 0x10F7EF8
	public static PlayerMainCamera GHAFGAACAEHABEF() { }

	// RVA: 0x10F803C Offset: 0x10F803C VA: 0x10F803C
	public static bool BHEGDADECBCGDGB() { }

	// RVA: 0x10F81C4 Offset: 0x10F81C4 VA: 0x10F81C4
	private void Awake() { }

	// RVA: 0x10F80B8 Offset: 0x10F80B8 VA: 0x10F80B8
	public bool BHHEGBECGHFCFEA() { }

	// RVA: 0x10F811C Offset: 0x10F811C VA: 0x10F811C
	public Transform EDCEFGEGAHEAAEG() { }

	// RVA: 0x10F8310 Offset: 0x10F8310 VA: 0x10F8310
	public Camera DHEEEGHFCFCECHB() { }

	// RVA: 0x10F8318 Offset: 0x10F8318 VA: 0x10F8318
	public PlayerController GEHFFEBHCHECCEB() { }

	// RVA: 0x10F8320 Offset: 0x10F8320 VA: 0x10F8320
	private void DDBGCGFHHCDEAFF(PlayerController HFACGHHBHBFFFDE) { }

	// RVA: 0x10F5FE4 Offset: 0x10F5FE4 VA: 0x10F5FE4
	public void BGADHBFFFHEGDGC(PlayerController HAFBEEFEADGHFCA, Transform FECFBGABGGFAABB) { }

	// RVA: 0x10F6648 Offset: 0x10F6648 VA: 0x10F6648
	public void BHACAECADBAFCEA(HACDCDGHHBCEHBG HBCFHACHFHBHDEH) { }

	// RVA: 0x10F8328 Offset: 0x10F8328 VA: 0x10F8328
	public void GBBGGCEABHHHHFB() { }

	// RVA: 0x10F83AC Offset: 0x10F83AC VA: 0x10F83AC
	public void HGHGEGECADBGGHH() { }

	// RVA: 0x10F5CC0 Offset: 0x10F5CC0 VA: 0x10F5CC0
	public void AAHAFFBFEBDFDDC() { }

	// RVA: 0x10F8430 Offset: 0x10F8430 VA: 0x10F8430
	public bool AFAADABFGFAHDEC(Vector3 GADGBCDEGEHCGBH, float DFHABCDHBFHDDEA) { }

	// RVA: 0x10F849C Offset: 0x10F849C VA: 0x10F849C
	public bool BAABAAFGHBCEDCA(Vector3 GADGBCDEGEHCGBH) { }

	// RVA: 0x10F855C Offset: 0x10F855C VA: 0x10F855C
	public bool CBFGCEGDBCBGGGA(int ADAFCEFBEDHAHEH) { }

	// RVA: 0x10F85A0 Offset: 0x10F85A0 VA: 0x10F85A0
	public GCAFCFFCGHHHFAE FBCDCGDBEBCFEBC(PhotonPlayer FGDHCHEFDAEGFFD) { }

	// RVA: 0x10F867C Offset: 0x10F867C VA: 0x10F867C
	public GCAFCFFCGHHHFAE FBCDCGDBEBCFEBC(PlayerController FGDHCHEFDAEGFFD) { }

	// RVA: 0x10F8774 Offset: 0x10F8774 VA: 0x10F8774
	private void OnDestroy() { }

	// RVA: 0x10F87C8 Offset: 0x10F87C8 VA: 0x10F87C8
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.BHBCEBEDGHECEBG : MulticastDelegate // TypeDefIndex: 2784
{
	// Methods

	// RVA: 0x10FC248 Offset: 0x10FC248 VA: 0x10FC248
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10FC384 Offset: 0x10FC384 VA: 0x10FC384 Slot: 12
	public virtual void Invoke(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x10FC398 Offset: 0x10FC398 VA: 0x10FC398 Slot: 13
	public virtual IAsyncResult BeginInvoke(PlayerController HAFBEEFEADGHFCA, AsyncCallback callback, object object) { }

	// RVA: 0x10FC3B8 Offset: 0x10FC3B8 VA: 0x10FC3B8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerManager.DEACEHAEDHGEAAB // TypeDefIndex: 2785
{
	// Fields
	public PlayerController playerController; // 0x10

	// Methods

	// RVA: 0x10FC3C4 Offset: 0x10FC3C4 VA: 0x10FC3C4
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.HFFFFABFGCHAGEF // TypeDefIndex: 2786
{
	// Fields
	public ECEHEFCBCDBECAF listener; // 0x10
	public PlayerManager.DEACEHAEDHGEAAB CS_0024_003C_003E8__locals1; // 0x18

	// Methods

	// RVA: 0x10FC3CC Offset: 0x10FC3CC VA: 0x10FC3CC
	internal void HBDGEHHDAHCEBDC() { }

	// RVA: 0x10FC480 Offset: 0x10FC480 VA: 0x10FC480
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.BEHDBFAAFFEBGBA // TypeDefIndex: 2787
{
	// Fields
	public ECEHEFCBCDBECAF listener; // 0x10
	public PlayerManager _003C_003E4__this; // 0x18

	// Methods

	// RVA: 0x10FC488 Offset: 0x10FC488 VA: 0x10FC488
	internal void FAEHDHGDCBFAFFD() { }

	// RVA: 0x10FC540 Offset: 0x10FC540 VA: 0x10FC540
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.ABFFFHGGBCFDDGD // TypeDefIndex: 2788
{
	// Fields
	public PlayerController controller; // 0x10

	// Methods

	// RVA: 0x10FC548 Offset: 0x10FC548 VA: 0x10FC548
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.GEHBBDGBEHHBDDE // TypeDefIndex: 2789
{
	// Fields
	public ECEHEFCBCDBECAF listener; // 0x10
	public PlayerManager.ABFFFHGGBCFDDGD CS_0024_003C_003E8__locals1; // 0x18

	// Methods

	// RVA: 0x10FC550 Offset: 0x10FC550 VA: 0x10FC550
	internal void FDCHHDHFCDABCHB() { }

	// RVA: 0x10FC604 Offset: 0x10FC604 VA: 0x10FC604
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.CHGEFBGEEDADHCE // TypeDefIndex: 2790
{
	// Fields
	public PlayerController playerController; // 0x10

	// Methods

	// RVA: 0x10FC60C Offset: 0x10FC60C VA: 0x10FC60C
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.BGAGHGAAAEDEBAG // TypeDefIndex: 2791
{
	// Fields
	public ECEHEFCBCDBECAF listener; // 0x10
	public PlayerManager.CHGEFBGEEDADHCE CS_0024_003C_003E8__locals1; // 0x18

	// Methods

	// RVA: 0x10FC614 Offset: 0x10FC614 VA: 0x10FC614
	internal void DFBACFGAAFGADFE() { }

	// RVA: 0x10FC6C8 Offset: 0x10FC6C8 VA: 0x10FC6C8
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.FFEABEFGFDDFGBF // TypeDefIndex: 2792
{
	// Fields
	public GameObject playerObject; // 0x10

	// Methods

	// RVA: 0x10FC6D0 Offset: 0x10FC6D0 VA: 0x10FC6D0
	internal bool FAEADFDHDGFDBDA(PlayerController c) { }

	// RVA: 0x10FC750 Offset: 0x10FC750 VA: 0x10FC750
	public void .ctor() { }
}

// Namespace: 
public sealed class PlayerManager.EHHBAEGEEDDDCFD // TypeDefIndex: 2793
{
	// Fields
	public KeyValuePair<string, EFADFDHBADHAHEA> pair; // 0x10

	// Methods

	// RVA: 0x10FC758 Offset: 0x10FC758 VA: 0x10FC758
	internal string HBAABFBAFFFHGHF(string skin) { }

	// RVA: 0x10FC7C0 Offset: 0x10FC7C0 VA: 0x10FC7C0
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Player
public class PlayerManager : LazySingleton<PlayerManager> // TypeDefIndex: 2794
{
	// Fields
	private static readonly FDFDGBABCCCGEFE EDDFBAGEBAHEDCE; // 0x0
	private int HDECEHHEDCHFABH; // 0x18
	private readonly Dictionary<int, PlayerController> EGFHHEBHAAGBBDB; // 0x20
	private readonly HashSet<PlayerController> FBHAHGDECHGBHEE; // 0x28
	private readonly Dictionary<string, Material> BHEEFGDEEHCFCBF; // 0x30
	private readonly HashSet<ECEHEFCBCDBECAF> BDHGHDCFBBGEGHE; // 0x38
	private PlayerManager.BHBCEBEDGHECEBG DDAACCCDBEDBCEC__BackingField; // 0x40
	private PlayerManager.BHBCEBEDGHECEBG DGDFEHDGAFCFEHD__BackingField; // 0x48
	private Action<PlayerController, ECEAGBDEHCHEGAA> HABCACAAAHCECHH__BackingField; // 0x50
	private readonly List<Type> AFGBBEAFGFFHFBG; // 0x58
	private bool ADBEHHHCBDGFEDC; // 0x60
	private PlayerController GGDCHEBHBGHBFFG; // 0x68
	private PlayerController EAEBHEFADHBBHHG; // 0x70
	public Dictionary<string, EFADFDHBADHAHEA> Pools; // 0x78

	// Properties
	public HashSet<PlayerController> CEADFCHEEGGGDHC { get; }
	internal PlayerController DEEBDAFCBHCGFBA { get; set; }
	public PlayerController HEHGCFGHADFHHGH { get; set; }
	private bool CFAACBCCFHGGEAA { get; }

	// Methods

	// RVA: 0x10F87D0 Offset: 0x10F87D0 VA: 0x10F87D0
	private static void .cctor() { }

	// RVA: 0x10F88A4 Offset: 0x10F88A4 VA: 0x10F88A4
	public void .ctor() { }

	// RVA: 0x10F8AD8 Offset: 0x10F8AD8 VA: 0x10F8AD8
	public HashSet<PlayerController> get_CEADFCHEEGGGDHC() { }

	// RVA: 0x10F8AE0 Offset: 0x10F8AE0 VA: 0x10F8AE0
	internal PlayerController get_DEEBDAFCBHCGFBA() { }

	// RVA: 0x10F8AE8 Offset: 0x10F8AE8 VA: 0x10F8AE8
	private void set_DEEBDAFCBHCGFBA(PlayerController value) { }

	// RVA: 0x10F8AF0 Offset: 0x10F8AF0 VA: 0x10F8AF0
	public PlayerController get_HEHGCFGHADFHHGH() { }

	// RVA: 0x10F8AF8 Offset: 0x10F8AF8 VA: 0x10F8AF8
	private void set_HEHGCFGHADFHHGH(PlayerController value) { }

	// RVA: 0x10F8B00 Offset: 0x10F8B00 VA: 0x10F8B00
	private bool get_CFAACBCCFHGGEAA() { }

	// RVA: 0x10F8BD4 Offset: 0x10F8BD4 VA: 0x10F8BD4
	public void add_DDAACCCDBEDBCEC(PlayerManager.BHBCEBEDGHECEBG value) { }

	// RVA: 0x10F8C74 Offset: 0x10F8C74 VA: 0x10F8C74
	public void remove_DDAACCCDBEDBCEC(PlayerManager.BHBCEBEDGHECEBG value) { }

	// RVA: 0x10F8D14 Offset: 0x10F8D14 VA: 0x10F8D14
	public void add_DGDFEHDGAFCFEHD(PlayerManager.BHBCEBEDGHECEBG value) { }

	// RVA: 0x10F8DB4 Offset: 0x10F8DB4 VA: 0x10F8DB4
	public void remove_DGDFEHDGAFCFEHD(PlayerManager.BHBCEBEDGHECEBG value) { }

	// RVA: 0x10F8E54 Offset: 0x10F8E54 VA: 0x10F8E54
	public void add_HABCACAAAHCECHH(Action<PlayerController, ECEAGBDEHCHEGAA> value) { }

	// RVA: 0x10F8F08 Offset: 0x10F8F08 VA: 0x10F8F08
	public void remove_HABCACAAAHCECHH(Action<PlayerController, ECEAGBDEHCHEGAA> value) { }

	// RVA: 0x10F8BD8 Offset: 0x10F8BD8 VA: 0x10F8BD8
	public void FEDEBEFFACAGEAA(PlayerManager.BHBCEBEDGHECEBG HFACGHHBHBFFFDE) { }

	// RVA: 0x10F8C78 Offset: 0x10F8C78 VA: 0x10F8C78
	public void BADGECHCEACADGD(PlayerManager.BHBCEBEDGHECEBG HFACGHHBHBFFFDE) { }

	// RVA: 0x10F8D18 Offset: 0x10F8D18 VA: 0x10F8D18
	public void HGAEBDFEFCBHFGE(PlayerManager.BHBCEBEDGHECEBG HFACGHHBHBFFFDE) { }

	// RVA: 0x10F8DB8 Offset: 0x10F8DB8 VA: 0x10F8DB8
	public void BDBHBFCCECDBBGD(PlayerManager.BHBCEBEDGHECEBG HFACGHHBHBFFFDE) { }

	// RVA: 0x10F8E58 Offset: 0x10F8E58 VA: 0x10F8E58
	public void BDDCAABBEAFFBAA(Action<PlayerController, ECEAGBDEHCHEGAA> HFACGHHBHBFFFDE) { }

	// RVA: 0x10F8F0C Offset: 0x10F8F0C VA: 0x10F8F0C
	public void GBHAGCCDGACFFCF(Action<PlayerController, ECEAGBDEHCHEGAA> HFACGHHBHBFFFDE) { }

	// RVA: 0x10F8FBC Offset: 0x10F8FBC VA: 0x10F8FBC
	public void BFFHCFGEBDCCBHE(string GCAEDBAHGEGCEEF) { }

	// RVA: 0x10F9124 Offset: 0x10F9124 VA: 0x10F9124
	public void FFEFECFEEGDHHBG(Team FCFFBABADHDCFHG, string AAADHGBADBFDAGD, PlayerCharacters CBABDBBBABBDDBH, int EGFHCFCGDEDAFHB, Type[] HADFEDFCGFDEEFB, string CCBEGADHDAAFBDG, string GDHFBBGBCEDGAHG, string DAEECEHBEDFDGDA) { }

	// RVA: 0x10F936C Offset: 0x10F936C VA: 0x10F936C
	public void EECCHFFAFBEADHB(ECEHEFCBCDBECAF GCEFDCACBDGGGDF) { }

	// RVA: 0x10F93C4 Offset: 0x10F93C4 VA: 0x10F93C4
	public void CCFEADDGGDEGGAA(Type CHGFFCCAFEHFFCA) { }

	// RVA: 0x10F94EC Offset: 0x10F94EC VA: 0x10F94EC
	public void HGHCEECEHGEHDEF(ECEHEFCBCDBECAF GCEFDCACBDGGGDF) { }

	// RVA: 0x10F9544 Offset: 0x10F9544 VA: 0x10F9544
	public HashSet<PlayerController> BDDEGCBCFDGBEBH() { }

	// RVA: 0x10F954C Offset: 0x10F954C VA: 0x10F954C
	private void HFFHAGBCDCADFCD() { }

	// RVA: 0x10F9708 Offset: 0x10F9708 VA: 0x10F9708
	private void HFHHHFBEACGAFAC() { }

	// RVA: 0x10F98D8 Offset: 0x10F98D8 VA: 0x10F98D8
	public void AFFBBFBAEAFDCEA(Team FCFFBABADHDCFHG, Vector3 GADGBCDEGEHCGBH, Quaternion EHCDGFBFBDEDGEC, int CFGBEEBFDDFHABB = 100, int HDEDCHBADEECAGE = 100, bool EHFACDFBHGGHAFA = True, bool FAHADAFBBBADHGA = False, float GGAFDFECFHFAGEH = 3,4028235E+38) { }

	// RVA: 0x10F9BC8 Offset: 0x10F9BC8 VA: 0x10F9BC8
	public void AAFEEBCGGHCEEHE(Team FCFFBABADHDCFHG, string DAEECEHBEDFDGDA, Vector3 GADGBCDEGEHCGBH, Quaternion EHCDGFBFBDEDGEC, int CFGBEEBFDDFHABB = 100, int HDEDCHBADEECAGE = 100, bool EHFACDFBHGGHAFA = True, bool FAHADAFBBBADHGA = False, float GGAFDFECFHFAGEH = 3,4028235E+38) { }

	// RVA: 0x10F4D50 Offset: 0x10F4D50 VA: 0x10F4D50
	public void AAFEAAGFFDHDFDH(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x10F691C Offset: 0x10F691C VA: 0x10F691C
	public void OnPhotonInstantiate(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x10F4AD8 Offset: 0x10F4AD8 VA: 0x10F4AD8
	public void CGCGAHBDDCGGFAD(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x10FA114 Offset: 0x10FA114 VA: 0x10FA114
	private void CGCGAHBDDCGGFAD() { }

	// RVA: 0x10F54A8 Offset: 0x10F54A8 VA: 0x10F54A8
	internal void HEGCECGDEAHFFFA(PlayerController FCCGGCBDEBFABAA) { }

	// RVA: 0x10F5968 Offset: 0x10F5968 VA: 0x10F5968
	internal void BGHCADGEGAABGDC(PlayerController HAFBEEFEADGHFCA, int BHDEBDCGBCHHFBF) { }

	// RVA: 0x10F9F6C Offset: 0x10F9F6C VA: 0x10F9F6C
	private void EFFHDEHHEAHEDFG(Action AEGBFFFCFACDDBE) { }

	// RVA: 0x10F64D4 Offset: 0x10F64D4 VA: 0x10F64D4
	public void AEHEFCFFAAECAFD(PlayerController FCCGGCBDEBFABAA, ECEAGBDEHCHEGAA GGEEBBBHEHACHFF) { }

	// RVA: 0x10FA3A8 Offset: 0x10FA3A8 VA: 0x10FA3A8
	public PlayerController CDBFBGCCBCGHFEC(int ADAFCEFBEDHAHEH) { }

	// RVA: 0x10FA470 Offset: 0x10FA470 VA: 0x10FA470
	public PlayerController AHCFEGAEECHAGAF(GameObject HHBBEGDAGBEGAEG) { }

	// RVA: 0x10FA634 Offset: 0x10FA634 VA: 0x10FA634
	public bool GAEGDHDEAAGFHBG(int ADAFCEFBEDHAHEH) { }

	// RVA: 0x10FA68C Offset: 0x10FA68C VA: 0x10FA68C
	public GameObject CFGDFFAEFCDEGGE(string BHDEBDCGBCHHFBF, Vector3 GADGBCDEGEHCGBH, Quaternion EHCDGFBFBDEDGEC) { }

	// RVA: 0x10FA7C4 Offset: 0x10FA7C4 VA: 0x10FA7C4
	public void AEFFGFBDBGFBCGC(GameObject CDBBDDHAAFFFBCB) { }

	// RVA: 0x10FA92C Offset: 0x10FA92C VA: 0x10FA92C
	private EFADFDHBADHAHEA EFECFBCCHFGBEHF(Team FCFFBABADHDCFHG) { }

	// RVA: 0x10F9E84 Offset: 0x10F9E84 VA: 0x10F9E84
	private EFADFDHBADHAHEA EFECFBCCHFGBEHF(string DAEECEHBEDFDGDA) { }

	// RVA: 0x10FAA18 Offset: 0x10FAA18 VA: 0x10FAA18
	public List<string> EADDBECAAFCFHCD() { }

	// RVA: 0x10F9B14 Offset: 0x10F9B14 VA: 0x10F9B14
	public string GFFHBBDEHGGCFEB(Team FCFFBABADHDCFHG) { }

	// RVA: 0x10FACE0 Offset: 0x10FACE0 VA: 0x10FACE0
	public Material EHCFFBCCBEBFFEG(CharacterSkinnedMeshLodGroupBase EFEBFHFHGBDAAGB, Material HHFFEBEFDACBBHE) { }

	// RVA: 0x10FAE64 Offset: 0x10FAE64 VA: 0x10FAE64
	public Material EGFGCBHCGAHAGCE(CharacterLodGroup EFEBFHFHGBDAAGB, Material HHFFEBEFDACBBHE) { }

	// RVA: 0x10FB118 Offset: 0x10FB118 VA: 0x10FB118
	internal PlayerController EGBEDGADFAHCCEH() { }

	// RVA: 0x10FB120 Offset: 0x10FB120 VA: 0x10FB120
	private void DHAACHHAHHBAFBF(PlayerController HFACGHHBHBFFFDE) { }

	// RVA: 0x10FB128 Offset: 0x10FB128 VA: 0x10FB128
	public PlayerController BDCBCFGEHDEDAHC() { }

	// RVA: 0x10FB130 Offset: 0x10FB130 VA: 0x10FB130
	private void GGEFBDFGEGCDFHH(PlayerController HFACGHHBHBFFFDE) { }

	// RVA: 0x10FB138 Offset: 0x10FB138 VA: 0x10FB138
	private void OnApplicationFocus(bool AGCGDGDFEEDGFFC) { }

	// RVA: 0x10FB1C0 Offset: 0x10FB1C0 VA: 0x10FB1C0
	private void OnApplicationPause(bool CBEHAAGGECGBBCC) { }

	// RVA: 0x10F8B04 Offset: 0x10F8B04 VA: 0x10F8B04
	private bool GBBHEEHAAFEDFFC() { }
}

// Namespace: Axlebolt.Standoff.Player
public abstract class SkinnedMeshLodGroup : MonoBehaviour // TypeDefIndex: 2801
{
	// Fields
	[SerializeField]
	private int _maxLodLevel; // 0x18
	private bool GFADGGGEAGBFEHF; // 0x1C
	private Material[] GDHFDCABFBDDGGF; // 0x20
	private int AFBEBBFAABHHDFF; // 0x28

	// Properties
	public int CEHEFEAHEAEFFBB { get; }
	public bool HDCHDHCBCGAFADH { get; }
	public Material[] GBDADGFHGCDBACA { get; }

	// Methods

	// RVA: 0x10FD354 Offset: 0x10FD354 VA: 0x10FD354
	public int get_CEHEFEAHEAEFFBB() { }

	// RVA: 0x10FD35C Offset: 0x10FD35C VA: 0x10FD35C
	public bool get_HDCHDHCBCGAFADH() { }

	// RVA: 0x10FD364 Offset: 0x10FD364 VA: 0x10FD364
	public Material[] get_GBDADGFHGCDBACA() { }

	// RVA: 0x10FD36C Offset: 0x10FD36C VA: 0x10FD36C
	public int AGACACBDGHAGADB() { }

	// RVA: 0x10FD374 Offset: 0x10FD374 VA: 0x10FD374
	public void EGBHHADGAAAFEEH() { }

	// RVA: 0x10FD3E0 Offset: 0x10FD3E0 VA: 0x10FD3E0
	public void FBGFHHEAAFCBAAF() { }

	// RVA: 0x10FD3EC Offset: 0x10FD3EC VA: 0x10FD3EC
	public void BFFFEHAHHFHGABE() { }

	// RVA: 0x10FD40C Offset: 0x10FD40C VA: 0x10FD40C
	protected void BFFHCFGEBDCCBHE() { }

	// RVA: 0x10FD434 Offset: 0x10FD434 VA: 0x10FD434
	public bool AFECFDCFECFFBHA() { }

	// RVA: 0x10FD43C Offset: 0x10FD43C VA: 0x10FD43C
	public Material[] DGDBEFGDEGCGHFH() { }

	// RVA: 0x10FD380 Offset: 0x10FD380 VA: 0x10FD380
	public void EGCAACCCFGCDAFG(int ADDFDBBECCEGEAH) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void EHHAGBCCGBAHDGD(int ADDFDBBECCEGEAH);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void HAEFAGDFGBDGCGB();

	// RVA: 0x10FD444 Offset: 0x10FD444 VA: 0x10FD444 Slot: 6
	public virtual void CCAFBGBACGBGHAC(Material[] ABHAFHEGAHFBGEF) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void CFEDFDGCHAEADFE(Material ABHAFHEGAHFBGEF);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FBCHHBABHDBHFBA();

	// RVA: 0x10FD44C Offset: 0x10FD44C VA: 0x10FD44C Slot: 9
	public virtual void HDFGFFHBFAFFHGH(bool EEBCHBHEBGCADGB) { }

	// RVA: 0x10FD458 Offset: 0x10FD458 VA: 0x10FD458
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeaponryController.<>c__DisplayClass70_0 // TypeDefIndex: 2812
{
	// Fields
	public FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG; // 0x10

	// Methods

	// RVA: 0x1102904 Offset: 0x1102904 VA: 0x1102904
	public void .ctor() { }

	// RVA: 0x1103398 Offset: 0x1103398 VA: 0x1103398
	internal bool <HEFGGDGCGCBCHBG>b__0(KeyValuePair<byte, WeaponController> slot) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WeaponryController.<>c__DisplayClass73_0 // TypeDefIndex: 2813
{
	// Fields
	public FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG; // 0x10

	// Methods

	// RVA: 0x1102A34 Offset: 0x1102A34 VA: 0x1102A34
	public void .ctor() { }

	// RVA: 0x11033F4 Offset: 0x11033F4 VA: 0x11033F4
	internal bool <FACADEBFFCGFCFH>b__1(KeyValuePair<byte, WeaponController> entry) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class WeaponryController.<>c // TypeDefIndex: 2814
{
	// Fields
	public static readonly WeaponryController.<>c <>9; // 0x0
	public static Func<KeyValuePair<byte, WeaponController>, bool> <>9__73_0; // 0x8
	public static Func<KeyValuePair<byte, WeaponController>, bool> <>9__74_0; // 0x10
	public static Func<KeyValuePair<byte, WeaponController>, int> <>9__74_1; // 0x18
	public static Func<KeyValuePair<byte, WeaponController>, byte> <>9__74_2; // 0x20

	// Methods

	// RVA: 0x1103450 Offset: 0x1103450 VA: 0x1103450
	private static void .cctor() { }

	// RVA: 0x11034C0 Offset: 0x11034C0 VA: 0x11034C0
	public void .ctor() { }

	// RVA: 0x11034C8 Offset: 0x11034C8 VA: 0x11034C8
	internal bool <FACADEBFFCGFCFH>b__73_0(KeyValuePair<byte, WeaponController> entry) { }

	// RVA: 0x1103540 Offset: 0x1103540 VA: 0x1103540
	internal bool <GGDEHDDCEFCHGBA>b__74_0(KeyValuePair<byte, WeaponController> slot) { }

	// RVA: 0x110359C Offset: 0x110359C VA: 0x110359C
	internal int <GGDEHDDCEFCHGBA>b__74_1(KeyValuePair<byte, WeaponController> slot) { }

	// RVA: 0x11035F0 Offset: 0x11035F0 VA: 0x11035F0
	internal byte <GGDEHDDCEFCHGBA>b__74_2(KeyValuePair<byte, WeaponController> slot) { }
}

// Namespace: Axlebolt.Standoff.Player.Weaponry
public class WeaponryController : Controller, HGDECFHDGBAEFBB<BEEAAEECGBCECCA, FBFBGCGECGHGGBC>, BDFGFCBCEDGGFFD, FCBCBDDBDAAHCHE // TypeDefIndex: 2815
{
	// Fields
	private const string DGDACAHGCBAHHHB = "WeaponryController";
	private PlayerController DDCBCHDAAHEEHHH; // 0x50
	private MecanimController AHDDACCCDAEDHFG; // 0x58
	private bool BACCBDEGHFGCBGF; // 0x60
	private readonly Dictionary<byte, WeaponController> ABAHFBAHBHHEBBB; // 0x68
	private readonly List<WeaponController> SRSlotsScratch; // 0x70
	private byte FFCAEAFDDGGFHHD; // 0x78
	private bool HDDBGGCGECDBGFE; // 0x79
	private FFCHECDHEGDECAH[] BDHGHDCFBBGEGHE; // 0x80
	private WeaponPickupController EGGGDBGBHFDHBBC; // 0x88
	private KitController CCBDEAEEFAECCBA; // 0x90
	private WeaponController GFEDDHGAFEFCFGD; // 0x98
	private float CHDAEHHBGDDDEAD; // 0xA0
	private float HHGFDFEABBGEBEB; // 0xA4

	// Properties
	public bool FAEBGDDCDBAGHAH { get; }
	public WeaponPickupController BBACDBGDHGHDFHG { get; set; }
	public KitController GCFEDGBCBCCAHCF { get; set; }
	public WeaponController ADFFFAGDHFAHEBE { get; set; }
	public float AEGGFHEGDACDBDD { get; set; }
	public float HDDHEDGDFDCEADB { get; set; }
	public Vector3 DBDBBBGCDHEACEF { get; }
	public Vector3 ACDFAACABECEECA { get; }

	// Methods

	// RVA: 0x10FFE60 Offset: 0x10FFE60 VA: 0x10FFE60
	public bool get_FAEBGDDCDBAGHAH() { }

	// RVA: 0x10FFE68 Offset: 0x10FFE68 VA: 0x10FFE68
	public WeaponPickupController get_BBACDBGDHGHDFHG() { }

	// RVA: 0x10FFE70 Offset: 0x10FFE70 VA: 0x10FFE70
	private void set_BBACDBGDHGHDFHG(WeaponPickupController value) { }

	// RVA: 0x10FFE78 Offset: 0x10FFE78 VA: 0x10FFE78
	public KitController get_GCFEDGBCBCCAHCF() { }

	// RVA: 0x10FFE80 Offset: 0x10FFE80 VA: 0x10FFE80
	private void set_GCFEDGBCBCCAHCF(KitController value) { }

	// RVA: 0x10FFE88 Offset: 0x10FFE88 VA: 0x10FFE88
	public WeaponController get_ADFFFAGDHFAHEBE() { }

	// RVA: 0x10FFE90 Offset: 0x10FFE90 VA: 0x10FFE90
	private void set_ADFFFAGDHFAHEBE(WeaponController value) { }

	// RVA: 0x10FFE98 Offset: 0x10FFE98 VA: 0x10FFE98
	public float get_AEGGFHEGDACDBDD() { }

	// RVA: 0x10FFEA0 Offset: 0x10FFEA0 VA: 0x10FFEA0
	private void set_AEGGFHEGDACDBDD(float value) { }

	// RVA: 0x10FFEA8 Offset: 0x10FFEA8 VA: 0x10FFEA8
	public float get_HDDHEDGDFDCEADB() { }

	// RVA: 0x10FFEB0 Offset: 0x10FFEB0 VA: 0x10FFEB0
	private void set_HDDHEDGDFDCEADB(float value) { }

	// RVA: 0x10FFEB8 Offset: 0x10FFEB8 VA: 0x10FFEB8
	public Vector3 get_DBDBBBGCDHEACEF() { }

	// RVA: 0x10FFEE4 Offset: 0x10FFEE4 VA: 0x10FFEE4
	public Vector3 get_ACDFAACABECEECA() { }

	// RVA: 0x10FFF80 Offset: 0x10FFF80 VA: 0x10FFF80
	public bool GHHAGAADCDDABCA() { }

	// RVA: 0x10FFF88 Offset: 0x10FFF88 VA: 0x10FFF88
	public WeaponPickupController CBABEBHDBDDECGG() { }

	// RVA: 0x10FFF90 Offset: 0x10FFF90 VA: 0x10FFF90
	private void BFCBGBCACBABCHA(WeaponPickupController HFACGHHBHBFFFDE) { }

	// RVA: 0x10FFF98 Offset: 0x10FFF98 VA: 0x10FFF98 Slot: 63
	public override void FDEDFCDHCDGCCCD() { }

	// RVA: 0x11000A4 Offset: 0x11000A4 VA: 0x11000A4 Slot: 64
	public override void BGCCFHHGDFGCFEB(Team FCFFBABADHDCFHG) { }

	// RVA: 0x11003B8 Offset: 0x11003B8 VA: 0x11003B8
	public KitController GCGAABCAHECGHED() { }

	// RVA: 0x11003C0 Offset: 0x11003C0 VA: 0x11003C0
	private void EAGECGHCCADHHCA(KitController HFACGHHBHBFFFDE) { }

	// RVA: 0x11003C8 Offset: 0x11003C8 VA: 0x11003C8
	public WeaponController GBHCCGBAEFDGAAC() { }

	// RVA: 0x11003D0 Offset: 0x11003D0 VA: 0x11003D0
	private void HEECEGFCDHCFDCA(WeaponController HFACGHHBHBFFFDE) { }

	// RVA: 0x11003D8 Offset: 0x11003D8 VA: 0x11003D8 Slot: 66
	public override void AAEDEDCEDCADEBG() { }

	// RVA: 0x1100628 Offset: 0x1100628 VA: 0x1100628 Slot: 72
	public override void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x1100908 Offset: 0x1100908 VA: 0x1100908 Slot: 73
	public override void CGEHBBBHECABDEB(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x1100AEC Offset: 0x1100AEC VA: 0x1100AEC Slot: 79
	public void EHDGAFGBFGGHHHE() { }

	// RVA: 0x1100AF0 Offset: 0x1100AF0 VA: 0x1100AF0 Slot: 80
	public void AFFFCAHCAFCBHFG() { }

	// RVA: 0x1100B7C Offset: 0x1100B7C VA: 0x1100B7C
	public float DGFGBABDHABEBDH() { }

	// RVA: 0x1100B84 Offset: 0x1100B84 VA: 0x1100B84
	private void FGFAGDBGCEEAGCF(float HFACGHHBHBFFFDE) { }

	// RVA: 0x1100B8C Offset: 0x1100B8C VA: 0x1100B8C
	public float FBEFHHFFACAEEEF() { }

	// RVA: 0x1100B94 Offset: 0x1100B94 VA: 0x1100B94
	private void CAFACDBAGECGCDD(float HFACGHHBHBFFFDE) { }

	// RVA: 0x1100B9C Offset: 0x1100B9C VA: 0x1100B9C Slot: 76
	public void FHAGFDFBAHEACHH(FBFBGCGECGHGGBC ECCCGADGAHBEDFC, float CAGGBAGGHFFGEEF, float GCABCDEGACEABFA) { }

	// RVA: 0x110106C Offset: 0x110106C VA: 0x110106C Slot: 75
	public BEEAAEECGBCECCA CCHAAGHDDABHDDC() { }

	// RVA: 0x1101430 Offset: 0x1101430 VA: 0x1101430 Slot: 74
	public void HAEEFHHBFEEGFHH(BEEAAEECGBCECCA GGEEBBBHEHACHFF) { }

	// RVA: 0x1101480 Offset: 0x1101480 VA: 0x1101480
	private void HDGHGCBEHBGCGFH(BEEAAEECGBCECCA GGEEBBBHEHACHFF) { }

	// RVA: 0x1101BA4 Offset: 0x1101BA4 VA: 0x1101BA4
	private void ABGFBGHGCHBAEAB(BEEAAEECGBCECCA GGEEBBBHEHACHFF) { }

	// RVA: 0x1102164 Offset: 0x1102164 VA: 0x1102164
	private KitController DCGGADDDHBDGAAA(BEEAAEECGBCECCA GGEEBBBHEHACHFF) { }

	// RVA: 0x11020FC Offset: 0x11020FC VA: 0x11020FC
	private void AGHFBCDDGCADDAC() { }

	// RVA: 0x1101DEC Offset: 0x1101DEC VA: 0x1101DEC
	private WeaponController GGCFGGBDFEADEGH(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG, int GDHDFBDACDGAEEE, HCAFGHHDFAHHGDC GDHGGAGHEEEFBCB) { }

	// RVA: 0x110223C Offset: 0x110223C VA: 0x110223C
	public void GECHEGCCCFCBFFD() { }

	// RVA: 0x11022E0 Offset: 0x11022E0 VA: 0x11022E0
	public void GBBEDFCGGBGBADG() { }

	// RVA: 0x1102380 Offset: 0x1102380 VA: 0x1102380 Slot: 78
	public void FGGBFDGBHHAHEDH() { }

	// RVA: 0x1102404 Offset: 0x1102404 VA: 0x1102404 Slot: 77
	public void FBGFHCCFAGCGGFE() { }

	// RVA: 0x1100D74 Offset: 0x1100D74 VA: 0x1100D74
	private void ECDDFHAGHBGBCBA() { }

	// RVA: 0x10FF270 Offset: 0x10FF270 VA: 0x10FF270
	public void BEEAHDGDHADBCGD(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG, ADEAEEAEHFDCCHA DDEAAFGDACHCACE = 0) { }

	// RVA: 0x1100124 Offset: 0x1100124 VA: 0x1100124
	public void BEEAHDGDHADBCGD(WeaponController BFGFADDCACFBCDD, ADEAEEAEHFDCCHA DDEAAFGDACHCACE = 0) { }

	// RVA: 0x1100F48 Offset: 0x1100F48 VA: 0x1100F48
	private void FHEFFEFFDAHAFCE(byte AFCEGFFFADBHHDA, bool GHDGCBCFGFCCAFD) { }

	// RVA: 0x1102488 Offset: 0x1102488 VA: 0x1102488
	private void EECCBAGDGDGCBGH(byte AFCEGFFFADBHHDA, bool GHDGCBCFGFCCAFD) { }

	// RVA: 0x110277C Offset: 0x110277C VA: 0x110277C
	public void HEFGGDGCGCBCHBG(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG) { }

	// RVA: 0x110290C Offset: 0x110290C VA: 0x110290C
	public void BDFDGDEHCCHHAAA(byte AFCEGFFFADBHHDA) { }

	// RVA: 0x10FFDF4 Offset: 0x10FFDF4 VA: 0x10FFDF4
	public bool BGCGGCEHAEGFGBB(byte AFCEGFFFADBHHDA) { }

	// RVA: 0x10FFC54 Offset: 0x10FFC54 VA: 0x10FFC54
	public bool FACADEBFFCGFCFH(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG) { }

	// RVA: 0x1102A3C Offset: 0x1102A3C VA: 0x1102A3C
	public void GGDEHDDCEFCHGBA(Vector3 EBGFBCHAABCEHGF) { }

	// RVA: 0x10FFEBC Offset: 0x10FFEBC VA: 0x10FFEBC
	public Vector3 HBDECCBDEHBFHHA() { }

	// RVA: 0x10FFEE8 Offset: 0x10FFEE8 VA: 0x10FFEE8
	public Vector3 DEHECBAAHDFAEEG() { }

	// RVA: 0x1102F68 Offset: 0x1102F68 VA: 0x1102F68
	public WeaponController[] EEEBGCGECDBCBGD() { }

	// RVA: 0x1102FD4 Offset: 0x1102FD4 VA: 0x1102FD4
	public WeaponController DHGAHCFEGEDDCCA(byte AFCEGFFFADBHHDA) { }

	// RVA: 0x1103068 Offset: 0x1103068 VA: 0x1103068
	public GrenadeController EECEDBFFHGAEAAG() { }

	// RVA: 0x1103190 Offset: 0x1103190 VA: 0x1103190
	public WeaponController BHAGGBDFEDFBEEB() { }

	// RVA: 0x1103234 Offset: 0x1103234 VA: 0x1103234
	public byte GFFGEADAFHFBAGH() { }

	// RVA: 0x1100EC8 Offset: 0x1100EC8 VA: 0x1100EC8
	public void BCDGHGHBECAGDGG(byte AFCEGFFFADBHHDA) { }

	// RVA: 0x11032B8 Offset: 0x11032B8 VA: 0x11032B8
	public void HGGFEDBDEEFDADD() { }

	// RVA: 0x11025C4 Offset: 0x11025C4 VA: 0x11025C4
	private void DHDBGDCCBHAECCH(byte AFCEGFFFADBHHDA) { }

	// RVA: 0x1101D18 Offset: 0x1101D18 VA: 0x1101D18
	public void DGHFACDCEAACEGF(byte FDFDBGDEEEDHHDA) { }

	// RVA: 0x1101F6C Offset: 0x1101F6C VA: 0x1101F6C
	public void BCAEDAEGGEBACCD(bool EDGCDBFGCDECEBE) { }

	// RVA: 0x1101E88 Offset: 0x1101E88 VA: 0x1101E88
	private void AGBDAEAHGGAEBDD(WeaponController BFGFADDCACFBCDD) { }

	// RVA: 0x11026F4 Offset: 0x11026F4 VA: 0x11026F4
	private void BCDGHGHBECAGDGG() { }

	// RVA: 0x11032C0 Offset: 0x11032C0 VA: 0x11032C0
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Player.Occlusion
public class PlayerOcclusionController : ObjectOccludee // TypeDefIndex: 2883
{
	// Fields
	[SerializeField]
	private List<Vector2> _occlusionPoints; // 0x38
	[SerializeField]
	private List<BipedMap.HHECCBDEGAAEGAB> _obstructionPoints; // 0x40
	private CharacterController DEGCCGAHBFABFHB; // 0x48
	private Vector3[] GEEBGHBBCBHDAAG; // 0x50
	private Vector3[] EGCFGBEABHBHAHH; // 0x58
	private PlayerController EBEGGBGAEAHAGFC; // 0x60

	// Properties
	public PlayerController FDGHEEAGGDGCGAE { get; set; }

	// Methods

	// RVA: 0x111F190 Offset: 0x111F190 VA: 0x111F190
	public PlayerController get_FDGHEEAGGDGCGAE() { }

	// RVA: 0x111F198 Offset: 0x111F198 VA: 0x111F198
	private void set_FDGHEEAGGDGCGAE(PlayerController value) { }

	// RVA: 0x111F1A0 Offset: 0x111F1A0 VA: 0x111F1A0
	public PlayerController GEHFFEBHCHECCEB() { }

	// RVA: 0x111F1A8 Offset: 0x111F1A8 VA: 0x111F1A8
	private void DDBGCGFHHCDEAFF(PlayerController HFACGHHBHBFFFDE) { }

	// RVA: 0x111F1B0 Offset: 0x111F1B0 VA: 0x111F1B0 Slot: 6
	public override void GGFHGHDEHFFEHHA() { }

	// RVA: 0x111F2F4 Offset: 0x111F2F4 VA: 0x111F2F4 Slot: 11
	public override Bounds BDGEEDCBDGFCCBB() { }

	// RVA: 0x111F334 Offset: 0x111F334 VA: 0x111F334 Slot: 12
	public override Vector3[] FAHAHABCBGGGACA(Vector3 CECBGHHEHABHBBA) { }

	// RVA: 0x111F624 Offset: 0x111F624 VA: 0x111F624 Slot: 13
	public override Vector3 AGCBCHADBHGFFEG() { }

	// RVA: 0x111F654 Offset: 0x111F654 VA: 0x111F654 Slot: 14
	public override Vector3[] GFHFEHHCFHCDECE(Vector3 CECBGHHEHABHBBA) { }

	// RVA: 0x111F848 Offset: 0x111F848 VA: 0x111F848
	public void .ctor() { }
}

// Namespace: 
public sealed class MovementController.HHHCDAFDDDDDDGF : MulticastDelegate // TypeDefIndex: 2885
{
	// Methods

	// RVA: 0x1122480 Offset: 0x1122480 VA: 0x1122480
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11225BC Offset: 0x11225BC VA: 0x11225BC Slot: 12
	public virtual void Invoke(MovementController AGAAECDGBBBCDGF) { }

	// RVA: 0x11225D0 Offset: 0x11225D0 VA: 0x11225D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(MovementController AGAAECDGBBBCDGF, AsyncCallback callback, object object) { }

	// RVA: 0x11225F0 Offset: 0x11225F0 VA: 0x11225F0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class MovementController.EGGDHEEAFBHAAFD : MulticastDelegate // TypeDefIndex: 2886
{
	// Methods

	// RVA: 0x11225FC Offset: 0x11225FC VA: 0x11225FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x112273C Offset: 0x112273C VA: 0x112273C Slot: 12
	public virtual void Invoke(MovementController AGAAECDGBBBCDGF, float CHCEEBHCFDFAHCA) { }

	// RVA: 0x1122750 Offset: 0x1122750 VA: 0x1122750 Slot: 13
	public virtual IAsyncResult BeginInvoke(MovementController AGAAECDGBBBCDGF, float CHCEEBHCFDFAHCA, AsyncCallback callback, object object) { }

	// RVA: 0x11227E4 Offset: 0x11227E4 VA: 0x11227E4 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Axlebolt.Standoff.Player.Movement
[RequireComponent(typeof(MecanimController))]
[RequireComponent(typeof(PlayerController))]
public class MovementController : Controller, HGDECFHDGBAEFBB<DHHFDEABDDCFDGD, CBHBEDBDGAABGBF>, FFCHECDHEGDECAH // TypeDefIndex: 2887
{
	// Fields
	private const float EFECGFGGCEDAAHB = 0,5;
	private const int EGFGFCGCGDFEFGD = 10;
	private static readonly FDFDGBABCCCGEFE EDDFBAGEBAHEDCE; // 0x0
	private PlayerController DDCBCHDAAHEEHHH; // 0x50
	private PlayerOcclusionController AHDCBFGDDEHAEAG; // 0x58
	[SerializeField]
	private bool _neverIdle; // 0x60
	private Transform DEDFGEHFDAFFHDB; // 0x68
	private CBHBEDBDGAABGBF CBFBFHAEFCBDHCE; // 0x70
	private float HHGFDFEABBGEBEB; // 0x78
	private float CHDAEHHBGDDDEAD; // 0x7C
	private CharacterController EFGBCCBFFGGDFGH; // 0x80
	private Trigger ADCCAEHDGCBADDE; // 0x88
	private EFBFEHFCADAGFHF[] BDHGHDCFBBGEGHE; // 0x90
	private GAHHHCDAFAGDHGH CDHEEHDEGFDEFGF; // 0x98
	public PlayerTranslationParameters translationParameters; // 0xA0
	public DFHEFCGADAGGAEH translationData; // 0xA8
	private DHHFDEABDDCFDGD EAGADECCECDDGCC; // 0xB0
	[HideInInspector]
	public Transform characterTransform; // 0xB8
	private MecanimController EBAGHECBEHABGGG; // 0xC0
	private float CHHFADHBFDAEHCA; // 0xC8
	private List<HHHAABFGEBGDADF<CEEBAHFBDECFCEB>> EFHDEHGABFDFDCD; // 0xD0
	private List<HHHAABFGEBGDADF<CEEBAHFBDECFCEB>> FEGFAAEGEHFHAHB; // 0xD8
	private HHHAABFGEBGDADF<CEEBAHFBDECFCEB>[] ACDEAGDGGHGHHAF; // 0xE0

	// Properties
	public bool GBHEBECHDAHGDEB { get; }
	public Transform EAHCCFHAFEAFAAB { get; set; }
	public CBHBEDBDGAABGBF BFEHFEBECDAACAH { get; set; }
	public float HDDHEDGDFDCEADB { get; set; }
	public float AEGGFHEGDACDBDD { get; set; }
	public CharacterController CHCAFAGECHCBDFD { get; set; }
	public Trigger EADAECGBGGBFCCG { get; set; }
	public BECEBHGAAHHCFBD FHGEGAGCDECFAAF { get; }
	public float AAEBFHDFFCEACFF { get; }
	public MecanimController DFCFCCABBACFHGA { get; set; }
	public BECEBHGAAHHCFBD GEDFEECEEABHHFF { get; set; }
	public Vector3 FBBFACCAHDDEGFE { get; }

	// Methods

	// RVA: 0x111FA28 Offset: 0x111FA28 VA: 0x111FA28
	public bool get_GBHEBECHDAHGDEB() { }

	// RVA: 0x111FA30 Offset: 0x111FA30 VA: 0x111FA30
	public Transform get_EAHCCFHAFEAFAAB() { }

	// RVA: 0x111FA38 Offset: 0x111FA38 VA: 0x111FA38
	private void set_EAHCCFHAFEAFAAB(Transform value) { }

	// RVA: 0x111FA40 Offset: 0x111FA40 VA: 0x111FA40
	public CBHBEDBDGAABGBF get_BFEHFEBECDAACAH() { }

	// RVA: 0x111FA48 Offset: 0x111FA48 VA: 0x111FA48
	private void set_BFEHFEBECDAACAH(CBHBEDBDGAABGBF value) { }

	// RVA: 0x111FA50 Offset: 0x111FA50 VA: 0x111FA50
	public float get_HDDHEDGDFDCEADB() { }

	// RVA: 0x111FA58 Offset: 0x111FA58 VA: 0x111FA58
	private void set_HDDHEDGDFDCEADB(float value) { }

	// RVA: 0x111FA60 Offset: 0x111FA60 VA: 0x111FA60
	public float get_AEGGFHEGDACDBDD() { }

	// RVA: 0x111FA68 Offset: 0x111FA68 VA: 0x111FA68
	private void set_AEGGFHEGDACDBDD(float value) { }

	// RVA: 0x111FA70 Offset: 0x111FA70 VA: 0x111FA70
	public CharacterController get_CHCAFAGECHCBDFD() { }

	// RVA: 0x111FA78 Offset: 0x111FA78 VA: 0x111FA78
	private void set_CHCAFAGECHCBDFD(CharacterController value) { }

	// RVA: 0x111FA80 Offset: 0x111FA80 VA: 0x111FA80
	public Trigger get_EADAECGBGGBFCCG() { }

	// RVA: 0x111FA88 Offset: 0x111FA88 VA: 0x111FA88
	private void set_EADAECGBGGBFCCG(Trigger value) { }

	// RVA: 0x111FA90 Offset: 0x111FA90 VA: 0x111FA90
	public BECEBHGAAHHCFBD get_FHGEGAGCDECFAAF() { }

	// RVA: 0x111FB04 Offset: 0x111FB04 VA: 0x111FB04
	public float get_AAEBFHDFFCEACFF() { }

	// RVA: 0x111FB34 Offset: 0x111FB34 VA: 0x111FB34
	public MecanimController get_DFCFCCABBACFHGA() { }

	// RVA: 0x111FB3C Offset: 0x111FB3C VA: 0x111FB3C
	private void set_DFCFCCABBACFHGA(MecanimController value) { }

	// RVA: 0x111FB44 Offset: 0x111FB44 VA: 0x111FB44
	public BECEBHGAAHHCFBD get_GEDFEECEEABHHFF() { }

	// RVA: 0x111FBB8 Offset: 0x111FBB8 VA: 0x111FBB8
	public void set_GEDFEECEEABHHFF(BECEBHGAAHHCFBD value) { }

	// RVA: 0x111FC34 Offset: 0x111FC34 VA: 0x111FC34
	public Vector3 get_FBBFACCAHDDEGFE() { }

	// RVA: 0x111FCC0 Offset: 0x111FCC0 VA: 0x111FCC0
	public void .ctor() { }

	// RVA: 0x111FE40 Offset: 0x111FE40 VA: 0x111FE40
	public bool HFAABCBFFDAFGCB() { }

	// RVA: 0x111FE48 Offset: 0x111FE48 VA: 0x111FE48
	public Transform FGEEEGGBADGHFAA() { }

	// RVA: 0x111FE50 Offset: 0x111FE50 VA: 0x111FE50
	private void AFEBACHHBDADGEE(Transform HFACGHHBHBFFFDE) { }

	// RVA: 0x111FE58 Offset: 0x111FE58 VA: 0x111FE58
	public CBHBEDBDGAABGBF CFBCHDDHECEGEAH() { }

	// RVA: 0x111FE60 Offset: 0x111FE60 VA: 0x111FE60
	private void BEEGGHAFBGAAAAF(CBHBEDBDGAABGBF HFACGHHBHBFFFDE) { }

	// RVA: 0x111FE68 Offset: 0x111FE68 VA: 0x111FE68
	public float FBEFHHFFACAEEEF() { }

	// RVA: 0x111FE70 Offset: 0x111FE70 VA: 0x111FE70
	private void CAFACDBAGECGCDD(float HFACGHHBHBFFFDE) { }

	// RVA: 0x111FE78 Offset: 0x111FE78 VA: 0x111FE78
	public float DGFGBABDHABEBDH() { }

	// RVA: 0x111FE80 Offset: 0x111FE80 VA: 0x111FE80
	private void FGFAGDBGCEEAGCF(float HFACGHHBHBFFFDE) { }

	// RVA: 0x111FE88 Offset: 0x111FE88 VA: 0x111FE88
	public CharacterController DCBAEHCBGAHGGDC() { }

	// RVA: 0x111FE90 Offset: 0x111FE90 VA: 0x111FE90
	private void FHFADCCCGFBEGEC(CharacterController HFACGHHBHBFFFDE) { }

	// RVA: 0x111FE98 Offset: 0x111FE98 VA: 0x111FE98
	public Trigger FEBCGADEHHDFBAE() { }

	// RVA: 0x111FEA0 Offset: 0x111FEA0 VA: 0x111FEA0
	private void BADECDGGHEEGDEF(Trigger HFACGHHBHBFFFDE) { }

	// RVA: 0x111FA94 Offset: 0x111FA94 VA: 0x111FA94
	public BECEBHGAAHHCFBD CDEGABBCCGDFCBF() { }

	// RVA: 0x111FB1C Offset: 0x111FB1C VA: 0x111FB1C
	public float BGGFAAAGFHFHACA() { }

	// RVA: 0x111FF5C Offset: 0x111FF5C VA: 0x111FF5C
	public MecanimController BFDECBEAGBGCCDB() { }

	// RVA: 0x111FF64 Offset: 0x111FF64 VA: 0x111FF64
	private void AADFFDGDFHBBECG(MecanimController HFACGHHBHBFFFDE) { }

	// RVA: 0x111FF6C Offset: 0x111FF6C VA: 0x111FF6C
	private void GFGAEGCAABHHCEA() { }

	// RVA: 0x1120090 Offset: 0x1120090 VA: 0x1120090 Slot: 63
	public override void FDEDFCDHCDGCCCD() { }

	// RVA: 0x1120978 Offset: 0x1120978 VA: 0x1120978 Slot: 64
	public override void BGCCFHHGDFGCFEB(Team FCFFBABADHDCFHG) { }

	// RVA: 0x1120AA8 Offset: 0x1120AA8 VA: 0x1120AA8 Slot: 65
	public override void GBEDCDHFFBAFDHA() { }

	// RVA: 0x1120B08 Offset: 0x1120B08 VA: 0x1120B08
	public void BGCCGGDGACEBDEG(float HFACGHHBHBFFFDE) { }

	// RVA: 0x1120B98 Offset: 0x1120B98 VA: 0x1120B98 Slot: 72
	public override void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x1120BDC Offset: 0x1120BDC VA: 0x1120BDC
	private void DBDGHBGAGBDBADG(HHHAABFGEBGDADF<CEEBAHFBDECFCEB>[] HDABCHAEHCEECDD) { }

	// RVA: 0x11206CC Offset: 0x11206CC VA: 0x11206CC
	private void FBGDAHCFGFDFCCD() { }

	// RVA: 0x1120C9C Offset: 0x1120C9C VA: 0x1120C9C
	private void GFFBEHBDHCFADFE() { }

	// RVA: 0x1120D7C Offset: 0x1120D7C VA: 0x1120D7C
	private void EEEGCDAEFECDDGB(float CHCEEBHCFDFAHCA) { }

	// RVA: 0x1120E6C Offset: 0x1120E6C VA: 0x1120E6C
	private void BHDHHADDHBEBGEF() { }

	// RVA: 0x11207A8 Offset: 0x11207A8 VA: 0x11207A8
	private void BFFCHHDHEGBCABF() { }

	// RVA: 0x1120F4C Offset: 0x1120F4C VA: 0x1120F4C
	private void BFFEHFEEBGDDFAG(float GCABCDEGACEABFA, float GBGBBEFGCGEABGC) { }

	// RVA: 0x1121184 Offset: 0x1121184 VA: 0x1121184 Slot: 74
	public void HAEEFHHBFEEGFHH(DHHFDEABDDCFDGD ABDGAGEECHAHDGE) { }

	// RVA: 0x11214D8 Offset: 0x11214D8 VA: 0x11214D8 Slot: 75
	public DHHFDEABDDCFDGD CCHAAGHDDABHDDC() { }

	// RVA: 0x11217F4 Offset: 0x11217F4 VA: 0x11217F4 Slot: 76
	public void FHAGFDFBAHEACHH(CBHBEDBDGAABGBF ECCCGADGAHBEDFC, float CAGGBAGGHFFGEEF, float GCABCDEGACEABFA) { }

	// RVA: 0x112184C Offset: 0x112184C VA: 0x112184C
	private void DBBFFHHHGEBCDCF() { }

	// RVA: 0x111FB48 Offset: 0x111FB48 VA: 0x111FB48
	public BECEBHGAAHHCFBD FFDAFEEEGFADAAH() { }

	// RVA: 0x111FBBC Offset: 0x111FBBC VA: 0x111FBBC
	public void CHBEBCABCAFEAGD(BECEBHGAAHHCFBD HFACGHHBHBFFFDE) { }

	// RVA: 0x111FC38 Offset: 0x111FC38 VA: 0x111FC38
	public Vector3 GEDFAAHEHBDCGCG() { }

	// RVA: 0x1121DE0 Offset: 0x1121DE0 VA: 0x1121DE0
	private HHHAABFGEBGDADF<CEEBAHFBDECFCEB> EHECCBCAGFGFEAG(float GCABCDEGACEABFA, byte GCDCEABGCFHDHFG) { }

	// RVA: 0x1121EA4 Offset: 0x1121EA4 VA: 0x1121EA4
	public void HFACGCBCEGCGFGE(AnimationCurve BCEBHAEHGAGDHCE, float DHBFHDEGGEAHFHB, float CAGGBAGGHFFGEEF) { }

	// RVA: 0x1121EC8 Offset: 0x1121EC8 VA: 0x1121EC8
	public void CCEABAFBBBAHDHD() { }

	// RVA: 0x1121F84 Offset: 0x1121F84 VA: 0x1121F84
	public void BFAFBEDGEGEGBGB(float CAGGBAGGHFFGEEF) { }

	// RVA: 0x1122114 Offset: 0x1122114 VA: 0x1122114
	public void EFAEGDFAEABGBGF() { }

	// RVA: 0x11221D0 Offset: 0x11221D0 VA: 0x11221D0
	public void AAAEBHBFBEBDDAC() { }

	// RVA: 0x112228C Offset: 0x112228C VA: 0x112228C Slot: 77
	public void AGBDAEAHGGAEBDD(WeaponController AAHCEHFGCCGHCFE) { }

	// RVA: 0x11222D0 Offset: 0x11222D0 VA: 0x11222D0
	public void CCGAGGFBEAEGEED(WeaponController AAHCEHFGCCGHCFE) { }

	// RVA: 0x11222D4 Offset: 0x11222D4 VA: 0x11222D4
	public void FDGGFDCBHHGGGFB(WeaponController AAHCEHFGCCGHCFE) { }

	// RVA: 0x11222D8 Offset: 0x11222D8 VA: 0x11222D8
	public void BEEAGCFDADBAACA(Vector3 GADGBCDEGEHCGBH, Vector3 EHCDGFBFBDEDGEC) { }

	// RVA: 0x1122368 Offset: 0x1122368 VA: 0x1122368
	public void FGBCDBGCDFAHAAC() { }

	// RVA: 0x11223DC Offset: 0x11223DC VA: 0x11223DC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MecanimController.<>c // TypeDefIndex: 2896
{
	// Fields
	public static readonly MecanimController.<>c <>9; // 0x0
	public static Action <>9__45_0; // 0x8
	public static Action <>9__92_0; // 0x10

	// Methods

	// RVA: 0x11250E8 Offset: 0x11250E8 VA: 0x11250E8
	private static void .cctor() { }

	// RVA: 0x1125158 Offset: 0x1125158 VA: 0x1125158
	public void .ctor() { }

	// RVA: 0x1125160 Offset: 0x1125160 VA: 0x1125160
	internal void <EFCGDBEGHECDGDF>b__45_0() { }

	// RVA: 0x1125164 Offset: 0x1125164 VA: 0x1125164
	internal void <.ctor>b__92_0() { }
}

// Namespace: Axlebolt.Standoff.Player.Mecanim
public class MecanimController : Controller, HGDECFHDGBAEFBB<EDGHAFEAGDBCCAC, DBDFGAGEAGBBHBE>, FFGBGHGBFHFBBFE // TypeDefIndex: 2897
{
	// Fields
	[HideInInspector]
	private PlayerController GFDEHBFDAAGFCHC; // 0x50
	private PlayerOcclusionController AHDCBFGDDEHAEAG; // 0x58
	private Animator AGEGADGGAHAEECA; // 0x60
	public PlayerMecanimConfig config; // 0x68
	private RuntimeAnimatorController BEBFGEAHDBEEGAH; // 0x70
	public FEEBFHEHHAFGCBF mecanimSync; // 0x78
	private GEBDAGBFGAAHFEF BCBFEDEBGBCAABB; // 0x80
	private FBDAGHFAHECEGAB ACCFAAFDCCBABAA; // 0x88
	private Action CHDBBCAAAGBGCAF__BackingField; // 0x90
	private FCBCBDDBDAAHCHE[] BDHGHDCFBBGEGHE; // 0x98
	private Action DBBCFEHCAAACFEB__BackingField; // 0xA0
	private float AAFHCAGCHEHDEGE; // 0xA8
	private EDGHAFEAGDBCCAC CBDFGDBGABBGEHG; // 0xB0

	// Properties
	public RuntimeAnimatorController DBAAHFBADGFCBFD { get; set; }
	public Animator EFGBHDFADHBDBFA { get; }

	// Methods

	// RVA: 0x1122BD8 Offset: 0x1122BD8 VA: 0x1122BD8
	public RuntimeAnimatorController get_DBAAHFBADGFCBFD() { }

	// RVA: 0x1122BE0 Offset: 0x1122BE0 VA: 0x1122BE0
	public void set_DBAAHFBADGFCBFD(RuntimeAnimatorController value) { }

	// RVA: 0x1122BE8 Offset: 0x1122BE8 VA: 0x1122BE8
	public Animator get_EFGBHDFADHBDBFA() { }

	// RVA: 0x1122BF0 Offset: 0x1122BF0 VA: 0x1122BF0
	public void add_CHDBBCAAAGBGCAF(Action value) { }

	// RVA: 0x1122C90 Offset: 0x1122C90 VA: 0x1122C90
	public void remove_CHDBBCAAAGBGCAF(Action value) { }

	// RVA: 0x1122D30 Offset: 0x1122D30 VA: 0x1122D30
	public void add_DBBCFEHCAAACFEB(Action value) { }

	// RVA: 0x1122DD0 Offset: 0x1122DD0 VA: 0x1122DD0
	public void remove_DBBCFEHCAAACFEB(Action value) { }

	// RVA: 0x1122E70 Offset: 0x1122E70 VA: 0x1122E70
	public RuntimeAnimatorController GFBBGAFEHFCEGHA() { }

	// RVA: 0x1122E78 Offset: 0x1122E78 VA: 0x1122E78
	public void AACDBCDHDABCGEC(RuntimeAnimatorController HFACGHHBHBFFFDE) { }

	// RVA: 0x1122BF4 Offset: 0x1122BF4 VA: 0x1122BF4
	public void HFADGFGADCFDFEC(Action HFACGHHBHBFFFDE) { }

	// RVA: 0x1122C94 Offset: 0x1122C94 VA: 0x1122C94
	public void GCDGEDGFDACDHAH(Action HFACGHHBHBFFFDE) { }

	// RVA: 0x1122D34 Offset: 0x1122D34 VA: 0x1122D34
	public void AEBHGFGCHAEAECF(Action HFACGHHBHBFFFDE) { }

	// RVA: 0x1122DD4 Offset: 0x1122DD4 VA: 0x1122DD4
	public void CEBGDBDCFADBABA(Action HFACGHHBHBFFFDE) { }

	// RVA: 0x1122E80 Offset: 0x1122E80 VA: 0x1122E80 Slot: 63
	public override void FDEDFCDHCDGCCCD() { }

	// RVA: 0x1122FA4 Offset: 0x1122FA4 VA: 0x1122FA4 Slot: 64
	public override void BGCCFHHGDFGCFEB(Team FCFFBABADHDCFHG) { }

	// RVA: 0x1122FC4 Offset: 0x1122FC4 VA: 0x1122FC4 Slot: 70
	public override void FBHAEBEFFDGFFCE(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x112306C Offset: 0x112306C VA: 0x112306C Slot: 71
	public override void GEGDBCCAFCDHEAH(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x1123114 Offset: 0x1123114 VA: 0x1123114 Slot: 72
	public override void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x112325C Offset: 0x112325C VA: 0x112325C Slot: 73
	public override void CGEHBBBHECABDEB(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x1123310 Offset: 0x1123310 VA: 0x1123310
	public void HCFGFGBDCFGGDED(RuntimeAnimatorController CHHHHBDADEFABGH) { }

	// RVA: 0x112332C Offset: 0x112332C VA: 0x112332C Slot: 76
	public void FHAGFDFBAHEACHH(DBDFGAGEAGBBHBE ECCCGADGAHBEDFC, float CAGGBAGGHFFGEEF, float GCABCDEGACEABFA) { }

	// RVA: 0x11233C4 Offset: 0x11233C4 VA: 0x11233C4
	private void BGHDHGEEAGHABCB() { }

	// RVA: 0x11233EC Offset: 0x11233EC VA: 0x11233EC Slot: 75
	public EDGHAFEAGDBCCAC CCHAAGHDDABHDDC() { }

	// RVA: 0x1123438 Offset: 0x1123438 VA: 0x1123438 Slot: 74
	public void HAEEFHHBFEEGFHH(EDGHAFEAGDBCCAC BBGCCGGCECAHFFE) { }

	// RVA: 0x1123574 Offset: 0x1123574 VA: 0x1123574
	private void FHHBEGCHDGCGHGF() { }

	// RVA: 0x1123668 Offset: 0x1123668 VA: 0x1123668
	private void AFGADEEBDGFEAEC() { }

	// RVA: 0x1123748 Offset: 0x1123748 VA: 0x1123748
	private void EHDGAFGBFGGHHHE() { }

	// RVA: 0x1123824 Offset: 0x1123824 VA: 0x1123824
	private void AFFFCAHCAFCBHFG() { }

	// RVA: 0x1123904 Offset: 0x1123904 VA: 0x1123904 Slot: 68
	public override void EFCGDBEGHECDGDF() { }

	// RVA: 0x1123AC8 Offset: 0x1123AC8 VA: 0x1123AC8 Slot: 78
	public void GEEEAABCFDACEAG() { }

	// RVA: 0x1123ACC Offset: 0x1123ACC VA: 0x1123ACC Slot: 79
	public void CHHEHCHAHBHCDEB() { }

	// RVA: 0x1123AEC Offset: 0x1123AEC VA: 0x1123AEC Slot: 80
	public void HFEDGHGHGCGFDGF() { }

	// RVA: 0x1123AF0 Offset: 0x1123AF0 VA: 0x1123AF0 Slot: 81
	public void DBHBDCGBHBEHDBE() { }

	// RVA: 0x1123AF4 Offset: 0x1123AF4 VA: 0x1123AF4 Slot: 77
	public void EBHBHGBABFGFHBC() { }

	// RVA: 0x1123B7C Offset: 0x1123B7C VA: 0x1123B7C
	public Animator BABBHAEFFDDDCAE() { }

	// RVA: 0x1123B84 Offset: 0x1123B84 VA: 0x1123B84
	public void BCDGHGHBECAGDGG(int GAAEGDFBDBDGEFG) { }

	// RVA: 0x1123C08 Offset: 0x1123C08 VA: 0x1123C08
	public void FEGGEBFBGDGDGCG(int GAAEGDFBDBDGEFG) { }

	// RVA: 0x1123C64 Offset: 0x1123C64 VA: 0x1123C64
	public void GHBEEBDBGDFEBDB(int GAAEGDFBDBDGEFG) { }

	// RVA: 0x1123CE0 Offset: 0x1123CE0 VA: 0x1123CE0
	public void GDGDEDDDHGECCBF(float AAAEADGDAGGDCHC, float HHAGACFBBGFFHEH) { }

	// RVA: 0x1123D98 Offset: 0x1123D98 VA: 0x1123D98
	public void DEABAEGFCCDFCAH() { }

	// RVA: 0x1123DEC Offset: 0x1123DEC VA: 0x1123DEC
	public void EHCDCHFHGAHAEDH() { }

	// RVA: 0x1123E40 Offset: 0x1123E40 VA: 0x1123E40
	public void CEDFEDBFEADGEBF() { }

	// RVA: 0x1123E94 Offset: 0x1123E94 VA: 0x1123E94
	public void AGHAACHHBBGBGDH(bool FHGAADCAHBDFFHB = False) { }

	// RVA: 0x1123F08 Offset: 0x1123F08 VA: 0x1123F08
	public void ABAFHFDEAEGCBGA() { }

	// RVA: 0x1123F5C Offset: 0x1123F5C VA: 0x1123F5C
	public void CDCBGDFBFDEECHF() { }

	// RVA: 0x1123FB0 Offset: 0x1123FB0 VA: 0x1123FB0
	public void DCBBFCGFBEFGGHG(int BDDDGABBBHGGDFH) { }

	// RVA: 0x112400C Offset: 0x112400C VA: 0x112400C
	public void GHDHGFACCAGHGBF() { }

	// RVA: 0x11240C0 Offset: 0x11240C0 VA: 0x11240C0
	public void AGFEDHAECABCCHG(float ABEFAEHEHHHBCAB) { }

	// RVA: 0x1121AE0 Offset: 0x1121AE0 VA: 0x1121AE0
	public void GCEFHDDDCHDHBBF(Vector2 AEBAHDEAHHFDGDB) { }

	// RVA: 0x1121D20 Offset: 0x1121D20 VA: 0x1121D20
	public void BBCGGBGBBBHHECB(float DFFEADAFGFHADBF) { }

	// RVA: 0x1121D84 Offset: 0x1121D84 VA: 0x1121D84
	public void EBHGBAHDDGEGFBH(int GCDCEABGCFHDHFG) { }

	// RVA: 0x11240E0 Offset: 0x11240E0 VA: 0x11240E0
	public void FECGEFDBGGDEBHG(float GCABCDEGACEABFA) { }

	// RVA: 0x1124144 Offset: 0x1124144 VA: 0x1124144
	public void EGGECEFCABBCCAB(float DCDBHBHGAEBAAGG) { }

	// RVA: 0x1121C58 Offset: 0x1121C58 VA: 0x1121C58
	public void BDGFCGGBEECGFFH(float EAGGDHDEDGFAGAD) { }

	// RVA: 0x1121CBC Offset: 0x1121CBC VA: 0x1121CBC
	public void ADBHBABHGCCEEEE(float GCCEGHEDACBGGBB) { }

	// RVA: 0x11241A8 Offset: 0x11241A8 VA: 0x11241A8
	public void HHDHGCDAHCGABGD(float DHAGDCFBDCEDHBD) { }

	// RVA: 0x112420C Offset: 0x112420C VA: 0x112420C
	public void HAEABDCFCFHADFG(bool BHHGFEFHGGABGEC) { }

	// RVA: 0x1124268 Offset: 0x1124268 VA: 0x1124268
	public float DHBEFGFDHCEFFGD(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x1124270 Offset: 0x1124270 VA: 0x1124270
	public void CFAEFGDEDCECFHH(float CBABEBEDHFGDGFH) { }

	// RVA: 0x11242FC Offset: 0x11242FC VA: 0x11242FC
	public void HHDHCCFAAEBAFAA() { }

	// RVA: 0x1124350 Offset: 0x1124350 VA: 0x1124350
	public void CDEHABAFEEBEGFA(bool CDBEFBBHDBDDHGE) { }

	// RVA: 0x11243AC Offset: 0x11243AC VA: 0x11243AC
	public void AGDEAHGCBBEAFEE() { }

	// RVA: 0x1124400 Offset: 0x1124400 VA: 0x1124400
	public void GHDAHFFBDEHBEAC() { }

	// RVA: 0x1124454 Offset: 0x1124454 VA: 0x1124454
	public void BBGBEGACBGGCEHB(float EHCFEFBCAEHEGEC) { }

	// RVA: 0x11244B8 Offset: 0x11244B8 VA: 0x11244B8
	public bool HGABFAAGBFDCDFF(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x11245A0 Offset: 0x11245A0 VA: 0x11245A0
	public bool GHDEHCCDGBAHAAH(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x11246C8 Offset: 0x11246C8 VA: 0x11246C8
	public bool DHCCEFHGAFFCGEG(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x11247F0 Offset: 0x11247F0 VA: 0x11247F0
	public bool FCBHBBDGGBECHGF(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x11248D4 Offset: 0x11248D4 VA: 0x11248D4
	public bool EEFDCHEDDBBGAEA(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x1124B50 Offset: 0x1124B50 VA: 0x1124B50
	public bool ABAAECDHABCBCFG(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x1124C20 Offset: 0x1124C20 VA: 0x1124C20
	public bool AHDDGHHEHECHCEA(string DAFHAGGHEDGDCEB) { }

	// RVA: 0x1124D28 Offset: 0x1124D28 VA: 0x1124D28
	public FBDAGHFAHECEGAB HFCCGACAFAGCFHE(int GFAFFDCFEEABADD) { }

	// RVA: 0x1124DC4 Offset: 0x1124DC4 VA: 0x1124DC4
	public FBDAGHFAHECEGAB GHAGDHEAEFECAHD(int GFAFFDCFEEABADD) { }

	// RVA: 0x1124E88 Offset: 0x1124E88 VA: 0x1124E88
	public float GDEBCBCHDBBAFGC() { }

	// RVA: 0x1124F1C Offset: 0x1124F1C VA: 0x1124F1C
	public float FAEHAHFGGBAABAF() { }

	// RVA: 0x1124F70 Offset: 0x1124F70 VA: 0x1124F70
	public void .ctor() { }
}

// Namespace: 
public enum AimController.BAEHBBGBEABHGBE // TypeDefIndex: 2923
{
	// Fields
	public int value__; // 0x0
	public const AimController.BAEHBBGBEABHGBE NotStated = 0;
	public const AimController.BAEHBBGBEABHGBE Translation = 1;
}

// Namespace: 
public enum AimController.DCCBBDFHGEEHBBE // TypeDefIndex: 2924
{
	// Fields
	public int value__; // 0x0
	public const AimController.DCCBBDFHGEEHBBE NotStated = 0;
	public const AimController.DCCBBDFHGEEHBBE Crouch = 1;
	public const AimController.DCCBBDFHGEEHBBE Stand = 2;
	public const AimController.DCCBBDFHGEEHBBE FinishedCrouch = 3;
	public const AimController.DCCBBDFHGEEHBBE FinishedStand = 4;
}

// Namespace: 
public sealed class AimController.DDHDHCHADGHEGFE : MulticastDelegate // TypeDefIndex: 2925
{
	// Methods

	// RVA: 0x113066C Offset: 0x113066C VA: 0x113066C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1130740 Offset: 0x1130740 VA: 0x1130740 Slot: 12
	public virtual void Invoke(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x1130754 Offset: 0x1130754 VA: 0x1130754 Slot: 13
	public virtual IAsyncResult BeginInvoke(BAAFADDFCADEHEA FFGFFADCBHGFBCD, AsyncCallback callback, object object) { }

	// RVA: 0x11307D8 Offset: 0x11307D8 VA: 0x11307D8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class AimController.AimingParameters.GeneralData // TypeDefIndex: 2926
{
	// Fields
	public CurvedValue curve01; // 0x10
	public CurvedValue curve00; // 0x18
	public CurvedValue curve11; // 0x20

	// Methods

	// RVA: 0x11307EC Offset: 0x11307EC VA: 0x11307EC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AimController.AimingParameters // TypeDefIndex: 2927
{
	// Fields
	public TransformTRS FPSOffsetStand; // 0x10
	public TransformTRS FPSOffsetCrouch; // 0x18
	public AnimationCurve FPSOffsetCurveSC; // 0x20
	public AnimationCurve FPSOffsetCurveCS; // 0x28
	public CurvedValue FPSOffsetCurveStandToCrouch; // 0x30
	public CurvedValue FPSOffsetCurveCrouchToStand; // 0x38
	public float FPSTDuration; // 0x40
	public CurvedValue fpsAdditiveOffsetOnLand; // 0x48
	public AnimationCurve weaponPHTCurve; // 0x50
	public float weaponPHTDuration; // 0x58
	public AnimationCurve weaponMTCurve; // 0x60
	public AnimationCurve weaponMTCurveOpp; // 0x68
	public float weaponMTDuration; // 0x70
	public AimController.AimingParameters.GeneralData generalData; // 0x78
	public TransformTRS defaultWeaponOffset; // 0x80
	public Vector3 defaultHeadRotation; // 0x88
	public Vector3 headOffset; // 0x94
	public Vector3 headCorrector; // 0xA0
	public float verticalClamp; // 0xAC
	public float horizontalClamp; // 0xB0
	public AnimationCurve verticalAimFilterCurve; // 0xB8

	// Methods

	// RVA: 0x11307E4 Offset: 0x11307E4 VA: 0x11307E4
	public void .ctor() { }
}

// Namespace: 
public class AimController.DEGFDGBGEBABCHG // TypeDefIndex: 2928
{
	// Fields
	public ValueBlender FHEBCAHHDHCAHCH; // 0x10
	public ValueBlender FACADBHAFGGCFHE; // 0x18

	// Methods

	// RVA: 0x112DA80 Offset: 0x112DA80 VA: 0x112DA80
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class AimController.TuningParams // TypeDefIndex: 2929
{
	// Fields
	public bool disableSpinesRotation; // 0x10
	public float mecanimSpineRotCoeff; // 0x14

	// Methods

	// RVA: 0x11307F4 Offset: 0x11307F4 VA: 0x11307F4
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Player.Aim
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(MecanimController))]
[RequireComponent(typeof(MovementController))]
public class AimController : Controller, HGDECFHDGBAEFBB<DEDBHCHHCFCDFHH, FFECCEHGGCHCDAE>, FFCHECDHEGDECAH, EFBFEHFCADAGFHF, FFGBGHGBFHFBBFE, FCBCBDDBDAAHCHE // TypeDefIndex: 2930
{
	// Fields
	[SerializeField]
	private bool _overrideSpineRotation; // 0x4B
	private HAACHBDEFGBGEEH FDFABBGBEFDFGBE; // 0x4C
	public float sensitivityX; // 0x50
	public float sensitivityY; // 0x54
	public float minimumX; // 0x58
	public float maximumX; // 0x5C
	public Transform FPSP_go; // 0x60
	public Transform spineDirector; // 0x68
	public Transform FPSCamera; // 0x70
	private Transform ADCCCDCECHCCFED; // 0x78
	public Transform camTransform; // 0x80
	public AimController.AimingParameters aimingParameters; // 0x88
	public AHFDHFFDEDDCAAF aimingData; // 0x90
	public AimController.DEGFDGBGEBABCHG interpolatorsBunch; // 0x98
	public AimController.TuningParams tuningParams; // 0xA0
	[SerializeField]
	private Vector3 _headDirectiveAngles; // 0xA8
	private PlayerController DDCBCHDAAHEEHHH; // 0xB8
	private MovementController HCFHAHGDFGHBAFE; // 0xC0
	private Transform ECDABDECBHABGCE; // 0xC8
	private MecanimController AHDDACCCDAEDHFG; // 0xD0
	private Transform FCHDAGHBFCEDDHH; // 0xD8
	private Transform HGDEGFHDGEFAHDD; // 0xE0
	private Transform AFEHBDADCBGEBAH; // 0xE8
	private Transform GGGEHDHCBGGFBGH; // 0xF0
	private bool CEGFAAAFCDACBCF; // 0xF8
	private FFECCEHGGCHCDAE EAFDGBAHHBCCDBC; // 0x100
	private readonly StateSimple<BAAFADDFCADEHEA> EACFHHCBEDGHAAG; // 0x108
	private Vector3 AHBGBACAEGCGEHG; // 0x110
	private readonly StateSimple<AimController.BAEHBBGBEABHGBE> BFAAADHAGDFBCDF; // 0x120
	private readonly StateSimple<AimController.DCCBBDFHGEEHBBE> FGAGDFFDEFDAHEC; // 0x128
	private readonly TransformTR HHHCFHGDGEDFCGC; // 0x130
	private readonly TransformTR ACGFBEHGGCEEHHC; // 0x138
	private TransformTR GGCCAEADCGCABEC; // 0x140
	private TransformTR FGAHFAFDEGEDFDG; // 0x148
	private readonly DEDBHCHHCFCDFHH EHGDCDFBEADDGDE; // 0x150
	private Action HHFHGEGBEEFBFFG; // 0x158
	private bool DDDEACFGDBACCBC; // 0x160
	private float CHDAEHHBGDDDEAD; // 0x164
	private float HHGFDFEABBGEBEB; // 0x168
	private Transform ADHDCDFFHDHEFDD; // 0x170
	private Transform HCEBGBDCEDCDGCG; // 0x178
	private HCGDBCBGAEFBEEA FEFDDABHCEECFDB; // 0x180
	private float HAECAAEFEGFACDD; // 0x188
	private float DCHFDFACHHDEHED; // 0x18C
	private BDFGFCBCEDGGFFD[] BDHGHDCFBBGEGHE; // 0x190
	private WeaponryController BGFEEECBBCFDGBB; // 0x198

	// Properties
	public bool ABACHHFAFFBBEGE { get; set; }
	public float AEGGFHEGDACDBDD { get; set; }
	public float HDDHEDGDFDCEADB { get; set; }
	private WeaponAnimationParameters BGABBBEEBFDBEAD { get; }

	// Methods

	// RVA: 0x112D6F4 Offset: 0x112D6F4 VA: 0x112D6F4
	public bool get_ABACHHFAFFBBEGE() { }

	// RVA: 0x112D6FC Offset: 0x112D6FC VA: 0x112D6FC
	public void set_ABACHHFAFFBBEGE(bool value) { }

	// RVA: 0x112D708 Offset: 0x112D708 VA: 0x112D708
	public float get_AEGGFHEGDACDBDD() { }

	// RVA: 0x112D710 Offset: 0x112D710 VA: 0x112D710
	private void set_AEGGFHEGDACDBDD(float value) { }

	// RVA: 0x112D718 Offset: 0x112D718 VA: 0x112D718
	public float get_HDDHEDGDFDCEADB() { }

	// RVA: 0x112D720 Offset: 0x112D720 VA: 0x112D720
	private void set_HDDHEDGDFDCEADB(float value) { }

	// RVA: 0x112D728 Offset: 0x112D728 VA: 0x112D728
	private WeaponAnimationParameters get_BGABBBEEBFDBEAD() { }

	// RVA: 0x112D754 Offset: 0x112D754 VA: 0x112D754
	public void .ctor() { }

	// RVA: 0x112DB1C Offset: 0x112DB1C VA: 0x112DB1C
	public bool EHBDGAEGADEFEBH() { }

	// RVA: 0x112DB24 Offset: 0x112DB24 VA: 0x112DB24
	public void HGFAFBBHAGEHACD(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x112DB30 Offset: 0x112DB30 VA: 0x112DB30
	public float DGFGBABDHABEBDH() { }

	// RVA: 0x112DB38 Offset: 0x112DB38 VA: 0x112DB38
	private void FGFAGDBGCEEAGCF(float HFACGHHBHBFFFDE) { }

	// RVA: 0x112DB40 Offset: 0x112DB40 VA: 0x112DB40
	public float FBEFHHFFACAEEEF() { }

	// RVA: 0x112DB48 Offset: 0x112DB48 VA: 0x112DB48
	private void CAFACDBAGECGCDD(float HFACGHHBHBFFFDE) { }

	// RVA: 0x112D72C Offset: 0x112D72C VA: 0x112D72C
	private WeaponAnimationParameters HCDDEDCCDCFHHAE() { }

	// RVA: 0x112DB50 Offset: 0x112DB50 VA: 0x112DB50 Slot: 63
	public override void FDEDFCDHCDGCCCD() { }

	// RVA: 0x112E00C Offset: 0x112E00C VA: 0x112E00C
	private void GFGAEGCAABHHCEA() { }

	// RVA: 0x112E0F0 Offset: 0x112E0F0 VA: 0x112E0F0 Slot: 64
	public override void BGCCFHHGDFGCFEB(Team FCFFBABADHDCFHG) { }

	// RVA: 0x112E234 Offset: 0x112E234 VA: 0x112E234
	public void BHAHDCEAFECAEAB(Vector3 BGABDFGAGDHFDEA) { }

	// RVA: 0x112E2BC Offset: 0x112E2BC VA: 0x112E2BC
	public Vector3 HHGCAFDHGDGAGCD() { }

	// RVA: 0x112E2E0 Offset: 0x112E2E0 VA: 0x112E2E0 Slot: 66
	public override void AAEDEDCEDCADEBG() { }

	// RVA: 0x112E304 Offset: 0x112E304 VA: 0x112E304 Slot: 71
	public override void GEGDBCCAFCDHEAH(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x112E36C Offset: 0x112E36C VA: 0x112E36C Slot: 72
	public override void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x112E510 Offset: 0x112E510 VA: 0x112E510 Slot: 73
	public override void CGEHBBBHECABDEB(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x112E57C Offset: 0x112E57C VA: 0x112E57C Slot: 76
	public void FHAGFDFBAHEACHH(FFECCEHGGCHCDAE ECCCGADGAHBEDFC, float CAGGBAGGHFFGEEF, float GCABCDEGACEABFA) { }

	// RVA: 0x112E654 Offset: 0x112E654 VA: 0x112E654
	private void FADDHGCGDEACEGD() { }

	// RVA: 0x112ED30 Offset: 0x112ED30 VA: 0x112ED30 Slot: 74
	public void HAEEFHHBFEEGFHH(DEDBHCHHCFCDFHH BBGCCGGCECAHFFE) { }

	// RVA: 0x112EE7C Offset: 0x112EE7C VA: 0x112EE7C Slot: 75
	public DEDBHCHHCFCDFHH CCHAAGHDDABHDDC() { }

	// RVA: 0x112EEE0 Offset: 0x112EEE0 VA: 0x112EEE0 Slot: 85
	public void CHHEHCHAHBHCDEB() { }

	// RVA: 0x112EEEC Offset: 0x112EEEC VA: 0x112EEEC Slot: 86
	public void HFEDGHGHGCGFDGF() { }

	// RVA: 0x112EEF0 Offset: 0x112EEF0 VA: 0x112EEF0 Slot: 87
	public void DBHBDCGBHBEHDBE() { }

	// RVA: 0x112EEF4 Offset: 0x112EEF4 VA: 0x112EEF4 Slot: 83
	public void EBHBHGBABFGFHBC() { }

	// RVA: 0x112EF00 Offset: 0x112EF00 VA: 0x112EF00 Slot: 84
	public void GEEEAABCFDACEAG() { }

	// RVA: 0x112EF04 Offset: 0x112EF04 VA: 0x112EF04 Slot: 88
	public void EHDGAFGBFGGHHHE() { }

	// RVA: 0x112EF44 Offset: 0x112EF44 VA: 0x112EF44 Slot: 89
	public void AFFFCAHCAFCBHFG() { }

	// RVA: 0x112EF48 Offset: 0x112EF48 VA: 0x112EF48
	public void DDHCHGHBHEFEEFH() { }

	// RVA: 0x112E6B8 Offset: 0x112E6B8 VA: 0x112E6B8
	private void DEHAHHDADHAHCEA() { }

	// RVA: 0x112E268 Offset: 0x112E268 VA: 0x112E268
	private void BFHGCEFDBFHCGCB() { }

	// RVA: 0x112E790 Offset: 0x112E790 VA: 0x112E790
	private void HGAGEBGBFEFHFGG() { }

	// RVA: 0x112EF80 Offset: 0x112EF80 VA: 0x112EF80
	public bool EBCAHHAFDHFFHGF(float GCABCDEGACEABFA) { }

	// RVA: 0x112EF9C Offset: 0x112EF9C VA: 0x112EF9C
	private Vector3 DEAEHCGGFEBCFAD() { }

	// RVA: 0x112EC24 Offset: 0x112EC24 VA: 0x112EC24
	private void GDGDEDDDHGECCBF() { }

	// RVA: 0x112F138 Offset: 0x112F138 VA: 0x112F138
	private Vector2 CDGBEDGFEGCHBEA() { }

	// RVA: 0x112F1E0 Offset: 0x112F1E0 VA: 0x112F1E0
	private Vector2 DFGGDGEGHFGEBDF() { }

	// RVA: 0x112F288 Offset: 0x112F288 VA: 0x112F288
	private void BBCGHDEADECDBHE() { }

	// RVA: 0x112FDEC Offset: 0x112FDEC VA: 0x112FDEC
	private void FGGBFDGBHHAHEDH() { }

	// RVA: 0x112FD10 Offset: 0x112FD10 VA: 0x112FD10
	private void FBGFHCCFAGCGGFE() { }

	// RVA: 0x112F70C Offset: 0x112F70C VA: 0x112F70C
	private void FCGDGEGGADBFFEB() { }

	// RVA: 0x112FECC Offset: 0x112FECC VA: 0x112FECC
	public bool HDHFAGBGDCEGEEB(float GCABCDEGACEABFA) { }

	// RVA: 0x112FEE8 Offset: 0x112FEE8 VA: 0x112FEE8
	private void HGBGHDFECDAFCBC() { }

	// RVA: 0x112FF28 Offset: 0x112FF28 VA: 0x112FF28
	private void BDCDCCACCGFDCDE() { }

	// RVA: 0x1130094 Offset: 0x1130094 VA: 0x1130094
	public void CAEGFHABCFGDADC() { }

	// RVA: 0x1130110 Offset: 0x1130110 VA: 0x1130110
	private void BABAHEEFECHEHGH() { }

	// RVA: 0x1130178 Offset: 0x1130178 VA: 0x1130178 Slot: 78
	public void HFGHFEHGEDAAEHA() { }

	// RVA: 0x11301A8 Offset: 0x11301A8 VA: 0x11301A8 Slot: 79
	public void AGCGFEGFDDGEEFE() { }

	// RVA: 0x113021C Offset: 0x113021C VA: 0x113021C Slot: 80
	public void DABDCDGEGBAEHFA(float CHCEEBHCFDFAHCA) { }

	// RVA: 0x11302C4 Offset: 0x11302C4 VA: 0x11302C4 Slot: 81
	public void GAHCCCDGGFFEBCD() { }

	// RVA: 0x113033C Offset: 0x113033C VA: 0x113033C Slot: 82
	public void AEFCEGFDAFHGCAA() { }

	// RVA: 0x11303B4 Offset: 0x11303B4 VA: 0x11303B4 Slot: 77
	public void AGBDAEAHGGAEBDD(WeaponController AAHCEHFGCCGHCFE) { }

	// RVA: 0x1130664 Offset: 0x1130664 VA: 0x1130664
	public void CCGAGGFBEAEGEED(WeaponController AAHCEHFGCCGHCFE) { }

	// RVA: 0x1130668 Offset: 0x1130668 VA: 0x1130668
	public void FDGGFDCBHHGGGFB(WeaponController AAHCEHFGCCGHCFE) { }
}

// Namespace: Axlebolt.Standoff.Occlusion.Dynamic
public abstract class ObjectOccludee : MonoBehaviour // TypeDefIndex: 2965
{
	// Fields
	private FFGBGHGBFHFBBFE[] BDHGHDCFBBGEGHE; // 0x18
	private Transform CBCBGACGGECGEAA; // 0x20
	private bool AEEDEGBCHCCHCDB; // 0x28
	private bool ABABBGADEEHCGHD; // 0x29
	private bool GDACHFABHBEHGHG; // 0x2A
	private HAACHBDEFGBGEEH EDGHEFHEBGBEGEA; // 0x2C
	private HAACHBDEFGBGEEH BGEDBAEFBBGFHHF; // 0x30

	// Properties
	public Transform FAFCFFABDEEBFAH { get; }
	public bool FDHCBCBHAAFDGBB { get; }
	public bool EFHADADCGFCAFAF { get; }
	public virtual bool FBGGFEHDFACFGHG { get; set; }
	public bool GGCBGCCFEGFDHAA { get; set; }
	public HAACHBDEFGBGEEH DFCGCDFHEBCHHFG { get; set; }
	public HAACHBDEFGBGEEH BGAAFCDEGAECEFC { get; set; }

	// Methods

	// RVA: 0x1137FD8 Offset: 0x1137FD8 VA: 0x1137FD8
	public Transform get_FAFCFFABDEEBFAH() { }

	// RVA: 0x113806C Offset: 0x113806C VA: 0x113806C
	public bool get_FDHCBCBHAAFDGBB() { }

	// RVA: 0x113808C Offset: 0x113808C VA: 0x113808C
	public bool get_EFHADADCGFCAFAF() { }

	// RVA: 0x11380AC Offset: 0x11380AC VA: 0x11380AC Slot: 4
	public virtual bool get_FBGGFEHDFACFGHG() { }

	// RVA: 0x11380B8 Offset: 0x11380B8 VA: 0x11380B8 Slot: 5
	public virtual void set_FBGGFEHDFACFGHG(bool value) { }

	// RVA: 0x11380C8 Offset: 0x11380C8 VA: 0x11380C8
	public bool get_GGCBGCCFEGFDHAA() { }

	// RVA: 0x11380D0 Offset: 0x11380D0 VA: 0x11380D0
	public void set_GGCBGCCFEGFDHAA(bool value) { }

	// RVA: 0x11380DC Offset: 0x11380DC VA: 0x11380DC
	public HAACHBDEFGBGEEH get_DFCGCDFHEBCHHFG() { }

	// RVA: 0x11380E4 Offset: 0x11380E4 VA: 0x11380E4
	private void set_DFCGCDFHEBCHHFG(HAACHBDEFGBGEEH value) { }

	// RVA: 0x11380EC Offset: 0x11380EC VA: 0x11380EC
	public HAACHBDEFGBGEEH get_BGAAFCDEGAECEFC() { }

	// RVA: 0x11380F4 Offset: 0x11380F4 VA: 0x11380F4
	private void set_BGAAFCDEGAECEFC(HAACHBDEFGBGEEH value) { }

	// RVA: 0x11380FC Offset: 0x11380FC VA: 0x11380FC Slot: 6
	public virtual void GGFHGHDEHFFEHHA() { }

	// RVA: 0x1138174 Offset: 0x1138174 VA: 0x1138174 Slot: 7
	public virtual void CGEGDGDACCBGCBH(bool FFCEBFHFCBCGEFC) { }

	// RVA: 0x1137FDC Offset: 0x1137FDC VA: 0x1137FDC
	public Transform EDCEFGEGAHEAAEG() { }

	// RVA: 0x11385E4 Offset: 0x11385E4 VA: 0x11385E4 Slot: 8
	public virtual void AAEDEDCEDCADEBG() { }

	// RVA: 0x113807C Offset: 0x113807C VA: 0x113807C
	public bool FEAEFCFEHGBFBEC() { }

	// RVA: 0x113809C Offset: 0x113809C VA: 0x113809C
	public bool DDHFHDBGCDCBCAE() { }

	// RVA: 0x11385F4 Offset: 0x11385F4 VA: 0x11385F4 Slot: 9
	public virtual bool DEABHEDFGEDHGHG() { }

	// RVA: 0x1138614 Offset: 0x1138614 VA: 0x1138614 Slot: 10
	public virtual void GFGECHBHEGHCBAA(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x1138620 Offset: 0x1138620 VA: 0x1138620
	public bool GHFEECCDCBCHBFA() { }

	// RVA: 0x1138628 Offset: 0x1138628 VA: 0x1138628
	public void ABHBAEDGAEADCEG(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x1138634 Offset: 0x1138634 VA: 0x1138634
	public HAACHBDEFGBGEEH EHDBEEGBGHHDBDC() { }

	// RVA: 0x113863C Offset: 0x113863C VA: 0x113863C
	private void CBBAAHGHADCHBFC(HAACHBDEFGBGEEH HFACGHHBHBFFFDE) { }

	// RVA: 0x1138644 Offset: 0x1138644 VA: 0x1138644
	public HAACHBDEFGBGEEH HFCHFHFFHEEGEBC() { }

	// RVA: 0x113864C Offset: 0x113864C VA: 0x113864C
	private void EHEECEHGGGGHAGC(HAACHBDEFGBGEEH HFACGHHBHBFFFDE) { }

	// RVA: 0x1138654 Offset: 0x1138654 VA: 0x1138654
	public void AFADGEEDAEAADAB(bool EDGCDBFGCDECEBE) { }

	// RVA: 0x11387A0 Offset: 0x11387A0 VA: 0x11387A0
	public void GFFCHAHGHBGGEBB(bool EDGCDBFGCDECEBE) { }

	// RVA: 0x11386A8 Offset: 0x11386A8 VA: 0x11386A8
	private void GAFFBEGBGDFFCCG() { }

	// RVA: 0x113898C Offset: 0x113898C VA: 0x113898C
	private void EBHBHGBABFGFHBC() { }

	// RVA: 0x1138A68 Offset: 0x1138A68 VA: 0x1138A68
	private void GEEEAABCFDACEAG() { }

	// RVA: 0x11386C0 Offset: 0x11386C0 VA: 0x11386C0
	private void EEHAGBAGDDHADBH() { }

	// RVA: 0x11387CC Offset: 0x11387CC VA: 0x11387CC
	private void HFEDGHGHGCGFDGF() { }

	// RVA: 0x11388AC Offset: 0x11388AC VA: 0x11388AC
	private void DBHBDCGBHBEHDBE() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Bounds BDGEEDCBDGFCCBB();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector3[] FAHAHABCBGGGACA(Vector3 CECBGHHEHABHBBA);

	// RVA: 0x1138B48 Offset: 0x1138B48 VA: 0x1138B48 Slot: 13
	public virtual Vector3 AGCBCHADBHGFFEG() { }

	// RVA: 0x1138B68 Offset: 0x1138B68 VA: 0x1138B68 Slot: 14
	public virtual Vector3[] GFHFEHHCFHCDECE(Vector3 CECBGHHEHABHBBA) { }

	// RVA: 0x1138B74 Offset: 0x1138B74 VA: 0x1138B74
	public void GBHBFHHADCAGDBF() { }

	// RVA: 0x1138B7C Offset: 0x1138B7C VA: 0x1138B7C
	protected void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Main.Inventory
public abstract class InventoryItemDefinition : ScriptableObject // TypeDefIndex: 3562
{
	// Fields
	[SerializeField]
	[DAFCADECBABEBEB]
	private HCAFGHHDFAHHGDC _id; // 0x18

	// Properties
	public HCAFGHHDFAHHGDC Id { get; }
	public int NumId { get; }

	// Methods

	// RVA: 0x1211620 Offset: 0x1211620 VA: 0x1211620
	public HCAFGHHDFAHHGDC get_Id() { }

	// RVA: 0x1211628 Offset: 0x1211628 VA: 0x1211628
	public int get_NumId() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x1211630 Offset: 0x1211630 VA: 0x1211630
	public void FDGHDBCHAFDFDFC(HCAFGHHDFAHHGDC BHDEBDCGBCHHFBF) { }

	// RVA: 0x120EA30 Offset: 0x120EA30 VA: 0x120EA30
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SkinDefinition.<>c // TypeDefIndex: 3595
{
	// Fields
	public static readonly SkinDefinition.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1227C60 Offset: 0x1227C60 VA: 0x1227C60
	private static void .cctor() { }

	// RVA: 0x1227CD0 Offset: 0x1227CD0 VA: 0x1227CD0
	public void .ctor() { }

	// RVA: 0x1227CD8 Offset: 0x1227CD8 VA: 0x1227CD8
	internal string <.cctor>b__4_0(InventoryItemDefinition skin) { }

	// RVA: 0x1227DF4 Offset: 0x1227DF4 VA: 0x1227DF4
	internal string <.cctor>b__4_1(InventoryItemDefinition skin) { }
}

// Namespace: Axlebolt.Standoff.Main.Inventory
public class SkinDefinition : InventoryItemDefinition, ADCEACEBCAEAAEC // TypeDefIndex: 3596
{
	// Fields
	private const string SkinsFolder = "Inventory/Skins";
	[SerializeField]
	private FCCEAGDGDCFDFCC _weaponId; // 0x1C

	// Properties
	public FCCEAGDGDCFDFCC WeaponId { get; }

	// Methods

	// RVA: 0x1227A58 Offset: 0x1227A58 VA: 0x1227A58
	public FCCEAGDGDCFDFCC get_WeaponId() { }

	// RVA: 0x1227A60 Offset: 0x1227A60 VA: 0x1227A60
	private static void .cctor() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x1227C50 Offset: 0x1227C50 VA: 0x1227C50
	public void FEGDFDECHEHABAF(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG) { }

	// RVA: 0x1227C58 Offset: 0x1227C58 VA: 0x1227C58
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GlovesDefinition.<>c // TypeDefIndex: 3811
{
	// Fields
	public static readonly GlovesDefinition.<>c <>9; // 0x0

	// Methods

	// RVA: 0x125DFDC Offset: 0x125DFDC VA: 0x125DFDC
	private static void .cctor() { }

	// RVA: 0x125E04C Offset: 0x125E04C VA: 0x125E04C
	public void .ctor() { }

	// RVA: 0x125E054 Offset: 0x125E054 VA: 0x125E054
	internal string <.cctor>b__2_0(InventoryItemDefinition glovesDefinition) { }
}

// Namespace: Axlebolt.Standoff.Main.Inventory.Gloves
public class GlovesDefinition : InventoryItemDefinition // TypeDefIndex: 3812
{
	// Fields
	private const string GlovesFolder = "Inventory/Gloves";

	// Methods

	// RVA: 0x125DE80 Offset: 0x125DE80 VA: 0x125DE80
	public void .ctor() { }

	// RVA: 0x125DE88 Offset: 0x125DE88 VA: 0x125DE88
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GlovesManager.<BCDGHFGGFADBHGD>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3813
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GlovesManager <>4__this; // 0x20
	private HACBFGCAADHHBFE <loadRequest>5__2; // 0x28
	private GlovesDefinition <definition>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x125E8D4 Offset: 0x125E8D4 VA: 0x125E8D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x125EAB4 Offset: 0x125EAB4 VA: 0x125EAB4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x125EAB8 Offset: 0x125EAB8 VA: 0x125EAB8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x125ECA8 Offset: 0x125ECA8 VA: 0x125ECA8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x125ECB0 Offset: 0x125ECB0 VA: 0x125ECB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x125ECF0 Offset: 0x125ECF0 VA: 0x125ECF0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GlovesManager.<FFDEAECHCGDAAFE>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 3814
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public GlovesDefinition FGDHACDEBCCGFAD; // 0x20
	public ArmsLodGroup EFEBFHFHGBDAAGB; // 0x28
	public GlovesManager <>4__this; // 0x30
	private ResourceRequest <resourceRequest>5__2; // 0x38
	private Material <material>5__3; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x125E9A0 Offset: 0x125E9A0 VA: 0x125E9A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x125ECF8 Offset: 0x125ECF8 VA: 0x125ECF8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x125ECFC Offset: 0x125ECFC VA: 0x125ECFC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x125F01C Offset: 0x125F01C VA: 0x125F01C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x125F024 Offset: 0x125F024 VA: 0x125F024 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x125F064 Offset: 0x125F064 VA: 0x125F064 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Axlebolt.Standoff.Main.Inventory.Gloves
public class GlovesManager : Singleton<GlovesManager> // TypeDefIndex: 3815
{
	// Fields
	private Dictionary<HCAFGHHDFAHHGDC, ACEHGCDAECGHGFA> HAGHEFBAHBGGDHH; // 0x18
	private readonly HashSet<HCAFGHHDFAHHGDC> FBFBHFHDCDHECBB; // 0x20
	private readonly Queue<HACBFGCAADHHBFE> HGCGEFGABCDAEEF; // 0x28
	private ArmsLodGroup BCEFHBCDGHDHCDC; // 0x30
	private HCAFGHHDFAHHGDC GHGGGDCGEDGCDCF; // 0x38

	// Methods

	// RVA: 0x125E0EC Offset: 0x125E0EC VA: 0x125E0EC Slot: 4
	protected override void FBGDAHCFGFDFCCD() { }

	// RVA: 0x125E2B0 Offset: 0x125E2B0 VA: 0x125E2B0
	private void FBBHBHDACBCEGHD() { }

	// RVA: 0x125E4AC Offset: 0x125E4AC VA: 0x125E4AC
	public void BAACABBECFCAAGD(HCAFGHHDFAHHGDC BHDEBDCGBCHHFBF, ArmsLodGroup EFEBFHFHGBDAAGB) { }

	// RVA: 0x125E7C0 Offset: 0x125E7C0 VA: 0x125E7C0
	public void EAFHCCDHABGFADE(ArmsLodGroup EFEBFHFHGBDAAGB) { }

	// RVA: 0x125E798 Offset: 0x125E798 VA: 0x125E798
	private void BGGCCCAAABFFBCG(ACEHGCDAECGHGFA ABHAFHEGAHFBGEF) { }

	// RVA: 0x125E324 Offset: 0x125E324 VA: 0x125E324
	private void FFACGADDAEEDHHE(HCAFGHHDFAHHGDC GDHGGAGHEEEFBCB, ArmsLodGroup EFEBFHFHGBDAAGB) { }

	[IteratorStateMachine(typeof(GlovesManager.<BCDGHFGGFADBHGD>d__11))]
	// RVA: 0x125E860 Offset: 0x125E860 VA: 0x125E860
	private IEnumerator BCDGHFGGFADBHGD() { }

	[IteratorStateMachine(typeof(GlovesManager.<FFDEAECHCGDAAFE>d__12))]
	// RVA: 0x125E8FC Offset: 0x125E8FC VA: 0x125E8FC
	private IEnumerator FFDEAECHCGDAAFE(GlovesDefinition FGDHACDEBCCGFAD, ArmsLodGroup EFEBFHFHGBDAAGB) { }

	// RVA: 0x125E9C8 Offset: 0x125E9C8 VA: 0x125E9C8
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory
public class InventoryParameters : ScriptableObject // TypeDefIndex: 4092
{
	// Fields
	[SerializeField]
	[DAFCADECBABEBEB]
	private FCCEAGDGDCFDFCC _id; // 0x18
	[SerializeField]
	private string _displayName; // 0x20
	[SerializeField]
	private int _cost; // 0x28
	[SerializeField]
	private int _movementRate; // 0x2C
	[SerializeField]
	private WeaponSprites _sprites; // 0x30
	[SerializeField]
	private Team _weaponTeam; // 0x38

	// Properties
	public FCCEAGDGDCFDFCC Id { get; }
	public byte NumId { get; }
	public string DisplayName { get; }
	public int Cost { get; }
	public int MovementRate { get; }
	public WeaponSprites Sprites { get; }
	public Team WeaponTeam { get; }

	// Methods

	// RVA: 0x12C9910 Offset: 0x12C9910 VA: 0x12C9910
	public FCCEAGDGDCFDFCC get_Id() { }

	// RVA: 0x12C9918 Offset: 0x12C9918 VA: 0x12C9918
	public byte get_NumId() { }

	// RVA: 0x12C9920 Offset: 0x12C9920 VA: 0x12C9920
	public string get_DisplayName() { }

	// RVA: 0x12C9928 Offset: 0x12C9928 VA: 0x12C9928
	public int get_Cost() { }

	// RVA: 0x12C9930 Offset: 0x12C9930 VA: 0x12C9930
	public int get_MovementRate() { }

	// RVA: 0x12C9938 Offset: 0x12C9938 VA: 0x12C9938
	public WeaponSprites get_Sprites() { }

	// RVA: 0x12C9940 Offset: 0x12C9940 VA: 0x12C9940
	public Team get_WeaponTeam() { }

	// RVA: 0x12C9948 Offset: 0x12C9948 VA: 0x12C9948
	public bool AAGBCCCEADFCBEC(Team FCFFBABADHDCFHG) { }

	// RVA: 0x12C9964 Offset: 0x12C9964 VA: 0x12C9964 Slot: 4
	public virtual int GDECCGGCHCGGBED() { }

	// RVA: 0x12C9908 Offset: 0x12C9908 VA: 0x12C9908
	public void .ctor() { }
}

// Namespace: 
public enum KnifeController.FCEHABDCDHCBEGF // TypeDefIndex: 4094
{
	// Fields
	public int value__; // 0x0
	public const KnifeController.FCEHABDCDHCBEGF Switching = 2;
	public const KnifeController.FCEHABDCDHCBEGF TryToSwitch = 3;
	public const KnifeController.FCEHABDCDHCBEGF Ready = 4;
}

// Namespace: Axlebolt.Standoff.Inventory
[RequireComponent(typeof(KnifeSoundController))]
public class KnifeController : WeaponController // TypeDefIndex: 4095
{
	// Fields
	private KnifeParameters EFCADEACGACCDCE; // 0xC8
	private StateSimple<KnifeController.FCEHABDCDHCBEGF> FFCFABAEBHBHFGE; // 0xD0
	private readonly float EHHEHHBGGFADDFC; // 0xD8
	private float HFDEAFHCHEBHACB; // 0xDC
	private KnifeSoundController DEGABHCBBBGEHBD; // 0xE0

	// Properties
	public override DGAABFCHGEFDACC CHCBHHDFGEDAEDA { get; }

	// Methods

	// RVA: 0x12CAA6C Offset: 0x12CAA6C VA: 0x12CAA6C Slot: 4
	public override DGAABFCHGEFDACC get_CHCBHHDFGEDAEDA() { }

	// RVA: 0x12CAA78 Offset: 0x12CAA78 VA: 0x12CAA78 Slot: 5
	public override DGAABFCHGEFDACC FHEEEFAEHBFEHHH() { }

	// RVA: 0x12CAA80 Offset: 0x12CAA80 VA: 0x12CAA80 Slot: 6
	public override void GGFHGHDEHFFEHHA(ACBGGCCAECBFDAH GBFACFCGBBDAEFC) { }

	// RVA: 0x12CB050 Offset: 0x12CB050 VA: 0x12CB050 Slot: 16
	public override DGHHHHFFAAEAHCF CCHAAGHDDABHDDC() { }

	// RVA: 0x12CB0D0 Offset: 0x12CB0D0 VA: 0x12CB0D0 Slot: 17
	public override void HAEEFHHBFEEGFHH(DGHHHHFFAAEAHCF BBGCCGGCECAHFFE) { }

	// RVA: 0x12CB1D0 Offset: 0x12CB1D0 VA: 0x12CB1D0 Slot: 18
	public override void FHAGFDFBAHEACHH(FFDACAFCHDFEEGB ECCCGADGAHBEDFC, float CAGGBAGGHFFGEEF, float GCABCDEGACEABFA) { }

	// RVA: 0x12CB180 Offset: 0x12CB180 VA: 0x12CB180
	private void FCDGGDEHBFEGBFA() { }

	// RVA: 0x12CB4F4 Offset: 0x12CB4F4 VA: 0x12CB4F4 Slot: 9
	public override void GAGHFHDCEFCFFBC(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x12CB638 Offset: 0x12CB638 VA: 0x12CB638 Slot: 11
	public override void FDDEHBACBDFACGF(float GCABCDEGACEABFA) { }

	// RVA: 0x12CB9A4 Offset: 0x12CB9A4 VA: 0x12CB9A4
	private void CAHDHFHGEAHACDA(Vector3 ACDAHADHAEDHFFC, Vector3 ADCHAFFHEEGGDCC, bool FDBAGFDBFAEBDDF) { }

	// RVA: 0x12CBF44 Offset: 0x12CBF44 VA: 0x12CBF44
	private void AFCFACBHFDEBAGH(IList<HEHCBBHCDBABCBD> CEDABHHFAFEBGBG) { }

	// RVA: 0x12CB370 Offset: 0x12CB370 VA: 0x12CB370
	private void BBADEAAAGCFGFHF() { }

	// RVA: 0x12CB28C Offset: 0x12CB28C VA: 0x12CB28C
	private void GGADECAGEEACEBB() { }

	// RVA: 0x12CC02C Offset: 0x12CC02C VA: 0x12CC02C Slot: 21
	public override BCDGABDFHACCDDH DEAACGEFGBFCGCC() { }

	// RVA: 0x12CC07C Offset: 0x12CC07C VA: 0x12CC07C Slot: 22
	public override BCDGABDFHACCDDH AFDGCGFHGECAAEG() { }

	// RVA: 0x12CC0CC Offset: 0x12CC0CC VA: 0x12CC0CC
	private void ECDDFHAGHBGBCBA() { }

	// RVA: 0x12CC1B0 Offset: 0x12CC1B0 VA: 0x12CC1B0
	public void .ctor() { }
}

// Namespace: 
public enum WeaponController.CGEBHAFEAFEEACE // TypeDefIndex: 4098
{
	// Fields
	public int value__; // 0x0
	public const WeaponController.CGEBHAFEAFEEACE Primary = 0;
	public const WeaponController.CGEBHAFEAFEEACE Secondary = 1;
	public const WeaponController.CGEBHAFEAFEEACE NotStated = 2;
}

// Namespace: 
public enum WeaponController.CCECBFGFCBBEEFH // TypeDefIndex: 4099
{
	// Fields
	public byte value__; // 0x0
	public const WeaponController.CCECBFGFCBBEEFH JustSwitched = 0;
	public const WeaponController.CCECBFGFCBBEEFH WaitingSwitchAnimation = 1;
	public const WeaponController.CCECBFGFCBBEEFH SetVisible = 2;
}

// Namespace: Axlebolt.Standoff.Inventory
[RequireComponent(typeof(WeaponPatternController))]
[RequireComponent(typeof(WeaponStatTrackController))]
[RequireComponent(typeof(WeaponCharmController))]
[RequireComponent(typeof(WeaponMap))]
[RequireComponent(typeof(WeaponLodGroup))]
[RequireComponent(typeof(WeaponStickersController))]
[RequireComponent(typeof(WeaponAnimationController))]
[RequireComponent(typeof(WeaponMaterialController))]
public abstract class WeaponController : MonoBehaviour // TypeDefIndex: 4100
{
	// Fields
	internal const int AGGADDADEFHBHHF = 0;
	internal const int DEDHGGABEDCCAHB = 1;
	private const float HGEGHEGHHABDECG = 0,5;
	internal PlayerController FDGHEEAGGDGCGAE; // 0x18
	internal MecanimController DFCFCCABBACFHGA; // 0x20
	internal WeaponAnimationController DDBBBFCEBBGCAAH; // 0x28
	internal WeaponAnimationParameters FEGCHCGHBCEECCG; // 0x30
	protected WeaponController.CCECBFGFCBBEEFH DFDCFEGHGAGBBDB; // 0x38
	protected bool HEBGBFCBCCFEFGA; // 0x39
	private float CHDAEHHBGDDDEAD; // 0x3C
	private float HHGFDFEABBGEBEB; // 0x40
	private WeaponLodGroup DCHDGDHEAAFGHGE; // 0x48
	private WeaponController.CGEBHAFEAFEEACE BGAFFCACHHFDFCF; // 0x50
	private byte DDBHHFDAHGFGCGG; // 0x54
	private string GHEHCCDFHHHGDEH; // 0x58
	private int DCEFHCCADCGGFFG; // 0x60
	private WeaponParameters AGBGHFCGHDFBHDB; // 0x68
	private WeaponMap DDGDDDDEBEEEBGD; // 0x70
	protected BAAFADDFCADEHEA AGBDDHFFGFGDBAH; // 0x78
	protected Action CFDHABAHGHEHDBF; // 0x80
	protected Action GEAFECFHADEFEGD; // 0x88
	private Transform CBCBGACGGECGEAA; // 0x90
	private byte HHGDCDCBDGHDCDC; // 0x98
	private bool AFCCFABBAHAFAEE; // 0x99
	private WeaponStatTrackController DGEEABEEDAHHEHA; // 0xA0
	private Controller[] FBHAHGDECHGBHEE; // 0xA8
	private WeaponMaterialController BHDEAEGFEDCCDEF; // 0xB0
	private FBDAGHFAHECEGAB GBADHEGGHHAEGGH; // 0xB8
	protected FFDACAFCHDFEEGB CDDAEGHAHDCGDCB; // 0xC0

	// Properties
	public float AEGGFHEGDACDBDD { get; set; }
	public float HDDHEDGDFDCEADB { get; set; }
	public WeaponLodGroup GACCCAFEDCDAEFC { get; set; }
	public WeaponController.CGEBHAFEAFEEACE BBBGABECHGBGHBA { get; set; }
	public FCCEAGDGDCFDFCC HGACDDEBAGEGGHG { get; }
	public byte ADDHBEABEBBGCDA { get; }
	public byte HCGBGGCAEEABBHF { get; set; }
	public string BFHHCEDEBACAHEC { get; set; }
	public HCAFGHHDFAHHGDC AHGGCGAABDCHFEA { get; }
	public int AHEAFDCGBHFEGHF { get; }
	public int DADCEGBGBAADFGE { get; set; }
	public bool FHBGHFDCGECEAGA { get; }
	public WeaponParameters ABGCEGHCDDDBABF { get; set; }
	public WeaponMap GHFDGGBDGEGDDDA { get; set; }
	public abstract DGAABFCHGEFDACC CHCBHHDFGEDAEDA { get; }
	public Transform FAFCFFABDEEBFAH { get; }
	public byte EFFGFABHHBABAEC { get; set; }
	public bool DGBHGFCEACBEHBA { get; set; }
	public WeaponStatTrackController HHGGHADBAEBDAHE { get; set; }
	public WeaponMaterialController DCFABFEFCEDFADF { get; set; }

	// Methods

	// RVA: 0x12CB178 Offset: 0x12CB178 VA: 0x12CB178
	public float get_AEGGFHEGDACDBDD() { }

	// RVA: 0x12CC3A8 Offset: 0x12CC3A8 VA: 0x12CC3A8
	private void set_AEGGFHEGDACDBDD(float value) { }

	// RVA: 0x12CC3B0 Offset: 0x12CC3B0 VA: 0x12CC3B0
	public float get_HDDHEDGDFDCEADB() { }

	// RVA: 0x12CC3B8 Offset: 0x12CC3B8 VA: 0x12CC3B8
	private void set_HDDHEDGDFDCEADB(float value) { }

	// RVA: 0x12CC3C0 Offset: 0x12CC3C0 VA: 0x12CC3C0
	public WeaponLodGroup get_GACCCAFEDCDAEFC() { }

	// RVA: 0x12CC3C8 Offset: 0x12CC3C8 VA: 0x12CC3C8
	private void set_GACCCAFEDCDAEFC(WeaponLodGroup value) { }

	// RVA: 0x12CC3D0 Offset: 0x12CC3D0 VA: 0x12CC3D0
	public WeaponController.CGEBHAFEAFEEACE get_BBBGABECHGBGHBA() { }

	// RVA: 0x12CC3D8 Offset: 0x12CC3D8 VA: 0x12CC3D8
	protected void set_BBBGABECHGBGHBA(WeaponController.CGEBHAFEAFEEACE value) { }

	// RVA: 0x12CC3E0 Offset: 0x12CC3E0 VA: 0x12CC3E0
	public FCCEAGDGDCFDFCC get_HGACDDEBAGEGGHG() { }

	// RVA: 0x12CC418 Offset: 0x12CC418 VA: 0x12CC418
	public byte get_ADDHBEABEBBGCDA() { }

	// RVA: 0x12CC024 Offset: 0x12CC024 VA: 0x12CC024
	public byte get_HCGBGGCAEEABBHF() { }

	// RVA: 0x12CC450 Offset: 0x12CC450 VA: 0x12CC450
	private void set_HCGBGGCAEEABBHF(byte value) { }

	// RVA: 0x12CC01C Offset: 0x12CC01C VA: 0x12CC01C
	public string get_BFHHCEDEBACAHEC() { }

	// RVA: 0x12CC458 Offset: 0x12CC458 VA: 0x12CC458
	private void set_BFHHCEDEBACAHEC(string value) { }

	// RVA: 0x12CC460 Offset: 0x12CC460 VA: 0x12CC460
	public HCAFGHHDFAHHGDC get_AHGGCGAABDCHFEA() { }

	// RVA: 0x12CC498 Offset: 0x12CC498 VA: 0x12CC498
	public int get_AHEAFDCGBHFEGHF() { }

	// RVA: 0x12CBF3C Offset: 0x12CBF3C VA: 0x12CBF3C
	public int get_DADCEGBGBAADFGE() { }

	// RVA: 0x12CC4D0 Offset: 0x12CC4D0 VA: 0x12CC4D0
	private void set_DADCEGBGBAADFGE(int value) { }

	// RVA: 0x12CC4D8 Offset: 0x12CC4D8 VA: 0x12CC4D8
	public bool get_FHBGHFDCGECEAGA() { }

	// RVA: 0x12CAA34 Offset: 0x12CAA34 VA: 0x12CAA34
	public WeaponParameters get_ABGCEGHCDDDBABF() { }

	// RVA: 0x12CC50C Offset: 0x12CC50C VA: 0x12CC50C
	private void set_ABGCEGHCDDDBABF(WeaponParameters value) { }

	// RVA: 0x12CB4E4 Offset: 0x12CB4E4 VA: 0x12CB4E4
	public WeaponMap get_GHFDGGBDGEGDDDA() { }

	// RVA: 0x12CC514 Offset: 0x12CC514 VA: 0x12CC514
	private void set_GHFDGGBDGEGDDDA(WeaponMap value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DGAABFCHGEFDACC get_CHCBHHDFGEDAEDA();

	// RVA: 0x12CC51C Offset: 0x12CC51C VA: 0x12CC51C
	public Transform get_FAFCFFABDEEBFAH() { }

	// RVA: 0x12CC5B0 Offset: 0x12CC5B0 VA: 0x12CC5B0
	public byte get_EFFGFABHHBABAEC() { }

	// RVA: 0x12CC5B8 Offset: 0x12CC5B8 VA: 0x12CC5B8
	private void set_EFFGFABHHBABAEC(byte value) { }

	// RVA: 0x12CC5C0 Offset: 0x12CC5C0 VA: 0x12CC5C0
	public bool get_DGBHGFCEACBEHBA() { }

	// RVA: 0x12CC5C8 Offset: 0x12CC5C8 VA: 0x12CC5C8
	private void set_DGBHGFCEACBEHBA(bool value) { }

	// RVA: 0x12CC5D4 Offset: 0x12CC5D4 VA: 0x12CC5D4
	public WeaponStatTrackController get_HHGGHADBAEBDAHE() { }

	// RVA: 0x12CC5DC Offset: 0x12CC5DC VA: 0x12CC5DC
	private void set_HHGGHADBAEBDAHE(WeaponStatTrackController value) { }

	// RVA: 0x12CBF2C Offset: 0x12CBF2C VA: 0x12CBF2C
	public WeaponMaterialController get_DCFABFEFCEDFADF() { }

	// RVA: 0x12CC5E4 Offset: 0x12CC5E4 VA: 0x12CC5E4
	private void set_DCFABFEFCEDFADF(WeaponMaterialController value) { }

	// RVA: 0x12CAA54 Offset: 0x12CAA54 VA: 0x12CAA54
	protected void .ctor() { }

	// RVA: 0x12CC5EC Offset: 0x12CC5EC VA: 0x12CC5EC
	public float DGFGBABDHABEBDH() { }

	// RVA: 0x12CC5F4 Offset: 0x12CC5F4 VA: 0x12CC5F4
	private void FGFAGDBGCEEAGCF(float HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC5FC Offset: 0x12CC5FC VA: 0x12CC5FC
	public float FBEFHHFFACAEEEF() { }

	// RVA: 0x12CC604 Offset: 0x12CC604 VA: 0x12CC604
	private void CAFACDBAGECGCDD(float HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC60C Offset: 0x12CC60C VA: 0x12CC60C
	public WeaponLodGroup EEGGAGFAADBCCCF() { }

	// RVA: 0x12CC614 Offset: 0x12CC614 VA: 0x12CC614
	private void CAAGGGDACEBBHEH(WeaponLodGroup HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC61C Offset: 0x12CC61C VA: 0x12CC61C
	public WeaponController.CGEBHAFEAFEEACE GBAHGBAGACAHGHE() { }

	// RVA: 0x12CC624 Offset: 0x12CC624 VA: 0x12CC624
	protected void FGBCCCCGHDAAADA(WeaponController.CGEBHAFEAFEEACE HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC3FC Offset: 0x12CC3FC VA: 0x12CC3FC
	public FCCEAGDGDCFDFCC FGDCGFHAADFCEEB() { }

	// RVA: 0x12CC434 Offset: 0x12CC434 VA: 0x12CC434
	public byte AFCDFHHGACBEDBH() { }

	// RVA: 0x12CC62C Offset: 0x12CC62C VA: 0x12CC62C
	public byte EFCFGGCCGAGHAHF() { }

	// RVA: 0x12CC634 Offset: 0x12CC634 VA: 0x12CC634
	private void CEDECBBCDGABDHD(byte HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC63C Offset: 0x12CC63C VA: 0x12CC63C
	public string HDHADAAAGAFFBHC() { }

	// RVA: 0x12CC644 Offset: 0x12CC644 VA: 0x12CC644
	private void FHHBBDDEECBEHDD(string HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC47C Offset: 0x12CC47C VA: 0x12CC47C
	public HCAFGHHDFAHHGDC HACHCEGABDGABGF() { }

	// RVA: 0x12CC4B4 Offset: 0x12CC4B4 VA: 0x12CC4B4
	public int HHCFHDCDBABHCFH() { }

	// RVA: 0x12CC64C Offset: 0x12CC64C VA: 0x12CC64C
	public int EEDEDGDDCHAAGGB() { }

	// RVA: 0x12CC654 Offset: 0x12CC654 VA: 0x12CC654
	private void ABDGGHAEFHCEFGG(int HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC4DC Offset: 0x12CC4DC VA: 0x12CC4DC
	public bool FBBAGHCHHEHGBEB() { }

	// RVA: 0x12CC65C Offset: 0x12CC65C VA: 0x12CC65C
	public WeaponParameters GAAHCBHGGAAFHEA() { }

	// RVA: 0x12CC664 Offset: 0x12CC664 VA: 0x12CC664
	private void DHAGEFEEBEDFDHB(WeaponParameters HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC66C Offset: 0x12CC66C VA: 0x12CC66C
	public WeaponMap ECDFGFEDFAAAHBC() { }

	// RVA: 0x12CC674 Offset: 0x12CC674 VA: 0x12CC674
	private void DEDHFAFFCHHGDBD(WeaponMap HFACGHHBHBFFFDE) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DGAABFCHGEFDACC FHEEEFAEHBFEHHH();

	// RVA: 0x12CC520 Offset: 0x12CC520 VA: 0x12CC520
	public Transform EDCEFGEGAHEAAEG() { }

	// RVA: 0x12CC67C Offset: 0x12CC67C VA: 0x12CC67C
	public byte HCBGCEAHGABBBCE() { }

	// RVA: 0x12CC684 Offset: 0x12CC684 VA: 0x12CC684
	private void EAFHAEHCDDECBHD(byte HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC68C Offset: 0x12CC68C VA: 0x12CC68C
	public bool BEBEDAHHHGEAFHH() { }

	// RVA: 0x12CC694 Offset: 0x12CC694 VA: 0x12CC694
	private void CDGHAHCCEHCFECF(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC6A0 Offset: 0x12CC6A0 VA: 0x12CC6A0
	public WeaponStatTrackController FBDAGHAEABBDFAF() { }

	// RVA: 0x12CC6A8 Offset: 0x12CC6A8 VA: 0x12CC6A8
	private void DEGBABBADDDEDCH(WeaponStatTrackController HFACGHHBHBFFFDE) { }

	// RVA: 0x12CAB5C Offset: 0x12CAB5C VA: 0x12CAB5C Slot: 6
	public virtual void GGFHGHDEHFFEHHA(ACBGGCCAECBFDAH BFGFADDCACFBCDD) { }

	// RVA: 0x12CD2B8 Offset: 0x12CD2B8 VA: 0x12CD2B8 Slot: 7
	public virtual void CGEGDGDACCBGCBH(int GDHDFBDACDGAEEE, HCAFGHHDFAHHGDC CCEDDCCFEFAHFBF) { }

	// RVA: 0x12CD358 Offset: 0x12CD358 VA: 0x12CD358 Slot: 8
	public virtual void AAEDEDCEDCADEBG() { }

	// RVA: 0x12CD438 Offset: 0x12CD438 VA: 0x12CD438
	public WeaponMaterialController AHCBEAFFAFHCGEG() { }

	// RVA: 0x12CD440 Offset: 0x12CD440 VA: 0x12CD440
	private void BDBFDDEGGHCEHEG(WeaponMaterialController HFACGHHBHBFFFDE) { }

	// RVA: 0x12CB50C Offset: 0x12CB50C VA: 0x12CB50C Slot: 9
	public virtual void GAGHFHDCEFCFFBC(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x12CD448 Offset: 0x12CD448 VA: 0x12CD448
	private void EEAEAADDHHEBDHF(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x12CD4B4 Offset: 0x12CD4B4 VA: 0x12CD4B4
	public void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x12CD520 Offset: 0x12CD520 VA: 0x12CD520 Slot: 10
	public virtual void CGEHBBBHECABDEB(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x12CDF48 Offset: 0x12CDF48 VA: 0x12CDF48
	public int CFEHCHBEDDAEBDC() { }

	// RVA: 0x12CDF5C Offset: 0x12CDF5C VA: 0x12CDF5C
	public bool CCGBEGHFGFFEAEE() { }

	// RVA: 0x12CDF6C Offset: 0x12CDF6C VA: 0x12CDF6C
	public bool FDEEGBFGFGFDGEF() { }

	// RVA: 0x12CB6A8 Offset: 0x12CB6A8 VA: 0x12CB6A8 Slot: 11
	public virtual void FDDEHBACBDFACGF(float GCABCDEGACEABFA) { }

	// RVA: 0x12CDF7C Offset: 0x12CDF7C VA: 0x12CDF7C Slot: 12
	public virtual void DGBCGHDBBCBEBBE() { }

	// RVA: 0x12CE190 Offset: 0x12CE190 VA: 0x12CE190 Slot: 13
	public virtual AccuracyData AEFAEGGFADGCEFE() { }

	// RVA: 0x12CE1EC Offset: 0x12CE1EC VA: 0x12CE1EC
	public void ABFGCGEBFEDCAEF() { }

	// RVA: 0x12CE220 Offset: 0x12CE220 VA: 0x12CE220
	public void HGHBHDHECDAHGAG() { }

	// RVA: 0x12CE254 Offset: 0x12CE254 VA: 0x12CE254
	private bool DFABCCCDCDGGAHB() { }

	// RVA: 0x12CE2A4 Offset: 0x12CE2A4 VA: 0x12CE2A4 Slot: 14
	public virtual void AFFFCAHCAFCBHFG() { }

	// RVA: 0x12CE4AC Offset: 0x12CE4AC VA: 0x12CE4AC Slot: 15
	public virtual void EHDGAFGBFGGHHHE() { }

	// RVA: 0x12CE4B0 Offset: 0x12CE4B0 VA: 0x12CE4B0
	private void CFEHHBHGAAHFDAC() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract DGHHHHFFAAEAHCF CCHAAGHDDABHDDC();

	// RVA: 0x12CB13C Offset: 0x12CB13C VA: 0x12CB13C Slot: 17
	public virtual void HAEEFHHBFEEGFHH(DGHHHHFFAAEAHCF BBGCCGGCECAHFFE) { }

	// RVA: 0x12CB278 Offset: 0x12CB278 VA: 0x12CB278 Slot: 18
	public virtual void FHAGFDFBAHEACHH(FFDACAFCHDFEEGB ECCCGADGAHBEDFC, float CAGGBAGGHFFGEEF, float GCABCDEGACEABFA) { }

	// RVA: 0x12CE54C Offset: 0x12CE54C VA: 0x12CE54C Slot: 19
	public virtual void GFEFDFCEEDCEDGE(bool AABHCHCBEDGECHD) { }

	// RVA: 0x12CE848 Offset: 0x12CE848 VA: 0x12CE848 Slot: 20
	public virtual void AFADGEEDAEAADAB(bool EDGCDBFGCDECEBE) { }

	// RVA: 0x12CE8C0 Offset: 0x12CE8C0 VA: 0x12CE8C0
	private void HCFADADFEFABBCC(FHBCCGDEGHFBEAF FCACBHCDGBAHEAB, bool GHDGCBCFGFCCAFD) { }

	// RVA: 0x12CEB74 Offset: 0x12CEB74 VA: 0x12CEB74
	public FHBCCGDEGHFBEAF BFAHDAHEDDCHDBG(bool GHDGCBCFGFCCAFD) { }

	// RVA: 0x12CEE10 Offset: 0x12CEE10 VA: 0x12CEE10 Slot: 21
	public virtual BCDGABDFHACCDDH DEAACGEFGBFCGCC() { }

	// RVA: 0x12CEE60 Offset: 0x12CEE60 VA: 0x12CEE60 Slot: 22
	public virtual BCDGABDFHACCDDH AFDGCGFHGECAAEG() { }
}

// Namespace: Axlebolt.Standoff.Inventory
public class WeaponLodGroup : MonoBehaviour // TypeDefIndex: 4103
{
	// Fields
	private static readonly FDFDGBABCCCGEFE EDDFBAGEBAHEDCE; // 0x0
	private const string BAGAFEEAGAFGHEC = "TemplateDrop";
	[SerializeField]
	private MeshLodLayerInfo[] _weaponLayers; // 0x18
	[SerializeField]
	private bool _initialized; // 0x20
	[SerializeField]
	private MeshFilter[] _activeLodChildren; // 0x28
	[SerializeField]
	private SkinnedMeshRenderer[] _childSkinnedMeshRenderers; // 0x30
	[SerializeField]
	private MeshFilter _activeLod; // 0x38
	[SerializeField]
	private MeshRenderer[] _meshRenderers; // 0x40
	private MeshRenderer FDGGAAFGEGFHBAF; // 0x48
	private Transform CBCBGACGGECGEAA; // 0x50
	private FCCEAGDGDCFDFCC GDHBHHCCDEGAGAC; // 0x58
	private bool DGEDDFDGHGBCBEH; // 0x59
	private int BFCBAHEFAADBBFB; // 0x5C

	// Properties
	public Transform FAFCFFABDEEBFAH { get; }
	public bool HGBDDAAEACAEAHF { get; set; }
	public MeshRenderer CECAHGAEEGEADFH { get; }
	public MeshRenderer[] HABEFHFEFHCABEA { get; }
	public SkinnedMeshRenderer[] EHAADGFEDHBEADF { get; }
	public int CCCFHBAAHFFHEED { get; set; }

	// Methods

	// RVA: 0x12CEF3C Offset: 0x12CEF3C VA: 0x12CEF3C
	public Transform get_FAFCFFABDEEBFAH() { }

	// RVA: 0x12CEF44 Offset: 0x12CEF44 VA: 0x12CEF44
	public bool get_HGBDDAAEACAEAHF() { }

	// RVA: 0x12CEF4C Offset: 0x12CEF4C VA: 0x12CEF4C
	private void set_HGBDDAAEACAEAHF(bool value) { }

	// RVA: 0x12CEF58 Offset: 0x12CEF58 VA: 0x12CEF58
	public MeshRenderer get_CECAHGAEEGEADFH() { }

	// RVA: 0x12CEF88 Offset: 0x12CEF88 VA: 0x12CEF88
	public MeshRenderer[] get_HABEFHFEFHCABEA() { }

	// RVA: 0x12CEFB8 Offset: 0x12CEFB8 VA: 0x12CEFB8
	public SkinnedMeshRenderer[] get_EHAADGFEDHBEADF() { }

	// RVA: 0x12CEFE8 Offset: 0x12CEFE8 VA: 0x12CEFE8
	public int get_CCCFHBAAHFFHEED() { }

	// RVA: 0x12CEFF0 Offset: 0x12CEFF0 VA: 0x12CEFF0
	private void set_CCCFHBAAHFFHEED(int value) { }

	// RVA: 0x12CEFF8 Offset: 0x12CEFF8 VA: 0x12CEFF8
	public void CGEGDGDACCBGCBH(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG) { }

	// RVA: 0x12CFD10 Offset: 0x12CFD10 VA: 0x12CFD10
	public Transform EDCEFGEGAHEAAEG() { }

	// RVA: 0x12CF80C Offset: 0x12CF80C VA: 0x12CF80C
	private void HDACHBEBAEAFCGF() { }

	// RVA: 0x12CFD18 Offset: 0x12CFD18 VA: 0x12CFD18
	private WeaponLod EEFEEHDHCBDBFAF(int ECGCGGAHGFDADAH, int ADFEHHGHGFDFDFC) { }

	// RVA: 0x12CFE6C Offset: 0x12CFE6C VA: 0x12CFE6C
	public void AFECBDBBHGBGAAH() { }

	// RVA: 0x12CF23C Offset: 0x12CF23C VA: 0x12CF23C
	private void HEGDDFCFBGCACGD(Transform GCEAHEEHFGBCDEE) { }

	// RVA: 0x12CF9B0 Offset: 0x12CF9B0 VA: 0x12CF9B0
	private void HCCDDGABBBCECHH() { }

	// RVA: 0x12D0058 Offset: 0x12D0058 VA: 0x12D0058
	private void HDFEGGGGAAAHEAA(Transform GCEAHEEHFGBCDEE) { }

	// RVA: 0x12D030C Offset: 0x12D030C VA: 0x12D030C
	public void GCBBEAEGEFBAGEE() { }

	// RVA: 0x12D04B0 Offset: 0x12D04B0 VA: 0x12D04B0
	public void BFBDBDHHEFABGBH() { }

	// RVA: 0x12D0650 Offset: 0x12D0650 VA: 0x12D0650
	public bool BCCDCCGFHEAEAGB() { }

	// RVA: 0x12D0658 Offset: 0x12D0658 VA: 0x12D0658
	private void DCFAGCAHAGHHEGB(bool HFACGHHBHBFFFDE) { }

	// RVA: 0x12CEF70 Offset: 0x12CEF70 VA: 0x12CEF70
	public MeshRenderer EBBFHHFDFGECDBB() { }

	// RVA: 0x12CEFA0 Offset: 0x12CEFA0 VA: 0x12CEFA0
	public MeshRenderer[] AAGFHDDEFEHHEFE() { }

	// RVA: 0x12CEFD0 Offset: 0x12CEFD0 VA: 0x12CEFD0
	public SkinnedMeshRenderer[] CHCBDBGCFHEDDFF() { }

	// RVA: 0x12CE5B0 Offset: 0x12CE5B0 VA: 0x12CE5B0
	public void BCBHDGGDCHCCEGG(bool EEBCHBHEBGCADGB) { }

	// RVA: 0x12D0664 Offset: 0x12D0664 VA: 0x12D0664
	public void CCAFBGBACGBGHAC(Material ABHAFHEGAHFBGEF) { }

	// RVA: 0x12D0888 Offset: 0x12D0888 VA: 0x12D0888
	public int DADHABBABCDHDCH() { }

	// RVA: 0x12D0890 Offset: 0x12D0890 VA: 0x12D0890
	private void FEGBFBCDEBCDFGD(int HFACGHHBHBFFFDE) { }

	// RVA: 0x12CDD70 Offset: 0x12CDD70 VA: 0x12CDD70
	public void AHHABDGEFFHHAAG(int GFAFFDCFEEABADD) { }

	// RVA: 0x12CFAB4 Offset: 0x12CFAB4 VA: 0x12CFAB4
	private void DABBCFGGFBCFEEH() { }

	// RVA: 0x12CFFA8 Offset: 0x12CFFA8 VA: 0x12CFFA8
	private void CGHDEGGAGBABDCH() { }

	// RVA: 0x12D0898 Offset: 0x12D0898 VA: 0x12D0898
	public void .ctor() { }

	// RVA: 0x12D08A0 Offset: 0x12D08A0 VA: 0x12D08A0
	private static void .cctor() { }
}

// Namespace: 
public enum WeaponMap.DHCGBABEGAHEHEF // TypeDefIndex: 4106
{
	// Fields
	public int value__; // 0x0
	public const WeaponMap.DHCGBABEGAHEHEF None = 0;
	public const WeaponMap.DHCGBABEGAHEHEF Magazine1 = 1;
	public const WeaponMap.DHCGBABEGAHEHEF Magazine2 = 2;
	public const WeaponMap.DHCGBABEGAHEHEF Magazine3 = 3;
	public const WeaponMap.DHCGBABEGAHEHEF Gunlock1 = 4;
	public const WeaponMap.DHCGBABEGAHEHEF Gunlock2 = 5;
	public const WeaponMap.DHCGBABEGAHEHEF Gunlock3 = 15;
	public const WeaponMap.DHCGBABEGAHEHEF Gunlock4 = 20;
	public const WeaponMap.DHCGBABEGAHEHEF Gunlock5 = 21;
	public const WeaponMap.DHCGBABEGAHEHEF Weapon = 6;
	public const WeaponMap.DHCGBABEGAHEHEF MuzzlePoint = 7;
	public const WeaponMap.DHCGBABEGAHEHEF Sight = 8;
	public const WeaponMap.DHCGBABEGAHEHEF CollimatorSight = 9;
	public const WeaponMap.DHCGBABEGAHEHEF SightLense = 10;
	public const WeaponMap.DHCGBABEGAHEHEF SightReticle = 11;
	public const WeaponMap.DHCGBABEGAHEHEF Cartridge1 = 12;
	public const WeaponMap.DHCGBABEGAHEHEF Cartridge2 = 13;
	public const WeaponMap.DHCGBABEGAHEHEF StatTrack = 14;
	public const WeaponMap.DHCGBABEGAHEHEF Handle1 = 16;
	public const WeaponMap.DHCGBABEGAHEHEF Handle2 = 17;
	public const WeaponMap.DHCGBABEGAHEHEF Blade1 = 18;
	public const WeaponMap.DHCGBABEGAHEHEF MuzzlePoint2 = 19;
	public const WeaponMap.DHCGBABEGAHEHEF Switch = 22;
	public const WeaponMap.DHCGBABEGAHEHEF EffectEmitterPoint1 = 23;
	public const WeaponMap.DHCGBABEGAHEHEF EffectEmitterPoint2 = 24;
}

// Namespace: Axlebolt.Standoff.Inventory
public class WeaponMap : MonoBehaviour // TypeDefIndex: 4107
{
	// Fields
	private GameObject BEDGAFFBBCDAEGA; // 0x18
	private GameObject HFDAGAEAFBCGGGF; // 0x20
	private GameObject ACFHCBGEBAGBECF; // 0x28
	private GameObject ACGEGDDDHDCGBGF; // 0x30
	private GameObject CHBFAEECAFEEEFB; // 0x38
	private GameObject BCEGCAHBDDBCDCD; // 0x40
	private GameObject HFAGBGCDDGEEBFD; // 0x48
	private GameObject BHHEDBHBDDFGDAG; // 0x50
	private GameObject AACGAHEDGEFDDAF; // 0x58
	private GameObject DGFFEHCGHDEFEBG; // 0x60
	private GameObject GFFAEAAGFAGBADF; // 0x68
	private GameObject ECHHCACFCDBGBHC; // 0x70
	private GameObject AEFECGAFGDDABAE; // 0x78
	private GameObject BDGBDDEBCCDAHCB; // 0x80
	private GameObject DCDAFBHHCBCDDGA; // 0x88
	private GameObject HADGHBGFCCFFHGD; // 0x90
	private GameObject GCAEAGCEBFEADDA; // 0x98
	private GameObject EGACABCAHCGGADD; // 0xA0
	private GameObject DAHBDEBDDDAHGBH; // 0xA8
	private TransformTR CHFBABFBDGGBGBD; // 0xB0
	private Transform HADCHBDABCDEGDA; // 0xB8
	private GameObject FBBFCHBGDGEEFCF; // 0xC0
	private GameObject CAFAECAAGAEEGCB; // 0xC8
	private GameObject HGGBGEFEFGEBBCC; // 0xD0
	private GameObject EBGFHHHHHEBAEGF; // 0xD8
	private GameObject[] ACDAHGHBCBDDCCD; // 0xE0

	// Properties
	public GameObject FAFCHDEDGDCFBGG { get; set; }
	public GameObject HHBHACABBBGDHFD { get; set; }
	public GameObject GFGDFCGADECBDCA { get; set; }
	public GameObject GHCFBBFBDGHHCED { get; set; }
	public GameObject CBHDAAGHEGECFFB { get; set; }
	public GameObject ECDEGBEHHCGBGAE { get; set; }
	public GameObject GCABFBDGHFEGDFE { get; set; }
	public GameObject GCHACCCECGBCFBF { get; set; }
	public GameObject ABBACCFBDAABDAD { get; set; }
	public GameObject HHCGFAHFCEGCGEC { get; set; }
	public GameObject GBGEAGDCAEBHBAG { get; set; }
	public GameObject FBDFFHFCBEDCEBC { get; set; }
	public GameObject HBDABEGACHFBGAD { get; set; }
	public GameObject ABAHDCGGBEHHBGH { get; set; }
	public GameObject EBHHHHGHCHAEDED { get; set; }
	public GameObject GGHCAFHFFBBGCFF { get; set; }
	public GameObject EBGDABDCGACHGBE { get; set; }
	public GameObject BGDHFFFBAAHABBA { get; set; }
	public GameObject CCCFADDGGAGFCAD { get; set; }
	public TransformTR FFHFHDHBBGBGDBH { get; set; }
	public Transform EGEBAACGDEHHABE { get; set; }
	public GameObject AAAAFBCADAGHEHG { get; set; }
	public GameObject HDEBECFGGGAADBH { get; set; }
	public GameObject AHEGEFGEADHHHDD { get; set; }
	public GameObject CFHHDBEHFDBCACE { get; set; }
	public GameObject[] CHGCEFFAEBCHFCD { get; set; }

	// Methods

	// RVA: 0x12D1E34 Offset: 0x12D1E34 VA: 0x12D1E34
	public void .ctor() { }

	// RVA: 0x12D1E3C Offset: 0x12D1E3C VA: 0x12D1E3C
	public GameObject get_FAFCHDEDGDCFBGG() { }

	// RVA: 0x12D1E44 Offset: 0x12D1E44 VA: 0x12D1E44
	private void set_FAFCHDEDGDCFBGG(GameObject value) { }

	// RVA: 0x12D1E4C Offset: 0x12D1E4C VA: 0x12D1E4C
	public GameObject get_HHBHACABBBGDHFD() { }

	// RVA: 0x12D1E54 Offset: 0x12D1E54 VA: 0x12D1E54
	private void set_HHBHACABBBGDHFD(GameObject value) { }

	// RVA: 0x12D1E5C Offset: 0x12D1E5C VA: 0x12D1E5C
	public GameObject get_GFGDFCGADECBDCA() { }

	// RVA: 0x12D1E64 Offset: 0x12D1E64 VA: 0x12D1E64
	private void set_GFGDFCGADECBDCA(GameObject value) { }

	// RVA: 0x12CB4EC Offset: 0x12CB4EC VA: 0x12CB4EC
	public GameObject get_GHCFBBFBDGHHCED() { }

	// RVA: 0x12D1E6C Offset: 0x12D1E6C VA: 0x12D1E6C
	private void set_GHCFBBFBDGHHCED(GameObject value) { }

	// RVA: 0x12D1E74 Offset: 0x12D1E74 VA: 0x12D1E74
	public GameObject get_CBHDAAGHEGECFFB() { }

	// RVA: 0x12D1E7C Offset: 0x12D1E7C VA: 0x12D1E7C
	private void set_CBHDAAGHEGECFFB(GameObject value) { }

	// RVA: 0x12D1E84 Offset: 0x12D1E84 VA: 0x12D1E84
	public GameObject get_ECDEGBEHHCGBGAE() { }

	// RVA: 0x12D1E8C Offset: 0x12D1E8C VA: 0x12D1E8C
	private void set_ECDEGBEHHCGBGAE(GameObject value) { }

	// RVA: 0x12D1E94 Offset: 0x12D1E94 VA: 0x12D1E94
	public GameObject get_GCABFBDGHFEGDFE() { }

	// RVA: 0x12D1E9C Offset: 0x12D1E9C VA: 0x12D1E9C
	private void set_GCABFBDGHFEGDFE(GameObject value) { }

	// RVA: 0x12D1EA4 Offset: 0x12D1EA4 VA: 0x12D1EA4
	public GameObject get_GCHACCCECGBCFBF() { }

	// RVA: 0x12D1EAC Offset: 0x12D1EAC VA: 0x12D1EAC
	private void set_GCHACCCECGBCFBF(GameObject value) { }

	// RVA: 0x12D1EB4 Offset: 0x12D1EB4 VA: 0x12D1EB4
	public GameObject get_ABBACCFBDAABDAD() { }

	// RVA: 0x12D1EBC Offset: 0x12D1EBC VA: 0x12D1EBC
	private void set_ABBACCFBDAABDAD(GameObject value) { }

	// RVA: 0x12D1EC4 Offset: 0x12D1EC4 VA: 0x12D1EC4
	public GameObject get_HHCGFAHFCEGCGEC() { }

	// RVA: 0x12D1ECC Offset: 0x12D1ECC VA: 0x12D1ECC
	private void set_HHCGFAHFCEGCGEC(GameObject value) { }

	// RVA: 0x12D1ED4 Offset: 0x12D1ED4 VA: 0x12D1ED4
	public GameObject get_GBGEAGDCAEBHBAG() { }

	// RVA: 0x12D1EDC Offset: 0x12D1EDC VA: 0x12D1EDC
	private void set_GBGEAGDCAEBHBAG(GameObject value) { }

	// RVA: 0x12D1EE4 Offset: 0x12D1EE4 VA: 0x12D1EE4
	public GameObject get_FBDFFHFCBEDCEBC() { }

	// RVA: 0x12D1EEC Offset: 0x12D1EEC VA: 0x12D1EEC
	private void set_FBDFFHFCBEDCEBC(GameObject value) { }

	// RVA: 0x12D1EF4 Offset: 0x12D1EF4 VA: 0x12D1EF4
	public GameObject get_HBDABEGACHFBGAD() { }

	// RVA: 0x12D1EFC Offset: 0x12D1EFC VA: 0x12D1EFC
	private void set_HBDABEGACHFBGAD(GameObject value) { }

	// RVA: 0x12D1F04 Offset: 0x12D1F04 VA: 0x12D1F04
	public GameObject get_ABAHDCGGBEHHBGH() { }

	// RVA: 0x12D1F0C Offset: 0x12D1F0C VA: 0x12D1F0C
	private void set_ABAHDCGGBEHHBGH(GameObject value) { }

	// RVA: 0x12D1F14 Offset: 0x12D1F14 VA: 0x12D1F14
	public GameObject get_EBHHHHGHCHAEDED() { }

	// RVA: 0x12D1F1C Offset: 0x12D1F1C VA: 0x12D1F1C
	private void set_EBHHHHGHCHAEDED(GameObject value) { }

	// RVA: 0x12D1F24 Offset: 0x12D1F24 VA: 0x12D1F24
	public GameObject get_GGHCAFHFFBBGCFF() { }

	// RVA: 0x12D1F2C Offset: 0x12D1F2C VA: 0x12D1F2C
	private void set_GGHCAFHFFBBGCFF(GameObject value) { }

	// RVA: 0x12D1F34 Offset: 0x12D1F34 VA: 0x12D1F34
	public GameObject get_EBGDABDCGACHGBE() { }

	// RVA: 0x12D1F3C Offset: 0x12D1F3C VA: 0x12D1F3C
	private void set_EBGDABDCGACHGBE(GameObject value) { }

	// RVA: 0x12D1F44 Offset: 0x12D1F44 VA: 0x12D1F44
	public GameObject get_BGDHFFFBAAHABBA() { }

	// RVA: 0x12D1F4C Offset: 0x12D1F4C VA: 0x12D1F4C
	private void set_BGDHFFFBAAHABBA(GameObject value) { }

	// RVA: 0x12D1F54 Offset: 0x12D1F54 VA: 0x12D1F54
	public GameObject get_CCCFADDGGAGFCAD() { }

	// RVA: 0x12D1F5C Offset: 0x12D1F5C VA: 0x12D1F5C
	private void set_CCCFADDGGAGFCAD(GameObject value) { }

	// RVA: 0x12D14BC Offset: 0x12D14BC VA: 0x12D14BC
	public TransformTR get_FFHFHDHBBGBGDBH() { }

	// RVA: 0x12D1F64 Offset: 0x12D1F64 VA: 0x12D1F64
	private void set_FFHFHDHBBGBGDBH(TransformTR value) { }

	// RVA: 0x12D14C4 Offset: 0x12D14C4 VA: 0x12D14C4
	public Transform get_EGEBAACGDEHHABE() { }

	// RVA: 0x12D1F6C Offset: 0x12D1F6C VA: 0x12D1F6C
	private void set_EGEBAACGDEHHABE(Transform value) { }

	// RVA: 0x12D1F74 Offset: 0x12D1F74 VA: 0x12D1F74
	public GameObject get_AAAAFBCADAGHEHG() { }

	// RVA: 0x12D1F7C Offset: 0x12D1F7C VA: 0x12D1F7C
	private void set_AAAAFBCADAGHEHG(GameObject value) { }

	// RVA: 0x12D1F84 Offset: 0x12D1F84 VA: 0x12D1F84
	public GameObject get_HDEBECFGGGAADBH() { }

	// RVA: 0x12D1F8C Offset: 0x12D1F8C VA: 0x12D1F8C
	private void set_HDEBECFGGGAADBH(GameObject value) { }

	// RVA: 0x12D1F94 Offset: 0x12D1F94 VA: 0x12D1F94
	public GameObject get_AHEGEFGEADHHHDD() { }

	// RVA: 0x12D1F9C Offset: 0x12D1F9C VA: 0x12D1F9C
	private void set_AHEGEFGEADHHHDD(GameObject value) { }

	// RVA: 0x12D1FA4 Offset: 0x12D1FA4 VA: 0x12D1FA4
	public GameObject get_CFHHDBEHFDBCACE() { }

	// RVA: 0x12D1FAC Offset: 0x12D1FAC VA: 0x12D1FAC
	private void set_CFHHDBEHFDBCACE(GameObject value) { }

	// RVA: 0x12D1FB4 Offset: 0x12D1FB4 VA: 0x12D1FB4
	public GameObject[] get_CHGCEFFAEBCHFCD() { }

	// RVA: 0x12D1FBC Offset: 0x12D1FBC VA: 0x12D1FBC
	private void set_CHGCEFFAEBCHFCD(GameObject[] value) { }

	// RVA: 0x12D1FC4 Offset: 0x12D1FC4 VA: 0x12D1FC4
	public GameObject EHACHCHEDBDGEHA() { }

	// RVA: 0x12D1FCC Offset: 0x12D1FCC VA: 0x12D1FCC
	private void ABBHABHEDGFHGCE(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D1FD4 Offset: 0x12D1FD4 VA: 0x12D1FD4
	public GameObject GBHAAHFAGAAGGBC() { }

	// RVA: 0x12D1FDC Offset: 0x12D1FDC VA: 0x12D1FDC
	private void AEAFCDFDDAHFFGE(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D1FE4 Offset: 0x12D1FE4 VA: 0x12D1FE4
	public GameObject FGAEEEEEGFFCAAD() { }

	// RVA: 0x12D1FEC Offset: 0x12D1FEC VA: 0x12D1FEC
	private void HCBHHGAFDGEBDED(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D1FF4 Offset: 0x12D1FF4 VA: 0x12D1FF4
	public GameObject HACAADCDFHHGAHA() { }

	// RVA: 0x12D1FFC Offset: 0x12D1FFC VA: 0x12D1FFC
	private void HDHAGHAHDHAADBB(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2004 Offset: 0x12D2004 VA: 0x12D2004
	public GameObject CDFHFBHAFBBEHGC() { }

	// RVA: 0x12D200C Offset: 0x12D200C VA: 0x12D200C
	private void DAHGAHECFEHDCCF(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2014 Offset: 0x12D2014 VA: 0x12D2014
	public GameObject DFBGFAAFBABGEDA() { }

	// RVA: 0x12D201C Offset: 0x12D201C VA: 0x12D201C
	private void FAGACCDGCCAAGCG(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2024 Offset: 0x12D2024 VA: 0x12D2024
	public GameObject CCGGGAGGEFBGCFH() { }

	// RVA: 0x12D202C Offset: 0x12D202C VA: 0x12D202C
	private void FFEFDFGFCHAHAFD(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2034 Offset: 0x12D2034 VA: 0x12D2034
	public GameObject FEEBFAADHGAGEHB() { }

	// RVA: 0x12D203C Offset: 0x12D203C VA: 0x12D203C
	private void FDBGGHEBDHFHADH(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2044 Offset: 0x12D2044 VA: 0x12D2044
	public GameObject FGEDEABHABFFHDD() { }

	// RVA: 0x12D204C Offset: 0x12D204C VA: 0x12D204C
	private void DEBAHBFGDHCBCAE(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2054 Offset: 0x12D2054 VA: 0x12D2054
	public GameObject EDAHEEGBFACAACF() { }

	// RVA: 0x12D205C Offset: 0x12D205C VA: 0x12D205C
	private void DCHFFBFHABAADGD(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2064 Offset: 0x12D2064 VA: 0x12D2064
	public GameObject DEBAAHCGAHBBFGC() { }

	// RVA: 0x12D206C Offset: 0x12D206C VA: 0x12D206C
	private void DHDGDDBGAFECDGB(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2074 Offset: 0x12D2074 VA: 0x12D2074
	public GameObject HCGHAGEADBHHCGC() { }

	// RVA: 0x12D207C Offset: 0x12D207C VA: 0x12D207C
	private void AGHAGGDCAHBADFF(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2084 Offset: 0x12D2084 VA: 0x12D2084
	public GameObject DDCADCAFBCHAGFH() { }

	// RVA: 0x12D208C Offset: 0x12D208C VA: 0x12D208C
	private void CCDGCBBDHAABEAB(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2094 Offset: 0x12D2094 VA: 0x12D2094
	public GameObject AACCHECDGBFGAEE() { }

	// RVA: 0x12D209C Offset: 0x12D209C VA: 0x12D209C
	private void EBGFDFAAEAGAEBH(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D20A4 Offset: 0x12D20A4 VA: 0x12D20A4
	public GameObject FEHFAAEDDGAECEH() { }

	// RVA: 0x12D20AC Offset: 0x12D20AC VA: 0x12D20AC
	private void BFCFAEBECCDBHGD(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D20B4 Offset: 0x12D20B4 VA: 0x12D20B4
	public GameObject GBGFCAAHBGADGFG() { }

	// RVA: 0x12D20BC Offset: 0x12D20BC VA: 0x12D20BC
	private void EABHECFHEDHGADD(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D20C4 Offset: 0x12D20C4 VA: 0x12D20C4
	public GameObject EHCAHGHAGGBHBGA() { }

	// RVA: 0x12D20CC Offset: 0x12D20CC VA: 0x12D20CC
	private void EBGGDDFBDGCEDAC(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D20D4 Offset: 0x12D20D4 VA: 0x12D20D4
	public GameObject HDBCECAAEFAHFGD() { }

	// RVA: 0x12D20DC Offset: 0x12D20DC VA: 0x12D20DC
	private void FCFHFDBDHHCCFDC(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D20E4 Offset: 0x12D20E4 VA: 0x12D20E4
	public GameObject FGDEGEGCEHDCEDD() { }

	// RVA: 0x12D20EC Offset: 0x12D20EC VA: 0x12D20EC
	private void FGEDCFDBHHAHHGC(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D20F4 Offset: 0x12D20F4 VA: 0x12D20F4
	public TransformTR FEEEAABFFBBCCGH() { }

	// RVA: 0x12D20FC Offset: 0x12D20FC VA: 0x12D20FC
	private void HCEEEDEFBGAGFEE(TransformTR HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2104 Offset: 0x12D2104 VA: 0x12D2104
	public Transform HFHHAHHADDEBCAE() { }

	// RVA: 0x12D210C Offset: 0x12D210C VA: 0x12D210C
	private void ADHDHGCCFDGBHGF(Transform HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2114 Offset: 0x12D2114 VA: 0x12D2114
	public GameObject AHGEDECEECGHCAA() { }

	// RVA: 0x12D211C Offset: 0x12D211C VA: 0x12D211C
	private void BFGFAAABFBDEAGC(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2124 Offset: 0x12D2124 VA: 0x12D2124
	public GameObject GCCAAFGHGCCEFDH() { }

	// RVA: 0x12D212C Offset: 0x12D212C VA: 0x12D212C
	private void EBCGDDBCGBGGEBH(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2134 Offset: 0x12D2134 VA: 0x12D2134
	public GameObject FAEDCBFAEBFEEHF() { }

	// RVA: 0x12D213C Offset: 0x12D213C VA: 0x12D213C
	private void BDABDDDCEAFEAEF(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2144 Offset: 0x12D2144 VA: 0x12D2144
	public GameObject HHDBBHGGGEFBGDH() { }

	// RVA: 0x12D214C Offset: 0x12D214C VA: 0x12D214C
	private void AFCCHEFCBGFAFCE(GameObject HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2154 Offset: 0x12D2154 VA: 0x12D2154
	public GameObject[] BGEBHAHAHCEHGHF() { }

	// RVA: 0x12D215C Offset: 0x12D215C VA: 0x12D215C
	private void DGHABDBCDGEADHC(GameObject[] HFACGHHBHBFFFDE) { }

	// RVA: 0x12CC6B0 Offset: 0x12CC6B0 VA: 0x12CC6B0
	internal void CGEGDGDACCBGCBH() { }

	// RVA: 0x12CD7D4 Offset: 0x12CD7D4 VA: 0x12CD7D4
	public void AHHABDGEFFHHAAG(int GFAFFDCFEEABADD) { }

	// RVA: 0x12D2164 Offset: 0x12D2164 VA: 0x12D2164
	private void CEGBFBGGDBHGBHF(int GFAFFDCFEEABADD, Transform HBEGGBADGCEDACD) { }

	// RVA: 0x12D2200 Offset: 0x12D2200 VA: 0x12D2200
	public GameObject GDHFCHCHEFBACDG(WeaponMap.DHCGBABEGAHEHEF HGFHCEBCCGFDEHF) { }
}

// Namespace: Axlebolt.Standoff.Inventory
public class WeaponMaterialController : MonoBehaviour, BCADCFDABHGCEFF // TypeDefIndex: 4109
{
	// Fields
	private Action CDCABEHHBGGGCAA__BackingField; // 0x18
	private FCCEAGDGDCFDFCC FAGBFHBFHAGCBEC; // 0x20
	private HCAFGHHDFAHHGDC DDAAGFHCHBHABAH; // 0x24
	private WeaponLodGroup DCHDGDHEAAFGHGE; // 0x28

	// Properties
	public FCCEAGDGDCFDFCC HGACDDEBAGEGGHG { get; set; }
	public HCAFGHHDFAHHGDC AHGGCGAABDCHFEA { get; set; }
	public WeaponLodGroup GACCCAFEDCDAEFC { get; set; }

	// Methods

	// RVA: 0x12D22D8 Offset: 0x12D22D8 VA: 0x12D22D8
	public FCCEAGDGDCFDFCC get_HGACDDEBAGEGGHG() { }

	// RVA: 0x12D22E0 Offset: 0x12D22E0 VA: 0x12D22E0
	private void set_HGACDDEBAGEGGHG(FCCEAGDGDCFDFCC value) { }

	// RVA: 0x12CBF34 Offset: 0x12CBF34 VA: 0x12CBF34
	public HCAFGHHDFAHHGDC get_AHGGCGAABDCHFEA() { }

	// RVA: 0x12D22E8 Offset: 0x12D22E8 VA: 0x12D22E8
	private void set_AHGGCGAABDCHFEA(HCAFGHHDFAHHGDC value) { }

	// RVA: 0x12D22F0 Offset: 0x12D22F0 VA: 0x12D22F0
	public WeaponLodGroup get_GACCCAFEDCDAEFC() { }

	// RVA: 0x12D22F8 Offset: 0x12D22F8 VA: 0x12D22F8
	private void set_GACCCAFEDCDAEFC(WeaponLodGroup value) { }

	// RVA: 0x12D2300 Offset: 0x12D2300 VA: 0x12D2300
	public void add_CDCABEHHBGGGCAA(Action value) { }

	// RVA: 0x12D23A0 Offset: 0x12D23A0 VA: 0x12D23A0
	public void remove_CDCABEHHBGGGCAA(Action value) { }

	// RVA: 0x12D2304 Offset: 0x12D2304 VA: 0x12D2304
	public void CDFGCCDDDEGHFGA(Action HFACGHHBHBFFFDE) { }

	// RVA: 0x12D23A4 Offset: 0x12D23A4 VA: 0x12D23A4
	public void CCBBAEFGDGFFGGE(Action HFACGHHBHBFFFDE) { }

	// RVA: 0x12CD250 Offset: 0x12CD250 VA: 0x12CD250
	public void GGFHGHDEHFFEHHA(FCCEAGDGDCFDFCC GAAEGDFBDBDGEFG) { }

	// RVA: 0x12CD350 Offset: 0x12CD350 VA: 0x12CD350
	public void CGEGDGDACCBGCBH(HCAFGHHDFAHHGDC CCEDDCCFEFAHFBF) { }

	// RVA: 0x12D2440 Offset: 0x12D2440 VA: 0x12D2440
	public FCCEAGDGDCFDFCC FGDCGFHAADFCEEB() { }

	// RVA: 0x12D2448 Offset: 0x12D2448 VA: 0x12D2448
	private void FGGDBCHGDFACCHH(FCCEAGDGDCFDFCC HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2450 Offset: 0x12D2450 VA: 0x12D2450
	public HCAFGHHDFAHHGDC HACHCEGABDGABGF() { }

	// RVA: 0x12D2458 Offset: 0x12D2458 VA: 0x12D2458
	private void CHEFFEHGFFBDEED(HCAFGHHDFAHHGDC HFACGHHBHBFFFDE) { }

	// RVA: 0x12D2460 Offset: 0x12D2460 VA: 0x12D2460
	public WeaponLodGroup EEGGAGFAADBCCCF() { }

	// RVA: 0x12D2468 Offset: 0x12D2468 VA: 0x12D2468
	private void CAAGGGDACEBBHEH(WeaponLodGroup HFACGHHBHBFFFDE) { }

	// RVA: 0x12CDE98 Offset: 0x12CDE98 VA: 0x12CDE98
	public void AHECFFFBDDGAGGG() { }

	// RVA: 0x12CD3E4 Offset: 0x12CD3E4 VA: 0x12CD3E4
	public void AAEDEDCEDCADEBG() { }

	// RVA: 0x12D28E4 Offset: 0x12D28E4 VA: 0x12D28E4 Slot: 4
	public bool AHBEGECHCHDFHFD(HCAFGHHDFAHHGDC CCEDDCCFEFAHFBF, int GFAFFDCFEEABADD) { }

	// RVA: 0x12D24FC Offset: 0x12D24FC VA: 0x12D24FC
	private void CCAFBGBACGBGHAC() { }

	// RVA: 0x12D29D0 Offset: 0x12D29D0 VA: 0x12D29D0
	private void HAHHHEAGCAEBEFH() { }

	// RVA: 0x12D2598 Offset: 0x12D2598 VA: 0x12D2598
	private void HAADAAGFCHBDCAC() { }

	// RVA: 0x12D2B0C Offset: 0x12D2B0C VA: 0x12D2B0C
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory
public abstract class WeaponParameters : InventoryParameters // TypeDefIndex: 4115
{
	// Fields
	[SerializeField]
	private float _fixScale; // 0x3C
	[SerializeField]
	private bool _dropBoxCollider; // 0x40
	[SerializeField]
	private WeaponThrowPhysParameters _throwParameters; // 0x48
	[SerializeField]
	private bool _inspectable; // 0x50
	[SerializeField]
	private bool _forceTakeAfterPickup; // 0x51
	[SerializeField]
	private bool _inspectableBonus; // 0x52
	[SerializeField]
	private WeaponHitDelayParameters _hitDelayParameters; // 0x58
	[SerializeField]
	private string _customAnimationName; // 0x60
	[SerializeField]
	private FCCEAGDGDCFDFCC _customAnimationWeaponId; // 0x68
	[SerializeField]
	private bool _isDroppable; // 0x69
	[SerializeField]
	private Sprite _customShootButtonSprite; // 0x70

	// Properties
	public float FixScale { get; }
	public bool DropBoxCollider { get; }
	public WeaponThrowPhysParameters ThrowParameters { get; }
	public bool Inspectable { get; }
	public bool ForceTakeAfterPickup { get; }
	public bool InspectableBonus { get; }
	public WeaponHitDelayParameters HitDelayParameters { get; }
	public string CustomAnimationName { get; }
	public FCCEAGDGDCFDFCC CustomAnimationWeaponId { get; }
	public bool IsDroppable { get; }
	public Sprite CustomShootButtonSprite { get; }

	// Methods

	// RVA: 0x12D51E8 Offset: 0x12D51E8 VA: 0x12D51E8
	public float get_FixScale() { }

	// RVA: 0x12D51F0 Offset: 0x12D51F0 VA: 0x12D51F0
	public bool get_DropBoxCollider() { }

	// RVA: 0x12D51F8 Offset: 0x12D51F8 VA: 0x12D51F8
	public WeaponThrowPhysParameters get_ThrowParameters() { }

	// RVA: 0x12D5200 Offset: 0x12D5200 VA: 0x12D5200
	public bool get_Inspectable() { }

	// RVA: 0x12D5208 Offset: 0x12D5208 VA: 0x12D5208
	public bool get_ForceTakeAfterPickup() { }

	// RVA: 0x12D5210 Offset: 0x12D5210 VA: 0x12D5210
	public bool get_InspectableBonus() { }

	// RVA: 0x12D5218 Offset: 0x12D5218 VA: 0x12D5218
	public WeaponHitDelayParameters get_HitDelayParameters() { }

	// RVA: 0x12D5220 Offset: 0x12D5220 VA: 0x12D5220
	public string get_CustomAnimationName() { }

	// RVA: 0x12D5228 Offset: 0x12D5228 VA: 0x12D5228
	public FCCEAGDGDCFDFCC get_CustomAnimationWeaponId() { }

	// RVA: 0x12D5230 Offset: 0x12D5230 VA: 0x12D5230
	public bool get_IsDroppable() { }

	// RVA: 0x12D5238 Offset: 0x12D5238 VA: 0x12D5238
	public Sprite get_CustomShootButtonSprite() { }

	// RVA: 0x12D5240 Offset: 0x12D5240 VA: 0x12D5240
	private void Awake() { }

	// RVA: 0x12D524C Offset: 0x12D524C VA: 0x12D524C Slot: 5
	protected virtual void AEDEGBDGEGGACDF() { }

	// RVA: 0x12D5250 Offset: 0x12D5250 VA: 0x12D5250
	private void BCGBDEEFEGGAGGD() { }

	// RVA: 0x12CC390 Offset: 0x12CC390 VA: 0x12CC390
	protected void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory
public class WeaponSoundController : Controller // TypeDefIndex: 4118
{
	// Fields
	private const string GEDCGCGFGDFHEHE = "FpsDeploy";
	private const string DFHBDCBACADCEGB = "TpsTeammateDeploy";
	private const string GAACHGGDEGABBFB = "TpsEnemyDeploy";
	private readonly Dictionary<CCBGFGDBAACEFAD, DFHBBCBEACCFDCD> AFCBBBHFGBAGHBH; // 0x60
	private readonly Dictionary<CCBGFGDBAACEFAD, DFHBBCBEACCFDCD> GEHDAGDHGACAFED; // 0x68
	private readonly Dictionary<CCBGFGDBAACEFAD, DFHBBCBEACCFDCD> GBGACAFBHHAFGHD; // 0x70
	private readonly Dictionary<string, HFDHBGCBCHHHACH> ADHCCDEHFDDBADA; // 0x78
	private WeaponSoundParameters BBHAFGECDBFAAEH; // 0x80

	// Methods

	// RVA: 0x12D5CE8 Offset: 0x12D5CE8 VA: 0x12D5CE8 Slot: 4
	public override void GGFHGHDEHFFEHHA(ACBGGCCAECBFDAH GBFACFCGBBDAEFC) { }

	// RVA: 0x12D6100 Offset: 0x12D6100 VA: 0x12D6100
	public void FACDFECGCFFAEHA(CCBGFGDBAACEFAD AEGACDBBHFFEBCC) { }

	// RVA: 0x12D630C Offset: 0x12D630C VA: 0x12D630C
	protected float BDHADBCCFFCHHGF() { }

	// RVA: 0x12D64C4 Offset: 0x12D64C4 VA: 0x12D64C4
	protected float HGAGEGBHHFCEGBF() { }

	// RVA: 0x12D651C Offset: 0x12D651C VA: 0x12D651C Slot: 12
	protected virtual bool EHAHFCGBDAEAFBE(CCBGFGDBAACEFAD AEGACDBBHFFEBCC) { }

	// RVA: 0x12CBFD8 Offset: 0x12CBFD8 VA: 0x12CBFD8
	public GCAFCFFCGHHHFAE HFADFAFHGHCEFGB() { }

	// RVA: 0x12D65D8 Offset: 0x12D65D8 VA: 0x12D65D8 Slot: 8
	public override void FDDEHBACBDFACGF() { }

	// RVA: 0x12D6810 Offset: 0x12D6810 VA: 0x12D6810 Slot: 13
	protected virtual void AFHDHBHFACFFGGF() { }

	// RVA: 0x12D6814 Offset: 0x12D6814 VA: 0x12D6814 Slot: 14
	protected virtual void HFCBAGBECDAEFHE() { }

	// RVA: 0x12D6338 Offset: 0x12D6338 VA: 0x12D6338
	private bool BDBAGCFEABBFCDB() { }

	// RVA: 0x12D63C8 Offset: 0x12D63C8 VA: 0x12D63C8
	protected Vector3 ABDBECGAEBAAEHA() { }

	// RVA: 0x12D6818 Offset: 0x12D6818 VA: 0x12D6818 Slot: 15
	protected virtual void OnDestroy() { }

	// RVA: 0x12D681C Offset: 0x12D681C VA: 0x12D681C
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory.Knife
public class KnifeSoundController : WeaponSoundController // TypeDefIndex: 4131
{
	// Methods

	// RVA: 0x12D7F90 Offset: 0x12D7F90 VA: 0x12D7F90
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory.Gloves
public class GlovesController : Controller // TypeDefIndex: 4198
{
	// Fields
	private PlayerController DDCBCHDAAHEEHHH; // 0x50

	// Methods

	// RVA: 0x12F40CC Offset: 0x12F40CC VA: 0x12F40CC Slot: 63
	public override void FDEDFCDHCDGCCCD() { }

	// RVA: 0x12F4130 Offset: 0x12F4130 VA: 0x12F4130 Slot: 66
	public override void AAEDEDCEDCADEBG() { }

	// RVA: 0x12F41D4 Offset: 0x12F41D4 VA: 0x12F41D4
	public void BBBFDAAGDDHAEEH(HCAFGHHDFAHHGDC CACBAEBDBEAFCFH) { }

	// RVA: 0x12F4338 Offset: 0x12F4338 VA: 0x12F4338 Slot: 73
	public override void CGEHBBBHECABDEB(BAAFADDFCADEHEA FFGFFADCBHGFBCD) { }

	// RVA: 0x12F4284 Offset: 0x12F4284 VA: 0x12F4284
	private void BAACABBECFCAAGD(HCAFGHHDFAHHGDC GECBFDCACDBGEDF) { }

	// RVA: 0x12F4134 Offset: 0x12F4134 VA: 0x12F4134
	private void DDBAHCBBDDGGDDA() { }

	// RVA: 0x12F43EC Offset: 0x12F43EC VA: 0x12F43EC
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory.Animation
[RequireComponent(typeof(WeaponAnimationEventController))]
public class WeaponAnimationController : Controller // TypeDefIndex: 4231
{
	// Fields
	public const int MaxEventBufferLength = 3;
	public WeaponAnimationParameters AnimationParameters; // 0x60
	private Animator AGEGADGGAHAEECA; // 0x68
	private Animator DEEEGECCCBDEACD; // 0x70
	private Animator FAGHEGBBGDCCCBB; // 0x78
	private WeaponAnimationClip ACHGDGBFHBECADE; // 0x80
	private bool DHCDGAHECEBEAGA; // 0x88
	private float FHHEGEHECFGAFCE; // 0x8C
	private float EGEHFGAFADDAGEG; // 0x90
	private List<CADFHFDBCCDADAD> BCDEDBGBDDAABCH; // 0x98
	private static readonly int HGCAECEGHHHBAHG; // 0x0
	private WeaponAnimationEventController BGCDCAADCHGDAGG; // 0xA0

	// Properties
	public WeaponAnimationEventController DCGGDEABBCFEEHB { get; set; }

	// Methods

	// RVA: 0x12F9DC8 Offset: 0x12F9DC8 VA: 0x12F9DC8
	public WeaponAnimationEventController get_DCGGDEABBCFEEHB() { }

	// RVA: 0x1304384 Offset: 0x1304384 VA: 0x1304384
	private void set_DCGGDEABBCFEEHB(WeaponAnimationEventController value) { }

	// RVA: 0x130438C Offset: 0x130438C VA: 0x130438C Slot: 4
	public override void GGFHGHDEHFFEHHA(ACBGGCCAECBFDAH GBFACFCGBBDAEFC) { }

	// RVA: 0x1304ADC Offset: 0x1304ADC VA: 0x1304ADC
	public WeaponAnimationEventController CGBBDDBHEBEFFAG() { }

	// RVA: 0x1304AE4 Offset: 0x1304AE4 VA: 0x1304AE4
	private void HBEBHEAHDHADDBA(WeaponAnimationEventController HFACGHHBHBFFFDE) { }

	// RVA: 0x1304AEC Offset: 0x1304AEC VA: 0x1304AEC Slot: 6
	public override void AAEDEDCEDCADEBG() { }

	// RVA: 0x1304B84 Offset: 0x1304B84 VA: 0x1304B84 Slot: 8
	public override void FDDEHBACBDFACGF() { }

	// RVA: 0x1304D90 Offset: 0x1304D90 VA: 0x1304D90 Slot: 11
	public override void AFHBDECAECBFAFG(BipedMap EDCCCHCBAHGFCCB) { }

	// RVA: 0x1304BB0 Offset: 0x1304BB0 VA: 0x1304BB0
	private void BDEHBGEECFAABFA() { }

	// RVA: 0x1304DBC Offset: 0x1304DBC VA: 0x1304DBC
	private WeaponAnimationClip HGHCAFHGDEEHGAA(int CGFAAHHAHBGDGFC) { }

	// RVA: 0x12FA1D4 Offset: 0x12FA1D4 VA: 0x12FA1D4
	public void GFEFDFCEEDCEDGE(bool BAHBBHFDDBDECFG) { }

	// RVA: 0x1304FAC Offset: 0x1304FAC VA: 0x1304FAC
	public void AFADGEEDAEAADAB(bool EDGCDBFGCDECEBE) { }

	// RVA: 0x1304FE0 Offset: 0x1304FE0 VA: 0x1304FE0
	public void FADCBACAEHCCACB(float GCABCDEGACEABFA) { }

	// RVA: 0x1304FFC Offset: 0x1304FFC VA: 0x1304FFC
	private float DBCEGDEBHGBGFEB(float GCABCDEGACEABFA) { }

	// RVA: 0x130505C Offset: 0x130505C VA: 0x130505C
	public float CGDHBHCGBEGDDHB(float GCABCDEGACEABFA) { }

	// RVA: 0x1305090 Offset: 0x1305090 VA: 0x1305090
	public void EBEHDCGFAFFBGDB(HHHAABFGEBGDADF<CADFHFDBCCDADAD>[] GBEDFFADGFHCBHC) { }

	// RVA: 0x13050A8 Offset: 0x13050A8 VA: 0x13050A8
	public HHHAABFGEBGDADF<CADFHFDBCCDADAD>[] CEECBAGGDHFBCCA() { }

	// RVA: 0x13050C0 Offset: 0x13050C0 VA: 0x13050C0
	public void EADHBFHHEEEBGEE(float GCABCDEGACEABFA) { }

	// RVA: 0x13050D8 Offset: 0x13050D8 VA: 0x13050D8
	public void AEEGAGEEEHFHBEC(int CGFAAHHAHBGDGFC, float AHBDADGAEFBCCBA, bool EDGCDBFGCDECEBE, float GBGBBEFGCGEABGC, float GCAGDECHGCAHBDG, bool ABEFHABFEBGFDFA) { }

	// RVA: 0x13058AC Offset: 0x13058AC VA: 0x13058AC
	public void .ctor() { }

	// RVA: 0x130596C Offset: 0x130596C VA: 0x130596C
	private static void .cctor() { }
}

// Namespace: Axlebolt.Standoff.Inventory.Animation
public class WeaponAnimationParameters : ScriptableObject // TypeDefIndex: 4235
{
	// Fields
	public int sourceAnimationStatesLayer; // 0x18
	public RuntimeAnimatorController animatorController; // 0x20
	public RuntimeAnimatorController lHandAnimatorController; // 0x28
	public RuntimeAnimatorController rHandAnimatorController; // 0x30
	public List<WeaponAnimationClip> animationClipList; // 0x38
	public TransformTR fpsCamOffset; // 0x40
	public float FpsCamFOV; // 0x48
	public TransformTR FpsCamOffsetClassic; // 0x50
	public float FpsCamFOVClassic; // 0x58
	public TransformTR spineFPSDirectorTR; // 0x60
	public TransformTR weaponDirectorOnStand; // 0x68
	public TransformTR weaponDirectorOnCrouch; // 0x70
	public float ArmsShakeMult; // 0x78
	public string magazine1AnimationName; // 0x80
	public string magazine2AnimationName; // 0x88
	public string magazine3AnimationName; // 0x90
	public string gunlock1AnimationName; // 0x98
	public string gunlock2AnimationName; // 0xA0
	public string sightAnimationName; // 0xA8
	public string collimatorSightAnimationName; // 0xB0
	public string sightLenseAnimationName; // 0xB8
	public string sightReticleAnimationName; // 0xC0
	public string cartridge1AnimationName; // 0xC8
	public string cartridge2AnimationName; // 0xD0
	public bool BlendedTPSShoot; // 0xD8
	public WeaponRecoilAnimation RecoilAnimation; // 0xE0
	public bool ForceUpdate; // 0xE8
	public bool ForceUpdateInTpsView; // 0xE9
	public AnimationCurve AdditiveSpineOrientCurveX; // 0xF0
	public AnimationCurve AdditiveSpineOrientCurveY; // 0xF8
	public AnimationCurve AdditiveSpineRotCurveX; // 0x100
	public AnimationCurve AdditiveSpineRotCurveY; // 0x108

	// Methods

	// RVA: 0x1305BF8 Offset: 0x1305BF8 VA: 0x1305BF8
	public void .ctor() { }
}

// Namespace: Axlebolt.Standoff.Controls
public class HitMarkerView : HudComponentView, AAFHBCHGDDGAGCG // TypeDefIndex: 4863
{
	// Fields
	[SerializeField]
	private CanvasGroup _hitGroup; // 0x30
	[SerializeField]
	private Animator _hitAnimator; // 0x38
	[SerializeField]
	private CanvasGroup _killGroup; // 0x40
	[SerializeField]
	private Animator _killAnimator; // 0x48
	private bool EFGBABHEFHFBAGD; // 0x50
	private int GEGDGCHACDCGEAA; // 0x54
	private bool GDBCCBDGDCFAEEC; // 0x58
	private Color AFFHHCCCHGFEAED; // 0x5C
	private float FFAHFAHADFDAEDH; // 0x6C
	private PlayerController DDCBCHDAAHEEHHH; // 0x70
	private static readonly int BGCDAFEBFHGFGAG; // 0x0
	private static readonly int CACDBEECFCHHEAE; // 0x4

	// Methods

	// RVA: 0x13D5EBC Offset: 0x13D5EBC VA: 0x13D5EBC
	private void Awake() { }

	// RVA: 0x13D5F24 Offset: 0x13D5F24 VA: 0x13D5F24 Slot: 15
	public override void GDCEHADGEEHCACF(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x13D6120 Offset: 0x13D6120 VA: 0x13D6120
	private void EHCCBHBABFAFEFG() { }

	// RVA: 0x13D6178 Offset: 0x13D6178 VA: 0x13D6178 Slot: 16
	public override void FBGFEEFDHDFADEA(PlayerController HAFBEEFEADGHFCA) { }

	// RVA: 0x13D5EC4 Offset: 0x13D5EC4 VA: 0x13D5EC4
	private void DDGAAFFEFCCHGFC(bool HHFCABFBEAHHCDH) { }

	// RVA: 0x13D617C Offset: 0x13D617C VA: 0x13D617C
	private void BBADEAAAGCFGFHF(bool GGABFAHHAGFHEFH) { }

	// RVA: 0x13D628C Offset: 0x13D628C VA: 0x13D628C
	private void CBGEACGDCCHECEE(PlayerController HAFBEEFEADGHFCA, HACDCDGHHBCEHBG HBCFHACHFHBHDEH) { }

	// RVA: 0x13D6348 Offset: 0x13D6348 VA: 0x13D6348 Slot: 18
	public void OnHitEvent(EDFFGGABHHCGGFE HHBDAGBAGCHACDG) { }

	// RVA: 0x13D6538 Offset: 0x13D6538 VA: 0x13D6538
	public void OnHitEvent(bool GGABFAHHAGFHEFH) { }

	// RVA: 0x13D6648 Offset: 0x13D6648 VA: 0x13D6648 Slot: 19
	public void OnSuicideEvent(PhotonPlayer FGDHCHEFDAEGFFD) { }

	// RVA: 0x13D664C Offset: 0x13D664C VA: 0x13D664C
	public void .ctor() { }

	// RVA: 0x13D6654 Offset: 0x13D6654 VA: 0x13D6654
	private static void .cctor() { }
}

// Namespace: Axlebolt.Standoff.Controls
public abstract class HudComponentView : View, EHBAFDFCBEAGEFA // TypeDefIndex: 4865
{
	// Fields
	private CanvasGroup GBGAAEBGDBDGHEA; // 0x20
	private bool GDBADGBBDBGDBED; // 0x28

	// Properties
	public bool HDCEEBEGECABABD { get; }

	// Methods

	// RVA: 0x13D6A64 Offset: 0x13D6A64 VA: 0x13D6A64
	public bool get_HDCEEBEGECABABD() { }

	// RVA: 0x13D39C4 Offset: 0x13D39C4 VA: 0x13D39C4 Slot: 14
	public virtual void BFFHCFGEBDCCBHE() { }

	// RVA: 0x13D6A6C Offset: 0x13D6A6C VA: 0x13D6A6C
	public bool AGFHGADBFGGBFHF() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void GDCEHADGEEHCACF(PlayerController HAFBEEFEADGHFCA);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void FBGFEEFDHDFADEA(PlayerController HAFBEEFEADGHFCA);

	// RVA: 0x13D3EFC Offset: 0x13D3EFC VA: 0x13D3EFC Slot: 17
	protected virtual void GFEFDFCEEDCEDGE(bool AABHCHCBEDGECHD) { }

	// RVA: 0x13D3F5C Offset: 0x13D3F5C VA: 0x13D3F5C
	protected void .ctor() { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[UsedByNativeCode]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 13929
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; }

	// Methods

	// RVA: 0x2DAF0F8 Offset: 0x2DAF0F8 VA: 0x2DAF0F8
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x2DAF104 Offset: 0x2DAF104 VA: 0x2DAF104
	public static Quaternion get_identity() { }

	// RVA: 0x2DAF150 Offset: 0x2DAF150 VA: 0x2DAF150
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2DAF1C4 Offset: 0x2DAF1C4 VA: 0x2DAF1C4
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x2DAF268 Offset: 0x2DAF268 VA: 0x2DAF268
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x2DAF27C Offset: 0x2DAF27C VA: 0x2DAF27C
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2DAF2AC Offset: 0x2DAF2AC VA: 0x2DAF2AC
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2DAF2DC Offset: 0x2DAF2DC VA: 0x2DAF2DC
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x2DAF2FC Offset: 0x2DAF2FC VA: 0x2DAF2FC
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x2DAF35C Offset: 0x2DAF35C VA: 0x2DAF35C
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x2DAF3E4 Offset: 0x2DAF3E4 VA: 0x2DAF3E4
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2DAF468 Offset: 0x2DAF468 VA: 0x2DAF468
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x2DAF4D4 Offset: 0x2DAF4D4 VA: 0x2DAF4D4
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x2DAF4EC Offset: 0x2DAF4EC VA: 0x2DAF4EC
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	// RVA: 0x2DAF57C Offset: 0x2DAF57C VA: 0x2DAF57C
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x2DAF6EC Offset: 0x2DAF6EC VA: 0x2DAF6EC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DAF750 Offset: 0x2DAF750 VA: 0x2DAF750 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2DAF824 Offset: 0x2DAF824 VA: 0x2DAF824 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x2DAF8A4 Offset: 0x2DAF8A4 VA: 0x2DAF8A4 Slot: 3
	public override string ToString() { }

	// RVA: 0x2DAF8B0 Offset: 0x2DAF8B0 VA: 0x2DAF8B0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	// RVA: 0x2DAFAE8 Offset: 0x2DAFAE8 VA: 0x2DAFAE8
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2DAFB9C Offset: 0x2DAFB9C VA: 0x2DAFB9C
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x2DAFC34 Offset: 0x2DAFC34 VA: 0x2DAFC34
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x2DAF67C Offset: 0x2DAF67C VA: 0x2DAF67C
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	// RVA: 0x2DAFD6C Offset: 0x2DAFD6C VA: 0x2DAFD6C
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	// RVA: 0x2DAF480 Offset: 0x2DAF480 VA: 0x2DAF480
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	// RVA: 0x2DAF410 Offset: 0x2DAF410 VA: 0x2DAF410
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = True)]
	// RVA: 0x2DAF520 Offset: 0x2DAF520 VA: 0x2DAF520
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	// RVA: 0x2DAFF1C Offset: 0x2DAFF1C VA: 0x2DAFF1C
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	// RVA: 0x2DAFFD4 Offset: 0x2DAFFD4 VA: 0x2DAFFD4
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocs]
	// RVA: 0x2DB0088 Offset: 0x2DB0088 VA: 0x2DB0088
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x2DB00F4 Offset: 0x2DB00F4 VA: 0x2DB00F4
	private static void .cctor() { }

	// RVA: 0x2DAFB48 Offset: 0x2DAFB48 VA: 0x2DAFB48
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x2DAFBF0 Offset: 0x2DAFBF0 VA: 0x2DAFBF0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x2DAFCA4 Offset: 0x2DAFCA4 VA: 0x2DAFCA4
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2DAFD08 Offset: 0x2DAFD08 VA: 0x2DAFD08
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2DAFDDC Offset: 0x2DAFDDC VA: 0x2DAFDDC
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2DAFE40 Offset: 0x2DAFE40 VA: 0x2DAFE40
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x2DAFE84 Offset: 0x2DAFE84 VA: 0x2DAFE84
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x2DAFEC8 Offset: 0x2DAFEC8 VA: 0x2DAFEC8
	private static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle) { }

	// RVA: 0x2DAFF80 Offset: 0x2DAFF80 VA: 0x2DAFF80
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x2DB0034 Offset: 0x2DB0034 VA: 0x2DB0034
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[NativeClass("Matrix4x4f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 13932
{
	// Fields
	[NativeName("m_Data[0]")]
	public float m00; // 0x0
	[NativeName("m_Data[1]")]
	public float m10; // 0x4
	[NativeName("m_Data[2]")]
	public float m20; // 0x8
	[NativeName("m_Data[3]")]
	public float m30; // 0xC
	[NativeName("m_Data[4]")]
	public float m01; // 0x10
	[NativeName("m_Data[5]")]
	public float m11; // 0x14
	[NativeName("m_Data[6]")]
	public float m21; // 0x18
	[NativeName("m_Data[7]")]
	public float m31; // 0x1C
	[NativeName("m_Data[8]")]
	public float m02; // 0x20
	[NativeName("m_Data[9]")]
	public float m12; // 0x24
	[NativeName("m_Data[10]")]
	public float m22; // 0x28
	[NativeName("m_Data[11]")]
	public float m32; // 0x2C
	[NativeName("m_Data[12]")]
	public float m03; // 0x30
	[NativeName("m_Data[13]")]
	public float m13; // 0x34
	[NativeName("m_Data[14]")]
	public float m23; // 0x38
	[NativeName("m_Data[15]")]
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 identity { get; }
	public FrustumPlanes decomposeProjection { get; }
	public Matrix4x4 inverse { get; }

	// Methods

	// RVA: 0x2DB1714 Offset: 0x2DB1714 VA: 0x2DB1714
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x2DB1730 Offset: 0x2DB1730 VA: 0x2DB1730
	public float get_Item(int row, int column) { }

	// RVA: 0x2DB182C Offset: 0x2DB182C VA: 0x2DB182C
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x2DB1738 Offset: 0x2DB1738 VA: 0x2DB1738
	public float get_Item(int index) { }

	// RVA: 0x2DB1834 Offset: 0x2DB1834 VA: 0x2DB1834
	public void set_Item(int index, float value) { }

	// RVA: 0x2DB1928 Offset: 0x2DB1928 VA: 0x2DB1928 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DB1B94 Offset: 0x2DB1B94 VA: 0x2DB1B94 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2DB1D08 Offset: 0x2DB1D08 VA: 0x2DB1D08 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x2DB1E10 Offset: 0x2DB1E10 VA: 0x2DB1E10
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x2DB1FB8 Offset: 0x2DB1FB8 VA: 0x2DB1FB8
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x2DB1ABC Offset: 0x2DB1ABC VA: 0x2DB1ABC
	public Vector4 GetColumn(int index) { }

	// RVA: 0x2DB1FEC Offset: 0x2DB1FEC VA: 0x2DB1FEC
	public Vector4 GetRow(int index) { }

	// RVA: 0x2DB20C4 Offset: 0x2DB20C4 VA: 0x2DB20C4
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x2DB212C Offset: 0x2DB212C VA: 0x2DB212C
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x2DB21AC Offset: 0x2DB21AC VA: 0x2DB21AC
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x2DB2204 Offset: 0x2DB2204 VA: 0x2DB2204
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x2DB224C Offset: 0x2DB224C VA: 0x2DB224C
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x2DB2278 Offset: 0x2DB2278 VA: 0x2DB2278
	public static Matrix4x4 get_identity() { }

	// RVA: 0x2DB22D0 Offset: 0x2DB22D0 VA: 0x2DB22D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2DB22DC Offset: 0x2DB22DC VA: 0x2DB22DC Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	[ThreadSafe]
	// RVA: 0x2DB28A4 Offset: 0x2DB28A4 VA: 0x2DB28A4
	private FrustumPlanes DecomposeProjection() { }

	// RVA: 0x2DB2950 Offset: 0x2DB2950 VA: 0x2DB2950
	public FrustumPlanes get_decomposeProjection() { }

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	// RVA: 0x2DB29C8 Offset: 0x2DB29C8 VA: 0x2DB29C8
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	// RVA: 0x2DB2AB4 Offset: 0x2DB2AB4 VA: 0x2DB2AB4
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	// RVA: 0x2DB2B3C Offset: 0x2DB2B3C VA: 0x2DB2B3C
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x2DB2BEC Offset: 0x2DB2BEC VA: 0x2DB2BEC
	public Matrix4x4 get_inverse() { }

	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
	// RVA: 0x2DB2C74 Offset: 0x2DB2C74 VA: 0x2DB2C74
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[FreeFunction("MatrixScripting::LookAt", IsThreadSafe = True)]
	// RVA: 0x2DB2DA4 Offset: 0x2DB2DA4 VA: 0x2DB2DA4
	public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up) { }

	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
	// RVA: 0x2DB2E90 Offset: 0x2DB2E90 VA: 0x2DB2E90
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x2DB2FC0 Offset: 0x2DB2FC0 VA: 0x2DB2FC0
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	// RVA: 0x2DB3070 Offset: 0x2DB3070 VA: 0x2DB3070
	private static void .cctor() { }

	// RVA: 0x2DB290C Offset: 0x2DB290C VA: 0x2DB290C
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	// RVA: 0x2DB2A58 Offset: 0x2DB2A58 VA: 0x2DB2A58
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x2DB2AF8 Offset: 0x2DB2AF8 VA: 0x2DB2AF8
	private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0x2DB2BA8 Offset: 0x2DB2BA8 VA: 0x2DB2BA8
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x2DB2D20 Offset: 0x2DB2D20 VA: 0x2DB2D20
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x2DB2E34 Offset: 0x2DB2E34 VA: 0x2DB2E34
	private static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret) { }

	// RVA: 0x2DB2F3C Offset: 0x2DB2F3C VA: 0x2DB2F3C
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[DefaultMember("Item")]
[NativeClass("Vector3f")]
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 13936
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }

	// Methods

	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x2DB3F88 Offset: 0x2DB3F88 VA: 0x2DB3F88
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = True)]
	// RVA: 0x2DB4060 Offset: 0x2DB4060 VA: 0x2DB4060
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x2DB40A4 Offset: 0x2DB40A4 VA: 0x2DB40A4
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2DB40E8 Offset: 0x2DB40E8 VA: 0x2DB40E8
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x2DB41D0 Offset: 0x2DB41D0 VA: 0x2DB41D0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2DB420C Offset: 0x2DB420C VA: 0x2DB420C
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x2DB4234 Offset: 0x2DB4234 VA: 0x2DB4234
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocs]
	// RVA: 0x2DB4348 Offset: 0x2DB4348 VA: 0x2DB4348
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x2DB43D4 Offset: 0x2DB43D4 VA: 0x2DB43D4
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x2DB4610 Offset: 0x2DB4610 VA: 0x2DB4610
	public float get_Item(int index) { }

	// RVA: 0x2DB468C Offset: 0x2DB468C VA: 0x2DB468C
	public void set_Item(int index, float value) { }

	// RVA: 0x2DB4708 Offset: 0x2DB4708 VA: 0x2DB4708
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2DB4714 Offset: 0x2DB4714 VA: 0x2DB4714
	public void .ctor(float x, float y) { }

	// RVA: 0x2DB4720 Offset: 0x2DB4720 VA: 0x2DB4720
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x2DB4730 Offset: 0x2DB4730 VA: 0x2DB4730
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2DB4758 Offset: 0x2DB4758 VA: 0x2DB4758 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2DB47A0 Offset: 0x2DB47A0 VA: 0x2DB47A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2DB4838 Offset: 0x2DB4838 VA: 0x2DB4838 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x2DB4868 Offset: 0x2DB4868 VA: 0x2DB4868
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x2DB4938 Offset: 0x2DB4938 VA: 0x2DB4938
	public void Normalize() { }

	// RVA: 0x2DB4A20 Offset: 0x2DB4A20 VA: 0x2DB4A20
	public Vector3 get_normalized() { }

	// RVA: 0x2DB4AEC Offset: 0x2DB4AEC VA: 0x2DB4AEC
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2DB4B04 Offset: 0x2DB4B04 VA: 0x2DB4B04
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x2DB4C00 Offset: 0x2DB4C00 VA: 0x2DB4C00
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x2DB4CD8 Offset: 0x2DB4CD8 VA: 0x2DB4CD8
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x2DB4DF4 Offset: 0x2DB4DF4 VA: 0x2DB4DF4
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x2DB4F74 Offset: 0x2DB4F74 VA: 0x2DB4F74
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x2DB5014 Offset: 0x2DB5014 VA: 0x2DB5014
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x2DB50C8 Offset: 0x2DB50C8 VA: 0x2DB50C8
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x2DB5148 Offset: 0x2DB5148 VA: 0x2DB5148
	public float get_magnitude() { }

	// RVA: 0x2DB51C8 Offset: 0x2DB51C8 VA: 0x2DB51C8
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x2DB51E0 Offset: 0x2DB51E0 VA: 0x2DB51E0
	public float get_sqrMagnitude() { }

	// RVA: 0x2DB5200 Offset: 0x2DB5200 VA: 0x2DB5200
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2DB521C Offset: 0x2DB521C VA: 0x2DB521C
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2DB5238 Offset: 0x2DB5238 VA: 0x2DB5238
	public static Vector3 get_zero() { }

	// RVA: 0x2DB5284 Offset: 0x2DB5284 VA: 0x2DB5284
	public static Vector3 get_one() { }

	// RVA: 0x2DB52D0 Offset: 0x2DB52D0 VA: 0x2DB52D0
	public static Vector3 get_forward() { }

	// RVA: 0x2DB531C Offset: 0x2DB531C VA: 0x2DB531C
	public static Vector3 get_back() { }

	// RVA: 0x2DB5368 Offset: 0x2DB5368 VA: 0x2DB5368
	public static Vector3 get_up() { }

	// RVA: 0x2DB53B4 Offset: 0x2DB53B4 VA: 0x2DB53B4
	public static Vector3 get_down() { }

	// RVA: 0x2DB5400 Offset: 0x2DB5400 VA: 0x2DB5400
	public static Vector3 get_left() { }

	// RVA: 0x2DB544C Offset: 0x2DB544C VA: 0x2DB544C
	public static Vector3 get_right() { }

	// RVA: 0x2DB5498 Offset: 0x2DB5498 VA: 0x2DB5498
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x2DB54A8 Offset: 0x2DB54A8 VA: 0x2DB54A8
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x2DB54B8 Offset: 0x2DB54B8 VA: 0x2DB54B8
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x2DB54C8 Offset: 0x2DB54C8 VA: 0x2DB54C8
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x2DB54D8 Offset: 0x2DB54D8 VA: 0x2DB54D8
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x2DB54EC Offset: 0x2DB54EC VA: 0x2DB54EC
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x2DB54FC Offset: 0x2DB54FC VA: 0x2DB54FC
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2DB5530 Offset: 0x2DB5530 VA: 0x2DB5530
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x2DB5564 Offset: 0x2DB5564 VA: 0x2DB5564 Slot: 3
	public override string ToString() { }

	// RVA: 0x2DB5570 Offset: 0x2DB5570 VA: 0x2DB5570 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2DB575C Offset: 0x2DB575C VA: 0x2DB575C
	private static void .cctor() { }

	// RVA: 0x2DB3FFC Offset: 0x2DB3FFC VA: 0x2DB3FFC
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x2DB4164 Offset: 0x2DB4164 VA: 0x2DB4164
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }
}

// Namespace: 
public enum Camera.StereoscopicEye // TypeDefIndex: 14076
{
	// Fields
	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;
}

// Namespace: 
public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 14077
{
	// Fields
	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;
}

// Namespace: 
public enum Camera.RenderRequestMode // TypeDefIndex: 14078
{
	// Fields
	public int value__; // 0x0
	public const Camera.RenderRequestMode None = 0;
	public const Camera.RenderRequestMode ObjectId = 1;
	public const Camera.RenderRequestMode Depth = 2;
	public const Camera.RenderRequestMode VertexNormal = 3;
	public const Camera.RenderRequestMode WorldPosition = 4;
	public const Camera.RenderRequestMode EntityId = 5;
	public const Camera.RenderRequestMode BaseColor = 6;
	public const Camera.RenderRequestMode SpecularColor = 7;
	public const Camera.RenderRequestMode Metallic = 8;
	public const Camera.RenderRequestMode Emission = 9;
	public const Camera.RenderRequestMode Normal = 10;
	public const Camera.RenderRequestMode Smoothness = 11;
	public const Camera.RenderRequestMode Occlusion = 12;
	public const Camera.RenderRequestMode DiffuseColor = 13;
}

// Namespace: 
public enum Camera.RenderRequestOutputSpace // TypeDefIndex: 14079
{
	// Fields
	public int value__; // 0x0
	public const Camera.RenderRequestOutputSpace ScreenSpace = -1;
	public const Camera.RenderRequestOutputSpace UV0 = 0;
	public const Camera.RenderRequestOutputSpace UV1 = 1;
	public const Camera.RenderRequestOutputSpace UV2 = 2;
	public const Camera.RenderRequestOutputSpace UV3 = 3;
	public const Camera.RenderRequestOutputSpace UV4 = 4;
	public const Camera.RenderRequestOutputSpace UV5 = 5;
	public const Camera.RenderRequestOutputSpace UV6 = 6;
	public const Camera.RenderRequestOutputSpace UV7 = 7;
	public const Camera.RenderRequestOutputSpace UV8 = 8;
}

// Namespace: 
public struct Camera.RenderRequest // TypeDefIndex: 14080
{
	// Fields
	private readonly Camera.RenderRequestMode m_CameraRenderMode; // 0x0
	private readonly RenderTexture m_ResultRT; // 0x8
	private readonly Camera.RenderRequestOutputSpace m_OutputSpace; // 0x10
}

// Namespace: 
public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 14081
{
	// Methods

	// RVA: 0x2DD2D70 Offset: 0x2DD2D70 VA: 0x2DD2D70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2DD2E54 Offset: 0x2DD2E54 VA: 0x2DD2E54 Slot: 12
	public virtual void Invoke(Camera cam) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[UsedByNativeCode]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
public sealed class Camera : Behaviour // TypeDefIndex: 14082
{
	// Fields
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativeProperty("Near")]
	public float nearClipPlane { get; set; }
	[NativeProperty("Far")]
	public float farClipPlane { get; }
	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView { get; set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; }
	public bool allowDynamicResolution { get; }
	public float orthographicSize { get; }
	public bool orthographic { get; }
	public float depth { get; }
	public float aspect { get; set; }
	public int cullingMask { get; }
	public int eventMask { get; }
	public CameraType cameraType { get; }
	public Color backgroundColor { get; }
	public CameraClearFlags clearFlags { get; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool usePhysicalProperties { get; set; }
	[NativeProperty("NormalizedViewportRect")]
	public Rect rect { get; }
	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect { get; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public int scaledPixelWidth { get; }
	public int scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public int targetDisplay { get; }
	public Matrix4x4 cameraToWorldMatrix { get; }
	public Matrix4x4 worldToCameraMatrix { get; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { set; }
	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering { set; }
	public static Camera main { get; }
	public static Camera current { get; }
	public bool stereoEnabled { get; }
	public StereoTargetEyeMask stereoTargetEye { get; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }
	public static Camera[] allCameras { get; }

	// Methods

	// RVA: 0x2DD0F6C Offset: 0x2DD0F6C VA: 0x2DD0F6C
	public void .ctor() { }

	// RVA: 0x2DD0F74 Offset: 0x2DD0F74 VA: 0x2DD0F74
	public float get_nearClipPlane() { }

	// RVA: 0x2DD0FB0 Offset: 0x2DD0FB0 VA: 0x2DD0FB0
	public void set_nearClipPlane(float value) { }

	// RVA: 0x2DD0FFC Offset: 0x2DD0FFC VA: 0x2DD0FFC
	public float get_farClipPlane() { }

	// RVA: 0x2DD1038 Offset: 0x2DD1038 VA: 0x2DD1038
	public float get_fieldOfView() { }

	// RVA: 0x2DD1074 Offset: 0x2DD1074 VA: 0x2DD1074
	public void set_fieldOfView(float value) { }

	[NativeName("CalculateRenderingPath")]
	// RVA: 0x2DD10C0 Offset: 0x2DD10C0 VA: 0x2DD10C0
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x2DD10FC Offset: 0x2DD10FC VA: 0x2DD10FC
	public bool get_allowHDR() { }

	// RVA: 0x2DD1138 Offset: 0x2DD1138 VA: 0x2DD1138
	public bool get_allowDynamicResolution() { }

	// RVA: 0x2DD1174 Offset: 0x2DD1174 VA: 0x2DD1174
	public float get_orthographicSize() { }

	// RVA: 0x2DD11B0 Offset: 0x2DD11B0 VA: 0x2DD11B0
	public bool get_orthographic() { }

	// RVA: 0x2DD11EC Offset: 0x2DD11EC VA: 0x2DD11EC
	public float get_depth() { }

	// RVA: 0x2DD1228 Offset: 0x2DD1228 VA: 0x2DD1228
	public float get_aspect() { }

	// RVA: 0x2DD1264 Offset: 0x2DD1264 VA: 0x2DD1264
	public void set_aspect(float value) { }

	// RVA: 0x2DD12B0 Offset: 0x2DD12B0 VA: 0x2DD12B0
	public void ResetAspect() { }

	// RVA: 0x2DD12EC Offset: 0x2DD12EC VA: 0x2DD12EC
	public int get_cullingMask() { }

	// RVA: 0x2DD1328 Offset: 0x2DD1328 VA: 0x2DD1328
	public int get_eventMask() { }

	// RVA: 0x2DD1364 Offset: 0x2DD1364 VA: 0x2DD1364
	public CameraType get_cameraType() { }

	// RVA: 0x2DD13A0 Offset: 0x2DD13A0 VA: 0x2DD13A0
	public Color get_backgroundColor() { }

	// RVA: 0x2DD143C Offset: 0x2DD143C VA: 0x2DD143C
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x2DD1478 Offset: 0x2DD1478 VA: 0x2DD1478
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x2DD14B4 Offset: 0x2DD14B4 VA: 0x2DD14B4
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x2DD14F8 Offset: 0x2DD14F8 VA: 0x2DD14F8
	public bool get_usePhysicalProperties() { }

	// RVA: 0x2DD1534 Offset: 0x2DD1534 VA: 0x2DD1534
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x2DD1578 Offset: 0x2DD1578 VA: 0x2DD1578
	public Rect get_rect() { }

	// RVA: 0x2DD1614 Offset: 0x2DD1614 VA: 0x2DD1614
	public Rect get_pixelRect() { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	// RVA: 0x2DD16B0 Offset: 0x2DD16B0 VA: 0x2DD16B0
	public int get_pixelWidth() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	// RVA: 0x2DD16EC Offset: 0x2DD16EC VA: 0x2DD16EC
	public int get_pixelHeight() { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	// RVA: 0x2DD1728 Offset: 0x2DD1728 VA: 0x2DD1728
	public int get_scaledPixelWidth() { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	// RVA: 0x2DD1764 Offset: 0x2DD1764 VA: 0x2DD1764
	public int get_scaledPixelHeight() { }

	// RVA: 0x2DD17A0 Offset: 0x2DD17A0 VA: 0x2DD17A0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x2DD17DC Offset: 0x2DD17DC VA: 0x2DD17DC
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x2DD1820 Offset: 0x2DD1820 VA: 0x2DD1820
	public int get_targetDisplay() { }

	// RVA: 0x2DD185C Offset: 0x2DD185C VA: 0x2DD185C
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x2DD190C Offset: 0x2DD190C VA: 0x2DD190C
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x2DD19BC Offset: 0x2DD19BC VA: 0x2DD19BC
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x2DD1A6C Offset: 0x2DD1A6C VA: 0x2DD1A6C
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2DD1AF4 Offset: 0x2DD1AF4 VA: 0x2DD1AF4
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2DD1B7C Offset: 0x2DD1B7C VA: 0x2DD1B7C
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x2DD1BC0 Offset: 0x2DD1BC0 VA: 0x2DD1BC0
	public void ResetProjectionMatrix() { }

	// RVA: 0x2DD1BFC Offset: 0x2DD1BFC VA: 0x2DD1BFC
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD1CC8 Offset: 0x2DD1CC8 VA: 0x2DD1CC8
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD1D94 Offset: 0x2DD1D94 VA: 0x2DD1D94
	public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD1E60 Offset: 0x2DD1E60 VA: 0x2DD1E60
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD1F2C Offset: 0x2DD1F2C VA: 0x2DD1F2C
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x2DD1F34 Offset: 0x2DD1F34 VA: 0x2DD1F34
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x2DD1F3C Offset: 0x2DD1F3C VA: 0x2DD1F3C
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x2DD1F44 Offset: 0x2DD1F44 VA: 0x2DD1F44
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x2DD1F4C Offset: 0x2DD1F4C VA: 0x2DD1F4C
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x2DD2008 Offset: 0x2DD2008 VA: 0x2DD2008
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD20DC Offset: 0x2DD20DC VA: 0x2DD20DC
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD2114 Offset: 0x2DD2114 VA: 0x2DD2114
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x2DD2160 Offset: 0x2DD2160 VA: 0x2DD2160
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD2234 Offset: 0x2DD2234 VA: 0x2DD2234
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2DD226C Offset: 0x2DD226C VA: 0x2DD226C
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunction("FindMainCamera")]
	// RVA: 0x2DD22B8 Offset: 0x2DD22B8 VA: 0x2DD22B8
	public static Camera get_main() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	// RVA: 0x2DD22E0 Offset: 0x2DD22E0 VA: 0x2DD22E0
	public static Camera get_current() { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	// RVA: 0x2DD2308 Offset: 0x2DD2308 VA: 0x2DD2308
	public bool get_stereoEnabled() { }

	// RVA: 0x2DD2344 Offset: 0x2DD2344 VA: 0x2DD2344
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	// RVA: 0x2DD2380 Offset: 0x2DD2380 VA: 0x2DD2380
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x2DD23BC Offset: 0x2DD23BC VA: 0x2DD23BC
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2DD248C Offset: 0x2DD248C VA: 0x2DD248C
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	// RVA: 0x2DD24D0 Offset: 0x2DD24D0 VA: 0x2DD24D0
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2DD25A0 Offset: 0x2DD25A0 VA: 0x2DD25A0
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x2DD2648 Offset: 0x2DD2648 VA: 0x2DD2648
	public void ResetStereoProjectionMatrices() { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	// RVA: 0x2DD2684 Offset: 0x2DD2684 VA: 0x2DD2684
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	// RVA: 0x2DD26AC Offset: 0x2DD26AC VA: 0x2DD26AC
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x2DD26E8 Offset: 0x2DD26E8 VA: 0x2DD26E8
	public static int get_allCamerasCount() { }

	// RVA: 0x2DD2710 Offset: 0x2DD2710 VA: 0x2DD2710
	public static Camera[] get_allCameras() { }

	// RVA: 0x2DD27B0 Offset: 0x2DD27B0 VA: 0x2DD27B0
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	// RVA: 0x2DD2894 Offset: 0x2DD2894 VA: 0x2DD2894
	public void Render() { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	// RVA: 0x2DD28D0 Offset: 0x2DD28D0 VA: 0x2DD28D0
	public static void SetupCurrent(Camera cur) { }

	[NativeName("AddCommandBuffer")]
	// RVA: 0x2DD290C Offset: 0x2DD290C VA: 0x2DD290C
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	// RVA: 0x2DD2960 Offset: 0x2DD2960 VA: 0x2DD2960
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2DD29B4 Offset: 0x2DD29B4 VA: 0x2DD29B4
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x2DD2AF0 Offset: 0x2DD2AF0 VA: 0x2DD2AF0
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[RequiredByNativeCode]
	// RVA: 0x2DD2C2C Offset: 0x2DD2C2C VA: 0x2DD2C2C
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x2DD2C98 Offset: 0x2DD2C98 VA: 0x2DD2C98
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x2DD2D04 Offset: 0x2DD2D04 VA: 0x2DD2D04
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x2DD13F8 Offset: 0x2DD13F8 VA: 0x2DD13F8
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2DD15D0 Offset: 0x2DD15D0 VA: 0x2DD15D0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2DD166C Offset: 0x2DD166C VA: 0x2DD166C
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x2DD18C8 Offset: 0x2DD18C8 VA: 0x2DD18C8
	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2DD1978 Offset: 0x2DD1978 VA: 0x2DD1978
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2DD1A28 Offset: 0x2DD1A28 VA: 0x2DD1A28
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2DD1AB0 Offset: 0x2DD1AB0 VA: 0x2DD1AB0
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2DD1B38 Offset: 0x2DD1B38 VA: 0x2DD1B38
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2DD1C6C Offset: 0x2DD1C6C VA: 0x2DD1C6C
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2DD1D38 Offset: 0x2DD1D38 VA: 0x2DD1D38
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2DD1E04 Offset: 0x2DD1E04 VA: 0x2DD1E04
	private void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2DD1ED0 Offset: 0x2DD1ED0 VA: 0x2DD1ED0
	private void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2DD1FB4 Offset: 0x2DD1FB4 VA: 0x2DD1FB4
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2DD2080 Offset: 0x2DD2080 VA: 0x2DD2080
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2DD21D8 Offset: 0x2DD21D8 VA: 0x2DD21D8
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x2DD2438 Offset: 0x2DD2438 VA: 0x2DD2438
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2DD254C Offset: 0x2DD254C VA: 0x2DD254C
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2DD25F4 Offset: 0x2DD25F4 VA: 0x2DD25F4
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }
}

// Namespace: 
private class Transform.Enumerator : IEnumerator // TypeDefIndex: 14158
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x2DDFB88 Offset: 0x2DDFB88 VA: 0x2DDFB88
	internal void .ctor(Transform outer) { }

	// RVA: 0x2DDFC04 Offset: 0x2DDFC04 VA: 0x2DDFC04 Slot: 5
	public object get_Current() { }

	// RVA: 0x2DDFC50 Offset: 0x2DDFC50 VA: 0x2DDFC50 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2DDFCB0 Offset: 0x2DDFCB0 VA: 0x2DDFCB0 Slot: 6
	public void Reset() { }
}

// Namespace: UnityEngine
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[RequiredByNativeCode]
public class Transform : Component, IEnumerable // TypeDefIndex: 14159
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; }
	public Vector3 up { get; }
	public Vector3 forward { get; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform root { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged { get; set; }

	// Methods

	// RVA: 0x2DDE13C Offset: 0x2DDE13C VA: 0x2DDE13C
	protected void .ctor() { }

	// RVA: 0x2DDE140 Offset: 0x2DDE140 VA: 0x2DDE140
	public Vector3 get_position() { }

	// RVA: 0x2DDE1E0 Offset: 0x2DDE1E0 VA: 0x2DDE1E0
	public void set_position(Vector3 value) { }

	// RVA: 0x2DDE278 Offset: 0x2DDE278 VA: 0x2DDE278
	public Vector3 get_localPosition() { }

	// RVA: 0x2DDE318 Offset: 0x2DDE318 VA: 0x2DDE318
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x2DDE3B0 Offset: 0x2DDE3B0 VA: 0x2DDE3B0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x2DDE438 Offset: 0x2DDE438 VA: 0x2DDE438
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x2DDE4BC Offset: 0x2DDE4BC VA: 0x2DDE4BC
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x2DDE544 Offset: 0x2DDE544 VA: 0x2DDE544
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x2DDE5C8 Offset: 0x2DDE5C8 VA: 0x2DDE5C8
	public Vector3 get_right() { }

	// RVA: 0x2DDE644 Offset: 0x2DDE644 VA: 0x2DDE644
	public Vector3 get_up() { }

	// RVA: 0x2DDE6C0 Offset: 0x2DDE6C0 VA: 0x2DDE6C0
	public Vector3 get_forward() { }

	// RVA: 0x2DDE3E0 Offset: 0x2DDE3E0 VA: 0x2DDE3E0
	public Quaternion get_rotation() { }

	// RVA: 0x2DDE468 Offset: 0x2DDE468 VA: 0x2DDE468
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2DDE4EC Offset: 0x2DDE4EC VA: 0x2DDE4EC
	public Quaternion get_localRotation() { }

	// RVA: 0x2DDE574 Offset: 0x2DDE574 VA: 0x2DDE574
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x2DDE84C Offset: 0x2DDE84C VA: 0x2DDE84C
	public Vector3 get_localScale() { }

	// RVA: 0x2DDE8EC Offset: 0x2DDE8EC VA: 0x2DDE8EC
	public void set_localScale(Vector3 value) { }

	// RVA: 0x2DDE984 Offset: 0x2DDE984 VA: 0x2DDE984
	public Transform get_parent() { }

	// RVA: 0x2DDE9FC Offset: 0x2DDE9FC VA: 0x2DDE9FC
	public void set_parent(Transform value) { }

	// RVA: 0x2DDE9C0 Offset: 0x2DDE9C0 VA: 0x2DDE9C0
	internal Transform get_parentInternal() { }

	// RVA: 0x2DDEAC4 Offset: 0x2DDEAC4 VA: 0x2DDEAC4
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x2DDEB0C Offset: 0x2DDEB0C VA: 0x2DDEB0C
	private Transform GetParent() { }

	// RVA: 0x2DDEB48 Offset: 0x2DDEB48 VA: 0x2DDEB48
	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	// RVA: 0x2DDEB90 Offset: 0x2DDEB90 VA: 0x2DDEB90
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x2DDEBE4 Offset: 0x2DDEBE4 VA: 0x2DDEBE4
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x2DDEC94 Offset: 0x2DDEC94 VA: 0x2DDEC94
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2DDED44 Offset: 0x2DDED44 VA: 0x2DDED44
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2DDEDF8 Offset: 0x2DDEDF8 VA: 0x2DDEDF8
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x2DDF080 Offset: 0x2DDF080 VA: 0x2DDF080
	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	// RVA: 0x2DDF084 Offset: 0x2DDF084 VA: 0x2DDF084
	public void LookAt(Transform target) { }

	// RVA: 0x2DDF178 Offset: 0x2DDF178 VA: 0x2DDF178
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2DDF1DC Offset: 0x2DDF1DC VA: 0x2DDF1DC
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	// RVA: 0x2DDF17C Offset: 0x2DDF17C VA: 0x2DDF17C
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x2DDF2AC Offset: 0x2DDF2AC VA: 0x2DDF2AC
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x2DDF368 Offset: 0x2DDF368 VA: 0x2DDF368
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x2DDF424 Offset: 0x2DDF424 VA: 0x2DDF424
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x2DDF4E0 Offset: 0x2DDF4E0 VA: 0x2DDF4E0
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x2DDF59C Offset: 0x2DDF59C VA: 0x2DDF59C
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x2DDF658 Offset: 0x2DDF658 VA: 0x2DDF658
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x2DDF714 Offset: 0x2DDF714 VA: 0x2DDF714
	public Transform get_root() { }

	// RVA: 0x2DDF750 Offset: 0x2DDF750 VA: 0x2DDF750
	private Transform GetRoot() { }

	[NativeMethod("GetChildrenCount")]
	// RVA: 0x2DDF78C Offset: 0x2DDF78C VA: 0x2DDF78C
	public int get_childCount() { }

	// RVA: 0x2DDF7C8 Offset: 0x2DDF7C8 VA: 0x2DDF7C8
	public void SetAsFirstSibling() { }

	// RVA: 0x2DDF804 Offset: 0x2DDF804 VA: 0x2DDF804
	public void SetAsLastSibling() { }

	// RVA: 0x2DDF840 Offset: 0x2DDF840 VA: 0x2DDF840
	public void SetSiblingIndex(int index) { }

	// RVA: 0x2DDF884 Offset: 0x2DDF884 VA: 0x2DDF884
	public int GetSiblingIndex() { }

	[FreeFunction]
	// RVA: 0x2DDF8C0 Offset: 0x2DDF8C0 VA: 0x2DDF8C0
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x2DDF914 Offset: 0x2DDF914 VA: 0x2DDF914
	public Transform Find(string n) { }

	[NativeMethod("GetWorldScaleLossy")]
	// RVA: 0x2DDF9AC Offset: 0x2DDF9AC VA: 0x2DDF9AC
	public Vector3 get_lossyScale() { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	// RVA: 0x2DDFA4C Offset: 0x2DDFA4C VA: 0x2DDFA4C
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x2DDFA90 Offset: 0x2DDFA90 VA: 0x2DDFA90
	public bool get_hasChanged() { }

	// RVA: 0x2DDFACC Offset: 0x2DDFACC VA: 0x2DDFACC
	public void set_hasChanged(bool value) { }

	// RVA: 0x2DDFB10 Offset: 0x2DDFB10 VA: 0x2DDFB10 Slot: 4
	public IEnumerator GetEnumerator() { }

	[NativeThrows]
	[FreeFunction("GetChild", HasExplicitThis = True)]
	// RVA: 0x2DDFBC0 Offset: 0x2DDFBC0 VA: 0x2DDFBC0
	public Transform GetChild(int index) { }

	// RVA: 0x2DDE19C Offset: 0x2DDE19C VA: 0x2DDE19C
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x2DDE234 Offset: 0x2DDE234 VA: 0x2DDE234
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x2DDE2D4 Offset: 0x2DDE2D4 VA: 0x2DDE2D4
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2DDE36C Offset: 0x2DDE36C VA: 0x2DDE36C
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x2DDE73C Offset: 0x2DDE73C VA: 0x2DDE73C
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x2DDE780 Offset: 0x2DDE780 VA: 0x2DDE780
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x2DDE7C4 Offset: 0x2DDE7C4 VA: 0x2DDE7C4
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2DDE808 Offset: 0x2DDE808 VA: 0x2DDE808
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x2DDE8A8 Offset: 0x2DDE8A8 VA: 0x2DDE8A8
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x2DDE940 Offset: 0x2DDE940 VA: 0x2DDE940
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x2DDEC50 Offset: 0x2DDEC50 VA: 0x2DDEC50
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2DDED00 Offset: 0x2DDED00 VA: 0x2DDED00
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2DDEDA4 Offset: 0x2DDEDA4 VA: 0x2DDEDA4
	private void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x2DDF258 Offset: 0x2DDF258 VA: 0x2DDF258
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x2DDF314 Offset: 0x2DDF314 VA: 0x2DDF314
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2DDF3D0 Offset: 0x2DDF3D0 VA: 0x2DDF3D0
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x2DDF48C Offset: 0x2DDF48C VA: 0x2DDF48C
	private void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2DDF548 Offset: 0x2DDF548 VA: 0x2DDF548
	private void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x2DDF604 Offset: 0x2DDF604 VA: 0x2DDF604
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2DDF6C0 Offset: 0x2DDF6C0 VA: 0x2DDF6C0
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2DDFA08 Offset: 0x2DDFA08 VA: 0x2DDFA08
	private void get_lossyScale_Injected(out Vector3 ret) { }
}

// Namespace: Axlebolt.Standoff.Core
public enum Team // TypeDefIndex: 18182
{
	// Fields
	public byte value__; // 0x0
	public const Team None = 0;
	public const Team Tr = 1;
	public const Team Ct = 2;
	public const Team Spectator = 3;
}

