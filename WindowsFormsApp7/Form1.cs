using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        UdpClient udpclient;
        byte[] income_upd;
        RichardBurnsRallyNGPTelemetryAPI rbr_api;
        IPEndPoint remoteIP;
        int totalstate = 0;
        Controller xi = new Controller(UserIndex.One);
        ushort brk_min = 0;
        ushort brk_max = 0;
        ushort brk_vl = 0;
        ushort brk_zero = 0;
        int spd_zero = 0;
        int brk_ehw = 1;
        float brk_dz = 0;
        ushort brk_fl = 0;
        int brk_mbs = 0;
        int brk_flw = 0;
        int pb_vl = 0;
        float spd_df = 0;
        ushort brk_right = 0;
        ushort brk_left = 0;
        ushort brk_preview = 0;
        RBRBrakingHelper.Form3 HUD_bar;
        public static string rbr_folder = string.Empty;
        string app_folder = Application.StartupPath;
        //RBRBrakingHelper.Form3 HUD_bar = new RBRBrakingHelper.Form3();
        public Form1()
        {
            InitializeComponent();

            //if (File.Exists(app_folder + "\\settings\\rbr_folder.ini"))
            //{
            //    using (StreamReader sr = new StreamReader(app_folder + "\\settings\\rbr_folder.ini"))
            //    {
            //        rbr_folder = sr.ReadLine();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Select RBR Folder");
            //    FolderBrowserDialog dialog = new FolderBrowserDialog();
            //    dialog.ShowDialog();
            //    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\rbr_folder.ini"))
            //    {
            //        sw.WriteLine(dialog.SelectedPath);
            //    }
            //    rbr_folder = dialog.SelectedPath;
            //}
            //if (!File.Exists(rbr_folder + "\\RichardBurnsRally_SSE.exe"))
            //{
            //    File.Delete(app_folder + "\\settings\\rbr_folder.ini");
            //    MessageBox.Show("RBR_SSE.exe not found");
            //    Application.Exit();
            //}
            //else;

            ////while (!File.Exists(rbr_folder + "\\RichardBurnsRally_SSE.exe"))
            ////{
            ////    MessageBox.Show("Select RBR Folder");
            ////    FolderBrowserDialog dialog = new FolderBrowserDialog();
            ////    dialog.ShowDialog();
            ////    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\rbr_folder.ini"))
            ////    {
            ////        sw.WriteLine(dialog.SelectedPath);
            ////    }
            ////    rbr_folder = dialog.SelectedPath;
            ////}
            //HUD_bar = new RBRBrakingHelper.Form3(rbr_folder);
        }


        private void RBR_Telemetry_Button_Click(object sender, EventArgs e)
        {
            if (hud_is_enable.CheckState == CheckState.Checked)
            { HUD_bar.Show(); }
            else;
            udpclient = new UdpClient();
            remoteIP = new IPEndPoint(IPAddress.Loopback, 6776);
            udpclient.Client.Bind(remoteIP);
            try
            {
                udpclient.BeginReceive(new AsyncCallback(RBRrecv), null);
                statusStrip1.Invoke((MethodInvoker)(() => statusStrip1.Items[0].Text = "Waiting RBR Telemetry"));
            }
            catch (Exception ex)
            {
                statusStrip1.Invoke((MethodInvoker)(() => statusStrip1.Items[0].Text = ex.Message.ToString()));
            }
        }

        public void RBRrecv(IAsyncResult RBRres)
        {
            income_upd = udpclient.EndReceive(RBRres, ref remoteIP);
            if (income_upd.Length == 664)
            {
                GCHandle gcHandle = GCHandle.Alloc((object)income_upd, GCHandleType.Pinned);
                rbr_api = (RichardBurnsRallyNGPTelemetryAPI)Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof(RichardBurnsRallyNGPTelemetryAPI));
                gcHandle.Free();
                totalstate++;
                // end of get udp daata

                if (ffb_is_enable.CheckState == CheckState.Checked)
                {

                    Vector3 bodyspeed = new Vector3(x: rbr_api.car.velocities.surge * 36 / 10, y: rbr_api.car.velocities.sway * 36 / 10, z: rbr_api.car.velocities.heave * 36 / 10);
                spd_df = bodyspeed.Length() - rbr_api.car.speed;
                if (rbr_api.control.brake > brk_dz && bodyspeed.Length() > brk_mbs)
                {
                    if (rbr_api.car.speed < brk_flw && rbr_api.car.speed > -1)
                    {
                        if (checkBox1.CheckState == CheckState.Unchecked)
                        {
                            xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = brk_fl });
                            brk_left = brk_fl;
                        }
                        else
                        {
                            if (rbr_api.control.handbrake > 0)
                            {
                                xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = brk_preview });
                                brk_right = brk_preview;
                            }
                            else
                            {
                                xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = brk_fl });
                                brk_left = brk_fl;
                            }
                        }
                    }

                    else
                    {
                        if (rbr_api.control.handbrake == 0)
                            brk_preview = brk_right;
                        else;
                        if (spd_df < 0)
                        {
                            xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = brk_min });
                            brk_right = brk_min;
                        }
                        else
                        {
                            var brk_vbr = brk_min + brk_vl * (spd_df);
                            if (brk_vbr > 65535)
                            {
                                xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = 65535 });
                                brk_right = 65535;
                            }
                            else
                            {
                                xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = (ushort)brk_vbr });
                                brk_right = (ushort)brk_vbr;
                            }
                        }
                    }
                }
                else
                {
                    xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = 0 });
                    brk_left = 0;
                    if (bodyspeed.Length() > spd_zero)
                    {
                        xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = brk_zero });
                        brk_right = brk_zero;
                    }

                    else
                    {
                        xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = 0 });
                        brk_right = 0;
                    }
                    if (rbr_api.control.handbrake == 0)
                        brk_preview = brk_right;

                }
            }
            else;
                    statusStrip1.Invoke((MethodInvoker)(() => statusStrip1.Items[0].Text = "Reciving RBR Telemetry: " + totalstate.ToString()));
                }
                else
                {
                if (ffb_is_enable.CheckState == CheckState.Checked)
                {
                    xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = 0 });
                    xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = 0 });
                }
                else;
                }


            //Task.Run(() => HUD_bar.data_set(rbr_api));
            if (hud_is_enable.CheckState == CheckState.Checked)
            {
                HUD_bar.data_set(rbr_api);
            }
            else;
            // HUD_bar.rbr = rbr_api;
            udpclient.BeginReceive(new AsyncCallback(RBRrecv), null);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = 65535 });
                await Task.Delay(1000);
                xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = 65535 });
                await Task.Delay(1000);

            }
            xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = 0 });
            xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = 0 });
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (ffb_is_enable.CheckState == CheckState.Checked)
            xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = (ushort)(trackBar1.Value) });
            label2.Invoke((MethodInvoker)(() =>
                label2.Text = ((float)(trackBar1.Value) / 65535 * 100).ToString() + "%"
            ));
            brk_min = (ushort)trackBar1.Value;
            brk_max = (ushort)trackBar2.Value;
            brk_vl = (ushort)((brk_max - brk_min) / 150);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (ffb_is_enable.CheckState == CheckState.Checked)
                xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = (ushort)(trackBar2.Value) });
            label4.Invoke((MethodInvoker)(() =>
                label4.Text = ((float)(trackBar2.Value) / 65535 * 100).ToString() + "%"
            ));
            brk_min = (ushort)trackBar1.Value;
            brk_max = (ushort)trackBar2.Value;
            brk_vl = (ushort)((brk_max - brk_min) / 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath.ToString() + "\\export.ini"))
            {
                sw.WriteLine(String.Join("", trackBar1.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar2.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar3.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar4.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar5.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar6.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar7.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar8.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar9.Value.ToString()));
            }
            brk_min = (ushort)trackBar1.Value;
            brk_max = (ushort)trackBar2.Value;
            brk_zero = (ushort)trackBar3.Value;
            spd_zero = (int)trackBar4.Value;
            brk_ehw = (int)trackBar5.Value;
            brk_dz = (float)trackBar6.Value / 65535;
            brk_fl = (ushort)trackBar7.Value;
            brk_mbs = (int)trackBar8.Value;
            brk_flw = (int)trackBar9.Value;

            brk_vl = (ushort)((brk_max - brk_min) / brk_ehw);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath.ToString() + "\\settings\\"))
                ;
            else Directory.CreateDirectory(Application.StartupPath.ToString() + "\\settings\\");

            if (File.Exists(app_folder + "\\settings\\hud.ini"))
            {
                using (StreamReader sr = new StreamReader(app_folder + "\\settings\\hud.ini"))
                {
                    if (sr.ReadLine().ToLower() == "on")
                    {
                        hud_is_enable.Checked = true;
                    }
                    else
                    {
                        hud_is_enable.Checked = false;
                    }

                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\hud.ini"))
                {
                    sw.WriteLine("on");
                }
            }

            if (File.Exists(app_folder + "\\settings\\ffb.ini"))
            {
                using (StreamReader sr = new StreamReader(app_folder + "\\settings\\ffb.ini"))
                {
                    if (sr.ReadLine().ToLower() == "on")
                    {
                        ffb_is_enable.Checked = true;
                    }
                    else
                    {
                        ffb_is_enable.Checked = false;
                    }

                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\ffb.ini"))
                {
                    sw.WriteLine("on");
                }
            }

            if (File.Exists(app_folder + "\\settings\\rbr_folder.ini"))
            {
                using (StreamReader sr = new StreamReader(app_folder + "\\settings\\rbr_folder.ini"))
                {
                    rbr_folder = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Select RBR Folder");
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();
                using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\rbr_folder.ini"))
                {
                    sw.WriteLine(dialog.SelectedPath);
                }
                rbr_folder = dialog.SelectedPath;
                if (!File.Exists(rbr_folder + "\\RichardBurnsRally_SSE.exe"))
                {
                    File.Delete(app_folder + "\\settings\\rbr_folder.ini");
                }
                else
                {
                    Application.Restart();
                    //Application.Exit();
                };
            }
            if (!File.Exists(rbr_folder + "\\RichardBurnsRally_SSE.exe"))
            {
                File.Delete(app_folder + "\\settings\\rbr_folder.ini");
                Application.Restart();
                //Application.Exit();
            }
            else;

            //while (!File.Exists(rbr_folder + "\\RichardBurnsRally_SSE.exe"))
            //{
            //    MessageBox.Show("Select RBR Folder");
            //    FolderBrowserDialog dialog = new FolderBrowserDialog();
            //    dialog.ShowDialog();
            //    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\rbr_folder.ini"))
            //    {
            //        sw.WriteLine(dialog.SelectedPath);
            //    }
            //    rbr_folder = dialog.SelectedPath;
            //}
            HUD_bar = new RBRBrakingHelper.Form3(rbr_folder);


            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath.ToString() + "\\export.ini"))
                {
                    int vl = 0;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar1.Value = vl;
                    brk_min = (ushort)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar2.Value = vl;
                    brk_max = (ushort)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar3.Value = vl;
                    brk_zero = (ushort)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar4.Value = vl;
                    spd_zero = (int)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar5.Value = vl;
                    brk_ehw = (int)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar6.Value = vl;
                    brk_dz = (float)vl / 65535;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar7.Value = vl;
                    brk_fl = (ushort)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar8.Value = vl;
                    brk_mbs = (int)vl;
                    int.TryParse(sr.ReadLine(), out vl);
                    trackBar9.Value = vl;
                    brk_flw = (int)vl;

                }
                brk_vl = (ushort)((brk_max - brk_min) / brk_ehw);
            }
            catch
            {
                MessageBox.Show("Failed to load config or connect to XInput device");
            }



            trackBar3.Visible = false;
            trackBar4.Visible = false;
            trackBar5.Visible = false;
            trackBar6.Visible = false;
            trackBar7.Visible = false;
            trackBar8.Visible = false;
            trackBar9.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            if (ffb_is_enable.CheckState == CheckState.Checked)
                xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = (ushort)(trackBar3.Value) });
            label5.Invoke((MethodInvoker)(() =>
                label5.Text = ((float)(trackBar3.Value) / 65535 * 100).ToString() + "%"
            ));
            brk_zero = (ushort)trackBar3.Value;
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label7.Invoke((MethodInvoker)(() =>
                label7.Text = trackBar4.Value.ToString() + " Kph"
            ));
            spd_zero = (int)trackBar4.Value;
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            label9.Invoke((MethodInvoker)(() =>
                label9.Text = trackBar5.Value.ToString() + " Kph"
            ));
            brk_ehw = (int)trackBar5.Value;
        }

        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            label11.Invoke((MethodInvoker)(() =>
                label11.Text = ((float)(trackBar6.Value) / 65535 * 100).ToString() + "%"
            ));
            brk_dz = (float)trackBar6.Value / 65535;
        }

        private void trackBar7_ValueChanged(object sender, EventArgs e)
        {
            if (ffb_is_enable.CheckState == CheckState.Checked)
                xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = (ushort)(trackBar7.Value) });
            label13.Invoke((MethodInvoker)(() =>
                label13.Text = ((float)(trackBar7.Value) / 65535 * 100).ToString() + "%"
            ));
            brk_fl = (ushort)trackBar7.Value;
        }

        private void trackBar8_ValueChanged(object sender, EventArgs e)
        {
            label15.Invoke((MethodInvoker)(() =>
                label15.Text = trackBar8.Value.ToString() + " Kph"
            ));
            brk_mbs = (int)trackBar8.Value;
        }

        private void trackBar9_ValueChanged(object sender, EventArgs e)
        {
            label17.Invoke((MethodInvoker)(() =>
                label17.Text = trackBar9.Value.ToString() + " Kph"
            ));
            brk_flw = (int)trackBar9.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fn = Microsoft.VisualBasic.Interaction.InputBox("Enter settings name:");
            if (fn == "" || fn.Intersect(Path.GetInvalidFileNameChars()).Any() == true)
            {
                MessageBox.Show("Wrong settings name");
                button4_Click(sender, null);
            }
            using (StreamWriter sw = new StreamWriter(Application.StartupPath.ToString() + "\\settings\\" + fn + ".ini"))
            {
                sw.WriteLine(String.Join("", trackBar1.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar2.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar3.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar4.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar5.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar6.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar7.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar8.Value.ToString()));
                sw.WriteLine(String.Join("", trackBar9.Value.ToString()));
            }
            brk_min = (ushort)trackBar1.Value;
            brk_max = (ushort)trackBar2.Value;
            brk_zero = (ushort)trackBar3.Value;
            spd_zero = (int)trackBar4.Value;
            brk_ehw = (int)trackBar5.Value;
            brk_dz = (float)trackBar6.Value / 65535;
            brk_fl = (ushort)trackBar7.Value;
            brk_mbs = (int)trackBar8.Value;
            brk_flw = (int)trackBar9.Value;

            brk_vl = (ushort)((brk_max - brk_min) / brk_ehw);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectfile = new OpenFileDialog { Filter = "Settings |*.ini" };
            selectfile.ShowDialog();
            using (StreamReader sr = new StreamReader(selectfile.FileName))
            {
                int vl = 0;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar1.Value = vl;
                brk_min = (ushort)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar2.Value = vl;
                brk_max = (ushort)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar3.Value = vl;
                brk_zero = (ushort)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar4.Value = vl;
                spd_zero = (int)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar5.Value = vl;
                brk_ehw = (int)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar6.Value = vl;
                brk_dz = (float)vl / 65535;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar7.Value = vl;
                brk_fl = (ushort)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar8.Value = vl;
                brk_mbs = (int)vl;
                int.TryParse(sr.ReadLine(), out vl);
                trackBar9.Value = vl;
                brk_flw = (int)vl;

            }
            brk_vl = (ushort)((brk_max - brk_min) / brk_ehw);
            xi.SetVibration(new SharpDX.XInput.Vibration { RightMotorSpeed = 0 });
            xi.SetVibration(new SharpDX.XInput.Vibration { LeftMotorSpeed = 0 });

        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            var sz = new System.Drawing.Size();
            if (ActiveForm.Size.Height != 561)
            {
                sz.Width = 493;
                sz.Height = 561;
                trackBar3.Visible = true;
                trackBar4.Visible = true;
                trackBar5.Visible = true;
                trackBar6.Visible = true;
                trackBar7.Visible = true;
                trackBar8.Visible = true;
                trackBar9.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                toolStripSplitButton1.Text = "Base Settings";
            }
            else
            {
                sz.Width = 493;
                sz.Height = 206;
                trackBar3.Visible = false;
                trackBar4.Visible = false;
                trackBar5.Visible = false;
                trackBar6.Visible = false;
                trackBar7.Visible = false;
                trackBar8.Visible = false;
                trackBar9.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false; 
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                toolStripSplitButton1.Text = "Advansed Settings";
            }
            ActiveForm.Size = sz;
        }

        private void ffb_is_enable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ffb_is_enable.CheckState == CheckState.Checked)
                {
                    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\ffb.ini"))
                    {
                        sw.WriteLine("on");
                    }
                }
                else
                {
                    
                    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\ffb.ini"))
                    {
                        sw.WriteLine("off");
                    }
                }
            }
            catch { }
        }

        private void hud_is_enable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (hud_is_enable.CheckState == CheckState.Checked)
                {
                    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\hud.ini"))
                    {
                        sw.WriteLine("on");
                    }
                }
                else
                {

                    using (StreamWriter sw = new StreamWriter(app_folder + "\\settings\\hud.ini"))
                    {
                        sw.WriteLine("off");
                    }
                }
            }
            catch { }
        }

        private void hud_is_enable_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
