using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary_Test2
{
    public class Salary : Employee
    {
        double ta, da, tax, bonus, netSalary;
        public void CalculateSalary()
        {
            SetEmployeeDetails();
            DisplayEmployeeDetails();



            if (EmployeeSalary < 10000)
            {
                ta = EmployeeSalary * 0.1;
                da = EmployeeSalary * 0.2;
                tax = EmployeeSalary * 0.1;
                bonus = EmployeeSalary * 0.3;
            }
            else
            {
                ta = EmployeeSalary * 0.2;
                da = EmployeeSalary * 0.3;
                tax = EmployeeSalary * 0.3;
                bonus = EmployeeSalary * 1.3;
            }
            netSalary = ta + da + bonus - tax + EmployeeSalary;
            Console.WriteLine("TA : " + ta);
            Console.WriteLine("DA : " + da);
            Console.WriteLine("TAX : " + tax);
            Console.WriteLine("BONUS : " + bonus);
            Console.WriteLine("NET SALARY : " + netSalary);
        }


    }
}


