Строка    8423: 	protected virtual byte[] GetNewConnectionID() { }
	Строка    8537: 	private readonly int m_connectionEnd; // 0x18
	Строка    8568: 	private static TlsNonceGenerator CreateNonceGenerator(TlsCrypto crypto, int connectionEnd) { }
	Строка    8571: 	internal void .ctor(TlsCrypto crypto, int connectionEnd) { }
	Строка    8860: 	public virtual void NotifyConnectionClosed() { }
	Строка    8974: 	protected virtual byte[] GetNewConnectionID() { }
	Строка    9025: 	public virtual void GetServerExtensionsForConnection(IDictionary<int, byte[]> serverExtensions) { }
	Строка   10337: public abstract class ConnectionEnd // TypeDefIndex: 191
	Строка   11007: 	private bool m_inConnection; // 0x50
	Строка   11461: 	public const DtlsRecordFlags UsesConnectionID = 2;
	Строка   11669: 	public const int connection_id = 54;
	Строка   11761: 	public const short request_connection_id = 9;
	Строка   11762: 	public const short new_connection_id = 10;
	Строка   13025: 	internal byte[] m_connectionIDLocal; // 0x150
	Строка   13026: 	internal byte[] m_connectionIDPeer; // 0x158
	Строка   13040: 	public byte[] ConnectionIDLocal { get; }
	Строка   13041: 	public byte[] ConnectionIDPeer { get; }
	Строка   13121: 	public byte[] get_ConnectionIDLocal() { }
	Строка   13124: 	public byte[] get_ConnectionIDPeer() { }
	Строка   14832: 	public static void AddConnectionIDExtension(IDictionary<int, byte[]> extensions, byte[] connectionID) { }
	Строка   14959: 	public static byte[] GetConnectionIDExtension(IDictionary<int, byte[]> extensions) { }
	Строка   15086: 	public static byte[] CreateConnectionIDExtension(byte[] connectionID) { }
	Строка   15209: 	public static byte[] ReadConnectionIDExtension(byte[] extensionData) { }
	Строка   15687: 	protected short m_connectionState; // 0x98
	Строка   15713: 	protected bool IsLegacyConnectionState() { }
	Строка   15716: 	protected bool IsTlsV13ConnectionState() { }
	Строка   15731: 	protected virtual void CloseConnection() { }
	Строка   15954: 	internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection) { }
	Строка   16221: 	public abstract void GetServerExtensionsForConnection(IDictionary<int, byte[]> serverExtensions);
	Строка   17738: 	internal static void NotifyConnectionClosed(TlsPeer tlsPeer) { }
	Строка   19231: 	protected readonly byte[] m_decryptConnectionID; // 0x48
	Строка   19232: 	protected readonly byte[] m_encryptConnectionID; // 0x50
	Строка   19280: 	protected virtual byte[] GetAdditionalData(long seqNo, short recordType, ProtocolVersion recordVersion, int ciphertextLength, int plaintextLength, byte[] connectionID) { }
	Строка   19333: 	protected readonly byte[] m_decryptConnectionID; // 0x48
	Строка   19334: 	protected readonly byte[] m_encryptConnectionID; // 0x50
	Строка   19453: 	protected readonly byte[] m_decryptConnectionID; // 0x28
	Строка   19454: 	protected readonly byte[] m_encryptConnectionID; // 0x30
	Строка   19526: 	public virtual byte[] CalculateMac(long seqNo, short type, byte[] connectionID, byte[] msg, int msgOff, int msgLen) { }
	Строка   19532: 	public virtual byte[] CalculateMacConstantTime(long seqNo, short type, byte[] connectionID, byte[] msg, int msgOff, int msgLen, int fullLength, byte[] dummyData) { }
	Строка   19538: 	protected virtual int GetHeaderLength(byte[] connectionID) { }
	Строка  125167: 	public const string caua = "Auth/ConnectionError";
	Строка  125487: 	public const string cbcw = "Common/ServerConnectionFailed";
	Строка  125704: 	public const string cbil = "Dialogs/CheckInternetConnection";
	Строка  125705: 	public const string cbim = "Dialogs/ConnectionFailed";
	Строка  125706: 	public const string cbin = "Dialogs/ConnectionHasBeenLost";
	Строка  125737: 	public const string cbjg = "DLC/ConnectionFailed";
	Строка  126083: 	public const string cbsw = "GameState/AwaitingRivalTeamReconnection";
	Строка  127125: 	public const string ccus = "RankedMatchmakingError/MatchmakingServerConnectionFailed";
	Строка  128258: 	public const string cdut = "StandChillow_JoinRoomDialog_NoInternetConnection";
	Строка  195093: 	private void vlb(ConnectionFailedException a) { }
	Строка  199267: 	private static string vym(ConnectionFailedException a) { }
	Строка  217549: public class ConnectionIssueView : View // TypeDefIndex: 5611
	Строка  273406: 	private const string csqu = "OnLanLobbyHostReceivedConnection";
	Строка  273455: 	public static void OnLanLobbyHostReceivedConnection() { }
	Строка  274209: 	public const Interop.NtDll.CreateOptions FILE_CREATE_TREE_CONNECTION = 128;
	Строка  278487: 	|-Action<Connection>..ctor
	Строка  278885: 	|-Action<Connection>.Invoke
	Строка  280180: 	|-Func<Connection, bool>..ctor
	Строка  281262: 	|-Func<Connection, bool>.Invoke
	Строка  282283: 	|-Comparison<Connection>..ctor
	Строка  282650: 	|-Comparison<Connection>.Invoke
	Строка  283002: 	|-Predicate<Connection>..ctor
	Строка  283387: 	|-Predicate<Connection>.Invoke
	Строка  306510: 	|-ThrowHelper.IfNullAndNullsAreIllegalThenThrow<Connection>
	Строка  307590: 	|-Array.InternalEnumerator<Connection>..ctor
	Строка  307971: 	|-Array.InternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  308742: 	|-Array.InternalEnumerator<Connection>.Dispose
	Строка  309123: 	|-Array.InternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Dispose
	Строка  309894: 	|-Array.InternalEnumerator<Connection>.MoveNext
	Строка  310275: 	|-Array.InternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.MoveNext
	Строка  310567: 	|-Array.InternalEnumerator<Connection>.get_Current
	Строка  311279: 	|-Array.InternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Current
	Строка  312316: 	|-Array.InternalEnumerator<Connection>.System.Collections.IEnumerator.Reset
	Строка  312697: 	|-Array.InternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerator.Reset
	Строка  312989: 	|-Array.InternalEnumerator<Connection>.System.Collections.IEnumerator.get_Current
	Строка  313700: 	|-Array.InternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerator.get_Current
	Строка  314753: 	|-Array.EmptyInternalEnumerator<Connection>.Dispose
	Строка  315134: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Dispose
	Строка  315905: 	|-Array.EmptyInternalEnumerator<Connection>.MoveNext
	Строка  316286: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.MoveNext
	Строка  316986: 	|-Array.EmptyInternalEnumerator<Connection>.get_Current
	Строка  317292: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Current
	Строка  317757: 	|-Array.EmptyInternalEnumerator<Connection>.System.Collections.IEnumerator.get_Current
	Строка  318631: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerator.get_Current
	Строка  319421: 	|-Array.EmptyInternalEnumerator<Connection>.System.Collections.IEnumerator.Reset
	Строка  319802: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerator.Reset
	Строка  320573: 	|-Array.EmptyInternalEnumerator<Connection>..ctor
	Строка  320954: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  321725: 	|-Array.EmptyInternalEnumerator<Connection>..cctor
	Строка  322105: 	|-Array.EmptyInternalEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..cctor
	Строка  322904: 	|-Array.BinarySearch<Connection>
	Строка  323804: 	|-Array.IndexOf<Connection>
	Строка  324648: 	|-Array.Reverse<Connection>
	Строка  325250: 	|-Array.Sort<Connection>
	Строка  326707: 	|-Array.InternalArray__IEnumerable_GetEnumerator<Connection>
	Строка  327088: 	|-Array.InternalArray__IEnumerable_GetEnumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  327862: 	|-Array.InternalArray__ICollection_Add<Connection>
	Строка  328243: 	|-Array.InternalArray__ICollection_Add<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  329014: 	|-Array.InternalArray__ICollection_Remove<Connection>
	Строка  329395: 	|-Array.InternalArray__ICollection_Remove<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  330186: 	|-Array.InternalArray__ICollection_Contains<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  330934: 	|-Array.InternalArray__ICollection_Contains<Connection>
	Строка  331978: 	|-Array.InternalArray__ICollection_CopyTo<Connection>
	Строка  332359: 	|-Array.InternalArray__ICollection_CopyTo<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  332651: 	|-Array.InternalArray__IReadOnlyList_get_Item<Connection>
	Строка  333363: 	|-Array.InternalArray__IReadOnlyList_get_Item<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  334403: 	|-Array.InternalArray__Insert<Connection>
	Строка  334784: 	|-Array.InternalArray__Insert<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  335587: 	|-Array.InternalArray__IndexOf<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  336324: 	|-Array.InternalArray__IndexOf<Connection>
	Строка  336889: 	|-Array.InternalArray__get_Item<Connection>
	Строка  337601: 	|-Array.InternalArray__get_Item<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  338159: 	|-Array.InternalArray__set_Item<Connection>
	Строка  338870: 	|-Array.InternalArray__set_Item<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  339724: 	|-Array.IndexOfImpl<Connection>
	Строка  392122: 	|-AsyncVoidMethodBuilder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>
	Строка  392567: 	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, FtpWebRequest.<CreateConnectionAsync>d__86>
	Строка  393058: 	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	Строка  393061: 	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	Строка  393355: 	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	Строка  393650: 	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	Строка  393651: 	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	Строка  393940: 	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	Строка  393994: 	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	Строка  394180: 	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	Строка  394517: 	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	Строка  394555: 	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	Строка  394586: 	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	Строка  394673: 	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	Строка  394790: 	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	Строка  394828: 	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	Строка  395120: 	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	Строка  395121: 	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	Строка  398649: 	|-RuntimeHelpers.IsReferenceOrContainsReferences<Connection>
	Строка  399048: 	|-Unsafe.Add<Connection>
	Строка  399441: 	|-Unsafe.As<byte, Connection>
	Строка  399921: 	|-Unsafe.IsAddressLessThan<Connection>
	Строка  418203: 	|-ReadOnlyCollection<Connection>..ctor
	Строка  418488: 	|-ReadOnlyCollection<Connection>.get_Count
	Строка  418833: 	|-ReadOnlyCollection<Connection>.get_Item
	Строка  419148: 	|-ReadOnlyCollection<Connection>.Contains
	Строка  419455: 	|-ReadOnlyCollection<Connection>.CopyTo
	Строка  419740: 	|-ReadOnlyCollection<Connection>.GetEnumerator
	Строка  420067: 	|-ReadOnlyCollection<Connection>.IndexOf
	Строка  420374: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	Строка  420719: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.get_Item
	Строка  420992: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.set_Item
	Строка  421277: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.Add
	Строка  421562: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.Clear
	Строка  421847: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.Insert
	Строка  422132: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.ICollection<T>.Remove
	Строка  422417: 	|-ReadOnlyCollection<Connection>.System.Collections.Generic.IList<T>.RemoveAt
	Строка  422848: 	|-ReadOnlyCollection<Connection>.System.Collections.IEnumerable.GetEnumerator
	Строка  423541: 	|-ReadOnlyCollection<Connection>.System.Collections.ICollection.get_IsSynchronized
	Строка  423972: 	|-ReadOnlyCollection<Connection>.System.Collections.ICollection.get_SyncRoot
	Строка  424811: 	|-ReadOnlyCollection<Connection>.System.Collections.ICollection.CopyTo
	Строка  425504: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.get_IsFixedSize
	Строка  425789: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.get_IsReadOnly
	Строка  426120: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.get_Item
	Строка  426417: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.set_Item
	Строка  426702: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.Add
	Строка  426987: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.Clear
	Строка  427272: 	|-ReadOnlyCollection<Connection>.IsCompatibleObject
	Строка  427603: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.Contains
	Строка  427956: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.IndexOf
	Строка  428267: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.Insert
	Строка  428552: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.Remove
	Строка  428837: 	|-ReadOnlyCollection<Connection>.System.Collections.IList.RemoveAt
	Строка  458902: 	|-List.Enumerator<Connection>..ctor
	Строка  459189: 	|-List.Enumerator<Connection>.Dispose
	Строка  459478: 	|-List.Enumerator<Connection>.MoveNext
	Строка  459899: 	|-List.Enumerator<Connection>.MoveNextRare
	Строка  460231: 	|-List.Enumerator<Connection>.get_Current
	Строка  460571: 	|-List.Enumerator<Connection>.System.Collections.IEnumerator.get_Current
	Строка  460916: 	|-List.Enumerator<Connection>.System.Collections.IEnumerator.Reset
	Строка  461232: 	|-List<Connection>..ctor
	Строка  461515: 	|-List<Connection>..ctor
	Строка  461944: 	|-List<Connection>..ctor
	Строка  462631: 	|-List<Connection>.get_Capacity
	Строка  462914: 	|-List<Connection>.set_Capacity
	Строка  463197: 	|-List<Connection>.get_Count
	Строка  463480: 	|-List<Connection>.System.Collections.IList.get_IsFixedSize
	Строка  463763: 	|-List<Connection>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	Строка  464046: 	|-List<Connection>.System.Collections.IList.get_IsReadOnly
	Строка  464329: 	|-List<Connection>.System.Collections.ICollection.get_IsSynchronized
	Строка  464758: 	|-List<Connection>.System.Collections.ICollection.get_SyncRoot
	Строка  465492: 	|-List<Connection>.get_Item
	Строка  465787: 	|-List<Connection>.set_Item
	Строка  466171: 	|-List<Connection>.IsCompatibleObject
	Строка  466502: 	|-List<Connection>.System.Collections.IList.get_Item
	Строка  466804: 	|-List<Connection>.System.Collections.IList.set_Item
	Строка  467185: 	|-List<Connection>.Add
	Строка  467582: 	|-List<Connection>.AddWithResize
	Строка  467979: 	|-List<Connection>.System.Collections.IList.Add
	Строка  468519: 	|-List<Connection>.AddRange
	Строка  469206: 	|-List<Connection>.AsReadOnly
	Строка  469637: 	|-List<Connection>.BinarySearch
	Строка  470470: 	|-List<Connection>.BinarySearch
	Строка  471303: 	|-List<Connection>.BinarySearch
	Строка  471957: 	|-List<Connection>.Clear
	Строка  472423: 	|-List<Connection>.Contains
	Строка  473256: 	|-List<Connection>.System.Collections.IList.Contains
	Строка  473943: 	|-List<Connection>.CopyTo
	Строка  474228: 	|-List<Connection>.System.Collections.ICollection.CopyTo
	Строка  474511: 	|-List<Connection>.CopyTo
	Строка  474794: 	|-List<Connection>.CopyTo
	Строка  475076: 	|-List<Connection>.EnsureCapacity
	Строка  475409: 	|-List<Connection>.Exists
	Строка  475750: 	|-List<Connection>.Find
	Строка  476049: 	|-List<Connection>.FindAll
	Строка  476488: 	|-List<Connection>.FindIndex
	Строка  476829: 	|-List<Connection>.FindIndex
	Строка  477170: 	|-List<Connection>.ForEach
	Строка  477514: 	|-List<Connection>.GetEnumerator
	Строка  477849: 	|-List<Connection>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	Строка  478184: 	|-List<Connection>.System.Collections.IEnumerable.GetEnumerator
	Строка  478471: 	|-List<Connection>.GetRange
	Строка  478902: 	|-List<Connection>.IndexOf
	Строка  479735: 	|-List<Connection>.System.Collections.IList.IndexOf
	Строка  480568: 	|-List<Connection>.IndexOf
	Строка  481258: 	|-List<Connection>.Insert
	Строка  481655: 	|-List<Connection>.System.Collections.IList.Insert
	Строка  482197: 	|-List<Connection>.InsertRange
	Строка  483030: 	|-List<Connection>.Remove
	Строка  483863: 	|-List<Connection>.System.Collections.IList.Remove
	Строка  484555: 	|-List<Connection>.RemoveAll
	Строка  485042: 	|-List<Connection>.RemoveAt
	Строка  485241: 	|-List<Connection>.RemoveRange
	Строка  485566: 	|-List<Connection>.Reverse
	Строка  485949: 	|-List<Connection>.Reverse
	Строка  486473: 	|-List<Connection>.Sort
	Строка  487306: 	|-List<Connection>.Sort
	Строка  488139: 	|-List<Connection>.Sort
	Строка  488829: 	|-List<Connection>.Sort
	Строка  489213: 	|-List<Connection>.ToArray
	Строка  489495: 	|-List<Connection>.TrimExcess
	Строка  489828: 	|-List<Connection>.TrueForAll
	Строка  490270: 	|-List<Connection>.AddEnumerable
	Строка  490957: 	|-List<Connection>..cctor
	Строка  494239: 	|-ArraySortHelper<Connection>.Sort
	Строка  495075: 	|-ArraySortHelper<Connection>.BinarySearch
	Строка  495768: 	|-ArraySortHelper<Connection>.Sort
	Строка  496191: 	|-ArraySortHelper<Connection>.InternalBinarySearch
	Строка  496510: 	|-ArraySortHelper<Connection>.SwapIfGreater
	Строка  496894: 	|-ArraySortHelper<Connection>.Swap
	Строка  497276: 	|-ArraySortHelper<Connection>.IntrospectiveSort
	Строка  497664: 	|-ArraySortHelper<Connection>.IntroSort
	Строка  498052: 	|-ArraySortHelper<Connection>.PickPivotAndPartition
	Строка  498440: 	|-ArraySortHelper<Connection>.Heapsort
	Строка  498828: 	|-ArraySortHelper<Connection>.DownHeap
	Строка  499216: 	|-ArraySortHelper<Connection>.InsertionSort
	Строка  499601: 	|-ArraySortHelper<Connection>.get_Default
	Строка  499885: 	|-ArraySortHelper<Connection>..ctor
	Строка  500169: 	|-ArraySortHelper<Connection>..cctor
	Строка  501230: 	|-Comparer<Connection>.get_Default
	Строка  502420: 	|-Comparer<Connection>.CreateComparer
	Строка  503218: 	|-Comparer<Connection>.System.Collections.IComparer.Compare
	Строка  503746: 	|-Comparer<Connection>..ctor
	Строка  505519: 	|-ObjectComparer<Connection>.Compare
	Строка  506345: 	|-ObjectComparer<Connection>.Equals
	Строка  506747: 	|-ObjectComparer<Connection>.GetHashCode
	Строка  507149: 	|-ObjectComparer<Connection>..ctor
	Строка  508009: 	|-EqualityComparer<Connection>.get_Default
	Строка  509481: 	|-EqualityComparer<Connection>.CreateComparer
	Строка  510412: 	|-EqualityComparer<Connection>.IndexOf
	Строка  510996: 	|-EqualityComparer<Connection>.LastIndexOf
	Строка  511578: 	|-EqualityComparer<Connection>.System.Collections.IEqualityComparer.GetHashCode
	Строка  512158: 	|-EqualityComparer<Connection>.System.Collections.IEqualityComparer.Equals
	Строка  512895: 	|-EqualityComparer<Connection>..ctor
	Строка  517502: 	|-ObjectEqualityComparer<Connection>.Equals
	Строка  518508: 	|-ObjectEqualityComparer<Connection>.GetHashCode
	Строка  519526: 	|-ObjectEqualityComparer<Connection>.IndexOf
	Строка  520540: 	|-ObjectEqualityComparer<Connection>.LastIndexOf
	Строка  521042: 	|-ObjectEqualityComparer<Connection>.Equals
	Строка  521538: 	|-ObjectEqualityComparer<Connection>.GetHashCode
	Строка  522034: 	|-ObjectEqualityComparer<Connection>..ctor
	Строка  595330: private class RemoteInputPlayerConnection.Subscriber : IDisposable // TypeDefIndex: 10068
	Строка  595333: 	public RemoteInputPlayerConnection owner; // 0x10
	Строка  595347: internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message> // TypeDefIndex: 10069
	Строка  595358: 	private IEditorPlayerConnection m_Connection; // 0x18
	Строка  595359: 	private RemoteInputPlayerConnection.Subscriber[] m_Subscribers; // 0x20
	Строка  595366: 	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }
	Строка  629608: 	private Hashtable connections; // 0x10
	Строка  629636: 	internal int nonCachedConnectionsCount; // 0x10
	Строка  649655: 	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	Строка  649777: 	public override bool SupportsConnectionInfo { get; }
	Строка  649796: 	public override bool get_SupportsConnectionInfo() { }
	Строка  651016: 	public WebConnectionTunnel tunnel; // 0x28
	Строка  651071: 	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }
	Строка  651387: 	private MonoTlsConnectionInfo connectionInfo; // 0x98
	Строка  651433: 	private void InitializeConnection() { }
	Строка  651741: 	public override bool SupportsConnectionInfo { get; }
	Строка  651763: 	public override bool get_SupportsConnectionInfo() { }
	Строка  672520: 	public const CommandStream.PipelineEntryFlags CreateDataConnection = 4;
	Строка  672690: 	internal CommandStream Connection; // 0x28
	Строка  672695: 	internal void .ctor(CommandStream connection) { }
	Строка  673072: 	public const FtpWebRequest.RequestStage ReleaseConnection = 4;
	Строка  673077: private struct FtpWebRequest.<CreateConnectionAsync>d__86 : IAsyncStateMachine // TypeDefIndex: 11809
	Строка  673143: 	private FtpControlStream _connection; // 0xB8
	Строка  673254: 	[AsyncStateMachine(typeof(FtpWebRequest.<CreateConnectionAsync>d__86))]
	Строка  673256: 	private void CreateConnectionAsync() { }
	Строка  673259: 	private FtpControlStream CreateConnection() { }
	Строка  673671: 	public const FtpStatusCode ConnectionClosed = 426;
	Строка  673799: 	public const HttpRequestHeader Connection = 1;
	Строка  674292: 	public const WebExceptionStatus ConnectionClosed = 8;
	Строка  675900: 	private string m_connectionGroupName; // 0x38
	Строка  676786: 	private Dictionary<HttpConnection, HttpConnection> unregistered; // 0x50
	Строка  676809: 	internal void RemoveConnection(HttpConnection conn) { }
	Строка  676928: private enum HttpConnection.InputState // TypeDefIndex: 11928
	Строка  676932: 	public const HttpConnection.InputState RequestLine = 0;
	Строка  676933: 	public const HttpConnection.InputState Headers = 1;
	Строка  676937: private enum HttpConnection.LineState // TypeDefIndex: 11929
	Строка  676941: 	public const HttpConnection.LineState None = 0;
	Строка  676942: 	public const HttpConnection.LineState CR = 1;
	Строка  676943: 	public const HttpConnection.LineState LF = 2;
	Строка  676947: internal sealed class HttpConnection // TypeDefIndex: 11930
	Строка  676973: 	private HttpConnection.InputState input_state; // 0xB0
	Строка  676974: 	private HttpConnection.LineState line_state; // 0xB4
	Строка  677022: 	private void RemoveConnection() { }
	Строка  677071: 	private Hashtable connections; // 0x70
	Строка  677152: 	internal void AddConnection(HttpConnection cnc) { }
	Строка  677155: 	internal void RemoveConnection(HttpConnection cnc) { }
	Строка  677177: 	private HttpConnection cnc; // 0x28
	Строка  677186: 	internal HttpConnection Connection { get; }
	Строка  677193: 	internal void .ctor(HttpConnection cnc) { }
	Строка  677211: 	internal HttpConnection get_Connection() { }
	Строка  677298: 	public bool IsSecureConnection { get; }
	Строка  677346: 	public bool get_IsSecureConnection() { }
	Строка  677764: 	private string connectionGroup; // 0x58
	Строка  677847: 	public bool UnsafeAuthenticatedConnectionSharing { get; }
	Строка  677973: 	public bool get_UnsafeAuthenticatedConnectionSharing() { }
	Строка  678721: 	private int connectionLeaseTimeout; // 0x60
	Строка  678727: 	private int connectionLimit; // 0x78
	Строка  678736: 	public int ConnectionLimit { get; }
	Строка  678749: 	internal void .ctor(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }
	Строка  678767: 	public int get_ConnectionLimit() { }
	Строка  678865: 	private static int defaultConnectionLimit; // 0x10
	Строка  678917: private class ServicePointScheduler.ConnectionGroup // TypeDefIndex: 11963
	Строка  678926: 	private LinkedList<WebConnection> connections; // 0x28
	Строка  678945: 	public void RemoveConnection(WebConnection connection) { }
	Строка  678957: 	public WebConnection FindIdleConnection(WebOperation operation) { }
	Строка  678960: 	public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force) { }
	Строка  679013: 	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2; // 0x28
	Строка  679014: 	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; // 0x30
	Строка  679062: 	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	Строка  679063: 	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	Строка  679064: 	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	Строка  679065: 	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	Строка  679066: 	private int currentConnections; // 0x48
	Строка  679067: 	private int connectionLimit; // 0x4C
	Строка  679090: 	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }
	Строка  679106: 	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation) { }
	Строка  679109: 	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }
	Строка  679112: 	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }
	Строка  679118: 	private void RemoveIdleConnection(WebConnection connection) { }
	Строка  679127: 	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }
	Строка  679130: 	private void OnConnectionCreated(WebConnection connection) { }
	Строка  679133: 	private void OnConnectionClosed(WebConnection connection) { }
	Строка  679457: private sealed class WebConnection.<>c // TypeDefIndex: 11975
	Строка  679460: 	public static readonly WebConnection.<>c <>9; // 0x0
	Строка  679481: private struct WebConnection.<Connect>d__16 : IAsyncStateMachine // TypeDefIndex: 11976
	Строка  679486: 	public WebConnection <>4__this; // 0x20
	Строка  679506: private struct WebConnection.<CreateStream>d__18 : IAsyncStateMachine // TypeDefIndex: 11977
	Строка  679511: 	public WebConnection <>4__this; // 0x20
	Строка  679531: private struct WebConnection.<InitConnection>d__19 : IAsyncStateMachine // TypeDefIndex: 11978
	Строка  679538: 	public WebConnection <>4__this; // 0x30
	Строка  679554: internal class WebConnection : IDisposable // TypeDefIndex: 11979
	Строка  679563: 	private WebConnectionTunnel tunnel; // 0x38
	Строка  679576: 	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }
	Строка  679593: 	[AsyncStateMachine(typeof(WebConnection.<Connect>d__16))]
	Строка  679597: 	[AsyncStateMachine(typeof(WebConnection.<CreateStream>d__18))]
	Строка  679601: 	[AsyncStateMachine(typeof(WebConnection.<InitConnection>d__19))]
	Строка  679603: 	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }
	Строка  679612: 	internal bool CanReuseConnection(WebOperation operation) { }
	Строка  679660: 	internal bool get_UnsafeAuthenticatedConnectionSharing() { }
	Строка  679663: 	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
	Строка  679667: internal abstract class WebConnectionStream : Stream // TypeDefIndex: 11980
	Строка  679678: 	private readonly WebConnection <Connection>k__BackingField; // 0x48
	Строка  679684: 	internal WebConnection Connection { get; }
	Строка  679697: 	protected void .ctor(WebConnection cnc, WebOperation operation) { }
	Строка  679705: 	internal WebConnection get_Connection() { }
	Строка  679788: private enum WebConnectionTunnel.NtlmAuthState // TypeDefIndex: 11981
	Строка  679792: 	public const WebConnectionTunnel.NtlmAuthState None = 0;
	Строка  679793: 	public const WebConnectionTunnel.NtlmAuthState Challenge = 1;
	Строка  679794: 	public const WebConnectionTunnel.NtlmAuthState Response = 2;
	Строка  679799: private struct WebConnectionTunnel.<Initialize>d__42 : IAsyncStateMachine // TypeDefIndex: 11982
	Строка  679804: 	public WebConnectionTunnel <>4__this; // 0x20
	Строка  679823: private struct WebConnectionTunnel.<ReadHeaders>d__43 : IAsyncStateMachine // TypeDefIndex: 11983
	Строка  679830: 	public WebConnectionTunnel <>4__this; // 0x30
	Строка  679848: internal class WebConnectionTunnel // TypeDefIndex: 11984
	Строка  679856: 	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	Строка  679860: 	private bool <CloseConnection>k__BackingField; // 0x2D
	Строка  679878: 	public bool CloseConnection { get; set; }
	Строка  679909: 	public bool get_CloseConnection() { }
	Строка  679913: 	private void set_CloseConnection(bool value) { }
	Строка  679959: 	[AsyncStateMachine(typeof(WebConnectionTunnel.<Initialize>d__42))]
	Строка  679963: 	[AsyncStateMachine(typeof(WebConnectionTunnel.<ReadHeaders>d__43))]
	Строка  680021: 	private WebConnection <Connection>k__BackingField; // 0x18
	Строка  680043: 	public WebConnection Connection { get; set; }
	Строка  680060: 	public WebConnection get_Connection() { }
	Строка  680064: 	private void set_Connection(WebConnection value) { }
	Строка  680125: 	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }
	Строка  680457: internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 11998
	Строка  680487: 	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }
	Строка  680694: internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 12004
	Строка  681786: 	public int ConnectionType; // 0xD0
	Строка  683455: 	public const SocketError ConnectionAborted = 10053;
	Строка  683456: 	public const SocketError ConnectionReset = 10054;
	Строка  683462: 	public const SocketError ConnectionRefused = 10061;
	Строка  683515: 	public const SocketOptionName AcceptConnection = 2;
	Строка  683534: 	public const SocketOptionName MaxConnections = 2147483647;
	Строка  684570: public sealed class ConnectionManagementElement : ConfigurationElement // TypeDefIndex: 12138
	Строка  684574: [ConfigurationCollection(typeof(ConnectionManagementElement))]
	Строка  684576: public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 12139
	Строка  684585: public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 12140
	Строка  687092: 	public Color _ConnectionLowLerp; // 0x40
	Строка  687093: 	public Color _ConnectionHighLerp; // 0x50
	Строка  687099: 	public static Color ConnectionLowLerp; // 0x30
	Строка  687100: 	public static Color ConnectionHighLerp; // 0x40
	Строка  689703: 	public static void GetContours(GridGraph grid, Action<Vector3[]> callback, float yMergeThreshold, GridNodeBase[] nodes, Func<GraphNode, GraphNode, bool> connectionFilter) { }
	Строка  689797: 	private static void GetHierarchicalNodesInRangeRec(int hierarchicalNode, Bounds bounds, SlabAllocator<int> connectionAllocator, NativeList<int> connectionAllocations, NativeList<Bounds> nodeBounds, NativeList<int> indices) { }
	Строка  689987: 	public bool deleteConnection; // 0x4D
	Строка  690196: 	private void RemoveConnections(GraphNode node) { }
	Строка  690374: 	internal bool staleConnections; // 0x7C
	Строка  690744: public struct Connection // TypeDefIndex: 12301
	Строка  690751: 	public const byte IncomingConnection = 16;
	Строка  690752: 	public const byte OutgoingConnection = 32;
	Строка  690803: public sealed class GraphNode.GetConnectionsWithData<T> : MulticastDelegate // TypeDefIndex: 12302
	Строка  690812: 	|-GraphNode.GetConnectionsWithData<bool>..ctor
	Строка  690813: 	|-GraphNode.GetConnectionsWithData<object>..ctor
	Строка  690814: 	|-GraphNode.GetConnectionsWithData<__Il2CppFullySharedGenericType>..ctor
	Строка  690815: 	|-GraphNode.GetConnectionsWithData<HierarchicalGraph.JobRecalculateComponents.Context>..ctor
	Строка  690823: 	|-GraphNode.GetConnectionsWithData<bool>.Invoke
	Строка  690824: 	|-GraphNode.GetConnectionsWithData<object>.Invoke
	Строка  690825: 	|-GraphNode.GetConnectionsWithData<__Il2CppFullySharedGenericType>.Invoke
	Строка  690826: 	|-GraphNode.GetConnectionsWithData<HierarchicalGraph.JobRecalculateComponents.Context>.Invoke
	Строка  690834: 	|-GraphNode.GetConnectionsWithData<bool>.BeginInvoke
	Строка  690837: 	|-GraphNode.GetConnectionsWithData<object>.BeginInvoke
	Строка  690840: 	|-GraphNode.GetConnectionsWithData<__Il2CppFullySharedGenericType>.BeginInvoke
	Строка  690843: 	|-GraphNode.GetConnectionsWithData<HierarchicalGraph.JobRecalculateComponents.Context>.BeginInvoke
	Строка  690851: 	|-GraphNode.GetConnectionsWithData<bool>.EndInvoke
	Строка  690852: 	|-GraphNode.GetConnectionsWithData<object>.EndInvoke
	Строка  690853: 	|-GraphNode.GetConnectionsWithData<__Il2CppFullySharedGenericType>.EndInvoke
	Строка  690854: 	|-GraphNode.GetConnectionsWithData<HierarchicalGraph.JobRecalculateComponents.Context>.EndInvoke
	Строка  690865: 	public static GraphNode.GetConnectionsWithData<Action<GraphNode>> <>9__63_0; // 0x8
	Строка  690876: 	internal void <GetConnections>b__63_0(GraphNode node, ref Action<GraphNode> action) { }
	Строка  690892: 	internal void <ContainsOutgoingConnection>b__0(GraphNode neighbour, ref bool contains) { }
	Строка  691030: 	public virtual void GetConnections(Action<GraphNode> action, int connectionFilter = 32) { }
	Строка  691033: 	public abstract void GetConnections<T>(GraphNode.GetConnectionsWithData<T> action, ref T data, int connectionFilter = 32);
	Строка  691037: 	|-GraphNode.GetConnections<__Il2CppFullySharedGenericType>
	Строка  691038: 	|-GraphNode.GetConnections<bool>
	Строка  691039: 	|-GraphNode.GetConnections<HierarchicalGraph.JobRecalculateComponents.Context>
	Строка  691048: 	[Obsolete("Use the static Connect method instead, or AddPartialConnection if you really need to")]
	Строка  691050: 	public void AddConnection(GraphNode node, uint cost) { }
	Строка  691052: 	[Obsolete("Use the static Disconnect method instead, or RemovePartialConnection if you really need to")]
	Строка  691054: 	public void RemoveConnection(GraphNode node) { }
	Строка  691057: 	public abstract void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming);
	Строка  691060: 	public abstract void RemovePartialConnection(GraphNode node);
	Строка  691063: 	public abstract void ClearConnections(bool alsoReverse = True);
	Строка  691065: 	[Obsolete("Use ContainsOutgoingConnection instead")]
	Строка  691067: 	public bool ContainsConnection(GraphNode node) { }
	Строка  691070: 	public virtual bool ContainsOutgoingConnection(GraphNode node) { }
	Строка  691129: 	public Connection[] connections; // 0x28
	Строка  691143: 	public override void ClearConnections(bool alsoReverse = True) { }
	Строка  691146: 	public override void GetConnections<T>(GraphNode.GetConnectionsWithData<T> action, ref T data, int connectionFilter = 32) { }
	Строка  691150: 	|-MeshNode.GetConnections<bool>
	Строка  691151: 	|-MeshNode.GetConnections<object>
	Строка  691152: 	|-MeshNode.GetConnections<HierarchicalGraph.JobRecalculateComponents.Context>
	Строка  691155: 	|-MeshNode.GetConnections<__Il2CppFullySharedGenericType>
	Строка  691159: 	public override bool ContainsOutgoingConnection(GraphNode node) { }
	Строка  691162: 	public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming) { }
	Строка  691165: 	public void AddPartialConnection(GraphNode node, uint cost, byte shapeEdgeInfo) { }
	Строка  691168: 	public override void RemovePartialConnection(GraphNode node) { }
	Строка  691552: 	public SlabAllocator<int> connectionAllocator; // 0x0
	Строка  691554: 	public NativeList<int> connectionAllocations; // 0x8
	Строка  691565: 	public List<int> connections; // 0x10
	Строка  691577: 	public static GraphNode.GetConnectionsWithData<HierarchicalGraph.JobRecalculateComponents.Context> <>9__12_0; // 0x8
	Строка  691596: 	public NativeList<int> connectionAllocations; // 0x8
	Строка  691614: 	private void CheckConnectionInvariants() { }
	Строка  691643: 	internal NativeList<int> connectionAllocations; // 0x20
	Строка  691644: 	internal SlabAllocator<int> connectionAllocator; // 0x30
	Строка  691656: 	private List<int> currentConnections; // 0xA0
	Строка  691734: 	public virtual bool filterDiagonalGridConnections { get; }
	Строка  691739: 	public virtual bool get_filterDiagonalGridConnections() { }
	Строка  691817: public sealed class Path.OpenCandidateConnectionBurst_000004FA$PostfixBurstDelegate : MulticastDelegate // TypeDefIndex: 12326
	Строка  691835: internal static class Path.OpenCandidateConnectionBurst_000004FA$BurstDirectCall // TypeDefIndex: 12327
	Строка  691895: 	public static readonly ProfilerMarker MarkerOpenCandidateConnectionsToEnd; // 0x8
	Строка  691992: 	public void OpenCandidateConnectionsToEndNode(Int3 position, uint parentPathNode, uint parentNodeIndex, uint parentG) { }
	Строка  691995: 	public void OpenCandidateConnection(uint parentPathNode, uint targetPathNode, uint parentG, uint connectionCost, uint fractionAlongEdge, Int3 targetNodePosition) { }
	Строка  691999: 	public static void OpenCandidateConnectionBurst(ref Path.OpenCandidateParams pars, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective) { }
	Строка  692132: 	public static void OpenCandidateConnectionBurst$BurstManaged(ref Path.OpenCandidateParams pars, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective) { }
	Строка  692980: 	public bool showNodeConnections; // 0xE1
	Строка  692995: 	internal const int HexagonConnectionMask = 175;
	Строка  693118: 	public uint GetConnectionCost(int dir) { }
	Строка  693163: 	public void RecalculateAllConnections() { }
	Строка  693166: 	public void RecalculateConnectionsInRegion(IntRect recalculateRect) { }
	Строка  693169: 	public void CalculateConnectionsForCellAndNeighbours(int x, int z) { }
	Строка  693171: 	[Obsolete("This method is very slow since 4.3.80. Use RecalculateConnectionsInRegion or RecalculateAllConnections instead to batch connection recalculations.")]
	Строка  693173: 	public virtual void CalculateConnections(GridNodeBase node) { }
	Строка  693175: 	[Obsolete("This method is very slow since 4.3.80. Use RecalculateConnectionsInRegion instead to batch connection recalculations.")]
	Строка  693177: 	public virtual void CalculateConnections(int x, int z) { }
	Строка  693480: 	public override void RemovePartialConnection(GraphNode node) { }
	Строка  693846: 	public static Func<TriangleMeshNode, Connection[]> <>9__93_2; // 0x28
	Строка  693869: 	internal Connection[] <PostDeserialization>b__93_2(TriangleMeshNode n) { }
	Строка  693893: 	public Dictionary<TriangleMeshNode, Connection[]> conns; // 0x10
	Строка  693910: 	public Func<Connection, bool> <>9__4; // 0x18
	Строка  693918: 	internal bool <PostDeserialization>b__4(Connection conn) { }
	Строка  693934: 	public bool showNodeConnections; // 0x5D
	Строка  693960: 	public abstract float MaxTileConnectionEdgeDistance { get; }
	Строка  693977: 	public abstract float get_MaxTileConnectionEdgeDistance();
	Строка  694073: 	protected static void CreateNodeConnections(TriangleMeshNode[] nodes, bool keepExistingConnections) { }
	Строка  694076: 	internal static void ConnectTiles(NavmeshTile tile1, NavmeshTile tile2, float tileWorldSizeX, float tileWorldSizeZ, float maxTileConnectionEdgeDistance) { }
	Строка  694192: 	private NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe> <tileNodeConnections>5__7; // 0xA8
	Строка  694298: 	public override float MaxTileConnectionEdgeDistance { get; }
	Строка  694316: 	public override float get_MaxTileConnectionEdgeDistance() { }
	Строка  694348: 	private const int GridFlagsConnectionOffset = 0;
	Строка  694349: 	private const int GridFlagsConnectionBit0 = 1;
	Строка  694350: 	private const int GridFlagsConnectionMask = 255;
	Строка  694351: 	private const int GridFlagsAxisAlignedConnectionMask = 15;
	Строка  694357: 	public override bool HasConnectionsToAllEightNeighbours { get; }
	Строка  694358: 	public override bool HasConnectionsToAllAxisAlignedNeighbours { get; }
	Строка  694359: 	public override bool HasAnyGridConnections { get; }
	Строка  694386: 	public override bool get_HasConnectionsToAllEightNeighbours() { }
	Строка  694389: 	public override bool get_HasConnectionsToAllAxisAlignedNeighbours() { }
	Строка  694392: 	public override bool HasConnectionInDirection(int dir) { }
	Строка  694395: 	public void SetConnection(int dir, bool value) { }
	Строка  694398: 	public void SetConnectionInternal(int dir, bool value) { }
	Строка  694401: 	public void SetAllConnectionInternal(int connections) { }
	Строка  694404: 	public int GetAllConnectionInternal() { }
	Строка  694407: 	public override bool get_HasAnyGridConnections() { }
	Строка  694410: 	public override void ResetConnectionsInternal() { }
	Строка  694422: 	public override void ClearConnections(bool alsoReverse) { }
	Строка  694425: 	public override void GetConnections<T>(GraphNode.GetConnectionsWithData<T> action, ref T data, int connectionFilter) { }
	Строка  694429: 	|-GridNode.GetConnections<bool>
	Строка  694430: 	|-GridNode.GetConnections<object>
	Строка  694431: 	|-GridNode.GetConnections<HierarchicalGraph.JobRecalculateComponents.Context>
	Строка  694434: 	|-GridNode.GetConnections<__Il2CppFullySharedGenericType>
	Строка  694441: 	public static int FilterDiagonalConnections(int conns, NumNeighbours neighbours, bool cutCorners) { }
	Строка  694453: 	public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming) { }
	Строка  694456: 	public override void RemovePartialConnection(GraphNode node) { }
	Строка  694459: 	protected void RemoveGridConnection(GridNode node) { }
	Строка  694477: 	public Connection[] connections; // 0x30
	Строка  694487: 	public abstract bool HasConnectionsToAllEightNeighbours { get; }
	Строка  694488: 	public abstract bool HasConnectionsToAllAxisAlignedNeighbours { get; }
	Строка  694489: 	public abstract bool HasAnyGridConnections { get; }
	Строка  694521: 	public abstract bool get_HasConnectionsToAllEightNeighbours();
	Строка  694524: 	public abstract bool get_HasConnectionsToAllAxisAlignedNeighbours();
	Строка  694527: 	public static int OppositeConnectionDirection(int dir) { }
	Строка  694530: 	public static int OffsetToConnectionDirection(int dx, int dz) { }
	Строка  694563: 	public virtual bool HasConnectionInDirection(int direction) { }
	Строка  694566: 	public abstract bool get_HasAnyGridConnections();
	Строка  694569: 	public override bool ContainsOutgoingConnection(GraphNode node) { }
	Строка  694572: 	public abstract void ResetConnectionsInternal();
	Строка  694581: 	public void ClearCustomConnections(bool alsoReverse) { }
	Строка  694584: 	public override void ClearConnections(bool alsoReverse) { }
	Строка  694587: 	public override void GetConnections<T>(GraphNode.GetConnectionsWithData<T> action, ref T data, int connectionFilter) { }
	Строка  694591: 	|-GridNodeBase.GetConnections<bool>
	Строка  694592: 	|-GridNodeBase.GetConnections<object>
	Строка  694593: 	|-GridNodeBase.GetConnections<HierarchicalGraph.JobRecalculateComponents.Context>
	Строка  694596: 	|-GridNodeBase.GetConnections<__Il2CppFullySharedGenericType>
	Строка  694600: 	public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming) { }
	Строка  694603: 	public override void RemovePartialConnection(GraphNode node) { }
	Строка  694623: 	public uint gridConnections; // 0x38
	Строка  694626: 	public const int ConnectionMask = 15;
	Строка  694627: 	public const int ConnectionStride = 4;
	Строка  694628: 	public const int AxisAlignedConnectionsMask = 65535;
	Строка  694629: 	public const uint AllConnectionsMask = 4294967295;
	Строка  694630: 	public const int NoConnection = 15;
	Строка  694631: 	internal const ulong DiagonalConnectionsMask = 4294901760;
	Строка  694635: 	public override bool HasAnyGridConnections { get; }
	Строка  694636: 	public override bool HasConnectionsToAllEightNeighbours { get; }
	Строка  694637: 	public override bool HasConnectionsToAllAxisAlignedNeighbours { get; }
	Строка  694658: 	public override void ResetConnectionsInternal() { }
	Строка  694661: 	public override bool get_HasAnyGridConnections() { }
	Строка  694664: 	public override bool get_HasConnectionsToAllEightNeighbours() { }
	Строка  694667: 	public override bool get_HasConnectionsToAllAxisAlignedNeighbours() { }
	Строка  694685: 	public override void ClearConnections(bool alsoReverse) { }
	Строка  694688: 	public override void GetConnections<T>(GraphNode.GetConnectionsWithData<T> action, ref T data, int connectionFilter) { }
	Строка  694692: 	|-LevelGridNode.GetConnections<bool>
	Строка  694693: 	|-LevelGridNode.GetConnections<object>
	Строка  694694: 	|-LevelGridNode.GetConnections<HierarchicalGraph.JobRecalculateComponents.Context>
	Строка  694697: 	|-LevelGridNode.GetConnections<__Il2CppFullySharedGenericType>
	Строка  694701: 	public override bool HasConnectionInDirection(int direction) { }
	Строка  694704: 	public void SetConnectionValue(int dir, int value) { }
	Строка  694707: 	public void SetAllConnectionInternal(ulong value) { }
	Строка  694710: 	public int GetConnectionValue(int dir) { }
	Строка  694713: 	public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming) { }
	Строка  694716: 	public override void RemovePartialConnection(GraphNode node) { }
	Строка  694719: 	protected void RemoveGridConnection(LevelGridNode node) { }
	Строка  694741: 	public Connection[] connections; // 0x28
	Строка  694766: 	public override void GetConnections<T>(GraphNode.GetConnectionsWithData<T> action, ref T data, int connectionFilter) { }
	Строка  694770: 	|-PointNode.GetConnections<bool>
	Строка  694771: 	|-PointNode.GetConnections<object>
	Строка  694772: 	|-PointNode.GetConnections<HierarchicalGraph.JobRecalculateComponents.Context>
	Строка  694775: 	|-PointNode.GetConnections<__Il2CppFullySharedGenericType>
	Строка  694779: 	public override void ClearConnections(bool alsoReverse) { }
	Строка  694782: 	public override bool ContainsOutgoingConnection(GraphNode node) { }
	Строка  694785: 	public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming) { }
	Строка  694788: 	public override void RemovePartialConnection(GraphNode node) { }
	Строка  695236: 	public GraphNode GetNearestConnection(Int3 point, NNConstraint constraint, long maximumSqrConnectionLength) { }
	Строка  695239: 	private void GetNearestConnectionInternal(int index, Int3 point, NNConstraint constraint, ref GraphNode best, ref long bestSqrDist, long distanceThresholdOffset) { }
	Строка  695257: 	public const PointGraph.NodeDistanceMode Connection = 1;
	Строка  695360: 	private List<Connection> <connections>5__2; // 0x78
	Строка  695361: 	private List<GraphNode> <candidateConnections>5__3; // 0x80
	Строка  695432: 	private long maximumConnectionLength; // 0x90
	Строка  695466: 	private NNInfo FindClosestConnectionPoint(PointNode node, Vector3 position, float maxDistanceSqr) { }
	Строка  695498: 	public void RebuildConnectionDistanceLookup() { }
	Строка  695501: 	private static long LongestConnectionLength(PointNode[] nodes, int nodeCount) { }
	Строка  695504: 	public void RegisterConnectionLength(long sqrLength) { }
	Строка  695523: 	public virtual bool IsValidConnection(GraphNode a, GraphNode b, out float dist) { }
	Строка  695917: 	public override float MaxTileConnectionEdgeDistance { get; }
	Строка  695986: 	public override float get_MaxTileConnectionEdgeDistance() { }
	Строка  696829: 	public const StartEndModifier.Exactness NodeConnection = 4;
	Строка  696844: 	private List<GraphNode> connectionBuffer; // 0x40
	Строка  696845: 	private Action<GraphNode> connectionBufferAddDelegate; // 0x48
	Строка  696859: 	private Vector3 Snap(ABPath path, StartEndModifier.Exactness mode, bool start, out bool forceAddPoint, out int closestConnectionIndex) { }
	Строка  697720: 	public bool filterDiagonalGridConnections { get; }
	Строка  697745: 	public bool get_filterDiagonalGridConnections() { }
	Строка  698393: 	public static GraphNode.GetConnectionsWithData<List<GraphNode>> <>9__69_0; // 0x8
	Строка  698574: 	private static readonly List<GraphNode>[] TempConnectionLists; // 0x20
	Строка  698718: 	private void GetTempQueue(out PathTracer.QueueItem[] queue, out List<GraphNode> connections) { }
	Строка  699659: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobCalculateGridConnections>..ctor
	Строка  699660: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobFilterDiagonalConnections>..ctor
	Строка  699683: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobCalculateGridConnections>.Invoke
	Строка  699684: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobFilterDiagonalConnections>.Invoke
	Строка  699725: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobCalculateGridConnections>.BeginInvoke
	Строка  699728: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobFilterDiagonalConnections>.BeginInvoke
	Строка  699763: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobCalculateGridConnections>.EndInvoke
	Строка  699764: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct.ExecuteJobFunction<JobFilterDiagonalConnections>.EndInvoke
	Строка  699814: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct<JobCalculateGridConnections>.Initialize
	Строка  699817: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct<JobFilterDiagonalConnections>.Initialize
	Строка  699870: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct<JobCalculateGridConnections>.Execute
	Строка  699873: 	|-JobParallelForBatchedExtensions.ParallelForBatchJobStruct<JobFilterDiagonalConnections>.Execute
	Строка  699934: 	|-JobParallelForBatchedExtensions.ScheduleBatch<JobCalculateGridConnections>
	Строка  699937: 	|-JobParallelForBatchedExtensions.ScheduleBatch<JobFilterDiagonalConnections>
	Строка  699964: 	|-JobParallelForBatchedExtensions.RunBatch<JobCalculateGridConnections>
	Строка  699967: 	|-JobParallelForBatchedExtensions.RunBatch<JobFilterDiagonalConnections>
	Строка  700027: 	|-DisposeArena.Add<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  700709: 	|-IJobExtensions.ScheduleBatch<JobCalculateGridConnections>
	Строка  700712: 	|-IJobExtensions.ScheduleBatch<JobFilterDiagonalConnections>
	Строка  700819: 	|-JobDependencyAnalyzer.ReflectionData<JobCalculateGridConnections>.Build
	Строка  700834: 	|-JobDependencyAnalyzer.ReflectionData<JobFilterDiagonalConnections>.Build
	Строка  700920: 	|-JobDependencyAnalyzer.ReflectionData<JobCalculateGridConnections>.Build
	Строка  700935: 	|-JobDependencyAnalyzer.ReflectionData<JobFilterDiagonalConnections>.Build
	Строка  701032: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>.initReflectionData
	Строка  701047: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>.initReflectionData
	Строка  701117: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>.HasHash
	Строка  701122: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>.HasHash
	Строка  701172: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>.GetDependencies
	Строка  701187: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>.GetDependencies
	Строка  701273: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>.GetDependencies
	Строка  701288: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>.GetDependencies
	Строка  701374: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>.GetDependencies
	Строка  701389: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>.GetDependencies
	Строка  701475: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>.Scheduled
	Строка  701490: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>.Scheduled
	Строка  701576: 	|-JobDependencyAnalyzer<JobCalculateGridConnections>..cctor
	Строка  701591: 	|-JobDependencyAnalyzer<JobFilterDiagonalConnections>..cctor
	Строка  703032: 	public void SetConnection(int dir, uint value) { }
	Строка  703035: 	public int GetConnection(int dir) { }
	Строка  703310: internal struct JobBuildConnections : IJob // TypeDefIndex: 12620
	Строка  703487: 	public float maxTileConnectionEdgeDistance; // 0xC
	Строка  703594: 	private static readonly ProfilerMarker MarkerBuildConnections; // 0x20
	Строка  703620: public struct JobCalculateTriangleConnections.TileNodeConnectionsUnsafe // TypeDefIndex: 12634
	Строка  703629: public struct JobCalculateTriangleConnections : IJob // TypeDefIndex: 12635
	Строка  703635: 	public NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe> nodeConnections; // 0x10
	Строка  703654: 	public float maxTileConnectionEdgeDistance; // 0x30
	Строка  703660: 	public static JobHandle ScheduleBatch(GCHandle tilesHandle, JobHandle dependency, IntRect tileRect, Vector2 tileWorldSize, float maxTileConnectionEdgeDistance) { }
	Строка  703663: 	public static JobHandle ScheduleRecalculateBorders(GCHandle tilesHandle, JobHandle dependency, IntRect tileRect, IntRect innerRect, Vector2 tileWorldSize, float maxTileConnectionEdgeDistance) { }
	Строка  703680: 	public float maxTileConnectionEdgeDistance; // 0x18
	Строка  703740: public struct JobWriteNodeConnections : IJob // TypeDefIndex: 12641
	Строка  703744: 	public NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe> nodeConnections; // 0x0
	Строка  703753: 	private void Apply(TriangleMeshNode[] nodes, JobCalculateTriangleConnections.TileNodeConnectionsUnsafe connections) { }
	Строка  703847: 	public abstract int GetNeighbourIndex(int nodeIndexXZ, int nodeIndex, int direction, NativeArray<ulong> nodeConnections, NativeArray<int> neighbourOffsets, int layerStride);
	Строка  703850: 	public abstract bool HasConnection(int nodeIndex, int direction, NativeArray<ulong> nodeConnections);
	Строка  703862: 	public int GetNeighbourIndex(int nodeIndexXZ, int nodeIndex, int direction, NativeArray<ulong> nodeConnections, NativeArray<int> neighbourOffsets, int layerStride) { }
	Строка  703865: 	public bool HasConnection(int nodeIndex, int direction, NativeArray<ulong> nodeConnections) { }
	Строка  703877: 	public int GetNeighbourIndex(int nodeIndexXZ, int nodeIndex, int direction, NativeArray<ulong> nodeConnections, NativeArray<int> neighbourOffsets, int layerStride) { }
	Строка  703880: 	public bool HasConnection(int nodeIndex, int direction, NativeArray<ulong> nodeConnections) { }
	Строка  703905: 	public NativeArray<ulong> connections; // 0x30
	Строка  703940: 	public void ReadFromNodesForConnectionCalculations(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, JobDependencyTracker dependencyTracker) { }
	Строка  703979: 	[Obsolete("Use nodes.connections instead")]
	Строка  703980: 	public NativeArray<ulong> nodeConnections { get; }
	Строка  704004: 	public NativeArray<ulong> get_nodeConnections() { }
	Строка  704040: 	public void Connections(float maxStepHeight, bool maxStepUsesSlope, IntBounds calculationBounds, NumNeighbours neighbours, bool cutCorners, bool use2D, bool useErodedWalkability, float characterHeight) { }
	Строка  704046: 	public void AssignNodeConnections(GridNodeBase[] nodes, int3 nodeArrayBounds, IntBounds writeBounds) { }
	Строка  704086: public interface GridIterationUtilities.IConnectionFilter // TypeDefIndex: 12655
	Строка  704091: 	public abstract bool IsValidConnection(int dataIndex, int dataX, int dataLayer, int dataZ, int direction, int neighbourDataIndex);
	Строка  704153: 	public static void FilterNodeConnections<T>(IntBounds bounds, NativeArray<ulong> nodeConnections, bool layeredDataLayout, ref T filter) { }
	Строка  704157: 	|-GridIterationUtilities.FilterNodeConnections<__Il2CppFullySharedGenericStructType>
	Строка  704161: 	public static Nullable<int> GetNeighbourDataIndex(IntBounds bounds, NativeArray<ulong> nodeConnections, bool layeredDataLayout, int dataX, int dataLayer, int dataZ, int direction) { }
	Строка  704301: 	public const GridGraphRule.Pass BeforeConnections = 1;
	Строка  704302: 	public const GridGraphRule.Pass AfterConnections = 2;
	Строка  704640: public struct JobCalculateGridConnections : IJobParallelForBatched // TypeDefIndex: 12679
	Строка  704660: 	public UnsafeSpan<ulong> nodeConnections; // 0xA8
	Строка  704671: 	public static bool IsValidConnection(float y, float y2, float maxStepHeight) { }
	Строка  704674: 	public static bool IsValidConnection(float2 yRange, float2 yRange2, float maxStepHeight, float characterHeight) { }
	Строка  704677: 	private static float ConnectionY(UnsafeSpan<float3> nodePositions, UnsafeSpan<float4> nodeNormals, NativeArray<float4> normalToHeightOffset, int nodeIndex, int dir, float4 up, bool reverse) { }
	Строка  704680: 	private static float2 ConnectionYRange(UnsafeSpan<float3> nodePositions, UnsafeSpan<float4> nodeNormals, NativeArray<float4> normalToHeightOffset, int nodeIndex, int layerStride, int y, int maxY, int dir, float4 up, bool reverse) { }
	Строка  704761: 	public NativeArray<ulong> nodeConnections; // 0x0
	Строка  704803: public struct JobFilterDiagonalConnections : IJobParallelForBatched // TypeDefIndex: 12684
	Строка  704809: 	public UnsafeSpan<ulong> nodeConnections; // 0x30
	Строка  704976: 	public NativeArray<ulong> nodeConnections; // 0x38
	Строка  705000: 	public NativeArray<ulong> nodeConnections; // 0x60
	Строка  705053: 	public NativeArray<ulong> nodeConnections; // 0x78
	Строка  705533: 	public void SerializeConnections(Connection[] connections, bool serializeMetadata) { }
	Строка  705536: 	public Connection[] DeserializeConnections(bool deserializeMetadata) { }
	Строка  706066: 	|-ArrayPool<Connection>.Claim
	Строка  706087: 	|-ArrayPool<Connection>.ClaimWithExactLength
	Строка  706112: 	|-ArrayPool<Connection>.Release
	Строка  706149: 	|-ArrayPool<Connection>..cctor
	Строка  706174: 	|-ListExtensions.ToArrayFromPool<Connection>
	Строка  706209: 	|-ListExtensions.ClearFast<Connection>
	Строка  706244: 	|-ListPool<Connection>.Claim
	Строка  706276: 	|-ListPool<Connection>.FindCandidate
	Строка  706308: 	|-ListPool<Connection>.Claim
	Строка  706353: 	|-ListPool<Connection>.Warmup
	Строка  706387: 	|-ListPool<Connection>.Release
	Строка  706421: 	|-ListPool<Connection>.Release
	Строка  706442: 	|-ListPool<Connection>.Clear
	Строка  706474: 	|-ListPool<Connection>.GetSize
	Строка  706506: 	|-ListPool<Connection>..cctor
	Строка  712617: 	private Vector3 drawConnectionStart; // 0x50
	Строка  712618: 	private Color drawConnectionColor; // 0x5C
	Строка  712619: 	private readonly Action<GraphNode> drawConnection; // 0x70
	Строка  712651: 	public void DrawConnections(GraphNode node) { }
	Строка  712654: 	private void DrawConnection(GraphNode other) { }
	Строка  861280: 	|-IJobExtensions.JobStruct.ExecuteJobFunction<JobBuildConnections>..ctor
	Строка  861287: 	|-IJobExtensions.JobStruct.ExecuteJobFunction<JobCalculateTriangleConnections>..ctor
	Строка  861311: 	|-IJobExtensions.JobStruct.ExecuteJobFunction<JobWriteNodeConnections>..ctor
	Строка  861380: 	|-IJobExtensions.JobStruct.ExecuteJobFunction<JobBuildConnections>.Invoke
	Строка  861387: 	|-IJobExtensions.JobStruct.ExecuteJobFunction<JobCalculateTriangleConnections>.Invoke
	Строка  861411: 	|-IJobExtensions.JobStruct.ExecuteJobFunction<JobWriteNodeConnections>.Invoke
	Строка  861544: 	|-IJobExtensions.JobStruct<JobBuildConnections>.Initialize
	Строка  861565: 	|-IJobExtensions.JobStruct<JobCalculateTriangleConnections>.Initialize
	Строка  861637: 	|-IJobExtensions.JobStruct<JobWriteNodeConnections>.Initialize
	Строка  861822: 	|-IJobExtensions.JobStruct<JobBuildConnections>.Execute
	Строка  861843: 	|-IJobExtensions.JobStruct<JobCalculateTriangleConnections>.Execute
	Строка  861915: 	|-IJobExtensions.JobStruct<JobWriteNodeConnections>.Execute
	Строка  862042: 	|-IJobExtensions.JobStruct<JobBuildConnections>..cctor
	Строка  862049: 	|-IJobExtensions.JobStruct<JobCalculateTriangleConnections>..cctor
	Строка  862073: 	|-IJobExtensions.JobStruct<JobWriteNodeConnections>..cctor
	Строка  862205: 	|-IJobExtensions.EarlyJobInit<JobBuildConnections>
	Строка  862226: 	|-IJobExtensions.EarlyJobInit<JobCalculateTriangleConnections>
	Строка  862298: 	|-IJobExtensions.EarlyJobInit<JobWriteNodeConnections>
	Строка  862474: 	|-IJobExtensions.GetReflectionData<JobCalculateTriangleConnections>
	Строка  862525: 	|-IJobExtensions.GetReflectionData<JobWriteNodeConnections>
	Строка  862684: 	|-IJobExtensions.Schedule<JobCalculateTriangleConnections>
	Строка  862732: 	|-IJobExtensions.Schedule<JobWriteNodeConnections>
	Строка  864262: 	|-NativeArray.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  864429: 	|-NativeArray.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Dispose
	Строка  864520: 	|-NativeArray.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.MoveNext
	Строка  864690: 	|-NativeArray.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Reset
	Строка  864783: 	|-NativeArray.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Current
	Строка  864948: 	|-NativeArray.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerator.get_Current
	Строка  865132: 	|-NativeArray.ReadOnly.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  865299: 	|-NativeArray.ReadOnly.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Dispose
	Строка  865390: 	|-NativeArray.ReadOnly.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.MoveNext
	Строка  865560: 	|-NativeArray.ReadOnly.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Reset
	Строка  865653: 	|-NativeArray.ReadOnly.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Current
	Строка  865818: 	|-NativeArray.ReadOnly.Enumerator<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerator.get_Current
	Строка  866012: 	|-NativeArray.ReadOnly<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  866111: 	|-NativeArray.ReadOnly<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Length
	Строка  866214: 	|-NativeArray.ReadOnly<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Item
	Строка  866355: 	|-NativeArray.ReadOnly<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.GetEnumerator
	Строка  866516: 	|-NativeArray.ReadOnly<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	Строка  866677: 	|-NativeArray.ReadOnly<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerable.GetEnumerator
	Строка  866862: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  867023: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  867184: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>..ctor
	Строка  867345: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Allocate
	Строка  867512: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Length
	Строка  867615: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_Item
	Строка  867767: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.set_Item
	Строка  867914: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.get_IsCreated
	Строка  868013: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Dispose
	Строка  868279: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Dispose
	Строка  868404: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.CopyFrom
	Строка  868552: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.CopyFrom
	Строка  868699: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.CopyTo
	Строка  868846: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.ToArray
	Строка  868980: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.GetEnumerator
	Строка  869141: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	Строка  869302: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.System.Collections.IEnumerable.GetEnumerator
	Строка  869469: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Equals
	Строка  869567: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Equals
	Строка  869669: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.GetHashCode
	Строка  869767: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.op_Equality
	Строка  869876: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Copy
	Строка  870023: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Copy
	Строка  870170: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Copy
	Строка  870317: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Copy
	Строка  870464: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Copy
	Строка  870611: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.CopySafe
	Строка  870758: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.CopySafe
	Строка  870905: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.CopySafe
	Строка  870986: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.InternalReinterpret<byte>
	Строка  871040: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.Reinterpret<byte>
	Строка  871158: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.GetSubArray
	Строка  871298: 	|-NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>.AsReadOnly
	Строка  872140: 	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobExtensions.JobStruct<JobBuildConnections>>
	Строка  872147: 	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobExtensions.JobStruct<JobCalculateTriangleConnections>>
	Строка  872171: 	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobExtensions.JobStruct<JobWriteNodeConnections>>
	Строка  872322: 	|-BurstRuntime.HashCode64<IJobExtensions.JobStruct<JobBuildConnections>>..cctor
	Строка  872343: 	|-BurstRuntime.HashCode64<IJobExtensions.JobStruct<JobCalculateTriangleConnections>>..cctor
	Строка  872415: 	|-BurstRuntime.HashCode64<IJobExtensions.JobStruct<JobWriteNodeConnections>>..cctor
	Строка  872564: 	|-BurstRuntime.GetHashCode64<IJobExtensions.JobStruct<JobBuildConnections>>
	Строка  872571: 	|-BurstRuntime.GetHashCode64<IJobExtensions.JobStruct<JobCalculateTriangleConnections>>
	Строка  872595: 	|-BurstRuntime.GetHashCode64<IJobExtensions.JobStruct<JobWriteNodeConnections>>
	Строка  872853: 	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  873278: 	|-UnsafeUtility.AlignOf<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  873596: 	|-UnsafeUtility.ReadArrayElement<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  873795: 	|-UnsafeUtility.WriteArrayElement<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  873989: 	|-UnsafeUtility.AddressOf<JobCalculateGridConnections>
	Строка  873990: 	|-UnsafeUtility.AddressOf<JobCalculateTriangleConnections>
	Строка  873998: 	|-UnsafeUtility.AddressOf<JobFilterDiagonalConnections>
	Строка  874012: 	|-UnsafeUtility.AddressOf<JobWriteNodeConnections>
	Строка  874300: 	|-UnsafeUtility.SizeOf<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>
	Строка  874310: 	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe>>
	Строка  884260: internal interface IPlayerEditorConnectionNative // TypeDefIndex: 15191
	Строка  884290: [NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
	Строка  884291: internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 15192
	Строка  884296: 	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }
	Строка  884299: 	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }
	Строка  884302: 	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }
	Строка  884305: 	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }
	Строка  884308: 	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }
	Строка  884311: 	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }
	Строка  884314: 	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }
	Строка  884317: 	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }
	Строка  884319: 	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	Строка  884323: 	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	Строка  884327: 	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	Строка  884331: 	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	Строка  884335: 	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	Строка  884339: 	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	Строка  884343: 	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	Строка  884347: 	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	Строка  891572: public struct EarlyUpdate.PollPlayerConnection // TypeDefIndex: 15419
	Строка  891577: public struct EarlyUpdate.PollHtcsPlayerConnection // TypeDefIndex: 15420
	Строка  892551: // Namespace: UnityEngine.Networking.PlayerConnection
	Строка  892565: // Namespace: UnityEngine.Networking.PlayerConnection
	Строка  892566: public interface IEditorPlayerConnection // TypeDefIndex: 15556
	Строка  892574: 	public abstract void RegisterConnection(UnityAction<int> callback);
	Строка  892577: 	public abstract void RegisterDisconnection(UnityAction<int> callback);
	Строка  892585: private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 15557
	Строка  892596: 	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
	Строка  892601: private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 15558
	Строка  892612: 	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
	Строка  892617: private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 15559
	Строка  892631: // Namespace: UnityEngine.Networking.PlayerConnection
	Строка  892633: public class PlayerConnection : ScriptableObject, IEditorPlayerConnection // TypeDefIndex: 15560
	Строка  892636: 	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	Строка  892638: 	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	Строка  892642: 	private static PlayerConnection s_Instance; // 0x8
	Строка  892645: 	public static PlayerConnection instance { get; }
	Строка  892651: 	public static PlayerConnection get_instance() { }
	Строка  892657: 	private static PlayerConnection CreateInstance() { }
	Строка  892663: 	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }
	Строка  892672: 	public void RegisterConnection(UnityAction<int> callback) { }
	Строка  892675: 	public void RegisterDisconnection(UnityAction<int> callback) { }
	Строка  892678: 	public void UnregisterConnection(UnityAction<int> callback) { }
	Строка  892681: 	public void UnregisterDisconnection(UnityAction<int> callback) { }
	Строка  892713: public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 15561
	Строка  892723: public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 15562
	Строка  892733: public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 15563
	Строка  892739: 	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20
	Строка  892758: private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass6_0 // TypeDefIndex: 15564
	Строка  892769: 	internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
	Строка  892774: private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass7_0 // TypeDefIndex: 15565
	Строка  892785: 	internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
	Строка  892790: private sealed class PlayerEditorConnectionEvents.<>c__DisplayClass8_0 // TypeDefIndex: 15566
	Строка  892801: 	internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
	Строка  892804: // Namespace: UnityEngine.Networking.PlayerConnection
	Строка  892806: internal class PlayerEditorConnectionEvents // TypeDefIndex: 15567
	Строка  892810: 	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	Строка  892812: 	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	Строка  892814: 	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20
	Строка  991252: 	|-Enumerable.Iterator<Connection>..ctor
	Строка  991321: 	|-Enumerable.Iterator<Connection>.get_Current
	Строка  991430: 	|-Enumerable.Iterator<Connection>.Dispose
	Строка  991526: 	|-Enumerable.Iterator<Connection>.GetEnumerator
	Строка  991618: 	|-Enumerable.Iterator<Connection>.System.Collections.IEnumerator.get_Current
	Строка  991722: 	|-Enumerable.Iterator<Connection>.System.Collections.IEnumerable.GetEnumerator
	Строка  991792: 	|-Enumerable.Iterator<Connection>.System.Collections.IEnumerator.Reset
	Строка  991869: 	|-Enumerable.WhereEnumerableIterator<Connection>..ctor
	Строка  991925: 	|-Enumerable.WhereEnumerableIterator<Connection>.Clone
	Строка  992011: 	|-Enumerable.WhereEnumerableIterator<Connection>.Dispose
	Строка  992133: 	|-Enumerable.WhereEnumerableIterator<Connection>.MoveNext
	Строка  992318: 	|-Enumerable.WhereEnumerableIterator<Connection>.Where
	Строка  992394: 	|-Enumerable.WhereArrayIterator<Connection>..ctor
	Строка  992429: 	|-Enumerable.WhereArrayIterator<Connection>.Clone
	Строка  992461: 	|-Enumerable.WhereArrayIterator<Connection>.MoveNext
	Строка  992553: 	|-Enumerable.WhereArrayIterator<Connection>.Where
	Строка  992612: 	|-Enumerable.WhereListIterator<Connection>..ctor
	Строка  992647: 	|-Enumerable.WhereListIterator<Connection>.Clone
	Строка  992679: 	|-Enumerable.WhereListIterator<Connection>.MoveNext
	Строка  992771: 	|-Enumerable.WhereListIterator<Connection>.Where
	Строка 1004269: 	|-Enumerable.<>c__DisplayClass6_0<Connection>..ctor
	Строка 1004315: 	|-Enumerable.<>c__DisplayClass6_0<Connection>.<CombinePredicates>b__0
	Строка 1008038: 	|-Enumerable.Where<Connection>
	Строка 1008275: 	|-Enumerable.CombinePredicates<Connection>
	Строка 1009947: 	|-Enumerable.ToList<Connection>
	Строка 1127519: 	private void OnConnectionFailedEvent() { }
	Строка 1156216: 	public const hiu ERR_DSP_CONNECTION = 5;
	Строка 1156741: 	public const hjt DSPCONNECTION = 8;
	Строка 1156796: 	public const hjx BADDSPCONNECTION = 16;
	Строка 1159441: 	private static extern hiu FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection) { }
	Строка 1159930: 	private static extern hiu FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, hks type) { }
	Строка 1159933: 	private static extern hiu FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection) { }
	Строка 1159945: 	private static extern hiu FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection) { }
	Строка 1159948: 	private static extern hiu FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection) { }
	Строка 1160098: 	private static extern hiu FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input) { }
	Строка 1160101: 	private static extern hiu FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output) { }
	Строка 1160104: 	private static extern hiu FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume) { }
	Строка 1160107: 	private static extern hiu FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume) { }
	Строка 1160110: 	private static extern hiu FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop) { }
	Строка 1160113: 	private static extern hiu FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop) { }
	Строка 1160116: 	private static extern hiu FMOD5_DSPConnection_GetType(IntPtr dspconnection, out hks type) { }
	Строка 1160119: 	private static extern hiu FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata) { }
	Строка 1160122: 	private static extern hiu FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata) { }
	Строка 1201996: public class MonoTlsConnectionInfo // TypeDefIndex: 21019
	Строка 1202084: 	public abstract bool SupportsConnectionInfo { get; }
	Строка 1202104: 	public abstract bool get_SupportsConnectionInfo();
	Строка 1220890: internal enum ConnectionRequestResult // TypeDefIndex: 21475
	Строка 1220894: 	public const ConnectionRequestResult None = 0;
	Строка 1220895: 	public const ConnectionRequestResult Accept = 1;
	Строка 1220896: 	public const ConnectionRequestResult Reject = 2;
	Строка 1220897: 	public const ConnectionRequestResult RejectForce = 3;
	Строка 1220901: public class LiteConnectionRequest // TypeDefIndex: 21476
	Строка 1220907: 	private ConnectionRequestResult <Result>k__BackingField; // 0x1C
	Строка 1220913: 	internal ConnectionRequestResult Result { get; set; }
	Строка 1220922: 	internal ConnectionRequestResult get_Result() { }
	Строка 1220926: 	private void set_Result(ConnectionRequestResult value) { }
	Строка 1220972: public class ConnectionRequest : LiteConnectionRequest // TypeDefIndex: 21477
	Строка 1221000: 	public const DisconnectReason ConnectionFailed = 0;
	Строка 1221004: 	public const DisconnectReason RemoteConnectionClose = 4;
	Строка 1221006: 	public const DisconnectReason ConnectionRejected = 6;
	Строка 1221010: 	public const DisconnectReason PeerToPeerConnection = 10;
	Строка 1221047: 	public abstract void OnConnectionRequest(ConnectionRequest request);
	Строка 1221083: 	public abstract void OnConnectionRequest(LiteConnectionRequest request);
	Строка 1221201: public sealed class EventBasedNetListener.OnConnectionRequest : MulticastDelegate // TypeDefIndex: 21489
	Строка 1221209: 	public virtual void Invoke(ConnectionRequest request) { }
	Строка 1221212: 	public virtual IAsyncResult BeginInvoke(ConnectionRequest request, AsyncCallback callback, object object) { }
	Строка 1221289: 	private EventBasedNetListener.OnConnectionRequest ConnectionRequestEvent; // 0x40
	Строка 1221349: 	public void add_ConnectionRequestEvent(EventBasedNetListener.OnConnectionRequest value) { }
	Строка 1221353: 	public void remove_ConnectionRequestEvent(EventBasedNetListener.OnConnectionRequest value) { }
	Строка 1221398: 	public void ClearConnectionRequestEvent() { }
	Строка 1221428: 	private void LiteNetLib.INetEventListener.OnConnectionRequest(ConnectionRequest request) { }
	Строка 1221552: public sealed class EventBasedLiteNetListener.OnConnectionRequest : MulticastDelegate // TypeDefIndex: 21500
	Строка 1221560: 	public virtual void Invoke(LiteConnectionRequest request) { }
	Строка 1221563: 	public virtual IAsyncResult BeginInvoke(LiteConnectionRequest request, AsyncCallback callback, object object) { }
	Строка 1221622: 	private EventBasedLiteNetListener.OnConnectionRequest ConnectionRequestEvent; // 0x40
	Строка 1221680: 	public void add_ConnectionRequestEvent(EventBasedLiteNetListener.OnConnectionRequest value) { }
	Строка 1221684: 	public void remove_ConnectionRequestEvent(EventBasedLiteNetListener.OnConnectionRequest value) { }
	Строка 1221721: 	public void ClearConnectionRequestEvent() { }
	Строка 1221748: 	private void LiteNetLib.ILiteNetEventListener.OnConnectionRequest(LiteConnectionRequest request) { }
	Строка 1221765: 	public readonly long ConnectionTime; // 0x10
	Строка 1221766: 	public byte ConnectionNumber; // 0x18
	Строка 1221774: 	private void .ctor(long connectionTime, byte connectionNumber, int localId, byte[] targetAddress, NetDataReader data) { }
	Строка 1221791: 	public readonly long ConnectionTime; // 0x10
	Строка 1221792: 	public readonly byte ConnectionNumber; // 0x18
	Строка 1221799: 	private void .ctor(long connectionTime, byte connectionNumber, int peerId, bool peerNetworkChanged) { }
	Строка 1221905: 	private readonly Dictionary<IPEndPoint, LiteConnectionRequest> _requestsDict; // 0x50
	Строка 1222011: 	internal void ConnectionLatencyUpdated(LiteNetPeer fromPeer, int latency) { }
	Строка 1222023: 	private void CreateEvent(NetEvent.EType type, LiteNetPeer peer, IPEndPoint remoteEndPoint, SocketError errorCode = 0, int latency = 0, DisconnectReason disconnectReason = 0, LiteConnectionRequest connectionRequest, DeliveryMethod deliveryMethod = 4, byte channelNumber = 0, NetPacket readerSource, object userData) { }
	Строка 1222049: 	protected virtual LiteNetPeer CreateIncomingPeer(LiteConnectionRequest request, int id) { }
	Строка 1222055: 	protected virtual LiteConnectionRequest CreateConnectionRequest(IPEndPoint remoteEndPoint, NetConnectRequestPacket requestPacket) { }
	Строка 1222058: 	internal LiteNetPeer OnConnectionSolved(LiteConnectionRequest request, byte[] rejectData, int start, int length) { }
	Строка 1222158: 	public LiteNetPeer Connect(string address, int port, NetDataWriter connectionData) { }
	Строка 1222164: 	public LiteNetPeer Connect(IPEndPoint target, NetDataWriter connectionData) { }
	Строка 1222167: 	public LiteNetPeer Connect(IPEndPoint target, ReadOnlySpan<byte> connectionData) { }
	Строка 1222176: 	public int GetPeersCount(ConnectionState peerState) { }
	Строка 1222179: 	public void GetPeers(List<LiteNetPeer> peers, ConnectionState peerState) { }
	Строка 1222334: public enum ConnectionState // TypeDefIndex: 21510
	Строка 1222338: 	public const ConnectionState Outgoing = 2;
	Строка 1222339: 	public const ConnectionState Connected = 4;
	Строка 1222340: 	public const ConnectionState ShutdownRequested = 8;
	Строка 1222341: 	public const ConnectionState Disconnected = 16;
	Строка 1222342: 	public const ConnectionState EndPointChange = 32;
	Строка 1222343: 	public const ConnectionState Any = 46;
	Строка 1222353: 	public const ConnectRequestResult Reconnection = 2;
	Строка 1222354: 	public const ConnectRequestResult NewConnection = 3;
	Строка 1222444: 	private ConnectionState _connectionState; // 0xE1
	Строка 1222468: 	internal byte ConnectionNum { get; set; }
	Строка 1222469: 	public ConnectionState ConnectionState { get; }
	Строка 1222484: 	internal byte get_ConnectionNum() { }
	Строка 1222487: 	private void set_ConnectionNum(byte value) { }
	Строка 1222490: 	public ConnectionState get_ConnectionState() { }
	Строка 1222567: 	internal void .ctor(LiteNetManager netManager, LiteConnectionRequest request, int id) { }
	Строка 1223061: 	public const byte MaxConnectionNumber = 4;
	Строка 1223154: 	public const NetEvent.EType ConnectionLatencyUpdated = 5;
	Строка 1223156: 	public const NetEvent.EType ConnectionRequest = 7;
	Строка 1223173: 	public LiteConnectionRequest ConnectionRequest; // 0x48
	Строка 1223208: 	public void GetPeers(List<NetPeer> peers, ConnectionState peerState) { }
	Строка 1223232: 	protected override LiteNetPeer CreateIncomingPeer(LiteConnectionRequest request, int id) { }
	Строка 1223238: 	protected override LiteConnectionRequest CreateConnectionRequest(IPEndPoint remoteEndPoint, NetConnectRequestPacket requestPacket) { }
	Строка 1223274: 	public NetPeer Connect(string address, int port, NetDataWriter connectionData) { }
	Строка 1223280: 	public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData) { }
	Строка 1223283: 	public NetPeer Connect(IPEndPoint target, ReadOnlySpan<byte> connectionData) { }
	Строка 1223332: 	public byte ConnectionNumber { get; set; }
	Строка 1223353: 	public byte get_ConnectionNumber() { }
	Строка 1223356: 	public void set_ConnectionNumber(byte value) { }
	Строка 1223455: 	internal void .ctor(NetManager netManager, LiteConnectionRequest request, int id) { }
	Строка 1243040: 	private void OnLoopbackConnected(int connectionId) { }
	Строка 1243047: 	private void OnLoopbackDisconnected(int connectionId) { }
	Строка 1243054: 	public void OnConnectionRequest(ConnectionRequest request) { }
	Строка 1265309: 	public const fas ConnectionFailed = 1;
	Строка 1265414: public class ConnectionFailedException : Exception // TypeDefIndex: 22609
	Строка 1279210: 	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 38;
	Строка 1279212: 	public const UnityWebRequest.UnityWebRequestError InsecureConnectionNotAllowed = 40;
	Строка 1279222: 	public const UnityWebRequest.Result ConnectionError = 2;
	Строка 1288402: internal enum ConnectionChangeType // TypeDefIndex: 23302
	Строка 1288406: 	public const ConnectionChangeType Connected = 0;
	Строка 1288407: 	public const ConnectionChangeType Disconnected = 1;
	Строка 1288408: 	public const ConnectionChangeType ConfigChange = 2;
	Строка 1288637: 	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }
	Строка 1289563: 	public const GoogleSignInStatusCode CONNECTION_SUSPENDED_DURING_CALL = 20;
	Строка 1289564: 	public const GoogleSignInStatusCode RECONNECTION_TIMED_OUT_DURING_UPDATE = 21;
	Строка 1289565: 	public const GoogleSignInStatusCode RECONNECTION_TIMED_OUT = 22;
	Строка 1292722: 	protected virtual void OnConnectionFailedEvent() { }
	Строка 1300485: 	public void OnConnectionRequest(ConnectionRequest request) { }
	Строка 1300570: 	public void Start(IPEndPoint endPoint, int maxConnections) { }
	Строка 1300580: 	public void SendData(ArraySegment<byte> data, int targetConnectionID, hhc reliability) { }
	Строка 1300584: 	public void byeu(ArraySegment<byte> a, IEnumerable<int> targetConnectionIDs, hhc b) { }
	Строка 1300625: 	public void OnConnectionRequest(ConnectionRequest request) { }
	Строка 1301735: 	public void Start(IPEndPoint endPoint, int maxConnections) { }
	Строка 1301745: 	public void SendData(ArraySegment<byte> data, int targetConnectionID, hhc reliability) { }
	Строка 1301749: 	public void byeu(ArraySegment<byte> a, IEnumerable<int> targetConnectionIDs, hhc b) { }
	Строка 1306522: public sealed class ConnectionFailedException : Exception // TypeDefIndex: 24048
	Строка 1306543: 	public const hgu ConnectionFailed = 1;
	Строка 1306547: 	public const hgu RemoteConnectionClose = 5;
	Строка 1306595: 	public ConnectionFailedException byek() { }
	Строка 1306687: 	public virtual void Invoke(int connectionID) { }
	Строка 1306690: 	public virtual IAsyncResult BeginInvoke(int connectionID, AsyncCallback callback, object object) { }
	Строка 1306705: 	public virtual void Invoke(int connectionID) { }
	Строка 1306708: 	public virtual IAsyncResult BeginInvoke(int connectionID, AsyncCallback callback, object object) { }
	Строка 1306723: 	public virtual void Invoke(int connectionID, ArraySegment<byte> data, hhc reliability) { }
	Строка 1306726: 	public virtual IAsyncResult BeginInvoke(int connectionID, ArraySegment<byte> data, hhc reliability, AsyncCallback callback, object object) { }
	Строка 1306773: 	public abstract void Start(IPEndPoint endPoint, int maxConnections);
	Строка 1306783: 	public abstract void SendData(ArraySegment<byte> data, int targetConnectionID, hhc reliability);
	Строка 1306787: 	public abstract void byeu(ArraySegment<byte> a, IEnumerable<int> targetConnectionIDs, hhc b);
	Строка  223722: 	private GameObject _playerInfo; // 0x38
	Строка  226360: 	private GameObject _anotherPlayerInfo; // 0x30
	Строка  226362: 	private GameObject _minePlayerInfo; // 0x38
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

	Строка  125715: 	public const string cbiw = "Dialogs/LoadingPlayerProfile";
	Строка  194971: 	private PlayerProfileController _playerProfileController; // 0x80
	Строка  194997: 	public PlayerProfileController dqga { get; }
	Строка  195004: 	public PlayerProfileController vkh() { }
	Строка  196581: 	private PlayerProfileView _profileView; // 0x88
	Строка  197273: private sealed class PlayerProfileController.<>c // TypeDefIndex: 5048
	Строка  197276: 	public static readonly PlayerProfileController.<>c <>9; // 0x0
	Строка  197297: private struct PlayerProfileController.bzt : IAsyncStateMachine // TypeDefIndex: 5049
	Строка  197303: 	public PlayerProfileController ckrw; // 0x30
	Строка  197318: private struct PlayerProfileController.bzu : IAsyncStateMachine // TypeDefIndex: 5050
	Строка  197324: 	public PlayerProfileController cksb; // 0x30
	Строка  197339: private struct PlayerProfileController.bzv : IAsyncStateMachine // TypeDefIndex: 5051
	Строка  197345: 	public PlayerProfileController cksg; // 0x30
	Строка  197359: public class PlayerProfileController : MonoBehaviour // TypeDefIndex: 5052
	Строка  197366: 	private PlayerProfileView _playerProfileView; // 0x28
	Строка  197373: 	public PlayerProfileView dqgw { get; }
	Строка  197379: 	public PlayerProfileView vry() { }
	Строка  197395: 	[AsyncStateMachine(typeof(PlayerProfileController.bzv))]
	Строка  197399: 	[AsyncStateMachine(typeof(PlayerProfileController.bzu))]
	Строка  197403: 	[AsyncStateMachine(typeof(PlayerProfileController.bzt))]
	Строка  197419: public class PlayerProfileView : View // TypeDefIndex: 5053
	Строка  197522: 	private PlayerProfileController _shortProfileController; // 0x78
	Строка  392245: 	|-AsyncVoidMethodBuilder.Start<PlayerProfileController.bzt>
	Строка  392248: 	|-AsyncVoidMethodBuilder.Start<PlayerProfileController.bzu>
	Строка  392251: 	|-AsyncVoidMethodBuilder.Start<PlayerProfileController.bzv>
	Строка  392486: 	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, PlayerProfileController.bzt>
	Строка  392487: 	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, PlayerProfileController.bzu>
	Строка  392488: 	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, PlayerProfileController.bzv>
