using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class MovieReservation : Form
	{

		const string path = @"JsonTextFile.json";

		//pages is a list of panels
		List<Panel> pages = new List<Panel>();

		//Integer to determine the page
		int page = 0;

		//Temp is list of chosen movies
		List<string[]> Temp = new List<string[]>();

		public MovieReservation()
		{
			InitializeComponent();

			AvailableMovies();

			//if there are zero movies selected, then the next page button won't work
			NextPageButton.Enabled = false;
		}

		int row = 0;
		int j = 1;
		public void chosenMovies()
		{
			var chosenItem = MovieReservationAvailableMoviesItem.chosenItem;
			string selectedMovieTitle = chosenItem.MovieTitle;
			string selectedMovieTechnology = chosenItem.FilmTechnology;
			string selectedMovieRuntime = chosenItem.Runtime;
			string selectedMovieDate = chosenItem.Date;

			//populate items here
			MovieReservationChosenMoviesItem[] MovieReservationChosenMoviesItems = new MovieReservationChosenMoviesItem[j];

			MovieReservationChosenMoviesItems[row] = new MovieReservationChosenMoviesItem(chosenItem);

			MovieReservationChosenMoviesItems[row].MovieTitle = selectedMovieTitle;
			MovieReservationChosenMoviesItems[row].FilmTechnology = selectedMovieTechnology;
			MovieReservationChosenMoviesItems[row].Runtime = selectedMovieRuntime;
			MovieReservationChosenMoviesItems[row].Date = selectedMovieDate;

			chosenMoviesPanel.Controls.Add(MovieReservationChosenMoviesItems[row]);
			chosenItem.Chosen = true;

			//create string array with all movie information
			string[] tempstring = new string[4];
			tempstring[0] = selectedMovieTitle;
			tempstring[1] = selectedMovieTechnology;
			tempstring[2] = selectedMovieRuntime;
			tempstring[3] = selectedMovieDate;

			//add string array to list
			Temp.Add(tempstring);

			row++;
			j++;

			MovieSelected();
		}

		public void MovieSelected()
		{
			//if there are zero movies selected, then the next page button won't work
			if (chosenMoviesPanel.Controls.Count == 0)
			{
				NextPageButton.Enabled = false;
			}
			else
			{
				NextPageButton.Enabled = true;
			}
		}

		public void SelectPeople()
		{
			var chosenItem = MovieReservationAvailableMoviesItem.chosenItem;

			//clear select page and shows new result
			SelectPeoplePanel.Controls.Clear();

			//fills select page with all chosen movies <- Temp contains list of string arrays (which contains movietitle, filmtechnology, runtime and date)
			for (int i = 0, j = 0; i < Temp.Count; i++)
			{
				SelectPeopleItem[] SelectPeopleItems = new SelectPeopleItem[Temp.Count];

				SelectPeopleItems[i] = new SelectPeopleItem(chosenItem);

				SelectPeopleItems[i].MovieTitle = Temp[i][j];
				SelectPeopleItems[i].FilmTechnology = Temp[i][j + 1];
				SelectPeopleItems[i].Runtime = Temp[i][j + 2];
				SelectPeopleItems[i].Date = Temp[i][j + 3];

				SelectPeoplePanel.Controls.Add(SelectPeopleItems[i]);
			}
		}

		public void RemoveItem(MovieReservationChosenMoviesItem item)
		{
			chosenMoviesPanel.Controls.Remove(item);

			//Deletes the same item from selecting people page. If the string array is the same as the deleted item, then it deletes the movie from temp list
			//Temp list contains all chosen movies
			for (int i = 0, j = 0; i < Temp.Count; i++)
			{
				if(
					Temp[i][j] == item.MovieTitle &&
					Temp[i][j+1] == item.FilmTechnology &&
					Temp[i][j+2] == item.Runtime &&
					Temp[i][j+3] == item.Date)
				{
					Temp.RemoveAt(i);
				}
			}

			MovieSelected();
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

				if (availableMoviesList[i].Value >= 0 && availableMoviesList[i].Value < 9)
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

		private void Page1NextButton_MouseEnter(object sender, EventArgs e)
		{
			NextPageButton.BackColor = Color.Gold;
		}

		private void Page1NextButton_MouseLeave(object sender, EventArgs e)
		{
			NextPageButton.BackColor = Color.Yellow;
		}

		private void MovieReservation_Load(object sender, EventArgs e)
		{
			pages.Add(PageNumber1);
			pages.Add(PageNumber2);
			pages.Add(PageNumber3);
			pages[page].BringToFront();
			PreviousPageButton.Visible = false;
		}

		private void NextPageButton_Click(object sender, EventArgs e)
		{

			//While current page is not the last page -> Next button will work
			if (page < pages.Count - 1)
			{
				pages[++page].BringToFront();
			}

			//Determines wether the return button is visible or not
			if (page > 0)
			{
				PreviousPageButton.Visible = true;
			}

			//if the visible page is selecting people page, then it runs the function to load all movies in the panel
			if (page == 1)
			{
				SelectPeople();
			}
		}

		private void PreviousPageButton_MouseClick(object sender, MouseEventArgs e)
		{
			//While current page is not the first page -> Previous button will work
			if (page > 0)
			{
				pages[--page].BringToFront();
			}

			//Determines wether the return button is visible or not
			if (page == 0)
			{
				PreviousPageButton.Visible = false;
			}
		}

		private void PreviousPageButton_MouseEnter(object sender, EventArgs e)
		{
			PreviousPageButton.BackColor = Color.Gold;
		}

		private void PreviousPageButton_MouseLeave(object sender, EventArgs e)
		{
			PreviousPageButton.BackColor = Color.Yellow;
		}

		private void RoadMapButton_Click(object sender, EventArgs e)
		{
			new RoadMap().Show();
		}

		private void DisclaimerButton_Click(object sender, EventArgs e)
		{

			new Disclaimer().ShowDialog();
			

		}

		private void DisclaimerButton_MouseEnter(object sender, EventArgs e)
		{
			DisclaimerButton.BackColor = Color.Gold;
		}

		private void DisclaimerButton_MouseLeave(object sender, EventArgs e)
		{
			DisclaimerButton.BackColor = Color.Yellow;
		}

		private void RoadMapButton_MouseEnter(object sender, EventArgs e)
		{
			RoadMapButton.BackColor = Color.Gold;
		}

		private void RoadMapButton_MouseLeave(object sender, EventArgs e)
		{
			RoadMapButton.BackColor = Color.Yellow;
		}
	}
}
