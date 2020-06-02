using System;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class SelectPeopleItem : UserControl
    {
		public static int TotalAdultPlusKids;
		public static SelectPeopleItem SelectedMovie;
		public SelectPeopleItem(MovieReservationAvailableMoviesItem chosenItem)
        {
            InitializeComponent();
		}

		private string _filmtechnology;
		private string _runtime;
		private string _Date;
		private string _comboBoxAdult;
		private string _comboBoxKids;
		private string _comboBoxStudent;
		private string _screen;

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
			get => _comboBoxKids;
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
				for (int i = 0; i < 10; i++)
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
				for (int i = 0; i < 10; i++)
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

		private void ChooseSeatsButton_Click(object sender, EventArgs e)
		{
			Step1Completed();
			if (comboBoxAdult.SelectedIndex > 0 && comboBoxKids.SelectedIndex >= 0 || comboBoxAdult.SelectedIndex >= 0 && comboBoxKids.SelectedIndex > 0)
			{
				SelectedMovie = this;
				SeatReservation screen_number = new SeatReservation(this.ScreenLabel.Text);
				screen_number.ShowDialog();
			}
		}

		private void SelectPeopleItem_MouseEnter(object sender, EventArgs e)
		{
			TotalAdultPlusKids = comboBoxAdult.SelectedIndex + comboBoxKids.SelectedIndex + 1;
			AllFields();
		}
	}
}
