; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [230 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 64
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 17
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 54
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 86
	i64 295915112840604065, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 87
	i64 464346026994987652, ; 5: System.Reactive.dll => 0x671b04057e67284 => 35
	i64 634308326490598313, ; 6: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 73
	i64 702024105029695270, ; 7: System.Drawing.Common => 0x9be17343c0e7726 => 106
	i64 720058930071658100, ; 8: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 67
	i64 872800313462103108, ; 9: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 63
	i64 940822596282819491, ; 10: System.Transactions => 0xd0e792aa81923a3 => 104
	i64 996343623809489702, ; 11: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 99
	i64 1000557547492888992, ; 12: Mono.Security.dll => 0xde2b1c9cba651a0 => 114
	i64 1120440138749646132, ; 13: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 101
	i64 1315114680217950157, ; 14: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 49
	i64 1425944114962822056, ; 15: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 3
	i64 1624659445732251991, ; 16: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 47
	i64 1628611045998245443, ; 17: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 75
	i64 1636321030536304333, ; 18: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 68
	i64 1731380447121279447, ; 19: Newtonsoft.Json => 0x18071957e9b889d7 => 19
	i64 1743969030606105336, ; 20: System.Memory.dll => 0x1833d297e88f2af8 => 32
	i64 1795316252682057001, ; 21: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 48
	i64 1836611346387731153, ; 22: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 86
	i64 1865037103900624886, ; 23: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 6
	i64 1875917498431009007, ; 24: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 45
	i64 1981742497975770890, ; 25: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 74
	i64 2040001226662520565, ; 26: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 112
	i64 2133195048986300728, ; 27: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 19
	i64 2136356949452311481, ; 28: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 79
	i64 2152408820173588167, ; 29: Supabase.Functions.dll => 0x1ddee46b01dd46c7 => 23
	i64 2165725771938924357, ; 30: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 52
	i64 2262844636196693701, ; 31: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 63
	i64 2284400282711631002, ; 32: System.Web.Services => 0x1fb3d1f42fd4249a => 110
	i64 2329709569556905518, ; 33: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 71
	i64 2335503487726329082, ; 34: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 38
	i64 2337758774805907496, ; 35: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 36
	i64 2470498323731680442, ; 36: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 58
	i64 2479423007379663237, ; 37: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 91
	i64 2497223385847772520, ; 38: System.Runtime => 0x22a7eb7046413568 => 37
	i64 2547086958574651984, ; 39: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 44
	i64 2592350477072141967, ; 40: System.Xml.dll => 0x23f9e10627330e8f => 41
	i64 2612152650457191105, ; 41: Microsoft.IdentityModel.Tokens.dll => 0x24403afeed9892c1 => 13
	i64 2624866290265602282, ; 42: mscorlib.dll => 0x246d65fbde2db8ea => 18
	i64 2694427813909235223, ; 43: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 83
	i64 2783046991838674048, ; 44: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 36
	i64 2789714023057451704, ; 45: Microsoft.IdentityModel.JsonWebTokens.dll => 0x26b70e1f9943eab8 => 11
	i64 2926123043691605432, ; 46: Websocket.Client.dll => 0x289bad67ac52adb8 => 43
	i64 2960931600190307745, ; 47: Xamarin.Forms.Core => 0x2917579a49927da1 => 97
	i64 3017704767998173186, ; 48: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 101
	i64 3289520064315143713, ; 49: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 70
	i64 3303437397778967116, ; 50: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 46
	i64 3311221304742556517, ; 51: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 34
	i64 3402534845034375023, ; 52: System.IdentityModel.Tokens.Jwt.dll => 0x2f383b6a0629a76f => 31
	i64 3493805808809882663, ; 53: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 89
	i64 3522470458906976663, ; 54: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 88
	i64 3531994851595924923, ; 55: System.Numerics => 0x31042a9aade235bb => 33
	i64 3571415421602489686, ; 56: System.Runtime.dll => 0x319037675df7e556 => 37
	i64 3716579019761409177, ; 57: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 58: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 85
	i64 3772598417116884899, ; 59: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 64
	i64 3966267475168208030, ; 60: System.Memory => 0x370b03412596249e => 32
	i64 4084167866418059728, ; 61: Supabase.Postgrest.dll => 0x38ade10920e9d9d0 => 25
	i64 4525561845656915374, ; 62: System.ServiceModel.Internals => 0x3ece06856b710dae => 111
	i64 4552073122317810273, ; 63: MobileJob.Android.dll => 0x3f2c3663075b3a61 => 0
	i64 4636684751163556186, ; 64: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 93
	i64 4782108999019072045, ; 65: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 51
	i64 4794310189461587505, ; 66: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 44
	i64 4795410492532947900, ; 67: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 88
	i64 4987257569025601880, ; 68: MobileJob.Android => 0x45364c55dd263158 => 0
	i64 5142919913060024034, ; 69: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 98
	i64 5203618020066742981, ; 70: Xamarin.Essentials => 0x4836f704f0e652c5 => 96
	i64 5205316157927637098, ; 71: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 77
	i64 5348796042099802469, ; 72: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 78
	i64 5376510917114486089, ; 73: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 91
	i64 5408338804355907810, ; 74: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 90
	i64 5451019430259338467, ; 75: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 57
	i64 5507995362134886206, ; 76: System.Core.dll => 0x4c705499688c873e => 29
	i64 5692067934154308417, ; 77: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 95
	i64 5748194408492950188, ; 78: Supabase.Storage.dll => 0x4fc5b05bfa1be2ac => 27
	i64 5757522595884336624, ; 79: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 55
	i64 5814345312393086621, ; 80: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 83
	i64 5896680224035167651, ; 81: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 72
	i64 6085203216496545422, ; 82: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 99
	i64 6086316965293125504, ; 83: FormsViewGroup.dll => 0x5476f10882baef80 => 4
	i64 6222399776351216807, ; 84: System.Text.Json.dll => 0x565a67a0ffe264a7 => 39
	i64 6319713645133255417, ; 85: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 73
	i64 6401687960814735282, ; 86: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 71
	i64 6504860066809920875, ; 87: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 52
	i64 6548213210057960872, ; 88: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 61
	i64 6591024623626361694, ; 89: System.Web.Services.dll => 0x5b7805f9751a1b5e => 110
	i64 6659513131007730089, ; 90: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 67
	i64 6724398223859243234, ; 91: Supabase.Postgrest => 0x5d51dc8ea565d8e2 => 25
	i64 6876862101832370452, ; 92: System.Xml.Linq => 0x5f6f85a57d108914 => 42
	i64 6894844156784520562, ; 93: System.Numerics.Vectors => 0x5faf683aead1ad72 => 34
	i64 7036436454368433159, ; 94: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 69
	i64 7103753931438454322, ; 95: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 66
	i64 7488575175965059935, ; 96: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 42
	i64 7496222613193209122, ; 97: System.IdentityModel.Tokens.Jwt => 0x6807eec000a1b522 => 31
	i64 7602111570124318452, ; 98: System.Reactive => 0x698020320025a6f4 => 35
	i64 7635363394907363464, ; 99: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 97
	i64 7637365915383206639, ; 100: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 96
	i64 7654504624184590948, ; 101: System.Net.Http => 0x6a3a4366801b8264 => 2
	i64 7735176074855944702, ; 102: Microsoft.CSharp => 0x6b58dda848e391fe => 7
	i64 7820441508502274321, ; 103: System.Data => 0x6c87ca1e14ff8111 => 103
	i64 7836164640616011524, ; 104: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 47
	i64 7868980864444657808, ; 105: Supabase.Realtime.dll => 0x6d343c679191f090 => 26
	i64 8044118961405839122, ; 106: System.ComponentModel.Composition => 0x6fa2739369944712 => 109
	i64 8083354569033831015, ; 107: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 70
	i64 8103644804370223335, ; 108: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 105
	i64 8132393369586336849, ; 109: Plugin.InputKit => 0x70dc10aeafef8451 => 20
	i64 8167236081217502503, ; 110: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 5
	i64 8398329775253868912, ; 111: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 56
	i64 8400357532724379117, ; 112: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 82
	i64 8601935802264776013, ; 113: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 90
	i64 8626175481042262068, ; 114: Java.Interop => 0x77b654e585b55834 => 5
	i64 8638972117149407195, ; 115: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 7
	i64 8639588376636138208, ; 116: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 81
	i64 8684531736582871431, ; 117: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 108
	i64 8758604146903086415, ; 118: Supabase.Realtime => 0x798cd011086bf54f => 26
	i64 9312692141327339315, ; 119: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 95
	i64 9324707631942237306, ; 120: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 48
	i64 9427266486299436557, ; 121: Microsoft.IdentityModel.Logging.dll => 0x82d460ebe6d2a60d => 12
	i64 9662334977499516867, ; 122: System.Numerics.dll => 0x8617827802b0cfc3 => 33
	i64 9678050649315576968, ; 123: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 58
	i64 9711637524876806384, ; 124: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 78
	i64 9808709177481450983, ; 125: Mono.Android.dll => 0x881f890734e555e7 => 17
	i64 9825649861376906464, ; 126: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 55
	i64 9834056768316610435, ; 127: System.Transactions.dll => 0x8879968718899783 => 104
	i64 9998632235833408227, ; 128: Mono.Security => 0x8ac2470b209ebae3 => 114
	i64 10038780035334861115, ; 129: System.Net.Http.dll => 0x8b50e941206af13b => 2
	i64 10229024438826829339, ; 130: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 61
	i64 10347464889647514442, ; 131: Supabase.Gotrue => 0x8f99947e7144434a => 24
	i64 10376576884623852283, ; 132: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 89
	i64 10430153318873392755, ; 133: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 59
	i64 10447083246144586668, ; 134: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 6
	i64 10792975316471595968, ; 135: MobileJob.dll => 0x95c859dddfd943c0 => 16
	i64 10847732767863316357, ; 136: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 49
	i64 10984620054693331049, ; 137: Plugin.InputKit.dll => 0x987135bda0a0c069 => 20
	i64 11002576679268595294, ; 138: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 9
	i64 11023048688141570732, ; 139: System.Core => 0x98f9bc61168392ac => 29
	i64 11037814507248023548, ; 140: System.Xml => 0x992e31d0412bf7fc => 41
	i64 11162124722117608902, ; 141: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 94
	i64 11340910727871153756, ; 142: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 60
	i64 11392833485892708388, ; 143: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 84
	i64 11517440453979132662, ; 144: Microsoft.IdentityModel.Abstractions.dll => 0x9fd62b122523d2f6 => 10
	i64 11529969570048099689, ; 145: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 94
	i64 11578238080964724296, ; 146: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 69
	i64 11580057168383206117, ; 147: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 45
	i64 11597940890313164233, ; 148: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 149: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 66
	i64 11868377108928577036, ; 150: MimeMapping.dll => 0xa4b4f2196610be0c => 15
	i64 12102847907131387746, ; 151: System.Buffers => 0xa7f5f40c43256f62 => 28
	i64 12137774235383566651, ; 152: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 92
	i64 12145679461940342714, ; 153: System.Text.Json => 0xa88e1f1ebcb62fba => 39
	i64 12439275739440478309, ; 154: Microsoft.IdentityModel.JsonWebTokens => 0xaca12f61007bf865 => 11
	i64 12451044538927396471, ; 155: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 65
	i64 12466513435562512481, ; 156: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 76
	i64 12477254241918261868, ; 157: MobileJob => 0xad281ca02dc61a6c => 16
	i64 12487638416075308985, ; 158: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 62
	i64 12538491095302438457, ; 159: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 53
	i64 12550732019250633519, ; 160: System.IO.Compression => 0xae2d28465e8e1b2f => 107
	i64 12700543734426720211, ; 161: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 54
	i64 12808066478489537992, ; 162: Websocket.Client => 0xb1bf649a25f50dc8 => 43
	i64 12888876061296924636, ; 163: Supabase.Core.dll => 0xb2de7c7d53a397dc => 21
	i64 12963446364377008305, ; 164: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 106
	i64 13310112861600168646, ; 165: Supabase.Storage => 0xb8b70520ac093ac6 => 27
	i64 13370592475155966277, ; 166: System.Runtime.Serialization => 0xb98de304062ea945 => 3
	i64 13401370062847626945, ; 167: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 92
	i64 13404347523447273790, ; 168: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 56
	i64 13454009404024712428, ; 169: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 102
	i64 13491513212026656886, ; 170: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 50
	i64 13572454107664307259, ; 171: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 85
	i64 13647894001087880694, ; 172: System.Data.dll => 0xbd670f48cb071df6 => 103
	i64 13959074834287824816, ; 173: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 65
	i64 13967638549803255703, ; 174: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 98
	i64 14124974489674258913, ; 175: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 53
	i64 14172845254133543601, ; 176: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 79
	i64 14212104595480609394, ; 177: System.Security.Cryptography.Cng.dll => 0xc53b89d4a4518272 => 113
	i64 14261073672896646636, ; 178: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 84
	i64 14486659737292545672, ; 179: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 72
	i64 14551742072151931844, ; 180: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 38
	i64 14625816794512409936, ; 181: Supabase.Gotrue.dll => 0xcaf956e23adac550 => 24
	i64 14644440854989303794, ; 182: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 77
	i64 14744453227118192070, ; 183: MimeMapping => 0xcc9ed21731bde5c6 => 15
	i64 14792063746108907174, ; 184: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 102
	i64 14852515768018889994, ; 185: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 60
	i64 14954917835170835695, ; 186: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 8
	i64 14987728460634540364, ; 187: System.IO.Compression.dll => 0xcfff1ba06622494c => 107
	i64 14988210264188246988, ; 188: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 62
	i64 15138356091203993725, ; 189: Microsoft.IdentityModel.Abstractions => 0xd2163ea89395c07d => 10
	i64 15154054061132759083, ; 190: Supabase => 0xd24e03e104e2402b => 22
	i64 15370334346939861994, ; 191: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 59
	i64 15391712275433856905, ; 192: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 8
	i64 15582737692548360875, ; 193: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 75
	i64 15609085926864131306, ; 194: System.dll => 0xd89e9cf3334914ea => 30
	i64 15777549416145007739, ; 195: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 87
	i64 15810740023422282496, ; 196: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 100
	i64 15847085070278954535, ; 197: System.Threading.Channels.dll => 0xdbec27e8f35f8e27 => 40
	i64 15937190497610202713, ; 198: System.Security.Cryptography.Cng => 0xdd2c465197c97e59 => 113
	i64 15963349826457351533, ; 199: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 112
	i64 16154507427712707110, ; 200: System => 0xe03056ea4e39aa26 => 30
	i64 16321164108206115771, ; 201: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 9
	i64 16565028646146589191, ; 202: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 109
	i64 16621146507174665210, ; 203: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 57
	i64 16677317093839702854, ; 204: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 82
	i64 16822611501064131242, ; 205: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 105
	i64 16833383113903931215, ; 206: mscorlib => 0xe99c30c1484d7f4f => 18
	i64 17024911836938395553, ; 207: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 46
	i64 17031351772568316411, ; 208: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 80
	i64 17037200463775726619, ; 209: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 68
	i64 17118171214553292978, ; 210: System.Threading.Channels => 0xed8ff6060fc420b2 => 40
	i64 17137864900836977098, ; 211: Microsoft.IdentityModel.Tokens => 0xedd5ed53b705e9ca => 13
	i64 17544493274320527064, ; 212: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 51
	i64 17576078694130054946, ; 213: Supabase.dll => 0xf3eac67343eef722 => 22
	i64 17608862831326185980, ; 214: Microsoft.IO.RecyclableMemoryStream.dll => 0xf45f3f7307c6c9fc => 14
	i64 17704177640604968747, ; 215: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 76
	i64 17710060891934109755, ; 216: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 74
	i64 17790600151040787804, ; 217: Microsoft.IdentityModel.Logging => 0xf6e4e89427cc055c => 12
	i64 17838668724098252521, ; 218: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 28
	i64 17882897186074144999, ; 219: FormsViewGroup => 0xf82cd03e3ac830e7 => 4
	i64 17892495832318972303, ; 220: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 100
	i64 17928294245072900555, ; 221: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 108
	i64 17958341848870185232, ; 222: Microsoft.IO.RecyclableMemoryStream => 0xf938d8c3a0f06910 => 14
	i64 18099689198537119569, ; 223: Supabase.Functions => 0xfb2f036e07c79751 => 23
	i64 18116111925905154859, ; 224: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 50
	i64 18121036031235206392, ; 225: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 80
	i64 18129453464017766560, ; 226: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 111
	i64 18226465428055663763, ; 227: Supabase.Core => 0xfcf169bd26322493 => 21
	i64 18305135509493619199, ; 228: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 81
	i64 18380184030268848184 ; 229: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 93
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [230 x i32] [
	i32 64, i32 17, i32 54, i32 86, i32 87, i32 35, i32 73, i32 106, ; 0..7
	i32 67, i32 63, i32 104, i32 99, i32 114, i32 101, i32 49, i32 3, ; 8..15
	i32 47, i32 75, i32 68, i32 19, i32 32, i32 48, i32 86, i32 6, ; 16..23
	i32 45, i32 74, i32 112, i32 19, i32 79, i32 23, i32 52, i32 63, ; 24..31
	i32 110, i32 71, i32 38, i32 36, i32 58, i32 91, i32 37, i32 44, ; 32..39
	i32 41, i32 13, i32 18, i32 83, i32 36, i32 11, i32 43, i32 97, ; 40..47
	i32 101, i32 70, i32 46, i32 34, i32 31, i32 89, i32 88, i32 33, ; 48..55
	i32 37, i32 1, i32 85, i32 64, i32 32, i32 25, i32 111, i32 0, ; 56..63
	i32 93, i32 51, i32 44, i32 88, i32 0, i32 98, i32 96, i32 77, ; 64..71
	i32 78, i32 91, i32 90, i32 57, i32 29, i32 95, i32 27, i32 55, ; 72..79
	i32 83, i32 72, i32 99, i32 4, i32 39, i32 73, i32 71, i32 52, ; 80..87
	i32 61, i32 110, i32 67, i32 25, i32 42, i32 34, i32 69, i32 66, ; 88..95
	i32 42, i32 31, i32 35, i32 97, i32 96, i32 2, i32 7, i32 103, ; 96..103
	i32 47, i32 26, i32 109, i32 70, i32 105, i32 20, i32 5, i32 56, ; 104..111
	i32 82, i32 90, i32 5, i32 7, i32 81, i32 108, i32 26, i32 95, ; 112..119
	i32 48, i32 12, i32 33, i32 58, i32 78, i32 17, i32 55, i32 104, ; 120..127
	i32 114, i32 2, i32 61, i32 24, i32 89, i32 59, i32 6, i32 16, ; 128..135
	i32 49, i32 20, i32 9, i32 29, i32 41, i32 94, i32 60, i32 84, ; 136..143
	i32 10, i32 94, i32 69, i32 45, i32 1, i32 66, i32 15, i32 28, ; 144..151
	i32 92, i32 39, i32 11, i32 65, i32 76, i32 16, i32 62, i32 53, ; 152..159
	i32 107, i32 54, i32 43, i32 21, i32 106, i32 27, i32 3, i32 92, ; 160..167
	i32 56, i32 102, i32 50, i32 85, i32 103, i32 65, i32 98, i32 53, ; 168..175
	i32 79, i32 113, i32 84, i32 72, i32 38, i32 24, i32 77, i32 15, ; 176..183
	i32 102, i32 60, i32 8, i32 107, i32 62, i32 10, i32 22, i32 59, ; 184..191
	i32 8, i32 75, i32 30, i32 87, i32 100, i32 40, i32 113, i32 112, ; 192..199
	i32 30, i32 9, i32 109, i32 57, i32 82, i32 105, i32 18, i32 46, ; 200..207
	i32 80, i32 68, i32 40, i32 13, i32 51, i32 22, i32 14, i32 76, ; 208..215
	i32 74, i32 12, i32 28, i32 4, i32 100, i32 108, i32 14, i32 23, ; 216..223
	i32 50, i32 80, i32 111, i32 21, i32 81, i32 93 ; 224..229
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
