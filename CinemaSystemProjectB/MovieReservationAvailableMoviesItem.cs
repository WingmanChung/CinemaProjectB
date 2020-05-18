using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieReservationAvailableMoviesItem : UserControl
    {
		public static MovieReservationAvailableMoviesItem chosenItem;
        public static bool chosenMoviePanelBool = false;

        public MovieReservationAvailableMoviesItem()
        {
            InitializeComponent();
        }

		//properties
		public bool Chosen { get; set; } = false;

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
            set { _screen = value; ScreenLabel.Text = value;}
        }


        private void YellowStripe_MouseClick(object sender, MouseEventArgs e)
        {
			chosenItem = this;
            chosenMoviePanelBool = true;

            this.BackColor = Color.FromArgb(64, 0, 0);

            Filmtitle.BackColor = Color.FromArgb(64, 0, 0);

            Filmtechnology.BackColor = Color.FromArgb(64, 0, 0);

            runtime.BackColor = Color.FromArgb(64, 0, 0);

            date.BackColor = Color.FromArgb(64, 0, 0);

            if (!Chosen)
                (this.ParentForm as MovieReservation).chosenMovies();

            Chosen = true;
            MessageBox.Show(Screen);

		}
        private void MovieReservationAvailableMoviesItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 0, 0);

            Filmtitle.BackColor = Color.FromArgb(64, 0, 0);

            Filmtechnology.BackColor = Color.FromArgb(64, 0, 0);

            runtime.BackColor = Color.FromArgb(64, 0, 0);

            date.BackColor = Color.FromArgb(64, 0, 0);

        }

        private void MovieReservationAvailableMoviesItem_MouseLeave(object sender, EventArgs e)
        {
            if (!Chosen)
			    SetDefaultColor();

		}

        public void SetDefaultColor()
		{
			this.BackColor = Color.Transparent;

			Filmtitle.BackColor = Color.Transparent;

			Filmtechnology.BackColor = Color.Transparent;

			runtime.BackColor = Color.Transparent;

			date.BackColor = Color.Transparent;
		}
    }
}
