namespace C______Combo_Box_Exercise
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbPictures = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(341, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(71, 31);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
            // 
            // cbPictures
            // 
            this.cbPictures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPictures.FormattingEnabled = true;
            this.cbPictures.Items.AddRange(new object[] {
            "BOOK",
            "BOY",
            "GIRL",
            "PEN"});
            this.cbPictures.Location = new System.Drawing.Point(347, 389);
            this.cbPictures.Name = "cbPictures";
            this.cbPictures.Size = new System.Drawing.Size(169, 21);
            this.cbPictures.Sorted = true;
            this.cbPictures.TabIndex = 2;
            this.cbPictures.SelectedIndexChanged += new System.EventHandler(this.cbPictures_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chang Picture :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbPic1
            // 
            this.pbPic1.Image = global::C______Combo_Box_Exercise.Properties.Resources.download__18_;
            this.pbPic1.Location = new System.Drawing.Point(206, 81);
            this.pbPic1.Name = "pbPic1";
            this.pbPic1.Size = new System.Drawing.Size(345, 277);
            this.pbPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic1.TabIndex = 0;
            this.pbPic1.TabStop = false;
            this.pbPic1.Click += new System.EventHandler(this.pbPic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPictures);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbPic1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPic1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbPictures;
        private System.Windows.Forms.Label label2;
    }
}

