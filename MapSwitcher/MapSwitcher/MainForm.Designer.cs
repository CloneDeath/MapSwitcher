namespace MapSwitcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnApply = new System.Windows.Forms.Button();
			this.cbMapSelect = new System.Windows.Forms.ComboBox();
			this.cbHeroDropdown1 = new System.Windows.Forms.ComboBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnChangeName = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cbVersions = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRandomHeroes = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cbHeroDropdown10 = new System.Windows.Forms.ComboBox();
			this.cbHeroDropdown9 = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cbHeroDropdown8 = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cbHeroDropdown7 = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cbHeroDropdown6 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cbHeroDropdown5 = new System.Windows.Forms.ComboBox();
			this.cbHeroDropdown4 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbHeroDropdown3 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbHeroDropdown2 = new System.Windows.Forms.ComboBox();
			this.cbUnlockTalents = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnLoadMap = new System.Windows.Forms.Button();
			this.btnStartGame = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbEnemyTeamAI = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbAllyTeamAI = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(344, 452);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(94, 23);
			this.btnApply.TabIndex = 0;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// cbMapSelect
			// 
			this.cbMapSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMapSelect.FormattingEnabled = true;
			this.cbMapSelect.Location = new System.Drawing.Point(62, 20);
			this.cbMapSelect.Name = "cbMapSelect";
			this.cbMapSelect.Size = new System.Drawing.Size(349, 21);
			this.cbMapSelect.TabIndex = 1;
			// 
			// cbHeroDropdown1
			// 
			this.cbHeroDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown1.FormattingEnabled = true;
			this.cbHeroDropdown1.Location = new System.Drawing.Point(62, 47);
			this.cbHeroDropdown1.Name = "cbHeroDropdown1";
			this.cbHeroDropdown1.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown1.TabIndex = 2;
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(62, 19);
			this.tbName.MaxLength = 40;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(146, 20);
			this.tbName.TabIndex = 3;
			this.tbName.Text = "Local Player";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Map:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Hero 1:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Name:";
			// 
			// btnChangeName
			// 
			this.btnChangeName.Location = new System.Drawing.Point(214, 17);
			this.btnChangeName.Name = "btnChangeName";
			this.btnChangeName.Size = new System.Drawing.Size(97, 23);
			this.btnChangeName.TabIndex = 7;
			this.btnChangeName.Text = "Change name";
			this.btnChangeName.UseVisualStyleBackColor = true;
			this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Version:";
			// 
			// cbVersions
			// 
			this.cbVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbVersions.FormattingEnabled = true;
			this.cbVersions.Location = new System.Drawing.Point(62, 19);
			this.cbVersions.Name = "cbVersions";
			this.cbVersions.Size = new System.Drawing.Size(146, 21);
			this.cbVersions.TabIndex = 9;
			this.cbVersions.SelectedIndexChanged += new System.EventHandler(this.cbVersions_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRandomHeroes);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.cbHeroDropdown10);
			this.groupBox1.Controls.Add(this.cbHeroDropdown9);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cbHeroDropdown8);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.cbHeroDropdown7);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.cbHeroDropdown6);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.cbHeroDropdown5);
			this.groupBox1.Controls.Add(this.cbHeroDropdown4);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cbHeroDropdown3);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cbHeroDropdown2);
			this.groupBox1.Controls.Add(this.cbUnlockTalents);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbMapSelect);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbHeroDropdown1);
			this.groupBox1.Location = new System.Drawing.Point(12, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(426, 219);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Map and Heroes";
			// 
			// btnRandomHeroes
			// 
			this.btnRandomHeroes.Location = new System.Drawing.Point(265, 182);
			this.btnRandomHeroes.Name = "btnRandomHeroes";
			this.btnRandomHeroes.Size = new System.Drawing.Size(146, 23);
			this.btnRandomHeroes.TabIndex = 25;
			this.btnRandomHeroes.Text = "Randomize Heroes";
			this.btnRandomHeroes.UseVisualStyleBackColor = true;
			this.btnRandomHeroes.Click += new System.EventHandler(this.btnRandomHeroes_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(214, 158);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "Hero 10:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(214, 131);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "Hero 9:";
			// 
			// cbHeroDropdown10
			// 
			this.cbHeroDropdown10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown10.FormattingEnabled = true;
			this.cbHeroDropdown10.Location = new System.Drawing.Point(265, 155);
			this.cbHeroDropdown10.Name = "cbHeroDropdown10";
			this.cbHeroDropdown10.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown10.TabIndex = 22;
			// 
			// cbHeroDropdown9
			// 
			this.cbHeroDropdown9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown9.FormattingEnabled = true;
			this.cbHeroDropdown9.Location = new System.Drawing.Point(265, 128);
			this.cbHeroDropdown9.Name = "cbHeroDropdown9";
			this.cbHeroDropdown9.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown9.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(214, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(42, 13);
			this.label13.TabIndex = 20;
			this.label13.Text = "Hero 8:";
			// 
			// cbHeroDropdown8
			// 
			this.cbHeroDropdown8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown8.FormattingEnabled = true;
			this.cbHeroDropdown8.Location = new System.Drawing.Point(265, 101);
			this.cbHeroDropdown8.Name = "cbHeroDropdown8";
			this.cbHeroDropdown8.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown8.TabIndex = 19;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(214, 77);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 13);
			this.label14.TabIndex = 18;
			this.label14.Text = "Hero 7:";
			// 
			// cbHeroDropdown7
			// 
			this.cbHeroDropdown7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown7.FormattingEnabled = true;
			this.cbHeroDropdown7.Location = new System.Drawing.Point(265, 74);
			this.cbHeroDropdown7.Name = "cbHeroDropdown7";
			this.cbHeroDropdown7.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown7.TabIndex = 17;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(214, 51);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(42, 13);
			this.label15.TabIndex = 16;
			this.label15.Text = "Hero 6:";
			// 
			// cbHeroDropdown6
			// 
			this.cbHeroDropdown6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown6.FormattingEnabled = true;
			this.cbHeroDropdown6.Location = new System.Drawing.Point(265, 47);
			this.cbHeroDropdown6.Name = "cbHeroDropdown6";
			this.cbHeroDropdown6.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown6.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(11, 158);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "Hero 5:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 131);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Hero 4:";
			// 
			// cbHeroDropdown5
			// 
			this.cbHeroDropdown5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown5.FormattingEnabled = true;
			this.cbHeroDropdown5.Location = new System.Drawing.Point(62, 155);
			this.cbHeroDropdown5.Name = "cbHeroDropdown5";
			this.cbHeroDropdown5.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown5.TabIndex = 12;
			// 
			// cbHeroDropdown4
			// 
			this.cbHeroDropdown4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown4.FormattingEnabled = true;
			this.cbHeroDropdown4.Location = new System.Drawing.Point(62, 128);
			this.cbHeroDropdown4.Name = "cbHeroDropdown4";
			this.cbHeroDropdown4.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown4.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Hero 3:";
			// 
			// cbHeroDropdown3
			// 
			this.cbHeroDropdown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown3.FormattingEnabled = true;
			this.cbHeroDropdown3.Location = new System.Drawing.Point(62, 101);
			this.cbHeroDropdown3.Name = "cbHeroDropdown3";
			this.cbHeroDropdown3.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown3.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Hero 2:";
			// 
			// cbHeroDropdown2
			// 
			this.cbHeroDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeroDropdown2.FormattingEnabled = true;
			this.cbHeroDropdown2.Location = new System.Drawing.Point(62, 74);
			this.cbHeroDropdown2.Name = "cbHeroDropdown2";
			this.cbHeroDropdown2.Size = new System.Drawing.Size(146, 21);
			this.cbHeroDropdown2.TabIndex = 7;
			// 
			// cbUnlockTalents
			// 
			this.cbUnlockTalents.AutoSize = true;
			this.cbUnlockTalents.Checked = true;
			this.cbUnlockTalents.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUnlockTalents.Location = new System.Drawing.Point(14, 186);
			this.cbUnlockTalents.Name = "cbUnlockTalents";
			this.cbUnlockTalents.Size = new System.Drawing.Size(98, 17);
			this.cbUnlockTalents.TabIndex = 6;
			this.cbUnlockTalents.Text = "Unlock Talents";
			this.cbUnlockTalents.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbName);
			this.groupBox2.Controls.Add(this.btnChangeName);
			this.groupBox2.Location = new System.Drawing.Point(12, 298);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(426, 55);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Name";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnLoadMap);
			this.groupBox3.Controls.Add(this.btnStartGame);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.cbVersions);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(426, 55);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Game Version";
			// 
			// btnLoadMap
			// 
			this.btnLoadMap.Location = new System.Drawing.Point(298, 17);
			this.btnLoadMap.Name = "btnLoadMap";
			this.btnLoadMap.Size = new System.Drawing.Size(75, 23);
			this.btnLoadMap.TabIndex = 11;
			this.btnLoadMap.Text = "LoadMap";
			this.btnLoadMap.UseVisualStyleBackColor = true;
			this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
			// 
			// btnStartGame
			// 
			this.btnStartGame.Location = new System.Drawing.Point(217, 17);
			this.btnStartGame.Name = "btnStartGame";
			this.btnStartGame.Size = new System.Drawing.Size(75, 23);
			this.btnStartGame.TabIndex = 10;
			this.btnStartGame.Text = "Start Game";
			this.btnStartGame.UseVisualStyleBackColor = true;
			this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbEnemyTeamAI);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.cbAllyTeamAI);
			this.groupBox4.Location = new System.Drawing.Point(12, 359);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(426, 87);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "AI Difficulty";
			// 
			// cbEnemyTeamAI
			// 
			this.cbEnemyTeamAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEnemyTeamAI.FormattingEnabled = true;
			this.cbEnemyTeamAI.Location = new System.Drawing.Point(87, 47);
			this.cbEnemyTeamAI.Name = "cbEnemyTeamAI";
			this.cbEnemyTeamAI.Size = new System.Drawing.Size(160, 21);
			this.cbEnemyTeamAI.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Enemy team:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Your team:";
			// 
			// cbAllyTeamAI
			// 
			this.cbAllyTeamAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAllyTeamAI.FormattingEnabled = true;
			this.cbAllyTeamAI.Location = new System.Drawing.Point(87, 20);
			this.cbAllyTeamAI.Name = "cbAllyTeamAI";
			this.cbAllyTeamAI.Size = new System.Drawing.Size(160, 21);
			this.cbAllyTeamAI.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 482);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnApply);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "HotS Patcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cbMapSelect;
        private System.Windows.Forms.ComboBox cbHeroDropdown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVersions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbEnemyTeamAI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbAllyTeamAI;
        private System.Windows.Forms.CheckBox cbUnlockTalents;
        private System.Windows.Forms.Button btnRandomHeroes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbHeroDropdown10;
        private System.Windows.Forms.ComboBox cbHeroDropdown9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbHeroDropdown8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbHeroDropdown7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbHeroDropdown6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbHeroDropdown5;
        private System.Windows.Forms.ComboBox cbHeroDropdown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbHeroDropdown3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHeroDropdown2;
		private System.Windows.Forms.Button btnLoadMap;
		private System.Windows.Forms.Button btnStartGame;
    }
}

