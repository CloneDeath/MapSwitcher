using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapSwitcher
{
	class HotsOffsets_V1 : HotsOffsets
	{
		public readonly IntPtr PatchMapOffset1;
		public readonly IntPtr PatchMapOffset2;
		public readonly IntPtr PatchHeroOffset;
		public readonly IntPtr HotsPlayers;
		

		public HotsOffsets_V1(int BuildID, int MapOffset1, int MapOffset2, int HeroOffset, int PlayerLocation, int AIDifficulty, int TalentAutoBuy)
			: base(1, BuildID, HeroOffset, 0x2042C, AIDifficulty, 0x197, TalentAutoBuy, typeof(HeroIDs_V1))
		{
			this.PatchMapOffset1 = new IntPtr(MapOffset1);
			this.PatchMapOffset2 = new IntPtr(MapOffset2);
			this.PatchHeroOffset = new IntPtr(HeroOffset);
			this.HotsPlayers = new IntPtr(PlayerLocation); // array of type HotsPlayer[16]			
		}
	}
}
