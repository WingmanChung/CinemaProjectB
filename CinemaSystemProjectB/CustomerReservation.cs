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

		public object CustomerReservationPage { get; internal set; }

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

		public static bool clicked = false;
		public static CustomerReservation CustomerMovie;

		private void ChooseOrChangeSeatsButton_Click(object sender, EventArgs e)
		{
			CustomerMovie = this;
			clicked = true;
			SeatReservation screen_number = new SeatReservation((Filmtitle.Text + Filmtechnology.Text + date.Text + ScreenLabel.Text).ToString(), ScreenLabel.Text, this.ScreenLabel.Text == "Zaal 1" ? 12 : this.ScreenLabel.Text == "Zaal 2" ? 18 : 30);
			screen_number.ShowDialog();
			clicked = false;
		}

		private void MoviePanel_MouseEnter(object sender, EventArgs e)
		{

		}
	}
}
