
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

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
            MovieTitle.Text = Movies["After"].MovieTitle;
            Release.Text = Movies["After"].Release;
            Director.Text = Movies["After"].Director;
            Genre.Text = Movies["After"].Genre;
            Language.Text = Movies["After"].Language;
            Prize.Text = Movies["After"].Prize;
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