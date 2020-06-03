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
    public partial class AdminEditMovieItem : UserControl
    {
        public static string ChosenEdit = "";
        public AdminEditMovieItem(string title)
        {
            InitializeComponent();
            Title = title;
        }

        public Image Cover { get => MoviePoster.Image; internal set => MoviePoster.Image = value; }
        public string Title { get => titel.Text; internal set => titel.Text = value; }
        public string Release { get => release.Text; internal set => release.Text = value; }
        public string FilmTechnology { get => filmtechnologie.Text; internal set => filmtechnologie.Text = value; }
        public string Rating { get => rating.Text; internal set => rating.Text = value; }
        public string Genre { get => genre.Text; internal set => genre.Text = value; }
        public string Language { get => taal.Text; internal set => taal.Text = value; }

        private void AdminEditMovieItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
        }

        private void AdminEditMovieItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void AdminEditMovieItem_MouseClick(object sender, MouseEventArgs e)
        {
            ChosenEdit = titel.Text;
            new AdminEditMovieWindow().Show();
        }
    }
}
