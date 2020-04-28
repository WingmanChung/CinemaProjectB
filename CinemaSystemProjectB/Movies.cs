using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            //populate here
            ListItem[] listItems = new ListItem[20];

            //loop through each item

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                //load image
                //listItems[i].Cover = ;
                listItems[i].Title = "Test";
                listItems[i].Release = "Test";
                listItems[i].Director = "Test";
                listItems[i].FilmTechnology = "Test";
                listItems[i].Rating = "Test";
                listItems[i].Age = "Test";

                //checks wheter listview is already filled or not (with preview searchresult)
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }
        }
    }
}
