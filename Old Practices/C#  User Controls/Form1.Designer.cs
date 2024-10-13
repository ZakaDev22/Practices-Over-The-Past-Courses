namespace C___User_Controls
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
            this.ctrSimpleCalculator2 = new C___User_Controls.ctrSimpleCalculator();
            this.ctrSimpleCalculator1 = new C___User_Controls.ctrSimpleCalculator();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrSimpleCalculator2
            // 
            this.ctrSimpleCalculator2.Location = new System.Drawing.Point(412, 37);
            this.ctrSimpleCalculator2.Name = "ctrSimpleCalculator2";
            this.ctrSimpleCalculator2.Size = new System.Drawing.Size(356, 297);
            this.ctrSimpleCalculator2.TabIndex = 1;
            // 
            // ctrSimpleCalculator1
            // 
            this.ctrSimpleCalculator1.Location = new System.Drawing.Point(50, 27);
            this.ctrSimpleCalculator1.Name = "ctrSimpleCalculator1";
            this.ctrSimpleCalculator1.Size = new System.Drawing.Size(356, 297);
            this.ctrSimpleCalculator1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrSimpleCalculator2);
            this.Controls.Add(this.ctrSimpleCalculator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrSimpleCalculator ctrSimpleCalculator1;
        private ctrSimpleCalculator ctrSimpleCalculator2;
        private System.Windows.Forms.Button button1;
    }
}

