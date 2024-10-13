using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Wolf_V1._0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int TotalPrice = 0;
        byte Scount = 0;
        byte Mcount = 0;
        byte Fcount = 0;
        byte Dcount = 0;
        bool bOrder = false;
        bool bReset = false;

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            pnSideBare.Height = btnMainCourse.Height;
            pnSideBare.Top = btnMainCourse.Top;

         
            gbFruitVegtables.Enabled = false;
            gbMainMeals.Enabled = true;
            gbDrinks.Enabled = false;
            gbSnacks.Enabled = false;
            gbSeaFood.Enabled = true;
            gbVegeterainFood.Enabled = true;
        }

        private void btnFruitEndVeg_Click(object sender, EventArgs e)
        {
            pnSideBare.Height = btnFruitEndVeg.Height;
            pnSideBare.Top = btnFruitEndVeg.Top;

            gbFruitVegtables.Enabled = true;
            gbMainMeals.Enabled = false;
            gbDrinks.Enabled = false;
            gbSnacks.Enabled = false;
            gbSeaFood.Enabled = false;
            gbVegeterainFood.Enabled = false;

        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            pnSideBare.Height = btnSnacks.Height;
            pnSideBare.Top = btnSnacks.Top;

            gbFruitVegtables.Enabled = false;
            gbMainMeals.Enabled = false;
            gbDrinks.Enabled = false;
            gbSnacks.Enabled = true;
            gbSeaFood.Enabled = false;
            gbVegeterainFood.Enabled = false;
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            pnSideBare.Height = btnDrinks.Height;
            pnSideBare.Top = btnDrinks.Top;

            gbFruitVegtables.Enabled = false;
            gbMainMeals.Enabled = false;
            gbDrinks.Enabled = true;
            gbSnacks.Enabled = false;
            gbSeaFood.Enabled = false;
            gbVegeterainFood.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString();

            gbFruitVegtables.Enabled = false;
            gbDrinks.Enabled = false;
            gbSnacks.Enabled = false;
        }

        private void pnMainCourse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

       private void UpdateMealse()
        {
            if (Mcount == 6)
            {

                MessageBox.Show("You Can Order Only 3 Meals.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sMeals = "";
           
            lbMeals.Text = "";

            if (chkChekenNugets.Checked)
            {

                sMeals = ",Cheken Nuggets";
                lbMeals.Text += sMeals;
                Mcount++;

            }
           

            if (chkHotDog.Checked)
            {
               
                sMeals = ",HOT DOG";
                lbMeals.Text += sMeals;
                Mcount++;
             
            }


            if (chkSandwitch.Checked)
            {
               
                sMeals = ",Sandwitch";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkPastaSalade.Checked)
            {
               
                sMeals = ",Pasta Salade";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkSpaggetti.Checked)
            {
               
               
                sMeals = ",SPAGGETTI";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkStake.Checked)
            {
               
                sMeals = ",STAKE";
                lbMeals.Text += sMeals;
                Mcount++;
              
            }

            if (chkPizza.Checked)
            {
              
                sMeals = ",PIZZA";
                lbMeals.Text += sMeals;
                Mcount++;
              
            }

            if (chkBurger.Checked)
            {
              
                sMeals = ",Burger";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkOctopus.Checked)
            {
               
                sMeals = ",OCTOPUS";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkSalamon.Checked)
            {
               
                sMeals = ",SALAMON";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkShrimps.Checked)
            {
               
                sMeals = ",SHRIMPS";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkLopster.Checked)
            {
               
                sMeals = ",LOPSTER";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkCoconutSoup.Checked)
            {
               
                sMeals = ",COCONUT SOUP";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkSaladeMix.Checked)
            {
                
                sMeals = ",SALADE MIX";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (chkTajine.Checked)
            {
               
                sMeals = ",TAJINE";
                lbMeals.Text += sMeals;
                Mcount++;
              
            }

            if (chkCoscous.Checked)
            {
              
                sMeals = ",COUSCOUSE";
                lbMeals.Text += sMeals;
                Mcount++;
               
            }

            if (lbMeals.Text.StartsWith(","))
                lbMeals.Text = lbMeals.Text.Substring(1, lbMeals.Text.Length - 1).Trim();

        }

       private void UpdateSnacks()
        {
            if (Scount == 1)
            {
                MessageBox.Show("You Can Order Only 1 Snacks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sSnacks = "";
           
            lbSnacks.Text = "";

            if(chkPanCake.Checked)
            {
                sSnacks = ",PanCake";
                lbSnacks.Text += sSnacks;
                Scount++;
            }
            if (chkIceCreem.Checked)
            {
               
                sSnacks = ",IceCreem";
                lbSnacks.Text += sSnacks;
                Scount++;
            }
            if (chkYogurt.Checked)
            {
               
                sSnacks = ",Yougurt";
                lbSnacks.Text += sSnacks;
                Scount++;
            }
            if (chkCheeseDips.Checked)
            {
            
                sSnacks = ",CheeseDips";
                lbSnacks.Text += sSnacks;
                Scount++;
            }

            if (lbSnacks.Text.StartsWith(","))
                lbSnacks.Text = lbSnacks.Text.Substring(1, lbSnacks.Text.Length - 1);
        }

        private void UpdateDrinks()
        {
            

            if (Dcount > 1)
            {
                MessageBox.Show("You Can Order Only 1 Drink.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sDrink = "";

            lbDrinks.Text = "";

            if (chkTea.Checked)
            {
                if (Dcount >= 1)
                {
                    return;
                }

                sDrink = ",TEA";
                lbDrinks.Text += sDrink;
                Dcount++;
            }
            if (chkCoffee.Checked)
            {
                if (Dcount >= 1)
                {
                    return;
                }

                sDrink = ",COFFEE";
                lbDrinks.Text += sDrink;
                Dcount++;
            }
            if (chkJuise.Checked)
            {
                if (Dcount >= 1)
                {
                    return;
                }

                sDrink = ",JUISE";
                lbDrinks.Text += sDrink;
                Dcount++;
            }
            if (chkMilkShake.Checked)
            {
                if (Dcount >= 1)
                {
                    return;
                }

                sDrink = ",MILK SHAKE";
                lbDrinks.Text += sDrink;
                Dcount++;
            }

            if (lbDrinks.Text.StartsWith(","))
                lbDrinks.Text = lbDrinks.Text.Substring(1, lbDrinks.Text.Length - 1);
        }

        private void UpdateFruitVeg()
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                lbSize.Text = "Small";
                TotalPrice += Convert.ToInt32(rbSmall.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(rbSmall.Tag);
            }

                    
        }

        private void rbMeduem_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMeduem.Checked)
            {
                lbSize.Text = "Medium";
                TotalPrice += Convert.ToInt32(rbMeduem.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(rbMeduem.Tag);
            }

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                lbSize.Text = "Large";
                TotalPrice += Convert.ToInt32(rbLarge.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(rbLarge.Tag);
            }

           
        }

        // calculate choosing meals. =================================================================      fix total Price problem :-)
        private void chkChekenNugets_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChekenNugets.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkChekenNugets.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }

            if (Mcount >= 6)
            {
                chkChekenNugets.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkChekenNugets.Checked)
            {
                TotalPrice += Convert.ToInt32(chkChekenNugets.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkChekenNugets.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkHotDog_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkHotDog.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkHotDog.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6) {
                chkHotDog.Checked = false;
                return;
                }

            UpdateMealse();
           
            if (chkHotDog.Checked)
            {
                TotalPrice += Convert.ToInt32(chkHotDog.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkHotDog.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkSandwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSandwitch.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkSandwitch.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkSandwitch.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkSandwitch.Checked)
            {
                TotalPrice += Convert.ToInt32(chkSandwitch.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkSandwitch.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkPastaSalade_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPastaSalade.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkPastaSalade.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkPastaSalade.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkPastaSalade.Checked)
            {
                TotalPrice += Convert.ToInt32(chkPastaSalade.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkPastaSalade.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkSpaggetti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpaggetti.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkSpaggetti.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkSpaggetti.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkSpaggetti.Checked)
            {
                TotalPrice += Convert.ToInt32(chkSpaggetti.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkSpaggetti.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkStake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStake.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkStake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkStake.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkStake.Checked)
            {
                TotalPrice += Convert.ToInt32(chkStake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkStake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPizza.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkPizza.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkPizza.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkPizza.Checked)
            {
                TotalPrice += Convert.ToInt32(chkPizza.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkPizza.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurger.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkBurger.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkBurger.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkBurger.Checked)
            {
                TotalPrice += Convert.ToInt32(chkBurger.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkBurger.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkOctopus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOctopus.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkOctopus.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkOctopus.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkOctopus.Checked)
            {
                TotalPrice += Convert.ToInt32(chkOctopus.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkOctopus.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkSalamon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalamon.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkSpaggetti.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkSalamon.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkSalamon.Checked)
            {
                TotalPrice += Convert.ToInt32(chkSpaggetti.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkSpaggetti.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkShrimps_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShrimps.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkShrimps.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkShrimps.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkShrimps.Checked)
            {
                TotalPrice += Convert.ToInt32(chkShrimps.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkShrimps.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkLopster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLopster.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkLopster.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkLopster.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkLopster.Checked)
            {
                TotalPrice += Convert.ToInt32(chkLopster.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkLopster.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkCoconutSoup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoconutSoup.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkCoconutSoup.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkCoconutSoup.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkCoconutSoup.Checked)
            {
                TotalPrice += Convert.ToInt32(chkCoconutSoup.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkCoconutSoup.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkSaladeMix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaladeMix.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkSaladeMix.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkSaladeMix.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkSaladeMix.Checked)
            {
                TotalPrice += Convert.ToInt32(chkSaladeMix.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkSaladeMix.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkTajine_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTajine.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkTajine.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }


            if (Mcount >= 6)
            {
                chkTajine.Checked = false;
                return;
            }
            UpdateMealse();
            if (chkTajine.Checked)
            {
                TotalPrice += Convert.ToInt32(chkTajine.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkTajine.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkCoscous_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoscous.Checked == false)
            {
                TotalPrice -= Convert.ToInt32(chkCoscous.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
                return;
            }
            
 
            if (Mcount >= 6)
            {
                chkCoscous.Checked = false;
                return;
            }

            UpdateMealse();
            if (chkCoscous.Checked)
            {
                TotalPrice += Convert.ToInt32(chkCoscous.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkCoscous.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        // Snacks =====================================================================
        private void chkPanCake_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSnacks();
            if (chkPanCake.Checked)
            {
                if (Scount == 1)
                    return;
                TotalPrice += Convert.ToInt32(chkPanCake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Scount == 1)
                    return;
                TotalPrice -= Convert.ToInt32(chkPanCake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkIceCreem_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSnacks();
            if (chkIceCreem.Checked)
            {
                if (Scount == 1)
                    return;
                TotalPrice += Convert.ToInt32(chkIceCreem.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Scount == 1)
                    return;
                TotalPrice -= Convert.ToInt32(chkIceCreem.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkYogurt_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSnacks();
            if (chkYogurt.Checked)
            {
                if (Scount == 1)
                    return;
                TotalPrice += Convert.ToInt32(chkYogurt.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Scount == 1)
                    return;
                TotalPrice -= Convert.ToInt32(chkYogurt.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkCheeseDips_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSnacks();
            if (chkCheeseDips.Checked)
            {
                if (Scount == 1)
                    return;
                TotalPrice += Convert.ToInt32(chkCheeseDips.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Scount == 1)
                    return;
                TotalPrice -= Convert.ToInt32(chkCheeseDips.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        //==============================================================================================
        private void chkstrawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (chkstrawberry.Checked)
            {
                TotalPrice += Convert.ToInt32(chkstrawberry.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkstrawberry.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkdragonfruit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdragonfruit.Checked)
            {
                TotalPrice += Convert.ToInt32(chkdragonfruit.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkdragonfruit.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkCarrot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarrot.Checked)
            {
                TotalPrice += Convert.ToInt32(chkCarrot.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkCarrot.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkPotatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotatoes.Checked)
            {
                TotalPrice += Convert.ToInt32(chkPotatoes.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkPotatoes.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        //======================================================================================================
        private void chkTea_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDrinks();
            if (chkTea.Checked)
            {
                if (Dcount >= 2 )
                {
                    chkTea.Checked = false;
                    return;
                }
                TotalPrice += Convert.ToInt32(chkTea.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Dcount >= 2)
                {
                    chkTea.Checked = false;
                    return;
                }
                TotalPrice -= Convert.ToInt32(chkTea.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
         }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDrinks();
            if (chkCoffee.Checked)
            {
                if (Dcount >= 2)
                {
                    chkCoffee.Checked = false;
                    return;
                }
                TotalPrice += Convert.ToInt32(chkCoffee.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Dcount >= 2)
                {
                    chkCoffee.Checked = false;
                    return;
                }
                TotalPrice -= Convert.ToInt32(chkCoffee.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkJuise_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDrinks();
            if (chkJuise.Checked)
            {
                if (Dcount >= 2)
                {
                    chkJuise.Checked = false;
                    return;
                }
                TotalPrice += Convert.ToInt32(chkJuise.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Dcount >= 2)
                {
                    chkJuise.Checked = false;
                    return;
                }
                TotalPrice -= Convert.ToInt32(chkJuise.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void chkMilkShake_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDrinks();
            if (chkMilkShake.Checked)
            {
                if (Dcount >= 2)
                {
                    chkMilkShake.Checked = false;
                    return;
                }
                TotalPrice += Convert.ToInt32(chkMilkShake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
            else
            {
                if (Dcount >= 2)
                {
                    chkMilkShake.Checked = false;
                    return;
                }
                TotalPrice -= Convert.ToInt32(chkMilkShake.Tag);
                lbTotalPrise.Text = TotalPrice + "$";
            }
        }

        private void sHowNumaricUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ToTal Bills = " + TotalPrice + "$", "Pay With USD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ToTal Bills = " + (TotalPrice * 10) + " DIRHAM", "Pay With MAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(bOrder)
            {
                MessageBox.Show("You Already Take Your Order \n Click Reset Button.", "Warning SCREEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("ORDER DONE SUCCUSSFULLY.\nClick Reset to Perform Another Order.", "ORDER SCREEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbMainMeals.Enabled = false;
            gbSeaFood.Enabled = false;
            gbVegeterainFood.Enabled = false;
            gbSize.Enabled = false;
            gbSnacks.Enabled = false;
            gbFruitVegtables.Enabled = false;
            gbDrinks.Enabled = false;
          
            btnMainCourse.Enabled = false;
            btnSnacks.Enabled = false;
            btnDrinks.Enabled = false;
            btnFruitEndVeg.Enabled = false;

            bOrder = true;
            bReset = false;
        }

        private void paySuccissfullyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bReset)
            {
                MessageBox.Show("You Already Reset Order Menue \n Click Order Button.", "Warning SCREEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Reset Order SUCCUSSFULLY.\nMake Your Order.", "Reset SCREEN", MessageBoxButtons.OK, MessageBoxIcon.Information);


            rbSmall.Checked = false; rbMeduem.Checked = false;rbLarge.Checked = false;

            chkChekenNugets.Checked = false; chkHotDog.Checked = false; chkSandwitch.Checked = false; chkPastaSalade.Checked = false; chkSpaggetti.Checked = false;
            chkBurger.Checked = false; chkCarrot.Checked = false; chkHotDog.Checked = false; chkStake.Checked = false; chkPizza.Checked = false;
            chkShrimps.Checked = false; chkOctopus.Checked = false; chkSalamon.Checked = false; chkLopster.Checked = false; chkTajine.Checked = false;
            chkCoscous.Checked = false; chkSaladeMix.Checked = false; chkCoconutSoup.Checked = false;
            chkPanCake.Checked = false; chkIceCreem.Checked = false; chkYogurt.Checked = false; chkCheeseDips.Checked = false;
            chkstrawberry.Checked = false; chkCarrot.Checked = false; chkdragonfruit.Checked = false; chkPotatoes.Checked = false;
            chkTea.Checked = false; chkCoffee.Checked = false; chkMilkShake.Checked = false; chkJuise.Checked = false;


            gbMainMeals.Enabled = true;
            gbSeaFood.Enabled = true;
            gbVegeterainFood.Enabled = true;
            gbSize.Enabled = true;
            gbSnacks.Enabled = true;
            gbFruitVegtables.Enabled = true;
            gbDrinks.Enabled = true;

            btnMainCourse.Enabled = true;
            btnSnacks.Enabled = true;
            btnDrinks.Enabled = true;
            btnFruitEndVeg.Enabled = true;

            lbMeals.Text = "Unknown..";
            lbSize.Text = "Unknown..";
            lbFruitVeg.Text = "Unknown..";
            lbDrinks.Text = "Unknown..";
            lbSnacks.Text = "Unknown..";

            Scount = 0;
            TotalPrice = 0;
            lbTotalPrise.Text = "0$";

            bOrder = false;
            bReset = true;
        }
    }

}