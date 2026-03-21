using System.Runtime.InteropServices;

using static Nnng.Interop.NNG;

namespace Nnng
{
    /// <summary>
    /// Provides managed wrappers for the nng (Nanomsg Next Generation) native library.
    /// </summary>
    public static class NNG
    {
        /// <summary>
        /// Returns the version string for the nng library.
        /// </summary>
        /// <returns>
        /// A string of the form <c>"major.minor.patch"</c>, or <see langword="null"/>
        /// if the native pointer is zero.
        /// </returns>
        public static string Version()
        {
            return Marshal.PtrToStringAnsi(nng_version());
        }
    }
}
