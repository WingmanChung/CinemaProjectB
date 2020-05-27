namespace CinemaSystemProjectB
{
    partial class AdminLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PassWordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Label();
            this.ShowPassWord = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 5);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 5);
            this.label1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(5, 476);
            this.label5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(482, 5);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(5, 476);
            this.label4.TabIndex = 6;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.UserNameLabel.Location = new System.Drawing.Point(81, 93);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(189, 23);
            this.UserNameLabel.TabIndex = 8;
            this.UserNameLabel.Text = "Gebruikersnaam";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Yellow;
            this.Exit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(423, 14);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(49, 26);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserNameInput
            // 
            this.UserNameInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameInput.Location = new System.Drawing.Point(84, 119);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(325, 25);
            this.UserNameInput.TabIndex = 11;
            this.UserNameInput.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(81, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wachtwoord";
            // 
            // PassWordInput
            // 
            this.PassWordInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordInput.Location = new System.Drawing.Point(84, 224);
            this.PassWordInput.MaxLength = 5324;
            this.PassWordInput.Name = "PassWordInput";
            this.PassWordInput.Size = new System.Drawing.Size(325, 25);
            this.PassWordInput.TabIndex = 13;
            this.PassWordInput.TextChanged += new System.EventHandler(this.PassWordInput_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Yellow;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(105, 338);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(287, 41);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Inloggen";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ShowPassWord
            // 
            this.ShowPassWord.AutoSize = true;
            this.ShowPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassWord.ForeColor = System.Drawing.Color.Yellow;
            this.ShowPassWord.Location = new System.Drawing.Point(349, 255);
            this.ShowPassWord.Name = "ShowPassWord";
            this.ShowPassWord.Size = new System.Drawing.Size(60, 20);
            this.ShowPassWord.TabIndex = 15;
            this.ShowPassWord.Text = "Show";
            this.ShowPassWord.UseVisualStyleBackColor = true;
            this.ShowPassWord.CheckedChanged += new System.EventHandler(this.ShowPassWord_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 2);
            this.label3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(487, 2);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(485, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 482);
            this.label8.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 482);
            this.label9.TabIndex = 22;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(487, 486);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowPassWord);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassWordInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PassWordInput;
        private System.Windows.Forms.Label LoginButton;
        private System.Windows.Forms.CheckBox ShowPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}