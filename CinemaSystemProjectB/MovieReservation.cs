using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
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
			string selectedMovieScreen = chosenItem.Screen;

			//populate items here
			MovieReservationChosenMoviesItem[] MovieReservationChosenMoviesItems = new MovieReservationChosenMoviesItem[j];

			MovieReservationChosenMoviesItems[row] = new MovieReservationChosenMoviesItem(chosenItem);

			MovieReservationChosenMoviesItems[row].MovieTitle = selectedMovieTitle;
			MovieReservationChosenMoviesItems[row].FilmTechnology = selectedMovieTechnology;
			MovieReservationChosenMoviesItems[row].Runtime = selectedMovieRuntime;
			MovieReservationChosenMoviesItems[row].Date = selectedMovieDate;
			MovieReservationChosenMoviesItems[row].Screen = selectedMovieScreen;

			chosenMoviesPanel.Controls.Add(MovieReservationChosenMoviesItems[row]);
			chosenItem.Chosen = true;

			//create string array with all movie information
			string[] tempstring = new string[5];
			tempstring[0] = selectedMovieTitle;
			tempstring[1] = selectedMovieTechnology;
			tempstring[2] = selectedMovieRuntime;
			tempstring[3] = selectedMovieDate;
			tempstring[4] = selectedMovieScreen;

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
			FoodMenuPanel.Controls.Clear();

			//fills select page with all chosen movies <- Temp contains list of string arrays (which contains movietitle, filmtechnology, runtime and date)
			for (int i = 0, j = 0; i < Temp.Count; i++)
			{
				SelectPeopleItem[] SelectPeopleItems = new SelectPeopleItem[Temp.Count];

				SelectPeopleItems[i] = new SelectPeopleItem(chosenItem);

				SelectPeopleItems[i].MovieTitle = Temp[i][j];
				SelectPeopleItems[i].FilmTechnology = Temp[i][j + 1];
				SelectPeopleItems[i].Runtime = Temp[i][j + 2];
				SelectPeopleItems[i].Date = Temp[i][j + 3];
				SelectPeopleItems[i].Screen = Temp[i][j + 4];

				SelectPeoplePanel.Controls.Add(SelectPeopleItems[i]);
			}

			//fills food menu page with all chosen movies
			for (int i = 0, j = 0; i < Temp.Count; i++)
			{
				FoodMenuMovieItem[] FoodMenuMovieItems = new FoodMenuMovieItem[Temp.Count];

				FoodMenuMovieItems[i] = new FoodMenuMovieItem(chosenItem);

				FoodMenuMovieItems[i].MovieTitle = Temp[i][j];
				FoodMenuMovieItems[i].FilmTechnology = Temp[i][j + 1];
				FoodMenuMovieItems[i].Runtime = Temp[i][j + 2];
				FoodMenuMovieItems[i].Date = Temp[i][j + 3];

				FoodMenuPanel.Controls.Add(FoodMenuMovieItems[i]);
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
			string moviescreen = "";

			for (int i = 0; i < MovieReservationAvailableMoviesItems.Length; i++)
			{
				MovieReservationAvailableMoviesItems[i] = new MovieReservationAvailableMoviesItem();

				//Key = movie title, Value = Index in available movie list
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
				
				//Value = index in available movie list. first 3 is for example screen 1, second 3 are screen 2, third 3 are screen 3 etc.
				if (availableMoviesList[i].Value == 0 ||
				    availableMoviesList[i].Value == 1 ||
				    availableMoviesList[i].Value == 2 ||

					availableMoviesList[i].Value == 9 ||
					availableMoviesList[i].Value == 10 ||
					availableMoviesList[i].Value == 11 ||

					availableMoviesList[i].Value == 18 ||
					availableMoviesList[i].Value == 19 ||
					availableMoviesList[i].Value == 20 ||

					availableMoviesList[i].Value == 27 ||
					availableMoviesList[i].Value == 28 ||
					availableMoviesList[i].Value == 29 ||

					availableMoviesList[i].Value == 36 ||
					availableMoviesList[i].Value == 37 ||
					availableMoviesList[i].Value == 38 ||

					availableMoviesList[i].Value == 45 ||
					availableMoviesList[i].Value == 46 ||
					availableMoviesList[i].Value == 47 ||

					availableMoviesList[i].Value == 54 ||
					availableMoviesList[i].Value == 55 ||
					availableMoviesList[i].Value == 56)
				{
					moviescreen = "Screen 1";
				}
				if (availableMoviesList[i].Value == 3 ||
				    availableMoviesList[i].Value == 4 ||
				    availableMoviesList[i].Value == 5 ||

					availableMoviesList[i].Value == 12 ||
					availableMoviesList[i].Value == 13 ||
					availableMoviesList[i].Value == 14 ||

					availableMoviesList[i].Value == 21 ||
					availableMoviesList[i].Value == 22 ||
					availableMoviesList[i].Value == 23 ||

					availableMoviesList[i].Value == 30 ||
					availableMoviesList[i].Value == 31 ||
					availableMoviesList[i].Value == 32 ||

					availableMoviesList[i].Value == 39 ||
					availableMoviesList[i].Value == 40 ||
					availableMoviesList[i].Value == 41 ||

					availableMoviesList[i].Value == 48 ||
					availableMoviesList[i].Value == 49 ||
					availableMoviesList[i].Value == 50 ||

					availableMoviesList[i].Value == 57 ||
					availableMoviesList[i].Value == 58 ||
					availableMoviesList[i].Value == 59)
				{
					moviescreen = "Screen 2";
				}
				if (availableMoviesList[i].Value == 6 ||
					availableMoviesList[i].Value == 7 ||
					availableMoviesList[i].Value == 8 ||

					availableMoviesList[i].Value == 15 ||
					availableMoviesList[i].Value == 16 ||
					availableMoviesList[i].Value == 17 ||

					availableMoviesList[i].Value == 24 ||
					availableMoviesList[i].Value == 25 ||
					availableMoviesList[i].Value == 26 ||

					availableMoviesList[i].Value == 33 ||
					availableMoviesList[i].Value == 34 ||
					availableMoviesList[i].Value == 35 ||

					availableMoviesList[i].Value == 42 ||
					availableMoviesList[i].Value == 43 ||
					availableMoviesList[i].Value == 44 ||

					availableMoviesList[i].Value == 51 ||
					availableMoviesList[i].Value == 52 ||
					availableMoviesList[i].Value == 53 ||

					availableMoviesList[i].Value == 60 ||
					availableMoviesList[i].Value == 61 ||
					availableMoviesList[i].Value == 62)
				{
					moviescreen = "Screen 3";
				}

				MovieReservationAvailableMoviesItems[i].Screen = moviescreen;

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
				MovieReservationLabel.Text = "Film reservering";

				PreviousPageButton.Visible = true;
				//if the visible page is selecting people page, then it runs the function to load all movies in the panel
				if (page == 1)
				{
					SelectPeople();
					NextPageButton.Enabled = false;
					//checks if all comboboxes are filled else the nextpagebutton will remain disabled
				}

				//if page is 2 (snack & drink menu) then it changes the text of MovieReservationLabel
				else if(page == 2)
				{
					MovieReservationLabel.Text = "Snack reservering";
					//Fills all food options with the same "amount" of people
					object[][] numbers = new object[SelectPeoplePanel.Controls.Count][];
					int i = 0;
					foreach (SelectPeopleItem movie in SelectPeoplePanel.Controls)
					{
						var x = (movie.comboBoxAdult.SelectedIndex) + (movie.comboBoxKids.SelectedIndex);
						for (int j = 0; j < x; j++)
						{
							numbers[i] = new object[x + 1];
							for (int k = 0; k < numbers[i].Length; k++)
							{
								numbers[i][k] = k;
							}
						}
						i++;
					}

					//Add the correct amount of total people to the correct movie in the foodmenupanel
					int num = 0;
					foreach (FoodMenuMovieItem item in FoodMenuPanel.Controls)
					{
						if (item.comboBox1.Items.Count == 0)
						{
							//add new combobox items
							item.comboBox1.Items.AddRange(numbers[num]);
							item.comboBox2.Items.AddRange(numbers[num]);
							item.comboBox3.Items.AddRange(numbers[num]);
							item.comboBox4.Items.AddRange(numbers[num]);
							item.comboBox5.Items.AddRange(numbers[num]);
							item.comboBox6.Items.AddRange(numbers[num]);
							item.comboBox7.Items.AddRange(numbers[num]);
							item.comboBox8.Items.AddRange(numbers[num]);
							item.comboBox9.Items.AddRange(numbers[num]);
							item.comboBox10.Items.AddRange(numbers[num]);
							item.comboBox11.Items.AddRange(numbers[num]);
							item.comboBox12.Items.AddRange(numbers[num]);
							item.comboBox13.Items.AddRange(numbers[num]);
							item.comboBox14.Items.AddRange(numbers[num]);
							item.comboBox15.Items.AddRange(numbers[num]);
							item.comboBox16.Items.AddRange(numbers[num]);
							item.comboBox17.Items.AddRange(numbers[num]);
							item.comboBox18.Items.AddRange(numbers[num]);
							item.comboBox19.Items.AddRange(numbers[num]);
							//sets all combobox display text to zero
							DefaultSelected(item);
							num++;
						}
						else
						{
							//clears previous combobox items
							item.comboBox1.Items.Clear();
							item.comboBox2.Items.Clear();
							item.comboBox3.Items.Clear();
							item.comboBox4.Items.Clear();
							item.comboBox5.Items.Clear();
							item.comboBox6.Items.Clear();
							item.comboBox7.Items.Clear();
							item.comboBox8.Items.Clear();
							item.comboBox9.Items.Clear();
							item.comboBox10.Items.Clear();
							item.comboBox11.Items.Clear();
							item.comboBox12.Items.Clear();
							item.comboBox13.Items.Clear();
							item.comboBox14.Items.Clear();
							item.comboBox15.Items.Clear();
							item.comboBox16.Items.Clear();
							item.comboBox17.Items.Clear();
							item.comboBox18.Items.Clear();
							item.comboBox19.Items.Clear();
							//add new combobox items
							item.comboBox1.Items.AddRange(numbers[num]);
							item.comboBox2.Items.AddRange(numbers[num]);
							item.comboBox3.Items.AddRange(numbers[num]);
							item.comboBox4.Items.AddRange(numbers[num]);
							item.comboBox5.Items.AddRange(numbers[num]);
							item.comboBox6.Items.AddRange(numbers[num]);
							item.comboBox7.Items.AddRange(numbers[num]);
							item.comboBox8.Items.AddRange(numbers[num]);
							item.comboBox9.Items.AddRange(numbers[num]);
							item.comboBox10.Items.AddRange(numbers[num]);
							item.comboBox11.Items.AddRange(numbers[num]);
							item.comboBox12.Items.AddRange(numbers[num]);
							item.comboBox13.Items.AddRange(numbers[num]);
							item.comboBox14.Items.AddRange(numbers[num]);
							item.comboBox15.Items.AddRange(numbers[num]);
							item.comboBox16.Items.AddRange(numbers[num]);
							item.comboBox17.Items.AddRange(numbers[num]);
							item.comboBox18.Items.AddRange(numbers[num]);
							item.comboBox19.Items.AddRange(numbers[num]);
							//sets all combobox display text to zero
							DefaultSelected(item);
							num++;
						}
					}
				}
			}
		}

		public void DefaultSelected(FoodMenuMovieItem item)
		{
			item.comboBox1.SelectedIndex = 0;
			item.comboBox2.SelectedIndex = 0;
			item.comboBox3.SelectedIndex = 0;
			item.comboBox4.SelectedIndex = 0;
			item.comboBox5.SelectedIndex = 0;
			item.comboBox6.SelectedIndex = 0;
			item.comboBox7.SelectedIndex = 0;
			item.comboBox8.SelectedIndex = 0;
			item.comboBox9.SelectedIndex = 0;
			item.comboBox10.SelectedIndex = 0;
			item.comboBox11.SelectedIndex = 0;
			item.comboBox12.SelectedIndex = 0;
			item.comboBox13.SelectedIndex = 0;
			item.comboBox14.SelectedIndex = 0;
			item.comboBox15.SelectedIndex = 0;
			item.comboBox16.SelectedIndex = 0;
			item.comboBox17.SelectedIndex = 0;
			item.comboBox18.SelectedIndex = 0;
			item.comboBox19.SelectedIndex = 0;
		}

		private void PreviousPageButton_MouseClick(object sender, MouseEventArgs e)
		{
			//While current page is not the first page -> Previous button will work
			if (page > 0)
			{
				MovieReservationLabel.Text = "Film reservering";
				if (page == 1)
				{
					//Warning to make sure the user understands the consequence of pressing the "previous page" button
					DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u terug naar de vorige pagina wilt gaan? Zo ja, dan worden uw geselecteerde keuzes verwijderd.", "Waarschuwing", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						pages[--page].BringToFront();
					}
					//Check is chosenmoviepanel contains movie. If yes, then the next button will be enabled.
					if (chosenMoviesPanel.Controls.Count != 0)
					{
						NextPageButton.Enabled = true;
					}
				}
				else
				{
					pages[--page].BringToFront();
				}
			}

			//Determines wether the return button is visible or not
			if (page == 0)
			{
				PreviousPageButton.Visible = false;
			}
		}

		public void checkAllBoxes()
		{
			//checks if all comboboxes are filled else the nextpagebutton will remain disabled
			List<string> movies = new List<string>();
			foreach (SelectPeopleItem movie in SelectPeoplePanel.Controls)
			{
				movies.Add(movie.comboBoxAdult.SelectedIndex.ToString());
				movies.Add(movie.comboBoxKids.SelectedIndex.ToString());
			}
			bool countBoxes = movies.Count > 0 && movies.All(a => a != "-1");
			if (countBoxes == true)
			{
				NextPageButton.Enabled = true;
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
