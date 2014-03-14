using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapSwitcher
{
	class HotsOffsets_V2 : HotsOffsets
	{
		
		public readonly IntPtr HotsPlayers;
		public readonly int f;

		public HotsOffsets_V2(int BuildID, int HeroOffset, int A_2, int AIDifficulty, int TalentsAutobuy, int A_5)
			: base(2, BuildID, HeroOffset, 0x2582D, AIDifficulty, 0x1A1, TalentsAutobuy, typeof(HeroIDs_V2))
		{
			this.HotsPlayers = new IntPtr(A_2);
			this.f = A_5;
		}
	}
}
