
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
            label6.Text = Movies["After"].Titel;
            label9.Text = Movies["After"].Release;
            label10.Text = Movies["After"].Regisseur;
            label8.Text = Movies["After"].Genre;
            label11.Text = Movies["After"].Taal;
            label12.Text = Movies["After"].Prijs;
            
            label3.Text = Movies["After"].Synopsis;

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