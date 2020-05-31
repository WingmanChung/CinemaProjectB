using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class AdminRemoveMovie : UserControl
    {
        private bool isCollapsed = false;
        const string path = @"JsonTextFile.json";
        public AdminRemoveMovie()
        {
            InitializeComponent();
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
                var RemoveItem = new AdminRemoveMovieItem();
                //load image
                var filmCover = ListView[movieList[i]].Image;
                var bytesFilm = Convert.FromBase64String(filmCover);

                RemoveItem.Cover = Image.FromStream(new MemoryStream(bytesFilm));

                RemoveItem.Title = ListView[movieList[i]].Title;
                RemoveItem.Release = ListView[movieList[i]].Release;
                
                RemoveItem.FilmTechnology = ListView[movieList[i]].FilmTechnology;
                RemoveItem.Rating = ListView[movieList[i]].Rating.ToString();
                
                RemoveItem.Genre = ListView[movieList[i]].Genre;
                RemoveItem.Language = ListView[movieList[i]].Language;

                AllMoviesList.Controls.Add(RemoveItem);

            }
        }

        private void OpenRemoveMoviePanel_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                RemoveMovieControl.Size = RemoveMovieControl.MinimumSize;
                this.Size = this.MinimumSize;
                isCollapsed = false;
            }
            else
            {
                this.Size = this.MaximumSize;
                RemoveMovieControl.Size = RemoveMovieControl.MaximumSize;
                isCollapsed = true;
            }
        }

        private void RemoveMovieButton_Click(object sender, EventArgs e)
        {
            List<string> Selected = new List<string>();
            foreach (Control C in AllMoviesList.Controls)
            {
                if (C is AdminRemoveMovieItem && ((AdminRemoveMovieItem)C).IsClicked)
                {
                    Selected.Add(((AdminRemoveMovieItem)C).Title);
                }
            }

            JObject file = JObject.Parse(File.ReadAllText(path));
            foreach(string title in Selected)
            {
                file.Remove(title);
            }
             File.WriteAllText(path, file.ToString(Formatting.Indented));
            FillAllMovieList();
            Program.MovieOverview.LoadMoviesOverview();
        }
    }
}
