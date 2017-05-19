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
            fr1Local.colorsButtonForeColor = Color.FromArgb(0, 72, 251);
            fr1Local.colorsButtonIdleFillColor = Color.FromArgb(0, 72, 251);
            fr1Local.aboutButtonForeColor = Color.FromArgb(0, 72, 251);
            fr1Local.aboutButtonIdleFillColor = Color.FromArgb(0, 72, 251);
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
        }
    }
}
