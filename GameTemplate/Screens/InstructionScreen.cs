//Tyler Tucker
//Instruction Screen
//Gives the user instructions



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate.Screens
{
    public partial class InstructionScreen : UserControl
    {
        Font drawFont = new Font("Arial", 16, FontStyle.Bold);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        public InstructionScreen()
        {
            InitializeComponent();
        }

        private void inTimer_Tick(object sender, EventArgs e)
        {
            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
        }

        private void InstructionScreen_Paint(object sender, PaintEventArgs e)     //displays instructions
        {
            e.Graphics.DrawString("Bricks will flow across the screen, \nwhen you hit the green button(or space bar) \n the brick will stop, \nyour goal is to stack all the bricks", drawFont, drawBrush, 9, 80);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
        }
    }
}
