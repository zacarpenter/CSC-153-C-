using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_TotalSales
{
    public partial class TotalSales : Form
    {
        public TotalSales()
        {
            InitializeComponent();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            const int SIZE = 7;

            double[] sales = new double[SIZE];

            int index = 0;

            double total;
            double average;
            double highest;
            double lowest;

            StreamReader inputFile;

            inputFile = File.OpenText("Sales.txt");

            while (index < sales.Length && !inputFile.EndOfStream)
            {
                sales[index] = double.Parse(inputFile.ReadLine());
                index++;
            } // end while

            inputFile.Close();

            foreach (double value in sales)
            {
                ouputBox.Items.Add(value);
            } // end foreach

            // get total from method
            total = Total(sales);
            // display total
            totalTxt.Text = total.ToString();

            // get average from method
            average = Average(sales);
            // display average
            averageTxt.Text = average.ToString();

            // get highest from method
            highest = Highest(sales);
            // display highest
            highestTxt.Text = highest.ToString();

            // get lowest from method
            lowest = Lowest(sales);
            // display lowest
            lowestTxt.Text = lowest.ToString();

        } // end method

        private double Total(double[] salesArray)
        {
            double total = 0;

            for (int index = 0; index < salesArray.Length; index++)
            {
                total += salesArray[index];
            } // end for

            return total;

        } // end method

        private double Average(double[] salesArray)
        {
            double total = 0;
            double average;

            for (int index = 0; index < salesArray.Length; index++)
            {
                total += salesArray[index];
            }

            average = (double)total / salesArray.Length;

            return average;

        } // end method

        private double Highest(double[] salesArray)
        {
            double highest = salesArray[0];

            for (int index = 1; index < salesArray.Length; index++)
            {
                if (salesArray[index] > highest)
                {
                    highest = salesArray[index];
                } // end if
            } // end for

            return highest;
        } // end method

        private double Lowest(double[] salesArray)
        {
            double lowest = salesArray[0];

            for (int index = 1; index < salesArray.Length; index++)
            {
                if (salesArray[index] < lowest)
                {
                    lowest = salesArray[index];
                } // end if
            } // end for

            return lowest;
        } // end method

    }
}
