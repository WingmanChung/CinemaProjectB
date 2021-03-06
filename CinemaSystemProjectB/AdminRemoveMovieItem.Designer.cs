﻿using System.Windows.Forms;

namespace CinemaSystemProjectB
{
    partial class AdminRemoveMovieItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.release = new System.Windows.Forms.Label();
            this.taal = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.filmtechnologie = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(0, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1120, 4);
            this.label2.TabIndex = 306;
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(45, 12);
            this.MoviePoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(168, 217);
            this.MoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePoster.TabIndex = 307;
            this.MoviePoster.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 308;
            this.label1.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(256, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 309;
            this.label3.Text = "Release:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(256, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 310;
            this.label4.Text = "Taal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(256, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 311;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(256, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 312;
            this.label6.Text = "Filmtechnologie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13F);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(256, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 313;
            this.label7.Text = "Rating:";
            // 
            // release
            // 
            this.release.AutoSize = true;
            this.release.BackColor = System.Drawing.Color.Transparent;
            this.release.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.release.ForeColor = System.Drawing.Color.Yellow;
            this.release.Location = new System.Drawing.Point(528, 78);
            this.release.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.release.Name = "release";
            this.release.Size = new System.Drawing.Size(65, 24);
            this.release.TabIndex = 314;
            this.release.Text = "label8";
            // 
            // taal
            // 
            this.taal.AutoSize = true;
            this.taal.BackColor = System.Drawing.Color.Transparent;
            this.taal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taal.ForeColor = System.Drawing.Color.Yellow;
            this.taal.Location = new System.Drawing.Point(528, 112);
            this.taal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taal.Name = "taal";
            this.taal.Size = new System.Drawing.Size(65, 24);
            this.taal.TabIndex = 315;
            this.taal.Text = "label8";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.Yellow;
            this.genre.Location = new System.Drawing.Point(528, 135);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(65, 24);
            this.genre.TabIndex = 316;
            this.genre.Text = "label8";
            // 
            // filmtechnologie
            // 
            this.filmtechnologie.AutoSize = true;
            this.filmtechnologie.BackColor = System.Drawing.Color.Transparent;
            this.filmtechnologie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmtechnologie.ForeColor = System.Drawing.Color.Yellow;
            this.filmtechnologie.Location = new System.Drawing.Point(528, 159);
            this.filmtechnologie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filmtechnologie.Name = "filmtechnologie";
            this.filmtechnologie.Size = new System.Drawing.Size(65, 24);
            this.filmtechnologie.TabIndex = 317;
            this.filmtechnologie.Text = "label8";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.Yellow;
            this.rating.Location = new System.Drawing.Point(528, 188);
            this.rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(65, 24);
            this.rating.TabIndex = 318;
            this.rating.Text = "label8";
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.BackColor = System.Drawing.Color.Transparent;
            this.titel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.Color.Yellow;
            this.titel.Location = new System.Drawing.Point(528, 27);
            this.titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(65, 24);
            this.titel.TabIndex = 319;
            this.titel.Text = "label8";
            // 
            // AdminRemoveMovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.titel);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.filmtechnologie);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.taal);
            this.Controls.Add(this.release);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoviePoster);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminRemoveMovieItem";
            this.Size = new System.Drawing.Size(1120, 246);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label release;
        private System.Windows.Forms.Label taal;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label filmtechnologie;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label titel;
    }
}
