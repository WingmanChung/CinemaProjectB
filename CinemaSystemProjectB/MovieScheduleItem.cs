using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class MovieScheduleItem : UserControl
    {
        public static string chosenMovieMovieSchedule;
        public static bool MovieScheduleChosenMovie = false;

        public MovieScheduleItem()
        {
            InitializeComponent();
        }

        //properties

        private string _movietitle;
        private string _filmtechnology;
        private string _runtime;

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

        private void Filmtitle_Click(object sender, EventArgs e)
        {
            //Title is the json key. When clicked, the chosenMovie will be the title because it's already loaded in the usercontrol.
            chosenMovieMovieSchedule = Filmtitle.Text;
            MovieScheduleChosenMovie = true;
            new MovieDescription().Show();
            MovieScheduleChosenMovie = false;
        }
    }
}
