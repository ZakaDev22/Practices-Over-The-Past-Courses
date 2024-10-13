namespace C____Pizza__Poject
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbPizzaSizeBox = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduem = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chkGreenPapers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomateos = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkMoreChees = new System.Windows.Forms.CheckBox();
            this.gbWhearToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbPriceText = new System.Windows.Forms.Label();
            this.lbToTalPrice = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbToppingName = new System.Windows.Forms.Label();
            this.lbWherToEat = new System.Windows.Forms.Label();
            this.lbTopping = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbPizzaSizeBox.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbWhearToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(286, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPizzaSizeBox
            // 
            this.gbPizzaSizeBox.BackColor = System.Drawing.Color.White;
            this.gbPizzaSizeBox.Controls.Add(this.rbLarge);
            this.gbPizzaSizeBox.Controls.Add(this.rbMeduem);
            this.gbPizzaSizeBox.Controls.Add(this.rbSmall);
            this.gbPizzaSizeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPizzaSizeBox.Location = new System.Drawing.Point(12, 179);
            this.gbPizzaSizeBox.Name = "gbPizzaSizeBox";
            this.gbPizzaSizeBox.Size = new System.Drawing.Size(200, 97);
            this.gbPizzaSizeBox.TabIndex = 2;
            this.gbPizzaSizeBox.TabStop = false;
            this.gbPizzaSizeBox.Text = "PIZZA SIZE";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(6, 74);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 21);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduem
            // 
            this.rbMeduem.AutoSize = true;
            this.rbMeduem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduem.Location = new System.Drawing.Point(6, 48);
            this.rbMeduem.Name = "rbMeduem";
            this.rbMeduem.Size = new System.Drawing.Size(80, 21);
            this.rbMeduem.TabIndex = 1;
            this.rbMeduem.TabStop = true;
            this.rbMeduem.Text = "Meduem";
            this.rbMeduem.UseVisualStyleBackColor = true;
            this.rbMeduem.CheckedChanged += new System.EventHandler(this.rbMeduem_CheckedChanged_1);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(6, 25);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(60, 21);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.White;
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(12, 297);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 87);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(95, 32);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(60, 21);
            this.rbThickCrust.TabIndex = 3;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(14, 32);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(54, 21);
            this.rbThinCrust.TabIndex = 2;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.White;
            this.gbTopping.Controls.Add(this.chkGreenPapers);
            this.gbTopping.Controls.Add(this.chkOlives);
            this.gbTopping.Controls.Add(this.chkOnion);
            this.gbTopping.Controls.Add(this.chkTomateos);
            this.gbTopping.Controls.Add(this.chkMushrooms);
            this.gbTopping.Controls.Add(this.chkMoreChees);
            this.gbTopping.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.Location = new System.Drawing.Point(218, 165);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(234, 126);
            this.gbTopping.TabIndex = 3;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            // 
            // chkGreenPapers
            // 
            this.chkGreenPapers.AutoSize = true;
            this.chkGreenPapers.Location = new System.Drawing.Point(120, 94);
            this.chkGreenPapers.Name = "chkGreenPapers";
            this.chkGreenPapers.Size = new System.Drawing.Size(116, 21);
            this.chkGreenPapers.TabIndex = 5;
            this.chkGreenPapers.Text = "Green Papers";
            this.chkGreenPapers.UseVisualStyleBackColor = true;
            this.chkGreenPapers.CheckedChanged += new System.EventHandler(this.chkGreenPapers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(120, 70);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(66, 21);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(120, 39);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(65, 21);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkTomateos
            // 
            this.chkTomateos.AutoSize = true;
            this.chkTomateos.Location = new System.Drawing.Point(6, 87);
            this.chkTomateos.Name = "chkTomateos";
            this.chkTomateos.Size = new System.Drawing.Size(90, 21);
            this.chkTomateos.TabIndex = 2;
            this.chkTomateos.Text = "Tomateos";
            this.chkTomateos.UseVisualStyleBackColor = true;
            this.chkTomateos.CheckedChanged += new System.EventHandler(this.chkTomateos_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 64);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(100, 21);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkMoreChees
            // 
            this.chkMoreChees.AutoSize = true;
            this.chkMoreChees.Location = new System.Drawing.Point(6, 39);
            this.chkMoreChees.Name = "chkMoreChees";
            this.chkMoreChees.Size = new System.Drawing.Size(103, 21);
            this.chkMoreChees.TabIndex = 0;
            this.chkMoreChees.Text = "Extra Chees";
            this.chkMoreChees.UseVisualStyleBackColor = true;
            this.chkMoreChees.CheckedChanged += new System.EventHandler(this.chkMoreChees_CheckedChanged);
            // 
            // gbWhearToEat
            // 
            this.gbWhearToEat.BackColor = System.Drawing.Color.White;
            this.gbWhearToEat.Controls.Add(this.rbTakeOut);
            this.gbWhearToEat.Controls.Add(this.rbEatIn);
            this.gbWhearToEat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbWhearToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhearToEat.Location = new System.Drawing.Point(228, 297);
            this.gbWhearToEat.Name = "gbWhearToEat";
            this.gbWhearToEat.Size = new System.Drawing.Size(200, 87);
            this.gbWhearToEat.TabIndex = 4;
            this.gbWhearToEat.TabStop = false;
            this.gbWhearToEat.Text = "Wher To Eat";
            this.gbWhearToEat.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(100, 31);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(85, 21);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(6, 31);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(62, 21);
            this.rbEatIn.TabIndex = 2;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmOrder.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 5;
            this.btnConfirmOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Location = new System.Drawing.Point(274, 390);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(75, 50);
            this.btnConfirmOrder.TabIndex = 5;
            this.btnConfirmOrder.Text = "Order PIzza";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(392, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPriceText
            // 
            this.lbPriceText.AutoSize = true;
            this.lbPriceText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPriceText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lbPriceText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPriceText.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceText.Location = new System.Drawing.Point(507, 379);
            this.lbPriceText.Name = "lbPriceText";
            this.lbPriceText.Size = new System.Drawing.Size(155, 40);
            this.lbPriceText.TabIndex = 12;
            this.lbPriceText.Text = "Total Price :";
            // 
            // lbToTalPrice
            // 
            this.lbToTalPrice.AutoSize = true;
            this.lbToTalPrice.Font = new System.Drawing.Font("MS PGothic", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToTalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbToTalPrice.Location = new System.Drawing.Point(652, 388);
            this.lbToTalPrice.Name = "lbToTalPrice";
            this.lbToTalPrice.Size = new System.Drawing.Size(85, 47);
            this.lbToTalPrice.TabIndex = 13;
            this.lbToTalPrice.Tag = "";
            this.lbToTalPrice.Text = "$ 0";
            this.lbToTalPrice.Click += new System.EventHandler(this.lbToTalPrice_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lbToppingName);
            this.gbOrderSummary.Controls.Add(this.lbWherToEat);
            this.gbOrderSummary.Controls.Add(this.lbTopping);
            this.gbOrderSummary.Controls.Add(this.lbCrustType);
            this.gbOrderSummary.Controls.Add(this.lbSize);
            this.gbOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(507, 165);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(354, 211);
            this.gbOrderSummary.TabIndex = 16;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary Ticket :";
            // 
            // lbToppingName
            // 
            this.lbToppingName.AutoSize = true;
            this.lbToppingName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppingName.Location = new System.Drawing.Point(21, 74);
            this.lbToppingName.Name = "lbToppingName";
            this.lbToppingName.Size = new System.Drawing.Size(88, 28);
            this.lbToppingName.TabIndex = 20;
            this.lbToppingName.Text = "Topping :";
            // 
            // lbWherToEat
            // 
            this.lbWherToEat.AutoSize = true;
            this.lbWherToEat.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWherToEat.Location = new System.Drawing.Point(22, 174);
            this.lbWherToEat.Name = "lbWherToEat";
            this.lbWherToEat.Size = new System.Drawing.Size(113, 21);
            this.lbWherToEat.TabIndex = 19;
            this.lbWherToEat.Text = "Wher To Eat :";
            // 
            // lbTopping
            // 
            this.lbTopping.AutoSize = true;
            this.lbTopping.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopping.Location = new System.Drawing.Point(115, 81);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(79, 16);
            this.lbTopping.TabIndex = 18;
            this.lbTopping.Text = "No Topping.";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(22, 142);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(100, 21);
            this.lbCrustType.TabIndex = 17;
            this.lbCrustType.Text = "Crust Type :";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(22, 37);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(49, 21);
            this.lbSize.TabIndex = 16;
            this.lbSize.Text = "Size :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(543, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 141);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-17, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 177);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbToTalPrice);
            this.Controls.Add(this.lbPriceText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.gbWhearToEat);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbPizzaSizeBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderForm";
            this.Text = "PIZZA HuT.Z";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.gbPizzaSizeBox.ResumeLayout(false);
            this.gbPizzaSizeBox.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbWhearToEat.ResumeLayout(false);
            this.gbWhearToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPizzaSizeBox;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.GroupBox gbWhearToEat;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduem;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.CheckBox chkGreenPapers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomateos;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkMoreChees;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPriceText;
        private System.Windows.Forms.Label lbToTalPrice;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lbToppingName;
        private System.Windows.Forms.Label lbWherToEat;
        private System.Windows.Forms.Label lbTopping;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}