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
    public partial class MovieSchedule : Form
    {
        const string path = @"JsonTextFile.json";

        public MovieSchedule()
        {
            InitializeComponent();
        }

        private void ScheduleScreen()
        {
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[10];

            for (int i = 0; i < 10; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();

                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 0 && i < 3)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 3 && i < 6)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 6 && i < 10)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void clearSchedules()
        {
            Screen1Schedule.Controls.Clear();
            Screen2Schedule.Controls.Clear();
            Screen3Schedule.Controls.Clear();
        }

        private void TodaySchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[10];

            for (int i = 0; i < 10; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();

                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 0 && i < 3)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 3 && i < 6)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 6 && i < 10)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void SecondSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[20];

            for (int i = 10; i < 20; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();

                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 10 && i < 13)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 13 && i < 16)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 16 && i < 20)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void ThirthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[30];

            for (int i = 20; i < 30; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();
                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 20 && i < 23)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 23 && i < 26)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 26 && i < 30)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void FourthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[40];

            for (int i = 30; i < 40; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();
                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 30 && i < 33)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 33 && i < 36)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 36 && i < 40)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void FifthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[43];

            for (int i = 40; i < 43; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();
                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 40 && i < 43)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void SixthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[10];

            for (int i = 0; i < 10; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();
                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 0 && i < 3)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 3 && i < 6)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 6 && i < 10)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        private void SeventhSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[30];

            for (int i = 20; i < 30; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();
                movieScheduleItems[i].MovieTitle = ListView[movieList[i]].Title;
                movieScheduleItems[i].FilmTechnology = ListView[movieList[i]].FilmTechnology;
                movieScheduleItems[i].Runtime = ListView[movieList[i]].Runtime;
                //end loop

                //fills screen 1 schedule
                if (i >= 20 && i < 23)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen1Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen1Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 2 schedule
                if (i >= 23 && i < 26)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen2Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen2Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
                //fills screen 3 schedule
                if (i >= 26 && i < 30)
                {
                    //checks wheter listview is already filled or not (with preview searchresult) <- Displays list in flowlayoutpanel
                    if (Screen1Schedule.Controls.Count < 0)
                    {
                        Screen3Schedule.Controls.Clear();
                    }
                    else
                    {
                        Screen3Schedule.Controls.Add(movieScheduleItems[i]);
                    }
                }
            }
        }

        //Selecting day button effect

        private void TodaySchedule_MouseEnter(object sender, EventArgs e)
        {
            TodaySchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void TodaySchedule_MouseLeave(object sender, EventArgs e)
        {
            TodaySchedule.BackColor = Color.Black;
        }

        private void SecondSchedule_MouseEnter(object sender, EventArgs e)
        {
            SecondSchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void SecondSchedule_MouseLeave(object sender, EventArgs e)
        {
            SecondSchedule.BackColor = Color.Black;
        }

        private void ThirthSchedule_MouseEnter(object sender, EventArgs e)
        {
            ThirthSchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void ThirthSchedule_MouseLeave(object sender, EventArgs e)
        {
            ThirthSchedule.BackColor = Color.Black;
        }

        private void FourthSchedule_MouseEnter(object sender, EventArgs e)
        {
            FourthSchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void FourthSchedule_MouseLeave(object sender, EventArgs e)
        {
            FourthSchedule.BackColor = Color.Black;
        }

        private void FifthSchedule_MouseEnter(object sender, EventArgs e)
        {
            FifthSchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void FifthSchedule_MouseLeave(object sender, EventArgs e)
        {
            FifthSchedule.BackColor = Color.Black;
        }

        private void SixthSchedule_MouseEnter(object sender, EventArgs e)
        {
            SixthSchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void SixthSchedule_MouseLeave(object sender, EventArgs e)
        {
            SixthSchedule.BackColor = Color.Black;
        }

        private void SeventhSchedule_MouseEnter(object sender, EventArgs e)
        {
            SeventhSchedule.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void SeventhSchedule_MouseLeave(object sender, EventArgs e)
        {
            SeventhSchedule.BackColor = Color.Black;
        }

        //shows movieschedule of today when you open movieschedule page
        private void MovieSchedule_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
