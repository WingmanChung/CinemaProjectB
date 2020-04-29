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
    public partial class ListItem : UserControl
    {
        public static string chosenMovieListView;
        public ListItem()
        {
            InitializeComponent();
        }


        //Properties

        private string _title;
        private string _release;
        private Image _cover;
        private string _director;
        private string _filmtechnology;
        private string _rating;
        private string _age;
        private string _genre;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; ListItemTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Release
        {
            get { return _release; }
            set { _release = value; Releasedate.Text = value; }
        }

        [Category("Custom Props")]
        public string Director
        {
            get { return _director; }
            set { _director = value; DirectorName.Text = value; }
        }

        [Category("Custom Props")]
        public string FilmTechnology
        {
            get { return _filmtechnology; }
            set { _filmtechnology = value; Filmtechnology.Text = value; }
        }

        [Category("Custom Props")]
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; rating.Text = value; }
        }

        [Category("Custom Props")]
        public string Age
        {
            get { return _age; }
            set { _age = value; age.Text = value; }
        }

        [Category("Custom Props")]
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; genre.Text = value; }
        }



        [Category("Custom Props")]
        public Image Cover
        {
            get { return _cover; }
            set { _cover = value; FilmCover.Image = value; }
        }

        private void FilmCover_MouseClick(object sender, MouseEventArgs e)
        {
            //Title is the json key. When clicked, the chosenMovie will be the title because it's already loaded in the usercontrol.
            chosenMovieListView = ListItemTitle.Text;
            new MovieDescription().Show();
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 0, 0);

            ListItemTitle.BackColor = Color.FromArgb(64, 0, 0);

            ListItemRelease.BackColor = Color.FromArgb(64, 0, 0);

            Releasedate.BackColor = Color.FromArgb(64, 0, 0);

            ListItemDirector.BackColor = Color.FromArgb(64, 0, 0);

            DirectorName.BackColor = Color.FromArgb(64, 0, 0);

            ListItemFilmtechnology.BackColor = Color.FromArgb(64, 0, 0);

            Filmtechnology.BackColor = Color.FromArgb(64, 0, 0);

            ListItemRating.BackColor = Color.FromArgb(64, 0, 0);

            rating.BackColor = Color.FromArgb(64, 0, 0);

            ListItemAge.BackColor = Color.FromArgb(64, 0, 0);

            age.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;

            ListItemTitle.BackColor = Color.Transparent;

            ListItemRelease.BackColor = Color.Transparent;

            Releasedate.BackColor = Color.Transparent;

            ListItemDirector.BackColor = Color.Transparent;

            DirectorName.BackColor = Color.Transparent;

            ListItemFilmtechnology.BackColor = Color.Transparent;

            Filmtechnology.BackColor = Color.Transparent;

            ListItemRating.BackColor = Color.Transparent;

            rating.BackColor = Color.Transparent;

            ListItemAge.BackColor = Color.Transparent;

            age.BackColor = Color.Transparent;
        }

    }
}
