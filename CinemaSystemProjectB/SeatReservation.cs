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
    public partial class SeatReservation : Form
    {
        public SeatReservation()
        {
            InitializeComponent();

        }

        public SeatReservation(String str)
        {
            InitializeComponent();
            this.label5.Text = str;

            if (this.label5.Text == "Screen 1")
            {
                pictureBox1.Image = Properties.Resources.Auditorium_1;
                Auditorium_1();
            }
            else if (this.label5.Text == "Screen 2")
            {
                pictureBox1.Image = Properties.Resources.Auditorium_2;
                Auditorium_2();

            }
            else
            {
                pictureBox1.Image = Properties.Resources.Auditorium_3;
                Auditorium_3();

            }


            dropdownNormalSeatAmount.SelectedIndex = 0;
            dropdownGoodSeatAmount.SelectedIndex = 0;
            dropdownBestSeatAmount.SelectedIndex = 0;
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

            for (int amount = 0; amount < 11; amount++)
            {
                dropdownNormalSeatAmount.Items.AddRange(new object[] { amount });

                dropdownGoodSeatAmount.Items.AddRange(new object[] { amount });
            }

            for (int amount = 0; amount < 9; amount++)
            {
                dropdownBestSeatAmount.Items.AddRange(new object[] { amount });
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

        private void button1_Click(object sender, EventArgs e)
        {
            int seatAmountGood = int.Parse(dropdownGoodSeatAmount.Text);
            int goodAmount = 1 * seatAmountGood;

            int seatAmountBest = int.Parse(dropdownBestSeatAmount.Text);
            int bestAmount = 2 * seatAmountBest;

            int totalAmountInt = goodAmount + bestAmount;
            string totalAmountString = totalAmountInt.ToString();

            label3.Text = "€" + totalAmountString;

        }
    }
}
