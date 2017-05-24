using RedSuper_Player.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using TagLib;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.DirectX.AudioVideoPlayback;

namespace RedSuper_Player
{
    public partial class Form1
    {
        // LIST CREATED FOR THE VIDEOS ADDED TO THE VIDEO LISTBOX
        private IList<string> videoList = new BindingList<string>();

        private Video video;

        private void bunifuImageButtonPlayVideo_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I REACHED HERE");
            var temp = listBoxVideos.SelectedItem;
            if (temp == null) return;
            string videoPath = listBoxVideos.SelectedItem.ToString();
            if (videoPath != null && !videoPath.Equals(""))
            {
                /*
                Video video = new Video("C:\\Users\\Public\\Videos\\Sample Videos\\Wildlife.wmv");
                video.Play();
                */

                try
                {
                    Form form1 = new Form();
                    form1.Show();
                    form1.WindowState = FormWindowState.Maximized;
                    Video movie = new Video(videoPath);
                    movie.Owner = form1;
                    movie.Size = new Size(1920, 1080);
                    movie.Play();
                } catch(Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
                video = new Video(videoPath, false);
                video.Owner = panelVideo;
                video.Size = new Size(1920, 1080);
            }

        }

        private void bunifuImageBtgyfghgfhgfhghuttonPlayVideo_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I REACHED HERE");
            var temp = listBoxVideos.SelectedItem;
            if (temp == null) return;
            string videoPath = listBoxVideos.SelectedItem.ToString();
            if (videoPath != null && !videoPath.Equals(""))
            {
                /*
                try
                {
                    video.Stop();
                    video.Dispose();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
                */
                /*
                pnlVideo.Size = pnlSize;
                video.Play();
                tmrVideo.Enabled = true;
                btnPlayPause.Text = "Pause";
                video.Ending += Video_Ending;
                lblVideo.Text = lstVideos.Text;
                */

                video = new Video(videoPath, false);
                video.Owner = panelVideo;
                //panelVideo.Size = panelSize;
                video.Play();

            }

        }

        private void panelVideo_Paint(object sender, PaintEventArgs e)
        {

        }


        // ON 'VIDEO' CLICK ADJUST PANELS FOR VIDEO CONTROLS
        private void bunifuFlatButtonVideo_Click(object sender, EventArgs e)
        {
            type = false;
            if (panelVideo.Visible == false)
            //CHECKS CURRENT TYPE TO AVOID RANDOM ANIMATIONS
            {
                panelVideo.Visible = true;
                webBrowserYoutube.Visible = false;
                panelYoutube.Visible = true;
                panelVideoTools.Visible = true;
                panelVideoTools.BringToFront();
                listBoxVideos.Visible = true;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////// VIDEO RELATED ////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*        
        private Video video;
        private string[] videoPaths;
        private string folderPath = @"C:\Users\";
        private int selectedIndex = 0;
        private Size formSize;
        private Size pnlSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);

            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            if (videoPaths != null)
            {
                foreach (string path in videoPaths)
                {
                    string vid = path.Replace(folderPath, string.Empty);
                    vid = vid.Replace(".wmv", string.Empty);
                    lstVideos.Items.Add(vid);
                }
            }
            lstVideos.SelectedIndex = selectedIndex;
        }

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch { }

            int index = lstVideos.SelectedIndex;
            selectedIndex = index;
            video = new Video(videoPaths[index], false);
            video.Owner = pnlVideo;
            pnlVideo.Size = pnlSize;
            video.Play();
            tmrVideo.Enabled = true;
            btnPlayPause.Text = "Pause";
            video.Ending += Video_Ending;
            lblVideo.Text = lstVideos.Text;
        }

        private void Video_Ending(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(2000);

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        NextVideo();
                    }));
                }
            });
        }

        private void NextVideo()
        {
            int index = lstVideos.SelectedIndex;
            index++;
            if (index > videoPaths.Length - 1)
                index = 0;
            selectedIndex = index;
            lstVideos.SelectedIndex = index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextVideo();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        private void PreviousVideo()
        {
            int index = lstVideos.SelectedIndex;
            index--;
            if (index == -1)
                index = videoPaths.Length - 1;
            selectedIndex = index;
            lstVideos.SelectedIndex = index;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
                tmrVideo.Enabled = true;
                btnPlayPause.Text = "Pause";
            }
            else if (video.Playing)
            {
                video.Pause();
                tmrVideo.Enabled = false;
                btnPlayPause.Text = "Play";
            }
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            video.Owner = this;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //exit full screen when escape is pressed
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                this.Size = formSize;
                video.Owner = pnlVideo;
                pnlVideo.Size = pnlSize;
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            video.Audio.Volume = trackVolume.Value;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            trackVolume.Visible = !trackVolume.Visible;
        }

        private void tmrVideo_Tick(object sender, EventArgs e)
        {
            int currentTime = Convert.ToInt32(video.CurrentPosition);
            int maxTime = Convert.ToInt32(video.Duration);

            lblVideoPosition.Text = string.Format("{0:00}:{1:00}:{2:00}", currentTime / 3600, (currentTime / 60) % 60, currentTime % 60)
                                    + " / " +
                                    string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }
            */

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
