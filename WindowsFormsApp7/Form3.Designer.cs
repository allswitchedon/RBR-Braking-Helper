namespace RBRBrakingHelper
{
    partial class Form3
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
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            this.R_turn_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.L_turn_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.brake_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.handbrake_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.throttle_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.clutch_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Drift_Angle = new System.Windows.Forms.Label();
            this.Engine_Temp = new CodeArtEng.Gauge.RectangleIndicator();
            this.Engine_Radiator_Temp = new CodeArtEng.Gauge.RectangleIndicator();
            this.Engine_Water_Temp = new CodeArtEng.Gauge.RectangleIndicator();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RPM_bar = new Matix.Controls.Progressbar.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.brake_FL = new CircularProgressBar.CircularProgressBar();
            this.wheel_RL = new CircularProgressBar.CircularProgressBar();
            this.brake_FR = new CircularProgressBar.CircularProgressBar();
            this.brake_RR = new CircularProgressBar.CircularProgressBar();
            this.brake_RL = new CircularProgressBar.CircularProgressBar();
            this.wheel_FR = new CircularProgressBar.CircularProgressBar();
            this.wheel_RR = new CircularProgressBar.CircularProgressBar();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.racetime = new System.Windows.Forms.Label();
            this.toend = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gear = new System.Windows.Forms.Label();
            this.rpm = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wheel_FL = new CircularProgressBar.CircularProgressBar();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // R_turn_bar
            // 
            this.R_turn_bar.BackColor = System.Drawing.Color.Silver;
            this.R_turn_bar.Flat = true;
            this.R_turn_bar.ForeColor = System.Drawing.Color.DarkOrange;
            this.R_turn_bar.Location = new System.Drawing.Point(1764, 39);
            this.R_turn_bar.Maximum = 100;
            this.R_turn_bar.Minimum = 0;
            this.R_turn_bar.Name = "R_turn_bar";
            this.R_turn_bar.Size = new System.Drawing.Size(154, 15);
            this.R_turn_bar.TabIndex = 16;
            this.R_turn_bar.Value = 56;
            // 
            // L_turn_bar
            // 
            this.L_turn_bar.BackColor = System.Drawing.Color.DarkOrange;
            this.L_turn_bar.Flat = true;
            this.L_turn_bar.ForeColor = System.Drawing.Color.Silver;
            this.L_turn_bar.Location = new System.Drawing.Point(1608, 39);
            this.L_turn_bar.Maximum = 100;
            this.L_turn_bar.Minimum = 0;
            this.L_turn_bar.Name = "L_turn_bar";
            this.L_turn_bar.Size = new System.Drawing.Size(154, 15);
            this.L_turn_bar.TabIndex = 17;
            this.L_turn_bar.Value = 56;
            // 
            // brake_bar
            // 
            this.brake_bar.BackColor = System.Drawing.Color.Silver;
            this.brake_bar.Flat = true;
            this.brake_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brake_bar.Location = new System.Drawing.Point(1768, 60);
            this.brake_bar.Maximum = 100;
            this.brake_bar.Minimum = 0;
            this.brake_bar.Name = "brake_bar";
            this.brake_bar.Size = new System.Drawing.Size(150, 10);
            this.brake_bar.TabIndex = 18;
            this.brake_bar.Value = 56;
            // 
            // handbrake_bar
            // 
            this.handbrake_bar.BackColor = System.Drawing.Color.Silver;
            this.handbrake_bar.Flat = true;
            this.handbrake_bar.ForeColor = System.Drawing.Color.DarkRed;
            this.handbrake_bar.Location = new System.Drawing.Point(1768, 76);
            this.handbrake_bar.Maximum = 100;
            this.handbrake_bar.Minimum = 0;
            this.handbrake_bar.Name = "handbrake_bar";
            this.handbrake_bar.Size = new System.Drawing.Size(150, 10);
            this.handbrake_bar.TabIndex = 19;
            this.handbrake_bar.Value = 56;
            // 
            // throttle_bar
            // 
            this.throttle_bar.BackColor = System.Drawing.Color.Silver;
            this.throttle_bar.Flat = true;
            this.throttle_bar.ForeColor = System.Drawing.Color.Green;
            this.throttle_bar.Location = new System.Drawing.Point(1608, 60);
            this.throttle_bar.Maximum = 100;
            this.throttle_bar.Minimum = 0;
            this.throttle_bar.Name = "throttle_bar";
            this.throttle_bar.Size = new System.Drawing.Size(150, 10);
            this.throttle_bar.TabIndex = 20;
            this.throttle_bar.Value = 56;
            // 
            // clutch_bar
            // 
            this.clutch_bar.BackColor = System.Drawing.Color.Silver;
            this.clutch_bar.Flat = true;
            this.clutch_bar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.clutch_bar.Location = new System.Drawing.Point(1608, 76);
            this.clutch_bar.Maximum = 100;
            this.clutch_bar.Minimum = 0;
            this.clutch_bar.Name = "clutch_bar";
            this.clutch_bar.Size = new System.Drawing.Size(150, 10);
            this.clutch_bar.TabIndex = 21;
            this.clutch_bar.Value = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(259, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 90);
            this.label1.TabIndex = 31;
            this.label1.Text = "T\r\nY\r\nR\r\nE\r\nS";
            // 
            // Drift_Angle
            // 
            this.Drift_Angle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drift_Angle.Font = new System.Drawing.Font("LCDMono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drift_Angle.ForeColor = System.Drawing.Color.Silver;
            this.Drift_Angle.Location = new System.Drawing.Point(114, 27);
            this.Drift_Angle.Name = "Drift_Angle";
            this.Drift_Angle.Size = new System.Drawing.Size(85, 33);
            this.Drift_Angle.TabIndex = 32;
            this.Drift_Angle.Text = "-180";
            this.Drift_Angle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Engine_Temp
            // 
            this.Engine_Temp.AnimationEnabled = false;
            this.Engine_Temp.ErrorLimit = 200D;
            this.Engine_Temp.Font = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engine_Temp.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.Engine_Temp.Location = new System.Drawing.Point(340, 0);
            this.Engine_Temp.Name = "Engine_Temp";
            this.Engine_Temp.ScaleFactor = 1D;
            this.Engine_Temp.Size = new System.Drawing.Size(60, 30);
            this.Engine_Temp.TabIndex = 33;
            this.Engine_Temp.Title = "";
            this.Engine_Temp.Unit = "";
            this.Engine_Temp.UserDefinedColors.Base = themeColors1;
            themeColors2.PointerColor = System.Drawing.Color.Red;
            this.Engine_Temp.UserDefinedColors.Error = themeColors2;
            themeColors3.PointerColor = System.Drawing.Color.Orange;
            this.Engine_Temp.UserDefinedColors.Warning = themeColors3;
            this.Engine_Temp.Value = 139D;
            this.Engine_Temp.WarningLimit = 150D;
            // 
            // Engine_Radiator_Temp
            // 
            this.Engine_Radiator_Temp.AnimationEnabled = false;
            this.Engine_Radiator_Temp.ErrorLimit = 130D;
            this.Engine_Radiator_Temp.Font = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engine_Radiator_Temp.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.Engine_Radiator_Temp.Location = new System.Drawing.Point(340, 62);
            this.Engine_Radiator_Temp.Name = "Engine_Radiator_Temp";
            this.Engine_Radiator_Temp.ScaleFactor = 1D;
            this.Engine_Radiator_Temp.Size = new System.Drawing.Size(60, 30);
            this.Engine_Radiator_Temp.TabIndex = 34;
            this.Engine_Radiator_Temp.Title = "";
            this.Engine_Radiator_Temp.Unit = "";
            this.Engine_Radiator_Temp.Value = 144D;
            this.Engine_Radiator_Temp.WarningLimit = 110D;
            // 
            // Engine_Water_Temp
            // 
            this.Engine_Water_Temp.AnimationEnabled = false;
            this.Engine_Water_Temp.ErrorLimit = 130D;
            this.Engine_Water_Temp.Font = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engine_Water_Temp.InfoMode = CodeArtEng.Gauge.GaugeInfoMode.NONE;
            this.Engine_Water_Temp.Location = new System.Drawing.Point(340, 31);
            this.Engine_Water_Temp.Name = "Engine_Water_Temp";
            this.Engine_Water_Temp.ScaleFactor = 1D;
            this.Engine_Water_Temp.Size = new System.Drawing.Size(60, 30);
            this.Engine_Water_Temp.TabIndex = 35;
            this.Engine_Water_Temp.Title = "";
            this.Engine_Water_Temp.Unit = "";
            this.Engine_Water_Temp.Value = 115D;
            this.Engine_Water_Temp.WarningLimit = 110D;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LCDMono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(144, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "DRIFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LCDMono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(144, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 37;
            this.label4.Text = "ANGLE";
            // 
            // RPM_bar
            // 
            this.RPM_bar.BackColor = System.Drawing.Color.Silver;
            this.RPM_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RPM_bar.Flat = true;
            this.RPM_bar.ForeColor = System.Drawing.Color.Green;
            this.RPM_bar.Location = new System.Drawing.Point(484, 1);
            this.RPM_bar.Maximum = 100;
            this.RPM_bar.Minimum = 0;
            this.RPM_bar.Name = "RPM_bar";
            this.RPM_bar.Size = new System.Drawing.Size(900, 80);
            this.RPM_bar.TabIndex = 39;
            this.RPM_bar.Value = 56;
            this.RPM_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RPM_bar_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LCDMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(52, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 84);
            this.label2.TabIndex = 48;
            this.label2.Text = "B\r\nR\r\nA\r\nK\r\nE\r\nS";
            // 
            // brake_FL
            // 
            this.brake_FL.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.brake_FL.AnimationSpeed = 0;
            this.brake_FL.BackColor = System.Drawing.Color.Transparent;
            this.brake_FL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.brake_FL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brake_FL.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brake_FL.InnerMargin = 2;
            this.brake_FL.InnerWidth = -1;
            this.brake_FL.Location = new System.Drawing.Point(-2, -2);
            this.brake_FL.MarqueeAnimationSpeed = 0;
            this.brake_FL.Maximum = 400;
            this.brake_FL.Name = "brake_FL";
            this.brake_FL.OuterColor = System.Drawing.Color.Silver;
            this.brake_FL.OuterMargin = -5;
            this.brake_FL.OuterWidth = 5;
            this.brake_FL.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brake_FL.ProgressWidth = 5;
            this.brake_FL.SecondaryFont = new System.Drawing.Font("LCDMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brake_FL.Size = new System.Drawing.Size(48, 48);
            this.brake_FL.StartAngle = 270;
            this.brake_FL.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.brake_FL.SubscriptMargin = new System.Windows.Forms.Padding(-16, -57, 0, 0);
            this.brake_FL.SubscriptText = "350";
            this.brake_FL.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.brake_FL.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_FL.SuperscriptText = "";
            this.brake_FL.TabIndex = 65;
            this.brake_FL.Text = " ";
            this.brake_FL.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_FL.Value = 68;
            // 
            // wheel_RL
            // 
            this.wheel_RL.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.wheel_RL.AnimationSpeed = 0;
            this.wheel_RL.BackColor = System.Drawing.Color.Transparent;
            this.wheel_RL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.wheel_RL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wheel_RL.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wheel_RL.InnerMargin = 2;
            this.wheel_RL.InnerWidth = -1;
            this.wheel_RL.Location = new System.Drawing.Point(205, 45);
            this.wheel_RL.MarqueeAnimationSpeed = 0;
            this.wheel_RL.Name = "wheel_RL";
            this.wheel_RL.OuterColor = System.Drawing.Color.Silver;
            this.wheel_RL.OuterMargin = -5;
            this.wheel_RL.OuterWidth = 5;
            this.wheel_RL.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wheel_RL.ProgressWidth = 5;
            this.wheel_RL.SecondaryFont = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheel_RL.Size = new System.Drawing.Size(48, 48);
            this.wheel_RL.StartAngle = 270;
            this.wheel_RL.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.wheel_RL.SubscriptMargin = new System.Windows.Forms.Padding(-16, -59, 0, 0);
            this.wheel_RL.SubscriptText = "99";
            this.wheel_RL.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.wheel_RL.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_RL.SuperscriptText = "";
            this.wheel_RL.TabIndex = 70;
            this.wheel_RL.Text = " ";
            this.wheel_RL.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_RL.Value = 100;
            // 
            // brake_FR
            // 
            this.brake_FR.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.brake_FR.AnimationSpeed = 0;
            this.brake_FR.BackColor = System.Drawing.Color.Transparent;
            this.brake_FR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.brake_FR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brake_FR.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brake_FR.InnerMargin = 2;
            this.brake_FR.InnerWidth = -1;
            this.brake_FR.Location = new System.Drawing.Point(74, -2);
            this.brake_FR.MarqueeAnimationSpeed = 0;
            this.brake_FR.Maximum = 400;
            this.brake_FR.Name = "brake_FR";
            this.brake_FR.OuterColor = System.Drawing.Color.Silver;
            this.brake_FR.OuterMargin = -5;
            this.brake_FR.OuterWidth = 5;
            this.brake_FR.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brake_FR.ProgressWidth = 5;
            this.brake_FR.SecondaryFont = new System.Drawing.Font("LCDMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brake_FR.Size = new System.Drawing.Size(48, 48);
            this.brake_FR.StartAngle = 270;
            this.brake_FR.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.brake_FR.SubscriptMargin = new System.Windows.Forms.Padding(-16, -57, 0, 0);
            this.brake_FR.SubscriptText = "350";
            this.brake_FR.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.brake_FR.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_FR.SuperscriptText = "";
            this.brake_FR.TabIndex = 73;
            this.brake_FR.Text = " ";
            this.brake_FR.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_FR.Value = 68;
            // 
            // brake_RR
            // 
            this.brake_RR.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.brake_RR.AnimationSpeed = 0;
            this.brake_RR.BackColor = System.Drawing.Color.Transparent;
            this.brake_RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.brake_RR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brake_RR.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brake_RR.InnerMargin = 2;
            this.brake_RR.InnerWidth = -1;
            this.brake_RR.Location = new System.Drawing.Point(74, 45);
            this.brake_RR.MarqueeAnimationSpeed = 0;
            this.brake_RR.Maximum = 400;
            this.brake_RR.Name = "brake_RR";
            this.brake_RR.OuterColor = System.Drawing.Color.Silver;
            this.brake_RR.OuterMargin = -5;
            this.brake_RR.OuterWidth = 5;
            this.brake_RR.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brake_RR.ProgressWidth = 5;
            this.brake_RR.SecondaryFont = new System.Drawing.Font("LCDMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brake_RR.Size = new System.Drawing.Size(48, 48);
            this.brake_RR.StartAngle = 270;
            this.brake_RR.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.brake_RR.SubscriptMargin = new System.Windows.Forms.Padding(-16, -57, 0, 0);
            this.brake_RR.SubscriptText = "350";
            this.brake_RR.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.brake_RR.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_RR.SuperscriptText = "";
            this.brake_RR.TabIndex = 74;
            this.brake_RR.Text = " ";
            this.brake_RR.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_RR.Value = 68;
            // 
            // brake_RL
            // 
            this.brake_RL.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.brake_RL.AnimationSpeed = 0;
            this.brake_RL.BackColor = System.Drawing.Color.Transparent;
            this.brake_RL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.brake_RL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brake_RL.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brake_RL.InnerMargin = 2;
            this.brake_RL.InnerWidth = -1;
            this.brake_RL.Location = new System.Drawing.Point(-2, 45);
            this.brake_RL.MarqueeAnimationSpeed = 0;
            this.brake_RL.Maximum = 400;
            this.brake_RL.Name = "brake_RL";
            this.brake_RL.OuterColor = System.Drawing.Color.Silver;
            this.brake_RL.OuterMargin = -5;
            this.brake_RL.OuterWidth = 5;
            this.brake_RL.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brake_RL.ProgressWidth = 5;
            this.brake_RL.SecondaryFont = new System.Drawing.Font("LCDMono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brake_RL.Size = new System.Drawing.Size(48, 48);
            this.brake_RL.StartAngle = 270;
            this.brake_RL.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.brake_RL.SubscriptMargin = new System.Windows.Forms.Padding(-16, -57, 0, 0);
            this.brake_RL.SubscriptText = "350";
            this.brake_RL.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.brake_RL.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_RL.SuperscriptText = "";
            this.brake_RL.TabIndex = 75;
            this.brake_RL.Text = " ";
            this.brake_RL.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.brake_RL.Value = 68;
            // 
            // wheel_FR
            // 
            this.wheel_FR.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.wheel_FR.AnimationSpeed = 0;
            this.wheel_FR.BackColor = System.Drawing.Color.Transparent;
            this.wheel_FR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.wheel_FR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wheel_FR.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wheel_FR.InnerMargin = 2;
            this.wheel_FR.InnerWidth = -1;
            this.wheel_FR.Location = new System.Drawing.Point(284, -2);
            this.wheel_FR.MarqueeAnimationSpeed = 0;
            this.wheel_FR.Name = "wheel_FR";
            this.wheel_FR.OuterColor = System.Drawing.Color.Silver;
            this.wheel_FR.OuterMargin = -5;
            this.wheel_FR.OuterWidth = 5;
            this.wheel_FR.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wheel_FR.ProgressWidth = 5;
            this.wheel_FR.SecondaryFont = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheel_FR.Size = new System.Drawing.Size(48, 48);
            this.wheel_FR.StartAngle = 270;
            this.wheel_FR.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.wheel_FR.SubscriptMargin = new System.Windows.Forms.Padding(-16, -59, 0, 0);
            this.wheel_FR.SubscriptText = "99";
            this.wheel_FR.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.wheel_FR.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_FR.SuperscriptText = "";
            this.wheel_FR.TabIndex = 77;
            this.wheel_FR.Text = " ";
            this.wheel_FR.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_FR.Value = 100;
            // 
            // wheel_RR
            // 
            this.wheel_RR.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.wheel_RR.AnimationSpeed = 0;
            this.wheel_RR.BackColor = System.Drawing.Color.Transparent;
            this.wheel_RR.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.wheel_RR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wheel_RR.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wheel_RR.InnerMargin = 2;
            this.wheel_RR.InnerWidth = -1;
            this.wheel_RR.Location = new System.Drawing.Point(284, 45);
            this.wheel_RR.MarqueeAnimationSpeed = 0;
            this.wheel_RR.Name = "wheel_RR";
            this.wheel_RR.OuterColor = System.Drawing.Color.Silver;
            this.wheel_RR.OuterMargin = -5;
            this.wheel_RR.OuterWidth = 5;
            this.wheel_RR.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wheel_RR.ProgressWidth = 5;
            this.wheel_RR.SecondaryFont = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheel_RR.Size = new System.Drawing.Size(48, 48);
            this.wheel_RR.StartAngle = 270;
            this.wheel_RR.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.wheel_RR.SubscriptMargin = new System.Windows.Forms.Padding(-16, -59, 0, 0);
            this.wheel_RR.SubscriptText = "99";
            this.wheel_RR.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.wheel_RR.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_RR.SuperscriptText = "";
            this.wheel_RR.TabIndex = 78;
            this.wheel_RR.Text = " ";
            this.wheel_RR.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_RR.Value = 100;
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.plotView1.Location = new System.Drawing.Point(1510, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(92, 92);
            this.plotView1.TabIndex = 79;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // racetime
            // 
            this.racetime.Font = new System.Drawing.Font("LCDMono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racetime.ForeColor = System.Drawing.Color.Silver;
            this.racetime.Location = new System.Drawing.Point(1753, 3);
            this.racetime.Name = "racetime";
            this.racetime.Size = new System.Drawing.Size(165, 30);
            this.racetime.TabIndex = 80;
            this.racetime.Text = "00:00:00";
            this.racetime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toend
            // 
            this.toend.Font = new System.Drawing.Font("LCDMono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toend.ForeColor = System.Drawing.Color.Silver;
            this.toend.Location = new System.Drawing.Point(1673, 1);
            this.toend.Name = "toend";
            this.toend.Size = new System.Drawing.Size(63, 17);
            this.toend.TabIndex = 81;
            this.toend.Text = "99999";
            this.toend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speed
            // 
            this.speed.Font = new System.Drawing.Font("LCDMono", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.ForeColor = System.Drawing.Color.Silver;
            this.speed.Location = new System.Drawing.Point(1377, 1);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(127, 57);
            this.speed.TabIndex = 82;
            this.speed.Text = "200";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.speed.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LCDMono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(1430, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 83;
            this.label6.Text = "KPH";
            // 
            // gear
            // 
            this.gear.AutoSize = true;
            this.gear.Font = new System.Drawing.Font("LCDMono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear.ForeColor = System.Drawing.Color.Silver;
            this.gear.Location = new System.Drawing.Point(1342, 3);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(29, 28);
            this.gear.TabIndex = 84;
            this.gear.Text = "N";
            // 
            // rpm
            // 
            this.rpm.Font = new System.Drawing.Font("LCDMono", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpm.ForeColor = System.Drawing.Color.Silver;
            this.rpm.Location = new System.Drawing.Point(413, 42);
            this.rpm.Name = "rpm";
            this.rpm.Size = new System.Drawing.Size(109, 38);
            this.rpm.TabIndex = 85;
            this.rpm.Text = "9999";
            this.rpm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LCDMono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(427, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 86;
            this.label9.Text = "RPM";
            // 
            // location
            // 
            this.location.Font = new System.Drawing.Font("LCDMono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.Silver;
            this.location.Location = new System.Drawing.Point(1673, 19);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(63, 17);
            this.location.TabIndex = 87;
            this.location.Text = "99999";
            this.location.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LCDMono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(1620, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 11);
            this.label7.TabIndex = 88;
            this.label7.Text = "finish";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LCDMono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(1606, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 11);
            this.label8.TabIndex = 89;
            this.label8.Text = "location";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // wheel_FL
            // 
            this.wheel_FL.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.wheel_FL.AnimationSpeed = 0;
            this.wheel_FL.BackColor = System.Drawing.Color.Transparent;
            this.wheel_FL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.wheel_FL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wheel_FL.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wheel_FL.InnerMargin = 2;
            this.wheel_FL.InnerWidth = -1;
            this.wheel_FL.Location = new System.Drawing.Point(205, -2);
            this.wheel_FL.MarqueeAnimationSpeed = 0;
            this.wheel_FL.Name = "wheel_FL";
            this.wheel_FL.OuterColor = System.Drawing.Color.Silver;
            this.wheel_FL.OuterMargin = -5;
            this.wheel_FL.OuterWidth = 5;
            this.wheel_FL.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.wheel_FL.ProgressWidth = 5;
            this.wheel_FL.SecondaryFont = new System.Drawing.Font("LCDMono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheel_FL.Size = new System.Drawing.Size(48, 48);
            this.wheel_FL.StartAngle = 270;
            this.wheel_FL.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.wheel_FL.SubscriptMargin = new System.Windows.Forms.Padding(-16, -59, 0, 0);
            this.wheel_FL.SubscriptText = "99";
            this.wheel_FL.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.wheel_FL.SuperscriptMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_FL.SuperscriptText = "";
            this.wheel_FL.TabIndex = 90;
            this.wheel_FL.Text = " ";
            this.wheel_FL.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.wheel_FL.Value = 100;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "RallySimFans.ini";
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastAccess;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1924, 92);
            this.ControlBox = false;
            this.Controls.Add(this.wheel_FL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.location);
            this.Controls.Add(this.gear);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.rpm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toend);
            this.Controls.Add(this.racetime);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.wheel_RR);
            this.Controls.Add(this.wheel_FR);
            this.Controls.Add(this.brake_RL);
            this.Controls.Add(this.brake_RR);
            this.Controls.Add(this.brake_FR);
            this.Controls.Add(this.wheel_RL);
            this.Controls.Add(this.brake_FL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Engine_Water_Temp);
            this.Controls.Add(this.Engine_Radiator_Temp);
            this.Controls.Add(this.Engine_Temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clutch_bar);
            this.Controls.Add(this.throttle_bar);
            this.Controls.Add(this.handbrake_bar);
            this.Controls.Add(this.brake_bar);
            this.Controls.Add(this.L_turn_bar);
            this.Controls.Add(this.R_turn_bar);
            this.Controls.Add(this.Drift_Angle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RPM_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.LocationChanged += new System.EventHandler(this.Form3_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Matix.Controls.Progressbar.ProgressBar R_turn_bar;
        private Matix.Controls.Progressbar.ProgressBar brake_bar;
        private Matix.Controls.Progressbar.ProgressBar handbrake_bar;
        private Matix.Controls.Progressbar.ProgressBar throttle_bar;
        private Matix.Controls.Progressbar.ProgressBar clutch_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Drift_Angle;
        private CodeArtEng.Gauge.RectangleIndicator Engine_Temp;
        private CodeArtEng.Gauge.RectangleIndicator Engine_Radiator_Temp;
        private CodeArtEng.Gauge.RectangleIndicator Engine_Water_Temp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Matix.Controls.Progressbar.ProgressBar L_turn_bar;
        private Matix.Controls.Progressbar.ProgressBar RPM_bar;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar brake_FL;
        private CircularProgressBar.CircularProgressBar wheel_RL;
        private CircularProgressBar.CircularProgressBar brake_FR;
        private CircularProgressBar.CircularProgressBar brake_RR;
        private CircularProgressBar.CircularProgressBar brake_RL;
        private CircularProgressBar.CircularProgressBar wheel_FR;
        private CircularProgressBar.CircularProgressBar wheel_RR;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Label racetime;
        private System.Windows.Forms.Label toend;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.Label rpm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar wheel_FL;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}