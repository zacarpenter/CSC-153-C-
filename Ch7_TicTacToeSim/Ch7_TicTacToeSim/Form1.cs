using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_TicTacToeSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // create new Random variable
            Random rand = new Random();

            // initialize ROWS for array
            const int ROWS = 3;
            // initialize COLS for array
            const int COLS = 3;

            // create 2-d array
            int[,] values = new int[ROWS, COLS];


            // for loop to work through the ROWS
            for (int row = 0; row < ROWS; row++)
            {
                // for loop to work through the COLS 
                for (int col = 0; col < COLS; col++)
                {
                    // assigning the variable values to a random value 
                    values[row, col] = rand.Next(2);


                    // if to assign the first box pic
                    if (values[0,0] == 0)
                    {
                        pictureBox00.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox00.Image = Properties.Resources.x;
                    } //


                    // if to assign the second box pic
                    if (values[0,1] == 0)
                    {
                        pictureBox01.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox01.Image = Properties.Resources.x;
                    } //


                    // if to assign the third box pic
                    if (values[0,2] == 0)
                    {
                        pictureBox02.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox02.Image = Properties.Resources.x;
                    } //


                    // if to assign the fourth box pic
                    if (values[1,0] == 0)
                    {
                        pictureBox10.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox10.Image = Properties.Resources.x;
                    } //


                    // if to assign the fifth box pic
                    if (values[1,1] == 0)
                    {
                        pictureBox11.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox11.Image = Properties.Resources.x;
                    } //


                    // if to assign the sixth box pic
                    if (values[1,2] == 0)
                    {
                        pictureBox12.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox12.Image = Properties.Resources.x;
                    } //


                    // if to assign the seventh box pic
                    if (values[2,0] == 0)
                    {
                        pictureBox20.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox20.Image = Properties.Resources.x;
                    } //


                    // if to assign the eigth box pic
                    if (values[2,1] == 0)
                    {
                        pictureBox21.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox21.Image = Properties.Resources.x;
                    } //


                    // if to assign the ninth box pic
                    if (values[2,2] == 0)
                    {
                        pictureBox22.Image = Properties.Resources.o;
                    }
                    else
                    {
                        pictureBox22.Image = Properties.Resources.x;
                    } //

                } // for COLS
            } // for ROWS


            Boolean oWins = false;
            Boolean xWins = false;

            // to determine the winner across the top row
            if (values[0, 0] == 0 && values[0, 1] == 0 && values[0, 2] == 0)
            {
                oWins = true;
            }
            if (values[0, 0] == 1 && values[0, 1] == 1 && values[0, 2] == 1)
            {
                xWins = true;
            }


            // to determine the winner across the middle row
            if (values[1, 0] == 0 && values[1, 1] == 0 && values[1, 2] == 0)
            {
                oWins = true;
            }
            if (values[1, 0] == 1 && values[1, 1] == 1 && values[1, 2] == 1)
            {
                xWins = true;
            }


            // to determine the winner across the bottom row
            if (values[2, 0] == 0 && values[2, 1] == 0 && values[2, 2] == 0)
            {
                oWins = true;
            }
            if (values[2, 0] == 1 && values[2, 1] == 1 && values[2, 2] == 1)
            {
                xWins = true;
            }

            // to determine the winner across the left column
            if (values[0, 0] == 0 && values[1, 0] == 0 && values[2, 0] == 0)
            {
                oWins = true;
            }
            if (values[0, 0] == 1 && values[1, 0] == 1 && values[2, 0] == 1)
            {
                xWins = true;
            }


            // to determine the winner across the middle column
            if (values[0, 1] == 0 && values[1, 1] == 0 && values[2, 1] == 0)
            {
                oWins = true;
            }
            if (values[0, 1] == 1 && values[1, 1] == 1 && values[2, 1] == 1)
            {
                xWins = true;
            }


            // to determine the winner across the right column
            if (values[0, 2] == 0 && values[1, 2] == 0 && values[2, 2] == 0)
            {
                oWins = true;
            }
            if (values[0, 2] == 1 && values[1, 2] == 1 && values[2, 2] == 1)
            {
                xWins = true;
            }


            // to determine the winner top left diagonal
            if (values[0, 0] == 0 && values[1, 1] == 0 && values[2, 2] == 0)
            {
                oWins = true;
            }
            if (values[0, 0] == 1 && values[1, 1] == 1 && values[2, 2] == 1)
            {
                xWins = true;
            }

            // to determine the winner bottom left diagonal
            if (values[2, 0] == 0 && values[1, 1] == 0 && values[0, 2] == 0)
            {
                oWins = true;
            }
            if (values[2, 0] == 1 && values[1, 1] == 1 && values[0, 2] == 1)
            {
                xWins = true;
            }


            // determine the winner
            if (oWins && xWins)
            {
                textBoxResults.Text = "Both win!";
            }
            else if (oWins)
            {
                textBoxResults.Text = "O Wins";
            }
            else if (xWins)
            {
                textBoxResults.Text = "X Wins";
            }
            else
            {
                textBoxResults.Text = "Nobody won";
            }
          

        } // end NewGame


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end Exit

    } // end class
} // end namespace
