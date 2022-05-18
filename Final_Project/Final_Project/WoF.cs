using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class WoF : Form
    {
        public WoF()
        {
            InitializeComponent();
        }

        // access the Spin class
        Spin spin = new Spin();

        // access Guess Letter form
        GuessLetter guess = new GuessLetter();

        // access the Solve form
        Solve solve = new Solve();

        // acces the Winner form
        Winner win = new Winner();

        // initialize the answer
        private string answer = "NORTH CAROLINA";

        // initialize the available letter list
        public string availableLetters;

        // initialize the players array
        private string[] players = new string[] { "Player 1", "Player 2", "Player 3" };

        // initialize the current player to player 1
        private int currentPlayer = 0;

        // initialize the playerAmounts array
        private int[] playerAmounts = new int[] { 0, 0, 0 };

        // initialize the playerGuess entry
        private string playerGuess;




        // update the form on load
        private void WoF_Load(object sender, EventArgs e)
        {
            // availableLetters takes the value of the label
            availableLetters = lblLetters.Text;
            
            // assign the currentPlayer to the label
            lblCurrentPlayer.Text = players[0].ToString() + " - Spin or Solve";

            // set the player amounts to zero on load
            txtPlayer1Amount.Text = "$0";
            txtPlayer2Amount.Text = "$0";
            txtPlayer3Amount.Text = "$0";

            // access the Guess form's guess button click
            guess.btnGuess.Click += BtnGuess_Click;
            // access the Solve form's solve button click
            solve.btnSolve.Click += BtnSolve_Click; 
        }


        // method for the solve click
        private void BtnSolve_Click(object sender, EventArgs e)
        {
            if (solve.txtSolve.Text.Equals(answer))
            {
                MessageBox.Show("Correct!");
                solve.txtSolve.Text = "";
                solve.Close();
                // show the Winner form
                win.lblWinner.Text = players[currentPlayer].ToString() + " wins $" + playerAmounts[currentPlayer];
                win.ShowDialog();
            }
            else
            {
                // go to the next player and the game continues
                NextPlayer();
                MessageBox.Show("Incorrect! " + players[currentPlayer].ToString() + "'s turn.");
                solve.txtSolve.Text = "";
                solve.Close();
            }
        }


        // method to open the Guess Letter form on click
        private void BtnGuess_Click(object sender, EventArgs e)
        {
            GuessALetter();
        }


        // method for guessing a letter
        public void GuessALetter()
        {
            try
            {
                // assign our variable playerGuess to the value entered in the textbox
                playerGuess = guess.txtGuess.Text;

                // store the playerGuess in a character array and assign it to a char variable
                char chPlayerGuess = playerGuess.ToCharArray()[0];

                // decision structure to check if we're using a valid guess
                if (guessValid(chPlayerGuess))
                {
                    // use our method to update the letters from the player guess
                    updateLetters(chPlayerGuess);

                    // create a loop to count the occurrences of playerGuess in answer
                    int occurrence = 0;
                    foreach (char ch in answer)
                    {
                        if (ch == chPlayerGuess)
                        {
                            occurrence++;
                        }
                    }                     

                    // successful guess
                    if (answer.Contains(playerGuess))
                    {
                        MessageBox.Show("There are " + occurrence + " " + playerGuess + "'s in the puzzle worth: $" + occurrence * spin.GetSpinValue());
                        // update availble letters, puzzle, and player amount
                        updatePlayerAmount(occurrence * spin.GetSpinValue());
                        guess.txtGuess.Text = "";
                        guess.Close();
                    }
                    // incorrect guess
                    else
                    {
                        // go to next player
                        NextPlayer();
                        MessageBox.Show("Incorrect guess. " + players[currentPlayer].ToString() + "'s turn.");
                        guess.txtGuess.Text = "";
                        guess.Close();
                    }
                }
                // this makes the player choose a letter that hasn't been chosen before or they don't enter a number/punctuation
                else
                {
                    MessageBox.Show("Pick from the available letters.");
                }
            } // end try
            catch
            {
                MessageBox.Show("Please enter a valid letter.");    
            } // end catch
        } // end method


        // method to determine if a valid character was entered
        private bool guessValid(char pGuess)
        {
            // check if the player's guess is a letter
            if (Char.IsLetter(pGuess))
            {
                if (lblLetters.Text.Contains(pGuess))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        } // end method
        

        // method to update the letters for the available letters labels on each form
        private void updateLetters(char letter)
        {
            lblLetters.Text = lblLetters.Text.Replace(letter, ' ');
            guess.GuesslblLetters.Text = guess.GuesslblLetters.Text.Replace(letter, ' ');

            if (letter == 'N')
            {
                lblN1.Text = "N";
                lblN2.Text = "N";
            }
            else if (letter == 'O')
            {
                lblO1.Text = "O";
                lblO2.Text = "O";
            }
            else if (letter == 'R')
            {
                lblR1.Text = "R";
                lblR2.Text = "R";
            }
            else if (letter == 'T')
            {
                lblT.Text = "T";
            }
            else if (letter == 'H')
            {
                lblH.Text = "H";
            }
            else if (letter == 'C')
            {
                lblC.Text = "C";
            }
            else if (letter == 'A')
            {
                lblA1.Text = "A";
                lblA2.Text = "A";
            }
            else if (letter == 'L')
            {
                lblL.Text = "L";
            }
            else if (letter == 'I')
            {
                lblI.Text = "I";
            }
        } // end method


        // method to update the playerAmounts array
        private void updatePlayerAmount(int value)
        {
            playerAmounts[currentPlayer] += value;

            switch (currentPlayer)
            {
                case 0:
                    txtPlayer1Amount.Text = "$ " + playerAmounts[currentPlayer].ToString();
                    break;
                case 1:
                    txtPlayer2Amount.Text = "$ " + playerAmounts[currentPlayer].ToString();
                    break;
                case 2:
                    txtPlayer3Amount.Text = "$ " + playerAmounts[currentPlayer].ToString();
                    break;
            }
            
        } // end method


        // method for switching players
        private void NextPlayer()
        {
            // move to the next player
            currentPlayer++;

            // reset the current player index
            if (currentPlayer > 2)
            {
                currentPlayer = 0;
            }
            // update the lables with current player info
            lblCurrentPlayer.Text = players[currentPlayer].ToString() + " - Spin or Solve";
            guess.GuesslblCurrentPlayer.Text = players[currentPlayer].ToString() + " - Guess a Letter";
        } // end method


        // method when the spin button is clicked
        private void btnSpin_Click(object sender, EventArgs e)
        {
            // get the random number
            spin.SpinWheel();

            // check if the random number is not 8 or 9
            if (spin.GetSpin() < 8)
            {
                MessageBox.Show(players[currentPlayer].ToString() + " landed on $" + spin.GetSpinValue());
                guess.ShowDialog();
            }
            else if (spin.GetSpin() == 8 || spin.GetSpin() == 9) 
            {
                MessageBox.Show(players[currentPlayer].ToString() + " landed on $" + spin.GetSpinValue() + ". \nNext player's turn.");
                updatePlayerAmount(spin.GetSpinValue());
                NextPlayer();
            }
        } // end method


        // method to show the Solve form on click
        private void btnSolve_Click(object sender, EventArgs e)
        {
            solve.ShowDialog();
        } // end method

    } // end class
} // end namespace
