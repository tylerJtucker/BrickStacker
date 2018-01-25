//Tyler Tucker
//Game Screen
//User plays the game

using GameTemplate.Dialogs;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            loseLabel.Visible = false;
            winSLabel.Visible = false;
            winBLabel.Visible = false;
        }

        #region required global values - DO NOT CHANGE

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        #endregion

        //TODO - Place game global variables here 
        //---------------------------------------

        SoundPlayer spaceBar = new SoundPlayer(Properties.Resources.Button);     //Creates all the sounds needed for this screen
        SoundPlayer win = new SoundPlayer(Properties.Resources.Win);
        SoundPlayer lose = new SoundPlayer(Properties.Resources.Lose);
        SoundPlayer winS = new SoundPlayer(Properties.Resources.winS);


        const int BH = 70;   //creates all constants needed for this screen
        const int SPEED1 = 400;
        const int SIZEMOVE = 60;
        const int BIG_WIDTH = 200;
        const int SMALL_WIDTH = 140;
        const int TINY_WIDTH = 80;

        int[] levelY = { 580, 510, 440, 370, 300, 230, 160, 90, 20 };   //an arrey of all the blocks Y positons

        int xR1, xR2, xR3, xR4, xR5, xR6, xR7, xR8, xR9 = 0;     //9 variables all initlized to 0

        int level = 0;             // variable to track the level
        Boolean hitR = false;     //boolean to check to see if the brick has hit the right side

        //Graphics objects
        Font drawFont = new Font("Arial", 16, FontStyle.Bold);     //brushes and fonts needed

        SolidBrush BrushL = new SolidBrush(Color.DarkBlue);

        SolidBrush BrushL1 = new SolidBrush(Color.Cyan);
        SolidBrush BrushL2 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL3 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL4 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL5 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL6 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL7 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL8 = new SolidBrush(Color.DarkBlue);
        SolidBrush BrushL9 = new SolidBrush(Color.DarkBlue);

        Pen PenWhite = new Pen(Color.White);

        private void stopTimer_Tick(object sender, EventArgs e)    //a timer which checks to see if space bar is pressed, then does the corisponding task
        {
            switch (level)
            {
                case 0:
                    if (spaceDown == true)
                    {
                        level++;
                        spaceDown = false;
                        BrushL2.Color = Color.Cyan;
                        spaceBar.Play();
                    }
                    break;
                case 1:
                    if (spaceDown == true)
                    {
                        level++;
                        spaceDown = false;
                        BrushL3.Color = Color.Cyan;
                        spaceBar.Play();
                        CheckStack(xR1, xR2, BrushL3, level);
                        
                    }
                    break;
                case 2:
                    if (spaceDown == true)
                    {
                        level++;
                        spaceDown = false;
                        BrushL4.Color = Color.Cyan;
                        spaceBar.Play();
                        CheckStack(xR2, xR3, BrushL4, level);
                    }
                    break;
                case 3:
                    if (spaceDown == true)
                    {
                        level++;
                        spaceDown = false;
                        BrushL5.Color = Color.Cyan;
                        spaceBar.Play();
                        gameTimer.Interval = 100;
                        CheckStack(xR3, xR4, BrushL5, level);
                    }
                    break;
                case 4:
                    if (spaceDown == true)
                    {
                        spaceBar.Play();
                        level++;
                        spaceDown = false;
                        BrushL6.Color = Color.Cyan;
                        CheckStack(xR4, xR5, BrushL6, level);
                    }

                    break;
                case 5:
                    if (spaceDown == true)
                    {
                        spaceBar.Play();
                        level++;
                        spaceDown = false;
                        BrushL7.Color = Color.Cyan;
                        CheckStack(xR5, xR6, BrushL7, level);
                    }
                    break;
                case 6:
                    if (spaceDown == true)
                    {
                        spaceBar.Play();
                        level++;
                        spaceDown = false;
                        BrushL8.Color = Color.Cyan;
                        gameTimer.Interval = 50;
                        CheckStack(xR6, xR7, BrushL8, level);

                    }
                    break;
                case 7:
                    if (spaceDown == true)
                    {
                        level ++;
                        spaceDown = false;
                        BrushL9.Color = Color.Cyan;
                        spaceBar.Play();
                        CheckStack(xR7, xR8, BrushL9, level);
                    }
                    break;
                case 8:
                    if (spaceDown == true)
                    {
                        level++;
                        spaceBar.Play();
                        spaceDown = false;
                        if (xR9 < xR8 || xR9 + TINY_WIDTH > xR8 + TINY_WIDTH)
                        {
                            winSLabel.Visible = true;
                            Class1.winSmall = true;
                            Class1.sPrizesWon++;

                            Refresh();
                            winS.PlaySync();

                            ScreenControl.changeScreen(this, "ScoreScreen");
                        }
                        else
                        {
                            win.Play();
                            winBLabel.Visible = true;
                            Class1.winBig = true;
                            Class1.bPrizesWon++;

                            Refresh();

                            Thread.Sleep(3000);
                            ScreenControl.changeScreen(this, "ScoreScreen");
                        }
                    }
                    break;
            }
        }
        //----------------------------------------

        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }

            //player 2 button presses
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.C:
                    cDown = true;
                    break;
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.X:
                    xDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;
                default:
                    break;
            }
        }     //checks if keys are down
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }

            //player 2 button releases
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;
                default:
                    break;
            }
        }     //checks if keys are relesed


        private void gameTimer_Tick(object sender, EventArgs e)  //ticks every 
        {
            //tells bricks where to go
            #region Row movements    
            switch (level)
            {
                case 0:
                    if (hitR == false)
                    {
                        xR1 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR1 -= SIZEMOVE;
                    }
                    break;
                case 1:
                    if (hitR == false)
                    {
                        xR2 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR2 -= SIZEMOVE;
                    }
                    break;
                case 2:
                    if (hitR == false)
                    {
                        xR3 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR3 -= SIZEMOVE;
                    }
                    break;
                case 3:
                    if (hitR == false)
                    {
                        xR4 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR4 -= SIZEMOVE;
                    }
                    break;
                case 4:
                    if (hitR == false)
                    {
                        xR5 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR5 -= SIZEMOVE;
                    }
                    break;
                case 5:
                    if (hitR == false)
                    {
                        xR6 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR6 -= SIZEMOVE;
                    }
                    break;
                case 6:
                    if (hitR == false)
                    {
                        xR7 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR7 -= SIZEMOVE;
                    }
                    break;
                case 7:
                    if (hitR == false)
                    {
                        xR8 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR8 -= SIZEMOVE;
                    }
                    break;
                case 8:
                    if (hitR == false)
                    {
                        xR9 += SIZEMOVE;
                    }

                    if (hitR == true)
                    {
                        xR9 -= SIZEMOVE;
                    }
                    break;
            }

            #endregion       

            //if brick hits wall the program knows
            #region collision detection

            if (level == 0)
            {
                Check_Collison(xR1, BIG_WIDTH);
            }
            if (level == 1)
            {
                Check_Collison(xR2, BIG_WIDTH);
            }
            if (level == 2)
            {
                Check_Collison(xR3, BIG_WIDTH);
            }
            if (level == 3)
            {
                Check_Collison(xR4, BIG_WIDTH);
            }
            if (level == 4)
            {
                Check_Collison(xR5, SMALL_WIDTH);
            }
            if (level == 5)
            {
                Check_Collison(xR6, SMALL_WIDTH);
            }
            if (level == 6)
            {
                Check_Collison(xR7, SMALL_WIDTH);
            }
            if (level == 7)
            {
                Check_Collison(xR8, TINY_WIDTH);
            }
            if (level == 8)
            {
                Check_Collison(xR9, TINY_WIDTH);
            }





            #endregion


            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
        }



        private void CheckStack(int previousx, int levelx, SolidBrush nextBrush, int level)
        {

            if (level <= 4)
            {
                if (levelx < previousx || levelx + BIG_WIDTH > previousx + BIG_WIDTH)
                {
                    loseLabel.Visible = true;
                    nextBrush.Color = Color.DarkBlue;

                    Refresh();
                    lose.PlaySync();

                    ScreenControl.changeScreen(this, "MenuScreen");
                }
            }

            else if (level == 5)
            {
                if (levelx < previousx || levelx + SMALL_WIDTH > previousx + BIG_WIDTH)
                {
                    loseLabel.Visible = true;
                    nextBrush.Color = Color.DarkBlue;

                    Refresh();
                    lose.PlaySync();

                    ScreenControl.changeScreen(this, "MenuScreen");
                }
            }

            else if (level == 6 || level == 7)
            {
                if (levelx < previousx || levelx + SMALL_WIDTH > previousx + SMALL_WIDTH)
                {
                    winSLabel.Visible = true;
                    Class1.winSmall = true;
                    Class1.sPrizesWon ++;
                    nextBrush.Color = Color.DarkBlue;

                    Refresh();
                    winS.PlaySync();

                    ScreenControl.changeScreen(this, "ScoreScreen");
                }
            }
            else if (level == 8)
            {
                if (levelx < previousx || levelx + TINY_WIDTH > previousx + SMALL_WIDTH)
                {
                    winSLabel.Visible = true;
                    Class1.winSmall = true;
                    Class1.sPrizesWon++;
                    nextBrush.Color = Color.DarkBlue;

                    Refresh();
                    winS.PlaySync();

                    ScreenControl.changeScreen(this, "ScoreScreen");
                }
            }



        }      //checks if the new brick lines up with the old brick and does the corrsispoding task

        private void Check_Collison(int levelx, int Width)
        {
            if (levelx >= this.Width - Width)
            {
                hitR = true;
            }

            if (levelx < SIZEMOVE)
            {
                hitR = false;
            }
            
        }  //method used to see if the bricks hit the wall

        private void pauseGame()
        {
            gameTimer.Enabled = false;
            rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

            DialogResult result = PauseDialog.Show();

            if (result == DialogResult.Cancel)
            {
                gameTimer.Enabled = true;
            }
            if (result == DialogResult.Abort)
            {
                ScreenControl.changeScreen(this, "MenuScreen");
            }
        }


        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw rectangles to screen
            e.Graphics.FillRectangle(BrushL1, xR1, levelY[0], BIG_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL2, xR2, levelY[1], BIG_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL3, xR3, levelY[2], BIG_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL4, xR4, levelY[3], BIG_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL5, xR5, levelY[4], SMALL_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL6, xR6, levelY[5], SMALL_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL7, xR7, levelY[6], SMALL_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL8, xR8, levelY[7], TINY_WIDTH, BH);
            e.Graphics.FillRectangle(BrushL9, xR9, levelY[8], TINY_WIDTH, BH);

            e.Graphics.DrawRectangle(PenWhite, 0, levelY[8], Width - 2, BH);
            e.Graphics.DrawRectangle(PenWhite, 0, levelY[4], Width - 2, BH);

            e.Graphics.DrawString("!BIG PRIZE!", drawFont, BrushL1, (Width / 2) - 60, levelY[8] + 25);
            e.Graphics.DrawString("!SMALL PRIZE!", drawFont, BrushL1, (Width / 2) - 80, levelY[4] + 25);
        }



    }
}
