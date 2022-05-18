using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_DistanceConverter
{
    public partial class distanceConverter : Form
    {
        public distanceConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // intializing our variables
            string convertFrom;
            string convertTo;
            double distance;

            if (listFrom.SelectedIndex != -1 && listTo.SelectedIndex != -1)
            {
                // initialize our variable to grab from the From list item
                convertFrom = listFrom.SelectedItem.ToString();

                // initialize our variable to grab from the To list item
                convertTo = listTo.SelectedItem.ToString();

                if (convertFrom == "Inches")
                {
                    // initialize the variable to pull from the initial value
                    distance = double.Parse(txtDistance.Text);

                    if (convertTo == "Inches")
                    {
                        // since inches and inches are selected we just take the initial value
                        txtConvertedDistance.Text = distance.ToString();
                    } // end if

                    else if (convertTo == "Feet")
                    {
                        // first we get the initial value
                        distance = double.Parse(txtDistance.Text);

                        // then we divide inches by 12 to convert to feet
                        distance /= 12;

                        // finally we take the distance value and output it to our converted distance text box
                        txtConvertedDistance.Text = distance.ToString();

                    } // end else if

                    else if (convertTo == "Yards")
                    {
                        // first we get the initial value
                        distance = double.Parse(txtDistance.Text);

                        // then we divide inches by 36 to convert to yards
                        distance /= 36;

                        // finally we take the distance value and output it to our converted distance text box
                        txtConvertedDistance.Text = distance.ToString();

                    } // end else if
                } // end if

                if (convertFrom == "Feet")
                {
                    // initialize the variable to pull from the initial value
                    distance = double.Parse(txtDistance.Text);

                    if (convertTo == "Inches")
                    {
                        // first we get the initial value
                        distance = double.Parse(txtDistance.Text);

                        // then we multiply feet by 12 to convert to inches
                        distance *= 12;

                        // finally we take the distance value and output it to our converted distance text box
                        txtConvertedDistance.Text = distance.ToString();
                    } // end if

                    else if (convertTo == "Feet")
                    {
                        // since feet and feet are selected we just take the initial value
                        txtConvertedDistance.Text = distance.ToString();
                    } // end else if

                    else if (convertTo == "Yards")
                    {
                        // first we get the initial value
                        distance = double.Parse(txtDistance.Text);

                        // then we divide feet by 3 to convert to yards
                        distance /= 3;

                        // finally we take the distance value and output it to our converted distance text box
                        txtConvertedDistance.Text = distance.ToString();
                    } // end else if

                } // end if

                if (convertFrom == "Yards")
                {
                    // initialize the variable to pull from the initial value
                    distance = double.Parse(txtDistance.Text);

                    if (convertTo == "Inches")
                    {
                        // first we get the initial value
                        distance = double.Parse(txtDistance.Text);

                        // then we multiply yards by 36 to convert to inches
                        distance *= 36;

                        // finally we take the distance value and output it to our converted distance text box
                        txtConvertedDistance.Text = distance.ToString();
                    } // end if

                    else if (convertTo == "Feet")
                    {
                        // first we get the initial value
                        distance = double.Parse(txtDistance.Text);

                        // then we multiply yards by 3 to convert to feet
                        distance *= 3;

                        // finally we take the distance value and output it to our converted distance text box
                        txtConvertedDistance.Text = distance.ToString();
                    } // end else if

                    else if (convertTo == "Yards")
                    {
                        // since yards and yards are selected we just take the initial value
                        txtConvertedDistance.Text = distance.ToString();
                    } // end else if
                } // end if
            } // end if
        } // end convert click event

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        } // end Exit click event
    }
}

// honestly I probably did this the hard way, but I was struggling to find a way to convert
// the list items to a number to then perform the calulation on them
// your email about the lstBands section of the video helped a lot, thanks!
// I assume maybe a while loop? would make this easier