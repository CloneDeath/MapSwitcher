using D3ZoomHack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MapSwitcher
{
    internal partial class MainForm : Form
    {
        IntPtr mapNamePtr;
        IntPtr oldMapPtr1;
        IntPtr oldMapPtr2;

        Random random = new Random();

        static readonly List<HotsOffsets> Offsets = new List<HotsOffsets>()
        {
			/*                 BUILD_ID Map_Offset1	Map_Offset2	Hero_Offset	PlayerLocation	AI_Offset	Talents_Autobuy	???		*/
            new HotsOffsets_V1(29049,	0x0140C680, 0x0140C687, 0x02E02E94, 0x04462B50,		0x0301D71C, 0x02314FE6),
            new HotsOffsets_V1(29108,	0x0140DF60, 0x0140DF67, 0x02E04E94, 0x04464B50,		0x0301F71C, 0x02316FE6),
			new HotsOffsets_V2(29360,							0x0302417B, 0x0446FFB0,		0x032802FD, 0x0232221B,		3720),
        };

		private AIDifficulty AlliedAI = AIDifficulty.HeroAIElite;
		private AIDifficulty EnemyAI = AIDifficulty.HeroAIElite;

        const int LocalPlayerIndex = 1;
        static readonly int NameOffset = (int)Marshal.OffsetOf(typeof(HotsPlayer), "_PlayerName");

        int[] Heroes = new int[10]
        {
            (int)HeroIDs_V1.Raynor, (int)HeroIDs_V1.Uther,  (int)HeroIDs_V1.DemonHunter, (int)HeroIDs_V1.Nova,		(int)HeroIDs_V1.Tyrael,
            (int)HeroIDs_V1.Diablo, (int)HeroIDs_V1.Arthas, (int)HeroIDs_V1.Illidan,	 (int)HeroIDs_V1.Malfurion, (int)HeroIDs_V1.WitchDoctor
        };

        ComboBox[] HeroComboBoxes = new ComboBox[10];

		public HotsOffsets SelectedVersion
		{
			get
			{
				return Offsets[cbVersions.SelectedIndex];
			}
		}

        public MainForm()
        {
            InitializeComponent();
			this.timer1.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
			for (int i = 0; i < Offsets.Count; i++){
				int num = cbVersions.Items.Add(Offsets[i].Build);

				/* Try to guess which version this is for */
				if (File.Exists(string.Format("Versions\\Base{0}\\Play.exe", Offsets[i].Build)))
					cbVersions.SelectedIndex = num;
			}

            HeroComboBoxes[0] = cbHeroDropdown1;
            HeroComboBoxes[1] = cbHeroDropdown2;
            HeroComboBoxes[2] = cbHeroDropdown3;
            HeroComboBoxes[3] = cbHeroDropdown4;
            HeroComboBoxes[4] = cbHeroDropdown5;
            HeroComboBoxes[5] = cbHeroDropdown6;
            HeroComboBoxes[6] = cbHeroDropdown7;
            HeroComboBoxes[7] = cbHeroDropdown8;
            HeroComboBoxes[8] = cbHeroDropdown9;
            HeroComboBoxes[9] = cbHeroDropdown10;

            cbAllyTeamAI.Items.AddRange(Enum.GetNames(typeof(AIDifficulty)));
			cbAllyTeamAI.SelectedIndex = (int)AlliedAI;

            cbEnemyTeamAI.Items.AddRange(Enum.GetNames(typeof(AIDifficulty)));
            cbEnemyTeamAI.SelectedIndex = (int)EnemyAI;

			cbVersions_SelectedIndexChanged(null, null); //Trigger UI Update
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
			InitProcess();

            try
            {
				if (SelectedVersion.Version == 1) {
					HotsOffsets_V1 CurrentVersion = SelectedVersion as HotsOffsets_V1;
					FileVersionInfo ver = Memory.CurrentProcess.MainModule.FileVersionInfo;

					if (ver.FilePrivatePart != Offsets[cbVersions.SelectedIndex].Build) {
						MessageBox.Show("Wrong or incompatible build selected! Patch failed.");
						return;
					}

					// Map patch
					byte[] mapName = Encoding.ASCII.GetBytes(cbMapSelect.SelectedItem + "\0\0\0");

					if (mapNamePtr == IntPtr.Zero)
						mapNamePtr = Memory.Alloc(mapName.Length);

					Memory.Write(mapNamePtr, mapName);

					oldMapPtr1 = Memory.Read<IntPtr>(CurrentVersion.PatchMapOffset1);
					oldMapPtr2 = Memory.Read<IntPtr>(CurrentVersion.PatchMapOffset2);

					Memory.Write<IntPtr>(CurrentVersion.PatchMapOffset1, mapNamePtr);
					Memory.Write<IntPtr>(CurrentVersion.PatchMapOffset2, mapNamePtr + mapName.Length - 3);

					
				}

				for (int i = 0; i < 10; ++i) {
					Heroes[i] = (int)Enum.Parse(SelectedVersion.HeroIDEnum, (string)HeroComboBoxes[i].SelectedItem);
				}

				AlliedAI = (AIDifficulty)Enum.Parse(typeof(AIDifficulty), (string)cbAllyTeamAI.SelectedItem);
				EnemyAI = (AIDifficulty)Enum.Parse(typeof(AIDifficulty), (string)cbEnemyTeamAI.SelectedItem);

				timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InitProcess()
        {
			Process[] processesByName = Process.GetProcessesByName("Play");

			if (processesByName.Length == 0)
            {
                MessageBox.Show("Play.exe isn't running! Please start Heroes of the Storm first.");
				return;
            }

			Memory.SetProcesses(processesByName);
            Memory.SelectProcess(0); // first process
            Memory.CurrentProcess.Exited += MainForm_ProcessExited;
        }

        void MainForm_ProcessExited(object sender, EventArgs e)
        {
            mapNamePtr = IntPtr.Zero;
            oldMapPtr1 = IntPtr.Zero;
            oldMapPtr2 = IntPtr.Zero;

            //MessageBox.Show("ProcessExited");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
				if (SelectedVersion.Version == 1) {
					HotsOffsets_V1 CurrentVersion = SelectedVersion as HotsOffsets_V1;

					if (oldMapPtr1 != IntPtr.Zero)
						Memory.Write<IntPtr>(CurrentVersion.PatchMapOffset1, oldMapPtr1);
					if (oldMapPtr2 != IntPtr.Zero)
						Memory.Write<IntPtr>(CurrentVersion.PatchMapOffset2, oldMapPtr2);
					if (mapNamePtr != IntPtr.Zero)
						Memory.FreeAll(mapNamePtr);
				}
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
				/* Hero Patch */
				for (int index = 0; index < 10; index++) {
					Memory.Write<byte>(SelectedVersion.PatchHeroOffset + index * SelectedVersion.HeroStructSize, (byte)this.Heroes[index]);
				}

				/* Talent Purchase */
				Memory.Write<byte>(SelectedVersion.TalentsAutobuyOn, cbUnlockTalents.Checked ? (byte)0 : (byte)1);

				for (int index = 0; index < 10; index++) {
					Memory.Write<int>(SelectedVersion.AIDifficulty + index * SelectedVersion.AIStructSize, index < 5 ? (int)AlliedAI : (int)EnemyAI);
				}
            }
            catch
            {
                timer1.Enabled = false;

                mapNamePtr = IntPtr.Zero;
                oldMapPtr1 = IntPtr.Zero;
                oldMapPtr2 = IntPtr.Zero;

                //MessageBox.Show("Hero id patch failed!");
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
			InitProcess();

            try
            {
                if (tbName.Text.Length > 0)
                {
					if (SelectedVersion.Version == 1) {
						HotsOffsets_V1 CurrentVersion = SelectedVersion as HotsOffsets_V1;
						IntPtr pPlayer = CurrentVersion.HotsPlayers + (LocalPlayerIndex * HotsPlayer.Size);
						Memory.WriteCString(pPlayer + NameOffset, tbName.Text);
					} else if (SelectedVersion.Version >= 2) {
						HotsOffsets_V2 CurrentVersion = SelectedVersion as HotsOffsets_V2;
						IntPtr pPlayer = CurrentVersion.HotsPlayers + CurrentVersion.f;
						Memory.WriteCString(pPlayer + 96, this.tbName.Text);
						Memory.WriteCString(pPlayer + 184, this.tbName.Text);
					}
                }
            }
            catch
            {
                MessageBox.Show("Name change failed!");
            }
        }

        private void btnRandomHeroes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
				Heroes[i] = random.Next(1, Enum.GetValues(SelectedVersion.HeroIDEnum).Length + 1);
                HeroComboBoxes[i].SelectedIndex = (int)Heroes[i] - 1;
            }
        }

		private void cbVersions_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnStartGame.Enabled = false;
			btnLoadMap.Enabled = false;
			btnApply.Enabled = false;
			cbMapSelect.Enabled = false;
			btnRandomHeroes.Enabled = false;
			cbMapSelect.Items.Clear();
			btnChangeName.Enabled = false;
			cbAllyTeamAI.Enabled = false;
			cbEnemyTeamAI.Enabled = false;
			cbUnlockTalents.Enabled = false;
			for (int i = 0; i < 10; i++) {
				HeroComboBoxes[i].Items.Clear();
				HeroComboBoxes[i].Enabled = false;
			}
			if (cbVersions.SelectedIndex == -1) return;


			btnRandomHeroes.Enabled = true;
			btnChangeName.Enabled = true;
			cbUnlockTalents.Enabled = true;
			cbAllyTeamAI.Enabled = true;
			cbEnemyTeamAI.Enabled = true;
			cbMapSelect.Enabled = true;
			if (SelectedVersion.Version == 1) {
				btnStartGame.Enabled = false;
				btnLoadMap.Enabled = false;

				cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/PracticeMode01.StormMap");
				cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/Tutorial01.StormMap");
				cbMapSelect.Items.Add("Heroes/BuiltIn/(10)TryMeMode.StormMap");
			}
			if (SelectedVersion.Version >= 2) {
				btnStartGame.Enabled = true;
				btnLoadMap.Enabled = true;
				
				cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/Practice01.StormMap");
				cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/Tutorial01.StormMap");
				cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/Tutorial02.StormMap");
				cbMapSelect.Items.Add("Heroes/BuiltIn/(10)TryMeMode.StormMap");
			}
			/* Possibly new maps in the future? */
			//cbMapSelect.Items.Add("Heroes/StartingExperience/BAS-SE01.StormMap");
			//cbMapSelect.Items.Add("Maps/Heroes/(10)CursedHollow.StormMap");
			//cbMapSelect.Items.Add("Maps/Heroes/(10)BlackhearthsBay.StormMap");
			//cbMapSelect.Items.Add("Maps/Heroes/(10)DragonShire.StormMap");
			//cbMapSelect.Items.Add("Maps/Heroes/(10)HauntedMines.StormMap");
			cbMapSelect.SelectedIndex = 0;

			for (int i = 0; i < 10; ++i) {
				HeroComboBoxes[i].Enabled = true;
				HeroComboBoxes[i].Items.AddRange(Enum.GetNames(SelectedVersion.HeroIDEnum));
				HeroComboBoxes[i].SelectedIndex = Heroes[i] - 1;
			}

			btnApply.Enabled = true;
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			this.RunStormLauncher(1);
		}

		private void btnLoadMap_Click(object sender, EventArgs e)
		{
			this.RunStormLauncher(2);
		}

		private void RunStormLauncher(int Mode)
		{
			if (SelectedVersion.Version < 2 || !File.Exists(string.Format("Versions\\Base{0}\\Play.exe", SelectedVersion.Build))) {
				MessageBox.Show("Required files are missing.\nMake sure this program located in game's root folder.", 
					"Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			} else {
				Process.Start("StormLauncher.exe", string.Format("{0} {1} {2}", (object)Mode, (object)SelectedVersion.Build, this.cbMapSelect.SelectedItem)).WaitForExit();
				InitProcess();
				if (Mode == 2) {
					this.timer1.Enabled = true;
				}
			}
		}
    }
}

