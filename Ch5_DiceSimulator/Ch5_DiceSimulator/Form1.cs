using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_DiceSimulator
{
    public partial class diceSimulator : Form
    {

        // variable for switching the images in each box
        private int p1 = 0;
        private int p2 = 0;
        private int p3 = 0;
        private int p4 = 0;

        // count wins, losses, ties
        private int userWins = 0;
        private int compWins = 0;
        private int draws = 0;

        // initialize our random variable
        Random rand = new Random();

        public diceSimulator()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // create first user dice for picture box
            int userDice1;
            userDice1 = rand.Next(1, 7);

            // create second user dice for picture box
            int userDice2;
            userDice2 = rand.Next(1, 7);

            // create first computer dice for picture box
            int compDice1;
            compDice1 = rand.Next(1, 7);

            // create second computer dice for picture box
            int compDice2;
            compDice2 = rand.Next(1, 7);

            if (p1 >= 0)
            {

                p1 = userDice1;

                if (p1 == 1)
                {
                    userDice1Pic.Image = Properties.Resources.Die1;
                }

                else if (p1 == 2)
                {
                    userDice1Pic.Image = Properties.Resources.Die2;
                }

                else if (p1 == 3)
                {
                    userDice1Pic.Image = Properties.Resources.Die3;
                }

                else if (p1 == 4)
                {
                    userDice1Pic.Image = Properties.Resources.Die4;
                }

                else if (p1 == 5)
                {
                    userDice1Pic.Image = Properties.Resources.Die5;
                }

                else if (p1 == 6)
                {
                    userDice1Pic.Image = Properties.Resources.Die6;
                }

            } // end if

            if (p2 >= 0)
            {

                p2 = userDice2;

                if (p2 == 1)
                {
                    userDice2Pic.Image = Properties.Resources.Die1;
                }

                else if (p2 == 2)
                {
                    userDice2Pic.Image = Properties.Resources.Die2;
                }
                
                else if (p2 == 3)
                {
                    userDice2Pic.Image = Properties.Resources.Die3;
                }

                else if (p2 == 4)
                {
                    userDice2Pic.Image = Properties.Resources.Die4;
                }

                else if (p2 == 5)
                {
                    userDice2Pic.Image = Properties.Resources.Die5;
                }

                else if (p2 == 6)
                {
                    userDice2Pic.Image = Properties.Resources.Die6;
                }

            } // end if 

            if (p3 >= 0)
            {

                p3 = compDice1;

                if (p3 == 1)
                {
                    compDice1Pic.Image = Properties.Resources.Die1;
                }

                else if (p3 == 2)
                {
                    compDice1Pic.Image = Properties.Resources.Die2;
                }

                else if (p3 == 3)
                {
                    compDice1Pic.Image = Properties.Resources.Die3;
                }

                else if (p3 == 4)
                {
                    compDice1Pic.Image = Properties.Resources.Die4;
                }

                else if (p3 == 5)
                {
                    compDice1Pic.Image = Properties.Resources.Die5;
                }

                else if (p3 == 6)
                {
                    compDice1Pic.Image = Properties.Resources.Die6;
                }

            } // end if

            if (p4 >= 0)
            {

                p4 = compDice2;

                if (p4 == 1)
                {
                    compDice2Pic.Image = Properties.Resources.Die1;
                }

                else if (p4 == 2)
                {
                    compDice2Pic.Image = Properties.Resources.Die2;
                }

                else if (p4 == 3)
                {
                    compDice2Pic.Image = Properties.Resources.Die3;
                }

                else if (p4 == 4)
                {
                    compDice2Pic.Image = Properties.Resources.Die4;
                }

                else if (p4 == 5)
                {
                    compDice2Pic.Image = Properties.Resources.Die5;
                }

                else if (p4 == 6)
                {
                    compDice2Pic.Image = Properties.Resources.Die6;
                }

            } // end if

            // totals user score
            int userSum;
            userSum = userDice1 + userDice2;

            // totals computer score
            int compSum;
            compSum = compDice1 + compDice2;

            // increment user win
            if (userSum > compSum)
            {
                userWins++;
            }

            // increment computer win
            else if (userSum < compSum)
            {
                compWins++;
            }

            // increment a tie
            else if (userSum == compSum)
            {
                draws++;
            }
            
        } // end dice click

        private void btnExit_Click(object sender, EventArgs e)
        {
            // create text file results.txt
            StreamWriter outputFile;
            outputFile = File.CreateText("results.txt");

            // write results
            outputFile.WriteLine("The user won: " + userWins.ToString() + " games.");
            outputFile.WriteLine("The computer won: " + compWins.ToString() + " games.");
            outputFile.WriteLine("There were: " + draws.ToString() + " undecided games.");

            // show results when clicking exit
            MessageBox.Show("You won: " + userWins + " times\n" + "You lost: " + compWins + " times\n" + "You tied: " + draws + "times");
            outputFile.Close();

            // close the form
            this.Close();
        } // end exit click
    } // end class
} // end namespace
