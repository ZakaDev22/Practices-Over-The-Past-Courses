namespace MyFirstWindowsFormsProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.btnShowFormAsDialog = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowJeryPic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowPizzaForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(309, 40);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(90, 38);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show form 1";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.btnShowPart1_Click);
            // 
            // btnShowFormAsDialog
            // 
            this.btnShowFormAsDialog.Location = new System.Drawing.Point(455, 40);
            this.btnShowFormAsDialog.Name = "btnShowFormAsDialog";
            this.btnShowFormAsDialog.Size = new System.Drawing.Size(90, 38);
            this.btnShowFormAsDialog.TabIndex = 1;
            this.btnShowFormAsDialog.Text = "Show Form As Dialog";
            this.btnShowFormAsDialog.UseVisualStyleBackColor = true;
            this.btnShowFormAsDialog.Click += new System.EventHandler(this.btnShowFormAsDialog_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(381, 97);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 185);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnShowJeryPic
            // 
            this.btnShowJeryPic.BackColor = System.Drawing.Color.Yellow;
            this.btnShowJeryPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowJeryPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowJeryPic.FlatAppearance.BorderSize = 4;
            this.btnShowJeryPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnShowJeryPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowJeryPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowJeryPic.Location = new System.Drawing.Point(29, 276);
            this.btnShowJeryPic.Name = "btnShowJeryPic";
            this.btnShowJeryPic.Size = new System.Drawing.Size(105, 50);
            this.btnShowJeryPic.TabIndex = 4;
            this.btnShowJeryPic.Text = "Hide The picture";
            this.btnShowJeryPic.UseVisualStyleBackColor = false;
            this.btnShowJeryPic.Click += new System.EventHandler(this.btnShowJeryPic_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hide The picture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowPizzaForm
            // 
            this.btnShowPizzaForm.BackColor = System.Drawing.Color.Gray;
            this.btnShowPizzaForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPizzaForm.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnShowPizzaForm.FlatAppearance.BorderSize = 4;
            this.btnShowPizzaForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnShowPizzaForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowPizzaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPizzaForm.Location = new System.Drawing.Point(624, 34);
            this.btnShowPizzaForm.Name = "btnShowPizzaForm";
            this.btnShowPizzaForm.Size = new System.Drawing.Size(105, 50);
            this.btnShowPizzaForm.TabIndex = 6;
            this.btnShowPizzaForm.Text = "Show Pizza Form";
            this.btnShowPizzaForm.UseVisualStyleBackColor = false;
            this.btnShowPizzaForm.Click += new System.EventHandler(this.btnShowPizzaForm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(208, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show Message Box";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(624, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Show Check Box Form";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyFirstWindowsFormsProject.Properties.Resources.FB_IMG_1684094087061;
            this.ClientSize = new System.Drawing.Size(757, 552);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowPizzaForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowJeryPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowFormAsDialog);
            this.Controls.Add(this.btnShowPart1);
            this.Name = "frmMain";
            this.Text = "Show Message Box";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button btnShowFormAsDialog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowJeryPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowPizzaForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}