using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public struct MovieTitle
	{
		public string Name;
		public Label Label;
		public PictureBox Image;

        public MovieTitle(string name, Label label, PictureBox image)
        {
            Name = name;
            Label = label;
            Image = image;
        }
    }

    public partial class MovieOverview : Form
    {
        const string path = @"JsonTextFile.json";
        public MovieDescriptionClass MovieInfo { get; set; }

        public static string chosenMovie;
        public static bool HomeScreen = false;
		public static List<MovieTitle> titles = new List<MovieTitle>();
        public static Label[] labels { get; private set; }

        public MovieOverview()
        {
            InitializeComponent();
            LoadMoviesOverview();
        }

        public void LoadMoviesOverview() {
            if (!File.Exists("movieSchedulesTest.txt"))
            {
                using (StreamWriter datePath = File.CreateText("movieSchedulesTest.txt"))
                {
                    datePath.Close();
                }
            }

            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //List with all keys (movie titles)
            var movieList = ListView.Keys.ToArray();
            List<string> duplicateMovieList = new List<string>();

            //Fills movieschedule text file with movies if there is no total of 63 movies
            Random movieRound = new Random();

            int textFileLength = File.ReadLines(@"movieSchedulesTest.txt").Count();
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
                else if (textFileLength >= 0 && textFileLength < 2 ||
                        textFileLength >= 3 && textFileLength < 5 ||
                        textFileLength >= 6 && textFileLength < 8 ||
                        textFileLength >= 9 && textFileLength < 11 ||
                        textFileLength >= 12 && textFileLength < 14 ||
                        textFileLength >= 15 && textFileLength < 17 ||
                        textFileLength >= 18 && textFileLength < 20 ||
                        textFileLength >= 21 && textFileLength < 23 ||
                        textFileLength >= 24 && textFileLength < 26 ||
                        textFileLength >= 27 && textFileLength < 29 ||
                        textFileLength >= 30 && textFileLength < 32 ||
                        textFileLength >= 33 && textFileLength < 35 ||
                        textFileLength >= 36 && textFileLength < 38 ||
                        textFileLength >= 39 && textFileLength < 41 ||
                        textFileLength >= 42 && textFileLength < 44 ||
                        textFileLength >= 45 && textFileLength < 47 ||
                        textFileLength >= 48 && textFileLength < 50 ||
                        textFileLength >= 51 && textFileLength < 53 ||
                        textFileLength >= 54 && textFileLength < 56 ||
                        textFileLength >= 57 && textFileLength < 59 ||
                        textFileLength >= 60 && textFileLength < 62)
                {
                    string[] runTime = ListView[movieList[chosenRandomNumber]].Runtime.Split();
                    if (Int64.Parse(runTime[0]) > 180)
                    {
                        file2.Close();
                    }
                    else
                    {
                        duplicateMovieList.Add(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]);
                        file2.WriteLine(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]);
                        file2.Close();
                        textFileLength++;
                    }
                }
                else
                {
                    duplicateMovieList.Add(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]);
                    file2.WriteLine(ListView[movieList[chosenRandomNumber]].Title + ", " + technology[chosenRandomNumber2]);
                    file2.Close();
                    textFileLength++;
                }
            }

            if (!File.Exists("DateVerification.txt"))
            {
                using (StreamWriter datePath = File.CreateText("DateVerification.txt"))
                {
                    datePath.WriteLine(DateTime.Now.ToString("dd - MM - yyyy"));
                    datePath.Close();
                }
            }
            else
            {
                //Checks if dates are up-to-date
                var allLines = File.ReadLines("DateVerification.txt");
                int fileLength = File.ReadLines(@"DateVerification.txt").Count();
                int lineNumber = 0;
                foreach (var lineInAllLines in allLines)
                {
                    if (lineNumber + 1 == fileLength)
                    {
                        if (lineInAllLines != DateTime.Now.ToString("dd - MM - yyyy"))
                        {
                            string tempFile = Path.GetTempFileName();

                            using (var sr = new StreamReader("movieSchedulesTest.txt"))
                            using (var sw = new StreamWriter(tempFile))
                            {
                                string line;
                                int line_number = 0;
                                int lines_to_delete = 9;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    line_number++;

                                    if (line_number <= lines_to_delete)
                                        continue;

                                    sw.WriteLine(line);
                                }
                            }
                            File.Delete("movieSchedulesTest.txt");
                            File.Move(tempFile, "movieSchedulesTest.txt");
                        }
                    }
                    lineNumber++;
                }

                //Add today's date to text file
                StreamWriter datesFile = new StreamWriter(@"DateVerification.txt", true);
                datesFile.WriteLine(DateTime.Now.ToString("dd - MM - yyyy"));
                datesFile.Close();
            }

            string resultJson = JsonConvert.SerializeObject(MovieInfo);

            Dictionary<string, MovieDescriptionClass> Movies = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            labels = new Label[] { filmtitel1, filmtitel2, filmtitel3, filmtitel4, filmtitel5 };
            PictureBox[] images = new PictureBox[] { Film1, Film2, Film3, Film4, Film5 };
			titles.Clear();

            for (int i = 0; i < 5; i++)
            {
				string title = Movies.Keys.ElementAt(i);

				titles.Add(new MovieTitle(
					title,
					labels[i],
                    images[i]
				));

                toolTip1.SetToolTip(labels[i], title);
                labels[i].Text = title;
                images[i].Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(Movies[title].Image)));
            }

            Email.Text = "bioscoop@hr.nl";
            Telefoonnummer.Text = "010-1234567";
            Locatie.Text = "Wijnhaven 107, 3011 WN Rotterdam";

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
			MovieTitle title = titles.First(x => x.Image == pic);

			chosenMovie = title.Name;

            HomeScreen = true;
            new MovieDescription().Show();
            HomeScreen = false;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
		{
            // Get the MovieTitle object that contains this picture box
			MovieTitle title = titles.First(x => x.Image == sender);
			Label label = title.Label;

            // Measure the height of the wrapped text in the label
			var textSize = TextRenderer.MeasureText(label.Text,
				label.Font,
                new Size(label.Size.Width, int.MaxValue), // The bounding box stretches downwards so that the resulting text size is not limited
                TextFormatFlags.WordBreak // Specify that the lines should break when they extend past the label width
            );

            // Set the label size to the newly measured text size
			label.Size = new Size(label.Size.Width, Math.Max(label.Size.Height, textSize.Height + 2));
		}

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            MovieTitle title = titles.First(x => x.Image == sender);

            title.Label.Size = new Size(title.Label.Width, 20);
        }
        

        private void Filmtijdenknop_Click(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.Yellow;
            AdminLogin.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new MovieSchedule().Show();

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
            AdminLogin.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new Movies().Show();
        }

        private void Prijzenknop_Click(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.Yellow;
            AdminLogin.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new PriceList().Show();
        }

        private void Menuknop_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
            AdminLogin.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Reserveerknop.BackColor = Color.White;

            new MenuCard().Show();
        }

        private void Reserveerknop_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
            AdminLogin.BackColor = Color.White;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;

            new MovieReservation().Show();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
            Filmtijdenknop.BackColor = Color.White;
            Filmsknop.BackColor = Color.White;
            Prijzenknop.BackColor = Color.White;
            Menuknop.BackColor = Color.White;
            new AdminLoginForm().ShowDialog();
        }
    }
}
