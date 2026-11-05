	Строка  114030: 	public const e OnBombPlanted = 4;
	Строка  125099: 	public const string caso = "Alert/BombArea";
	Строка  125100: 	public const string casp = "Alert/BombHasBeenPlanted";
	Строка  125101: 	public const string casq = "Alert/BombHasBeenPlantedWithoutTimer";
	Строка  125146: 	public const string catl = "AudioSettings/MusicOfPlantedBomb";
	Строка  125668: 	public const string cbhz = "Defuse/MvpDefusingBomb";
	Строка  125670: 	public const string cbib = "Defuse/MvpPlantingBomb";
	Строка  126343: 	public const string cbzw = "KeyboardGameActions/SwitchToBomb";
	Строка  126584: 	public const string ccgp = "LocationsCallouts/BombsiteA";
	Строка  126585: 	public const string ccgq = "LocationsCallouts/BombsiteB";
	Строка  127548: 	public const string cdfr = "StandChillow/BotCoordinateBombSiteSelected";
	Строка  133843: 	private bool _bombEnabled; // 0x6A
	Строка  138140: 	[ReflectSetting(ceso = "Debug Info: Bomb Manager")]
	Строка  138141: 	public bool DebugInfoBombManagerEnabled; // 0x2A
	Строка  147914: public class BombWeaponryController : Controller // TypeDefIndex: 3752
	Строка  155144: private struct BombManager.bdg : IAsyncStateMachine // TypeDefIndex: 3926
	Строка  155148: 	public faf<BombManager> cgqi; // 0x8
	Строка  155164: public class BombManager : efa<BombManager> // TypeDefIndex: 3927
	Строка  155172: 	private BombSite[] <cgqn>k__BackingField; // 0x40
	Строка  155174: 	private BombSitesContainer[] <cgqo>k__BackingField; // 0x48
	Строка  155179: 	private PlantedBombController cgqt; // 0x78
	Строка  155182: 	private BombParameters cgqw; // 0x88
	Строка  155183: 	private BombSoundParameters cgqx; // 0x90
	Строка  155184: 	private BombExtendedParameters cgqy; // 0x98
	Строка  155202: 	public BombSite[] cgqn { get; set; }
	Строка  155204: 	public BombSitesContainer[] cgqo { get; set; }
	Строка  155238: 	public BombSite[] pnp() { }
	Строка  155242: 	private void pnq(BombSite[] a) { }
	Строка  155249: 	public BombSitesContainer[] pns() { }
	Строка  155253: 	private void pnt(BombSitesContainer[] a) { }
	Строка  155371: 	public bool ppd(edq a, BombController b) { }
	Строка  155468: 	public BombSite pqi() { }
	Строка  155471: 	public BombSitesContainer pqj() { }
	Строка  155489: 	public BombSite pqp(cfs a) { }
	Строка  155495: 	public BombSitesContainer pqr(cfs a) { }
	Строка  155501: 	private BombSite pqt(cfs a) { }
	Строка  155504: 	private BombSitesContainer pqu(cfs a) { }
	Строка  155511: 	|-BombManager.pqv<object>
	Строка  155519: 	|-BombManager.pqw<object>
	Строка  155556: 	[AsyncStateMachine(typeof(BombManager.bdg))]
	Строка  155558: 	public static UniTask<BombManager> prf(CancellationToken a) { }
	Строка  155562: 	internal static BombManager prg(fiu a, short b, string c, eek d) { }
	Строка  155566: 	private static BombManager prh(short a, string b, eek c) { }
	Строка  158190: 	private const string chac = "BombSite";
	Строка  158242: 	public const string chae = "bomberId";
	Строка  159736: 	public BoolValue BombPlanted; // 0x18
	Строка  159737: 	public BoolValue BombDefused; // 0x20
	Строка  205801: public class BombSite : StaticMapZone // TypeDefIndex: 5329
	Строка  205820: public class BombSitesContainer : StaticMapZone // TypeDefIndex: 5330
	Строка  205824: 	private BombSite[] <cllz>k__BackingField; // 0x38
	Строка  205826: 	private cfs _bombSitesType; // 0x40
	Строка  205829: 	public BombSite[] cllz { get; set; }
	Строка  205836: 	public BombSite[] wts() { }
	Строка  205840: 	private void wtt(BombSite[] a) { }
	Строка  205853: public class BombSiteSpawnZone : TeamSpawnZone // TypeDefIndex: 5331
	Строка  206013: public class BombSiteZoneParams : ZoneParams // TypeDefIndex: 5339
	Строка  206017: 	private cfs _bombSite; // 0x50
	Строка  206044: 	internal bool wuj(BombSiteZoneParams a) { }
	Строка  206073: 	private BombSiteZoneParams[] _bombSiteZonesParams; // 0x20
	Строка  206078: 	public BombSiteZoneParams[] dqkv { get; }
	Строка  206089: 	public BombSiteZoneParams[] wun() { }
	Строка  209235: 	public const che Bomb = 4;
	Строка  209487: 	public const chh Bomb = 4;
	Строка  215574: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215576: public class BombBeepStep // TypeDefIndex: 5562
	Строка  215600: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215602: public class BombController : WeaponController, cgc // TypeDefIndex: 5563
	Строка  215608: 	private BombMap cmnk; // 0xF8
	Строка  215611: 	private BombParameters <cmnm>k__BackingField; // 0x108
	Строка  215615: 	public BombParameters cmnm { get; set; }
	Строка  215624: 	public BombParameters yle() { }
	Строка  215628: 	private void ylf(BombParameters a) { }
	Строка  215709: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215710: [CreateAssetMenu(fileName = "Bomb", menuName = "Standoff/Create BombExtendedParameters")]
	Строка  215711: public class BombExtendedParameters : ScriptableObject // TypeDefIndex: 5564
	Строка  215717: 	private Vector3 _bombRotation; // 0x20
	Строка  215719: 	private Vector3 _bombOffset; // 0x2C
	Строка  215723: 	private BombBeepStep[] _beepSteps; // 0x48
	Строка  215729: 	private BombSpriteFlareConfig _bombSpriteFlareConfig; // 0x58
	Строка  215737: 	public BombBeepStep[] dqyn { get; }
	Строка  215754: 	public BombBeepStep[] ylw() { }
	Строка  215769: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215770: public class BombIndicator : MonoBehaviour // TypeDefIndex: 5565
	Строка  215813: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215814: public class BombMap : MonoBehaviour // TypeDefIndex: 5566
	Строка  215837: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215838: [CreateAssetMenu(fileName = "Bomb", menuName = "Standoff/Create BombParameters")]
	Строка  215839: public class BombParameters : WeaponParameters // TypeDefIndex: 5567
	Строка  215930: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215931: [CreateAssetMenu(menuName = "Standoff/Create BombSoundParameters")]
	Строка  215932: public class BombSoundParameters : WeaponSoundParameters // TypeDefIndex: 5569
	Строка  215981: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  215983: public class BombSpriteFlareConfig // TypeDefIndex: 5570
	Строка  216025: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  216100: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  216182: private class PlantedBombController.ckt // TypeDefIndex: 5577
	Строка  216210: private class PlantedBombController.cku // TypeDefIndex: 5578
	Строка  216229: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  216230: public class PlantedBombController : MonoBehaviour // TypeDefIndex: 5579
	Строка  216233: 	private const string cmog = "PlantedBombController";
	Строка  216234: 	public const string GameObjectName = "Bomb";
	Строка  216235: 	private BombParameters cmoh; // 0x20
	Строка  216236: 	private BombExtendedParameters cmoi; // 0x28
	Строка  216242: 	private BombSoundParameters cmoo; // 0x50
	Строка  216243: 	private PlantedBombController.ckt cmop; // 0x58
	Строка  216244: 	private PlantedBombController.cku cmoq; // 0x60
	Строка  216245: 	private PlantedBombController.cku cmor; // 0x68
	Строка  216246: 	private PlantedBombController.cku cmos; // 0x70
	Строка  216323: 	public void ynw(BombParameters a, BombSoundParameters b, BombExtendedParameters c) { }
	Строка  216356: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  216400: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  216438: // Namespace: Chillow.StandChillow.Inventory.Bomb
	Строка  217445: 	public static Func<BombSiteSpawnZone, bool> <>9__12_0; // 0x8
	Строка  217446: 	public static Func<BombSiteSpawnZone, bool> <>9__12_1; // 0x10
	Строка  217457: 	internal bool yrd(BombSiteSpawnZone a) { }
	Строка  217460: 	internal bool yre(BombSiteSpawnZone a) { }
	Строка  217467: 	private readonly Dictionary<cfs, List<BombSiteSpawnZone>> cmqj; // 0x10
	Строка  217468: 	private readonly Dictionary<cfs, List<BombSiteSpawnZone>> cmqk; // 0x18
	Строка  217504: 	private static Dictionary<cfs, List<BombSiteSpawnZone>> yrk(IEnumerable<BombSiteSpawnZone> a) { }
	Строка  217510: 	protected List<BombSiteSpawnZone> yrm(Team a) { }
	Строка  217737: 	public const clf OnBombPlantedByLocalPlayer = 4;
	Строка  217741: 	public const clf OnBombPlantedTeamBonus = 8;
	Строка  223718: 	private GameObject _bombKillerContainer; // 0x28
	Строка  226366: 	private GameObject _bombMarker; // 0x48
	Строка  226704: 	private Color _bombColor; // 0xD8
	Строка  227293: private enum BombAlertNotificationView.cpa // TypeDefIndex: 5824
	Строка  227297: 	public const BombAlertNotificationView.cpa Idle = 0;
	Строка  227298: 	public const BombAlertNotificationView.cpa Show = 1;
	Строка  227299: 	public const BombAlertNotificationView.cpa WaitToHide = 2;
	Строка  227300: 	public const BombAlertNotificationView.cpa Hide = 3;
	Строка  227304: public class BombAlertNotificationView : NotificationsHudView // TypeDefIndex: 5825
	Строка  227313: 	private BombAlertNotificationView.cpa cnpy; // 0x50
	Строка  227334: public class BombProgressNotificationView : NotificationsHudView // TypeDefIndex: 5826
	Строка  227346: 	private Sprite _bombIcon; // 0x60
	Строка  227795: 	private Image _imageBomb; // 0x50
	Строка  227936: 	private BombProgressNotificationView _bombProgressNotificationView; // 0xC8
	Строка  227938: 	private BombAlertNotificationView _bombAlertNotificationView; // 0xD0
	Строка  227958: 	public BombProgressNotificationView drir { get; }
	Строка  227959: 	public BombAlertNotificationView dris { get; }
	Строка  227985: 	public BombProgressNotificationView balt() { }
	Строка  227988: 	public BombAlertNotificationView balu() { }
	Строка  228114: 	private NotificatedItemController _bombItem; // 0x50
	Строка  228265: public class BombSiteLevelZoneLabel : LevelZoneLabel // TypeDefIndex: 5852
	Строка  228269: 	private cfs _bombSite; // 0x48
	Строка  228282: public class BombSiteZone // TypeDefIndex: 5853
	Строка  228285: 	public cfs BombSite; // 0x10
	Строка  228528: 	internal bool bani(BombSiteZone a) { }
	Строка  228712: 	private BombSiteZone[] _bombSiteZones; // 0x38
	Строка  228769: 	private BombSiteZone baon(cfs a) { }
	Строка  229288: 	private GameObject _bombTimer; // 0x58
	Строка  234252: 	private Sprite _bombSiteSprite; // 0xC0
	Строка  236395: 	public static Func<BombSitesContainer, bool> <>9__18_0; // 0x8
	Строка  236417: 	internal bool bbqf(BombSitesContainer a) { }
	Строка  236538: 	private float _bombPlantedTime; // 0x310
	Строка  236548: 	private BombSitesContainer[] coov; // 0x360
	Строка  238270: 	private BombParameters <cosu>k__BackingField; // 0x2F8
	Строка  238282: 	public BombParameters cosu { get; set; }
	Строка  238310: 	public BombParameters bbxp() { }
	Строка  238314: 	private void bbxq(BombParameters a) { }
	Строка  238910: 	private float _bombAlertInteval; // 0x2C
	Строка  238970: 	private int _bombPlantReward; // 0x28
	Строка  238972: 	private int _bombDefusedReward; // 0x2C
	Строка  239071: 	[FormerlySerializedAs("_radarBombDrawer")]
	Строка  239073: 	private DefuseBombDrawer _bombDrawer; // 0x10
	Строка  239075: 	private DefusePlantedBombDrawer _plantedBombDrawer; // 0x18
	Строка  239077: 	private Sprite _bombSiteASprite; // 0x20
	Строка  239079: 	private Sprite _bombSiteBSprite; // 0x28
	Строка  239082: 	public DefuseBombDrawer drrk { get; }
	Строка  239083: 	public DefusePlantedBombDrawer drrl { get; }
	Строка  239090: 	public DefuseBombDrawer bcad() { }
	Строка  239093: 	public DefusePlantedBombDrawer bcae() { }
	Строка  239117: 	private int _bombPlantPoints; // 0x1C
	Строка  239119: 	private int _bombExplodesPoints; // 0x20
	Строка  239121: 	private int _defusingBombPoints; // 0x24
	Строка  239213: 	private hsa _bombHasBeenPlantedRef; // 0x38
	Строка  239215: 	private hsa _bombHasBeenDefusedRef; // 0x48
	Строка  239217: 	private hsa _plantingTheBombRef; // 0x58
	Строка  239219: 	private hsa _defusingTheBombRef; // 0x68
	Строка  239225: 	private hsa _bombDroppedRef; // 0x98
	Строка  239227: 	private hsa _bombPickupRef; // 0xA8
	Строка  239331: public class DefuseBombDrawer : csc, csb // TypeDefIndex: 6128
	Строка  239335: 	private Sprite _bombSprite; // 0x10
	Строка  239382: public class DefusePlantedBombDrawer : csa // TypeDefIndex: 6129
	Строка  239386: 	private Sprite _bombSprite; // 0x10
	Строка  239429: 	public const cuv PlantingBomb = 1;
	Строка  239430: 	public const cuv DefusingBomb = 2;
	Строка  255806: 	public const ddz BombDrop = 1;
	Строка  255807: 	public const ddz BombPickup = 2;
	Строка  256136: 	private WeaponSlotView _bombSlotView; // 0x50
	Строка  256466: 	[KeyBindableAction(19, cexf = False, cexd = "Take Weapon/Defuse Bomb/Spawn Dummy/Control Bot")]
	Строка  256480: 	[KeyBindableAction(45, cexe = True, cexd = "Switch to Bomb")]
	Строка  256481: 	public const KeyboardGameAction SwitchToBomb = 17;
	Строка  261387: 	public const dgt BombSiteA = 1;
	Строка  261388: 	public const dgt BombSiteB = 2;
	Строка  261502: 	private static dgt bexv(Vector3 a, BombSite[] b, float c) { }
	Строка  261538: 	private float _bombSiteFlagRadius; // 0x48
	Строка  263288: 	public const dhs BombPlantA = 12;
	Строка  263289: 	public const dhs BombPlantB = 13;
	Строка  263290: 	public const dhs DroppedBombPos = 14;
	Строка  263291: 	public const dhs PlantedBombPos = 15;
	Строка  263429: 	public const dhw DefendPlantedBomb = 4;
	Строка  263432: 	public const dhw GetOnBomberSite = 7;
	Строка  263433: 	public const dhw TakeDroppedBomb = 8;
	Строка  263434: 	public const dhw DefusePlantedBomb = 9;
	Строка  263435: 	public const dhw PlantBomb = 10;
	Строка  263437: 	public const dhw GuardDroppedBomb = 12;
	Строка  267586: 	private BombManager crop; // 0x1C0
	Строка  268027: 	public const dkf FollowBomber = 1;
	Строка  268030: 	public const dkf DefendBombPlant = 4;
	Строка  268031: 	public const dkf GuardDroppedBomb = 5;
	Строка  268184: 	private float _hearBombPlantRadius; // 0x48
	Строка  268186: 	private float _hearBombPlantRadiusHigh; // 0x4C
	Строка  268188: 	private dii _hearBombPlantMinDifficulty; // 0x50
	Строка  268481: 	private Vector3 bgez(BombSite a) { }
	Строка  270563: 	public const dma PlantBomb = 5;
	Строка  270564: 	public const dma DefuseBomb = 6;
	Строка  270567: 	public const dma FleeFromBomb = 9;
	Строка  272482: 	private BombParameters csni; // 0x68
	Строка  272632: 	public BombParameters bhdc() { }
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
	Строка 1187809: 	public const hui Sticker_DropTheBomb = 1136;
	Строка 1189176: 	public const hui Charm_Bomb = 5329;
	Строка 1189607: 	public const hui USP_Stickerbomb = 161200;
	Строка 1189608: 	public const hui Tec9_Stickerbomb = 161600;
	Строка 1189609: 	public const hui MP7_Stickerbomb = 163400;
	Строка 1189610: 	public const hui AWM_Stickerbomb = 165100;
	Строка 1189611: 	public const hui M40_Stickerbomb = 165200;
	Строка 1189612: 	public const hui M110_Stickerbomb = 165300;
	Строка 1190919: 	public const huk Bomb = 100;
	Строка 1249583: 	public char bomb() { }
	Строка    5544: 	private int DecodeLastBlock(Stream outStream, char c1, char c2, char c3, char c4) { }
	Строка   73738: 	private static readonly ulong[] C4; // 0x28
