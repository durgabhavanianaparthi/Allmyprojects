using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Hierarchical
{
    public  class EmployeeSalaryDetais
    {
        public double Salary { get; set; }
        public string EName { get; set; }        

        //public int Id { get; set; }
        public void SalaryDetails()
        {           
            Console.WriteLine("Enter name:");
            EName = Console.ReadLine();           
           // return EName;
        }
         
    }
}
