using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class EmployeeSalaryDetails3: EmployeeSalaryDetais

    {
        public void PrintEmployeeDetails()
        {
            SalaryDetails();
            string sName = EName;
            Console.WriteLine("original name is :" +sName);            
          
        }
    }
}
