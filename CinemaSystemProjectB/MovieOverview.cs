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
            toolTip1.SetToolTip(filmtitel5, "How to train your dragon");
            toolTip1.SetToolTip(filmtitel4, "Godzilla");
            toolTip1.SetToolTip(filmtitel3, "Frozen 2");
            toolTip1.SetToolTip(filmtitel2, "Avengers: End Game");
            toolTip1.SetToolTip(filmtitel1, "After");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MovieDescription().Show();
        }


}
}
