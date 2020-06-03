using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CinemaSystemProjectB
{
    public partial class AdminEditMovie : UserControl
    {
        private bool isCollapsed = false;
        const string path = @"JsonTextFile.json";
        public AdminEditMovie()
        {
            InitializeComponent();

            // Shrink upon initialization (allows the form to be big in the designer tab)
            this.Size = this.MinimumSize;

            FillAllMovieList();
        }

        public void FillAllMovieList()
        {

            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            AllMoviesList.Controls.Clear();
            for (int i = 0; i < movieList.Length; i++)
            {
                var EditItem = new AdminEditMovieItem(ListView[movieList[i]].Title);
                //load image
                var filmCover = ListView[movieList[i]].Image;
                var bytesFilm = Convert.FromBase64String(filmCover);

                EditItem.Cover = Image.FromStream(new MemoryStream(bytesFilm));
                EditItem.Release = ListView[movieList[i]].Release;

                EditItem.FilmTechnology = ListView[movieList[i]].FilmTechnology;
                EditItem.Rating = ListView[movieList[i]].Rating.ToString();

                EditItem.Genre = ListView[movieList[i]].Genre;
                EditItem.Language = ListView[movieList[i]].Language;

                AllMoviesList.Controls.Add(EditItem);

            }
        }

        private void OpenRemoveMoviePanel_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                EditMovieControl.Size = EditMovieControl.MinimumSize;
                this.Size = this.MinimumSize;
                isCollapsed = false;
            }
            else
            {
                this.Size = this.MaximumSize;
                EditMovieControl.Size = EditMovieControl.MaximumSize;
                isCollapsed = true;
            }
        }


    }
}
