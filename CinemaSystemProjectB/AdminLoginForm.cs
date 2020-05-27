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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string msgtxt = $"Username: {UserNameInput.Text}{Environment.NewLine}Wachtwoord: {PassWordInput.Text}";
            MessageBox.Show(msgtxt);
        }

        private void ShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassWord.Checked)
            {
                PassWordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PassWordInput.UseSystemPasswordChar = true;
            }
        }

        private void PassWordInput_TextChanged(object sender, EventArgs e)
        {
            if (ShowPassWord.Checked)
            {
                PassWordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PassWordInput.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.Gold;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.Yellow;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Gold;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Yellow;
        }
    }
}
