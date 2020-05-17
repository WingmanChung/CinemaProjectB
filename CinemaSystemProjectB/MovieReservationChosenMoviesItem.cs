using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class MovieReservationChosenMoviesItem : UserControl
	{
		public MovieReservationChosenMoviesItem(MovieReservationAvailableMoviesItem sibling)
		{
			InitializeComponent();

			_sibling = sibling;
		}

		//properties

		private MovieReservationAvailableMoviesItem _sibling;
		private string _movietitle;
		private string _filmtechnology;
		private string _runtime;
		private string _Date;

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



		private void MovieReservationChosenMoviesItem_MouseEnter(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(64, 0, 0);

			Filmtitle.BackColor = Color.FromArgb(64, 0, 0);

			Filmtechnology.BackColor = Color.FromArgb(64, 0, 0);

			runtime.BackColor = Color.FromArgb(64, 0, 0);

			date.BackColor = Color.FromArgb(64, 0, 0);
		}

		private void MovieReservationChosenMoviesItem_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.Transparent;

			Filmtitle.BackColor = Color.Transparent;

			Filmtechnology.BackColor = Color.Transparent;

			runtime.BackColor = Color.Transparent;

			date.BackColor = Color.Transparent;
		}

		private void MovieReservationChosenMoviesItem_MouseClick(object sender, MouseEventArgs e)
		{
			_sibling.Chosen = false;
			_sibling.SetDefaultColor();
			(this.ParentForm as MovieReservation).RemoveItem(this);
		}
	}
}
