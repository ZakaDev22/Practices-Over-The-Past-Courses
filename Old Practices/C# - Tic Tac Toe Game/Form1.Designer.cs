namespace C____Tic_Tac_Toe_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbWinnerPic = new System.Windows.Forms.PictureBox();
            this.pbTurns = new System.Windows.Forms.PictureBox();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinnerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(238, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Turn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Winner :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbWinnerPic
            // 
            this.pbWinnerPic.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.Progress3;
            this.pbWinnerPic.Location = new System.Drawing.Point(110, 258);
            this.pbWinnerPic.Name = "pbWinnerPic";
            this.pbWinnerPic.Size = new System.Drawing.Size(163, 95);
            this.pbWinnerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWinnerPic.TabIndex = 20;
            this.pbWinnerPic.TabStop = false;
            // 
            // pbTurns
            // 
            this.pbTurns.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.Player1;
            this.pbTurns.Location = new System.Drawing.Point(110, 146);
            this.pbTurns.Name = "pbTurns";
            this.pbTurns.Size = new System.Drawing.Size(163, 95);
            this.pbTurns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTurns.TabIndex = 19;
            this.pbTurns.TabStop = false;
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestartGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestartGame.FlatAppearance.BorderSize = 3;
            this.btnRestartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.download__1_;
            this.btnRestartGame.Location = new System.Drawing.Point(17, 389);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(136, 49);
            this.btnRestartGame.TabIndex = 12;
            this.btnRestartGame.Text = "Restart ";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // pb9
            // 
            this.pb9.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb9.Location = new System.Drawing.Point(667, 330);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(121, 99);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 11;
            this.pb9.TabStop = false;
            this.pb9.Tag = "9";
            this.pb9.Click += new System.EventHandler(this.pb9_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb8.Location = new System.Drawing.Point(541, 330);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(121, 99);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 10;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb7.Location = new System.Drawing.Point(399, 330);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(121, 99);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 9;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            this.pb7.Click += new System.EventHandler(this.pb7_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb2.Location = new System.Drawing.Point(541, 89);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(120, 99);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb3.Location = new System.Drawing.Point(667, 89);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(121, 99);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb6.Location = new System.Drawing.Point(667, 211);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(121, 99);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 6;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb5.Location = new System.Drawing.Point(540, 211);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(121, 99);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb4.Location = new System.Drawing.Point(399, 211);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(121, 99);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pb1.Location = new System.Drawing.Point(399, 89);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(121, 99);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.tic_tac;
            this.pictureBox2.Location = new System.Drawing.Point(399, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C____Tic_Tac_Toe_Game.Properties.Resources.tic_tac;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbWinnerPic);
            this.Controls.Add(this.pbTurns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-TacToe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbWinnerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbTurns;
        private System.Windows.Forms.PictureBox pbWinnerPic;
        private System.Windows.Forms.Label label3;
    }
}

