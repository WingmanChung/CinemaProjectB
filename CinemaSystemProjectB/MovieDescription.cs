
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CinemaSystemProjectB
{
    public partial class MovieDescription : Form
    {
        const string path = @"JsonTextFile.json";
        public MovieDescriptionClass MovieInfo { get; set; }
        public MovieDescription()
        {
            InitializeComponent();



            string resultJson = JsonConvert.SerializeObject(MovieInfo);

            Dictionary<string, MovieDescriptionClass> Movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));
            Filmtitel.Text = Movies["After"].MovieTitle;
            Release.Text = Movies["After"].Release;
            Regisseurs.Text = Movies["After"].Director;
            Genre.Text = Movies["After"].Genre;
            Taal.Text = Movies["After"].Language;
            Prijs.Text = Movies["After"].Prize;
            Synopsis.Text = Movies["After"].Synopsis;

            MovieInfo = JsonConvert.DeserializeObject<MovieDescriptionClass>(resultJson, new JsonSerializerSettings());

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