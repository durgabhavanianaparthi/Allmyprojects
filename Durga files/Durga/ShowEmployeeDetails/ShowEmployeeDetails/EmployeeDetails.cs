using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowEmployeeDetails
{
    internal class EmployeeDetails
    {
        public string EmpName { get; set; }
        public string EmpID { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }



        public void GetEmployeeDetails()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Name :" + EmpName);
            Console.WriteLine("ID :" + EmpID);
            Console.WriteLine("Address :" + EmpAddress);



            EmployeeSalaryDetails objSalary = new EmployeeSalaryDetails();
            objSalary.CalculateSalary(EmpSalary);
        }
    }
}
