using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieOverview : Form
    {
        const string path = @"JsonTextFile.json";
        public MovieDescriptionClass MovieInfo { get; set; }

        public static string Film1Title = "After";
        public static string Film2Title = "Avengers: Endgame";
        public static string Film3Title = "Frozen 2";
        public static string Film4Title = "Godzilla: King of the Monsters";
        public static string Film5Title = "How to train your dragon 3";
        public static string chosenMovie;

        public MovieOverview()
        {
            InitializeComponent();
            string resultJson = JsonConvert.SerializeObject(MovieInfo);

            Dictionary<string, MovieDescriptionClass> Movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            toolTip1.SetToolTip(filmtitel1, Film1Title);
            toolTip1.SetToolTip(filmtitel2, Film2Title);
            toolTip1.SetToolTip(filmtitel3, Film3Title);
            toolTip1.SetToolTip(filmtitel4, Film4Title);
            toolTip1.SetToolTip(filmtitel5, Film5Title);

            filmtitel1.Text = Film1Title;
            filmtitel2.Text = Film2Title;
            filmtitel3.Text = Film3Title;
            filmtitel4.Text = Film4Title;
            filmtitel5.Text = Film5Title;

            var fileStringFilm1 = Movies[Film1Title].Image;
            var bytesFilm1 = Convert.FromBase64String(fileStringFilm1);
            var fileStringFilm2 = Movies[Film2Title].Image;
            var bytesFilm2 = Convert.FromBase64String(fileStringFilm2);
            var fileStringFilm3 = Movies[Film3Title].Image;
            var bytesFilm3 = Convert.FromBase64String(fileStringFilm3);
            var fileStringFilm4 = Movies[Film4Title].Image;
            var bytesFilm4 = Convert.FromBase64String(fileStringFilm4);
            var fileStringFilm5 = Movies[Film5Title].Image;
            var bytesFilm5 = Convert.FromBase64String(fileStringFilm5);

            Film1.Image = Image.FromStream(new MemoryStream(bytesFilm1));
            Film2.Image = Image.FromStream(new MemoryStream(bytesFilm2));
            Film3.Image = Image.FromStream(new MemoryStream(bytesFilm3));
            Film4.Image = Image.FromStream(new MemoryStream(bytesFilm4));
            Film5.Image = Image.FromStream(new MemoryStream(bytesFilm5));

            Email.Text = "bioscoop@hr.nl";
            Telefoonnummer.Text = "010-1234567";
            Locatie.Text = "Wijnhaven 107, 3011 WN Rotterdam";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chosenMovie = Film1Title;
            new MovieDescription().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chosenMovie = Film2Title;
            new MovieDescription().Show();
        }

        private void Film3_Click(object sender, EventArgs e)
        {
            chosenMovie = Film3Title;
            new MovieDescription().Show();
        }

        private void Film4_Click(object sender, EventArgs e)
        {
            chosenMovie = Film4Title;
            new MovieDescription().Show();
        }

        private void Film5_Click(object sender, EventArgs e)
        {
            chosenMovie = Film5Title;
            new MovieDescription().Show();
        }

        private void Filmtijdenknop_Click(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.Yellow;
            Startknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

        }

        private void Startknop_Click(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.Yellow;
            Filmsknop.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

        }

        private void Filmsknop_Click(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.Yellow;
            Startknop.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new Movies().Show();
        }

        private void Prijzenknop_Click(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.Yellow;
            Startknop.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new PriceList().Show();
        }

        private void Menuknop_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
            Startknop.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new MenuCard().Show();
        }

        private void Reserveerknop_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
            Startknop.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
        }
    }
}
