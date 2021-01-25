using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace SecureApe
{
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer SCP = new System.Media.SoundPlayer(@"..\..\sounds\sndSCP.wav");
        System.Media.SoundPlayer Imperial1 = new System.Media.SoundPlayer(@"..\..\sounds\sndImperial.wav");
        System.Media.SoundPlayer Imperial2 = new System.Media.SoundPlayer(@"..\..\sounds\sndDroid.wav");
        System.Media.SoundPlayer Imperial3 = new System.Media.SoundPlayer(@"..\..\sounds\sndDeath.wav");
        System.Media.SoundPlayer Inter1 = new System.Media.SoundPlayer(@"..\..\sounds\MTAF1.wav");
        System.Media.SoundPlayer Inter2 = new System.Media.SoundPlayer(@"..\..\sounds\MTAF2.wav");
        System.Media.SoundPlayer Inter3 = new System.Media.SoundPlayer(@"..\..\sounds\MTAF3.wav");

        public Form1()
        {
            InitializeComponent();
        }

        

        private void cmdPasscode_Click(object sender, EventArgs e)
        {
            grbPasscode.Visible = true;
            txtPasscode.PasswordChar = '*';
            cmdPasscode.Visible = false;
            cmdExit.Visible = false;
        }

        private void cmdBackPass_Click(object sender, EventArgs e)
        {
            grbPasscode.Visible = false;
            txtPasscode.Text = "";
            cmdPasscode.Visible = true;
            cmdExit.Visible = true;
            
        }

        private void cmdEnter_Click(object sender, EventArgs e)
        {

            if (txtPasscode.Text == "")
            {
                txtPasscode.PasswordChar = '\0';
                txtPasscode.Text = "Enter Passcode";
                txtPasscode.Refresh();
                System.Threading.Thread.Sleep(700);
                txtPasscode.Text = "";
                txtPasscode.PasswordChar = '*';
            }
            else if (txtPasscode.Text == "Ape1031972")
            {
                grbHome.Visible = true;
                grbPasscode.Visible = false;
                txtPasscode.Text = "";
            }
            else
            {
                txtPasscode.PasswordChar = '\0';
                txtPasscode.Text = "Password Failed";
                txtPasscode.Refresh();
                System.Threading.Thread.Sleep(700);
                txtPasscode.Text = "";
                txtPasscode.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            grbHome.Visible = false;
            grbPasscode.Visible = false;
            cmdPasscode.Visible = true;
            cmdExit.Visible = true;
        }

        private void cmdPlaySCP_Click(object sender, EventArgs e)
        {
            SCP.Play();
        }

        private void cmdPLAYa_Click(object sender, EventArgs e)
        {
            Imperial1.Play();
        }

        private void cmdPLAYb_Click(object sender, EventArgs e)
        {
            Imperial2.Play();
        }

        private void cmpPLAYc_Click(object sender, EventArgs e)
        {
            Imperial3.Play();
        }

        private void cmdPLAY1_Click(object sender, EventArgs e)
        {
            Inter1.Play();
        }

        private void cmdPLAY2_Click(object sender, EventArgs e)
        {
            Inter2.Play();
        }

        private void cmdPLAY3_Click(object sender, EventArgs e)
        {
            Inter3.Play();
        }

        private void cmdSTOPsnd_Click(object sender, EventArgs e)
        {
            SCP.Stop();
            Imperial1.Stop();
            Imperial2.Stop();
            Imperial3.Stop();
            Inter1.Stop();
            Inter2.Stop();
            Inter3.Stop();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice CaptureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
            
        }

        private void cmdQRrun_Click(object sender, EventArgs e)
        {
            CaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            CaptureDevice.NewFrame += CaptureDevice_NewFrame;
            CaptureDevice.Start();
            timerQRpic.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picQRscan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cmdQRstop_Click(object sender, EventArgs e)
        {
            CaptureDevice.Stop();
        }

        private void timerQRpic_Tick(object sender, EventArgs e)
        {
            if(picQRscan.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)picQRscan.Image);
                if (result != null)
                {
                    txtQRdecode.Text = result.ToString();
                    timerQRpic.Stop();
                    if (CaptureDevice.IsRunning)
                        CaptureDevice.Stop();
                    if (txtQRdecode.Text == "Ape1031972QR")
                        grScanner.Visible = false;
                    if (txtQRdecode.Text == "Ape1031972QR")
                        grbPasscode.Visible = false;
                    if (txtQRdecode.Text == "Ape1031972QR")
                        grbHome.Visible = true;
                    if (txtQRdecode.Text != "Ape1031972QR")
                        MessageBox.Show("Error - QR not matched");
                }
                
            }
        }

        private void cmdScanStart_Click(object sender, EventArgs e)
        {
            grbPasscode.Visible = false;
            grScanner.Visible = true;
        }

        private void cmdQRback_Click(object sender, EventArgs e)
        {
            CaptureDevice.Stop();
            grbPasscode.Visible = true;
            grScanner.Visible = false;
        }
    }
}
