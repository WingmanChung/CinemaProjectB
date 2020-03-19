
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
        public MovieInfo MovieInfo { get; set; }
        public MovieDescription()
        {
            InitializeComponent();

            

            string resultJson = JsonConvert.SerializeObject(MovieInfo);

            Dictionary<string, MovieInfo> Movies = JsonConvert.DeserializeObject<Dictionary<string, MovieInfo>>(File.ReadAllText(path));
            label3.Text = Movies["After"].Title;
            Synopsis.Text = Movies["After"].Synopsis;

            MovieInfo = JsonConvert.DeserializeObject<MovieInfo>(resultJson, new JsonSerializerSettings());

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