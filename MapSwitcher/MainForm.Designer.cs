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
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnChangeName = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.comboBox11 = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.comboBox12 = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.comboBox13 = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.comboBox14 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
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
			// comboBox1
			// 
			this.cbMapSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMapSelect.FormattingEnabled = true;
			this.cbMapSelect.Location = new System.Drawing.Point(62, 20);
			this.cbMapSelect.Name = "comboBox1";
			this.cbMapSelect.Size = new System.Drawing.Size(349, 21);
			this.cbMapSelect.TabIndex = 1;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(62, 47);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(146, 21);
			this.comboBox2.TabIndex = 2;
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(62, 19);
			this.textBox1.MaxLength = 40;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(146, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "Local Player";
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
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(62, 19);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(146, 21);
			this.comboBox3.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.comboBox10);
			this.groupBox1.Controls.Add(this.comboBox11);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.comboBox12);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.comboBox13);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.comboBox14);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.comboBox9);
			this.groupBox1.Controls.Add(this.comboBox8);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.comboBox7);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.comboBox6);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbMapSelect);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(426, 219);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Map and Heroes";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(265, 182);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(146, 23);
			this.button4.TabIndex = 25;
			this.button4.Text = "Randomize heroes";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			// comboBox10
			// 
			this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox10.FormattingEnabled = true;
			this.comboBox10.Location = new System.Drawing.Point(265, 155);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(146, 21);
			this.comboBox10.TabIndex = 22;
			// 
			// comboBox11
			// 
			this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox11.FormattingEnabled = true;
			this.comboBox11.Location = new System.Drawing.Point(265, 128);
			this.comboBox11.Name = "comboBox11";
			this.comboBox11.Size = new System.Drawing.Size(146, 21);
			this.comboBox11.TabIndex = 21;
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
			// comboBox12
			// 
			this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox12.FormattingEnabled = true;
			this.comboBox12.Location = new System.Drawing.Point(265, 101);
			this.comboBox12.Name = "comboBox12";
			this.comboBox12.Size = new System.Drawing.Size(146, 21);
			this.comboBox12.TabIndex = 19;
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
			// comboBox13
			// 
			this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox13.FormattingEnabled = true;
			this.comboBox13.Location = new System.Drawing.Point(265, 74);
			this.comboBox13.Name = "comboBox13";
			this.comboBox13.Size = new System.Drawing.Size(146, 21);
			this.comboBox13.TabIndex = 17;
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
			// comboBox14
			// 
			this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox14.FormattingEnabled = true;
			this.comboBox14.Location = new System.Drawing.Point(265, 47);
			this.comboBox14.Name = "comboBox14";
			this.comboBox14.Size = new System.Drawing.Size(146, 21);
			this.comboBox14.TabIndex = 15;
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
			// comboBox9
			// 
			this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox9.FormattingEnabled = true;
			this.comboBox9.Location = new System.Drawing.Point(62, 155);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(146, 21);
			this.comboBox9.TabIndex = 12;
			// 
			// comboBox8
			// 
			this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(62, 128);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(146, 21);
			this.comboBox8.TabIndex = 11;
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
			// comboBox7
			// 
			this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(62, 101);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(146, 21);
			this.comboBox7.TabIndex = 9;
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
			// comboBox6
			// 
			this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(62, 74);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(146, 21);
			this.comboBox6.TabIndex = 7;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(14, 186);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(94, 17);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Unlock talents";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox1);
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
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.comboBox3);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(426, 55);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Game Version";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboBox5);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.comboBox4);
			this.groupBox4.Location = new System.Drawing.Point(12, 359);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(426, 87);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "AI Difficulty";
			// 
			// comboBox5
			// 
			this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(87, 47);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(160, 21);
			this.comboBox5.TabIndex = 3;
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
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(87, 20);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(160, 21);
			this.comboBox4.TabIndex = 0;
			// 
			// Form1
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
			this.Name = "Form1";
			this.Text = "HotS Patcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}

