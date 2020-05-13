using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieReservation : Form
    {
        const string path = @"JsonTextFile.json";
        bool swapping = MovieReservationAvailableMoviesItem.chosenMoviePanelBool;
        public MovieReservation()
        {
            InitializeComponent();

            AvailableMovies();
        }

        int row = 0;
        private void chosenMovies()
        {

            string selectedMovieTitle = MovieReservationAvailableMoviesItem.chosenMovieForPanel;
            string selectedMovieTechnology = MovieReservationAvailableMoviesItem.chosenMovieTechnology;
            string selectedMovieRuntime = MovieReservationAvailableMoviesItem.chosenMovieRuntime;
            string selectedMovieDate = MovieReservationAvailableMoviesItem.chosenMovieDate;

            //populate items here
            MovieReservationAvailableMoviesItem[] MovieReservationChosenMoviesItems = new MovieReservationAvailableMoviesItem[1];

            for (int i = 0; i < 1; i++)
            {
                MovieReservationChosenMoviesItems[row] = new MovieReservationAvailableMoviesItem();

                MovieReservationChosenMoviesItems[row].MovieTitle = selectedMovieTitle;
                MovieReservationChosenMoviesItems[row].FilmTechnology = selectedMovieTechnology;
                MovieReservationChosenMoviesItems[row].Runtime = selectedMovieRuntime;
                MovieReservationChosenMoviesItems[row].Date = selectedMovieDate;
            }
            
            chosenMoviesPanel.Controls.Add(MovieReservationChosenMoviesItems[row]);

            row++;
        }

        private void AvailableMovies()
        {
            //Loads json file with all movies

            Dictionary<string, MovieDescriptionClass> ListView = JsonConvert.DeserializeObject<Dictionary<string, MovieDescriptionClass>>(File.ReadAllText(path));

            //fills list from streamreader

            List<KeyValuePair<string, int>> availableMoviesList = new List<KeyValuePair<string, int>>();
            List<string> technologies = new List<string>();

            // Read the file and display it line by line.
            StreamReader file = new StreamReader(@"movieSchedulesTest.txt");
            int count = 0;
            while (!file.EndOfStream)
            {
                string[] words = file.ReadLine().Split(',');
                for (int i = 0; i < 1; i++) //loops through each element of the array
                {
                    availableMoviesList.Add(new KeyValuePair<string, int>(words[i], count));
                    technologies.Add(words[i + 1]);
                    count++;
                }
            }
            file.Close();

            //populate items here
            MovieReservationAvailableMoviesItem[] MovieReservationAvailableMoviesItems = new MovieReservationAvailableMoviesItem[availableMoviesList.Count];

            string moviedate = "";

            for (int i = 0; i < MovieReservationAvailableMoviesItems.Length; i++)
            {
                MovieReservationAvailableMoviesItems[i] = new MovieReservationAvailableMoviesItem();

                MovieReservationAvailableMoviesItems[i].MovieTitle = ListView[availableMoviesList[i].Key].Title;
                MovieReservationAvailableMoviesItems[i].FilmTechnology = technologies[i];
                MovieReservationAvailableMoviesItems[i].Runtime = ListView[availableMoviesList[i].Key].Runtime;
                
                if(availableMoviesList[i].Value >= 0 && availableMoviesList[i].Value < 9)
                {
                    moviedate = DateTime.Now.ToString("dd - MM - yyyy");
                }
                if (availableMoviesList[i].Value >= 9 && availableMoviesList[i].Value < 18)
                {
                    moviedate = DateTime.Now.AddDays(1).ToString("dd - MM - yyyy");
                }
                if (availableMoviesList[i].Value >= 18 && availableMoviesList[i].Value < 27)
                {
                    moviedate = DateTime.Now.AddDays(2).ToString("dd - MM - yyyy");
                }
                if (availableMoviesList[i].Value >= 27 && availableMoviesList[i].Value < 36)
                {
                    moviedate = DateTime.Now.AddDays(3).ToString("dd - MM - yyyy");
                }
                if (availableMoviesList[i].Value >= 36 && availableMoviesList[i].Value < 45)
                {
                    moviedate = DateTime.Now.AddDays(4).ToString("dd - MM - yyyy");
                }
                if (availableMoviesList[i].Value >= 45 && availableMoviesList[i].Value < 54)
                {
                    moviedate = DateTime.Now.AddDays(5).ToString("dd - MM - yyyy");
                }
                if (availableMoviesList[i].Value >= 54 && availableMoviesList[i].Value < 63)
                {
                    moviedate = DateTime.Now.AddDays(6).ToString("dd - MM - yyyy");
                }

                MovieReservationAvailableMoviesItems[i].Date = moviedate;

                if (availableMoviesPanel.Controls.Count < 0)
                {
                    availableMoviesPanel.Controls.Clear();
                }
                else
                {
                    availableMoviesPanel.Controls.Add(MovieReservationAvailableMoviesItems[i]);
                }

            }
        }
    }
}
