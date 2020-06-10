namespace CinemaSystemProjectB
{
    partial class AdminEditMovie
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
            this.EditMovieControl = new System.Windows.Forms.Panel();
            this.AllMoviesList = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenRemoveMoviePanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditMovieControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditMovieControl
            // 
            this.EditMovieControl.Controls.Add(this.AllMoviesList);
            this.EditMovieControl.Controls.Add(this.label2);
            this.EditMovieControl.Controls.Add(this.label4);
            this.EditMovieControl.Controls.Add(this.label3);
            this.EditMovieControl.Controls.Add(this.OpenRemoveMoviePanel);
            this.EditMovieControl.Controls.Add(this.label1);
            this.EditMovieControl.Location = new System.Drawing.Point(0, 0);
            this.EditMovieControl.MaximumSize = new System.Drawing.Size(970, 750);
            this.EditMovieControl.MinimumSize = new System.Drawing.Size(970, 54);
            this.EditMovieControl.Name = "EditMovieControl";
            this.EditMovieControl.Size = new System.Drawing.Size(970, 750);
            this.EditMovieControl.TabIndex = 0;
            // 
            // AllMoviesList
            // 
            this.AllMoviesList.AutoScroll = true;
            this.AllMoviesList.Location = new System.Drawing.Point(52, 75);
            this.AllMoviesList.Name = "AllMoviesList";
            this.AllMoviesList.Size = new System.Drawing.Size(868, 610);
            this.AllMoviesList.TabIndex = 311;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(20, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 3);
            this.label2.TabIndex = 310;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(930, 3);
            this.label4.TabIndex = 309;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(1, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(970, 3);
            this.label3.TabIndex = 304;
            // 
            // OpenRemoveMoviePanel
            // 
            this.OpenRemoveMoviePanel.BackColor = System.Drawing.Color.DarkRed;
            this.OpenRemoveMoviePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenRemoveMoviePanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenRemoveMoviePanel.ForeColor = System.Drawing.Color.Black;
            this.OpenRemoveMoviePanel.Location = new System.Drawing.Point(0, 7);
            this.OpenRemoveMoviePanel.Name = "OpenRemoveMoviePanel";
            this.OpenRemoveMoviePanel.Size = new System.Drawing.Size(971, 39);
            this.OpenRemoveMoviePanel.TabIndex = 303;
            this.OpenRemoveMoviePanel.Text = "Film wijzigen\r\n";
            this.OpenRemoveMoviePanel.UseVisualStyleBackColor = false;
            this.OpenRemoveMoviePanel.Click += new System.EventHandler(this.OpenRemoveMoviePanel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(970, 3);
            this.label1.TabIndex = 20;
            // 
            // AdminEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.EditMovieControl);
            this.MaximumSize = new System.Drawing.Size(970, 750);
            this.MinimumSize = new System.Drawing.Size(970, 54);
            this.Name = "AdminEditMovie";
            this.Size = new System.Drawing.Size(970, 750);
            this.EditMovieControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditMovieControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenRemoveMoviePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel AllMoviesList;
    }
}
