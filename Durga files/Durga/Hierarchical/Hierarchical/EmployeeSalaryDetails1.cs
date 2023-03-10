using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical
{
   public  class EmployeeSalaryDetails1: EmployeeSalaryDetais
    {
        public void BonusDetails()
        {
           //SalaryDetails();

            Double bonus = 3000;
            double NetSalary = bonus + Salary;
            Console.WriteLine("netsalary is :"+NetSalary);
            Console.ReadLine(); 

        }
       
        

    }
}
