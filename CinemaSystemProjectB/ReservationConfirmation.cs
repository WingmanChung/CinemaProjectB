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
    public partial class ReservationConfirmation : Form
    {
        public ReservationConfirmation()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MovieReservation.showCodes = "";
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

        private void ReservationConfirmation_Load(object sender, EventArgs e)
        {
            ReservationCodes.Text = MovieReservation.showCodes;
        }
    }
}
