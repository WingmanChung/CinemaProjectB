using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class SeatReservation : Form
    {
        int TotalCustomers = SelectPeopleItem.TotalAdultPlusKids;
        public Dictionary<string, Color> selectedSeats = new Dictionary<string, Color>();       //{key;value} / {"A1"; (0,255,0)}
        private int BestSeats;
        private int GoodSeats;
        private int NormalSeats;
        private int SeatRows;

        SelectPeopleItem SelectedMovie2 = SelectPeopleItem.SelectedMovie;
        
        public Dictionary<string, MovieDescriptionClass> AllMovieSeats { get; private set; }

        public SeatReservation()
        {
            InitializeComponent();
            SeatConfirmButton.Enabled = false;
        }

        private int[][] blocks = new int[][] { };
        private Label[][] arraySeat = new Label[][] { };

        public SeatReservation(String chosenMovie, string MovieScreen, int Row)
        {
            InitializeComponent();
            SeatRows = Row;
            Dictionary<string, int[][]> AllMovieSeats = JsonConvert.DeserializeObject<Dictionary<string, int[][]>>(File.ReadAllText(@"ReservedSeats.json"));
            foreach (var movie in AllMovieSeats)
            {
                if (movie.Key == chosenMovie)
                {
                    blocks = movie.Value;
                    break;
                }
            }

            if (MovieScreen == "Zaal 1")
            {
                //Screen 1 size
                SeatFlowPanel.Size = new Size(blocks[0].Length*32 + 28, blocks.Length*32+28);
                this.Size = new Size(1110, 786);

                gradientLabel1.Width = 1110;                                                                    //logo
                Wittelijn.Width = 1110;                                                                         //white line

                Sizes();
            }
            if (MovieScreen == "Zaal 2")
            {
                //Screen 2 size
                SeatFlowPanel.Size = new Size(blocks[0].Length * 32 + 28, blocks.Length*32+28);
                this.Size = new Size(1110, SeatFlowPanel.Height + 300);

                gradientLabel1.Width = 1110;                                                                    //logo
                Wittelijn.Width = 1110;                                                                         //white line

                Sizes();

                //EXTRA SIZES
                label2.Size = new Size(30, 779);                                                                //red line on the right size
                Linkerkolom.Size = new Size(30, 779);                                                           //red line on the left size
            }
            if (MovieScreen == "Zaal 3")
            {
                //Screen 3 size
                SeatFlowPanel.Size = new Size(blocks[0].Length * 32 + 31, blocks.Length * 32 + 31);
                this.Size = new Size(SeatFlowPanel.Width + 450, SeatFlowPanel.Height + 300);

                gradientLabel1.Width = SeatFlowPanel.Width + 450;                                               //logo
                Wittelijn.Width = SeatFlowPanel.Width + 450;                                                    //white line

                Sizes();

                //EXTRA SIZES
                label2.Size = new Size(30, 979);                                                                //red line on the right size
                Linkerkolom.Size = new Size(30, 979);                                                           //red line on the left size
            }


            int a = 65;
            Label[][] arraySeat = new Label[blocks.Length][];

            for (int i = 0; i < blocks.Length; i++)
            {
                arraySeat[i] = new Label[blocks[i].Length];
                int color = 1;
                for (int j = 0; j < blocks[i].Length; j++)
                {
                    int x = 13;
                    int y = 14;
                    int width = 31;
                    int height = 31;
                    Label mylabel = new Label
                    {
                        Text = BackColor != Color.Transparent ? (((char)(a + i)) + $"{color}").ToString() : ((char)(a)).ToString(),
                        Size = new Size(width, height),
                        Font = new Font("Arial", 9, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(x, y),
                        BackColor = blocks[i][j] == 1 ? Color.FromArgb(0, 162, 232) : blocks[i][j] == 2 ? Color.FromArgb(240, 228, 0) : blocks[i][j] == 3 ? Color.FromArgb(237, 28, 36) : blocks[i][j] == 4 || blocks[i][j] == 5 ? Color.Gray : Color.Transparent
                    };
                    mylabel.Click += new EventHandler(SeatClick);
                    mylabel.Margin = new Padding(1);
                    arraySeat[i][j] = mylabel;
                    SeatFlowPanel.Controls.Add(mylabel);
                    if (mylabel.BackColor != Color.Transparent)
                    {
                        color++;
                    }
                }
            }
        }

        public void Sizes()
        {
            label2.Location = new Point(this.Size.Width - 40, 121);                                         //red line on the right

            label1.Location = new Point(this.Size.Width - 357, 154);                                        //text aboven selectedSeatsPanel //753; 154
            label8.Location = new Point(this.Size.Width - 376, 177);                                        //red line above selectedSeatsPanel //734; 177
            selectedSeatsPanel.Location = new Point(this.Size.Width - 376, 201);                            //displays selected seat //734; 201
            label9.Location = new Point(this.Size.Width - 376, 597);                                        //red line under selectedSeatsPanel //734; 597

            PriceList.Location = new Point(gradientLabel1.Width - 376, this.Size.Height - 147);             //price list //734; 639
            AdditionalCosts.Location = new Point(gradientLabel1.Width - 267, this.Size.Height - 141);       //additional costs //843; 645
            SeatConfirmButton.Location = new Point(gradientLabel1.Width - 201, this.Size.Height - 99);      //confirm selected seats button //909; 687

            Screen.Location = new Point(82, this.Size.Height - 143);                                        //gray screen //82; 643
            Screen.Width = SeatFlowPanel.Width - 50;

            label11.Location = new Point(83, this.Size.Height - 99);                                        //blue color //83; 687
            label12.Location = new Point(102, this.Size.Height - 99);                                       //normal seats //102; 687

            label13.Location = new Point(83, this.Size.Height - 71);                                        //yellow color //83; 715
            label14.Location = new Point(102, this.Size.Height - 71);                                       //good seats //102; 715

            label15.Location = new Point(292, this.Size.Height - 99);                                       //red color //292; 687
            label16.Location = new Point(311, this.Size.Height - 99);                                       //best seats //311; 687

            label4.Location = new Point(292, this.Size.Height - 71);                                        //green //292; 715
            label5.Location = new Point(311, this.Size.Height - 71);                                        //selected seats //311; 715

            label6.Location = new Point(494, this.Size.Height - 99);                                        //gray color //494; 687
            label7.Location = new Point(513, this.Size.Height - 99);                                        //unavailable seats //513; 687
        }

        private void SeatConfirmButton_MouseEnter(object sender, EventArgs e)
        {
            SeatConfirmButton.BackColor = Color.Gold;
        }

        private void SeatConfirmButton_MouseLeave(object sender, EventArgs e)
        {
            SeatConfirmButton.BackColor = Color.Yellow;
        }

        int costs = 0;
        private void SeatReservation_MouseEnter(object sender, EventArgs e)
        {
            int tempNormal = 0;
            int tempGood = 0;
            int tempBest = 0;
            foreach (var seat in selectedSeats)
            {
                if (seat.Value == Color.FromArgb(237, 28, 36))
                {
                    tempBest++;
                }
                else if (seat.Value == Color.FromArgb(240, 228, 0))
                {
                    tempGood++;
                }
                else if (seat.Value == Color.FromArgb(0, 162, 232))
                {
                    tempNormal++;
                }
            }

            costs = (tempBest * 2) + (tempGood * 1) + (tempNormal * 0);
            AdditionalCosts.Text = "Extra kosten €" + costs + ",00";

            //Checks if seats are equal to total customers
            if (selectedSeats.Count == TotalCustomers - 1)
            {
                SeatConfirmButton.Visible = true;
                SeatConfirmButton.Enabled = true;
            }
            else
            {
                SeatConfirmButton.Visible = false;
                SeatConfirmButton.Enabled = false;
            }
        }

        private void PriceList_MouseEnter(object sender, EventArgs e)
        {
            PriceList.BackColor = Color.Gold;
        }

        private void PriceList_MouseLeave(object sender, EventArgs e)
        {
            PriceList.BackColor = Color.Yellow;
        }

        private void PriceList_MouseClick(object sender, MouseEventArgs e)
        {
            new PriceList().Show();
        }
        
        private void SeatConfirmButton_Click(object sender, EventArgs e)
        {
            foreach (var seat in selectedSeats)
            {
                if (seat.Value == Color.FromArgb(237, 28, 36))
                {
                    BestSeats++;
                }
                else if (seat.Value == Color.FromArgb(240, 228, 0))
                {
                    GoodSeats++;
                }
                else if (seat.Value == Color.FromArgb(0, 162, 232))
                {
                    NormalSeats++;
                }
            }

            SelectedMovie2.TotalNormalSeats.Text = NormalSeats.ToString();
            SelectedMovie2.TotalGoodSeats.Text = GoodSeats.ToString();
            SelectedMovie2.TotalBestSeats.Text = BestSeats.ToString();

            //Saves the state of selected seats when customer exists form
            SelectedMovie2.CustomerChosenSeats = new Dictionary<string, Color>(selectedSeats);

            Label[] allSeats = new Label[SeatFlowPanel.Controls.Count];

            int index = 0;
            foreach(Label seat in SeatFlowPanel.Controls)
            {
                allSeats[index] = seat;
                index++;
            }

            //Saves new seat array
            index = 0;
            for (int i = 0; i < SelectedMovie2.newBlocks.Length; i++)
            {
                SelectedMovie2.newBlocks[i] = new int[SeatRows];
                for (int j = 0; j < SeatRows; j++)
                {
                    if (allSeats[index].BackColor == Color.FromArgb(0, 162, 232))
                    {
                        SelectedMovie2.newBlocks[i][j] = 1;     //blue
                    }
                    else if (allSeats[index].BackColor == Color.FromArgb(240, 228, 0))
                    {
                        SelectedMovie2.newBlocks[i][j] = 2;     //yellow
                    }
                    else if (allSeats[index].BackColor == Color.FromArgb(237, 28, 36))
                    {
                        SelectedMovie2.newBlocks[i][j] = 3;     //red
                    }
                    else if (allSeats[index].BackColor == Color.FromArgb(0, 255, 0))
                    {
                        SelectedMovie2.newBlocks[i][j] = 4;     //green
                    }
                    else if (allSeats[index].BackColor == Color.Gray)
                    {
                        SelectedMovie2.newBlocks[i][j] = 5;     //gray
                    }
                    else
                    {
                        SelectedMovie2.newBlocks[i][j] = 0;     //transparent
                    }
                    index++;
                }
            }
            if(clickedHere == true)
            {
                movie.TotalPrice.Text = (Convert.ToDecimal(movie.TotalPrice.Text.Replace("€", "")) - Convert.ToDecimal(movie.TotalGoodSeatPrice.Text.Replace("€", "")) -
                                                                                    Convert.ToDecimal(movie.TotalBestSeatPrice.Text.Replace("€", ""))).ToString();
                movie.NormalSeat.Text = NormalSeats.ToString();
                movie.GoodSeat.Text = GoodSeats.ToString();
                movie.BestSeat.Text = BestSeats.ToString();

                string temp3 = ((GoodSeats * 1) < 10 ? "    " : (GoodSeats * 1) < 100 ? "  " : "") + (GoodSeats * 1).ToString();

                string temp4 = ((BestSeats * 2) < 10 ? "    " : (BestSeats * 2) < 100 ? "  " : "") + (BestSeats * 2).ToString();

                movie.TotalGoodSeatPrice.Text = "€" + temp3 + ",00";
                movie.TotalBestSeatPrice.Text = "€" + temp4 + ",00";

                movie.TotalPrice.Text = "€" + (Convert.ToDecimal(GoodSeats * 1) + Convert.ToDecimal(BestSeats * 2) + Convert.ToDecimal(movie.TotalPrice.Text.Replace("€", ""))).ToString();
                //ReservationPrice
                movie.Refresh();
            }

            this.Close();
        }

        bool clickedHere = CustomerReservation.clicked;
        CustomerReservation movie = CustomerReservation.CustomerMovie;

        private void SeatReservation_Load(object sender, EventArgs e)
        {
            //Reloads the last state of selected seats
            if(SelectedMovie2.CustomerChosenSeats.Count > 0)
            {
                selectedSeats = new Dictionary<string, Color>(SelectedMovie2.CustomerChosenSeats);

                //checks if the seat is in the panel. If yes, the seat becomes green
                foreach(var text in selectedSeats)
                {
                    foreach(Label seat in SeatFlowPanel.Controls)
                    {
                        if(text.Key == seat.Text)
                        {
                            seat.BackColor = Color.FromArgb(0, 255, 0); //green
                        }
                    }
                }
            }
        }

        protected void SeatClick(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            Label lbl = sender as Label;

            //Changes label color when clicked on a specific label
            if (selectedSeats.ContainsKey(lbl.Text))
            {
                lbl.BackColor = selectedSeats[lbl.Text];
                selectedSeats.Remove(lbl.Text);
            }
            else
            {
                if (lbl.BackColor != Color.Transparent && lbl.BackColor != Color.Gray)
                {
                    if (selectedSeats.Count < TotalCustomers - 1)
                    {
                        selectedSeats.Add(lbl.Text, lbl.BackColor);
                        lbl.BackColor = Color.FromArgb(0, 255, 0); //green
                    }
                }
            }
            SelectedSeatsLabel.Text = string.Join("\n", selectedSeats.Keys);
        }
    }
}
