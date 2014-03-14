using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapSwitcher
{
	abstract class HotsOffsets
	{
		public readonly int Version;
		public readonly int Build;
		public readonly IntPtr PatchHeroOffset;
		public readonly int HeroStructSize;
		public readonly IntPtr AIDifficulty;
		public readonly int AIStructSize;
		public readonly Type HeroIDEnum;
		public readonly IntPtr TalentsAutobuyOn;


		public HotsOffsets(int Version, int BuildID, int HeroOffset, int HeroStructSize, int AIDifficulty, int AIStructSize, int TalentsAutoBuy, Type HeroIDs)
		{
			this.Version = Version;
			this.Build = BuildID;
			this.PatchHeroOffset = new IntPtr(HeroOffset);
			this.HeroStructSize = HeroStructSize;
			this.AIDifficulty = new IntPtr(AIDifficulty);
			this.AIStructSize = AIStructSize;
			this.TalentsAutobuyOn = new IntPtr(TalentsAutoBuy);
			this.HeroIDEnum = HeroIDs;
		}
	}
}
