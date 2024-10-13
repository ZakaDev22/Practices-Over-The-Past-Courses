using C____Tic_Tac_Toe_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C____Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        enum enPlayerChoice { player1 = 1, player2 = 2 }

        enPlayerChoice PlayerChoice = enPlayerChoice.player1;

        bool count1, count2, count3, count4, count5, count6, count7, count8, count9;

        bool Win1, Win2;

        string Player1, Player2;

          void isPlayer1Win()
        {
           if(Player1 == "123" || Player1 == "321" || Player1 == "312" || Player1 == "213" || Player1 == "132" || Player1 == "147" || Player1 == "741" || Player1 == "417" || Player1 == "471" ||
               Player1 == "159" || Player1 == "951" || Player1 == "519" || Player1 == "591" || Player1 == "798" )
            {
                Win1 = true;
            }

            if (Player1 == "258" || Player1 == "852" || Player1 == "528" || Player1 == "582" || Player1 == "369" || Player1 == "963" || Player1 == "639" || Player1 == "693" ||
               Player1 == "456" || Player1 == "654" || Player1 == "546" || Player1 == "564" || Player1 == "465")
                Win1 = true;

            if (Player1 == "789" || Player1 == "987" || Player1 == "879" || Player1 == "897" ||
                Player1 == "357" || Player1 == "375" || Player1 == "753" || Player1 == "537" || Player1 == "573" || Player1 == "753")
                Win1 = true;
        }

        void isPlayer2Win()
        {
            if (Player2 == "123"  || Player2 == "312"|| Player2 == "321" || Player2 == "213" || Player2 == "132" || Player2 == "147" || Player2 == "741" || Player2 == "417" || Player2 == "471" ||
                Player2 == "159" || Player2 == "951" || Player2 == "519" || Player2 == "591" || Player2 == "798")
            {
                Win2 = true;
            }

            if (Player2 == "258" || Player2 == "852" || Player2 == "528" || Player2 == "582" || Player2 == "369" || Player2 == "963" || Player2 == "639" || Player2 == "693" ||
               Player2 == "456" || Player2 == "654" || Player2 == "546" || Player2 == "564" || Player2 == "465")
                Win2 = true;


            if (Player2 == "789" || Player2 == "987" || Player2 == "879" || Player2 == "897" ||
               Player2 == "357" || Player2 == "375" || Player2 == "753" || Player2 == "537" || Player2 == "573" || Player2 == "735")
                Win2 = true;

        }

        void TheWinner()
        {
            if (Win1 == true)
            {
                pbWinnerPic.Image = Resources.win5;
                MessageBox.Show(" Player 1 Win The Game,\n\n Refresh the Game With Restart Button To Play Again.", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Win2 == true)
            {
                pbWinnerPic.Image = Resources.win6;
                MessageBox.Show(" Player 2 Win The Game,\n\n Refresh the Game With Restart Button To Play Again.", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }


        void PrintLabelTurn()
        {

            if (PlayerChoice == enPlayerChoice.player1)
                pbTurns.Image = Resources.Player1;
            else
                pbTurns.Image = Resources.Player2;
        }

        void ReplacePlayerTurns()
        {

            if (PlayerChoice == enPlayerChoice.player1)
                PlayerChoice = enPlayerChoice.player2;
            else
                PlayerChoice = enPlayerChoice.player1;
        }

        void ShowGameOver()
        {
            if (Win1 == true || Win2 == true)
                return;

            if((count1==true)&& (count2==true) && (count3 == true) && (count4 == true)
                && (count5 == true) && (count6 == true) && (count7 == true) && (count8 == true) && (count9 == true))
            {
                pbWinnerPic.Image = Resources.Draw;
                MessageBox.Show(" No Winner, Game Over !,\n\n Refresh the Game With Restart Button To Play Again.", " Game End", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void Form_Paint(object sender, PaintEventArgs e)
        {

            //Color white = Color.FromArgb(255, 255, 255, 255);
            //Pen whitePen = new Pen(white);
            //whitePen.Width = 15;
            ////whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            //whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            //whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            ////draw Horizental lines
            //e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            //e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            ////draw Vertical lines
            //e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            //e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);

        }

        private void pb1_Click(object sender, EventArgs e)
        {

            if (Win1 == true || Win2 == true)
                return;

            if (count1 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrintLabelTurn();

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb1.Image = Resources.tic_tac_x1;
                Player1 += pb1.Tag.ToString();
            }

            else
            {
                pb1.Image = Resources.tic_tac_o1;
                Player2 += pb1.Tag.ToString();
            }

            count1 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();


        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count2 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb2.Image = Resources.tic_tac_x1;
                Player1 += pb2.Tag.ToString();
            }

            else
            {
                pb2.Image = Resources.tic_tac_o1;
                Player2 += pb2.Tag.ToString();
            }

            count2 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count3 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb3.Image = Resources.tic_tac_x1;
                Player1 += pb3.Tag.ToString();
            }

            else
            {
                pb3.Image = Resources.tic_tac_o1;
                Player2 += pb3.Tag.ToString();
            }

            count3 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count4 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb4.Image = Resources.tic_tac_x1;
                Player1 += pb4.Tag.ToString();
            }

            else
            {
                pb4.Image = Resources.tic_tac_o1;
                Player2 += pb4.Tag.ToString();
            }

            count4 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count5 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb5.Image = Resources.tic_tac_x1;
                Player1 += pb5.Tag.ToString();
            }

            else
            {
                pb5.Image = Resources.tic_tac_o1;
                Player2 += pb5.Tag.ToString();
            }

            count5 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count6 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb6.Image = Resources.tic_tac_x1;
                Player1 += pb6.Tag.ToString();
            }

            else
            {
                pb6.Image = Resources.tic_tac_o1;
                Player2 += pb6.Tag.ToString();
            }

            count6 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count7 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb7.Image = Resources.tic_tac_x1;
                Player1 += pb7.Tag.ToString();
            }

            else
            {
                pb7.Image = Resources.tic_tac_o1;
                Player2 += pb7.Tag.ToString();
            }

            count7 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count8 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb8.Image = Resources.tic_tac_x1;
                Player1 += pb8.Tag.ToString();
            }

            else
            {
                pb8.Image = Resources.tic_tac_o1;
                Player2 += pb8.Tag.ToString();
            }

            count8 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();
            
            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (Win1 == true || Win2 == true)
                return;

            if (count9 == true)
            {
                MessageBox.Show(" Wrong Choice !", " Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PlayerChoice == enPlayerChoice.player1)
            {
                pb9.Image = Resources.tic_tac_x1;
                Player1 += pb9.Tag.ToString();
            }

            else
            {
                pb9.Image = Resources.tic_tac_o1;
                Player2 += pb9.Tag.ToString();
            }

            count9 = true;

            isPlayer1Win();
            isPlayer2Win();
            TheWinner();

            ReplacePlayerTurns();
            PrintLabelTurn();

            ShowGameOver();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Player1 = "";
            Player2 = "";
            Win1 = false;
            Win2 = false;

            pb1.Image = Resources.QuestionMark;
            pb2.Image = Resources.QuestionMark;
            pb3.Image = Resources.QuestionMark;
            pb4.Image = Resources.QuestionMark;
            pb5.Image = Resources.QuestionMark;
            pb6.Image = Resources.QuestionMark;
            pb7.Image = Resources.QuestionMark;
            pb8.Image = Resources.QuestionMark;
            pb9.Image = Resources.QuestionMark;

            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
            count6 = false;
            count7 = false;
            count8 = false;
            count9 = false;

            PlayerChoice = enPlayerChoice.player1 ;

            pbTurns.Image = Resources.Player1;
            pbWinnerPic.Image = Resources.Progress3;
        }

    }
}
