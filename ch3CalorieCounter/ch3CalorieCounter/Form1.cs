using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3CalorieCounter
{
    public partial class calorieCounter : Form
    {

        // Constant fields
        const int PEAR_IMAGE = 120;
        const int ORANGE_IMAGE = 90;
        const int BANANA_IMAGE = 115;
        const int APPLE_IMAGE = 80;

        // Field variable to hold the total
        // initialized with 0
        private int totalCal = 0;

        public calorieCounter()
        {
            InitializeComponent();
        }

     
        private void pearImage_Click(object sender, EventArgs e)
        {
            // Add the pear calorie value to the total
            totalCal += PEAR_IMAGE;

            // Display the total, formatted as a string
            totalLabel.Text = totalCal.ToString();
        }

        private void orangeImage_Click(object sender, EventArgs e)
        {
            // Add the orange calorie value to the total
            totalCal += ORANGE_IMAGE;

            // Display the total, formatted as a string
            totalLabel.Text = totalCal.ToString();
        }

        private void bananaImage_Click(object sender, EventArgs e)
        {
            // Add the banana calorie value to the total
            totalCal += BANANA_IMAGE;

            // Display the total, formatted as a string
            totalLabel.Text = totalCal.ToString();
        }

        private void appleImage_Click(object sender, EventArgs e)
        {
            // Add the apple calorie value to the total
            totalCal += APPLE_IMAGE;

            // Display the total, formatted as a string
            totalLabel.Text = totalCal.ToString();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Clear the total calories calculated
            totalCal = 0;
            totalLabel.Text = totalCal.ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
