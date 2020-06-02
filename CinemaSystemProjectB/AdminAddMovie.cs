using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class AdminAddMovie : UserControl
    {
        private bool isCollapsed = false;
        const string path = @"JsonTextFile.json";
        public AdminAddMovie()
        {
            InitializeComponent();

            // Shrink upon initialization (allows the form to be big in the designer tab)
            this.Size = this.MinimumSize;
        }



        private string _movieTitle;
        private string _filmtechnology;
        private string _runtime;
        private string _release;
        private string _language;
        private string _age;
        private string _trailer;
        private string _director;
        private string _synopsis;
        private string _genre;
        private string _rating;
        private string _price;


        [Category("Custom Props")]
        public string MovieTitle
        {
            get { return _movieTitle; }
            set { _movieTitle = value; textBoxTitle.Text = value;}
        }

        [Category("Custom Props")]
        public string FilmTechnology
        {
            get { return _filmtechnology; }
            set { _filmtechnology = value; textBoxFilmtechnology.Text = value; }
        }

        [Category("Custom Props")]
        public string Runtime
        {
            get { return _runtime; }
            set { _runtime = value; textBoxRuntime.Text = value; }
        }

        [Category("Custom Props")]
        public string Release
        {
            get { return _release; }
            set { _release = value; textBoxRelease.Text = value; }
        }
        [Category("Custom Props")]
        public string Language
        {
            get { return _language; }
            set { _language = value; textBoxLanguage.Text = value; }
        }

        [Category("Custom Props")]
        public string Age
        {
            get { return _age; }
            set { _age = value; textBoxAge.Text = value; }
        }

        [Category("Custom Props")]
        public string Trailer
        {
            get { return _trailer; }
            set { _trailer = value; textBoxTrailer.Text = value; }
        }

        [Category("Custom Props")]
        public string Director
        {
            get { return _director; }
            set { _director = value; textBoxDirector.Text = value; }
        }

        [Category("Custom Props")]
        public string Synopsis
        {
            get { return _synopsis; }
            set { _synopsis = value; textBoxSynopsis.Text = value; }
        }

        [Category("Custom Props")]
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; textBoxGenre.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; textBoxPrice.Text = value; }
        }

        [Category("Custom Props")]
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; textBoxRating.Text = value; }
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            //Loads json file with all movies
            Dictionary<string, MovieDescriptionClass> movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            MovieDescriptionClass newMovie;
            try
			{
                newMovie = new MovieDescriptionClass()
                {
                    Title = textBoxTitle.Text,
                    Release = textBoxRelease.Text,
                    Director = textBoxDirector.Text,
                    Genre = textBoxGenre.Text,
                    Language = textBoxLanguage.Text,
                    Rating = float.Parse(textBoxRating.Text),
                    Age = textBoxAge.Text,
                    Runtime = textBoxAge.Text,
                    FilmTechnology = textBoxFilmtechnology.Text,
                    Price = textBoxPrice.Text,
                    Trailer = textBoxTrailer.Text,
                    Synopsis = textBoxSynopsis.Text,
                    Image = Convert.ToBase64String(File.ReadAllBytes(AddMoviePoster.ImageLocation))
                };
			}
            catch
			{
                MessageBox.Show("Voer een geldig nummer in.");
                return;
			}

            //Check for duplicate movies
            foreach(var entry in movies.Values)
            {
                if (newMovie.Equals(entry))
                {
                    MessageBox.Show("Deze film bestaat al.");
                    return;
                }
            }

            movies.Add(newMovie.Title, newMovie);

            File.WriteAllText(path, JsonConvert.SerializeObject(movies, Formatting.Indented));
            MessageBox.Show("Film is toegevoegd");
        }

        private void AddMovieButton_MouseEnter(object sender, EventArgs e)
        {
            AddMovieButton.BackColor = Color.Gold;
        }

        private void AddMovieButton_MouseLeave(object sender, EventArgs e)
        {
            AddMovieButton.BackColor = Color.Yellow;
        }

        private void OpenAddMoviePanel_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                AddMovieControl.Size = AddMovieControl.MinimumSize;
                this.Size = this.MinimumSize;
                isCollapsed = false;
            }
            else
            {
                this.Size = this.MaximumSize;
                AddMovieControl.Size = AddMovieControl.MaximumSize;
                isCollapsed = true;
            }
        }

        private void textBoxTitle_Enter(object sender, EventArgs e)
        {
            if(textBoxTitle.Text == "Titel")
            {
                textBoxTitle.Text = "";

                if(textBoxTitle.Text != null)
                {

                }

                textBoxTitle.Font = new Font(textBoxTitle.Font, FontStyle.Regular);
            }
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Titel";

                textBoxTitle.Font = new Font(textBoxTitle.Font, FontStyle.Italic);
            }
        }

        private void textBoxRelease_Enter(object sender, EventArgs e)
        {
            if (textBoxRelease.Text == "Releasedatum")
            {
                textBoxRelease.Text = "";

                textBoxRelease.Font = new Font(textBoxRelease.Font, FontStyle.Regular);
            }
        }

        private void textBoxRelease_Leave(object sender, EventArgs e)
        {
            if (textBoxRelease.Text == "")
            {
                textBoxRelease.Text = "Releasedatum";

                textBoxRelease.Font = new Font(textBoxRelease.Font, FontStyle.Italic);
            }
        }

        private void textBoxDirector_Enter(object sender, EventArgs e)
        {
            if (textBoxDirector.Text == "Regisseur(s)")
            {
                textBoxDirector.Text = "";

                textBoxDirector.Font = new Font(textBoxDirector.Font, FontStyle.Regular);
            }
        }

        private void textBoxDirector_Leave(object sender, EventArgs e)
        {
            if (textBoxDirector.Text == "")
            {
                textBoxDirector.Text = "Regisseur(s)";

                textBoxDirector.Font = new Font(textBoxDirector.Font, FontStyle.Italic);
            }
        }

        private void textBoxGenre_Enter(object sender, EventArgs e)
        {
            if (textBoxGenre.Text == "Genre")
            {
                textBoxGenre.Text = "";

                textBoxGenre.Font = new Font(textBoxGenre.Font, FontStyle.Regular);
            }
        }

        private void textBoxGenre_Leave(object sender, EventArgs e)
        {
            if (textBoxGenre.Text == "")
            {
                textBoxGenre.Text = "Genre";

                textBoxGenre.Font = new Font(textBoxGenre.Font, FontStyle.Italic);
            }
        }

        private void textBoxLanguage_Enter(object sender, EventArgs e)
        {
            if (textBoxLanguage.Text == "Taal")
            {
                textBoxLanguage.Text = "";

                textBoxLanguage.Font = new Font(textBoxLanguage.Font, FontStyle.Regular);
            }
        }

        private void textBoxLanguage_Leave(object sender, EventArgs e)
        {
            if (textBoxLanguage.Text == "")
            {
                textBoxLanguage.Text = "Taal";

                textBoxLanguage.Font = new Font(textBoxLanguage.Font, FontStyle.Italic);
            }
        }

        private void textBoxRating_Enter(object sender, EventArgs e)
        {
            if (textBoxRating.Text == "Rating")
            {
                textBoxRating.Text = "";

                textBoxRating.Font = new Font(textBoxRating.Font, FontStyle.Regular);
            }
        }

        private void textBoxRating_Leave(object sender, EventArgs e)
        {
            if (textBoxRating.Text == "")
            {
                textBoxRating.Text = "Rating";

                textBoxRating.Font = new Font(textBoxRating.Font, FontStyle.Italic);
            }
        }

        private void textBoxAge_Enter(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "Leeftijd")
            {
                textBoxAge.Text = "";

                textBoxAge.Font = new Font(textBoxAge.Font, FontStyle.Regular);
            }
        }

        private void textBoxAge_Leave(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "")
            {
                textBoxAge.Text = "Leeftijd";

                textBoxAge.Font = new Font(textBoxAge.Font, FontStyle.Italic);
            }
        }

        private void textBoxRuntime_Enter(object sender, EventArgs e)
        {
            if (textBoxRuntime.Text == "Filmduur")
            {
                textBoxRuntime.Text = "";

                textBoxRuntime.Font = new Font(textBoxRuntime.Font, FontStyle.Regular);
            }
        }

        private void textBoxRuntime_Leave(object sender, EventArgs e)
        {
            if (textBoxRuntime.Text == "")
            {
                textBoxRuntime.Text = "Filmduur";

                textBoxRuntime.Font = new Font(textBoxRuntime.Font, FontStyle.Italic);
            }
        }

        private void textBoxFilmtechnology_Enter(object sender, EventArgs e)
        {
            if (textBoxFilmtechnology.Text == "Filmtechnologie")
            {
                textBoxFilmtechnology.Text = "";

                textBoxFilmtechnology.Font = new Font(textBoxFilmtechnology.Font, FontStyle.Regular);
            }
        }

        private void textBoxFilmtechnology_Leave(object sender, EventArgs e)
        {
            if (textBoxFilmtechnology.Text == "")
            {
                textBoxFilmtechnology.Text = "Filmtechnologie";

                textBoxFilmtechnology.Font = new Font(textBoxFilmtechnology.Font, FontStyle.Italic);
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "Prijs")
            {
                textBoxPrice.Text = "";

                textBoxPrice.Font = new Font(textBoxPrice.Font, FontStyle.Regular);
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.Text = "Prijs";

                textBoxPrice.Font = new Font(textBoxPrice.Font, FontStyle.Italic);
            }
        }

        private void textBoxTrailer_Enter(object sender, EventArgs e)
        {
            if (textBoxTrailer.Text == "Trailerlink")
            {
                textBoxTrailer.Text = "";

                textBoxTrailer.Font = new Font(textBoxTrailer.Font, FontStyle.Regular);
            }
        }

        private void textBoxTrailer_Leave(object sender, EventArgs e)
        {
            if (textBoxTrailer.Text == "")
            {
                textBoxTrailer.Text = "Trailerlink";

                textBoxTrailer.Font = new Font(textBoxTrailer.Font, FontStyle.Italic);
            }
        }

        private void textBoxSynopsis_Enter(object sender, EventArgs e)
        {
            if (textBoxSynopsis.Text == "Korte filmbeschrijving")
            {
                textBoxSynopsis.Text = "";

                textBoxSynopsis.Font = new Font(textBoxSynopsis.Font, FontStyle.Regular);
            }
        }

        private void textBoxSynopsis_Leave(object sender, EventArgs e)
        {
            if (textBoxSynopsis.Text == "")
            {
                textBoxSynopsis.Text = "Korte filmbeschrijving";

                textBoxSynopsis.Font = new Font(textBoxSynopsis.Font, FontStyle.Italic);
            }
        }

        private void AddMovieImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                //Admin may only choose jpg or png file
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;

                    AddMoviePoster.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Er is iets fout gegaan", "Foutmelding!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
