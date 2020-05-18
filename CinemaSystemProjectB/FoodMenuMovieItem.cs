using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
	public partial class FoodMenuMovieItem : UserControl
    {

		private bool isCollapsed = false;
        public FoodMenuMovieItem(MovieReservationAvailableMoviesItem chosenItem)
		{
            InitializeComponent();
		}

		private string _movietitle;
		private string _filmtechnology;
		private string _runtime;
		private string _Date;

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

		private void ChooseFoodButton_Click(object sender, System.EventArgs e)
		{
			if (isCollapsed)
			{
				ItemPanel.Size = ItemPanel.MinimumSize;
				this.Size = this.MinimumSize;
				isCollapsed = false;
			}
			else
			{
				this.Size = this.MaximumSize;
				ItemPanel.Size = ItemPanel.MaximumSize;
				isCollapsed = true;
			}
		}
	}
}
