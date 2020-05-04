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


        string chosenGenre;
        string chosenAge;
        string chosenAge2;
        bool AboveTwelve = false;

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
            //Loads json file with all movies
            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //Sorts the array keys from A to Z
            if(NameMovies.Checked)
            {
                Array.Sort(movieList);
            }

            //Sorts the movies by rating from highest to lowest (Work in Progress)
            if (RatingMovies.Checked)
            {
                Array.Sort(movieList);
            }

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
                listItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                listItems[i].Rating = ListView[movieList[i]].Rating;
                listItems[i].Age = ListView[movieList[i]].Age;
                listItems[i].Genre = ListView[movieList[i]].Genre;
                //end loop


                //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
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

        private void genreItems()
        {
            //Loads json file with all movies
            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //Determines how many movies the chosen genre contains
            int movieCount = 0;
            var movieTitles = new List<string>();

            foreach (var movieTitle in movieList)
            {
                    if (ListView[movieTitle].Genre.Contains(chosenGenre))
                    {
                        movieTitles.Add(movieTitle);
                        movieCount++;
                    }
            }
           

            //Populate items in the list (flowlayoutpanel)
            ListItem[] listItems = new ListItem[movieCount];

            for (int i = 0, j = 0; i < 1; i++)
            {
                foreach (var title in movieTitles)
                {
                    listItems[j] = new ListItem();
                    
                    //load image
                    var filmCover = ListView[movieTitles[j]].Image;
                    var bytesFilm = Convert.FromBase64String(filmCover);

                    listItems[j].Cover = Image.FromStream(new MemoryStream(bytesFilm));

                    listItems[j].Title = ListView[movieTitles[j]].Title;
                    listItems[j].Release = ListView[movieTitles[j]].Release;
                    listItems[j].Director = ListView[movieTitles[j]].Director;
                    listItems[j].FilmTechnology = ListView[movieTitles[j]].FilmTechnology;
                    listItems[j].Rating = ListView[movieList[j]].Rating;
                    listItems[j].Age = ListView[movieTitles[j]].Age;
                    listItems[j].Genre = ListView[movieTitles[j]].Genre;
                    //end loop


                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(listItems[j]);
                    }
                    j++;
                }
            }
            
        }

        private void movieKidsItems()
        {
            //Loads json file with all movies
            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();
            if (AboveTwelve == false)
            {
                

                //Determines how many movies the chosen genre contains
                int movieCount = 0;
                    var movieTitles = new List<string>();

                    foreach (var movieTitle in movieList)
                    {


                        if (ListView[movieTitle].Age == chosenAge || ListView[movieTitle].Age == chosenAge2)
                        {
                            movieTitles.Add(movieTitle);
                            movieCount++;
                        }
                    
                    }
                    //Populate items in the list (flowlayoutpanel)
                    ListItem[] listItems = new ListItem[movieCount];
                    for (int i = 0, j = 0; i < 1; i++)
                    {

                        foreach (var title in movieTitles)
                        {
                            listItems[j] = new ListItem();
                            
                            //load image
                            var filmCover = ListView[movieTitles[j]].Image;
                            var bytesFilm = Convert.FromBase64String(filmCover);

                            listItems[j].Cover = Image.FromStream(new MemoryStream(bytesFilm));

                            listItems[j].Title = ListView[movieTitles[j]].Title;
                            listItems[j].Release = ListView[movieTitles[j]].Release;
                            listItems[j].Director = ListView[movieTitles[j]].Director;
                            listItems[j].FilmTechnology = ListView[movieTitles[j]].FilmTechnology;
                            listItems[i].Rating = ListView[movieList[i]].Rating;
                            listItems[j].Age = ListView[movieTitles[j]].Age;
                            listItems[j].Genre = ListView[movieTitles[j]].Genre;
                            //end loop


                            //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                            if (flowLayoutPanel1.Controls.Count < 0)
                            {
                                flowLayoutPanel1.Controls.Clear();
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(listItems[j]);
                            }
                            j++;
                        }
                    }
                
            }
            if (AboveTwelve == true)
            {   
                
                
                    //Determines how many movies the chosen genre contains
                    int movieCount = 0;
                    var movieTitles = new List<string>();

                    foreach (var movieTitle in movieList)
                    {

                        if (ListView[movieTitle].Age != chosenAge && ListView[movieTitle].Age != chosenAge2)
                        {
                            movieTitles.Add(movieTitle);
                            movieCount++;
                        }

                    }
                    
                    //Populate items in the list (flowlayoutpanel)
                    ListItem[] listItems = new ListItem[movieCount];
                    for (int i = 0, j = 0; i < 1; i++)
                    {

                        foreach (var title in movieTitles)
                        {
                            listItems[j] = new ListItem();
                            
                            //load image
                            var filmCover = ListView[movieTitles[j]].Image;
                            var bytesFilm = Convert.FromBase64String(filmCover);

                            listItems[j].Cover = Image.FromStream(new MemoryStream(bytesFilm));

                            listItems[j].Title = ListView[movieTitles[j]].Title;
                            listItems[j].Release = ListView[movieTitles[j]].Release;
                            listItems[j].Director = ListView[movieTitles[j]].Director;
                            listItems[j].FilmTechnology = ListView[movieTitles[j]].FilmTechnology;
                            listItems[i].Rating = ListView[movieList[i]].Rating;
                            listItems[j].Age = ListView[movieTitles[j]].Age;
                            listItems[j].Genre = ListView[movieTitles[j]].Genre;
                            //end loop


                            //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                            if (flowLayoutPanel1.Controls.Count < 0)
                            {
                                flowLayoutPanel1.Controls.Clear();
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(listItems[j]);
                            }
                            j++;
                        }
                    }
                
            }

        }

        private void AllMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (AllMovies.Checked)
            {
                //When All movies is checked, all genre boxes will be unchecked
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
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                flowLayoutPanel1.Controls.Clear();
                populateItems();
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }

        private void ThrillerMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (ThrillerMovies.Checked)
            {
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
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Thriller";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void ActionMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (ActionMovies.Checked)
            {
                ThrillerMovies.Checked = false;
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
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Actie";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void RomanceMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (RomanceMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
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
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Romantiek";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void FantasyMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (FantasyMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
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
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Fantasie";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }


        private void SciFiMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (SciFiMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
                HorrorMovies.Checked = false;
                ComedyMovies.Checked = false;
                AnimationMovies.Checked = false;
                DramaMovies.Checked = false;
                HistoryMovies.Checked = false;
                WarMovies.Checked = false;
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Sci-Fi";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void ComedyMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (ComedyMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
                HorrorMovies.Checked = false;
                SciFiMovies.Checked = false;
                AnimationMovies.Checked = false;
                DramaMovies.Checked = false;
                HistoryMovies.Checked = false;
                WarMovies.Checked = false;
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Comedie";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void AnimationMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (AnimationMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
                HorrorMovies.Checked = false;
                SciFiMovies.Checked = false;
                ComedyMovies.Checked = false;
                DramaMovies.Checked = false;
                HistoryMovies.Checked = false;
                WarMovies.Checked = false;
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Animatie";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void DramaMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (DramaMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
                HorrorMovies.Checked = false;
                SciFiMovies.Checked = false;
                ComedyMovies.Checked = false;
                AnimationMovies.Checked = false;
                HistoryMovies.Checked = false;
                WarMovies.Checked = false;
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Drama";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void HistoryMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (HistoryMovies.Checked)
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
                WarMovies.Checked = false;
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Historisch";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void WarMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (WarMovies.Checked)
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
                AdventureMovies.Checked = false;
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Oorlog";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void AdventureMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (AdventureMovies.Checked)
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
                MysteryMovies.Checked = false;
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Avontuur";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void MysteryMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (MysteryMovies.Checked)
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
                CrimeMovies.Checked = false;
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Mysterie";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void CrimeMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (CrimeMovies.Checked)
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
                FamilyMovies.Checked = false;
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Misdaad";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void FamilyMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (FamilyMovies.Checked)
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
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Familie";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void HorrorMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (HorrorMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
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
                AllMovies.Checked = false;
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenGenre = "Horror";
                flowLayoutPanel1.Controls.Clear();
                genreItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }
        private void AgeMovies_CheckedChanged(object sender, EventArgs e) //Age
        {
            if (AgeMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
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
                HorrorMovies.Checked = false;               
                TwelvePlus.Checked = false;
                AllMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenAge = "6+";
                chosenAge2 = "9+";
                AboveTwelve = false;
                flowLayoutPanel1.Controls.Clear();
                movieKidsItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void NameMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (NameMovies.Checked)
            {
                //When All movies is checked, all genre boxes will be unchecked
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
                TwelvePlus.Checked = false;
                AgeMovies.Checked = false;
                AllMovies.Checked = false;
                RatingMovies.Checked = false;
                flowLayoutPanel1.Controls.Clear();
                populateItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void RatingMovies_CheckedChanged(object sender, EventArgs e) //Rating
        {
            if (RatingMovies.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
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
                HorrorMovies.Checked = false;
                TwelvePlus.Checked = false;
                AllMovies.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                flowLayoutPanel1.Controls.Clear();
                populateItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void TwelvePlus_CheckedChanged(object sender, EventArgs e)
        {
            if (TwelvePlus.Checked)
            {
                ThrillerMovies.Checked = false;
                ActionMovies.Checked = false;
                RomanceMovies.Checked = false;
                FantasyMovies.Checked = false;
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
                HorrorMovies.Checked = false;
                AllMovies.Checked = false;
                AgeMovies.Checked = false;
                NameMovies.Checked = false;
                RatingMovies.Checked = false;
                chosenAge = "6+";
                chosenAge2 = "9+";
                AboveTwelve = true;
                flowLayoutPanel1.Controls.Clear();
                movieKidsItems();
            }
            else
            {
                codeRepetitionForCategorie();
            }
        }

        private void codeRepetitionForCategorie()
        {
            flowLayoutPanel1.Controls.Clear();
            if (AgeMovies.Checked == false && NameMovies.Checked == false && TwelvePlus.Checked == false && RatingMovies.Checked == false)
            {
                if (ThrillerMovies.Checked == false &&
                 ActionMovies.Checked == false &&
                 RomanceMovies.Checked == false &&
                 FantasyMovies.Checked == false &&
                 SciFiMovies.Checked == false &&
                 ComedyMovies.Checked == false &&
                 AnimationMovies.Checked == false &&
                 DramaMovies.Checked == false &&
                 HistoryMovies.Checked == false &&
                 WarMovies.Checked == false &&
                 AdventureMovies.Checked == false &&
                 MysteryMovies.Checked == false &&
                 CrimeMovies.Checked == false &&
                 FamilyMovies.Checked == false &&
                 HorrorMovies.Checked == false &&
                 AllMovies.Checked == false &&
                 AgeMovies.Checked == false &&
                 NameMovies.Checked == false &&
                 RatingMovies.Checked == false)
                {
                    AllMovies.Checked = true;
                }
            }
        }
    }
}
