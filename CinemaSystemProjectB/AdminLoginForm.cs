using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    public partial class AdminLoginForm : Form
    {

        const string path = @"Password.json";

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

            Dictionary<string, AdminCredentials> ListView = JsonConvert.DeserializeObject<Dictionary<string, AdminCredentials>>(File.ReadAllText(path));

            if (UserNameInput.Text == ListView["admin_login"].Username && PassWordInput.Text == ListView["admin_login"].Password)
            {
                string msgtxt = $"Username: {UserNameInput.Text}{Environment.NewLine}Wachtwoord: {PassWordInput.Text}";
                MessageBox.Show(msgtxt);
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            new AdminPanel().Show();
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
