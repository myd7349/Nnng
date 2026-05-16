#pragma warning disable CS1591

namespace Nnng.Interop
{
    public static partial class NngNative
    {
#if NETFRAMEWORK
        static NngNative()
        {
            NativeLoader.EnsureLoaded();
        }
#endif
    }
}
