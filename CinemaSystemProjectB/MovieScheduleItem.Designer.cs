namespace CinemaSystemProjectB
{
    partial class MovieScheduleItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Filmtitle
            // 
            this.Filmtitle.AutoEllipsis = true;
            this.Filmtitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmtitle.ForeColor = System.Drawing.Color.Yellow;
            this.Filmtitle.Location = new System.Drawing.Point(18, 22);
            this.Filmtitle.Name = "Filmtitle";
            this.Filmtitle.Size = new System.Drawing.Size(257, 76);
            this.Filmtitle.TabIndex = 0;
            this.Filmtitle.Text = "FIlmtitel";
            this.Filmtitle.Click += new System.EventHandler(this.Filmtitle_Click);
            // 
            // Filmtechnology
            // 
            this.Filmtechnology.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filmtechnology.ForeColor = System.Drawing.Color.Yellow;
            this.Filmtechnology.Location = new System.Drawing.Point(18, 108);
            this.Filmtechnology.Name = "Filmtechnology";
            this.Filmtechnology.Size = new System.Drawing.Size(137, 28);
            this.Filmtechnology.TabIndex = 1;
            this.Filmtechnology.Text = "2D/3D";
            this.Filmtechnology.Click += new System.EventHandler(this.Filmtitle_Click);
            // 
            // runtime
            // 
            this.runtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtime.ForeColor = System.Drawing.Color.Yellow;
            this.runtime.Location = new System.Drawing.Point(161, 108);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(125, 28);
            this.runtime.TabIndex = 2;
            this.runtime.Text = "Filmduur";
            this.runtime.Click += new System.EventHandler(this.Filmtitle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 3);
            this.label1.TabIndex = 3;
            // 
            // MovieScheduleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runtime);
            this.Controls.Add(this.Filmtechnology);
            this.Controls.Add(this.Filmtitle);
            this.Name = "MovieScheduleItem";
            this.Size = new System.Drawing.Size(293, 156);
            this.Click += new System.EventHandler(this.Filmtitle_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Filmtitle;
        private System.Windows.Forms.Label Filmtechnology;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.Label label1;
    }
}
