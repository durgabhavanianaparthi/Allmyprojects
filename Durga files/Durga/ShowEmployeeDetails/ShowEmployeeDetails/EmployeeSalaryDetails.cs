using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowEmployeeDetails
{
    internal class EmployeeSalaryDetails
    {
        double salary, hra, ta, da, tax, pf, netSalary;
        public void CalculateSalary(double _salary)
        {
            salary = _salary;
            hra = _salary * 0.35;
            ta = _salary * 0.1;
            da = _salary * 0.1;
            tax = _salary * 0.15;
            pf = _salary * 0.05;
            netSalary = _salary + hra + ta + da - tax - pf;



            DisplayPayslip();
        }



        private void DisplayPayslip()
        {
            Console.WriteLine("Salary Details are ");
            Console.WriteLine("Salary :" + salary);
            Console.WriteLine("HRA :" + hra);
            Console.WriteLine("TA :" + ta);
            Console.WriteLine("DA :" + da);
            Console.WriteLine("TAX :" + tax);
            Console.WriteLine("PF :" + pf);
            Console.WriteLine("Net Salary :" + netSalary);
        }




    }
}




