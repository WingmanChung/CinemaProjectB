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
    public partial class MovieOverview : Form
    {
        public MovieOverview()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form godzilla = new Godzilla();
            godzilla.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form madeInAbyss = new MadeInAbyss();
            madeInAbyss.ShowDialog();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form avengers = new Avengers();
            avengers.ShowDialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frozen2 = new Frozen2();
            frozen2.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form johnWick2 = new JohnWick2();
            johnWick2.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form johnWick3 = new JohnWick3();
            johnWick3.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form after = new After();
            after.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form stormwind = new Stormwind();
            stormwind.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form istillseeyou = new IStillSeeYou();
            istillseeyou.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form httyd3 = new Httyd3();
            httyd3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 10; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            MessageBox.Show(randomString);
        }

    }
}
