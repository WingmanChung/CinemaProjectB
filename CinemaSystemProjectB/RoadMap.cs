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
    public partial class RoadMap : Form
    {
        public RoadMap()
        {
            InitializeComponent();

            RoadMapPanel();
        }

        public void RoadMapPanel()
        {
            RoadMapItem[] RoadMapItems = new RoadMapItem[1];

            for (int i = 0; i < RoadMapItems.Length; i++)
            {
                RoadMapItems[i] = new RoadMapItem();

                if (RoadMapLayOutPanel.Controls.Count < 0)
                {
                    RoadMapLayOutPanel.Controls.Clear();
                }
                else
                {
                    RoadMapLayOutPanel.Controls.Add(RoadMapItems[i]);
                }
            }


        }
    }
}
