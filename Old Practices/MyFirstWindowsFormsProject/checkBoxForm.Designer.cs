namespace MyFirstWindowsFormsProject
{
    partial class checkBoxForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnHideCheckBox1 = new System.Windows.Forms.Button();
            this.btnCheckBoxVAl = new System.Windows.Forms.Button();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduem = new System.Windows.Forms.RadioButton();
            this.rbLArge = new System.Windows.Forms.RadioButton();
            this.btnRadioButtomValue = new System.Windows.Forms.Button();
            this.gpBox1 = new System.Windows.Forms.GroupBox();
            this.gpCrustSize = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gpBox1.SuspendLayout();
            this.gpCrustSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.checkBox1.FlatAppearance.BorderSize = 7;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(115, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(497, 41);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Do You Want To Add Onion IN Your PiZZa";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnHideCheckBox1
            // 
            this.btnHideCheckBox1.Location = new System.Drawing.Point(12, 103);
            this.btnHideCheckBox1.Name = "btnHideCheckBox1";
            this.btnHideCheckBox1.Size = new System.Drawing.Size(75, 84);
            this.btnHideCheckBox1.TabIndex = 1;
            this.btnHideCheckBox1.Text = "Show Check Box Value";
            this.btnHideCheckBox1.UseVisualStyleBackColor = true;
            this.btnHideCheckBox1.Click += new System.EventHandler(this.btnHideCheckBox1_Click);
            // 
            // btnCheckBoxVAl
            // 
            this.btnCheckBoxVAl.Location = new System.Drawing.Point(115, 103);
            this.btnCheckBoxVAl.Name = "btnCheckBoxVAl";
            this.btnCheckBoxVAl.Size = new System.Drawing.Size(75, 84);
            this.btnCheckBoxVAl.TabIndex = 2;
            this.btnCheckBoxVAl.Text = "Show Check Box Value By Value";
            this.btnCheckBoxVAl.UseVisualStyleBackColor = true;
            this.btnCheckBoxVAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(32, 31);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMeduem
            // 
            this.rbMeduem.AutoSize = true;
            this.rbMeduem.Location = new System.Drawing.Point(31, 54);
            this.rbMeduem.Name = "rbMeduem";
            this.rbMeduem.Size = new System.Drawing.Size(66, 17);
            this.rbMeduem.TabIndex = 4;
            this.rbMeduem.TabStop = true;
            this.rbMeduem.Text = "Meduem";
            this.rbMeduem.UseVisualStyleBackColor = true;
            // 
            // rbLArge
            // 
            this.rbLArge.AutoSize = true;
            this.rbLArge.Location = new System.Drawing.Point(31, 77);
            this.rbLArge.Name = "rbLArge";
            this.rbLArge.Size = new System.Drawing.Size(52, 17);
            this.rbLArge.TabIndex = 5;
            this.rbLArge.TabStop = true;
            this.rbLArge.Text = "Large";
            this.rbLArge.UseVisualStyleBackColor = true;
            // 
            // btnRadioButtomValue
            // 
            this.btnRadioButtomValue.Location = new System.Drawing.Point(12, 200);
            this.btnRadioButtomValue.Name = "btnRadioButtomValue";
            this.btnRadioButtomValue.Size = new System.Drawing.Size(127, 53);
            this.btnRadioButtomValue.TabIndex = 6;
            this.btnRadioButtomValue.Text = "See The Value Of First Rb";
            this.btnRadioButtomValue.UseVisualStyleBackColor = true;
            this.btnRadioButtomValue.Click += new System.EventHandler(this.btnRadioButtomValue_Click);
            // 
            // gpBox1
            // 
            this.gpBox1.Controls.Add(this.rbSmall);
            this.gpBox1.Controls.Add(this.rbMeduem);
            this.gpBox1.Controls.Add(this.rbLArge);
            this.gpBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox1.Location = new System.Drawing.Point(245, 123);
            this.gpBox1.Name = "gpBox1";
            this.gpBox1.Size = new System.Drawing.Size(200, 100);
            this.gpBox1.TabIndex = 7;
            this.gpBox1.TabStop = false;
            this.gpBox1.Text = "Chose PiZZa Size";
            // 
            // gpCrustSize
            // 
            this.gpCrustSize.Controls.Add(this.rbThick);
            this.gpCrustSize.Controls.Add(this.rbThin);
            this.gpCrustSize.Location = new System.Drawing.Point(479, 123);
            this.gpCrustSize.Name = "gpCrustSize";
            this.gpCrustSize.Size = new System.Drawing.Size(200, 100);
            this.gpCrustSize.TabIndex = 8;
            this.gpCrustSize.TabStop = false;
            this.gpCrustSize.Text = "Crust Size";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(18, 31);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(46, 17);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(18, 64);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(52, 17);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // checkBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpCrustSize);
            this.Controls.Add(this.gpBox1);
            this.Controls.Add(this.btnRadioButtomValue);
            this.Controls.Add(this.btnCheckBoxVAl);
            this.Controls.Add(this.btnHideCheckBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "checkBoxForm";
            this.Text = "checkBoxForm";
            this.gpBox1.ResumeLayout(false);
            this.gpBox1.PerformLayout();
            this.gpCrustSize.ResumeLayout(false);
            this.gpCrustSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnHideCheckBox1;
        private System.Windows.Forms.Button btnCheckBoxVAl;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduem;
        private System.Windows.Forms.RadioButton rbLArge;
        private System.Windows.Forms.Button btnRadioButtomValue;
        private System.Windows.Forms.GroupBox gpBox1;
        private System.Windows.Forms.GroupBox gpCrustSize;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
    }
}