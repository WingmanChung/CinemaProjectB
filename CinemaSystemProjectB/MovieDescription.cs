
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;
using System;
using System.Drawing;

namespace CinemaSystemProjectB
{
    public partial class MovieDescription : Form
    {
        const string path = @"JsonTextFile.json";
        Dictionary<string, MovieDescriptionClass> Movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

		public MovieDescriptionClass MovieInfo { get; set; }

        public MovieDescription()
        {
            InitializeComponent();

            string showMovie;

            //determines which variable will be used to show selected movie(choosing between forms)
            if (MovieOverview.HomeScreen)
            {
                showMovie = MovieOverview.chosenMovie;
            }
            //to check if chosenMovie is selected in Trending or not
            else if (MovieScheduleItem.MovieScheduleChosenMovie)
            {
                showMovie = MovieScheduleItem.chosenMovieMovieSchedule;
            }
            else
            {
                showMovie = ListItem.chosenMovieListView;
            }

            string resultJson = JsonConvert.SerializeObject(MovieInfo);

            Filmtitel.Text = Movies[showMovie].Title;
            Releasedatumlabel.Text = Movies[showMovie].Release;
            Regisseurlabel.Text = Movies[showMovie].Director;
            Genrelabel.Text = Movies[showMovie].Genre;
            Taallabel.Text = Movies[showMovie].Language;
            Prijslabel.Text = Movies[showMovie].Price;
            Synopsis.Text = Movies[showMovie].Synopsis;
            Trailerlink.Text = Movies[showMovie].Trailer;
            Leeftijdlabel.Text = Movies[showMovie].Age;
            Technologielabel.Text = Movies[showMovie].FilmTechnology;
            RuntimeLabel.Text = Movies[showMovie].Runtime;
            RatingLabel.Text = Movies[showMovie].Rating.ToString();

            // Load the filmposter image from the base 64 stream (uses a memory stream to read the bytes from the base64 string)
            Filmposter.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(Movies[showMovie].Image)));
            MovieInfo = JsonConvert.DeserializeObject<MovieDescriptionClass>(resultJson, new JsonSerializerSettings());
        }

		private void Trailerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Trailerlink.Text);
		}

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            new MovieReservation().Show();
        }

        private void PriceListButton_MouseEnter(object sender, EventArgs e)
        {
            PriceListButton.BackColor = Color.Gold;
        }

        private void PriceListButton_MouseLeave(object sender, EventArgs e)
        {
            PriceListButton.BackColor = Color.Yellow;
        }

        private void PriceListButton_Click(object sender, EventArgs e)
        {
            new PriceList().Show();
        }
    }
}
