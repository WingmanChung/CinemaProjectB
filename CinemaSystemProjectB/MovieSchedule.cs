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
            ScheduleScreen();
        }

        private void SecondSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
        }

        private void ThirthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
        }

        private void FourthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
        }

        private void FifthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
        }

        private void SixthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
        }

        private void SeventhSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
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
            ScheduleScreen();
        }
    }
}
