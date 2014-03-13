using D3ZoomHack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MapSwitcher
{
    public partial class MainForm : Form
    {
        AIDifficulty yourAI;
        AIDifficulty enemyAI;

        IntPtr mapNamePtr;
        IntPtr oldMapPtr1;
        IntPtr oldMapPtr2;

        Random random = new Random();

        static readonly List<HotsOffsets> Offsets = new List<HotsOffsets>()
        {
            new HotsOffsets(29049, 0x0140C680, 0x0140C687, 0x02E02E94, 0x04462B50, 0x0301D71C, 0x02314FE6),
            new HotsOffsets(29108, 0x0140DF60, 0x0140DF67, 0x02E04E94, 0x04464B50, 0x0301F71C, 0x02316FE6)
        };

        const int AIStructSize = 0x197;
        const int HeroesStructSize = 0x2042C;

        const int LocalPlayerIndex = 1;
        static readonly int NameOffset = (int)Marshal.OffsetOf(typeof(HotsPlayer), "_PlayerName");

        HeroIDs[] Heroes = new HeroIDs[10]
        {
            HeroIDs.Raynor, HeroIDs.Uther, HeroIDs.DemonHunter, HeroIDs.Nova, HeroIDs.Tyrael,
            HeroIDs.Diablo, HeroIDs.Arthas, HeroIDs.Illidan, HeroIDs.Malfurion, HeroIDs.WitchDoctor
        };

        ComboBox[] HeroComboBoxes = new ComboBox[10];

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/Tutorial01.StormMap");
            cbMapSelect.Items.Add("Heroes/BuiltIn/StartingExperience/PracticeMode01.StormMap");
            cbMapSelect.Items.Add("Heroes/BuiltIn/(10)TryMeMode.StormMap");
            //cbMapSelect.Items.Add("Heroes/StartingExperience/BAS-SE01.StormMap");
            //cbMapSelect.Items.Add("Maps/Heroes/(10)CursedHollow.StormMap");
            //cbMapSelect.Items.Add("Maps/Heroes/(10)BlackhearthsBay.StormMap");
            //cbMapSelect.Items.Add("Maps/Heroes/(10)DragonShire.StormMap");
            //cbMapSelect.Items.Add("Maps/Heroes/(10)HauntedMines.StormMap");
            cbMapSelect.SelectedIndex = 1;

            HeroComboBoxes[0] = comboBox2;
            HeroComboBoxes[1] = comboBox6;
            HeroComboBoxes[2] = comboBox7;
            HeroComboBoxes[3] = comboBox8;
            HeroComboBoxes[4] = comboBox9;
            HeroComboBoxes[5] = comboBox14;
            HeroComboBoxes[6] = comboBox13;
            HeroComboBoxes[7] = comboBox12;
            HeroComboBoxes[8] = comboBox11;
            HeroComboBoxes[9] = comboBox10;

            for (int i = 0; i < 10; ++i)
            {
                HeroComboBoxes[i].Items.AddRange(Enum.GetNames(typeof(HeroIDs)));
                HeroComboBoxes[i].SelectedIndex = (int)Heroes[i] - 1;
            }

            foreach (var offset in Offsets)
            {
                comboBox3.Items.Add(offset.Build);
            }

            comboBox3.SelectedIndex = 1;

            comboBox4.Items.AddRange(Enum.GetNames(typeof(AIDifficulty)));
            comboBox4.SelectedIndex = 9;

            comboBox5.Items.AddRange(Enum.GetNames(typeof(AIDifficulty)));
            comboBox5.SelectedIndex = 8;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!InitProcess())
                return;

            try
            {
                FileVersionInfo ver = Memory.CurrentProcess.MainModule.FileVersionInfo;

                if (ver.FilePrivatePart != Offsets[comboBox3.SelectedIndex].Build)
                {
                    MessageBox.Show("Wrong or incompatible build selected! Patch failed.");
                    return;
                }

                // Map patch
                byte[] mapName = Encoding.ASCII.GetBytes(cbMapSelect.SelectedItem + "\0\0\0");

                if (mapNamePtr == IntPtr.Zero)
                    mapNamePtr = Memory.Alloc(mapName.Length);

                Memory.Write(mapNamePtr, mapName);

                oldMapPtr1 = Memory.Read<IntPtr>(Offsets[comboBox3.SelectedIndex].PatchMapOffset1);
                oldMapPtr2 = Memory.Read<IntPtr>(Offsets[comboBox3.SelectedIndex].PatchMapOffset2);

                Memory.Write<IntPtr>(Offsets[comboBox3.SelectedIndex].PatchMapOffset1, mapNamePtr);
                Memory.Write<IntPtr>(Offsets[comboBox3.SelectedIndex].PatchMapOffset2, mapNamePtr + mapName.Length - 3);

                for (int i = 0; i < 10; ++i)
                {
                    Heroes[i] = (HeroIDs)Enum.Parse(typeof(HeroIDs), (string)HeroComboBoxes[i].SelectedItem);
                }

                yourAI = (AIDifficulty)Enum.Parse(typeof(AIDifficulty), (string)comboBox4.SelectedItem);
                enemyAI = (AIDifficulty)Enum.Parse(typeof(AIDifficulty), (string)comboBox5.SelectedItem);

                timer1.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private bool InitProcess()
        {
            var p = Process.GetProcessesByName("Play");

            if (p.Length == 0)
            {
                MessageBox.Show("Play.exe isn't running! Please start Heroes of the Storm first.");
                return false;
            }

            Memory.SetProcesses(p);

            Memory.SelectProcess(0); // first process

            Memory.CurrentProcess.Exited += Form1_ProcessExited;

            return true;
        }

        void Form1_ProcessExited(object sender, EventArgs e)
        {
            mapNamePtr = IntPtr.Zero;
            oldMapPtr1 = IntPtr.Zero;
            oldMapPtr2 = IntPtr.Zero;

            //MessageBox.Show("ProcessExited");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (oldMapPtr1 != IntPtr.Zero)
                    Memory.Write<IntPtr>(Offsets[comboBox3.SelectedIndex].PatchMapOffset1, oldMapPtr1);
                if (oldMapPtr2 != IntPtr.Zero)
                    Memory.Write<IntPtr>(Offsets[comboBox3.SelectedIndex].PatchMapOffset2, oldMapPtr2);
                if (mapNamePtr != IntPtr.Zero)
                    Memory.FreeAll(mapNamePtr);
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Hero patch
                for (int i = 0; i < 10; ++i)
                {
                    Memory.Write<byte>(Offsets[comboBox3.SelectedIndex].PatchHeroOffset + i * HeroesStructSize, (byte)Heroes[i]);
                }

                // Talents auto buy (thanks Simca!)
                Memory.Write<byte>(Offsets[comboBox3.SelectedIndex].TalentsAutobuyOn, checkBox2.Checked ? (byte)0 : (byte)1);

                // AI patch
                for (int i = 0; i < 10; i++)
                {
                    Memory.Write<int>(Offsets[comboBox3.SelectedIndex].AIDifficulty + i * AIStructSize, i < 5 ? (int)yourAI : (int)enemyAI);
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
            if (!InitProcess())
                return;

            try
            {
                if (textBox1.Text.Length > 0)
                {
                    IntPtr pPlayer = Offsets[comboBox3.SelectedIndex].HotsPlayers + LocalPlayerIndex * HotsPlayer.Size;
                    Memory.WriteCString(pPlayer + NameOffset, textBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show("Name change failed!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                Heroes[i] = (HeroIDs)random.Next(1, Enum.GetValues(typeof(HeroIDs)).Length + 1);
                HeroComboBoxes[i].SelectedIndex = (int)Heroes[i] - 1;
            }
        }
    }
}

