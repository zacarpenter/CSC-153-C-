using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        // global variable to hold our the computer's selection
        private int compChoice;

        // global variable to hold the user's selection
        private string userChoice;

        private int wins, losses, draws = 0;

        private void CompChoice()
        {

            // create random number
            Random rand = new Random();

            // assign random number to variable
            compChoice = rand.Next(1, 4);

            // if statements to display image according to number assigned
            switch (compChoice)
            {
                case 1:
                    computerChoiceImage.Image = Properties.Resources.Rock;
                    compChoice = 1;
                    break;

                case 2:
                    computerChoiceImage.Image = Properties.Resources.Paper;
                    compChoice = 2;
                    break;

                case 3:
                    computerChoiceImage.Image = Properties.Resources.Scissors;
                    compChoice = 3;
                    break;
            }
        } // end computer choice method



        private void rockBtn_Click(object sender, EventArgs e)
        {
            userChoiceImage.Image = Properties.Resources.Rock;
            userChoice = "rock";
            CompChoice();
            WinnerDetermination();
            totalWinsLossesDraws();
        } // end user rock choice



        private void paperBtn_Click(object sender, EventArgs e)
        {
            userChoiceImage.Image = Properties.Resources.Paper;
            userChoice = "paper";
            CompChoice();
            WinnerDetermination();
            totalWinsLossesDraws();
        } // end user paper choice



        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            userChoiceImage.Image = Properties.Resources.Scissors;
            userChoice = "scissors";
            CompChoice();
            WinnerDetermination();
            totalWinsLossesDraws();
        } // end user scissors choice



        private void WinnerDetermination()
        {
            CompChoice();

            // user selects rock
            if (userChoice == "rock")
            {
                switch (compChoice)
                {
                    // results for computer selects rock
                    case 1:
                        resultTxtBox.Text = "It's a draw! Please play again.";
                        break;

                    // results for computer selects paper
                    case 2:
                        resultTxtBox.Text = "Paper wraps rock. COMPUTER wins.";
                        break;

                    // results for computer selects scissors
                    case 3:
                        resultTxtBox.Text = "Rock smashes scissors. USER wins!";
                        break;
                } // end switch
            } // end user rock selection if

            if (userChoice == "paper")
            {
                switch (compChoice)
                {
                    // results for computer selects rock
                    case 1:
                        resultTxtBox.Text = "Paper wraps rock. USER wins!";
                        break;

                    // results for computer selects paper
                    case 2:
                        resultTxtBox.Text = "It's a draw! Please play again.";
                        break;

                    // results for computer selects scissors
                    case 3:
                        resultTxtBox.Text = "Scissors cuts paper. COMPUTER wins.";
                        break;
                } // end switch
            } // end user paper selection if

            if (userChoice == "scissors")
            {
                switch (compChoice)
                {
                    // results for computer selects rock
                    case 1:
                        resultTxtBox.Text = "Rock smashes scissors. COMPUTER wins.";
                        break;

                    // results for computer selects paper
                    case 2:
                        resultTxtBox.Text = "Scissors cuts paper. USER wins!";
                        break;

                    // results for computer selects scissors
                    case 3:
                        resultTxtBox.Text = "It's a draw! Please play again.";
                        break;
                }
            }
        } // end winner method



        private void totalWinsLossesDraws()
        {

            CompChoice();

            // increment wins/losses/draws if user chooses rock
            if (userChoice == "rock")
            {
                switch (compChoice)
                {
                    // increment for computer selects rock
                    case 1:
                        draws++;
                        drawsTxtBox.Text = draws.ToString();
                        break;

                    // increment for computer selects paper
                    case 2:
                        losses++;
                        computerWinsTxtBox.Text = losses.ToString();
                        break;

                    // increment for computer selects scissors
                    case 3:
                        wins++;
                        userWinsTxtBox.Text = wins.ToString();
                        break;
                } // end switch
            } // end user if increment for rock

            if (userChoice == "paper")
            {
                switch (compChoice)
                {
                    // increment for computer selects rock
                    case 1:
                        wins++;
                        userWinsTxtBox.Text = wins.ToString();
                        break;

                    // increment for computer selects paper
                    case 2:
                        draws++;
                        drawsTxtBox.Text = draws.ToString();
                        break;

                    // increment for computer selects scissors
                    case 3:
                        losses++;
                        computerWinsTxtBox.Text = losses.ToString();
                        break;
                } // end switch
            } // end user if increment for paper

            if (userChoice == "scissors")
            {
                switch (compChoice)
                {
                    // increment for computer selects rock
                    case 1:
                        losses++;
                        computerWinsTxtBox.Text = losses.ToString();
                        break;

                    // increment for computer selects paper
                    case 2:
                        wins++;
                        userWinsTxtBox.Text = wins.ToString();
                        break;

                    // increment for computer selects scissors
                    case 3:
                        draws++;
                        drawsTxtBox.Text = draws.ToString();
                        break;
                } // end switch
            } // end user if increment for scissors


        } // end total win/losses/draws method

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        } // end close click event

    } // end class
} // end namespace
