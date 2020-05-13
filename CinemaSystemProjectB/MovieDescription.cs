
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
        public MovieDescriptionClass MovieInfo { get; set; }

        public MovieDescription()
        {
            InitializeComponent();

            string showMovie;
            //to check if chosenMovie is selected in Trending or not
            bool checkBool = MovieOverview.HomeScreen;
            bool checkBool2 = MovieScheduleItem.MovieScheduleChosenMovie;

            //determines which variable will be used to show selected movie(choosing between forms)

            if (checkBool)
            {
                showMovie = MovieOverview.chosenMovie;
            }
            else if (checkBool2)
            {
                showMovie = MovieScheduleItem.chosenMovieMovieSchedule;
            }
            else
            {
                showMovie = ListItem.chosenMovieListView;
            }

            string resultJson = JsonConvert.SerializeObject(MovieInfo);

            Dictionary<string, MovieDescriptionClass> Movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

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

            var fileString = Movies[showMovie].Image;
            var bytes = Convert.FromBase64String(fileString);

            Filmposter.Image = Image.FromStream(new MemoryStream(bytes));


            MovieInfo = JsonConvert.DeserializeObject<MovieDescriptionClass>(resultJson, new JsonSerializerSettings());
        }

        private void Trailerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Trailerlink.Text);
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            /*var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            DateTime dateToday = DateTime.Today;
            MessageBox.Show(finalString + dateToday.ToString("ddMMyyyy"), "Reservatie code");*/

            new MovieReservation().Show();
        }

    }
}

/*
{
    "Avengers": {
        "Title": "whatever"
    },
    After": {
    title}
}
*/

/*

{

var fileString = Movies[showMovie].Image;
var bytes = Convert.FromBase64String(fileString);

pictureBox1.Image = Image.FromStream(new MemoryStream(bytes));
}
*/
