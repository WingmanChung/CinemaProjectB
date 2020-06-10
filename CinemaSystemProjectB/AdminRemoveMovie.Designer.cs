namespace CinemaSystemProjectB
{
    partial class AdminRemoveMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OpenRemoveMoviePanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveMovieControl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AllMoviesList = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveMovieButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveMovieControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(970, 3);
            this.label1.TabIndex = 19;
            // 
            // OpenRemoveMoviePanel
            // 
            this.OpenRemoveMoviePanel.BackColor = System.Drawing.Color.DarkRed;
            this.OpenRemoveMoviePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenRemoveMoviePanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenRemoveMoviePanel.ForeColor = System.Drawing.Color.Black;
            this.OpenRemoveMoviePanel.Location = new System.Drawing.Point(0, 6);
            this.OpenRemoveMoviePanel.Name = "OpenRemoveMoviePanel";
            this.OpenRemoveMoviePanel.Size = new System.Drawing.Size(971, 39);
            this.OpenRemoveMoviePanel.TabIndex = 302;
            this.OpenRemoveMoviePanel.Text = "Film verwijderen\r\n\r\n";
            this.OpenRemoveMoviePanel.UseVisualStyleBackColor = false;
            this.OpenRemoveMoviePanel.Click += new System.EventHandler(this.OpenRemoveMoviePanel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(1, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(970, 3);
            this.label3.TabIndex = 303;
            // 
            // RemoveMovieControl
            // 
            this.RemoveMovieControl.Controls.Add(this.label4);
            this.RemoveMovieControl.Controls.Add(this.AllMoviesList);
            this.RemoveMovieControl.Controls.Add(this.RemoveMovieButton);
            this.RemoveMovieControl.Controls.Add(this.label2);
            this.RemoveMovieControl.Controls.Add(this.label1);
            this.RemoveMovieControl.Controls.Add(this.label3);
            this.RemoveMovieControl.Controls.Add(this.OpenRemoveMoviePanel);
            this.RemoveMovieControl.Location = new System.Drawing.Point(0, 3);
            this.RemoveMovieControl.MaximumSize = new System.Drawing.Size(970, 750);
            this.RemoveMovieControl.MinimumSize = new System.Drawing.Size(970, 54);
            this.RemoveMovieControl.Name = "RemoveMovieControl";
            this.RemoveMovieControl.Size = new System.Drawing.Size(970, 750);
            this.RemoveMovieControl.TabIndex = 304;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(930, 3);
            this.label4.TabIndex = 308;
            // 
            // AllMoviesList
            // 
            this.AllMoviesList.AutoScroll = true;
            this.AllMoviesList.Location = new System.Drawing.Point(53, 75);
            this.AllMoviesList.Name = "AllMoviesList";
            this.AllMoviesList.Size = new System.Drawing.Size(867, 610);
            this.AllMoviesList.TabIndex = 307;
            // 
            // RemoveMovieButton
            // 
            this.RemoveMovieButton.AutoSize = true;
            this.RemoveMovieButton.BackColor = System.Drawing.Color.Yellow;
            this.RemoveMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveMovieButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMovieButton.Location = new System.Drawing.Point(804, 704);
            this.RemoveMovieButton.Name = "RemoveMovieButton";
            this.RemoveMovieButton.Size = new System.Drawing.Size(146, 31);
            this.RemoveMovieButton.TabIndex = 306;
            this.RemoveMovieButton.Text = "Film verwijderen";
            this.RemoveMovieButton.UseVisualStyleBackColor = false;
            this.RemoveMovieButton.Click += new System.EventHandler(this.RemoveMovieButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(20, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 3);
            this.label2.TabIndex = 305;
            // 
            // AdminRemoveMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.RemoveMovieControl);
            this.MaximumSize = new System.Drawing.Size(970, 750);
            this.MinimumSize = new System.Drawing.Size(970, 54);
            this.Name = "AdminRemoveMovie";
            this.Size = new System.Drawing.Size(970, 750);
            this.RemoveMovieControl.ResumeLayout(false);
            this.RemoveMovieControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenRemoveMoviePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel RemoveMovieControl;
        private System.Windows.Forms.Button RemoveMovieButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel AllMoviesList;
        private System.Windows.Forms.Label label4;
    }
}
