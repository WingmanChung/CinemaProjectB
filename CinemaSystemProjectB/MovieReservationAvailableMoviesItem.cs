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
        
        public string MovieTitle
        {
            get => Filmtitle.Text;
            set => Filmtitle.Text = value;
        }

        public string FilmTechnology
        {
            get => Filmtechnology.Text;
            set => Filmtechnology.Text = value;
        }

        public string Runtime
        {
            get => runtime.Text;
            set => runtime.Text = value;
        }

        public string Date
        {
            get => date.Text;
            set => date.Text = value;
        }

        public string Screen
        {
            get => ScreenLabel.Text;
            set => ScreenLabel.Text = value;
        }


        public void YellowStripe_MouseClick(object sender, MouseEventArgs e)
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
