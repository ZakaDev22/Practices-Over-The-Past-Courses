namespace MyFirstWindowsFormsProject
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labSHowName = new System.Windows.Forms.Label();
            this.btnCloseForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFirstWindowsFormsProject.Properties.Resources.download__13_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 184);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labSHowName
            // 
            this.labSHowName.AutoSize = true;
            this.labSHowName.BackColor = System.Drawing.Color.Aqua;
            this.labSHowName.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.labSHowName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labSHowName.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSHowName.Location = new System.Drawing.Point(89, 9);
            this.labSHowName.Name = "labSHowName";
            this.labSHowName.Size = new System.Drawing.Size(630, 49);
            this.labSHowName.TabIndex = 2;
            this.labSHowName.Text = "Welcom TO My PiZza Resturant";
            this.labSHowName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCloseForm2
            // 
            this.btnCloseForm2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCloseForm2.FlatAppearance.BorderSize = 5;
            this.btnCloseForm2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCloseForm2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCloseForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm2.Location = new System.Drawing.Point(64, 381);
            this.btnCloseForm2.Name = "btnCloseForm2";
            this.btnCloseForm2.Size = new System.Drawing.Size(144, 57);
            this.btnCloseForm2.TabIndex = 3;
            this.btnCloseForm2.Text = "Close";
            this.btnCloseForm2.UseVisualStyleBackColor = true;
            this.btnCloseForm2.Click += new System.EventHandler(this.btnCloseForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyFirstWindowsFormsProject.Properties.Resources.images__13_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseForm2);
            this.Controls.Add(this.labSHowName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "PIzza Hot";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labSHowName;
        private System.Windows.Forms.Button btnCloseForm2;
    }
}