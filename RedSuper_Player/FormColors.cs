using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSuper_Player
{
    public partial class FormColors : Form
    {
        // ASSIGNS TO MAIN FORM
        Form1 fr1Local;

        /// <summary>
        /// INITIALIZES FORM WITH ABILITY TO 'MODIFY OBJECTS' ON MAIN FORM
        /// </summary>
        /// <param name="colors"></param>
        public FormColors(Form1 colors)
        {
            InitializeComponent();
            fr1Local = colors;
        }

        /// <summary>
        /// CLOSE COLORS FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonColorsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // INITIALIZES PUBLIC FORM 1 WITH GET/SET METHOD TO GET COLORS ON CLICK AND SET ON MAIN FORM
        /// <summary>
        /// gets value to set on main
        /// </summary>
        public Form1 Form1
        {
            get { return fr1Local; }
            set { fr1Local = value; }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////// COLORS RELATED / ON EACH COLOR'S CLICK, GET VALUE AND RETURN //////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// GET FOR RED
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonColorsRed_Click(object sender, EventArgs e)
        {
            fr1Local.panelTopImage = Properties.Resources.Spotify_Effect_OP1T3;
            fr1Local.panelTopColor = Color.FromArgb(248, 97, 97);
            fr1Local.colorsButtonActiveForeColor = Color.FromArgb(248, 97, 97);
            fr1Local.colorsButtonIdleFillColor = Color.FromArgb(248, 97, 97);
            fr1Local.colorsButtonActiveFillColor = Color.White;
            fr1Local.colorsButtonActiveLineColor = Color.White;
            fr1Local.colorsButtonForeColor = Color.White;
            fr1Local.colorsButtonIdleForeColor = Color.White;
            fr1Local.colorsButtonIdleLineColor = Color.White;
            fr1Local.aboutButtonActiveForeColor = Color.FromArgb(248, 97, 97);
            fr1Local.aboutButtonIdleFillColor = Color.FromArgb(248, 97, 97);
            fr1Local.aboutButtonActiveFillColor = Color.White;
            fr1Local.aboutButtonActiveLineColor = Color.White;
            fr1Local.aboutButtonForeColor = Color.White;
            fr1Local.aboutButtonIdleForeColor = Color.White;
            fr1Local.aboutButtonIdleLineColor = Color.White;
            fr1Local.topMainLabel = Color.Transparent;
            fr1Local.topSideLabel = Color.Transparent;
            fr1Local.browseButtonIcon = Properties.Resources.Browse;
            fr1Local.browseButtonOnHoverTextColor = Color.FromArgb(190, 1, 15);
            fr1Local.videoButtonIcon = Properties.Resources.video1;
            fr1Local.videoButtonOnHoverTextColor = Color.FromArgb(190, 1, 15);
            fr1Local.youtubeButtonIcon = Properties.Resources.YouTube_1000;
            fr1Local.youtubeButtonOnHoverTextColor = Color.FromArgb(190, 1, 15);
            fr1Local.mySongsButtonIcon = Properties.Resources.music;
            fr1Local.mySongsButtonOnHoverTextColor = Color.FromArgb(190, 1, 15);
            fr1Local.playlistsButtonIcon = Properties.Resources.playlist;
            fr1Local.playlistsButtonOnHoverTextColor = Color.FromArgb(190, 1, 15);
            fr1Local.menuButtonIcon = Properties.Resources.Expand_Arrow_96;
            // CHECKS FOR MUSIC COVER
            if (fr1Local.musicCover != true)
            {
                fr1Local.coverIcon = Properties.Resources.Music_Record_Filled_100;
            }
            fr1Local.trackBarIndicatorColor = Color.FromArgb(190, 1, 15);
            fr1Local.startButtonIcon = Properties.Resources.Skip_to_Start_100;
            //CHECKS MUSIC STATUS (PLAYING OR PAUSED)
            if (fr1Local.musicStatus != true)
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Play_100__1_;
            }
            else
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Pause_Filled_100;
            }
            fr1Local.endButtonIcon = Properties.Resources.End_100;
            fr1Local.settingsButtonIcon = Properties.Resources.Horizontal_Settings_Mixer_100;
            fr1Local.soundButtonIcon = Properties.Resources.Unmuted_;
            fr1Local.goButtonIcon = Properties.Resources.Go_100;
            fr1Local.volumeSliderIndicatorColor = Color.FromArgb(190, 1, 15);

            fr1Local.equalizer = Properties.Resources.rhythm;
            fr1Local.fullScreenIcon = Properties.Resources.Full_Screen_100;
            fr1Local.rewindIcon = Properties.Resources.Rewind_100;
            fr1Local.fastForwardIcon = Properties.Resources.Fast_Forward_100;
            fr1Local.stopIcon = Properties.Resources.Stop_100;
            fr1Local.trackBarVideoIndicatorColor = Color.FromArgb(190, 1, 15);
            fr1Local.volumeSliderVideoColor = Color.FromArgb(190, 1, 15);
            fr1Local.startVideoIcon = Properties.Resources.Skip_to_Start_100;
            fr1Local.playVideoIcon = Properties.Resources.Circled_Play_100__1_;
            fr1Local.endVideoIcon = Properties.Resources.End_100;
            fr1Local.optionsVideoIcon = Properties.Resources.Horizontal_Settings_Mixer_100;
            fr1Local.soundVideoIcon = Properties.Resources.Unmuted_;
        }

        /// <summary>
        /// get for blue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonColorsBlue_Click(object sender, EventArgs e)
        {
            fr1Local.panelTopImage = Properties.Resources.Spotify_Effect_The_OneBlue;
            fr1Local.panelTopColor = Color.FromArgb(135, 250, 217);
            fr1Local.colorsButtonActiveForeColor = Color.FromArgb(135, 250, 217);
            fr1Local.colorsButtonIdleFillColor = Color.FromArgb(135, 250, 217);
            fr1Local.colorsButtonActiveFillColor = Color.DimGray;
            fr1Local.colorsButtonActiveLineColor = Color.DimGray;
            fr1Local.colorsButtonForeColor = Color.DimGray;
            fr1Local.colorsButtonIdleForeColor = Color.DimGray;
            fr1Local.colorsButtonIdleLineColor = Color.DimGray;
            fr1Local.aboutButtonActiveForeColor = Color.FromArgb(135, 250, 217);
            fr1Local.aboutButtonIdleFillColor = Color.FromArgb(135, 250, 217);
            fr1Local.aboutButtonActiveFillColor = Color.DimGray;
            fr1Local.aboutButtonActiveLineColor = Color.DimGray;
            fr1Local.aboutButtonForeColor = Color.DimGray;
            fr1Local.aboutButtonIdleForeColor = Color.DimGray;
            fr1Local.aboutButtonIdleLineColor = Color.DimGray;
            fr1Local.topMainLabel = Color.DimGray;
            fr1Local.topSideLabel = Color.DimGray;
            fr1Local.browseButtonIcon = Properties.Resources.BrowseBlue;
            fr1Local.browseButtonOnHoverTextColor = Color.FromArgb(0, 72, 251);
            fr1Local.videoButtonIcon = Properties.Resources.videoBlue;
            fr1Local.videoButtonOnHoverTextColor = Color.FromArgb(0, 72, 251);
            fr1Local.youtubeButtonIcon = Properties.Resources.YouTubeBlue;
            fr1Local.youtubeButtonOnHoverTextColor = Color.FromArgb(0, 72, 251);
            fr1Local.mySongsButtonIcon = Properties.Resources.musicBlue;
            fr1Local.mySongsButtonOnHoverTextColor = Color.FromArgb(0, 72, 251);
            fr1Local.playlistsButtonIcon = Properties.Resources.playlistBlue;
            fr1Local.playlistsButtonOnHoverTextColor = Color.FromArgb(0, 72, 251);
            fr1Local.menuButtonIcon = Properties.Resources.Expand_Arrow_Blue;
            // CHECKS FOR MUSIC COVER
            if (fr1Local.musicCover != true)
            {
                fr1Local.coverIcon = Properties.Resources.Music_Record_FilledBlue;
            }
            fr1Local.trackBarIndicatorColor = Color.FromArgb(0, 72, 251);
            fr1Local.startButtonIcon = Properties.Resources.Skip_to_Start_Blue;
            //CHECKS MUSIC STATUS (PLAYING OR PAUSED)
            if (fr1Local.musicStatus != true)
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Play_100Blue;
            }
            else
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Pause_Filled_Blue;
            }
            fr1Local.endButtonIcon = Properties.Resources.End_Blue;
            fr1Local.settingsButtonIcon = Properties.Resources.Horizontal_Settings_Mixer_Blue;
            fr1Local.soundButtonIcon = Properties.Resources.Room_SoundBlue;
            fr1Local.goButtonIcon = Properties.Resources.Go_Blue;
            fr1Local.volumeSliderIndicatorColor = Color.FromArgb(0, 72, 251);

            fr1Local.equalizer = Properties.Resources.equalizerBlue;
            fr1Local.fullScreenIcon = Properties.Resources.Full_ScreenBlue;
            fr1Local.rewindIcon = Properties.Resources.RewindBlue;
            fr1Local.fastForwardIcon = Properties.Resources.Fast_ForwardBlue;
            fr1Local.stopIcon = Properties.Resources.StopBlue;
            fr1Local.trackBarVideoIndicatorColor = Color.FromArgb(0, 72, 251);
            fr1Local.volumeSliderVideoColor = Color.FromArgb(0, 72, 251);
            fr1Local.startVideoIcon = Properties.Resources.Skip_to_Start_Blue;
            fr1Local.playVideoIcon = Properties.Resources.Circled_Play_100Blue;
            fr1Local.endVideoIcon = Properties.Resources.End_Blue;
            fr1Local.optionsVideoIcon = Properties.Resources.Horizontal_Settings_Mixer_Blue;
            fr1Local.soundVideoIcon = Properties.Resources.Room_SoundBlue;
        }

        /// <summary>
        /// get for green
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonColorsGreen_Click(object sender, EventArgs e)
        {
            fr1Local.panelTopImage = Properties.Resources.Spotify_Effect_The_OneGreen;
            fr1Local.panelTopColor = Color.FromArgb(113, 223, 110);
            fr1Local.colorsButtonActiveForeColor = Color.FromArgb(113, 223, 110);
            fr1Local.colorsButtonIdleFillColor = Color.FromArgb(113, 223, 110);
            fr1Local.colorsButtonActiveFillColor = Color.Black;
            fr1Local.colorsButtonActiveLineColor = Color.Black;
            fr1Local.colorsButtonForeColor = Color.Black;
            fr1Local.colorsButtonIdleForeColor = Color.Black;
            fr1Local.colorsButtonIdleLineColor = Color.Black;
            fr1Local.aboutButtonActiveForeColor = Color.FromArgb(113, 223, 110);
            fr1Local.aboutButtonIdleFillColor = Color.FromArgb(113, 223, 110);
            fr1Local.aboutButtonActiveFillColor = Color.Black;
            fr1Local.aboutButtonActiveLineColor = Color.Black;
            fr1Local.aboutButtonForeColor = Color.Black;
            fr1Local.aboutButtonIdleForeColor = Color.Black;
            fr1Local.aboutButtonIdleLineColor = Color.Black;
            fr1Local.topMainLabel = Color.Black;
            fr1Local.topSideLabel = Color.Black;
            fr1Local.browseButtonIcon = Properties.Resources.BrowseGreen;
            fr1Local.browseButtonOnHoverTextColor = Color.FromArgb(84, 204, 84);
            fr1Local.videoButtonIcon = Properties.Resources.videoGreen;
            fr1Local.videoButtonOnHoverTextColor = Color.FromArgb(84, 204, 84);
            fr1Local.youtubeButtonIcon = Properties.Resources.YouTubeGreen;
            fr1Local.youtubeButtonOnHoverTextColor = Color.FromArgb(84, 204, 84);
            fr1Local.mySongsButtonIcon = Properties.Resources.musicGreen;
            fr1Local.mySongsButtonOnHoverTextColor = Color.FromArgb(84, 204, 84);
            fr1Local.playlistsButtonIcon = Properties.Resources.playlistGreen;
            fr1Local.playlistsButtonOnHoverTextColor = Color.FromArgb(84, 204, 84);
            fr1Local.menuButtonIcon = Properties.Resources.Expand_Arrow_Green;
            // CHECKS FOR MUSIC COVER
            if (fr1Local.musicCover != true)
            {
                fr1Local.coverIcon = Properties.Resources.Music_Record_FilledGreen;
            }
            fr1Local.trackBarIndicatorColor = Color.FromArgb(84, 204, 84);
            fr1Local.startButtonIcon = Properties.Resources.Skip_to_Start_Green;
            //CHECKS MUSIC STATUS (PLAYING OR PAUSED)
            if (fr1Local.musicStatus != true)
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Play_100Green;
            }
            else
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Pause_Filled_Green;
            }
            fr1Local.endButtonIcon = Properties.Resources.End_Green;
            fr1Local.settingsButtonIcon = Properties.Resources.Horizontal_Settings_Mixer_Green;
            fr1Local.soundButtonIcon = Properties.Resources.Room_SoundGreen;
            fr1Local.goButtonIcon = Properties.Resources.Go_Green;
            fr1Local.volumeSliderIndicatorColor = Color.FromArgb(84, 204, 84);

            fr1Local.equalizer = Properties.Resources.equalizerGreen;
            fr1Local.fullScreenIcon = Properties.Resources.Full_ScreenGreen;
            fr1Local.rewindIcon = Properties.Resources.RewindGreen;
            fr1Local.fastForwardIcon = Properties.Resources.Fast_ForwardGreen;
            fr1Local.stopIcon = Properties.Resources.StopGreen;
            fr1Local.trackBarVideoIndicatorColor = Color.FromArgb(84, 204, 84);
            fr1Local.volumeSliderVideoColor = Color.FromArgb(84, 204, 84);
            fr1Local.startVideoIcon = Properties.Resources.Skip_to_Start_Green;
            fr1Local.playVideoIcon = Properties.Resources.Circled_Play_100Green;
            fr1Local.endVideoIcon = Properties.Resources.End_Green;
            fr1Local.optionsVideoIcon = Properties.Resources.Horizontal_Settings_Mixer_Green;
            fr1Local.soundVideoIcon = Properties.Resources.Room_SoundGreen;
        }

        /// <summary>
        /// get for orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonColorsOrange_Click(object sender, EventArgs e)
        {
            fr1Local.panelTopImage = Properties.Resources.Spotify_Effect_The_OneOrange;
            fr1Local.panelTopColor = Color.FromArgb(249, 157, 70);
            fr1Local.colorsButtonActiveForeColor = Color.FromArgb(249, 157, 70);
            fr1Local.colorsButtonIdleFillColor = Color.FromArgb(249, 157, 70);
            fr1Local.colorsButtonActiveFillColor = Color.White;
            fr1Local.colorsButtonActiveLineColor = Color.White;
            fr1Local.colorsButtonForeColor = Color.White;
            fr1Local.colorsButtonIdleForeColor = Color.White;
            fr1Local.colorsButtonIdleLineColor = Color.White;
            fr1Local.aboutButtonActiveForeColor = Color.FromArgb(249, 157, 70);
            fr1Local.aboutButtonIdleFillColor = Color.FromArgb(249, 157, 70);
            fr1Local.aboutButtonActiveFillColor = Color.White;
            fr1Local.aboutButtonActiveLineColor = Color.White;
            fr1Local.aboutButtonForeColor = Color.White;
            fr1Local.aboutButtonIdleForeColor = Color.White;
            fr1Local.aboutButtonIdleLineColor = Color.White;
            fr1Local.topMainLabel = Color.Transparent;
            fr1Local.topSideLabel = Color.Transparent;
            fr1Local.browseButtonIcon = Properties.Resources.BrowseOrange;
            fr1Local.browseButtonOnHoverTextColor = Color.FromArgb(255, 102, 0);
            fr1Local.videoButtonIcon = Properties.Resources.videoOrange;
            fr1Local.videoButtonOnHoverTextColor = Color.FromArgb(255, 102, 0);
            fr1Local.youtubeButtonIcon = Properties.Resources.YouTubeOrange;
            fr1Local.youtubeButtonOnHoverTextColor = Color.FromArgb(255, 102, 0);
            fr1Local.mySongsButtonIcon = Properties.Resources.musicOrange;
            fr1Local.mySongsButtonOnHoverTextColor = Color.FromArgb(255, 102, 0);
            fr1Local.playlistsButtonIcon = Properties.Resources.playlistOrange;
            fr1Local.playlistsButtonOnHoverTextColor = Color.FromArgb(255, 102, 0);
            fr1Local.menuButtonIcon = Properties.Resources.Expand_Arrow_Orange;
            // CHECKS FOR MUSIC COVER
            if (fr1Local.musicCover != true)
            {
                fr1Local.coverIcon = Properties.Resources.Music_Record_FilledOrange;
            }
            fr1Local.trackBarIndicatorColor = Color.FromArgb(255, 102, 0);
            fr1Local.startButtonIcon = Properties.Resources.Skip_to_Start_Orange;
            //CHECKS MUSIC STATUS (PLAYING OR PAUSED)
            if (fr1Local.musicStatus != true)
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Play_100Orange;
            }
            else
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Pause_Filled_Orange;
            }
            fr1Local.endButtonIcon = Properties.Resources.End_Orange;
            fr1Local.settingsButtonIcon = Properties.Resources.Horizontal_Settings_Mixer_Orange;
            fr1Local.soundButtonIcon = Properties.Resources.Room_SoundOrange;
            fr1Local.goButtonIcon = Properties.Resources.Go_Orange;
            fr1Local.volumeSliderIndicatorColor = Color.FromArgb(255, 102, 0);

            fr1Local.equalizer = Properties.Resources.equalizerOrange;
            fr1Local.fullScreenIcon = Properties.Resources.Full_ScreenOrange;
            fr1Local.rewindIcon = Properties.Resources.RewindOrange;
            fr1Local.fastForwardIcon = Properties.Resources.Fast_ForwardOrange;
            fr1Local.stopIcon = Properties.Resources.StopOrange;
            fr1Local.trackBarVideoIndicatorColor = Color.FromArgb(255, 102, 0);
            fr1Local.volumeSliderVideoColor = Color.FromArgb(255, 102, 0);
            fr1Local.startVideoIcon = Properties.Resources.Skip_to_Start_Orange;
            fr1Local.playVideoIcon = Properties.Resources.Circled_Play_100Orange;
            fr1Local.endVideoIcon = Properties.Resources.End_Orange;
            fr1Local.optionsVideoIcon = Properties.Resources.Horizontal_Settings_Mixer_Orange;
            fr1Local.soundVideoIcon = Properties.Resources.Room_SoundOrange;
        }

        /// <summary>
        /// get for pink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonColorsPink_Click(object sender, EventArgs e)
        {
            fr1Local.panelTopImage = Properties.Resources.Spotify_Effect_The_One;
            fr1Local.panelTopColor = Color.FromArgb(255, 0, 234);
            fr1Local.colorsButtonActiveForeColor = Color.FromArgb(255, 0, 234);
            fr1Local.colorsButtonIdleFillColor = Color.FromArgb(255, 0, 234);
            fr1Local.colorsButtonActiveFillColor = Color.White;
            fr1Local.colorsButtonActiveLineColor = Color.White;
            fr1Local.colorsButtonForeColor = Color.White;
            fr1Local.colorsButtonIdleForeColor = Color.White;
            fr1Local.colorsButtonIdleLineColor = Color.White;
            fr1Local.aboutButtonActiveForeColor = Color.FromArgb(255, 0, 234);
            fr1Local.aboutButtonIdleFillColor = Color.FromArgb(255, 0, 234);
            fr1Local.aboutButtonActiveFillColor = Color.White;
            fr1Local.aboutButtonActiveLineColor = Color.White;
            fr1Local.aboutButtonForeColor = Color.White;
            fr1Local.aboutButtonIdleForeColor = Color.White;
            fr1Local.aboutButtonIdleLineColor = Color.White;
            fr1Local.topMainLabel = Color.Transparent;
            fr1Local.topSideLabel = Color.Transparent;
            fr1Local.browseButtonIcon = Properties.Resources.BrowsePink;
            fr1Local.browseButtonOnHoverTextColor = Color.FromArgb(255, 0, 128);
            fr1Local.videoButtonIcon = Properties.Resources.videoPink;
            fr1Local.videoButtonOnHoverTextColor = Color.FromArgb(255, 0, 128);
            fr1Local.youtubeButtonIcon = Properties.Resources.YouTubePink;
            fr1Local.youtubeButtonOnHoverTextColor = Color.FromArgb(255, 0, 128);
            fr1Local.mySongsButtonIcon = Properties.Resources.musicPink;
            fr1Local.mySongsButtonOnHoverTextColor = Color.FromArgb(255, 0, 128);
            fr1Local.playlistsButtonIcon = Properties.Resources.playlistPink;
            fr1Local.playlistsButtonOnHoverTextColor = Color.FromArgb(255, 0, 128);
            fr1Local.menuButtonIcon = Properties.Resources.Expand_Arrow_Pink;
            // CHECKS FOR MUSIC COVER
            if (fr1Local.musicCover != true)
            {
                fr1Local.coverIcon = Properties.Resources.Music_Record_FilledPink;
            }
            fr1Local.trackBarIndicatorColor = Color.FromArgb(255, 0, 128);
            fr1Local.startButtonIcon = Properties.Resources.Skip_to_Start_Pink;
            //CHECKS MUSIC STATUS (PLAYING OR PAUSED)
            if (fr1Local.musicStatus != true)
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Play_100Pink;
            }
            else
            {
                fr1Local.playButtonIcon = Properties.Resources.Circled_Pause_Filled_Pink;
            }
            fr1Local.endButtonIcon = Properties.Resources.End_Pink;
            fr1Local.settingsButtonIcon = Properties.Resources.Horizontal_Settings_Mixer_Pink;
            fr1Local.soundButtonIcon = Properties.Resources.Room_SoundPink;
            fr1Local.goButtonIcon = Properties.Resources.Go_Pink;
            fr1Local.volumeSliderIndicatorColor = Color.FromArgb(255, 0, 128);
            fr1Local.equalizer = Properties.Resources.equalizerPink;

            fr1Local.fullScreenIcon = Properties.Resources.Full_ScreenPink;
            fr1Local.rewindIcon = Properties.Resources.RewindPink;
            fr1Local.fastForwardIcon = Properties.Resources.Fast_ForwardPink;
            fr1Local.stopIcon = Properties.Resources.StopPink;
            fr1Local.trackBarVideoIndicatorColor = Color.FromArgb(255, 0, 128);
            fr1Local.volumeSliderVideoColor = Color.FromArgb(255, 0, 128);
            fr1Local.startVideoIcon = Properties.Resources.Skip_to_Start_Pink;
            fr1Local.playVideoIcon = Properties.Resources.Circled_Play_100Pink;
            fr1Local.endVideoIcon = Properties.Resources.End_Pink;
            fr1Local.optionsVideoIcon = Properties.Resources.Horizontal_Settings_Mixer_Pink;
            fr1Local.soundVideoIcon = Properties.Resources.Room_SoundPink;
        }
    }
}
