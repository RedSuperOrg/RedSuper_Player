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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // MUSIC LIST BOX WILL HAVE THE SAME DATA AS THE MUSIC LIST 
            listBoxMusic.DataSource = musicList;

            // CREATED DEFAULT DEVICE FOR VOLUME ON CALLOUT
            wave = new NAudio.Wave.WaveOut();

            // VIDEO LIST BOX WILL HAVE THE SAME DATA AS THE VIDEO LIST 
            listBoxVideos.DataSource = videoList;

            // INITIAL VOLUME
            wave.Volume = 1.0f;

            bunifuThinButton23.BackColor = Color.Transparent;
            bunifuThinButton24.BackColor = Color.Transparent;
        }

        private Video video;

        private int selectedIndex = 0;

        // VARIABLE FOR THE URL FOR YOUTUBE
        string _ytUrl;

        // LIST CREATED FOR THE SONGS ADDED TO THE MUSIC LISTBOX
        private IList<string> musicList = new BindingList<string>();

        // LIST CREATED FOR THE VIDEOS ADDED TO THE VIDEO LISTBOX
        private IList<string> videoList = new BindingList<string>();

        // STREAM TO NULL UNTIL SOMETHING'S CHOSEN
        private NAudio.Wave.BlockAlignReductionStream stream = null;

        // OUTPUT IS NULL WHILE NOTHING'S CHOSEN 
        private NAudio.Wave.DirectSoundOut output = null;

        // CREATED VARIABLE TO ADJUST VOLUME OF THE AUDIO CONTEXT
        private NAudio.Wave.WaveOut wave;

        // VARIABLE TO ASSIGN LAST VOLUME ON "MUTE" CLICK
        private float lastVolume = 1.0f;

        bool type = true;

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
        /// Maximizes or returns to normal depending on current state with double click on the top panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTop_DoubleClick(object sender, EventArgs e)
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

            if (type == true)
            {
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
                pictureBoxEqualizer.Enabled = false;
            }
            else
            {
                myOpenFileDialog.InitialDirectory = "c:\\";
                myOpenFileDialog.Filter = "WMV File (*.wmv)|*.wmv|All FILES (*.*)|*.*";
                myOpenFileDialog.FilterIndex = 1;
                myOpenFileDialog.RestoreDirectory = false;
                myOpenFileDialog.Multiselect = true;

                // POPS THE FILE DIALOG
                if (myOpenFileDialog.ShowDialog() != DialogResult.OK) return;

                // FOR EACH SONG BROWSED, ADD TO THE LISTBOX IF THERE'S NOT A COPY
                string[] videos = myOpenFileDialog.FileNames;
                foreach (string video in videos)
                {
                    if (!videoList.Contains(video))
                    {
                        videoList.Add(video);
                        listBoxVideos.Refresh();
                    }
                }

                pictureBoxEqualizer.Enabled = false;
            }
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

                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                {
                    bunifuImageButtonSlideMenu.Image = Resources.Expand_Arrow_96;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonSlideMenu.Image = Resources.Expand_Arrow_Blue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonSlideMenu.Image = Resources.Expand_Arrow_Orange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonSlideMenu.Image = Resources.Expand_Arrow_Green;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonSlideMenu.Image = Resources.Expand_Arrow_Pink;
                                }
                            }
                        }
                    }
                }

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

                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                {
                    bunifuImageButtonSlideMenu.Image = Resources.CollapseArrow;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonSlideMenu.Image = Resources.CollapseArrowBlue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonSlideMenu.Image = Resources.CollapseArrowOrange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonSlideMenu.Image = Resources.CollapseArrowGreen;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonSlideMenu.Image = Resources.CollapseArrowPink;
                                }
                            }
                        }
                    }
                }


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
                    //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                    {
                        bunifuImageButtonPlay.Image = Resources.Circled_Play_100__1_;
                    }
                    else
                    {
                        //BLUE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                        {
                            bunifuImageButtonPlay.Image = Resources.Circled_Play_100Blue;
                        }
                        else
                        {
                            //ORANGE
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                            {
                                bunifuImageButtonPlay.Image = Resources.Circled_Play_100Orange;
                            }
                            else
                            {
                                //GREEN
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                                {
                                    bunifuImageButtonPlay.Image = Resources.Circled_Play_100Green;
                                }
                                else
                                {
                                    //PINK
                                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                    {
                                        bunifuImageButtonPlay.Image = Resources.Circled_Play_100Pink;
                                    }
                                }
                            }
                        }
                    }
                    pictureBoxEqualizer.Enabled = false;
                }
                else
                {
                    // IF IT'S PAUSED, PLAY (PROTECTED FROM NO MUSIC CHOICE)
                    if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                    {
                        output.Play();
                        //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                        {
                            bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_100;
                        }
                        else
                        {
                            //BLUE
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                            {
                                bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Blue;
                            }
                            else
                            {
                                //ORANGE
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                                {
                                    bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Orange;
                                }
                                else
                                {
                                    //GREEN
                                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                                    {
                                        bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Green;
                                    }
                                    else
                                    {
                                        //PINK
                                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                        {
                                            bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Pink;
                                        }
                                    }
                                }
                            }
                        }
                        pictureBoxEqualizer.Enabled = true;
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
                    pictureBoxSideCover.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(170, 170, null, IntPtr.Zero);
                    pictureBoxSideCover.Visible = false;
                    bunifuTransitionSlidingMenu1.ShowSync(pictureBoxSideCover);
                }
                else
                {
                    //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                    {
                        pictureBoxCoverSlider.Image = Resources.Music_Record_Filled_100;
                        pictureBoxSideCover.Image = Resources.Music_Record_Filled_100;
                    }
                    else
                    {
                        //BLUE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                        {
                            pictureBoxCoverSlider.Image = Resources.Music_Record_FilledBlue;
                            pictureBoxSideCover.Image = Resources.Music_Record_FilledBlue;
                        }
                        else
                        {
                            //ORANGE
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                            {
                                pictureBoxCoverSlider.Image = Resources.Music_Record_FilledOrange;
                                pictureBoxSideCover.Image = Resources.Music_Record_FilledOrange;
                            }
                            else
                            {
                                //GREEN
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                                {
                                    pictureBoxCoverSlider.Image = Resources.Music_Record_FilledGreen;
                                    pictureBoxSideCover.Image = Resources.Music_Record_FilledGreen;
                                }
                                else
                                {
                                    //PINK
                                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                    {
                                        pictureBoxCoverSlider.Image = Resources.Music_Record_FilledPink;
                                        pictureBoxSideCover.Image = Resources.Music_Record_FilledPink;
                                    }
                                }
                            }
                        }
                    }
                }

                bunifuImageButtonPlay.Enabled = true;
                pictureBoxEqualizer.Visible = true;
                pictureBoxEqualizer.Enabled = true;

                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                {
                    bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_100;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Blue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Orange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Green;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonPlay.Image = Resources.Circled_Pause_Filled_Pink;
                                }
                            }
                        }
                    }
                }
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
            wave.Volume = Math.Max(0.00f, volume);
            if (bunifuSliderVolume.Value == 0)
            {
                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                {
                    bunifuImageButtonMute.Image = Resources.Muted_;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonMute.Image = Resources.MuteBlue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonMute.Image = Resources.MuteOrange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonMute.Image = Resources.MuteGreen;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonMute.Image = Resources.MutePink;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                {
                    bunifuImageButtonMute.Image = Resources.Unmuted_;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonMute.Image = Resources.Room_SoundBlue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonMute.Image = Resources.Room_SoundOrange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonMute.Image = Resources.Room_SoundGreen;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonMute.Image = Resources.Room_SoundPink;
                                }
                            }
                        }
                    }
                }
            }
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

        /// <summary>
        /// CHANGES THE OUTPUT AS THE VALUE CHANGES ON THE SLIDER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuSliderMain_ValueChanged(object sender, EventArgs e)
        {
            if (output != null)
            {
                TimeSpan newPos = new TimeSpan(bunifuSliderMain.Value * 10000000);
                stream.CurrentTime = newPos;
            }
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
                wave.Volume = 0.00f;
                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15))
                {
                    bunifuImageButtonMute.Image = Resources.Muted_;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonMute.Image = Resources.MuteBlue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonMute.Image = Resources.MuteOrange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonMute.Image = Resources.MuteGreen;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonMute.Image = Resources.MutePink;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                wave.Volume = lastVolume;
                //CHECKS THE COLOR OF THE FORM TO CHANGE ARROW ICON (RED)
                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(190, 1, 15)) 
                {
                    bunifuImageButtonMute.Image = Resources.Unmuted_;
                }
                else
                {
                    //BLUE
                    if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(0, 72, 251))
                    {
                        bunifuImageButtonMute.Image = Resources.Room_SoundBlue;
                    }
                    else
                    {
                        //ORANGE
                        if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 102, 0))
                        {
                            bunifuImageButtonMute.Image = Resources.Room_SoundOrange;
                        }
                        else
                        {
                            //GREEN
                            if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(84, 204, 84))
                            {
                                bunifuImageButtonMute.Image = Resources.Room_SoundGreen;
                            }
                            else
                            {
                                //PINK
                                if (bunifuFlatButtonBrowse.OnHoverTextColor == Color.FromArgb(255, 0, 128))
                                {
                                    bunifuImageButtonMute.Image = Resources.Room_SoundPink;
                                }
                            }
                        }
                    }
                }
            }
        }

        // ON 'YOUTUBE' CLICK HIDE PANELS FROM AUDIO AND SHOW YOUTUBE CONTROLS
        private void bunifuFlatButtonYoutube_Click(object sender, EventArgs e)
        {
            if (webBrowserYoutube.Visible == false)
            {
                panelVideo.Visible = false;
                panelVideoTools.Visible = false;
                webBrowserYoutube.Visible = true;
                panelYoutube.Visible = false;
                bunifuTransitionSlidingMenu.ShowSync(panelYoutube);
                panelYoutube.Visible = true;
                listBoxVideos.Visible = false;
            }
        }

        // ON 'MYSONGS' CLICK RETURN TO AUDIO PLAYER
        private void bunifuFlatButtonMySongs_Click(object sender, EventArgs e)
        {
            type = true;
            webBrowserYoutube.Visible = false;
            panelYoutube.Visible = false;
            panelVideo.Visible = false;
            panelVideoTools.Visible = false;
            listBoxVideos.Visible = false;
        }

        private void bunifuFlatButtonVideo_Click(object sender, EventArgs e)
        {
            type = false;
            if (panelVideo.Visible == false)
            {
                panelVideo.Visible = true;
                webBrowserYoutube.Visible = false;
                panelYoutube.Visible = true;
                panelVideoTools.Visible = true;
                panelVideoTools.BringToFront();
                listBoxVideos.Visible = true;
            }
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
        ////////////////////////////////////////////////////// COLORS RELATED ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Image panelTopImage
        {
            get { return panelTop.BackgroundImage; }
            set { panelTop.BackgroundImage = value; }
        }

        public Color panelTopColor
        {
            get { return panelTop.BackColor; }
            set { panelTop.BackColor = value; }
        }

        //Font color for colors button (background color)
        public Color colorsButtonActiveForeColor
        {
            get { return bunifuThinButton23.ActiveForecolor; }
            set { bunifuThinButton23.ActiveForecolor = value; }
        }

        //Fill Color for colors button(background color)
        public Color colorsButtonIdleFillColor
        {
            get { return bunifuThinButton23.IdleFillColor; }
            set { bunifuThinButton23.IdleFillColor = value; }
        }

        public Color colorsButtonActiveFillColor
        {
            get { return bunifuThinButton23.ActiveFillColor; }
            set { bunifuThinButton23.ActiveFillColor = value; }
        }

        public Color colorsButtonActiveLineColor
        {
            get { return bunifuThinButton23.ActiveLineColor; }
            set { bunifuThinButton23.ActiveLineColor = value; }
        }

        public Color colorsButtonForeColor
        {
            get { return bunifuThinButton23.ForeColor; }
            set { bunifuThinButton23.ForeColor = value; }
        }

        public Color colorsButtonIdleForeColor
        {
            get { return bunifuThinButton23.IdleForecolor; }
            set { bunifuThinButton23.IdleForecolor = value; }
        }

        public Color colorsButtonIdleLineColor
        {
            get { return bunifuThinButton23.IdleLineColor; }
            set { bunifuThinButton23.IdleLineColor = value; }
        }

        ////////////

        public Color aboutButtonActiveForeColor
        {
            get { return bunifuThinButton24.ActiveForecolor; }
            set { bunifuThinButton24.ActiveForecolor = value; }
        }

        public Color aboutButtonIdleFillColor
        {
            get { return bunifuThinButton24.IdleFillColor; }
            set { bunifuThinButton24.IdleFillColor = value; }
        }

        public Color aboutButtonActiveFillColor
        {
            get { return bunifuThinButton24.ActiveFillColor; }
            set { bunifuThinButton24.ActiveFillColor = value; }
        }

        public Color aboutButtonActiveLineColor
        {
            get { return bunifuThinButton24.ActiveLineColor; }
            set { bunifuThinButton24.ActiveLineColor = value; }
        }

        public Color aboutButtonForeColor
        {
            get { return bunifuThinButton24.ForeColor; }
            set { bunifuThinButton24.ForeColor = value; }
        }

        public Color aboutButtonIdleForeColor
        {
            get { return bunifuThinButton24.IdleForecolor; }
            set { bunifuThinButton24.IdleForecolor = value; }
        }

        public Color aboutButtonIdleLineColor
        {
            get { return bunifuThinButton24.IdleLineColor; }
            set { bunifuThinButton24.IdleLineColor = value; }
        }

        public Color topSideLabel
        {
            get { return bunifuCustomLabelVersionText.ForeColor; }
            set { bunifuCustomLabelVersionText.ForeColor = value; }
        }

        public Color topMainLabel
        {
            get { return bunifuCustomLabelTopText.ForeColor; }
            set { bunifuCustomLabelTopText.ForeColor = value; }
        }

        public Image browseButtonIcon
        {
            get { return bunifuFlatButtonBrowse.Iconimage; }
            set { bunifuFlatButtonBrowse.Iconimage = value; }
        }

        public Color browseButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonBrowse.OnHoverTextColor; }
            set { bunifuFlatButtonBrowse.OnHoverTextColor = value; }
        }

        public Image videoButtonIcon
        {
            get { return bunifuFlatButtonVideo.Iconimage; }
            set { bunifuFlatButtonVideo.Iconimage = value; }
        }

        public Color videoButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonVideo.OnHoverTextColor; }
            set { bunifuFlatButtonVideo.OnHoverTextColor = value; }
        }

        public Image youtubeButtonIcon
        {
            get { return bunifuFlatButtonYoutube.Iconimage; }
            set { bunifuFlatButtonYoutube.Iconimage = value; }
        }

        public Color youtubeButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonYoutube.OnHoverTextColor; }
            set { bunifuFlatButtonYoutube.OnHoverTextColor = value; }
        }

        public Image mySongsButtonIcon
        {
            get { return bunifuFlatButtonMySongs.Iconimage; }
            set { bunifuFlatButtonMySongs.Iconimage = value; }
        }

        public Color mySongsButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonMySongs.OnHoverTextColor; }
            set { bunifuFlatButtonMySongs.OnHoverTextColor = value; }
        }

        public Image playlistsButtonIcon
        {
            get { return bunifuFlatButtonPlaylists.Iconimage; }
            set { bunifuFlatButtonPlaylists.Iconimage = value; }
        }

        public Color playlistsButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonPlaylists.OnHoverTextColor; }
            set { bunifuFlatButtonPlaylists.OnHoverTextColor = value; }
        }

        public Image menuButtonIcon
        {
            get { return bunifuImageButtonSlideMenu.Image; }
            set { bunifuImageButtonSlideMenu.Image = value; }
        }

        public Image coverIcon
        {
            get { return pictureBoxCoverSlider.Image; }
            set { pictureBoxCoverSlider.Image = value; }
        }

        public Color trackBarIndicatorColor
        {
            get { return bunifuSliderMain.IndicatorColor; }
            set { bunifuSliderMain.IndicatorColor = value; }
        }

        public Image startButtonIcon
        {
            get { return bunifuImageButtonStart.Image; }
            set { bunifuImageButtonStart.Image = value; }
        }

        public Image playButtonIcon
        {
            get { return bunifuImageButtonPlay.Image; }
            set { bunifuImageButtonPlay.Image = value; }
        }

        public Image endButtonIcon
        {
            get { return bunifuImageButtonEnd.Image; }
            set { bunifuImageButtonEnd.Image = value; }
        }

        public Image settingsButtonIcon
        {
            get { return bunifuImageButtonSettings.Image; }
            set { bunifuImageButtonSettings.Image = value; }
        }

        public Image soundButtonIcon
        {
            get { return bunifuImageButtonMute.Image; }
            set { bunifuImageButtonMute.Image = value; }
        }

        public Image goButtonIcon
        {
            get { return bunifuImageButtonGo.Image; }
            set { bunifuImageButtonGo.Image = value; }
        }

        public Color volumeSliderIndicatorColor
        {
            get { return bunifuSliderVolume.IndicatorColor; }
            set { bunifuSliderVolume.IndicatorColor = value; }
        }

        public Image equalizer
        {
            get { return pictureBoxEqualizer.Image; }
            set { pictureBoxEqualizer.Image = value; }
        }

        ////////////Video

        public Image fullScreenIcon
        {
            get { return bunifuImageButtonFullScreenVideo.Image; }
            set { bunifuImageButtonFullScreenVideo.Image = value; }
        }

        public Image rewindIcon
        {
            get { return bunifuImageButtonRewindVideo.Image; }
            set { bunifuImageButtonRewindVideo.Image = value; }
        }

        public Image fastForwardIcon
        {
            get { return bunifuImageButtonFastForwardVideo.Image; }
            set { bunifuImageButtonFastForwardVideo.Image = value; }
        }

        public Image stopIcon
        {
            get { return bunifuImageButtonStopVideo.Image; }
            set { bunifuImageButtonStopVideo.Image = value; }
        }

        public Color trackBarVideoIndicatorColor
        {
            get { return bunifuSliderMainVideo.IndicatorColor; }
            set { bunifuSliderMainVideo.IndicatorColor = value; }
        }

        public Color volumeSliderVideoColor
        {
            get { return bunifuSliderVolumeVideo.IndicatorColor; }
            set { bunifuSliderVolumeVideo.IndicatorColor = value; }
        }

        public Image startVideoIcon
        {
            get { return bunifuImageButtonSkipToStartVideo.Image; }
            set { bunifuImageButtonSkipToStartVideo.Image = value; }
        }

        public Image playVideoIcon
        {
            get { return bunifuImageButtonPlayVideo.Image; }
            set { bunifuImageButtonPlayVideo.Image = value; }
        }

        public Image endVideoIcon
        {
            get { return bunifuImageButtonSkipToEndVideo.Image; }
            set { bunifuImageButtonSkipToEndVideo.Image = value; }
        }

        public Image soundVideoIcon
        {
            get { return bunifuImageButtonSoundVideo.Image; }
            set { bunifuImageButtonSoundVideo.Image = value; }
        }

        public Image optionsVideoIcon
        {
            get { return bunifuImageButtonOptionsVideo.Image; }
            set { bunifuImageButtonOptionsVideo.Image = value; }
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////v

        private void bunifuImageButtonSkipToEndVideo_Click(object sender, EventArgs e)
        {
            int index = listBoxVideos.SelectedIndex;
            index++;
            selectedIndex = index;
            listBoxVideos.SelectedIndex = index;
        }


        private void listBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selected = listBoxMusic.SelectedItem;
            video = new Video(selected.ToString(), false);
            video.Owner = panelVideo;
            video.Play();
        }

        private void bunifuImageButtonSkipToStartVideo_Click(object sender, EventArgs e)
        {
            int index = listBoxVideos.SelectedIndex;
            index--;
            selectedIndex = index;
            listBoxVideos.SelectedIndex = index;
        }

        private void bunifuImageButtonPlayVideo_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
            }
            else if (video.Playing)
            {
                video.Pause();
            }
        }

        private void bunifuSliderVolumeVideo_ValueChanged(object sender, EventArgs e)
        {
            video.Audio.Volume = bunifuSliderVolumeVideo.Value;
        }

        private void bunifuImageButtonFullScreenVideo_Click(object sender, EventArgs e)
        {

        }

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
