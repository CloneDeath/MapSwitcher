using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace D3ZoomHack
{
    [Flags]
    public enum AllocationType : int
    {
        Commit = 0x1000,
        Reserve = 0x2000,
        Decommit = 0x4000,
        Release = 0x8000,
        Reset = 0x80000,
        Physical = 0x400000,
        TopDown = 0x100000,
        WriteWatch = 0x200000,
        LargePages = 0x20000000
    }

    [Flags]
    public enum MemoryProtection : int
    {
        Execute = 0x10,
        ExecuteRead = 0x20,
        ExecuteReadWrite = 0x40,
        ExecuteWriteCopy = 0x80,
        NoAccess = 0x01,
        ReadOnly = 0x02,
        ReadWrite = 0x04,
        WriteCopy = 0x08,
        GuardModifierflag = 0x100,
        NoCacheModifierflag = 0x200,
        WriteCombineModifierflag = 0x400
    }

    class Memory
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, IntPtr dwSize, IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocationType dwFreeType);

        private static Process[] processes;
        private static int SelectedProcess = 0;

        public static IntPtr BaseAddress
        {
            get
            {
                return processes[SelectedProcess].MainModule.BaseAddress;
            }
        }

        public static Process CurrentProcess
        {
            get
            {
                return processes[SelectedProcess];
            }
        }

        public static void SetProcesses(Process[] _processes)
        {
            processes = _processes;

            foreach (var p in processes)
                p.EnableRaisingEvents = true;
        }

        public static void SelectProcess(int index)
        {
            SelectedProcess = index;
        }

        #region Write Methods
        public static bool Write(IntPtr offset, byte[] data)
        {
            bool result = WriteProcessMemory(processes[SelectedProcess].Handle, offset, data, new IntPtr(data.Length), IntPtr.Zero);
            if (!result)
                throw new Win32Exception();
            return result;
        }

        public static void Write<T>(IntPtr offset, T value) where T : struct
        {
            byte[] buffer = new byte[Marshal.SizeOf(value)];
            IntPtr hObj = Marshal.AllocHGlobal(buffer.Length);
            try
            {
                Marshal.StructureToPtr(value, hObj, false);
                Marshal.Copy(hObj, buffer, 0, buffer.Length);
                Write(offset, buffer);
            }
            finally
            {
                Marshal.FreeHGlobal(hObj);
            }
        }

        // Chain pointers write
        public static void Write<T>(IntPtr baseAddr, T value, bool readbase, params int[] offsets) where T : struct
        {
            IntPtr ptr;
            if (readbase)
                ptr = Read<IntPtr>(baseAddr);
            else
                ptr = baseAddr;

            if (ptr != IntPtr.Zero)
            {
                for (int i = 0; i < offsets.Length; ++i)
                {
                    if (i == offsets.Length - 1)
                    {
                        Write<T>(new IntPtr(ptr.ToInt64() + offsets[i]), value);
                        return;
                    }

                    ptr = Read<IntPtr>(new IntPtr(ptr.ToInt64() + offsets[i]));

                    if (ptr == IntPtr.Zero)
                        break;
                }
            }
        }

        public static bool WriteCString(IntPtr offset, string str)
        {
            return Write(offset, Encoding.UTF8.GetBytes(str + '\0'));
        }
        #endregion

        #region Read Methods
        public static byte[] Read(IntPtr offset, int length)
        {
            var result = new byte[length];
            if (!ReadProcessMemory(processes[SelectedProcess].Handle, offset, result, new IntPtr(length), IntPtr.Zero))
                throw new Win32Exception();
            return result;
        }

        public static T Read<T>(IntPtr offset) where T : struct
        {
            byte[] result = new byte[Marshal.SizeOf(typeof(T))];
            if (!ReadProcessMemory(processes[SelectedProcess].Handle, offset, result, new IntPtr(result.Length), IntPtr.Zero))
                throw new Win32Exception();
            GCHandle handle = GCHandle.Alloc(result, GCHandleType.Pinned);
            T returnObject = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return returnObject;
        }

        // Chain pointers read
        public static T Read<T>(IntPtr baseAddr, bool readbase, params int[] offsets) where T : struct
        {
            IntPtr ptr;
            if (readbase)
                ptr = Read<IntPtr>(baseAddr);
            else
                ptr = baseAddr;

            if (ptr != IntPtr.Zero)
            {
                for (int i = 0; i < offsets.Length; ++i)
                {
                    if (i == offsets.Length - 1)
                        return Read<T>(new IntPtr(ptr.ToInt64() + offsets[i]));

                    ptr = Read<IntPtr>(new IntPtr(ptr.ToInt64() + offsets[i]));

                    if (ptr == IntPtr.Zero)
                        break;
                }
            }

            return default(T);
        }

        public static string ReadCString(IntPtr baseAddr, int maxLen = 255)
        {
            return Encoding.UTF8.GetString(Read(baseAddr, maxLen).TakeWhile(ret => ret != 0).ToArray());
        }
        #endregion

        #region Alloc Methods
        public static IntPtr Alloc(int size)
        {
            return VirtualAllocEx(processes[SelectedProcess].Handle, IntPtr.Zero, new IntPtr(size), AllocationType.Reserve | AllocationType.Commit, MemoryProtection.ExecuteReadWrite);
        }

        public static void FreeAll(IntPtr mem)
        {
            VirtualFreeEx(processes[SelectedProcess].Handle, mem, 0, AllocationType.Release);
        }
        #endregion
    }
}
