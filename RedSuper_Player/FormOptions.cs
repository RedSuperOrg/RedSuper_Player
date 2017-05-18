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

        }
    }
}
