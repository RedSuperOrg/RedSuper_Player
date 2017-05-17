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

        private void bunifuImageButtonCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
