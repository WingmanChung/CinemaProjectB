
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

            string showMovie = MovieOverview.chosenMovie;

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

            var fileString = Movies[showMovie].Image;
            var bytes = Convert.FromBase64String(fileString);

            Filmposter.Image = Image.FromStream(new MemoryStream(bytes));


            MovieInfo = JsonConvert.DeserializeObject<MovieDescriptionClass>(resultJson, new JsonSerializerSettings());
        }

        private void Trailerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Trailerlink.Text);
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
