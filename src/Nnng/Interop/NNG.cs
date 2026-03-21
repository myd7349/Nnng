using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nnng.Interop
{
    internal static partial class NNG
    {
#if NETFRAMEWORK
        static NNG()
        {
            NativeLoader.EnsureLoaded();
        }
#endif

#if USE_LIBRARY_IMPORT
        [LibraryImport(LibraryName)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial nint nng_version();
#else
        [DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr nng_version();
#endif

        private const string LibraryName = "nng";
    }
}
