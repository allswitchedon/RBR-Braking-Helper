namespace WindowsFormsApp7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ffb_is_enable = new System.Windows.Forms.CheckBox();
            this.hud_is_enable = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 145);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel1.Text = "RBR Braking Helper";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(120, 17);
            this.toolStripSplitButton1.Text = "Advansed Settings";
            this.toolStripSplitButton1.Click += new System.EventHandler(this.toolStripSplitButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RBR_Telemetry_Button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 41);
            this.trackBar1.Maximum = 65535;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(446, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 92);
            this.trackBar2.Maximum = 65535;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(446, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Easy braking vibration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hard braking vibration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "0%";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Preload vibration";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(12, 143);
            this.trackBar3.Maximum = 65535;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(446, 45);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "0 Kph";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Preload speed";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(12, 194);
            this.trackBar4.Maximum = 200;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(446, 45);
            this.trackBar4.TabIndex = 20;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "1 Kph";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Easy-Hard width";
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(12, 245);
            this.trackBar5.Maximum = 200;
            this.trackBar5.Minimum = 1;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(446, 45);
            this.trackBar5.TabIndex = 23;
            this.trackBar5.Value = 1;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar5_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "0%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Brake pedal deadzone";
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(12, 296);
            this.trackBar6.Maximum = 65535;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(446, 45);
            this.trackBar6.TabIndex = 26;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar6_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "0%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Full lock vibration";
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(12, 347);
            this.trackBar7.Maximum = 65535;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(446, 45);
            this.trackBar7.TabIndex = 29;
            this.trackBar7.ValueChanged += new System.EventHandler(this.trackBar7_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 430);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "0 Kph";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Minimal bodyspeed for full lock vibration";
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(12, 398);
            this.trackBar8.Maximum = 200;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(446, 45);
            this.trackBar8.TabIndex = 32;
            this.trackBar8.ValueChanged += new System.EventHandler(this.trackBar8_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(314, 481);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "1 Kph";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(90, 481);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Full lock wheelspeed";
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(12, 449);
            this.trackBar9.Maximum = 200;
            this.trackBar9.Minimum = 1;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(446, 45);
            this.trackBar9.TabIndex = 35;
            this.trackBar9.Value = 1;
            this.trackBar9.ValueChanged += new System.EventHandler(this.trackBar9_ValueChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Save as";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(156, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(90, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "RWD Fix";
            // 
            // ffb_is_enable
            // 
            this.ffb_is_enable.AutoSize = true;
            this.ffb_is_enable.Checked = true;
            this.ffb_is_enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ffb_is_enable.Location = new System.Drawing.Point(420, 5);
            this.ffb_is_enable.Name = "ffb_is_enable";
            this.ffb_is_enable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ffb_is_enable.Size = new System.Drawing.Size(45, 17);
            this.ffb_is_enable.TabIndex = 42;
            this.ffb_is_enable.Text = "FFB";
            this.ffb_is_enable.UseVisualStyleBackColor = true;
            this.ffb_is_enable.CheckedChanged += new System.EventHandler(this.ffb_is_enable_CheckedChanged);
            // 
            // hud_is_enable
            // 
            this.hud_is_enable.AutoSize = true;
            this.hud_is_enable.Checked = true;
            this.hud_is_enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hud_is_enable.Location = new System.Drawing.Point(415, 28);
            this.hud_is_enable.Name = "hud_is_enable";
            this.hud_is_enable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hud_is_enable.Size = new System.Drawing.Size(50, 17);
            this.hud_is_enable.TabIndex = 43;
            this.hud_is_enable.Text = "HUD";
            this.hud_is_enable.UseVisualStyleBackColor = true;
            this.hud_is_enable.CheckedChanged += new System.EventHandler(this.hud_is_enable_CheckedChanged);
            this.hud_is_enable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hud_is_enable_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 167);
            this.Controls.Add(this.hud_is_enable);
            this.Controls.Add(this.ffb_is_enable);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 561);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(493, 206);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSplitButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ffb_is_enable;
        private System.Windows.Forms.CheckBox hud_is_enable;
    }
}

