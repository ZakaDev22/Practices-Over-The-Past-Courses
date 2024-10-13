namespace MyFirstWindowsFormsProject
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowMessageWithTitle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowMessageWithTitle
            // 
            this.btnShowMessageWithTitle.BackColor = System.Drawing.Color.Yellow;
            this.btnShowMessageWithTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMessageWithTitle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowMessageWithTitle.FlatAppearance.BorderSize = 4;
            this.btnShowMessageWithTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnShowMessageWithTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowMessageWithTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMessageWithTitle.Location = new System.Drawing.Point(95, 217);
            this.btnShowMessageWithTitle.Name = "btnShowMessageWithTitle";
            this.btnShowMessageWithTitle.Size = new System.Drawing.Size(151, 67);
            this.btnShowMessageWithTitle.TabIndex = 5;
            this.btnShowMessageWithTitle.Text = "Show Message With Title";
            this.btnShowMessageWithTitle.UseVisualStyleBackColor = false;
            this.btnShowMessageWithTitle.Click += new System.EventHandler(this.btnShowJeryPic_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Message With Title end Ok Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyFirstWindowsFormsProject.Properties.Resources.download__4_;
            this.ClientSize = new System.Drawing.Size(639, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowMessageWithTitle);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowMessageWithTitle;
        private System.Windows.Forms.Button button2;
    }
}