using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
	public partial class AdminEditMovieWindow : Form
	{
		const string path = @"JsonTextFile.json";

		string EditMovieTitle = AdminEditMovieItem.ChosenEdit;

		Dictionary<string, MovieDescriptionClass> movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));



		public AdminEditMovieWindow()
		{
			InitializeComponent();

			this.textBoxSynopsis.Text = movies[EditMovieTitle].Synopsis;
			this.textBoxTrailer.Text = movies[EditMovieTitle].Trailer;

			var fileString = movies[EditMovieTitle].Image;
			var bytes = Convert.FromBase64String(fileString);

			this.AddMoviePoster.Image = Image.FromStream(new MemoryStream(bytes));

			this.textBoxPrice.Text = movies[EditMovieTitle].Price;
			this.textBoxTitle.Text = movies[EditMovieTitle].Title;
			this.textBoxFilmtechnology.Text = movies[EditMovieTitle].FilmTechnology;
			this.textBoxRelease.Text = movies[EditMovieTitle].Release;
			this.textBoxRuntime.Text = movies[EditMovieTitle].Runtime;
			this.textBoxDirector.Text = movies[EditMovieTitle].Director;
			this.textBoxAge.Text = movies[EditMovieTitle].Age;
			this.textBoxGenre.Text = movies[EditMovieTitle].Genre;
			this.textBoxRating.Text = movies[EditMovieTitle].Rating.ToString();
			this.textBoxLanguage.Text = movies[EditMovieTitle].Language;
		}

		public void EditFields()
		{
			var movieEdit = new MovieDescriptionClass()
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
                Image = movies[EditMovieTitle].Image
			};

			if (this.AddMoviePoster.ImageLocation != null)
			{
				string Image = Convert.ToBase64String(File.ReadAllBytes(this.AddMoviePoster.ImageLocation));
				movieEdit.Image = Image;
			}

			movies.Remove(EditMovieTitle);
			movies[movieEdit.Title] = movieEdit;
		}

		private void EditMovieButton_Click(object sender, EventArgs e)
		{
			EditFields();

			File.WriteAllText(path, JsonConvert.SerializeObject(movies, Formatting.Indented));


			MessageBox.Show("Film gewijzigd");

            AdminEditMovieWindow obj = (AdminEditMovieWindow)Application.OpenForms["AdminEditMovieWindow"];
            AdminPanel obj2 = (AdminPanel)Application.OpenForms["AdminPanel"];
			new AdminPanel().Show();
            obj.Close();
            obj2.Close();
		}

		private void EditMovieButton_MouseEnter(object sender, EventArgs e)
		{
			EditMovieButton.BackColor = Color.Gold;
		}

		private void EditMovieButton_MouseLeave(object sender, EventArgs e)
		{
			EditMovieButton.BackColor = Color.Yellow;
		}

		private void AddMovieImageButton_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();

				//Admin may only choose jpg or png file
				dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

				if (dialog.ShowDialog() == DialogResult.OK)
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

		private void AddMovieImageButton_MouseEnter(object sender, EventArgs e)
		{
			AddMovieImageButton.BackColor = Color.Gold;
		}

		private void AddMovieImageButton_MouseLeave(object sender, EventArgs e)
		{
			AddMovieImageButton.BackColor = Color.Yellow;
		}
	}
}
