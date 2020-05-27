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
    public partial class MovieConfirmation : Form
    {
        
        public MovieConfirmation()
        {
            InitializeComponent();
        }

        private void MovieConfirmation_Load(object sender, EventArgs e)
        {
            ReservationConfirmation.Text = MovieReservation.showCodes;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MovieReservation obj = (MovieReservation)Application.OpenForms["MovieReservation"];
            obj.Close();
            this.Close();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Gold;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Yellow;
        }

    }
}
