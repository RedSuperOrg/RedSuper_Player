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
        public FormAbout(Form1 about)
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButtonCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
