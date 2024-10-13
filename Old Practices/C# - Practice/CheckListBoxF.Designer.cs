namespace C____Practice
{
    partial class CheckListBoxF
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
            this.chkListB1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LlbYoutub = new System.Windows.Forms.LinkLabel();
            this.LlbProgrammingAdvices = new System.Windows.Forms.LinkLabel();
            this.LlbLinkedIn = new System.Windows.Forms.LinkLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkListB1
            // 
            this.chkListB1.FormattingEnabled = true;
            this.chkListB1.Location = new System.Drawing.Point(23, 35);
            this.chkListB1.Name = "chkListB1";
            this.chkListB1.Size = new System.Drawing.Size(277, 154);
            this.chkListB1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Selected Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Checked All Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove Item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 70);
            this.button5.TabIndex = 5;
            this.button5.Text = "UnChecked Items";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Youtub.com",
            "Programming Advices",
            "Linked In"});
            this.comboBox1.Location = new System.Drawing.Point(480, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LlbYoutub
            // 
            this.LlbYoutub.AutoSize = true;
            this.LlbYoutub.Location = new System.Drawing.Point(747, 318);
            this.LlbYoutub.Name = "LlbYoutub";
            this.LlbYoutub.Size = new System.Drawing.Size(41, 13);
            this.LlbYoutub.TabIndex = 8;
            this.LlbYoutub.TabStop = true;
            this.LlbYoutub.Text = "Youtub";
            this.LlbYoutub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbYoutub_LinkClicked);
            // 
            // LlbProgrammingAdvices
            // 
            this.LlbProgrammingAdvices.AutoSize = true;
            this.LlbProgrammingAdvices.Location = new System.Drawing.Point(682, 353);
            this.LlbProgrammingAdvices.Name = "LlbProgrammingAdvices";
            this.LlbProgrammingAdvices.Size = new System.Drawing.Size(106, 13);
            this.LlbProgrammingAdvices.TabIndex = 9;
            this.LlbProgrammingAdvices.TabStop = true;
            this.LlbProgrammingAdvices.Text = "ProgrammingAdvices";
            this.LlbProgrammingAdvices.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbProgrammingAdvices_LinkClicked);
            // 
            // LlbLinkedIn
            // 
            this.LlbLinkedIn.AutoSize = true;
            this.LlbLinkedIn.Location = new System.Drawing.Point(691, 318);
            this.LlbLinkedIn.Name = "LlbLinkedIn";
            this.LlbLinkedIn.Size = new System.Drawing.Size(48, 13);
            this.LlbLinkedIn.TabIndex = 10;
            this.LlbLinkedIn.TabStop = true;
            this.LlbLinkedIn.Text = "LinkedIn";
            this.LlbLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbLinkedIn_LinkClicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(658, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 69);
            this.button6.TabIndex = 11;
            this.button6.Text = "Reset Pictures";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C____Practice.Properties.Resources.images__7_;
            this.pictureBox1.Location = new System.Drawing.Point(453, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CheckListBoxF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.LlbLinkedIn);
            this.Controls.Add(this.LlbProgrammingAdvices);
            this.Controls.Add(this.LlbYoutub);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkListB1);
            this.Name = "CheckListBoxF";
            this.Text = "Linked in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel LlbYoutub;
        private System.Windows.Forms.LinkLabel LlbProgrammingAdvices;
        private System.Windows.Forms.LinkLabel LlbLinkedIn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}