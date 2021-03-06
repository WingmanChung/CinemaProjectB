﻿namespace CinemaSystemProjectB
{
    partial class RoadMap
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
            this.gradientLabel1 = new CinemaSystemProjectB.GradientLabel();
            this.Bioscoopnaam = new System.Windows.Forms.Label();
            this.Wittelijn = new System.Windows.Forms.Label();
            this.Linkerkolom = new System.Windows.Forms.Label();
            this.Rechterkolom = new System.Windows.Forms.Label();
            this.MovieReservationLabel = new System.Windows.Forms.Label();
            this.RoadMapLayOutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientLabel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BeginColor = System.Drawing.Color.Black;
            this.gradientLabel1.Controls.Add(this.Bioscoopnaam);
            this.gradientLabel1.EndColor = System.Drawing.Color.Maroon;
            this.gradientLabel1.Location = new System.Drawing.Point(-4, -2);
            this.gradientLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(1484, 149);
            this.gradientLabel1.TabIndex = 57;
            // 
            // Bioscoopnaam
            // 
            this.Bioscoopnaam.AutoSize = true;
            this.Bioscoopnaam.BackColor = System.Drawing.Color.Transparent;
            this.Bioscoopnaam.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Bioscoopnaam.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bioscoopnaam.ForeColor = System.Drawing.Color.Yellow;
            this.Bioscoopnaam.Location = new System.Drawing.Point(69, 39);
            this.Bioscoopnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bioscoopnaam.Name = "Bioscoopnaam";
            this.Bioscoopnaam.Size = new System.Drawing.Size(356, 73);
            this.Bioscoopnaam.TabIndex = 10;
            this.Bioscoopnaam.Text = "Darichwiwi";
            // 
            // Wittelijn
            // 
            this.Wittelijn.BackColor = System.Drawing.Color.White;
            this.Wittelijn.Location = new System.Drawing.Point(-7, 143);
            this.Wittelijn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wittelijn.Name = "Wittelijn";
            this.Wittelijn.Size = new System.Drawing.Size(1483, 6);
            this.Wittelijn.TabIndex = 58;
            // 
            // Linkerkolom
            // 
            this.Linkerkolom.BackColor = System.Drawing.Color.Maroon;
            this.Linkerkolom.Location = new System.Drawing.Point(0, 149);
            this.Linkerkolom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Linkerkolom.Name = "Linkerkolom";
            this.Linkerkolom.Size = new System.Drawing.Size(40, 796);
            this.Linkerkolom.TabIndex = 59;
            // 
            // Rechterkolom
            // 
            this.Rechterkolom.BackColor = System.Drawing.Color.Maroon;
            this.Rechterkolom.Location = new System.Drawing.Point(1436, 149);
            this.Rechterkolom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rechterkolom.Name = "Rechterkolom";
            this.Rechterkolom.Size = new System.Drawing.Size(40, 770);
            this.Rechterkolom.TabIndex = 60;
            // 
            // MovieReservationLabel
            // 
            this.MovieReservationLabel.BackColor = System.Drawing.Color.Yellow;
            this.MovieReservationLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieReservationLabel.ForeColor = System.Drawing.Color.Black;
            this.MovieReservationLabel.Location = new System.Drawing.Point(48, 159);
            this.MovieReservationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieReservationLabel.Name = "MovieReservationLabel";
            this.MovieReservationLabel.Size = new System.Drawing.Size(1380, 39);
            this.MovieReservationLabel.TabIndex = 61;
            this.MovieReservationLabel.Text = "Online reserveren stap-voor-stap";
            this.MovieReservationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoadMapLayOutPanel
            // 
            this.RoadMapLayOutPanel.AutoScroll = true;
            this.RoadMapLayOutPanel.Location = new System.Drawing.Point(48, 199);
            this.RoadMapLayOutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoadMapLayOutPanel.Name = "RoadMapLayOutPanel";
            this.RoadMapLayOutPanel.Size = new System.Drawing.Size(1380, 720);
            this.RoadMapLayOutPanel.TabIndex = 62;
            // 
            // RoadMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1476, 919);
            this.Controls.Add(this.RoadMapLayOutPanel);
            this.Controls.Add(this.MovieReservationLabel);
            this.Controls.Add(this.Rechterkolom);
            this.Controls.Add(this.Linkerkolom);
            this.Controls.Add(this.Wittelijn);
            this.Controls.Add(this.gradientLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "RoadMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoadMap";
            this.gradientLabel1.ResumeLayout(false);
            this.gradientLabel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientLabel gradientLabel1;
        private System.Windows.Forms.Label Bioscoopnaam;
        private System.Windows.Forms.Label Wittelijn;
        private System.Windows.Forms.Label Linkerkolom;
        private System.Windows.Forms.Label Rechterkolom;
        private System.Windows.Forms.Label MovieReservationLabel;
        private System.Windows.Forms.FlowLayoutPanel RoadMapLayOutPanel;
    }
}