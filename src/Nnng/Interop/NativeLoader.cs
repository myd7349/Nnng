#if NETFRAMEWORK
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Nnng.Interop
{
    internal static class NativeLoader
    {
        internal static void EnsureLoaded()
        {
            if (_loaded)
                return;

            lock (_syncRoot)
            {
                if (_loaded)
                    return;

                Load();
                _loaded = true;
            }
        }

        private static void Load()
        {
            string assemblyDirectory = Path.GetDirectoryName(typeof(NativeLoader).Assembly.Location);
            if (string.IsNullOrEmpty(assemblyDirectory))
                return;

            // Prefer architecture-specific subdirectory (x64\ or x86\) so that
            // both bitness variants can coexist in the output folder —
            // the same layout used by System.Data.SQLite / SQLitePCL.raw.
            string platform = IntPtr.Size == 8 ? "x64" : "x86";
#if NET35
            string dllPath = Path.Combine(Path.Combine(assemblyDirectory, platform), LibraryName);
#else
            string dllPath = Path.Combine(assemblyDirectory, platform, LibraryName);
#endif

            if (!File.Exists(dllPath))
            {
                // Fall back to the assembly directory itself (legacy flat layout).
                dllPath = Path.Combine(assemblyDirectory, LibraryName);
                if (!File.Exists(dllPath))
                    return;
            }

            Debug.WriteLine($"Load nng runtime library: {dllPath}...");

            // Pre-loading the DLL with its full path registers it in the
            // process module list under the bare name "nng.dll". Any
            // subsequent DllImport("nng") call will then find it without
            // searching the DLL search path at all.
            // LOAD_WITH_ALTERED_SEARCH_PATH makes the DLL's own directory the
            // base for resolving its transitive dependencies.
            LoadLibraryExW(dllPath, IntPtr.Zero, LOAD_WITH_ALTERED_SEARCH_PATH);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr LoadLibraryExW(string lpLibFileName, IntPtr hFile, uint dwFlags);

        // Instructs the loader to use the DLL's own directory as the search
        // path for its dependencies, rather than the application directory.
        private const uint LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008;

        private const string LibraryName = "nng.dll";

        private static readonly object _syncRoot = new object();
        private static bool _loaded;
    }
}
#endif
