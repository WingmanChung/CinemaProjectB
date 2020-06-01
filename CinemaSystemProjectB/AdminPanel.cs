using System;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            AddMovieFunc();
            RemoveMovieFunc();
        }

        public void AddMovieFunc()
        {
            AdminAddMovie[] AddMovie = new AdminAddMovie[1];

            AddMovie[0] = new AdminAddMovie();

            if (AdminFunctions.Controls.Count < 0)
            {
                AdminFunctions.Controls.Clear();
            }
            else
            {
                AdminFunctions.Controls.Add(AddMovie[0]);
            }
        }

        public void RemoveMovieFunc()
        {
            AdminRemoveMovie[] RemoveMovie = new AdminRemoveMovie[1];

            RemoveMovie[0] = new AdminRemoveMovie();

            if (AdminFunctions.Controls.Count < 0)
            {
                AdminFunctions.Controls.Clear();
            }
            else
            {
                AdminFunctions.Controls.Add(RemoveMovie[0]);
            }
        }
    }
}
