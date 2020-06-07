using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class CustomerReservation : UserControl
    {
		private bool isCollapsed = false;
		public CustomerReservation(MovieReservationAvailableMoviesItem chosenItem)
        {
            InitializeComponent();
			this.Size = this.MinimumSize;
		}

		private string _movietitle;
		private string _filmtechnology;
		private string _runtime;
		private string _Date;
		private string _screen;

		[Category("Custom Props")]
		public string MovieTitle
		{
			get { return _movietitle; }
			set { _movietitle = value; Filmtitle.Text = value; }
		}

		[Category("Custom Props")]
		public string FilmTechnology
		{
			get { return _filmtechnology; }
			set { _filmtechnology = value; Filmtechnology.Text = value; }
		}

		[Category("Custom Props")]
		public string Runtime
		{
			get { return _runtime; }
			set { _runtime = value; runtime.Text = value; }
		}

		[Category("Custom Props")]
		public string Date
		{
			get { return _Date; }
			set { _Date = value; date.Text = value; }
		}

		[Category("Custom Props")]
		public string Screen
		{
			get { return _screen; }
			set { _screen = value; ScreenLabel.Text = value; }
		}

		private void ShowReservationButton_Click(object sender, EventArgs e)
		{
			//IN KNOP BUTTON
			if (isCollapsed)
			{
				MoviePanel.Size = MoviePanel.MinimumSize;
				this.Size = this.MinimumSize;
				isCollapsed = false;
			}
			else
			{
				this.Size = this.MaximumSize;
				MoviePanel.Size = MoviePanel.MaximumSize;
				isCollapsed = true;
			}
		}

		private void ChooseOrChangeSeatsButton_Click(object sender, EventArgs e)
		{
			SeatReservation screen_number = new SeatReservation((Filmtitle.Text + Filmtechnology.Text + date.Text + ScreenLabel.Text).ToString(), ScreenLabel.Text, this.ScreenLabel.Text == "Zaal 1" ? 12 : this.ScreenLabel.Text == "Zaal 2" ? 18 : 30);
			screen_number.ShowDialog();
		}

		private void CustomerReservation_MouseEnter(object sender, EventArgs e)
		{
			/*SelectPeopleItem SelectedMovies = null;
			foreach (SelectPeopleItem item in SelectPeoplePanel.Controls)
			{
				if(item.MovieTitle == this.MovieTitle)
				{
					SelectedMovies = item;
					break;
				}
			}

			this.NormalSeat.Text = SelectedMovies.TotalNormalSeats.Text;
			this.GoodSeat.Text = SelectedMovies.TotalGoodSeats.Text;
			this.BestSeat.Text = SelectedMovies.TotalBestSeats.Text;

			string temp3 = "";
			string temp4 = "";

			if ((Convert.ToInt32(SelectedMovies.TotalGoodSeats.Text)) < 0)
			{
				temp3 = "    0";
			}
			else
			{
				temp3 = ((Convert.ToInt32(SelectedMovies.TotalGoodSeats.Text) * 1) < 10 ? "    " : (Convert.ToInt32(SelectedMovies.TotalGoodSeats.Text) * 1) < 100 ? "  " : "") + (Convert.ToInt32(SelectedMovies.TotalGoodSeats.Text) * 1).ToString();
			}
			if ((Convert.ToInt32(SelectedMovies.TotalBestSeats.Text)) < 0)
			{
				temp4 = "    0";
			}
			else
			{
				temp4 = ((Convert.ToInt32(SelectedMovies.TotalBestSeats.Text) * 2) < 10 ? "    " : (Convert.ToInt32(SelectedMovies.TotalBestSeats.Text) * 2) < 100 ? "  " : "") + (Convert.ToInt32(SelectedMovies.TotalBestSeats.Text) * 2).ToString();
			}

			this.TotalNormalSeatPrice.Text = "€    0,00";
			this.TotalGoodSeatPrice.Text = "€" + temp3 + ",00";
			this.TotalBestSeatPrice.Text = "€" + temp4 + ",00";*/
		}
	}
}
