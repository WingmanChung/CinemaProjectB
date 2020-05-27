using System;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class AdminRemoveMovie : UserControl
    {
        private bool isCollapsed = false;
        public AdminRemoveMovie()
        {
            InitializeComponent();
            FillAllMovieList();
        }

        public void FillAllMovieList()
        {
            AdminRemoveMovieItem[] AdminRemoveMovieItems = new AdminRemoveMovieItem[2]; //Array length = number of movies

            for(int i = 0; i < AdminRemoveMovieItems.Length; i++)
            {
                AdminRemoveMovieItems[i] = new AdminRemoveMovieItem();

                if (AllMoviesList.Controls.Count < 0)
                {
                    AllMoviesList.Controls.Clear();
                }
                else
                {
                    AllMoviesList.Controls.Add(AdminRemoveMovieItems[i]);
                }
            }
        }

        private void OpenRemoveMoviePanel_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                RemoveMovieControl.Size = RemoveMovieControl.MinimumSize;
                this.Size = this.MinimumSize;
                isCollapsed = false;
            }
            else
            {
                this.Size = this.MaximumSize;
                RemoveMovieControl.Size = RemoveMovieControl.MaximumSize;
                isCollapsed = true;
            }
        }

        private void RemoveMovieButton_Click(object sender, EventArgs e)
        {

        }
    }
}
