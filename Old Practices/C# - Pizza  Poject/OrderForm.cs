using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Pizza__Poject
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        static byte Price = 0;


        void ShowToppingChoices()
        {
            string[] strToppings = {"Extra Cheese","Mushrooms","Tomatoes","Onion"
            ,"Olives","Green Peppers"};

            bool[] Choices = {chkMoreChees.Checked,chkMushrooms.Checked,chkTomateos.Checked
            ,chkOnion.Checked,chkOlives.Checked,chkGreenPapers.Checked};

            lbTopping.Text = "";

            byte WordsCounter = 0;

            for (byte i = 0; i < 6; i++)
            {

                if (Choices[i] == true)
                {

                    if (WordsCounter > 0)
                    {
                        lbTopping.Text += ", ";

                    }

                    if (WordsCounter == 3)
                    {
                        lbTopping.Text += "\n  ";
                    }

                    lbTopping.Text += strToppings[i];
                    WordsCounter++;

                }
            }

            if (lbTopping.Text == "")
            {
                lbTopping.Text = "No Toppings";
            }


        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = " Size : Small";

            if (rbSmall.Checked == true)
                Price += 5;
            if (rbSmall.Checked == false)
                Price -= 5;


            lbToTalPrice.Text = "$ " + Price;
        }

        private void rbMeduem_CheckedChanged_1(object sender, EventArgs e)
        {
            lbSize.Text = " Size : Meduim";
            if (rbMeduem.Checked == true)
                Price += 10;
            if (rbMeduem.Checked == false)
                Price -= 10;


            lbToTalPrice.Text = "$ " + Price;
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = " Size : Large";
            if (rbLarge.Checked == true)
                Price += 20;
            if (rbLarge.Checked == false)
                Price -= 20;


            lbToTalPrice.Text = "$ " + Price;
        }

      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = "Crust Type : Thin ";

            if (rbThinCrust.Checked == true)
                Price += 10;
            if (rbThinCrust.Checked == false)
                Price -= 10;


            lbToTalPrice.Text = "$ " + Price;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = "Crust Type : Thick ";

            if (rbThickCrust.Checked == true)
                Price += 20;
            if (rbThickCrust.Checked == false)
                Price -= 20;


            lbToTalPrice.Text = "$ " + Price;
        }

        private void chkMoreChees_CheckedChanged(object sender, EventArgs e)
        {



            if (chkMoreChees.Checked == true)
            {
                ShowToppingChoices();

                Price += 10;
                lbToTalPrice.Text = "$ " + Price;
            }
            else
            {
                ShowToppingChoices();

                Price -= 10;
                lbToTalPrice.Text = "$ " + Price;
            }

          

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked == true)
            {
                ShowToppingChoices();

                Price += 10;
                lbToTalPrice.Text = "$ " + Price;
            }
            else
            {
                ShowToppingChoices();

                Price -= 10;
                lbToTalPrice.Text = "$ " + Price;
            }
        }

        private void chkTomateos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomateos.Checked == true)
            {
                ShowToppingChoices();

                Price += 10;
                lbToTalPrice.Text = "$ " + Price;
            }
            else
            {
                ShowToppingChoices();

                Price -= 10;
                lbToTalPrice.Text = "$ " + Price;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked == true)
            {
                ShowToppingChoices();

                Price += 10;
                lbToTalPrice.Text = "$ " + Price;
            }
            else
            {
                ShowToppingChoices();

                Price -= 10;
                lbToTalPrice.Text = "$ " + Price;
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked == true)
            {
                ShowToppingChoices();

                Price += 10;
                lbToTalPrice.Text = "$ " + Price;
            }
            else
            {
                ShowToppingChoices();

                Price -= 10;
                lbToTalPrice.Text = "$ " + Price;
            }
        }

        private void chkGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPapers.Checked == true)
            {
                ShowToppingChoices();

                Price += 10;
                lbToTalPrice.Text = "$ " + Price;
            }
            else
            {
                ShowToppingChoices();

                Price -= 10;
                lbToTalPrice.Text = "$ " + Price;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbWherToEat.Text = " WHer To Eat : Eat In ";

            if (rbEatIn.Checked == true)
                Price += 10;
            if (rbEatIn.Checked == false)
                Price -= 10;


            lbToTalPrice.Text = "$ " + Price;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWherToEat.Text = " WHer To Eat : TAke Out ";

            if (rbTakeOut.Checked == true)
                Price += 20;
            if (rbTakeOut.Checked == false)
                Price -= 20;


            lbToTalPrice.Text = "$ " + Price;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show(" Confirme Order !", "Confirme ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbPizzaSizeBox.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhearToEat.Enabled = false;
                gbTopping.Enabled = false;
                btnConfirmOrder.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            rbSmall.Checked = false;
            rbMeduem.Checked = false;
            rbLarge.Checked = false;

            chkMoreChees.Checked = false;
            chkMushrooms.Checked = false;
            chkOnion.Checked = false;
            chkTomateos.Checked = false;
            chkGreenPapers.Checked = false;
            chkOlives.Checked = false;

            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;

            rbThinCrust.Checked = false;
            rbThickCrust.Checked = false;

            gbPizzaSizeBox.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhearToEat.Enabled = true;
            gbTopping.Enabled = true;
            btnConfirmOrder.Enabled = true;

            lbCrustType.Text = " Crust Type : ";
            lbSize.Text = " Size : ";
            lbTopping.Text = " No Toppings. ";
            lbWherToEat.Text = " Where To Eat : ";
        }

        private void lbToTalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
