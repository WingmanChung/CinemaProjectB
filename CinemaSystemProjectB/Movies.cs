using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CinemaSystemProjectB
{
    public partial class Movies : Form
    {
        const string path = @"JsonTextFile.json";

        public MovieDescriptionClass ListViewItems { get; set; }
        public Movies()
        {
            InitializeComponent();
            AllMovies.Checked = true;
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            string resultJson = JsonConvert.SerializeObject(ListViewItems);

            Dictionary<string,MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));


            var movieList = ListView.Keys.ToArray();

            //populate here

            ListItem[] listItems = new ListItem[ListView.Count];

            //loop through each item

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                //load image
                var filmCover = ListView[ListView[movieList[i]].Title].Image;
                var bytesFilm = Convert.FromBase64String(filmCover);

                listItems[i].Cover = Image.FromStream(new MemoryStream(bytesFilm));

                listItems[i].Title = ListView[movieList[i]].Title;
                listItems[i].Release = ListView[movieList[i]].Release;
                listItems[i].Director = ListView[movieList[i]].Director;
                //listItems[i].FilmTechnology = ListView[movieList[i]].;
                //listItems[i].Rating = ListView[movieList[i]].;
                listItems[i].Age = ListView[movieList[i]].Age;
                //end loop


                //checks wheter listview is already filled or not (with preview searchresult)
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }

            



        }

        private void AllMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (AllMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
                HorrorMovies.Checked = false;
                SciFiMovies.Checked = false;
                ComedyMovies.Checked = false;
                AnimationMovies.Checked = false;
                DramaMovies.Checked = false;
                HistoryMovies.Checked = false;
                WarMovies.Checked = false;
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                populateItems();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
            }

            
        }
    }
}
