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
    public partial class FormOptions : Form
    {
        Form1 fr1Local;

        public FormOptions(Form1 options)
        {
            InitializeComponent();
            fr1Local = options;
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {

        }

        public Form1 Form1
        {
            get { return fr1Local; }
            set { fr1Local = value; }
        }

        private void bunifuImageButtonColorsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanelColorsOrange_Paint(object sender, PaintEventArgs e)
        {

        }

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
            fr1Local.coverIcon = Properties.Resources.Music_Record_FilledBlue;
            fr1Local.trackBarIndicatorColor = Color.FromArgb(0, 72, 251);
            fr1Local.startButtonIcon = Properties.Resources.Skip_to_Start_Blue;
            fr1Local.playButtonIcon = Properties.Resources.Circled_Play_100Blue;
            fr1Local.endButtonIcon = Properties.Resources.End_Blue;
            fr1Local.settingsButtonIcon = Properties.Resources.Horizontal_Settings_Mixer_Blue;
            fr1Local.soundButtonIcon = Properties.Resources.Room_SoundBlue;
            fr1Local.goButtonIcon = Properties.Resources.Go_Blue;
            fr1Local.volumeSliderIndicatorColor = Color.FromArgb(0, 72, 251);
        }
    }
}
