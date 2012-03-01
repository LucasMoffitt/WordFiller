using System;
using System.Drawing;
using System.Windows.Forms;
using WordFiller.Framework;
using WordFiller.Kinect;

namespace WordFiller
{
    public partial class FrmConfig : Form
    {

        public FrmConfig()
        {
            InitializeComponent();
            Closed += (FrmConfig_Closed);

            trackbar_textsize.Value = Settings.GetFontSize();
            lbl_demotext.Font = new Font("Arial", Settings.GetFontSize());
            checkbox_kinectstatus.Checked = Settings.GetKinectStatus();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            ManageWindows.Forms.Add(this);
            
            if (Settings.GetHandOrientation() == "left")
            {
                rdb_left.Checked = true;
            }
            
            WhatIsTheKinectDoing();
        }

        private void FrmConfig_Closed(object sender, EventArgs e)
        {
            KinectSettings.DisableKinect();
            ManageWindows.Forms.Remove(this);
        }
        
        private void WhatIsTheKinectDoing()
        {
            if (Settings.GetKinectStatus())
            {
                if (KinectSettings.Nui == null)
                {
                    KinectSettings.EnableKinect();

                    foreach (var w in ManageWindows.Forms)
                    {
                        if (w is FrmMain)
                        {
                            (w as FrmMain).StartupCheck_Kinect();
                        }
                    }
                }
                
                VideoOutputTimer.Enabled = true;
            }
            else
            {
                KinectSettings.DisableKinect();
                VideoOutputTimer.Enabled = false;
            }
        }
        
        private void VideoOutputTimer_Tick(object sender, EventArgs e)
        {
        //    img_kinectvideo.Image = KinectSettings.videoOutput;
        }

        private void trackbar_textsize_Scroll(object sender, EventArgs e)
        {
            lbl_demotext.Font = new Font("Arial", trackbar_textsize.Value);
            Settings.SetFontSize(trackbar_textsize.Value);
        }

        private void trackbar_kinecttilt_Scroll(object sender, EventArgs e)
        {
            KinectSettings.TiltKinect(trackbar_kinecttilt.Value);
        }

        private void rdb_right_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SetHandOrientation("right");
        }

        private void rdb_left_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SetHandOrientation("left");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkbox_kinectstatus_CheckedChanged(object sender, EventArgs e)
        {
            Settings.SetKinectStatus(checkbox_kinectstatus.Checked);
        }

        private void pnl_content_Paint(object sender, PaintEventArgs e)
        {

        }


   }
}
