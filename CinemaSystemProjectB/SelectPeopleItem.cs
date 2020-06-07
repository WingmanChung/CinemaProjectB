using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class SelectPeopleItem : UserControl
    {
		public static int TotalAdultPlusKids;
		public static SelectPeopleItem SelectedMovie;
		public Dictionary<string, Color> CustomerChosenSeats = new Dictionary<string, Color>();
		public int[][] newBlocks;
		public SelectPeopleItem(MovieReservationAvailableMoviesItem chosenItem)
        {
            InitializeComponent();
		}

		private string _filmtechnology;

		public string MovieTitle
		{
			get { return Filmtitle.Text; }
			set { Filmtitle.Text = value; }
		}

		public string FilmTechnology
		{
			get { return _filmtechnology; }
			set { _filmtechnology = value; Filmtechnology.Text = value; }
		}

		public string Runtime
		{
			get { return runtime.Text; }
			set { runtime.Text = value; }
		}
		
		public string Date
		{
			get { return date.Text; }
			set { date.Text = value; }
		}

		public string ComboBoxAdult
		{
			get => comboBoxAdult.Text;
			set => comboBoxAdult.Text = value;
		}

		public string ComboBoxKids
		{
			get => comboBoxKids.Text;
			set => comboBoxKids.Text = value;
		}

		public string ComboBoxStudent
		{
			get => comboBoxStudent.Text;
			set => comboBoxStudent.Text = value;
		}

		public string ComboBoxSenior
		{
			get => comboBoxSenior.Text;
			set => comboBoxSenior.Text = value;
		}

		public string Screen
		{
			get => ScreenLabel.Text;
			set => ScreenLabel.Text = value;
		}

		public void CheckIfZero()
		{
			//checks if the selected items in step 1 are 0 or not. If yes -> show message and reset selected items
			if (comboBoxAdult.SelectedIndex == 0 && comboBoxKids.SelectedIndex == 0)
			{
				MessageBox.Show("Er kunnen niet bij beide vakjes het getal 0 worden ingevuld");
				comboBoxAdult.Items.Clear();
				comboBoxKids.Items.Clear();
				comboBoxSenior.Items.Clear();
				comboBoxStudent.Items.Clear();
			}
		}

		public void Step1Completed()
		{
			//shows message if user clicks on either the senior or student combobox before selecting numbers in step 1
			if ((comboBoxAdult.Items.Count == 0 && comboBoxAdult.SelectedIndex < 0) || (comboBoxKids.Items.Count == 0 && comboBoxKids.SelectedIndex < 0))
			{
				MessageBox.Show("Kies eerst de aantal volwassenen en kinderen bij stap 1");
			}
		}

		public void AllFields()
		{
			(this.ParentForm as MovieReservation).checkAllBoxes();
		}

		private void comboBoxAdult_MouseClick(object sender, MouseEventArgs e)
		{
			//if adult combobox is empty, fill it
			if (comboBoxAdult.Items.Count == 0)
			{
				for (int i = 0; i < 11; i++)
				{
					comboBoxAdult.Items.Add(i);
				}
			}
			else
			{
				//if the selected item in adult combobox is changed, then it will reset all the comboboxes in step 2
				if ((comboBoxAdult.SelectedIndex + comboBoxKids.SelectedIndex).ToString() != comboBoxAdult.Text)
				{
					comboBoxSenior.ResetText();
					comboBoxStudent.ResetText();
				}
			}
			ComboBoxAdult = comboBoxAdult.SelectedIndex.ToString();
		}

		private void comboBoxKids_MouseClick(object sender, MouseEventArgs e)
		{
			//if kids combobox is empty, fill it
			if (comboBoxKids.Items.Count == 0)
			{
				for (int i = 0; i < 11; i++)
				{
					comboBoxKids.Items.Add(i);
				}
			}
			ComboBoxKids = comboBoxKids.SelectedIndex.ToString();
		}

		private void comboBoxStudent_MouseClick(object sender, MouseEventArgs e)
		{
			Step1Completed();
			//if the total items in student combobox is different than the total items in adult combobox then it clears the student combobox and fills it with the total items of adult combobox
			if (comboBoxStudent.Items.Count != comboBoxAdult.Items.Count)
			{
				comboBoxStudent.Items.Clear();
				//if there isn't a selected item (yet) then it fills the student combobox with numbers (total of the adult combobox)
				if(comboBoxSenior.SelectedItem == null)
				{
					for (int i = 0; i < comboBoxAdult.SelectedIndex + 1; i++)
					{
						comboBoxStudent.Items.Add(i);
					}
				}
				//if senior combobox contains a selected item then it calculates here how many numbers there are left to choose from (e.g. 5-3 = 2 left)
				else
				{
					for (int i = 0; i < ((comboBoxAdult.SelectedIndex + 1) - comboBoxSenior.SelectedIndex); i++)
					{
						comboBoxStudent.Items.Add(i);
					}
				}
			}
			ComboBoxStudent = comboBoxStudent.SelectedIndex.ToString();
			CheckIfZero();
		}

		private void comboBoxSenior_MouseClick(object sender, MouseEventArgs e)
		{
			Step1Completed();
			//if the total items in total combobox is different than the total items in adult combobox then it clears the adult combobox and fills it with the total items of total combobox
			if (comboBoxSenior.Items.Count != comboBoxAdult.Items.Count)
			{
				comboBoxSenior.Items.Clear();
				//if there isn't a selected item (yet) then it fills the senior combobox with numbers (total of the adult combobox)
				if (comboBoxStudent.SelectedItem == null)
				{
					for (int i = 0; i < comboBoxAdult.SelectedIndex + 1; i++)
					{
						comboBoxSenior.Items.Add(i);
					}
				}
				//if student combobox contains a selected item then it calculates here how many numbers there are left to choose from (e.g. 5-3 = 2 left)
				else
				{
					for (int i = 0; i < ((comboBoxAdult.SelectedIndex + 1) - comboBoxStudent.SelectedIndex); i++)
					{
						comboBoxSenior.Items.Add(i);
					}
				}
			}
			ComboBoxSenior = comboBoxSenior.SelectedIndex.ToString();
			CheckIfZero();
		}

		public class MovieSeatReservation
		{
			public string Movie { get; set; }
			public int[][] Seats { get; set; }
		}

		private void ChooseSeatsButton_Click(object sender, EventArgs e)
		{
			Step1Completed();
			if (comboBoxAdult.SelectedIndex > 0 && comboBoxKids.SelectedIndex >= 0 || comboBoxAdult.SelectedIndex >= 0 && comboBoxKids.SelectedIndex > 0)
			{
				SelectedMovie = this;

				MovieSeatReservation movieSeats = new MovieSeatReservation
				{
					Movie = Filmtitle.Text + Filmtechnology.Text + date.Text + ScreenLabel.Text,
					Seats = ScreenLabel.Text == "Zaal 1" ? Screen1Seats() : ScreenLabel.Text == "Zaal 2" ? Screen2Seats() : Screen3Seats()
				};
				newBlocks = new int[movieSeats.Seats.Length][];

				//Creates json file if it doesn't exist yet
				if (!File.Exists("ReservedSeats.json"))
				{
					using (StreamWriter datePath = File.CreateText("ReservedSeats.json"))
					{
						datePath.Close();
					}
				}

				Dictionary<string, int[][]> AllMovieSeats = JsonConvert.DeserializeObject<Dictionary<string, int[][]>>(File.ReadAllText(@"ReservedSeats.json"));

				//checks if AllMovieSeats dictionary is null (this will avoid NullException error
				if(AllMovieSeats == null)
				{
					File.WriteAllText(@"ReservedSeats.json", new JObject() { { movieSeats.Movie, JArray.FromObject(movieSeats.Seats) } }.ToString());
				}
				//if it's not null, then add dictionary to json file
				else if (!(AllMovieSeats.ContainsKey(movieSeats.Movie)))
				{
					AllMovieSeats.Add(movieSeats.Movie, movieSeats.Seats);
					string json = JsonConvert.SerializeObject(AllMovieSeats, Formatting.Indented);

					File.WriteAllText(@"ReservedSeats.json", json);
				}

				SeatReservation screen_number = new SeatReservation(movieSeats.Movie, ScreenLabel.Text, movieSeats.Seats[0].Length);
				screen_number.ShowDialog();
			}
		}

		private void SelectPeopleItem_MouseEnter(object sender, EventArgs e)
		{
			TotalAdultPlusKids = comboBoxAdult.SelectedIndex + comboBoxKids.SelectedIndex + 1;
			AllFields();
		}

		public int[][] Screen1Seats()
		{
			//ZAAL1
			int[][] blocks = new int[14][]{
		 new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //1
		 new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, //2
		 new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, //3
		 new int[] {1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1 }, //4
		 new int[] {1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1 }, //5
		 new int[] {1, 1, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1 }, //6
		 new int[] {1, 1, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1 }, //7
		 new int[] {1, 1, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1 }, //8
		 new int[] {1, 1, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1 }, //9
		 new int[] {1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1 }, //10
		 new int[] {1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1 }, //11
		 new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, //12
		 new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //13
		 new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 } //14
		 };
			return blocks;
		}

		public int[][] Screen2Seats()
		{
			//ZAAL2
			int[][] blocks = new int[19][]
			{
			new int[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, //1
			new int[] {0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 0 }, //2
			new int[] {0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0 }, //3
			new int[] {0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0 }, //4
			new int[] {0, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0 }, //5
			new int[] {0, 1, 1, 1, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 1, 1, 1, 0 }, //6
			new int[] {1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1 }, //7
			new int[] {1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1 }, //8
			new int[] {1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1 }, //9
			new int[] {1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1 },//10
			new int[] {1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1 }, //11
			new int[] {0, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 0 }, //12
			new int[] {0, 1, 1, 1, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 1, 1, 1, 0 }, //13
			new int[] {0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0 }, //14
			new int[] {0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0 }, //15
			new int[] {0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0 }, //16
			new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //17
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, //18
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 } //19
			};
			return blocks;
		}

		public int[][] Screen3Seats()
		{
			//ZAAL3
			int[][] blocks = new int[20][]
			{
			new int[] {0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, //1
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, //2
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0 }, //3
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0 }, //4
			new int[] {0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0 }, //5
			new int[] {0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0 }, //6
			new int[] {0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 0 }, //7
			new int[] {1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1 }, //8
			new int[] {1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1 }, //9
			new int[] {1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1 }, //10
			new int[] {1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1 }, //11
			new int[] {1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1 }, //12
			new int[] {0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 0 }, //13
			new int[] {0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0 }, //14
			new int[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //15
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, //16
			new int[] {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }, //17
			new int[] {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, //18
			new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, //19
			new int[] {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 } //19
			};
			return blocks;
		}
	}
}
