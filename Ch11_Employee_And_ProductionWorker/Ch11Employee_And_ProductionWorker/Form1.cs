using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11Employee_And_ProductionWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radProductionWorker_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxShift.Visible = radProductionWorker.Checked;
            txtHourlyPayRate.Visible = radProductionWorker.Checked;
            txtAnnualSalary.Visible = radShiftSupervisor.Checked;
            txtAnnualProductionBonus.Visible = radShiftSupervisor.Checked;

            // reset the fields on switch
            txtName.Text = "";
            txtEmployeeNumber.Text = "";
            txtHourlyPayRate.Text = "";
            txtAnnualSalary.Text = "";
            txtAnnualProductionBonus.Text = "";
        }

        private void radShiftSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxShift.Visible = radProductionWorker.Checked;
            txtHourlyPayRate.Visible = radProductionWorker.Checked;
            txtAnnualSalary.Visible = radShiftSupervisor.Checked;
            txtAnnualProductionBonus.Visible = radShiftSupervisor.Checked;

            // reset the fields on switch
            txtName.Text = "";
            txtEmployeeNumber.Text = "";
            txtHourlyPayRate.Text = "";
            txtAnnualSalary.Text = "";
            txtAnnualProductionBonus.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (radProductionWorker.Checked) // Production Worker
            {
                ProductionWorker prod = new ProductionWorker();

                prod.Name = txtName.Text;
                prod.EmployeeNumber = Convert.ToInt32(txtEmployeeNumber.Text);
                //prod.SelectedShiftNumber = comboBoxShift.SelectedItem;
                prod.SelectedShiftNumber = (comboBoxShift.SelectedIndex + 1).ToString();
                prod.HourlyPayRate = Convert.ToDouble(txtHourlyPayRate.Text);

                MessageBox.Show(prod.Name + "\'s Employee Number is: " + prod.EmployeeNumber.ToString() + "\n" + prod.Name + " works Shift " + prod.SelectedShiftNumber.ToString() + ", with an Hourly Pay Rate of: " + prod.HourlyPayRate.ToString("c"));
            }

            else // Shift Supervisor
            {
                ShiftSupervisor sup = new ShiftSupervisor();

                sup.Name = txtName.Text;
                sup.EmployeeNumber = Convert.ToInt32(txtEmployeeNumber.Text);
                sup.AnnualSalary = Convert.ToDouble(txtAnnualSalary.Text);
                sup.AnnualProductionBonus = Convert.ToDouble(txtAnnualProductionBonus.Text);

                MessageBox.Show(sup.Name + "\'s Employee Number is: " + sup.EmployeeNumber.ToString() + "\n" + sup.Name + " earns an Annual Salary of: " + sup.AnnualSalary.ToString("c") + "\n" + sup.Name + " also earned an Annual Production Bonus of: " + sup.AnnualProductionBonus.ToString("c"));
            }

        } // end Create

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end Close

    } // end class
} // end namespace
