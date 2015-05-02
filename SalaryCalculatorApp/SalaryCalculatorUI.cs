using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.EmployeeName = employeeNameTextBox.Text;
            aSalary.BasicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.HouseRent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.MadicalAllowence = Convert.ToDouble(medicalAllowenceTextBox.Text);

            MessageBox.Show(aSalary.EmployeeName+" Your Salary is: "+aSalary.TotalSalary().ToString());
            employeeNameTextBox.Clear();
            basicAmountTextBox.Clear();
            houseRentTextBox.Clear();
            medicalAllowenceTextBox.Clear();
        }
    }
}
