; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [230 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 73
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 102
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 19
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 97
	i32 95598293, ; 4: Supabase.dll => 0x5b2b6d5 => 22
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 87
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 87
	i32 122350210, ; 7: System.Threading.Channels.dll => 0x74aea82 => 40
	i32 162612358, ; 8: MimeMapping => 0x9b14486 => 15
	i32 165246403, ; 9: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 54
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 88
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 52
	i32 230216969, ; 12: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 68
	i32 230752869, ; 13: Microsoft.CSharp.dll => 0xdc10265 => 7
	i32 232815796, ; 14: System.Web.Services => 0xde07cb4 => 110
	i32 261689757, ; 15: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 57
	i32 278686392, ; 16: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 72
	i32 280482487, ; 17: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 66
	i32 318968648, ; 18: Xamarin.AndroidX.Activity.dll => 0x13031348 => 44
	i32 321597661, ; 19: System.Numerics => 0x132b30dd => 33
	i32 342366114, ; 20: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 70
	i32 385762202, ; 21: System.Memory.dll => 0x16fe439a => 32
	i32 441335492, ; 22: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 56
	i32 442521989, ; 23: Xamarin.Essentials => 0x1a605985 => 96
	i32 450948140, ; 24: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 65
	i32 465846621, ; 25: mscorlib => 0x1bc4415d => 18
	i32 469710990, ; 26: System.dll => 0x1bff388e => 30
	i32 476646585, ; 27: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 66
	i32 485463106, ; 28: Microsoft.IdentityModel.Abstractions => 0x1cef9442 => 10
	i32 486930444, ; 29: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 77
	i32 526420162, ; 30: System.Transactions.dll => 0x1f6088c2 => 104
	i32 548916678, ; 31: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 6
	i32 577335427, ; 32: System.Security.Cryptography.Cng => 0x22697083 => 113
	i32 605376203, ; 33: System.IO.Compression.FileSystem => 0x24154ecb => 108
	i32 610194910, ; 34: System.Reactive.dll => 0x245ed5de => 35
	i32 627609679, ; 35: Xamarin.AndroidX.CustomView => 0x2568904f => 61
	i32 662205335, ; 36: System.Text.Encodings.Web.dll => 0x27787397 => 38
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 93
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 49
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 42
	i32 763346851, ; 40: Websocket.Client => 0x2d7fbfa3 => 43
	i32 772621961, ; 41: Supabase.Core.dll => 0x2e0d4689 => 21
	i32 775507847, ; 42: System.IO.Compression => 0x2e394f87 => 107
	i32 791272004, ; 43: Plugin.InputKit => 0x2f29da44 => 20
	i32 809851609, ; 44: System.Drawing.Common.dll => 0x30455ad9 => 106
	i32 843511501, ; 45: Xamarin.AndroidX.Print => 0x3246f6cd => 84
	i32 920281169, ; 46: Supabase.Functions => 0x36da6051 => 23
	i32 928116545, ; 47: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 102
	i32 955402788, ; 48: Newtonsoft.Json => 0x38f24a24 => 19
	i32 967690846, ; 49: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 70
	i32 974778368, ; 50: FormsViewGroup.dll => 0x3a19f000 => 4
	i32 1012816738, ; 51: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 86
	i32 1028951442, ; 52: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 8
	i32 1035644815, ; 53: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 48
	i32 1042160112, ; 54: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 99
	i32 1052210849, ; 55: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 74
	i32 1089187994, ; 56: Websocket.Client.dll => 0x40ebb09a => 43
	i32 1098259244, ; 57: System => 0x41761b2c => 30
	i32 1175144683, ; 58: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 91
	i32 1178241025, ; 59: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 81
	i32 1204270330, ; 60: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 49
	i32 1216849306, ; 61: Supabase.Realtime.dll => 0x4887a59a => 26
	i32 1219540809, ; 62: Supabase.Functions.dll => 0x48b0b749 => 23
	i32 1267360935, ; 63: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 92
	i32 1293217323, ; 64: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 63
	i32 1336984896, ; 65: Supabase.Core => 0x4fb0c540 => 21
	i32 1365406463, ; 66: System.ServiceModel.Internals.dll => 0x516272ff => 111
	i32 1376866003, ; 67: Xamarin.AndroidX.SavedState => 0x52114ed3 => 86
	i32 1395857551, ; 68: Xamarin.AndroidX.Media.dll => 0x5333188f => 78
	i32 1406073936, ; 69: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 58
	i32 1411638395, ; 70: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 36
	i32 1460219004, ; 71: Xamarin.Forms.Xaml => 0x57092c7c => 100
	i32 1460893475, ; 72: System.IdentityModel.Tokens.Jwt => 0x57137723 => 31
	i32 1462112819, ; 73: System.IO.Compression.dll => 0x57261233 => 107
	i32 1469204771, ; 74: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 47
	i32 1498168481, ; 75: Microsoft.IdentityModel.JsonWebTokens.dll => 0x594c3ca1 => 11
	i32 1516168485, ; 76: Supabase.Gotrue => 0x5a5ee525 => 24
	i32 1551954004, ; 77: Microsoft.IO.RecyclableMemoryStream.dll => 0x5c80f054 => 14
	i32 1582372066, ; 78: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 62
	i32 1592978981, ; 79: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1602292545, ; 80: MobileJob.dll => 0x5f810b41 => 16
	i32 1622152042, ; 81: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 76
	i32 1624863272, ; 82: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 95
	i32 1636350590, ; 83: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 60
	i32 1639515021, ; 84: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 85: System.Runtime => 0x62c6282e => 37
	i32 1658241508, ; 86: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 89
	i32 1658251792, ; 87: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 101
	i32 1667080824, ; 88: MobileJob.Android.dll => 0x635da278 => 0
	i32 1670060433, ; 89: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 57
	i32 1729485958, ; 90: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 53
	i32 1766324549, ; 91: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 88
	i32 1776026572, ; 92: System.Core.dll => 0x69dc03cc => 29
	i32 1788241197, ; 93: Xamarin.AndroidX.Fragment => 0x6a96652d => 65
	i32 1796167890, ; 94: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 6
	i32 1808609942, ; 95: Xamarin.AndroidX.Loader => 0x6bcd3296 => 76
	i32 1813201214, ; 96: Xamarin.Google.Android.Material => 0x6c13413e => 101
	i32 1818569960, ; 97: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 82
	i32 1828688058, ; 98: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 9
	i32 1867746548, ; 99: Xamarin.Essentials.dll => 0x6f538cf4 => 96
	i32 1878053835, ; 100: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 100
	i32 1885316902, ; 101: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 50
	i32 1919157823, ; 102: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 79
	i32 1986222447, ; 103: Microsoft.IdentityModel.Tokens.dll => 0x7663596f => 13
	i32 2011961780, ; 104: System.Buffers.dll => 0x77ec19b4 => 28
	i32 2018526534, ; 105: Supabase.Gotrue.dll => 0x78504546 => 24
	i32 2019465201, ; 106: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 74
	i32 2055257422, ; 107: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 71
	i32 2079903147, ; 108: System.Runtime.dll => 0x7bf8cdab => 37
	i32 2090596640, ; 109: System.Numerics.Vectors => 0x7c9bf920 => 34
	i32 2095794904, ; 110: MobileJob => 0x7ceb4ad8 => 16
	i32 2097448633, ; 111: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 67
	i32 2126786730, ; 112: Xamarin.Forms.Platform.Android => 0x7ec430aa => 98
	i32 2128198166, ; 113: Supabase.Realtime => 0x7ed9ba16 => 26
	i32 2138252982, ; 114: Supabase => 0x7f7326b6 => 22
	i32 2143465592, ; 115: Microsoft.IO.RecyclableMemoryStream => 0x7fc2b078 => 14
	i32 2192057212, ; 116: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 9
	i32 2201231467, ; 117: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 118: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 91
	i32 2244775296, ; 119: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 77
	i32 2256548716, ; 120: Xamarin.AndroidX.MultiDex => 0x8680336c => 79
	i32 2261435625, ; 121: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 69
	i32 2279755925, ; 122: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 85
	i32 2315684594, ; 123: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 45
	i32 2369706906, ; 124: Microsoft.IdentityModel.Logging => 0x8d3edb9a => 12
	i32 2409053734, ; 125: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 83
	i32 2465532216, ; 126: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 56
	i32 2471841756, ; 127: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 128: Java.Interop.dll => 0x93918882 => 5
	i32 2501346920, ; 129: System.Data.DataSetExtensions => 0x95178668 => 105
	i32 2505896520, ; 130: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 73
	i32 2562349572, ; 131: Microsoft.CSharp => 0x98ba5a04 => 7
	i32 2570120770, ; 132: System.Text.Encodings.Web => 0x9930ee42 => 38
	i32 2581819634, ; 133: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 92
	i32 2620871830, ; 134: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 60
	i32 2624644809, ; 135: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 64
	i32 2633051222, ; 136: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 72
	i32 2640290731, ; 137: Microsoft.IdentityModel.Logging.dll => 0x9d5fa3ab => 12
	i32 2701096212, ; 138: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 89
	i32 2719963679, ; 139: System.Security.Cryptography.Cng.dll => 0xa21f5a1f => 113
	i32 2732626843, ; 140: Xamarin.AndroidX.Activity => 0xa2e0939b => 44
	i32 2735172069, ; 141: System.Threading.Channels => 0xa30769e5 => 40
	i32 2737747696, ; 142: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 47
	i32 2766581644, ; 143: Xamarin.Forms.Core => 0xa4e6af8c => 97
	i32 2778768386, ; 144: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 94
	i32 2810250172, ; 145: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 58
	i32 2819470561, ; 146: System.Xml.dll => 0xa80db4e1 => 41
	i32 2853208004, ; 147: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 94
	i32 2855708567, ; 148: Xamarin.AndroidX.Transition => 0xaa36a797 => 90
	i32 2903344695, ; 149: System.ComponentModel.Composition => 0xad0d8637 => 109
	i32 2905242038, ; 150: mscorlib.dll => 0xad2a79b6 => 18
	i32 2916838712, ; 151: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 95
	i32 2919462931, ; 152: System.Numerics.Vectors.dll => 0xae037813 => 34
	i32 2921128767, ; 153: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 46
	i32 2978675010, ; 154: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 63
	i32 3024354802, ; 155: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 68
	i32 3044182254, ; 156: FormsViewGroup => 0xb57288ee => 4
	i32 3057625584, ; 157: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 80
	i32 3084678329, ; 158: Microsoft.IdentityModel.Tokens => 0xb7dc74b9 => 13
	i32 3099081453, ; 159: MimeMapping.dll => 0xb8b83aed => 15
	i32 3111772706, ; 160: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3112133039, ; 161: MobileJob.Android => 0xb97f61af => 0
	i32 3124832203, ; 162: System.Threading.Tasks.Extensions => 0xba4127cb => 112
	i32 3138360719, ; 163: Supabase.Postgrest.dll => 0xbb0f958f => 25
	i32 3204380047, ; 164: System.Data.dll => 0xbefef58f => 103
	i32 3211777861, ; 165: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 62
	i32 3247949154, ; 166: Mono.Security => 0xc197c562 => 114
	i32 3258312781, ; 167: Xamarin.AndroidX.CardView => 0xc235e84d => 53
	i32 3265893370, ; 168: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 112
	i32 3267021929, ; 169: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 51
	i32 3312457198, ; 170: Microsoft.IdentityModel.JsonWebTokens => 0xc57015ee => 11
	i32 3317135071, ; 171: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 61
	i32 3317144872, ; 172: System.Data => 0xc5b79d28 => 103
	i32 3340431453, ; 173: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 50
	i32 3346324047, ; 174: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 81
	i32 3353484488, ; 175: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 67
	i32 3358260929, ; 176: System.Text.Json => 0xc82afec1 => 39
	i32 3362522851, ; 177: Xamarin.AndroidX.Core => 0xc86c06e3 => 59
	i32 3366347497, ; 178: Java.Interop => 0xc8a662e9 => 5
	i32 3374999561, ; 179: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 85
	i32 3395150330, ; 180: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 36
	i32 3404865022, ; 181: System.ServiceModel.Internals => 0xcaf21dfe => 111
	i32 3429136800, ; 182: System.Xml => 0xcc6479a0 => 41
	i32 3430777524, ; 183: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 184: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 64
	i32 3476120550, ; 185: Mono.Android => 0xcf3163e6 => 17
	i32 3485117614, ; 186: System.Text.Json.dll => 0xcfbaacae => 39
	i32 3486566296, ; 187: System.Transactions => 0xcfd0c798 => 104
	i32 3493954962, ; 188: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 55
	i32 3501239056, ; 189: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 51
	i32 3509114376, ; 190: System.Xml.Linq => 0xd128d608 => 42
	i32 3536029504, ; 191: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 98
	i32 3567349600, ; 192: System.ComponentModel.Composition.dll => 0xd4a16f60 => 109
	i32 3607666123, ; 193: Supabase.Postgrest => 0xd7089dcb => 25
	i32 3618140916, ; 194: Xamarin.AndroidX.Preference => 0xd7a872f4 => 83
	i32 3627220390, ; 195: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 84
	i32 3632359727, ; 196: Xamarin.Forms.Platform => 0xd881692f => 99
	i32 3633644679, ; 197: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 46
	i32 3641597786, ; 198: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 71
	i32 3672681054, ; 199: Mono.Android.dll => 0xdae8aa5e => 17
	i32 3676310014, ; 200: System.Web.Services.dll => 0xdb2009fe => 110
	i32 3682565725, ; 201: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 52
	i32 3684561358, ; 202: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 55
	i32 3689375977, ; 203: System.Drawing.Common => 0xdbe768e9 => 106
	i32 3700591436, ; 204: Microsoft.IdentityModel.Abstractions.dll => 0xdc928b4c => 10
	i32 3718780102, ; 205: Xamarin.AndroidX.Annotation => 0xdda814c6 => 45
	i32 3724971120, ; 206: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 80
	i32 3731644420, ; 207: System.Reactive => 0xde6c6004 => 35
	i32 3758932259, ; 208: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 69
	i32 3776811843, ; 209: Plugin.InputKit.dll => 0xe11d9343 => 20
	i32 3786282454, ; 210: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 54
	i32 3822602673, ; 211: Xamarin.AndroidX.Media => 0xe3d849b1 => 78
	i32 3829621856, ; 212: System.Numerics.dll => 0xe4436460 => 33
	i32 3841636137, ; 213: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 8
	i32 3885922214, ; 214: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 90
	i32 3896760992, ; 215: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 59
	i32 3906640997, ; 216: Supabase.Storage.dll => 0xe8da9c65 => 27
	i32 3920810846, ; 217: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 108
	i32 3921031405, ; 218: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 93
	i32 3931092270, ; 219: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 82
	i32 3945713374, ; 220: System.Data.DataSetExtensions.dll => 0xeb2ecede => 105
	i32 3955647286, ; 221: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 48
	i32 3980364293, ; 222: Supabase.Storage => 0xed3f8a05 => 27
	i32 4025784931, ; 223: System.Memory => 0xeff49a63 => 32
	i32 4105002889, ; 224: Mono.Security.dll => 0xf4ad5f89 => 114
	i32 4151237749, ; 225: System.Core => 0xf76edc75 => 29
	i32 4182413190, ; 226: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 75
	i32 4260525087, ; 227: System.Buffers => 0xfdf2741f => 28
	i32 4263231520, ; 228: System.IdentityModel.Tokens.Jwt.dll => 0xfe1bc020 => 31
	i32 4292120959 ; 229: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 75
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [230 x i32] [
	i32 73, i32 102, i32 19, i32 97, i32 22, i32 87, i32 87, i32 40, ; 0..7
	i32 15, i32 54, i32 88, i32 52, i32 68, i32 7, i32 110, i32 57, ; 8..15
	i32 72, i32 66, i32 44, i32 33, i32 70, i32 32, i32 56, i32 96, ; 16..23
	i32 65, i32 18, i32 30, i32 66, i32 10, i32 77, i32 104, i32 6, ; 24..31
	i32 113, i32 108, i32 35, i32 61, i32 38, i32 93, i32 49, i32 42, ; 32..39
	i32 43, i32 21, i32 107, i32 20, i32 106, i32 84, i32 23, i32 102, ; 40..47
	i32 19, i32 70, i32 4, i32 86, i32 8, i32 48, i32 99, i32 74, ; 48..55
	i32 43, i32 30, i32 91, i32 81, i32 49, i32 26, i32 23, i32 92, ; 56..63
	i32 63, i32 21, i32 111, i32 86, i32 78, i32 58, i32 36, i32 100, ; 64..71
	i32 31, i32 107, i32 47, i32 11, i32 24, i32 14, i32 62, i32 3, ; 72..79
	i32 16, i32 76, i32 95, i32 60, i32 2, i32 37, i32 89, i32 101, ; 80..87
	i32 0, i32 57, i32 53, i32 88, i32 29, i32 65, i32 6, i32 76, ; 88..95
	i32 101, i32 82, i32 9, i32 96, i32 100, i32 50, i32 79, i32 13, ; 96..103
	i32 28, i32 24, i32 74, i32 71, i32 37, i32 34, i32 16, i32 67, ; 104..111
	i32 98, i32 26, i32 22, i32 14, i32 9, i32 2, i32 91, i32 77, ; 112..119
	i32 79, i32 69, i32 85, i32 45, i32 12, i32 83, i32 56, i32 1, ; 120..127
	i32 5, i32 105, i32 73, i32 7, i32 38, i32 92, i32 60, i32 64, ; 128..135
	i32 72, i32 12, i32 89, i32 113, i32 44, i32 40, i32 47, i32 97, ; 136..143
	i32 94, i32 58, i32 41, i32 94, i32 90, i32 109, i32 18, i32 95, ; 144..151
	i32 34, i32 46, i32 63, i32 68, i32 4, i32 80, i32 13, i32 15, ; 152..159
	i32 3, i32 0, i32 112, i32 25, i32 103, i32 62, i32 114, i32 53, ; 160..167
	i32 112, i32 51, i32 11, i32 61, i32 103, i32 50, i32 81, i32 67, ; 168..175
	i32 39, i32 59, i32 5, i32 85, i32 36, i32 111, i32 41, i32 1, ; 176..183
	i32 64, i32 17, i32 39, i32 104, i32 55, i32 51, i32 42, i32 98, ; 184..191
	i32 109, i32 25, i32 83, i32 84, i32 99, i32 46, i32 71, i32 17, ; 192..199
	i32 110, i32 52, i32 55, i32 106, i32 10, i32 45, i32 80, i32 35, ; 200..207
	i32 69, i32 20, i32 54, i32 78, i32 33, i32 8, i32 90, i32 59, ; 208..215
	i32 27, i32 108, i32 93, i32 82, i32 105, i32 48, i32 27, i32 32, ; 216..223
	i32 114, i32 29, i32 75, i32 28, i32 31, i32 75 ; 224..229
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
