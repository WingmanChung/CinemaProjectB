using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class SeatReservation : Form
    {
        int TotalCustomers = SelectPeopleItem.TotalAdultPlusKids;
        SelectPeopleItem SelectedMovie2 = SelectPeopleItem.SelectedMovie;
        public SeatReservation()
        {
            InitializeComponent();
            SeatConfirmButton.Enabled = false;
        }

        public SeatReservation(String str)
        {
            InitializeComponent();
            this.WhichScreenLabel.Text = str;

            if (this.WhichScreenLabel.Text == "Zaal 1")
            {
                pictureBox1.Image = Properties.Resources.Auditorium_1;
                Auditorium_1();
            }
            else if (this.WhichScreenLabel.Text == "Zaal 2")
            {
                pictureBox1.Image = Properties.Resources.Auditorium_2;
                Auditorium_2();

            }
            else
            {
                pictureBox1.Image = Properties.Resources.Auditorium_3;
                Auditorium_3();

            }
        }

        public void Auditorium()
        {
            Auditorium_1();
            Auditorium_2();
            Auditorium_3();
        }

        public void Auditorium_1()
        {
            for (int Nrow = 1; Nrow < 13; Nrow++)
            {
                dropdownNormalSeatRow.Items.AddRange(new object[] { Nrow });
            }

            for(int Grow = 4; Grow < 12; Grow++)
            {
                dropdownGoodSeatRow.Items.AddRange(new object[] { Grow });
            }

            for (int Brow = 6; Brow < 10; Brow++)
            {
                dropdownBestSeatRow.Items.AddRange(new object[] { Brow });
            }
        }

        public void Auditorium_2()
        {
            for (int Nrow = 1; Nrow < 20; Nrow++)
            {
                dropdownNormalSeatRow.Items.AddRange(new object[] { Nrow });
            }

            for (int Grow = 4; Grow < 18; Grow++)
            {
                dropdownGoodSeatRow.Items.AddRange(new object[] { Grow });
            }

            for (int Brow = 7; Brow < 14; Brow++)
            {
                dropdownBestSeatRow.Items.AddRange(new object[] { Brow });
            }

            for (int amount = 0; amount < 11; amount++)
            {
                dropdownNormalSeatAmount.Items.AddRange(new object[] { amount });

                dropdownGoodSeatAmount.Items.AddRange(new object[] { amount });

                dropdownBestSeatAmount.Items.AddRange(new object[] { amount });
            }
        }

        public void Auditorium_3()
        {
            for (int Nrow = 1; Nrow < 31; Nrow++)
            {
                dropdownNormalSeatRow.Items.AddRange(new object[] { Nrow });
            }

            for (int Grow = 4; Grow < 19; Grow++)
            {
                dropdownGoodSeatRow.Items.AddRange(new object[] { Grow });
            }

            for (int Brow = 8; Brow < 16; Brow++)
            {
                dropdownBestSeatRow.Items.AddRange(new object[] { Brow });
            }

            for (int amount = 0; amount < 11; amount++)
            {
                dropdownNormalSeatAmount.Items.AddRange(new object[] { amount });

                dropdownGoodSeatAmount.Items.AddRange(new object[] { amount });

                dropdownBestSeatAmount.Items.AddRange(new object[] { amount });

            }
        }

        private void SeatConfirmButton_MouseEnter(object sender, EventArgs e)
        {
            SeatConfirmButton.BackColor = Color.Gold;
        }

        private void SeatConfirmButton_MouseLeave(object sender, EventArgs e)
        {
            SeatConfirmButton.BackColor = Color.Yellow;
        }

        private void SeatReservation_MouseEnter(object sender, EventArgs e)
        {   

            if (dropdownGoodSeatAmount.SelectedIndex > -1 & dropdownBestSeatAmount.SelectedIndex > -1
                & dropdownBestSeatRow.SelectedIndex > -1 & dropdownGoodSeatRow.SelectedIndex > -1 & dropdownNormalSeatRow.SelectedIndex > -1)
            {
                //total price of good seats
                int seatAmountGood = int.Parse(dropdownGoodSeatAmount.Text);
                int goodAmount = 1 * seatAmountGood;

                //total price of best seats
                int seatAmountBest = int.Parse(dropdownBestSeatAmount.Text);
                int bestAmount = 2 * seatAmountBest;

                //total price of all seats
                int totalAmountInt = goodAmount + bestAmount;
                string totalAmountString = totalAmountInt.ToString();

                TotalSeatPrice.Text = "€" + totalAmountString;

                SeatConfirmButton.Visible = true;
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

        private void dropdownNormalSeatAmount_MouseClick(object sender, MouseEventArgs e)
        {
            if (dropdownNormalSeatAmount.Items.Count == 0 && dropdownGoodSeatAmount.Items.Count == 0 && dropdownBestSeatAmount.Items.Count == 0)
            {
                for (int i = 0; i < TotalCustomers; i++)
                {
                    dropdownNormalSeatAmount.Items.Add(i);
                }
            }
            else
            {
                dropdownNormalSeatAmount.Items.Clear();
                for (int i = 0; i < TotalCustomers - (dropdownGoodSeatAmount.SelectedIndex == -1 ? 0 : dropdownGoodSeatAmount.SelectedIndex) - (dropdownBestSeatAmount.SelectedIndex == -1 ? 0 : dropdownBestSeatAmount.SelectedIndex); i++)
                {
                    dropdownNormalSeatAmount.Items.Add(i);
                }
            }
        }

        private void dropdownGoodSeatAmount_MouseClick(object sender, MouseEventArgs e)
        {
            if (dropdownNormalSeatAmount.Items.Count == 0 && dropdownGoodSeatAmount.Items.Count == 0 && dropdownBestSeatAmount.Items.Count == 0)
            {
                for (int i = 0; i < TotalCustomers; i++)
                {
                    dropdownGoodSeatAmount.Items.Add(i);
                }
            }
            else
            {
                dropdownGoodSeatAmount.Items.Clear();
                for (int i = 0; i < TotalCustomers - (dropdownNormalSeatAmount.SelectedIndex == -1 ? 0 : dropdownNormalSeatAmount.SelectedIndex) - (dropdownBestSeatAmount.SelectedIndex == -1 ? 0 : dropdownBestSeatAmount.SelectedIndex); i++)
                {
                    dropdownGoodSeatAmount.Items.Add(i);
                }
            }
        }

        private void dropdownBestSeatAmount_MouseClick(object sender, MouseEventArgs e)
        {
            if (dropdownNormalSeatAmount.Items.Count == 0 && dropdownGoodSeatAmount.Items.Count == 0 && dropdownBestSeatAmount.Items.Count == 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    dropdownBestSeatAmount.Items.Add(i);
                }
            }
            else
            {
                dropdownBestSeatAmount.Items.Clear();
                int total = TotalCustomers - (dropdownGoodSeatAmount.SelectedIndex == -1 ? 0 : dropdownGoodSeatAmount.SelectedIndex) - (dropdownNormalSeatAmount.SelectedIndex == -1 ? 0 : dropdownNormalSeatAmount.SelectedIndex);
                if(total > 9)
                {
                    total = 9;
                }
                for (int i = 0; i < total; i++)
                {
                    dropdownBestSeatAmount.Items.Add(i);
                }
            }
        }

        private void SeatConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedMovie2.TotalNormalSeats.Text = dropdownNormalSeatAmount.SelectedIndex.ToString();
            SelectedMovie2.TotalGoodSeats.Text = dropdownGoodSeatAmount.SelectedIndex.ToString();
            SelectedMovie2.TotalBestSeats.Text = dropdownBestSeatAmount.SelectedIndex.ToString();

            this.Close();
        }
    }
}
