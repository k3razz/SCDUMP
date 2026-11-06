
// Namespace: 
[CompilerGenerated]
private struct PlayerProfileController.bzv : IAsyncStateMachine // TypeDefIndex: 5051
{
	// Fields
	public int cksd; // 0x0
	public AsyncVoidMethodBuilder ckse; // 0x8
	public string cksf; // 0x28
	public PlayerProfileController cksg; // 0x30
	private TaskAwaiter cksh; // 0x38

	// Methods

	// RVA: 0x10833F0 Offset: 0x10823F0 VA: 0x1810833F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x723720 Offset: 0x722720 VA: 0x180723720 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class PlayerProfileController : MonoBehaviour // TypeDefIndex: 5052
{
	// Fields
	[CompilerGenerated]
	private Action <cksi>k__BackingField; // 0x20
	[FormerlySerializedAs("_shortProfileView")]
	[SerializeField]
	private PlayerProfileView _playerProfileView; // 0x28
	[SerializeField]
	private PlayerNameChangeController _nameChangeDialog; // 0x30
	private dpj cksj; // 0x38
	private dpe cksk; // 0x40

	// Properties
	public PlayerProfileView dqgw { get; }
	public Action cksi { get; set; }

	// Methods

	// RVA: 0x5B6260 Offset: 0x5B5260 VA: 0x1805B6260
	public PlayerProfileView vry() { }

	[CompilerGenerated]
	// RVA: 0x5D2C90 Offset: 0x5D1C90 VA: 0x1805D2C90
	public Action vrz() { }

	[CompilerGenerated]
	// RVA: 0x5FF1A0 Offset: 0x5FE1A0 VA: 0x1805FF1A0
	public void vsa(Action a) { }

	// RVA: 0x107F3A0 Offset: 0x107E3A0 VA: 0x18107F3A0
	public void vsb() { }

	// RVA: 0x107F4B0 Offset: 0x107E4B0 VA: 0x18107F4B0
	private void vsc() { }

	[AsyncStateMachine(typeof(PlayerProfileController.bzv))]
	// RVA: 0x107F510 Offset: 0x107E510 VA: 0x18107F510
	private void vsd(string a) { }

	[AsyncStateMachine(typeof(PlayerProfileController.bzu))]
	// RVA: 0x107F5E0 Offset: 0x107E5E0 VA: 0x18107F5E0
	public void vse(string a) { }

	[AsyncStateMachine(typeof(PlayerProfileController.bzt))]
	// RVA: 0x107F6B0 Offset: 0x107E6B0 VA: 0x18107F6B0
	public void vsf(byte[] a) { }

	// RVA: 0x107F780 Offset: 0x107E780 VA: 0x18107F780
	public void vsg(dpj a, dpe b) { }

	// RVA: 0x713990 Offset: 0x712990 VA: 0x180713990
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x107F880 Offset: 0x107E880 VA: 0x18107F880
	private void vsh() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class PlayerProfileView : View // TypeDefIndex: 5053
{
	// Fields
	[CompilerGenerated]
	private Action <cksl>k__BackingField; // 0x30
	[CompilerGenerated]
	private Action <cksm>k__BackingField; // 0x38
	[SerializeField]
	private AvatarImage _avatarImage; // 0x40
	[SerializeField]
	private AvatarImage _backgroundAvatarImage; // 0x48
	[SerializeField]
	private TMP_Text _idText; // 0x50
	[SerializeField]
	private Button _idButton; // 0x58
	[SerializeField]
	private TMP_Text _nameText; // 0x60
	[SerializeField]
	private Button _nameChangeButton; // 0x68
	[SerializeField]
	private Button _shareButton; // 0x70
	[SerializeField]
	private RankView _rankView; // 0x78
	[SerializeField]
	private Rank2X2View _rank2X2View; // 0x80
	[SerializeField]
	private RankDuelView _rankDuelView; // 0x88
	private string cksn; // 0x90

	// Properties
	public Action cksl { get; set; }
	public Action cksm { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5FF110 Offset: 0x5FE110 VA: 0x1805FF110
	public Action vsi() { }

	[CompilerGenerated]
	// RVA: 0x5FF1D0 Offset: 0x5FE1D0 VA: 0x1805FF1D0
	public void vsj(Action a) { }

	[CompilerGenerated]
	// RVA: 0x5FF120 Offset: 0x5FE120 VA: 0x1805FF120
	public Action vsk() { }

	[CompilerGenerated]
	// RVA: 0x5FF1E0 Offset: 0x5FE1E0 VA: 0x1805FF1E0
	public void vsl(Action a) { }

	// RVA: 0x107F970 Offset: 0x107E970 VA: 0x18107F970
	private void Awake() { }

	// RVA: 0x107FBA0 Offset: 0x107EBA0 VA: 0x18107FBA0
	public void vsm(dpj a, dpe b) { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x107FE00 Offset: 0x107EE00 VA: 0x18107FE00
	private void vsn() { }

	[CompilerGenerated]
	// RVA: 0x107FE40 Offset: 0x107EE40 VA: 0x18107FE40
	private void vso() { }

	[CompilerGenerated]
	// RVA: 0x107FE80 Offset: 0x107EE80 VA: 0x18107FE80
	private void vsp() { }

	[CompilerGenerated]
	// RVA: 0x107FE90 Offset: 0x107EE90 VA: 0x18107FE90
	private void vsq() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProfileController.<>c // TypeDefIndex: 5054
{
	// Fields
	public static readonly ProfileController.<>c <>9; // 0x0
	public static Action <>9__2_0; // 0x8

	// Methods

	// RVA: 0x1081BA0 Offset: 0x1080BA0 VA: 0x181081BA0
	private static void .cctor() { }

	// RVA: 0x5BD600 Offset: 0x5BC600 VA: 0x1805BD600
	public void .ctor() { }

	// RVA: 0x1081F00 Offset: 0x1080F00 VA: 0x181081F00
	internal void vsr() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class ProfileController : TabController<ProfileController> // TypeDefIndex: 5055
{
	// Fields
	[SerializeField]
	private PlayerProfileController _shortProfileController; // 0x78
	[SerializeField]
	private StatsMainController _statsMainController; // 0x80

	// Methods

	// RVA: 0x107FF00 Offset: 0x107EF00 VA: 0x18107FF00 Slot: 30
	protected override void mlj() { }

	// RVA: 0x1080060 Offset: 0x107F060 VA: 0x181080060 Slot: 26
	protected override void mlk() { }

	// RVA: 0x107FEA0 Offset: 0x107EEA0 VA: 0x18107FEA0
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class Rank2X2View : RankView // TypeDefIndex: 5056
{
	// Properties
	protected override string dqgx { get; }

	// Methods

	// RVA: 0x1080540 Offset: 0x107F540 VA: 0x181080540 Slot: 16
	protected override string vss() { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class RankCalibrationView : View // TypeDefIndex: 5057
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI _matchesLeftText; // 0x30

	// Methods

	// RVA: 0x1080570 Offset: 0x107F570 VA: 0x181080570
	public void vst(int a, int b) { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class RankDuelView : RankView // TypeDefIndex: 5058
{
	// Properties
	protected override string dqgx { get; }

	// Methods

	// RVA: 0x1080640 Offset: 0x107F640 VA: 0x181080640 Slot: 16
	protected override string vss() { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class RankEmptyView : View // TypeDefIndex: 5059
{
	// Fields
	[SerializeField]
	private Text _titleText; // 0x30
	[SerializeField]
	private fmj _gameModeName; // 0x38

	// Methods

	// RVA: 0x1080670 Offset: 0x107F670 VA: 0x181080670
	private void Awake() { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class RankLockedView : View // TypeDefIndex: 5060
{
	// Methods

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class RankOpenView : View // TypeDefIndex: 5061
{
	// Fields
	[SerializeField]
	private Image _rankBackgroundGradient; // 0x30
	[SerializeField]
	private Image _rankBackground; // 0x38
	[SerializeField]
	private Image _rankIcon; // 0x40
	[SerializeField]
	private TextMeshProUGUI _rankName; // 0x48
	[SerializeField]
	private TextMeshProUGUI _mmr; // 0x50
	[SerializeField]
	private Sprite _unknownRankSprite; // 0x58

	// Methods

	// RVA: 0x1080750 Offset: 0x107F750 VA: 0x181080750
	public void vsu(RankDefinition a, int b) { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class RankView : View // TypeDefIndex: 5062
{
	// Fields
	[SerializeField]
	protected RankOpenView _rankOpen; // 0x30
	[SerializeField]
	private RankCalibrationView _rankCalibration; // 0x38
	[SerializeField]
	private RankLockedView _rankLocked; // 0x40

	// Properties
	protected virtual string dqgx { get; }

	// Methods

	// RVA: 0x1080910 Offset: 0x107F910 VA: 0x181080910 Slot: 16
	protected virtual string vss() { }

	// RVA: 0x1080940 Offset: 0x107F940 VA: 0x181080940
	public void vsv(dpj a, dpe b) { }

	// RVA: 0x1080EE0 Offset: 0x107FEE0 VA: 0x181080EE0
	protected ye vsw() { }

	// RVA: 0x1080F50 Offset: 0x107FF50 VA: 0x181080F50
	protected yf vsx() { }

	// RVA: 0xF6DE50 Offset: 0xF6CE50 VA: 0x180F6DE50
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class StatsMainController : FrameController // TypeDefIndex: 5063
{
	// Fields
	[SerializeField]
	private StatsTabBar _statsTabBar; // 0x60
	[SerializeField]
	private CompetitiveStatsTabController _rankedStatsTabController; // 0x68
	[SerializeField]
	private CommonStatsTabController _commonStatsTabController; // 0x70
	[SerializeField]
	private MatchesTabController _matchesTabController; // 0x78
	[SerializeField]
	private bool _selectRankedStats; // 0x80
	private bool ckso; // 0x81

	// Methods

	// RVA: 0x10818E0 Offset: 0x10808E0 VA: 0x1810818E0 Slot: 30
	protected override void mlj() { }

	// RVA: 0x10819B0 Offset: 0x10809B0 VA: 0x1810819B0
	public void vsy(dpj a, dpe b) { }

	// RVA: 0x10818D0 Offset: 0x10808D0 VA: 0x1810818D0
	public void .ctor() { }
}

// Namespace: Chillow.StandChillow.Main.Profile
public class StatsTabBar : TabBar // TypeDefIndex: 5064
{
	// Fields
	[SerializeField]
	private TabBtn _rankedStatsButton; // 0x70
	[SerializeField]
	private TabBtn _commonStatsButton; // 0x78
	[SerializeField]
	private TabBtn _matchesButton; // 0x80

	// Methods

	// RVA: 0xFA3FD0 Offset: 0xFA2FD0 VA: 0x180FA3FD0
	public void vsz(CompetitiveStatsTabController a) { }

	// RVA: 0xFA3FE0 Offset: 0xFA2FE0 VA: 0x180FA3FE0
	public void vta(CommonStatsTabController a) { }

	// RVA: 0xFAF520 Offset: 0xFAE520 VA: 0x180FAF520
	public void vtb(MatchesTabController a) { }

	// RVA: 0xFA3FC0 Offset: 0xFA2FC0 VA: 0x180FA3FC0
	public void .ctor() { }
}

Поиск "UserName" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "NickName" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "Nickname" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "Latency" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "Latency" (найдено 0 совпадений в 0 выделениях из 1) [Обычный: Слова]
Поиск "Ping" (найдено 0 совпадений в 0 выделениях из 1) [Обычный: Слова]
Поиск "RTT" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class NetPlayer" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class NetworkManager" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class NetcodeClient" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class ConnectionManager" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class NetworkClient" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class PlayerInfo" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
Поиск "class UserProfile" (найдено 0 совпадений в 0 выделениях из 1) [Обычный]
