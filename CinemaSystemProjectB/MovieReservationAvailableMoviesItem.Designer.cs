namespace CinemaSystemProjectB
{
    partial class MovieReservationAvailableMoviesItem
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
            this.Filmtitle = new System.Windows.Forms.Label();
            this.Filmtechnology = new System.Windows.Forms.Label();
            this.runtime = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Filmtitle
            // 
            this.Filmtitle.AutoEllipsis = true;
            this.Filmtitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmtitle.ForeColor = System.Drawing.Color.Yellow;
            this.Filmtitle.Location = new System.Drawing.Point(3, 19);
            this.Filmtitle.Name = "Filmtitle";
            this.Filmtitle.Size = new System.Drawing.Size(419, 53);
            this.Filmtitle.TabIndex = 1;
            this.Filmtitle.Text = "FIlmtitel";
            this.Filmtitle.Click += new System.EventHandler(this.Filmtitle_Click);
            this.Filmtitle.MouseEnter += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseEnter);
            this.Filmtitle.MouseLeave += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseLeave);
            // 
            // Filmtechnology
            // 
            this.Filmtechnology.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmtechnology.ForeColor = System.Drawing.Color.Yellow;
            this.Filmtechnology.Location = new System.Drawing.Point(3, 90);
            this.Filmtechnology.Name = "Filmtechnology";
            this.Filmtechnology.Size = new System.Drawing.Size(137, 28);
            this.Filmtechnology.TabIndex = 2;
            this.Filmtechnology.Text = "2D/3D";
            this.Filmtechnology.Click += new System.EventHandler(this.Filmtitle_Click);
            this.Filmtechnology.MouseEnter += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseEnter);
            this.Filmtechnology.MouseLeave += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseLeave);
            // 
            // runtime
            // 
            this.runtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtime.ForeColor = System.Drawing.Color.Yellow;
            this.runtime.Location = new System.Drawing.Point(146, 90);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(125, 28);
            this.runtime.TabIndex = 3;
            this.runtime.Text = "Filmduur";
            this.runtime.Click += new System.EventHandler(this.Filmtitle_Click);
            this.runtime.MouseEnter += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseEnter);
            this.runtime.MouseLeave += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseLeave);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Yellow;
            this.date.Location = new System.Drawing.Point(297, 90);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(125, 28);
            this.date.TabIndex = 4;
            this.date.Text = "Datum";
            this.date.Click += new System.EventHandler(this.Filmtitle_Click);
            this.date.MouseEnter += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseEnter);
            this.date.MouseLeave += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(0, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 3);
            this.label2.TabIndex = 5;
            this.label2.Click += new System.EventHandler(this.Filmtitle_Click);
            // 
            // MovieReservationAvailableMoviesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.runtime);
            this.Controls.Add(this.Filmtechnology);
            this.Controls.Add(this.Filmtitle);
            this.Name = "MovieReservationAvailableMoviesItem";
            this.Size = new System.Drawing.Size(427, 132);
            this.MouseEnter += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MovieReservationAvailableMoviesItem_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Filmtitle;
        private System.Windows.Forms.Label Filmtechnology;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label2;
    }
}
