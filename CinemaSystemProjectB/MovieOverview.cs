using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieOverview : Form
    {
        public MovieOverview()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form godzilla = new Godzilla();
            godzilla.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form madeInAbyss = new MadeInAbyss();
            madeInAbyss.ShowDialog();
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form avengers = new Avengers();
            avengers.ShowDialog();
        }
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Form frozen2 = new Frozen2();
            frozen2.ShowDialog();
        }


    }
}
