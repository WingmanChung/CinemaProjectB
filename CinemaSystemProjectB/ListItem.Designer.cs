namespace CinemaSystemProjectB
{
    partial class ListItem
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
            this.FilmCover = new System.Windows.Forms.PictureBox();
            this.ListItemTitle = new System.Windows.Forms.Label();
            this.ListItemRelease = new System.Windows.Forms.Label();
            this.ListItemDirector = new System.Windows.Forms.Label();
            this.ListItemFilmtechnology = new System.Windows.Forms.Label();
            this.ListItemRating = new System.Windows.Forms.Label();
            this.ListItemAge = new System.Windows.Forms.Label();
            this.Releasedate = new System.Windows.Forms.Label();
            this.DirectorName = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.Filmtechnology = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilmCover)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmCover
            // 
            this.FilmCover.Location = new System.Drawing.Point(28, 15);
            this.FilmCover.Name = "FilmCover";
            this.FilmCover.Size = new System.Drawing.Size(145, 213);
            this.FilmCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilmCover.TabIndex = 0;
            this.FilmCover.TabStop = false;
            this.FilmCover.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.FilmCover.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItemTitle
            // 
            this.ListItemTitle.AutoEllipsis = true;
            this.ListItemTitle.BackColor = System.Drawing.Color.Transparent;
            this.ListItemTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemTitle.ForeColor = System.Drawing.Color.Yellow;
            this.ListItemTitle.Location = new System.Drawing.Point(192, 15);
            this.ListItemTitle.Name = "ListItemTitle";
            this.ListItemTitle.Size = new System.Drawing.Size(527, 45);
            this.ListItemTitle.TabIndex = 1;
            this.ListItemTitle.Text = "Title";
            this.ListItemTitle.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.ListItemTitle.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItemRelease
            // 
            this.ListItemRelease.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemRelease.ForeColor = System.Drawing.Color.Yellow;
            this.ListItemRelease.Location = new System.Drawing.Point(193, 86);
            this.ListItemRelease.Name = "ListItemRelease";
            this.ListItemRelease.Size = new System.Drawing.Size(120, 23);
            this.ListItemRelease.TabIndex = 2;
            this.ListItemRelease.Text = "Release datum: ";
            this.ListItemRelease.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.ListItemRelease.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItemDirector
            // 
            this.ListItemDirector.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemDirector.ForeColor = System.Drawing.Color.Yellow;
            this.ListItemDirector.Location = new System.Drawing.Point(193, 109);
            this.ListItemDirector.Name = "ListItemDirector";
            this.ListItemDirector.Size = new System.Drawing.Size(86, 23);
            this.ListItemDirector.TabIndex = 3;
            this.ListItemDirector.Text = "Regisseur: ";
            this.ListItemDirector.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.ListItemDirector.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItemFilmtechnology
            // 
            this.ListItemFilmtechnology.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemFilmtechnology.ForeColor = System.Drawing.Color.Yellow;
            this.ListItemFilmtechnology.Location = new System.Drawing.Point(193, 132);
            this.ListItemFilmtechnology.Name = "ListItemFilmtechnology";
            this.ListItemFilmtechnology.Size = new System.Drawing.Size(103, 23);
            this.ListItemFilmtechnology.TabIndex = 4;
            this.ListItemFilmtechnology.Text = "Filmervaring: ";
            this.ListItemFilmtechnology.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.ListItemFilmtechnology.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItemRating
            // 
            this.ListItemRating.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemRating.ForeColor = System.Drawing.Color.Yellow;
            this.ListItemRating.Location = new System.Drawing.Point(193, 155);
            this.ListItemRating.Name = "ListItemRating";
            this.ListItemRating.Size = new System.Drawing.Size(59, 23);
            this.ListItemRating.TabIndex = 5;
            this.ListItemRating.Text = "Rating:";
            this.ListItemRating.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.ListItemRating.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItemAge
            // 
            this.ListItemAge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemAge.ForeColor = System.Drawing.Color.Yellow;
            this.ListItemAge.Location = new System.Drawing.Point(193, 178);
            this.ListItemAge.Name = "ListItemAge";
            this.ListItemAge.Size = new System.Drawing.Size(68, 23);
            this.ListItemAge.TabIndex = 6;
            this.ListItemAge.Text = "Leeftijd:";
            this.ListItemAge.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.ListItemAge.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // Releasedate
            // 
            this.Releasedate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Releasedate.ForeColor = System.Drawing.Color.Yellow;
            this.Releasedate.Location = new System.Drawing.Point(308, 86);
            this.Releasedate.Name = "Releasedate";
            this.Releasedate.Size = new System.Drawing.Size(120, 23);
            this.Releasedate.TabIndex = 7;
            this.Releasedate.Text = "Date";
            this.Releasedate.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.Releasedate.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // DirectorName
            // 
            this.DirectorName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectorName.ForeColor = System.Drawing.Color.Yellow;
            this.DirectorName.Location = new System.Drawing.Point(277, 109);
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.Size = new System.Drawing.Size(120, 23);
            this.DirectorName.TabIndex = 8;
            this.DirectorName.Text = "Name";
            this.DirectorName.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.DirectorName.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.Yellow;
            this.age.Location = new System.Drawing.Point(259, 178);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(120, 23);
            this.age.TabIndex = 9;
            this.age.Text = "Age";
            this.age.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.age.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // rating
            // 
            this.rating.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.Yellow;
            this.rating.Location = new System.Drawing.Point(250, 155);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(120, 23);
            this.rating.TabIndex = 10;
            this.rating.Text = "0/10";
            this.rating.UseMnemonic = false;
            this.rating.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.rating.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // Filmtechnology
            // 
            this.Filmtechnology.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmtechnology.ForeColor = System.Drawing.Color.Yellow;
            this.Filmtechnology.Location = new System.Drawing.Point(290, 132);
            this.Filmtechnology.Name = "Filmtechnology";
            this.Filmtechnology.Size = new System.Drawing.Size(120, 23);
            this.Filmtechnology.TabIndex = 11;
            this.Filmtechnology.Text = "Text";
            this.Filmtechnology.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.Filmtechnology.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Filmtechnology);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.age);
            this.Controls.Add(this.DirectorName);
            this.Controls.Add(this.Releasedate);
            this.Controls.Add(this.ListItemAge);
            this.Controls.Add(this.ListItemRating);
            this.Controls.Add(this.ListItemFilmtechnology);
            this.Controls.Add(this.ListItemDirector);
            this.Controls.Add(this.ListItemRelease);
            this.Controls.Add(this.ListItemTitle);
            this.Controls.Add(this.FilmCover);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(707, 247);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.FilmCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FilmCover;
        private System.Windows.Forms.Label ListItemTitle;
        private System.Windows.Forms.Label ListItemRelease;
        private System.Windows.Forms.Label ListItemDirector;
        private System.Windows.Forms.Label ListItemFilmtechnology;
        private System.Windows.Forms.Label ListItemRating;
        private System.Windows.Forms.Label ListItemAge;
        private System.Windows.Forms.Label Releasedate;
        private System.Windows.Forms.Label DirectorName;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label Filmtechnology;
    }
}
