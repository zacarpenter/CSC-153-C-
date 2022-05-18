using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch10CarClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car myCar = new Car();


        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            myCar.Accelerate();
            txtCurrentSpeed.Text = myCar.CurrentSpeed().ToString();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            myCar.Brake();
            txtCurrentSpeed.Text = myCar.CurrentSpeed().ToString();
        }

        private void btnSecondPage_Click(object sender, EventArgs e)
        {
            Form2 page2 = new Form2();

            myCar.Year = txtYear.Text;
            myCar.Make = txtMake.Text;

            page2.txtOutput.Text = myCar.Year + " " + myCar.Make;
            page2.Show();
        }

    } // end class
} // end namespace
