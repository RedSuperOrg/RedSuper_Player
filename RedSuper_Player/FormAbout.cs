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
    public partial class FormAbout : Form
    {
        /// <summary>
        /// Initializes with property to be opened from main form
        /// </summary>
        /// <param name="about"></param>
        public FormAbout(Form1 about)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Changes hovering color to black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuDatepickerAbout_MouseHover(object sender, EventArgs e)
        {
            bunifuDatepickerAbout.ForeColor = Color.Black;
        }

        /// <summary>
        /// Opens github profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonWarSkeleton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/WARSKELETON");
        }

        /// <summary>
        /// Opens github profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonRedDr3ad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RedDr3ad");
        }
    }
}
