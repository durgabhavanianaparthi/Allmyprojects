using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalaryUsingConstructer
{
    internal class CalculateSalary
    {
        public double HRA { get; set; }
        public double TA { get; set; }
        public double Tax { get; set; }
        public double DA { get; set; }
        public double Netsalary { get; set; }
        public double Salary { get; set; }

        public CalculateSalary(double _salary)
        {
            Salary = _salary;

        }

        public void CalculateSalaryMethod()
        { 
            if (Salary < 10000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.1;
                Tax = Salary * 0.1;
                DA = Salary * 0.15;

            }
            else
            {
                HRA = Salary * 0.3;
                TA = Salary * 0.15;
                Tax = Salary * 0.2;
                DA = Salary * 0.2;

            }
            Netsalary = Salary + HRA + TA + DA - Tax;
            

        }
    }
}
