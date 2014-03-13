using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MapSwitcher
{
	[StructLayout(LayoutKind.Explicit, Size = 0xE80)]
	struct HotsPlayer
	{
		[FieldOffset(0x60)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		byte[] _PlayerName2;

		[FieldOffset(0xB8)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		byte[] _PlayerName;

		public string Name
		{
			get { return Encoding.UTF8.GetString(_PlayerName.TakeWhile(ret => ret != 0).ToArray()); }
		}

		public static int Size
		{
			get { return Marshal.SizeOf(typeof(HotsPlayer)); }
		}
	}
}
