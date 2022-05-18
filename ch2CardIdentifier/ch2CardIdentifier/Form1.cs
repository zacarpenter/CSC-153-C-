using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch2CardIdentifier
{
    public partial class frmCardIdentifier : Form
    {
        public frmCardIdentifier()
        {
            InitializeComponent();
        }

        /* Click on the picture of the card to see the name of the card listed in the box
           The code below is ordered by picture from left to right
        */

        private void twoClubs_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Two of Clubs";
        }

        private void aceSpades_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Ace of Spades";
        }

        private void queenHearts_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Queen of Hearts";
        }

        private void jackDiamonds_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Jack of Diamonds";
        }

        private void kingClubs_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "King of Clubs";
        }

        //This was a fun assignment!
    }
}
