; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [244 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 76
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 101
	i32 57967248, ; 2: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 41
	i32 101534019, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 87
	i32 120558881, ; 4: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 87
	i32 134690465, ; 5: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 105
	i32 160529393, ; 6: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 13
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 53
	i32 166922606, ; 8: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 24
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 89
	i32 201930040, ; 10: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 14
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 51
	i32 230216969, ; 12: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 71
	i32 232815796, ; 13: System.Web.Services => 0xde07cb4 => 119
	i32 261689757, ; 14: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 56
	i32 278686392, ; 15: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 74
	i32 280482487, ; 16: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 69
	i32 318968648, ; 17: Xamarin.AndroidX.Activity.dll => 0x13031348 => 43
	i32 321597661, ; 18: System.Numerics => 0x132b30dd => 9
	i32 342366114, ; 19: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 72
	i32 388313361, ; 20: Xamarin.Android.Support.Animated.Vector.Drawable => 0x17253111 => 20
	i32 389971796, ; 21: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 26
	i32 441335492, ; 22: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 55
	i32 442521989, ; 23: Xamarin.Essentials => 0x1a605985 => 98
	i32 450948140, ; 24: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 68
	i32 465846621, ; 25: mscorlib => 0x1bc4415d => 3
	i32 469710990, ; 26: System.dll => 0x1bff388e => 7
	i32 476646585, ; 27: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 69
	i32 486930444, ; 28: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 80
	i32 514659665, ; 29: Xamarin.Android.Support.Compat => 0x1ead1551 => 24
	i32 524864063, ; 30: Xamarin.Android.Support.Print => 0x1f48ca3f => 36
	i32 526420162, ; 31: System.Transactions.dll => 0x1f6088c2 => 111
	i32 527452488, ; 32: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 105
	i32 605376203, ; 33: System.IO.Compression.FileSystem => 0x24154ecb => 115
	i32 627609679, ; 34: Xamarin.AndroidX.CustomView => 0x2568904f => 61
	i32 639843206, ; 35: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 67
	i32 643868501, ; 36: System.Net => 0x2660a755 => 8
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 94
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 48
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 120
	i32 691348768, ; 40: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 107
	i32 692692150, ; 41: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 21
	i32 700284507, ; 42: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 102
	i32 720511267, ; 43: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 106
	i32 775507847, ; 44: System.IO.Compression => 0x2e394f87 => 114
	i32 790371945, ; 45: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 62
	i32 801787702, ; 46: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 33
	i32 809851609, ; 47: System.Drawing.Common.dll => 0x30455ad9 => 110
	i32 843511501, ; 48: Xamarin.AndroidX.Print => 0x3246f6cd => 82
	i32 916714535, ; 49: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 36
	i32 928116545, ; 50: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 101
	i32 956575887, ; 51: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 106
	i32 967690846, ; 52: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 72
	i32 987342438, ; 53: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 17
	i32 1012816738, ; 54: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 86
	i32 1031528504, ; 55: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 100
	i32 1035644815, ; 56: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 47
	i32 1052210849, ; 57: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 77
	i32 1084122840, ; 58: Xamarin.Kotlin.StdLib => 0x409e66d8 => 104
	i32 1098167829, ; 59: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 19
	i32 1098259244, ; 60: System => 0x41761b2c => 7
	i32 1109081163, ; 61: Group2_IT123P_MP => 0x421b3c4b => 0
	i32 1149092582, ; 62: Xamarin.AndroidX.Window => 0x447dc2e6 => 97
	i32 1175144683, ; 63: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 92
	i32 1204270330, ; 64: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 48
	i32 1264511973, ; 65: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 88
	i32 1267360935, ; 66: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 93
	i32 1275534314, ; 67: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 107
	i32 1292763917, ; 68: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 28
	i32 1293217323, ; 69: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 64
	i32 1297413738, ; 70: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 16
	i32 1322716291, ; 71: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 97
	i32 1365406463, ; 72: System.ServiceModel.Internals.dll => 0x516272ff => 118
	i32 1376866003, ; 73: Xamarin.AndroidX.SavedState => 0x52114ed3 => 86
	i32 1406073936, ; 74: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 57
	i32 1445445088, ; 75: Xamarin.Android.Support.Fragment => 0x5627bde0 => 32
	i32 1462112819, ; 76: System.IO.Compression.dll => 0x57261233 => 114
	i32 1469204771, ; 77: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 46
	i32 1574652163, ; 78: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 27
	i32 1582372066, ; 79: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 63
	i32 1587447679, ; 80: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 13
	i32 1592978981, ; 81: System.Runtime.Serialization.dll => 0x5ef2ee25 => 117
	i32 1597949149, ; 82: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 100
	i32 1622152042, ; 83: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 79
	i32 1624863272, ; 84: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 96
	i32 1635184631, ; 85: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 67
	i32 1636350590, ; 86: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 60
	i32 1639515021, ; 87: System.Net.Http.dll => 0x61b9038d => 109
	i32 1657153582, ; 88: System.Runtime => 0x62c6282e => 11
	i32 1658241508, ; 89: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 90
	i32 1658251792, ; 90: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 99
	i32 1662014763, ; 91: Xamarin.Android.Support.Vector.Drawable => 0x6310552b => 40
	i32 1670060433, ; 92: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 56
	i32 1698840827, ; 93: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 103
	i32 1729485958, ; 94: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 52
	i32 1766324549, ; 95: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 89
	i32 1776026572, ; 96: System.Core.dll => 0x69dc03cc => 4
	i32 1788241197, ; 97: Xamarin.AndroidX.Fragment => 0x6a96652d => 68
	i32 1808609942, ; 98: Xamarin.AndroidX.Loader => 0x6bcd3296 => 79
	i32 1813058853, ; 99: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 104
	i32 1813201214, ; 100: Xamarin.Google.Android.Material => 0x6c13413e => 99
	i32 1866717392, ; 101: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 33
	i32 1867746548, ; 102: Xamarin.Essentials.dll => 0x6f538cf4 => 98
	i32 1885316902, ; 103: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 49
	i32 1916660109, ; 104: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 19
	i32 1919157823, ; 105: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 81
	i32 1983156543, ; 106: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 103
	i32 2019465201, ; 107: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 77
	i32 2037417872, ; 108: Xamarin.Android.Support.ViewPager => 0x79708790 => 42
	i32 2044222327, ; 109: Xamarin.Android.Support.Loader => 0x79d85b77 => 34
	i32 2055257422, ; 110: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 73
	i32 2079903147, ; 111: System.Runtime.dll => 0x7bf8cdab => 11
	i32 2090596640, ; 112: System.Numerics.Vectors => 0x7c9bf920 => 10
	i32 2097448633, ; 113: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 70
	i32 2104898930, ; 114: Group2_IT123P_MP.dll => 0x7d763572 => 0
	i32 2139458754, ; 115: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 31
	i32 2142278582, ; 116: System.Data.OleDb.dll => 0x7fb093b6 => 6
	i32 2166116741, ; 117: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 27
	i32 2196165013, ; 118: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 41
	i32 2201107256, ; 119: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 108
	i32 2201231467, ; 120: System.Net.Http => 0x8334206b => 109
	i32 2217644978, ; 121: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 92
	i32 2244775296, ; 122: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 80
	i32 2256548716, ; 123: Xamarin.AndroidX.MultiDex => 0x8680336c => 81
	i32 2279755925, ; 124: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 84
	i32 2315684594, ; 125: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 44
	i32 2330457430, ; 126: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 26
	i32 2330986192, ; 127: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 37
	i32 2373288475, ; 128: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 32
	i32 2403452196, ; 129: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 66
	i32 2440966767, ; 130: Xamarin.Android.Support.Loader.dll => 0x917e326f => 34
	i32 2465532216, ; 131: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 55
	i32 2471841756, ; 132: netstandard.dll => 0x93554fdc => 112
	i32 2475788418, ; 133: Java.Interop.dll => 0x93918882 => 1
	i32 2487632829, ; 134: Xamarin.Android.Support.DocumentFile => 0x944643bd => 30
	i32 2501346920, ; 135: System.Data.DataSetExtensions => 0x95178668 => 113
	i32 2505896520, ; 136: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 76
	i32 2581819634, ; 137: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 93
	i32 2605712449, ; 138: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 108
	i32 2620871830, ; 139: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 60
	i32 2624644809, ; 140: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 65
	i32 2633051222, ; 141: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 74
	i32 2698266930, ; 142: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 17
	i32 2701096212, ; 143: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 90
	i32 2732626843, ; 144: Xamarin.AndroidX.Activity => 0xa2e0939b => 43
	i32 2736590120, ; 145: System.Data.OleDb => 0xa31d0d28 => 6
	i32 2737747696, ; 146: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 46
	i32 2751899777, ; 147: Xamarin.Android.Support.Collections => 0xa406a881 => 23
	i32 2770495804, ; 148: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 102
	i32 2778768386, ; 149: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 95
	i32 2779977773, ; 150: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 85
	i32 2788639665, ; 151: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 35
	i32 2788775637, ; 152: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 38
	i32 2810250172, ; 153: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 57
	i32 2819470561, ; 154: System.Xml.dll => 0xa80db4e1 => 12
	i32 2821294376, ; 155: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 85
	i32 2853208004, ; 156: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 95
	i32 2855708567, ; 157: Xamarin.AndroidX.Transition => 0xaa36a797 => 91
	i32 2876493027, ; 158: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 38
	i32 2887636118, ; 159: System.Net.dll => 0xac1dd496 => 8
	i32 2893257763, ; 160: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 14
	i32 2903344695, ; 161: System.ComponentModel.Composition => 0xad0d8637 => 116
	i32 2905242038, ; 162: mscorlib.dll => 0xad2a79b6 => 3
	i32 2916838712, ; 163: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 96
	i32 2919462931, ; 164: System.Numerics.Vectors.dll => 0xae037813 => 10
	i32 2921128767, ; 165: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 45
	i32 2921692953, ; 166: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 29
	i32 2922925221, ; 167: Xamarin.Android.Support.Vector.Drawable.dll => 0xae384ca5 => 40
	i32 2978675010, ; 168: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 64
	i32 2996846495, ; 169: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 75
	i32 3016983068, ; 170: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 88
	i32 3024354802, ; 171: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 71
	i32 3056250942, ; 172: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 22
	i32 3068715062, ; 173: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 15
	i32 3111772706, ; 174: System.Runtime.Serialization => 0xb979e222 => 117
	i32 3204380047, ; 175: System.Data.dll => 0xbefef58f => 5
	i32 3204912593, ; 176: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 22
	i32 3211777861, ; 177: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 63
	i32 3233339011, ; 178: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 16
	i32 3247949154, ; 179: Mono.Security => 0xc197c562 => 121
	i32 3258312781, ; 180: Xamarin.AndroidX.CardView => 0xc235e84d => 52
	i32 3267021929, ; 181: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 50
	i32 3296380511, ; 182: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 23
	i32 3317135071, ; 183: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 61
	i32 3317144872, ; 184: System.Data => 0xc5b79d28 => 5
	i32 3321585405, ; 185: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 30
	i32 3340431453, ; 186: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 49
	i32 3345895724, ; 187: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 83
	i32 3352662376, ; 188: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 25
	i32 3353484488, ; 189: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 70
	i32 3357663996, ; 190: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 28
	i32 3362522851, ; 191: Xamarin.AndroidX.Core => 0xc86c06e3 => 59
	i32 3366347497, ; 192: Java.Interop => 0xc8a662e9 => 1
	i32 3374999561, ; 193: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 84
	i32 3404865022, ; 194: System.ServiceModel.Internals => 0xcaf21dfe => 118
	i32 3405233483, ; 195: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 62
	i32 3429136800, ; 196: System.Xml => 0xcc6479a0 => 12
	i32 3430777524, ; 197: netstandard => 0xcc7d82b4 => 112
	i32 3439690031, ; 198: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 21
	i32 3441283291, ; 199: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 65
	i32 3476120550, ; 200: Mono.Android => 0xcf3163e6 => 2
	i32 3486566296, ; 201: System.Transactions => 0xcfd0c798 => 111
	i32 3493954962, ; 202: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 54
	i32 3501239056, ; 203: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 50
	i32 3509114376, ; 204: System.Xml.Linq => 0xd128d608 => 120
	i32 3547625832, ; 205: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 37
	i32 3567349600, ; 206: System.ComponentModel.Composition.dll => 0xd4a16f60 => 116
	i32 3627220390, ; 207: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 82
	i32 3633644679, ; 208: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 45
	i32 3641597786, ; 209: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 73
	i32 3664423555, ; 210: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 42
	i32 3672681054, ; 211: Mono.Android.dll => 0xdae8aa5e => 2
	i32 3676310014, ; 212: System.Web.Services.dll => 0xdb2009fe => 119
	i32 3678221644, ; 213: Xamarin.Android.Support.v7.AppCompat => 0xdb3d354c => 39
	i32 3681174138, ; 214: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 15
	i32 3682565725, ; 215: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 51
	i32 3684561358, ; 216: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 54
	i32 3689375977, ; 217: System.Drawing.Common => 0xdbe768e9 => 110
	i32 3706696989, ; 218: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 58
	i32 3714038699, ; 219: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 35
	i32 3718463572, ; 220: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0xdda34054 => 20
	i32 3718780102, ; 221: Xamarin.AndroidX.Annotation => 0xdda814c6 => 44
	i32 3776062606, ; 222: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 31
	i32 3786282454, ; 223: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 53
	i32 3829621856, ; 224: System.Numerics.dll => 0xe4436460 => 9
	i32 3832731800, ; 225: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 25
	i32 3862817207, ; 226: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 18
	i32 3874897629, ; 227: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 18
	i32 3883175360, ; 228: Xamarin.Android.Support.v7.AppCompat.dll => 0xe7748dc0 => 39
	i32 3885922214, ; 229: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 91
	i32 3888767677, ; 230: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 83
	i32 3896760992, ; 231: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 59
	i32 3920810846, ; 232: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 115
	i32 3921031405, ; 233: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 94
	i32 3945713374, ; 234: System.Data.DataSetExtensions.dll => 0xeb2ecede => 113
	i32 3955647286, ; 235: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 47
	i32 3959773229, ; 236: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 75
	i32 4063435586, ; 237: Xamarin.Android.Support.CustomView => 0xf2331b42 => 29
	i32 4101593132, ; 238: Xamarin.AndroidX.Emoji2 => 0xf479582c => 66
	i32 4105002889, ; 239: Mono.Security.dll => 0xf4ad5f89 => 121
	i32 4151237749, ; 240: System.Core => 0xf76edc75 => 4
	i32 4182413190, ; 241: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 78
	i32 4256097574, ; 242: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 58
	i32 4292120959 ; 243: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 78
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [244 x i32] [
	i32 76, i32 101, i32 41, i32 87, i32 87, i32 105, i32 13, i32 53, ; 0..7
	i32 24, i32 89, i32 14, i32 51, i32 71, i32 119, i32 56, i32 74, ; 8..15
	i32 69, i32 43, i32 9, i32 72, i32 20, i32 26, i32 55, i32 98, ; 16..23
	i32 68, i32 3, i32 7, i32 69, i32 80, i32 24, i32 36, i32 111, ; 24..31
	i32 105, i32 115, i32 61, i32 67, i32 8, i32 94, i32 48, i32 120, ; 32..39
	i32 107, i32 21, i32 102, i32 106, i32 114, i32 62, i32 33, i32 110, ; 40..47
	i32 82, i32 36, i32 101, i32 106, i32 72, i32 17, i32 86, i32 100, ; 48..55
	i32 47, i32 77, i32 104, i32 19, i32 7, i32 0, i32 97, i32 92, ; 56..63
	i32 48, i32 88, i32 93, i32 107, i32 28, i32 64, i32 16, i32 97, ; 64..71
	i32 118, i32 86, i32 57, i32 32, i32 114, i32 46, i32 27, i32 63, ; 72..79
	i32 13, i32 117, i32 100, i32 79, i32 96, i32 67, i32 60, i32 109, ; 80..87
	i32 11, i32 90, i32 99, i32 40, i32 56, i32 103, i32 52, i32 89, ; 88..95
	i32 4, i32 68, i32 79, i32 104, i32 99, i32 33, i32 98, i32 49, ; 96..103
	i32 19, i32 81, i32 103, i32 77, i32 42, i32 34, i32 73, i32 11, ; 104..111
	i32 10, i32 70, i32 0, i32 31, i32 6, i32 27, i32 41, i32 108, ; 112..119
	i32 109, i32 92, i32 80, i32 81, i32 84, i32 44, i32 26, i32 37, ; 120..127
	i32 32, i32 66, i32 34, i32 55, i32 112, i32 1, i32 30, i32 113, ; 128..135
	i32 76, i32 93, i32 108, i32 60, i32 65, i32 74, i32 17, i32 90, ; 136..143
	i32 43, i32 6, i32 46, i32 23, i32 102, i32 95, i32 85, i32 35, ; 144..151
	i32 38, i32 57, i32 12, i32 85, i32 95, i32 91, i32 38, i32 8, ; 152..159
	i32 14, i32 116, i32 3, i32 96, i32 10, i32 45, i32 29, i32 40, ; 160..167
	i32 64, i32 75, i32 88, i32 71, i32 22, i32 15, i32 117, i32 5, ; 168..175
	i32 22, i32 63, i32 16, i32 121, i32 52, i32 50, i32 23, i32 61, ; 176..183
	i32 5, i32 30, i32 49, i32 83, i32 25, i32 70, i32 28, i32 59, ; 184..191
	i32 1, i32 84, i32 118, i32 62, i32 12, i32 112, i32 21, i32 65, ; 192..199
	i32 2, i32 111, i32 54, i32 50, i32 120, i32 37, i32 116, i32 82, ; 200..207
	i32 45, i32 73, i32 42, i32 2, i32 119, i32 39, i32 15, i32 51, ; 208..215
	i32 54, i32 110, i32 58, i32 35, i32 20, i32 44, i32 31, i32 53, ; 216..223
	i32 9, i32 25, i32 18, i32 18, i32 39, i32 91, i32 83, i32 59, ; 224..231
	i32 115, i32 94, i32 113, i32 47, i32 75, i32 29, i32 66, i32 121, ; 232..239
	i32 4, i32 78, i32 58, i32 78 ; 240..243
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
