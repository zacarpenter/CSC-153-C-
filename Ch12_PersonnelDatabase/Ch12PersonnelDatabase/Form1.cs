using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12PersonnelDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeList);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeList.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeList.Employee);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxLookup.SelectedIndex == 0)
            {
                this.employeeTableAdapter.FillByName(this.employeeList.Employee, txtSearch.Text);
            }
            else if (cbxLookup.SelectedIndex == 1)
            {
                this.employeeTableAdapter.FillByEmployeeID(this.employeeList.Employee, Convert.ToInt32(txtSearch.Text));
            }
            else if (cbxLookup.SelectedIndex == 2)
            {
                this.employeeTableAdapter.FillByPosition(this.employeeList.Employee, txtSearch.Text);
            }
            else
            {
                this.employeeTableAdapter.FillByHourlyPayRate(this.employeeList.Employee, Convert.ToDecimal(txtSearch.Text));
            }
            
        } // end Search click

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employeeList.Employee);
        } // end Show All click

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end Close click

    } // end class
} // end namespace
