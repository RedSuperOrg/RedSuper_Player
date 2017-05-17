﻿using RedSuper_Player.Properties;
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

namespace RedSuper_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // LIST BOX WILL HAVE THE SAME DATA AS THE MUSIC LIST 
            listBoxMusic.DataSource = musicList;

            // CREATED DEFAULT DEVICE FOR VOLUME ON CALLOUT
            wave = new NAudio.Wave.WaveOut();

            // INITIAL VOLUME
            wave.Volume = 1.0f;
        }

        // VARIABLE FOR THE URL FOR YOUTUBE
        string _ytUrl;

        // LIST CREATED FOR THE SONGS ADDED TO THE MUSIC LISTBOX
        private IList<string> musicList = new BindingList<string>();

        // STREAM TO NULL UNTIL SOMETHING'S CHOSEN
        private NAudio.Wave.BlockAlignReductionStream stream = null;

        // OUTPUT IS NULL WHILE NOTHING'S CHOSEN 
        private NAudio.Wave.DirectSoundOut output = null;

        // CREATED VARIABLE TO ADJUST VOLUME OF THE AUDIO CONTEXT
        private NAudio.Wave.WaveOut wave;

        // VARIABLE TO ASSIGN LAST VOLUME ON "MUTE" CLICK
        private float lastVolume = 1.0f;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// MISTAKES WERE MADE //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void bunifuSliderMain_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabelEndTimer_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextboxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Resize(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string VideoId
        {
            // MATCH URL WITH VIDEO ON YOUTUBE
            get
            {
                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-z0-9-_]+)").Match(_ytUrl);
                return ytMatch.Success ? ytMatch.Groups[1].Value : string.Empty;
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// TRIPLE BUTTON (MAX, MIN, EXIT) //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Exits the program on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Maximizes or returns to normal depending on current state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            // If its maximized, go back to normal. Else, maximize
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Minimize program (HIDE)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// BROWSE FUNCTION (LOAD FILES) ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Opens file dialog too choose items to present
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonBrowse_Click_1(object sender, EventArgs e)
        {
            // ASSIGN THE CLASS
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();

            // CORRECTS THE INITIAL DIRECTORY, FILTERS, ENABLES MULTISELECT
            myOpenFileDialog.InitialDirectory = "c:\\";
            myOpenFileDialog.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File  (*.wav)|*.wav|All FILES (*.*)|*.*";
            myOpenFileDialog.FilterIndex = 1;
            myOpenFileDialog.RestoreDirectory = false;
            myOpenFileDialog.Multiselect = true;

            // POPS THE FILE DIALOG
            if (myOpenFileDialog.ShowDialog() != DialogResult.OK) return;

            // FOR EACH SONG BROWSED, ADD TO THE LISTBOX IF THERE'S NOT A COPY
            string[] songs = myOpenFileDialog.FileNames;
            foreach (string song in songs)
            {
                if (!musicList.Contains(song))
                {
                    musicList.Add(song);
                    listBoxMusic.Refresh();
                }
            }

            // START WITH NO SOUND SELECTED
            listBoxMusic.ClearSelected();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// MENU SLIDE (HIDE AND BACK) ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Changes colors to default or new
        /// Slides the Menu in or out
        /// Slides the logo in or out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonSlideMenu_Click(object sender, EventArgs e)
        {
            // IF IT'S HIDDEN, SHOW, ELSE HIDE
            if (panelMenu.Width == 55)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 200;
                bunifuTransitionSlidingMenu.ShowSync(panelMenu);
                bunifuImageButtonSlideMenu.Image = Resources.Expand_Arrow_96;
                bunifuFlatButtonBrowse.OnHovercolor = Color.Transparent;
                bunifuFlatButtonVideo.OnHovercolor = Color.Transparent;
                bunifuFlatButtonYoutube.OnHovercolor = Color.Transparent;
                bunifuFlatButtonMySongs.OnHovercolor = Color.Transparent;
                bunifuFlatButtonPlaylists.OnHovercolor = Color.Transparent;
                bunifuTransitionSlidingMenu1.ShowSync(panelText);
                bunifuTransitionSlidingMenu.HideSync(pictureBoxLogo);
            }
            else
            {
                bunifuTransitionSlidingMenu1.HideSync(panelText);
                panelMenu.Visible = false;
                panelMenu.Width = 55;
                bunifuImageButtonSlideMenu.Image = Resources.CollapseArrow;
                bunifuFlatButtonBrowse.OnHovercolor = Color.DimGray;
                bunifuFlatButtonVideo.OnHovercolor = Color.DimGray;
                bunifuFlatButtonYoutube.OnHovercolor = Color.DimGray;
                bunifuFlatButtonMySongs.OnHovercolor = Color.DimGray;
                bunifuFlatButtonPlaylists.OnHovercolor = Color.DimGray;
                bunifuTransitionSlidingMenu.ShowSync(panelMenu);
                bunifuTransitionSlidingMenu.ShowSync(pictureBoxLogo);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// METHOD TO RESET OUTPUT ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// READY TO USE THIS METHOD TO RESET OUTPUT
        /// </summary>
        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
            timerAudio.Enabled = false;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bunifuImageButtonPlay_Click(object sender, EventArgs e)
        {
            //IF OUTPUT IS ASSIGNED
            if (output != null)
            {
                //IF IT'S PLAYING, BUTTON PAUSES AND CHANGES TO PLAY IMAGE, ELSE, PLAY AND PAUSE IMAGE
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Pause();
                    bunifuImageButtonPlay.Image = Resources.Circled_Play_100__1_;
                }
                else
                {
                    // IF IT'S PAUSED, PLAY (PROTECTED FROM NO MUSIC CHOICE)
                    if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                    {
                        output.Play();
                        bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_100;
                    }
                }
                
                // RESETS TIMER WHEN MUSIC SELECTED CHANGES
                timerAudio.Enabled = true;
            } 
        }

       ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// CLEARS EVERYTHING ON EXIT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        /// <summary>
        /// POPS VIDEO PLAYER FORM (WIP)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonVideo_Click(object sender, EventArgs e)
        {
            Form2 video = new Form2(this);
            video.Show();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////// LIST BOX (SELECTING SONGS) ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// WILL PLAY SELECTED SONG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            // METHOD RESET
            DisposeWave();

            // SELECT SONG FROM LISTBOX 
            var selected = listBoxMusic.SelectedItem;
            string song = null;

            // IF SONG SELECTED, ADD STRING VARIABLE
            if (selected != null)
            {
                song = selected.ToString();
            }

            // IF SELECTED SONG'S RESULT == OK, ADD TO THE LIST BOX
            if (song != null && !song.Equals(""))
            {
                // CORRECT PROCEEDURE FOR EITHER MP3 OR WAV
                if (song.EndsWith(".mp3"))
                {
                    NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(song));
                    stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                }
                else if (song.EndsWith(".wav"))
                {
                    NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(song));
                    stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                }
                else throw new InvalidOperationException("Not a correct audio file type.");

                // ASSINGS NAUDIO TO OUTPUT AND PLAY
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                output.Play();

                // BOOL TO RESET TIMER
                timerAudio.Enabled = true;

                // TAGS FROM FILE TO EXTRA INFORMATION
                TagLib.File tagFile = TagLib.File.Create(song);
                string artist = tagFile.Tag.FirstAlbumArtist;
                string album = tagFile.Tag.Album;
                string title = tagFile.Tag.Title;

                // EXTRA INFORMATION PLACED ON LABEL
                bunifuCustomLabelArtistName.Text = artist;
                bunifuCustomLabelArtistExtraInfo.Text = album;
                
                //////////////Protection FROM ERRORS

                //Needs to have something written
                if (bunifuCustomLabelArtistName.Text.Length < 1)
                {
                    bunifuCustomLabelArtistName.Text = "Artist Name";
                }

                //SAME
                if (bunifuCustomLabelArtistExtraInfo.Text.Length < 1)
                {
                    bunifuCustomLabelArtistExtraInfo.Text = "Album";
                }

                // FILE TO ADD TO TABS

                var file = TagLib.File.Create(song);
                
                ////////////////Protection FROM ERRORS

                // If tag has lenght (!= 0) Add the picture
                if (file.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pictureBoxCoverSlider.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
                else
                {
                    pictureBoxCoverSlider.Image = Resources.Music_Record_Filled_100;
                }

                bunifuImageButtonPlay.Enabled = true;
                bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_100;
            }
        }

        /// <summary>
        /// VOLUME = SLIDER VALUE WILL BE THE AUDIO VOLUME FOR THE SONG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuSliderVolume_ValueChanged(object sender, EventArgs e)
        {
            float volume =  bunifuSliderVolume.Value / 100.0f;
            lastVolume = volume;
            wave.Volume = Math.Max(0.01f, volume);

        }

        /// <summary>
        /// IF IT HAS AN OUTPUT GO TO PREVIOUS SONG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonStart_Click(object sender, EventArgs e)
        {
            // IF OUTPUT ISN'T NULL
            if (output != null)
            {
                // IF SONG ISN'T AHEAD OF 1 SECOND, CHANGE TO PREVIOUS SONG, ELSE CHANGE IT'S TIME TO 0 SECONDS
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused || stream.CurrentTime.TotalSeconds < 1)
                {
                    listBoxMusic.SelectedIndex = (listBoxMusic.SelectedIndex - 1) % musicList.Count;
                }
                else
                {
                    stream.Position = 0;
                }
            }
        }

        /// <summary>
        /// GET TOTAL DURATION FROM THE AUDIO STREAM AND ASSIGN IT TO LABEL
        /// GET CURRENT TIME TO TRACK THE TIME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrAudio_Tick(object sender, EventArgs e)
        {
            // TOTAL DURATION
            string duration = stream.TotalTime.ToString("mm\\:ss");
            bunifuCustomLabelEndTimer.Text = duration;
            bunifuSliderMain.MaximumValue = (int)stream.TotalTime.TotalSeconds;

            // CURRENT TIMER
            string curTime = stream.CurrentTime.ToString("mm\\:ss");
            bunifuCustomLabelStartTimer.Text = curTime;
            bunifuSliderMain.Value = (int)stream.CurrentTime.TotalSeconds; 
        }

        // MAIN SLIDER WILL KEEP TRACK OF CURRENT TIME ON ITS VALUE
        private void bunifuSliderMain_Scroll(object sender, ScrollEventArgs e)
        {
            TimeSpan newPos = new TimeSpan(bunifuSliderMain.Value * 10000000); 
            stream.CurrentTime = newPos;
        }

        /// <summary>
        /// ON CLICK, MOVE TO NEXT SONG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonEnd_Click(object sender, EventArgs e)
        {
            // MOVE TO NEXT SONG ON MUSIC LIST BOX
            listBoxMusic.SelectedIndex = (listBoxMusic.SelectedIndex + 1) % musicList.Count;
        }

        /// <summary>
        /// IF IMAGE HAS BEEN CLICKED CHANGE TO OPPOSING IMAGE AND CHANGE SOUND
        /// IF CHANGED TO MUTED IMAGE, SOUND EQUALS TO MINIMUM VOLUME, ELSE CHANGE TO UNMUTED IMAGE AND LAST VOLUME 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonMute_Click(object sender, EventArgs e)
        {
            float volume = wave.Volume;

            // if volume is minimum, muted image, else move to last volume shown and unmuted image
            if (volume >= 0.01)
            {
                wave.Volume = 0.01f;
                bunifuImageButtonMute.Image = Resources.Muted_;
            }
            else
            {
                wave.Volume = lastVolume;
                bunifuImageButtonMute.Image = Resources.Unmuted_;
            }
        }

        // ON 'YOUTUBE' CLICK HIDE PANELS FROM AUDIO AND SHOW YOUTUBE CONTROLS
        private void bunifuFlatButtonYoutube_Click(object sender, EventArgs e)
        {
            webBrowserYoutube.Visible = true;
            panelYoutube.Visible = false;
            bunifuTransitionSlidingMenu.ShowSync(panelYoutube);
            panelYoutube.Visible = true;
        }

        // ON 'MYSONGS' CLICK RETURN TO AUDIO PLAYER
        private void bunifuFlatButtonMySongs_Click(object sender, EventArgs e)
        {
            webBrowserYoutube.Visible = false;
            panelYoutube.Visible = false;
        }

        // ON GO PRESS NAVIGATE THE PRESENT URL
        private void bunifuImageButtonGo_Click_1(object sender, EventArgs e)
        {
            _ytUrl = bunifuCustomTextboxYoutube.Text;
            webBrowserYoutube.Navigate($"http://youtube.com/v/{VideoId}?version=3");
        }

        // POPS NEW FORM WITH COLORS
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            FormOptions myOptions= new FormOptions(this);
            myOptions.ShowDialog();
        }

        // POPS FORM WITH FOUNDERS INFORMATION
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            FormAbout aboutUs = new FormAbout(this);
            aboutUs.ShowDialog();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
