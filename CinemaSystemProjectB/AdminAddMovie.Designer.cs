namespace CinemaSystemProjectB
{
    partial class AdminAddMovie
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
            this.OpenAddMoviePanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxRelease = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxRuntime = new System.Windows.Forms.TextBox();
            this.textBoxFilmtechnology = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTrailer = new System.Windows.Forms.TextBox();
            this.textBoxSynopsis = new System.Windows.Forms.TextBox();
            this.AddMoviePoster = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddMovieImageButton = new System.Windows.Forms.Button();
            this.AddMovieControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AddMoviePoster)).BeginInit();
            this.AddMovieControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(970, 3);
            this.label1.TabIndex = 18;
            // 
            // OpenAddMoviePanel
            // 
            this.OpenAddMoviePanel.BackColor = System.Drawing.Color.DarkRed;
            this.OpenAddMoviePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenAddMoviePanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenAddMoviePanel.ForeColor = System.Drawing.Color.Black;
            this.OpenAddMoviePanel.Location = new System.Drawing.Point(-1, 6);
            this.OpenAddMoviePanel.Name = "OpenAddMoviePanel";
            this.OpenAddMoviePanel.Size = new System.Drawing.Size(971, 39);
            this.OpenAddMoviePanel.TabIndex = 301;
            this.OpenAddMoviePanel.Text = "Film toevoegen\r\n";
            this.OpenAddMoviePanel.UseVisualStyleBackColor = false;
            this.OpenAddMoviePanel.Click += new System.EventHandler(this.OpenAddMoviePanel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(970, 3);
            this.label3.TabIndex = 302;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(20, 820);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 3);
            this.label2.TabIndex = 303;
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.AutoSize = true;
            this.AddMovieButton.BackColor = System.Drawing.Color.Yellow;
            this.AddMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieButton.Location = new System.Drawing.Point(812, 838);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(138, 31);
            this.AddMovieButton.TabIndex = 304;
            this.AddMovieButton.Text = "Film toevoegen";
            this.AddMovieButton.UseVisualStyleBackColor = false;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            this.AddMovieButton.MouseEnter += new System.EventHandler(this.AddMovieButton_MouseEnter);
            this.AddMovieButton.MouseLeave += new System.EventHandler(this.AddMovieButton_MouseLeave);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Black;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitle.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxTitle.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxTitle.Location = new System.Drawing.Point(341, 121);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(526, 27);
            this.textBoxTitle.TabIndex = 318;
            this.textBoxTitle.Text = "Titel";
            this.textBoxTitle.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // textBoxRelease
            // 
            this.textBoxRelease.BackColor = System.Drawing.Color.Black;
            this.textBoxRelease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRelease.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxRelease.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRelease.Location = new System.Drawing.Point(341, 156);
            this.textBoxRelease.Name = "textBoxRelease";
            this.textBoxRelease.Size = new System.Drawing.Size(526, 27);
            this.textBoxRelease.TabIndex = 319;
            this.textBoxRelease.Text = "Releasedatum";
            this.textBoxRelease.Enter += new System.EventHandler(this.textBoxRelease_Enter);
            this.textBoxRelease.Leave += new System.EventHandler(this.textBoxRelease_Leave);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.BackColor = System.Drawing.Color.Black;
            this.textBoxDirector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirector.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxDirector.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDirector.Location = new System.Drawing.Point(341, 191);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(526, 27);
            this.textBoxDirector.TabIndex = 320;
            this.textBoxDirector.Text = "Regisseur(s)";
            this.textBoxDirector.Enter += new System.EventHandler(this.textBoxDirector_Enter);
            this.textBoxDirector.Leave += new System.EventHandler(this.textBoxDirector_Leave);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.Black;
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGenre.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxGenre.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxGenre.Location = new System.Drawing.Point(341, 226);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(526, 27);
            this.textBoxGenre.TabIndex = 321;
            this.textBoxGenre.Text = "Genre";
            this.textBoxGenre.Enter += new System.EventHandler(this.textBoxGenre_Enter);
            this.textBoxGenre.Leave += new System.EventHandler(this.textBoxGenre_Leave);
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.BackColor = System.Drawing.Color.Black;
            this.textBoxLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLanguage.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxLanguage.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxLanguage.Location = new System.Drawing.Point(341, 261);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(526, 27);
            this.textBoxLanguage.TabIndex = 322;
            this.textBoxLanguage.Text = "Taal";
            this.textBoxLanguage.Enter += new System.EventHandler(this.textBoxLanguage_Enter);
            this.textBoxLanguage.Leave += new System.EventHandler(this.textBoxLanguage_Leave);
            // 
            // textBoxRating
            // 
            this.textBoxRating.BackColor = System.Drawing.Color.Black;
            this.textBoxRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRating.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxRating.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRating.Location = new System.Drawing.Point(341, 296);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(526, 27);
            this.textBoxRating.TabIndex = 323;
            this.textBoxRating.Text = "Rating";
            this.textBoxRating.Enter += new System.EventHandler(this.textBoxRating_Enter);
            this.textBoxRating.Leave += new System.EventHandler(this.textBoxRating_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.Black;
            this.textBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAge.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxAge.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxAge.Location = new System.Drawing.Point(341, 331);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(526, 27);
            this.textBoxAge.TabIndex = 324;
            this.textBoxAge.Text = "Leeftijd";
            this.textBoxAge.Enter += new System.EventHandler(this.textBoxAge_Enter);
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // textBoxRuntime
            // 
            this.textBoxRuntime.BackColor = System.Drawing.Color.Black;
            this.textBoxRuntime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRuntime.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxRuntime.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxRuntime.Location = new System.Drawing.Point(341, 366);
            this.textBoxRuntime.Name = "textBoxRuntime";
            this.textBoxRuntime.Size = new System.Drawing.Size(526, 27);
            this.textBoxRuntime.TabIndex = 325;
            this.textBoxRuntime.Text = "Filmduur";
            this.textBoxRuntime.Enter += new System.EventHandler(this.textBoxRuntime_Enter);
            this.textBoxRuntime.Leave += new System.EventHandler(this.textBoxRuntime_Leave);
            // 
            // textBoxFilmtechnology
            // 
            this.textBoxFilmtechnology.BackColor = System.Drawing.Color.Black;
            this.textBoxFilmtechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilmtechnology.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxFilmtechnology.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxFilmtechnology.Location = new System.Drawing.Point(341, 401);
            this.textBoxFilmtechnology.Name = "textBoxFilmtechnology";
            this.textBoxFilmtechnology.Size = new System.Drawing.Size(526, 27);
            this.textBoxFilmtechnology.TabIndex = 326;
            this.textBoxFilmtechnology.Text = "Filmtechnologie";
            this.textBoxFilmtechnology.Enter += new System.EventHandler(this.textBoxFilmtechnology_Enter);
            this.textBoxFilmtechnology.Leave += new System.EventHandler(this.textBoxFilmtechnology_Leave);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Black;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxPrice.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxPrice.Location = new System.Drawing.Point(341, 436);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(526, 27);
            this.textBoxPrice.TabIndex = 327;
            this.textBoxPrice.Text = "Prijs";
            this.textBoxPrice.Enter += new System.EventHandler(this.textBoxPrice_Enter);
            this.textBoxPrice.Leave += new System.EventHandler(this.textBoxPrice_Leave);
            // 
            // textBoxTrailer
            // 
            this.textBoxTrailer.BackColor = System.Drawing.Color.Black;
            this.textBoxTrailer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrailer.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxTrailer.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxTrailer.Location = new System.Drawing.Point(341, 471);
            this.textBoxTrailer.Name = "textBoxTrailer";
            this.textBoxTrailer.Size = new System.Drawing.Size(526, 27);
            this.textBoxTrailer.TabIndex = 328;
            this.textBoxTrailer.Text = "Trailerlink";
            this.textBoxTrailer.Enter += new System.EventHandler(this.textBoxTrailer_Enter);
            this.textBoxTrailer.Leave += new System.EventHandler(this.textBoxTrailer_Leave);
            // 
            // textBoxSynopsis
            // 
            this.textBoxSynopsis.BackColor = System.Drawing.Color.Black;
            this.textBoxSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSynopsis.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Italic);
            this.textBoxSynopsis.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxSynopsis.Location = new System.Drawing.Point(341, 506);
            this.textBoxSynopsis.Multiline = true;
            this.textBoxSynopsis.Name = "textBoxSynopsis";
            this.textBoxSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSynopsis.Size = new System.Drawing.Size(526, 294);
            this.textBoxSynopsis.TabIndex = 329;
            this.textBoxSynopsis.Text = "Korte filmbeschrijving";
            this.textBoxSynopsis.Enter += new System.EventHandler(this.textBoxSynopsis_Enter);
            this.textBoxSynopsis.Leave += new System.EventHandler(this.textBoxSynopsis_Leave);
            // 
            // AddMoviePoster
            // 
            this.AddMoviePoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddMoviePoster.Location = new System.Drawing.Point(100, 121);
            this.AddMoviePoster.Name = "AddMoviePoster";
            this.AddMoviePoster.Size = new System.Drawing.Size(210, 307);
            this.AddMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddMoviePoster.TabIndex = 317;
            this.AddMoviePoster.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(297, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 24);
            this.label4.TabIndex = 330;
            this.label4.Text = "Vul hier de onderstaande velden in";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(20, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(930, 3);
            this.label5.TabIndex = 331;
            // 
            // AddMovieImageButton
            // 
            this.AddMovieImageButton.AutoSize = true;
            this.AddMovieImageButton.BackColor = System.Drawing.Color.Yellow;
            this.AddMovieImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieImageButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieImageButton.Location = new System.Drawing.Point(100, 436);
            this.AddMovieImageButton.Name = "AddMovieImageButton";
            this.AddMovieImageButton.Size = new System.Drawing.Size(210, 31);
            this.AddMovieImageButton.TabIndex = 332;
            this.AddMovieImageButton.Text = "Afbeelding toevoegen";
            this.AddMovieImageButton.UseVisualStyleBackColor = false;
            this.AddMovieImageButton.Click += new System.EventHandler(this.AddMovieImageButton_Click);
            // 
            // AddMovieControl
            // 
            this.AddMovieControl.Controls.Add(this.AddMovieButton);
            this.AddMovieControl.Controls.Add(this.AddMovieImageButton);
            this.AddMovieControl.Controls.Add(this.label2);
            this.AddMovieControl.Controls.Add(this.label1);
            this.AddMovieControl.Controls.Add(this.label5);
            this.AddMovieControl.Controls.Add(this.label4);
            this.AddMovieControl.Controls.Add(this.OpenAddMoviePanel);
            this.AddMovieControl.Controls.Add(this.textBoxSynopsis);
            this.AddMovieControl.Controls.Add(this.label3);
            this.AddMovieControl.Controls.Add(this.textBoxTrailer);
            this.AddMovieControl.Controls.Add(this.AddMoviePoster);
            this.AddMovieControl.Controls.Add(this.textBoxPrice);
            this.AddMovieControl.Controls.Add(this.textBoxTitle);
            this.AddMovieControl.Controls.Add(this.textBoxFilmtechnology);
            this.AddMovieControl.Controls.Add(this.textBoxRelease);
            this.AddMovieControl.Controls.Add(this.textBoxRuntime);
            this.AddMovieControl.Controls.Add(this.textBoxDirector);
            this.AddMovieControl.Controls.Add(this.textBoxAge);
            this.AddMovieControl.Controls.Add(this.textBoxGenre);
            this.AddMovieControl.Controls.Add(this.textBoxRating);
            this.AddMovieControl.Controls.Add(this.textBoxLanguage);
            this.AddMovieControl.Location = new System.Drawing.Point(0, 3);
            this.AddMovieControl.MaximumSize = new System.Drawing.Size(970, 887);
            this.AddMovieControl.MinimumSize = new System.Drawing.Size(970, 54);
            this.AddMovieControl.Name = "AddMovieControl";
            this.AddMovieControl.Size = new System.Drawing.Size(970, 54);
            this.AddMovieControl.TabIndex = 333;
            // 
            // AdminAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.AddMovieControl);
            this.MaximumSize = new System.Drawing.Size(970, 887);
            this.MinimumSize = new System.Drawing.Size(970, 54);
            this.Name = "AdminAddMovie";
            this.Size = new System.Drawing.Size(970, 54);
            ((System.ComponentModel.ISupportInitialize)(this.AddMoviePoster)).EndInit();
            this.AddMovieControl.ResumeLayout(false);
            this.AddMovieControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenAddMoviePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.PictureBox AddMoviePoster;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxRelease;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxRuntime;
        private System.Windows.Forms.TextBox textBoxFilmtechnology;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTrailer;
        private System.Windows.Forms.TextBox textBoxSynopsis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddMovieImageButton;
        private System.Windows.Forms.Panel AddMovieControl;
    }
}
