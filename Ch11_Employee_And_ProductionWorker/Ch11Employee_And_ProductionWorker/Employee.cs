using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Employee_And_ProductionWorker
{
    class Employee
    {

        // fields
        private string name;
        private int employeeNumber;

        // constructor
        public Employee()
        {
            name = "";
            employeeNumber = 0;
        }

        // set and get
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int EmployeeNumber
        {
            set { employeeNumber = value; }
            get { return employeeNumber; }
        }

    } // end class Employee

    class ProductionWorker: Employee
    {

        // fields
        private object selectedShiftNumber;
        private double hourlyPayRate;

        // constructor
        public ProductionWorker()
        {
            selectedShiftNumber = 0;
            hourlyPayRate = 0.00;
        }

        // set and get
        public object SelectedShiftNumber
        {
            set { selectedShiftNumber = value; }
            get { return selectedShiftNumber; }
        }

        public double HourlyPayRate
        {
            set { hourlyPayRate = value; }
            get { return hourlyPayRate; }
        }

    } // end ProductionWorker

    class ShiftSupervisor: Employee
    {

        // fields
        private double annualSalary;
        private double annualProductionBonus;

        // constructor
        public ShiftSupervisor()
        {
            annualSalary = 0.00;
            annualProductionBonus = 0.00;
        }

        // set and get
        public double AnnualSalary
        {
            set { annualSalary = value; }
            get { return annualSalary; }
        }

        public double AnnualProductionBonus
        {
            set { annualProductionBonus = value; }
            get { return annualProductionBonus; }
        }

    } // end ShiftSupervisor

} // end namespace
