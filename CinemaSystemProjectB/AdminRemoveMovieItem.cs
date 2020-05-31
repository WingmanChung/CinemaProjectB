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
    public partial class AdminRemoveMovieItem : UserControl
    {
        public AdminRemoveMovieItem()
        {
            InitializeComponent();
        }

        public Image Cover { get => MoviePoster.Image; internal set => MoviePoster.Image = value;}
        public string Title { get => titel.Text; internal set => titel.Text = value; }
        public string Release { get => release.Text; internal set => release.Text = value; }       
        public string FilmTechnology { get => filmtechnologie.Text; internal set => filmtechnologie.Text = value; }
        public string Rating { get => rating.Text; internal set => rating.Text = value; }        
        public string Genre { get => genre.Text; internal set => genre.Text = value; }
        public string Language { get => taal.Text; internal set => taal.Text = value; }

        public bool IsClicked { get; set; }

        private void OnMouseClick(object sender, EventArgs e)
        {
            IsClicked = !IsClicked;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if(!IsClicked)
                this.BackColor = Color.Black;
        }


    }
}
