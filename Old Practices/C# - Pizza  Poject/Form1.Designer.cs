namespace C____Pizza__Poject
{
    partial class PizzaOrderForm
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
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.btnShowOrderScreen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-40, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.AutoSize = true;
            this.lbFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFormTitle.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.lbFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormTitle.ForeColor = System.Drawing.Color.Red;
            this.lbFormTitle.Location = new System.Drawing.Point(158, 23);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(587, 41);
            this.lbFormTitle.TabIndex = 1;
            this.lbFormTitle.Text = "Welcome To Your PiZZa Order App";
            // 
            // btnShowOrderScreen
            // 
            this.btnShowOrderScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowOrderScreen.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnShowOrderScreen.FlatAppearance.BorderSize = 5;
            this.btnShowOrderScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnShowOrderScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnShowOrderScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrderScreen.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOrderScreen.Location = new System.Drawing.Point(575, 141);
            this.btnShowOrderScreen.Name = "btnShowOrderScreen";
            this.btnShowOrderScreen.Size = new System.Drawing.Size(160, 107);
            this.btnShowOrderScreen.TabIndex = 2;
            this.btnShowOrderScreen.Text = "Go To Order Screen.";
            this.btnShowOrderScreen.UseVisualStyleBackColor = false;
            this.btnShowOrderScreen.Click += new System.EventHandler(this.btnShowOrderScreen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnClose.FlatAppearance.BorderSize = 5;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(575, 275);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 107);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close The App";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowOrderScreen);
            this.Controls.Add(this.lbFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PizzaOrderForm";
            this.Text = "PiZZa Hut.Z";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.Button btnShowOrderScreen;
        private System.Windows.Forms.Button btnClose;
    }
}

