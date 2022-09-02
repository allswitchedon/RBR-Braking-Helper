using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace RBRBrakingHelper
{
    public partial class Form3 : Form
    {
        Vector3 car_speed;
        Vector drift_xy;
        Vector drift_ref;
        bool t_ow_set = true;
        int[] t_ow = new int[2] { 40 ,75};

        float[] wfl, wfr, wrl, wrr;
        PictureBox[] pb_left;
        PictureBox[] pb_right;
        PictureBox[] pb_1k;
        PictureBox[] pb_500;
        int gearup=0;
        int geardown=0;
        OxyPlot.PlotModel gg_model;
        OxyPlot.Series.ScatterSeries gg_series;
        WindowsFormsApp7.RichardBurnsRallyNGPTelemetryAPI rbr_api;
        int upd_info = 0;
        int g0up, g0down, g1up, g1down, g2up, g2down, g3up, g3down, g4up, g4down, g5up, g5down, g6up, g6down, g7up, g7down, rpm_max;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        List<PictureBox> pb_1k_list = new List<PictureBox>();


        private void RPM_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form3_LocationChanged(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\location.ini"))
            {
                sw.WriteLine(this.Location.X);
                sw.WriteLine(this.Location.Y);
            }
        }

        List<PictureBox> pb_500_list = new List<PictureBox>();

        private async void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            await Task.Delay(2500);
            //using (StreamReader sr = new StreamReader("D:\\Games\\Richard Burns Rally\\Physics\\s_i2003\\common.lsp"))
            using (StreamReader sr = new StreamReader(rbr_folder + "\\\\Physics\\s_i2003\\common.lsp"))
            {
                label9.Invoke((MethodInvoker)(() => label9.Text = "RD"));
                while (!sr.EndOfStream)
                {
                    var rl = sr.ReadLine().Split('\t').ToList();
                    rl.RemoveAll(isEven);
                    if (rl.Count == 2)
                    {
                        if (rl[0].Contains("Gear0Upshift"))
                        {
                            g0up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear0Downshift"))
                        {
                            g0down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear1Upshift"))
                        {
                            g1up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear1Downshift"))
                        {
                            g1down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear2Upshift"))
                        {
                            g2up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear2Downshift"))
                        {
                            g2down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear3Upshift"))
                        {
                            g3up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear3Downshift"))
                        {
                            g3down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear4Upshift"))
                        {
                            g4up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear4Downshift"))
                        {
                            g4down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear5Upshift"))
                        {
                            g5up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear5Downshift"))
                        {
                            g5down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear6Upshift"))
                        {
                            g6up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear6Downshift"))
                        {
                            g6down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear7Upshift"))
                        {
                            g7up = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("Gear7Downshift"))
                        {
                            g7down = (int)(float.Parse(rl[1]));
                        }
                        if (rl[0].Contains("RPMLimit"))
                        {
                            rpm_max = (int)(float.Parse(rl[1]));
                        }
                    }
                }
                if (g0down == 0)
                    g0down = rpm_max / 2;
                if (g1down == 0)
                    g1down = rpm_max / 2;
                if (g2down == 0)
                    g2down = rpm_max / 2;
                if (g3down == 0)
                    g3down = rpm_max / 2;
                if (g4down == 0)
                    g4down = rpm_max / 2;
                if (g5down == 0)
                    g5down = rpm_max / 2;
                if (g6down == 0)
                    g6down = rpm_max / 2;
                if (g7down == 0)
                    g7down = rpm_max / 2;

                if (g0up == 0)
                    g0up = rpm_max - 500;
                if (g1up == 0)
                    g1up = rpm_max - 500;
                if (g2up == 0)
                    g2up = rpm_max - 500;
                if (g3up == 0)
                    g3up = rpm_max - 500;
                if (g4up == 0)
                    g4up = rpm_max - 500;
                if (g5up == 0)
                    g5up = rpm_max - 500;
                if (g6up == 0)
                    g6up = rpm_max - 500;
                if (g7up == 0)
                    g7up = rpm_max - 500;
                RPM_bar.Maximum = rpm_max;
            }
            rpm_1k(rpm_max);
            rpm_500(rpm_max);

            RPM_bar.SendToBack();
            label9.Invoke((MethodInvoker)(() => label9.Text = "RPM"));
        }


        string rbr_folder;
        string app_folder = Application.StartupPath;
        FolderBrowserDialog dialog = new FolderBrowserDialog();

        public Form3(string rbr_fld)
        {
            rbr_folder = rbr_fld;
            

            drift_ref.X = 1;
            drift_ref.Y = 0;
            wfl = new float[8];
            wfr = new float[8];
            wrl = new float[8];
            wrr = new float[8];
            pb_left = new PictureBox[79];
            pb_right = new PictureBox[79];
            pb_1k = new PictureBox[9];
            pb_500 = new PictureBox[19];

            InitializeComponent();
            try
            {
                fileSystemWatcher1.Path = rbr_fld;
            }
            catch
            {
                MessageBox.Show("Wrong RBR direcory");
            }
            RPM_bar.Maximum = rpm_max;
            gg_model = new OxyPlot.PlotModel();
            gg_series = new OxyPlot.Series.ScatterSeries();
            gg_series.Points.Add(new OxyPlot.Series.ScatterPoint(0, 0));
            gg_model.Series.Add(gg_series);
            var axis_y = new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, IsAxisVisible = false };
            var axis_x = new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, IsAxisVisible = false };
            gg_model.Axes.Add(axis_x);
            gg_model.Axes.Add(axis_y);
            gg_model.Axes[0].Zoom(-1, 1);
            gg_model.Axes[1].Zoom(-1, 1);
            plotView1.Model = gg_model;
            rbr_api = new WindowsFormsApp7.RichardBurnsRallyNGPTelemetryAPI();
            g0up = g0down = g1up = g1down = g2up = g2down = g3up = g3down = g4up = g4down = g5up = g5down = g6up = g6down = g7up = g7down = 0;
            rpm_max = 600;

            if (File.Exists(app_folder + "\\settings\\location.ini"))
            {
                int x = 0;
                int y = 0;
                using (StreamReader sr = new StreamReader(app_folder + "\\settings\\location.ini"))
                {
                   int.TryParse(sr.ReadLine(), out x);
                    int.TryParse(sr.ReadLine(), out y);

                }
                this.Location = new System.Drawing.Point(x, y);
            }

        }

        public void data_set(WindowsFormsApp7.RichardBurnsRallyNGPTelemetryAPI rbr_api_in )
        {
            rbr_api = rbr_api_in;
            upd_info++;
        }

        void brake(CircularProgressBar.CircularProgressBar cpb, int layer, int disk)
        {


            if (layer > 400)
                layer = 400;
            else if (layer < 0)
                layer = 0;
            else;
                cpb.Invoke((MethodInvoker)(() =>
                {
                        cpb.Value = layer;
                        cpb.SubscriptText = disk.ToString();
                        if (layer > 350)
                            cpb.ProgressColor = Color.Red;
                        else if (layer > 300)
                            cpb.ProgressColor = Color.Orange;
                        else if (layer > 150)
                            cpb.ProgressColor = Color.Green;
                        else cpb.ProgressColor = Color.Blue;

                        if (disk > 325)
                            cpb.InnerColor = Color.LightCoral;
                        else if (disk > 275)
                            cpb.InnerColor = Color.SandyBrown;
                        else if (disk > 125)
                            cpb.InnerColor = Color.PaleGreen;
                        else cpb.InnerColor = Color.LightSkyBlue;
                }));
         

        }

        void wheel(CircularProgressBar.CircularProgressBar cpb, int wear, int temp)
        {
            if (wear > 100)
                wear = 100;
            else if (wear < 0)
                wear = 0;
            else;
            cpb.Invoke((MethodInvoker)(() =>
            {
                cpb.Value = wear;
                cpb.SubscriptText = temp.ToString();
                    if (wear > 66)
                        cpb.ProgressColor = Color.Green;
                    else if (wear > 33)
                        cpb.ProgressColor = Color.Orange;
                    else cpb.ProgressColor = Color.Red;

                    if (temp > t_ow[1])
                        cpb.InnerColor = Color.LightCoral;
                    else if (temp > t_ow[1] -5)
                        cpb.InnerColor = Color.SandyBrown;
                    else if (temp > t_ow[0])
                        cpb.InnerColor = Color.PaleGreen;
                    else cpb.InnerColor = Color.LightSkyBlue;

                cpb.Update();
            }));
            
        }

        public static string stopwatch(double time)
        {
            int minute;
            int second;
            int milisecond;
            string Time;
            minute = (int)(time / 60);
            second = (int)(time - 60 * minute);
            milisecond = (int)((time - (int)(time)) * 100);
            Time = minute.ToString();
            if (second < 10)
                Time += ":" + "0" + second.ToString();
            else Time = minute.ToString() + ":" + second.ToString();
            if (milisecond < 10)
                Time += ":" + "0" + milisecond.ToString();
            else Time += ":" + milisecond.ToString();
            return Time;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Update(rbr_api);
                Thread.Sleep(10);
            }

        }

        private static bool isEven(string st)
        {
            return (st == string.Empty);
        }


        public void Update(WindowsFormsApp7.RichardBurnsRallyNGPTelemetryAPI rbr)
        {
            Engine_Temp.Value = (int)(rbr.car.engine.engineTemperature - 273.15f);
            Engine_Water_Temp.Value = (int)(rbr.car.engine.engineCoolantTemperature - 273.15f);
            Engine_Radiator_Temp.Value = (int)(rbr.car.engine.radiatorCoolantTemperature - 273.15f);
            brake(brake_FL, (int)(rbr.car.suspensionLF.wheel.brakeDisk.layerTemperature - 273.15f), (int)(rbr.car.suspensionLF.wheel.brakeDisk.temperature - 273.15f));
            brake(brake_FR, (int)(rbr.car.suspensionRF.wheel.brakeDisk.layerTemperature - 273.15f), (int)(rbr.car.suspensionRF.wheel.brakeDisk.temperature - 273.15f));
            brake(brake_RL, (int)(rbr.car.suspensionLB.wheel.brakeDisk.layerTemperature - 273.15f), (int)(rbr.car.suspensionLB.wheel.brakeDisk.temperature - 273.15f));
            brake(brake_RR, (int)(rbr.car.suspensionRB.wheel.brakeDisk.layerTemperature - 273.15f), (int)(rbr.car.suspensionRB.wheel.brakeDisk.temperature - 273.15f));

            wfl[0] = rbr.car.suspensionLF.wheel.tire.segment1.wear;
            wfl[1] = rbr.car.suspensionLF.wheel.tire.segment2.wear;
            wfl[2] = rbr.car.suspensionLF.wheel.tire.segment3.wear;
            wfl[3] = rbr.car.suspensionLF.wheel.tire.segment4.wear;
            wfl[4] = rbr.car.suspensionLF.wheel.tire.segment5.wear;
            wfl[5] = rbr.car.suspensionLF.wheel.tire.segment6.wear;
            wfl[6] = rbr.car.suspensionLF.wheel.tire.segment7.wear;
            wfl[7] = rbr.car.suspensionLF.wheel.tire.segment8.wear;

            wfr[0] = rbr.car.suspensionRF.wheel.tire.segment1.wear;
            wfr[1] = rbr.car.suspensionRF.wheel.tire.segment2.wear;
            wfr[2] = rbr.car.suspensionRF.wheel.tire.segment3.wear;
            wfr[3] = rbr.car.suspensionRF.wheel.tire.segment4.wear;
            wfr[4] = rbr.car.suspensionRF.wheel.tire.segment5.wear;
            wfr[5] = rbr.car.suspensionRF.wheel.tire.segment6.wear;
            wfr[6] = rbr.car.suspensionRF.wheel.tire.segment7.wear;
            wfr[7] = rbr.car.suspensionRF.wheel.tire.segment8.wear;

            wrl[0] = rbr.car.suspensionLB.wheel.tire.segment1.wear;
            wrl[1] = rbr.car.suspensionLB.wheel.tire.segment2.wear;
            wrl[2] = rbr.car.suspensionLB.wheel.tire.segment3.wear;
            wrl[3] = rbr.car.suspensionLB.wheel.tire.segment4.wear;
            wrl[4] = rbr.car.suspensionLB.wheel.tire.segment5.wear;
            wrl[5] = rbr.car.suspensionLB.wheel.tire.segment6.wear;
            wrl[6] = rbr.car.suspensionLB.wheel.tire.segment7.wear;
            wrl[7] = rbr.car.suspensionLB.wheel.tire.segment8.wear;

            wrr[0] = rbr.car.suspensionRB.wheel.tire.segment1.wear;
            wrr[1] = rbr.car.suspensionRB.wheel.tire.segment2.wear;
            wrr[2] = rbr.car.suspensionRB.wheel.tire.segment3.wear;
            wrr[3] = rbr.car.suspensionRB.wheel.tire.segment4.wear;
            wrr[4] = rbr.car.suspensionRB.wheel.tire.segment5.wear;
            wrr[5] = rbr.car.suspensionRB.wheel.tire.segment6.wear;
            wrr[6] = rbr.car.suspensionRB.wheel.tire.segment7.wear;
            wrr[7] = rbr.car.suspensionRB.wheel.tire.segment8.wear;

            //wheel(wheel_FL, 100 - (int)(wfl.Average() * 100), (int)(rbr.car.suspensionLF.wheel.tire.temperature - 273.15f));
            //wheel(wheel_FR, 100 - (int)(wfr.Average() * 100), (int)(rbr.car.suspensionRF.wheel.tire.temperature - 273.15f));
            //wheel(wheel_RL, 100 - (int)(wrl.Average() * 100), (int)(rbr.car.suspensionLB.wheel.tire.temperature - 273.15f));
            //wheel(wheel_RR, 100 - (int)(wrr.Average() * 100), (int)(rbr.car.suspensionRB.wheel.tire.temperature - 273.15f));

            wheel(wheel_FL, (int)(100f - wfl.Average()*100), (int)(rbr.car.suspensionLF.wheel.tire.temperature - 273.15f));
            wheel(wheel_FR, (int)(100f - wfr.Average() * 100), (int)(rbr.car.suspensionRF.wheel.tire.temperature - 273.15f));
            wheel(wheel_RL, (int)(100f - wrl.Average() * 100), (int)(rbr.car.suspensionLB.wheel.tire.temperature - 273.15f));
            wheel(wheel_RR, (int)(100f - wrr.Average() * 100), (int)(rbr.car.suspensionRB.wheel.tire.temperature - 273.15f));


            throttle_bar.Value = (int)(rbr.control.throttle * 100);
            clutch_bar.Value = (int)(rbr.control.clutch * 100);
            brake_bar.Value = (int)(rbr.control.brake * 100);
            handbrake_bar.Value = (int)(rbr.control.handbrake * 100);
            if (rbr.control.steering > 0)
            {
                R_turn_bar.Value = (int)(rbr.control.steering * 100);
                L_turn_bar.Value = 100;
            }
            else if (rbr.control.steering < 0)
            {
                R_turn_bar.Value = 0;
                L_turn_bar.Value = 100 + (int)(rbr.control.steering * 100);
            }
            else
            {
                R_turn_bar.Value = 0;
                L_turn_bar.Value = 0;
            };
            car_speed.X = rbr.car.velocities.surge;
            car_speed.Y = rbr.car.velocities.sway;
            car_speed.Z = rbr.car.velocities.heave;
            //Speed_value.Value = car_speed.Length();
            //Speed_value.Value = rbr.control.steering;
            speed.Invoke((MethodInvoker)(() => speed.Text = ((int)(car_speed.Length() * 3.6f)).ToString()));

            drift_xy.X = rbr.car.velocities.surge;
            drift_xy.Y = rbr.car.velocities.sway;
            Drift_Angle.Invoke((MethodInvoker)(() => Drift_Angle.Text = ((int)(Vector.AngleBetween(drift_ref, drift_xy))*-1).ToString()));




            switch (rbr.control.gear)
            {
                case 0:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "R"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g0up, g0down);
                    break;
                case 1:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "N"
                    )); 
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g1up, g1down);
                    break;
                case 2:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "1"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g2up, g2down);
                    break;
                case 3:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "2"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g3up, g3down);
                    break;
                case 4:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "3"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g4up, g4down);
                    break;
                case 5:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "4"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g5up, g5down);
                    break;
                case 6:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "5"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g6up, g6down);
                    break;
                case 7:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "6"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g7up, g7down);
                    break;

                default:
                    gear.Invoke((MethodInvoker)(() =>
                    gear.Text = "N"
                    ));
                    RPM_bar.ForeColor = bar_color(rbr.car.engine.rpm, g1up, g1down);
                    break;
            }
            RPM_bar.Value = (int)rbr.car.engine.rpm;
            //if (rbr.car.engine.rpm > rpm_max)
            //{
            //    RPM_bar.Value = rpm_max;
            //}
            //else if (rbr.car.engine.rpm > gearup)
            //{
            //    RPM_bar.ForeColor = Color.Red;
            //    RPM_bar.Value = (int)rbr.car.engine.rpm;
            //}
            //else if (rbr.car.engine.rpm > gearup - 250)
            //{
            //    RPM_bar.ForeColor = Color.Orange;
            //    RPM_bar.Value = (int)rbr.car.engine.rpm;
            //}
            //else if (rbr.car.engine.rpm > geardown)
            //{
            //    RPM_bar.ForeColor = Color.Green;
            //    RPM_bar.Value = (int)rbr.car.engine.rpm;
            //}
            //else
            //{
            //    RPM_bar.ForeColor = Color.LightGreen;
            //    RPM_bar.Value = (int)rbr.car.engine.rpm;
            //}
            gg_series.Points.Clear();
            gg_series.Points.Add(new OxyPlot.Series.ScatterPoint(rbr.car.accelerations.sway*-1, rbr.car.accelerations.surge*-1));
            plotView1.OnModelChanged();

            racetime.Invoke((MethodInvoker)(() => racetime.Text = stopwatch(rbr.stage.raceTime)));
            toend.Invoke((MethodInvoker)(() => toend.Text = ((int)rbr.stage.distanceToEnd).ToString()));
            rpm.Invoke((MethodInvoker)(() => rpm.Text = ((int)rbr.car.engine.rpm).ToString()));
            location.Invoke((MethodInvoker)(() => location.Text = ((int)rbr.stage.driveLineLocation).ToString()));

            if (rbr.totalSteps < 100 && t_ow_set == true && rbr.car.suspensionLB.wheel.tire.temperature > 300)
            {
                t_ow = operation_windown((int)(rbr.car.suspensionLB.wheel.tire.temperature-273.15f));
                t_ow_set = false;
            }
            else if (rbr.totalSteps > 100 && t_ow_set == false)
            {
                t_ow_set = true;
            }
        }

        public void Standby()
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            for (int i =0; i<pb_left.Length; i++)
            {
                pb_left[i] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(pb_left[i])).BeginInit();
                pb_left[i].Location = new System.Drawing.Point(484, 2+i);
                pb_left[i].Name = "pictureBox_left"+i.ToString();
                pb_left[i].Size = new System.Drawing.Size(1+i, 1);
                pb_left[i].TabIndex = 100 +i;
                pb_left[i].TabStop = false;                
                ((System.ComponentModel.ISupportInitialize)(pb_left[i])).EndInit();
                this.Controls.Add(this.pb_left[i]);

                pb_right[i] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(pb_right[i])).BeginInit();
                pb_right[i].Location = new System.Drawing.Point(1306+i, 1 + i);
                pb_right[i].Name = "pictureBox_right" + i.ToString();
                pb_right[i].Size = new System.Drawing.Size(pb_right.Length - i, 1);
                pb_right[i].TabIndex = 200 + i;
                pb_right[i].TabStop = false;
                ((System.ComponentModel.ISupportInitialize)(pb_right[i])).EndInit();
                this.Controls.Add(this.pb_right[i]);
            }

            rpm_1k(10000);
            rpm_500(10000);

            RPM_bar.SendToBack();
            backgroundWorker1.RunWorkerAsync();

        }

        void rpm_1k(int max_rpm)
        {
            foreach (PictureBox pb in pb_1k_list)
            {
                this.Controls.Remove(pb);
            }
            pb_1k_list.Clear();
            float dist = 900000f / max_rpm;
            var how_many = max_rpm/1000;
            for (int i = 0; i < how_many; i++)
            {
                if (484 + (int)dist * (i + 1) < 1384)
                {
                    //pb_1k_list.Add(new System.Windows.Forms.PictureBox());
                    //((System.ComponentModel.ISupportInitialize)(pb_1k_list[i])).BeginInit();
                    //pb_1k_list[i].Location = new System.Drawing.Point(482 + (int)dist * (i + 1), 5);
                    //pb_1k_list[i].Name = "pictureBox_left" + i.ToString();
                    //pb_1k_list[i].Size = new System.Drawing.Size(5, 72);
                    //pb_1k_list[i].TabIndex = 300 + i;
                    //pb_1k_list[i].TabStop = false;
                    //((System.ComponentModel.ISupportInitialize)(pb_1k_list[i])).EndInit();
                    //this.Controls.Add(this.pb_1k_list[i]);


                    pb_1k_list.Add(new System.Windows.Forms.PictureBox());
                    ((System.ComponentModel.ISupportInitialize)(pb_1k_list[i])).BeginInit();
                    if (482 + (int)dist * (i + 1) < 1306)
                    {
                        pb_1k_list[i].Location = new System.Drawing.Point(482 + (int)dist * (i + 1), 5);
                        pb_1k_list[i].Size = new System.Drawing.Size(5, 72);
                    }
                    else
                    {
                        var last = 486 + (int)dist * (i + 1);
                        var last2 = last - 1306;
                        var last3 = pb_right[last2].Location.Y;
                        var last4 = 79 - last3 - 8;
                        pb_1k_list[i].Location = new System.Drawing.Point(482 + (int)dist * (i + 1), last3 +6);
                        pb_1k_list[i].Size = new System.Drawing.Size(5, last4);
                    }
                    pb_1k_list[i].Name = "pictureBox_left" + i.ToString();
                    pb_1k_list[i].TabIndex = 300 + i;
                    pb_1k_list[i].TabStop = false;
                    ((System.ComponentModel.ISupportInitialize)(pb_1k_list[i])).EndInit();
                    this.Controls.Add(this.pb_1k_list[i]);


                }
            }
        }

        int[] operation_windown (int temp)
        {
            int[] t_ow = new int[] { temp - 5, temp + 25 };
            return t_ow; 
        }
        void rpm_500(int max_rpm)
        {
            foreach (PictureBox pb in pb_500_list)
            {
                this.Controls.Remove(pb);
            }
            pb_500_list.Clear();
            float dist = 900000f / max_rpm/2;
            var how_many = max_rpm / 500;
            for (int i = 0; i < how_many; i++)
            {
                if (i % 2 == 0 && i >1 && 484 + (int)dist * (i + 1) < 1306)
                {
                    pb_500_list.Add(new System.Windows.Forms.PictureBox());
                    var ii = pb_500_list.Count() - 1;
                    ((System.ComponentModel.ISupportInitialize)(pb_500_list[ii])).BeginInit();
                    pb_500_list[ii].Location = new System.Drawing.Point(483 + (int)dist * (i + 1), 15);
                    pb_500_list[ii].Name = "pictureBox_left" + i.ToString();
                    pb_500_list[ii].Size = new System.Drawing.Size(3, 52);
                    pb_500_list[ii].TabIndex = 400 + ii;
                    pb_500_list[ii].TabStop = false;
                    ((System.ComponentModel.ISupportInitialize)(pb_500_list[ii])).EndInit();
                    this.Controls.Add(this.pb_500_list[ii]);
                }
                else;
            }
        }


        Color bar_color (float rpm, int gearup, int geardown)
        {
            Color cl = new Color();
            if (rpm> gearup)
            {
                cl = Color.Red;
            }
            else if (rpm > gearup - 250)
            {
                cl = Color.Orange;
            }
            else if (rpm > geardown)
            {
                cl = Color.Green;
            }
            else
            {
                cl = Color.LightGreen;
            }

            return cl;

        }
    }
}
