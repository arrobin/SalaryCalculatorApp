using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string EmployeeName;
        public double BasicAmount;
        public double HouseRent;
        public double MadicalAllowence;

        public double TotalSalary()
        {
            return (BasicAmount + (BasicAmount * HouseRent / 100) + (BasicAmount * MadicalAllowence / 100));
        }
    }
}
