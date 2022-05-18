using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9_DrinkVendingMachineSim
{
    public partial class Form1 : Form
    {
        struct Drink
        {
            public string name;
            public decimal cost;
            public int numRemaining;
        }

        const int SIZE = 5;

        Drink[] drink = new Drink[SIZE];

        decimal total = 0.00m;

        
        public Form1()
        {
            InitializeComponent();
        }


        private void imgCola_Click(object sender, EventArgs e)
        {

            drink[0].name = "Cola";
            drink[0].cost = 1.00m;
            drink[0].numRemaining = int.Parse(lblColaRemaining.Text);

            if (drink[0].numRemaining > 0)
            {
                drink[0].numRemaining--;
                lblColaRemaining.Text = drink[0].numRemaining.ToString();
                total += drink[0].cost;
                lblTotal.Text = total.ToString("c");
            }
            else if (drink[0].numRemaining == 0)
            {
                MessageBox.Show("There are no Cola remaining. Please purchase something else.");
            }

        } // end method

        private void imgRootBeer_Click(object sender, EventArgs e)
        {
            drink[1].name = "Root Beer";
            drink[1].cost = 1.00m;
            drink[1].numRemaining = int.Parse(lblRootRemaining.Text);

            if (drink[1].numRemaining > 0)
            {
                drink[1].numRemaining--;
                lblRootRemaining.Text = drink[1].numRemaining.ToString();
                total += drink[1].cost;
                lblTotal.Text = total.ToString("c");
            }
            else if (drink[1].numRemaining == 0)
            {
                MessageBox.Show("There are no Root Beer remaining. Please purchase something else.");
            }
        } // end method

        private void imgLemonLime_Click(object sender, EventArgs e)
        {
            drink[2].name = "Lemon Lime";
            drink[2].cost = 1.00m;
            drink[2].numRemaining = int.Parse(lblLemonRemaining.Text);

            if (drink[2].numRemaining > 0)
            {
                drink[2].numRemaining--;
                lblLemonRemaining.Text = drink[2].numRemaining.ToString();
                total += drink[2].cost;
                lblTotal.Text = total.ToString("c");
            }
            else if (drink[2].numRemaining == 0)
            {
                MessageBox.Show("There are no Lemon Lime remaining. Please purchase something else.");
            }
        } // end method

        private void imgGrapeSoda_Click(object sender, EventArgs e)
        {
            drink[3].name = "Grape Soda";
            drink[3].cost = 1.50m;
            drink[3].numRemaining = int.Parse(lblGrapeRemaining.Text);

            if (drink[3].numRemaining > 0)
            {
                drink[3].numRemaining--;
                lblGrapeRemaining.Text = drink[3].numRemaining.ToString();
                total += drink[3].cost;
                lblTotal.Text = total.ToString("c");
            }
            else if (drink[3].numRemaining == 0)
            {
                MessageBox.Show("There are no Grape Soda remaining. Please purchase something else.");
            }
        } // end method

        private void imgCreamSoda_Click(object sender, EventArgs e)
        {
            drink[4].name = "Cream Soda";
            drink[4].cost = 1.50m;
            drink[4].numRemaining = int.Parse(lblCreamRemaining.Text);

            if (drink[4].numRemaining > 0)
            {
                drink[4].numRemaining--;
                lblCreamRemaining.Text = drink[4].numRemaining.ToString();
                total += drink[4].cost;
                lblTotal.Text = total.ToString("c");
            }
            else if (drink[4].numRemaining == 0)
            {
                MessageBox.Show("There are no Cream Soda remaining. Please purchase something else.");
            }
        } // end method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end method

    } // end class
} // end namespace
