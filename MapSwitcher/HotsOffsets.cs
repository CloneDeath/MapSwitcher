using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapSwitcher
{
	/*
	GameSpeed
	0.000244140625
	Slower  0   2457    0.599853515625
	Slow    1   3276    0.7998046875
	Normal  2   4096    1.00000
	Fast    3   4915    1.199951171875
	Faster  4   5734    1.39990234375
	*/
	class HotsOffsets
	{
		public readonly int Build;
		public readonly IntPtr PatchMapOffset1;
		public readonly IntPtr PatchMapOffset2;
		public readonly IntPtr PatchHeroOffset;
		public readonly IntPtr HotsPlayers;
		public readonly IntPtr AIDifficulty;
		public readonly IntPtr TalentsAutobuyOn;

		public HotsOffsets(int bld, int mo1, int mo2, int ho, int plrs, int ai, int tab)
		{
			Build = bld;
			PatchMapOffset1 = new IntPtr(mo1);
			PatchMapOffset2 = new IntPtr(mo2);
			PatchHeroOffset = new IntPtr(ho);
			HotsPlayers = new IntPtr(plrs); // array of type HotsPlayer[16]
			AIDifficulty = new IntPtr(ai);
			TalentsAutobuyOn = new IntPtr(tab);
		}
	}
}
