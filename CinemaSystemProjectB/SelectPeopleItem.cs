using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class SelectPeopleItem : UserControl
    {
		public SelectPeopleItem(MovieReservationAvailableMoviesItem chosenItem)
        {
            InitializeComponent();
		}

		private string _movietitle;
		private string _filmtechnology;
		private string _runtime;
		private string _Date;
		private string _comboBoxAdult;
		private string _comboBoxKids;
		private string _comboBoxStudent;
		private string _screen;

		[Category("Custom Props")]
		public string MovieTitle
		{
			get { return _movietitle; }
			set { _movietitle = value; Filmtitle.Text = value; }
		}

		[Category("Custom Props")]
		public string FilmTechnology
		{
			get { return _filmtechnology; }
			set { _filmtechnology = value; Filmtechnology.Text = value; }
		}

		[Category("Custom Props")]
		public string Runtime
		{
			get { return _runtime; }
			set { _runtime = value; runtime.Text = value; }
		}

		[Category("Custom Props")]
		public string Date
		{
			get { return _Date; }
			set { _Date = value; date.Text = value; }
		}

		[Category("Custom Props")]
		public string ComboBoxAdult
		{
			get { return _comboBoxAdult; }
			set { _comboBoxAdult = value; comboBoxAdult.Text = ""; }
		}

		[Category("Custom Props")]
		public string ComboBoxKids
		{
			get { return _comboBoxKids; }
			set { _comboBoxKids = value; comboBoxKids.Text = ""; }
		}

		[Category("Custom Props")]
		public string ComboBoxStudent
		{
			get { return _comboBoxStudent; }
			set { _comboBoxStudent = value; comboBoxStudent.Text = ""; }
		}

		[Category("Custom Props")]
		private string _comboBoxSenior;

		public string ComboBoxSenior
		{
			get { return _comboBoxSenior; }
			set { _comboBoxSenior = value; comboBoxSenior.Text = ""; }
		}
		[Category("Custom Props")]
		public string Screen
		{
			get { return _screen; }
			set { _screen = value; ScreenLabel.Text = value; }
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
			AllFields();
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
			AllFields();
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
			AllFields();
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
			AllFields();
		}

		private void ChooseSeatsButton_Click(object sender, EventArgs e)
		{
			SeatReservation screen_number = new SeatReservation(this.ScreenLabel.Text);
			screen_number.ShowDialog(); 
		}
	}
}
