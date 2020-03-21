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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ara Ara Startu-desu!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }
    }
}
