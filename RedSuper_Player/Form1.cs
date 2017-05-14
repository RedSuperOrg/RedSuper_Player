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

namespace RedSuper_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NAudio.Wave.BlockAlignReductionStream stream = null;

        private NAudio.Wave.DirectSoundOut output = null;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// MISTAKES WERE MADE //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form_Resize(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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
            myOpenFileDialog.ShowDialog();

            if (myOpenFileDialog.ShowDialog() != DialogResult.OK) return;

            DisposeWave();

            if (myOpenFileDialog.FileName.EndsWith(".mp3"))
            {
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(myOpenFileDialog.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else if (myOpenFileDialog.FileName.EndsWith(".wav"))
            {
                NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(myOpenFileDialog.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else throw new InvalidOperationException("Not a correct audio file type.");

            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();

            bunifuImageButtonPlay.Enabled = true;
            bunifuImageButtonPlay.Image = Resources.Circled_Pause_100;
        }

        /// <summary>
        /// Changes colors to default or new
        /// Slides the Menu in or out
        /// Slides the logo in or out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonSlideMenu_Click(object sender, EventArgs e)
        {
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
        }

        private void bunifuImageButtonPlay_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Pause();
                    bunifuImageButtonPlay.Image = Resources.Circled_Play_100__1_;
                }
                else
                {
                    if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                    {
                        output.Play();
                        bunifuImageButtonPlay.Image = Resources.Circled_Pause_100;
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
