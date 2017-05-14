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
        private IList<string> musicList = new BindingList<string>();
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            listBoxMusic.DataSource = musicList;
        }

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
            Console.WriteLine("I am here");
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();

            // CORRECTS THE INITIAL DIRECTORY, FILTERS, ENABLES MULTISELECT
            myOpenFileDialog.InitialDirectory = "c:\\";
            myOpenFileDialog.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File  (*.wav)|*.wav|All FILES (*.*)|*.*";
            myOpenFileDialog.FilterIndex = 1;
            myOpenFileDialog.RestoreDirectory = false;
            myOpenFileDialog.Multiselect = true;
            // POPS THE FILE DIALOG
            myOpenFileDialog.ShowDialog();

            string[] songs = myOpenFileDialog.FileNames;
            foreach(string song in songs)
            {
                if (!musicList.Contains(song))
                {
                    musicList.Add(song);
                    listBoxMusic.Refresh();
                    //listBoxMusic.Items.Add(song);
                    //listBoxMusic.DataSource = musicList;
                }
            }
        }

        private void bunifuImageButtonSlideMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 55)
            {
                panelMenu.Width = 200;
                bunifuTransitionSlidingMenu.ShowSync(panelMenu);
            }
            else
            {
                panelMenu.Width = 55;
            }
        }

        private void bunifuFlatButtonVideo_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButtonPlay_Click(object sender, EventArgs e)
        {
            Console.WriteLine(wplayer.status);
            string songPath = listBoxMusic.SelectedItem.ToString();
            if(songPath != null && !songPath.Equals(""))
            {
                wplayer.URL = songPath;
                wplayer.controls.play();
                string a =  wplayer.status;
                Console.WriteLine(a);

                //bunifuImageButtonPlay.Image = 
            }
        }

        private void bunifuSliderVolume_ValueChanged(object sender, EventArgs e)
        {
            wplayer.settings.volume = bunifuSliderVolume.Value;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
