#pragma warning disable CS1591

using System.Runtime.InteropServices;

namespace Nnng.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FixedArray2<T> where T : unmanaged
    {
        public T Item0;
        public T Item1;
    }
}