Строка  127375: 	public const string cdbu = "SearchGame/Ping";
	Строка  127936: 	public const string cdnr = "Statistics/Ping";
	Строка  157302: 	public const string cgxi = "ping";
	Строка  160203: 	public virtual void Invoke(GameServer server, int onlinePlayers, int ping, string info = "") { }
	Строка  160206: 	public virtual IAsyncResult BeginInvoke(GameServer server, int onlinePlayers, int ping, string info, AsyncCallback callback, object object) { }
	Строка  161000: 	private Ping chkq; // 0x28
	Строка  273168: 	public const string csqa = "Ping";
	Строка  681313: private struct Ping.cap_user_header_t // TypeDefIndex: 12030
	Строка  681321: private struct Ping.cap_user_data_t // TypeDefIndex: 12031
	Строка  681330: private class Ping.IcmpMessage // TypeDefIndex: 12032
	Строка  681374: private sealed class Ping.<>c__DisplayClass50_0 // TypeDefIndex: 12033
	Строка  681377: 	public Ping <>4__this; // 0x10
	Строка  681397: public class Ping : Component, IDisposable // TypeDefIndex: 12034
	Строка  681420: 	private static extern int capget(ref Ping.cap_user_header_t header, ref Ping.cap_user_data_t data) { }
	Строка 1222472: 	public int Ping { get; }
	Строка 1223301: 	public const PacketProperty Ping = 4;
