//Tyler Tucker
//Prizes Screen
//Shows what prizes the user had won

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameTemplate.Screens
{

    public partial class ScoreScreen : UserControl
    {
        SolidBrush Brush = new SolidBrush(Color.SaddleBrown);
        Random prizeNum = new Random();
        int pause = 100;

        SoundPlayer roll = new SoundPlayer(Properties.Resources.Roll);

        public ScoreScreen()
        {
            InitializeComponent();
            ScreenControl.setComponentValues(this);
        }

        private void prizeTick_Tick(object sender, EventArgs e)
        {
            prizesLeftS.Text = "Small Prizes Left: " + Class1.sPrizesWon;
            prizeLeftB.Text = "Big Prizes Left: " + Class1.bPrizesWon;

            prizesUnlock(Class1.smallP1, sPrizeBox4, GameTemplate.Properties.Resources.sPrize4);     //desplays prizes
            prizesUnlock(Class1.smallP2, sPrizeBox1, GameTemplate.Properties.Resources.sPrize1);
            prizesUnlock(Class1.smallP3, sPrizeBox2, GameTemplate.Properties.Resources.sPrize2);
            prizesUnlock(Class1.smallP4, sPrizeBox3, GameTemplate.Properties.Resources.sPrize3);

            prizesUnlock(Class1.bigP1, bPrizeBox4, GameTemplate.Properties.Resources.bPrize4);
            prizesUnlock(Class1.bigP2, bPrizeBox1, GameTemplate.Properties.Resources.bPrize1);
            prizesUnlock(Class1.bigP3, bPrizeBox2, GameTemplate.Properties.Resources.bPrize2);
            prizesUnlock(Class1.bigP4, bPrizeBox3, GameTemplate.Properties.Resources.bPrize3);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }

        private void prizeButton_Click(object sender, EventArgs e)
        {      
            if (Class1.winSmall == true)
            {
                roll.Play();
                Class1.prize = prizeNum.Next(0, 4);
                Class1.sPrizesWon--;
                prizeButton.Visible = false;

                switch (Class1.prize)
                {
                    case 0:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.sPrize1;
                        prizeWon.Refresh();
                        Class1.smallP1 = true;
                        break;
                    case 1:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.sPrize2;
                        prizeWon.Refresh();
                        Class1.smallP2 = true;
                        break;
                    case 2:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.sPrize3;
                        prizeWon.Refresh();
                        Class1.smallP3 = true;
                        break;
                    case 3:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.sPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.sPrize4;
                        prizeWon.Refresh();
                        Class1.smallP4 = true;
                        break;

                }
                prizeButton.Visible = true;
            }      //if a small prize is won then the corissponding task will run
            else if (Class1.winBig == true)
            {
                Class1.bPrizesWon--;
                Class1.prize = prizeNum.Next(0, 4);
                prizeButton.Visible = false;
                roll.Play();

                switch (Class1.prize)
                {
                    case 0:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.bPrize1;
                        prizeWon.Refresh();
                        Class1.bigP1 = true;
                        break;
                    case 1:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.bPrize2;
                        prizeWon.Refresh();
                        Class1.bigP2 = true;
                        break;
                    case 2:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.bPrize3;
                        prizeWon.Refresh();
                        Class1.bigP3 = true;
                        break;
                    case 3:
                        for (int i = 1; i <= 6; i++)
                        {
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize4;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize1;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize2;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                            prizeWon.Image = GameTemplate.Properties.Resources.bPrize3;
                            prizeWon.Refresh();
                            Thread.Sleep(pause);
                        }
                        prizeWon.BackgroundImage = GameTemplate.Properties.Resources.bPrize4;
                        prizeWon.Refresh();
                        Class1.bigP4 = true;
                        break;
                }
                prizeButton.Visible = true;
            }    // if a big prize is won the corrisponding task will run

            if (Class1.sPrizesWon <= 0)
            {
                Class1.winSmall = false;
            }

            if (Class1.bPrizesWon <= 0)
            {
                Class1.winBig = false;
            }
        }

        public void prizesUnlock(bool prize, PictureBox prizeBox, Image prizeImage)
        {
            if (prize == true)
            {
                prizeBox.BackgroundImage = prizeImage;
                prizeBox.Refresh();
            }
        }   //method to desplay prizes


            private void ScoreScreen_Paint(object sender, PaintEventArgs e)
            { 

            }

    }
}
