using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieSchedule : Form
    {
        const string path = @"JsonTextFile.json";
        public int movieScheduleCount;

        public MovieSchedule()
        {
            InitializeComponent();

            TodaySchedule.Text = DateTime.Now.ToString("dd - MM - yyyy");
            SecondSchedule.Text = DateTime.Now.AddDays(1).ToString("dd - MM - yyyy");
            ThirthSchedule.Text = DateTime.Now.AddDays(2).ToString("dd - MM - yyyy");
            FourthSchedule.Text = DateTime.Now.AddDays(3).ToString("dd - MM - yyyy");
            FifthSchedule.Text = DateTime.Now.AddDays(4).ToString("dd - MM - yyyy");
            SixthSchedule.Text = DateTime.Now.AddDays(5).ToString("dd - MM - yyyy");
            SeventhSchedule.Text = DateTime.Now.AddDays(6).ToString("dd - MM - yyyy");
        }

        private void ScheduleScreen()
        {
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();
            List<string> duplicateMovieList = new List<string>();

            //Fills movieschedule text file with movies if there is no total of 63 movies
            Random movieRound = new Random();

            while (File.ReadLines(@"movieSchedulesTest.txt").Count() < 63)
            {
                StreamWriter file2 = new StreamWriter(@"movieSchedulesTest.txt", true);

                int chosenRandomNumber = movieRound.Next(0, 43);

                string[] technology = ListView[movieList[chosenRandomNumber]].FilmTechnology.Split(',');
                int chosenRandomNumber2 = movieRound.Next(0, technology.Length);
                //Method to avoid duplicates in movieschedules
                if (duplicateMovieList.Contains(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]))
                {
                    file2.Close();
                }
                else
                {
                    duplicateMovieList.Add(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]);
                    file2.WriteLine(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]);
                    file2.Close();
                }
            }

            //fills list from streamreader

            List<KeyValuePair<string, string>> woorden = new List<KeyValuePair<string, string>>();

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(@"movieSchedulesTest.txt");
            while (!file.EndOfStream)
            {
                string[] words = file.ReadLine().Split(',');
                for (int i = 0; i < 1; i++) //loops through each element of the array
                {
                    woorden.Add(new KeyValuePair<string, string>(words[i], words[i + 1]));
                }
            }
            file.Close();

            //populate items here

            MovieScheduleItem[] movieScheduleItems = new MovieScheduleItem[9];

            for (int i = 0, j = movieScheduleCount; i < 9; i++)
            {
                movieScheduleItems[i] = new MovieScheduleItem();

                movieScheduleItems[i].MovieTitle = ListView[woorden[j].Key].Title;
                movieScheduleItems[i].FilmTechnology = woorden[j].Value;
                movieScheduleItems[i].Runtime = ListView[woorden[j].Key].Runtime;
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
                if (i >= 6 && i < 9)
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

                j++;
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
            movieScheduleCount = 0;
            ScheduleScreen();
        }

        private void SecondSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            movieScheduleCount = 9;
            ScheduleScreen();
        }

        private void ThirthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            movieScheduleCount = 18;
            ScheduleScreen();
        }

        private void FourthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            movieScheduleCount = 27;
            ScheduleScreen();
        }

        private void FifthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            movieScheduleCount = 36;
            ScheduleScreen();
        }

        private void SixthSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            movieScheduleCount = 45;
            ScheduleScreen();
        }

        private void SeventhSchedule_Click(object sender, EventArgs e)
        {
            clearSchedules();
            movieScheduleCount = 54;
            ScheduleScreen();
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
