using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DeepSpaceBattles
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
            Image img = DeepSpaceBattles.Properties.Resources.redfighter0005;
            pictureBox1.Image = img;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure that you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay h = new HowToPlay();
            h.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
