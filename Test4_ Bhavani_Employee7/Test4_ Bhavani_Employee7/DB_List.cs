using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4__Bhavani_Employee7
{
    internal class DB_List: Properties
    {
        
        public List<DB_List> EmployeeMethod()
        {
            List<DB_List> listEmployee_LIst = new List<DB_List>
            {
                new DB_List{ EmpId=1, EmpName ="Mounika",EmpAge=35,EmpGender='F', DeptId=1},
                new DB_List{EmpId=1, EmpName="Shravan",EmpAge=25,EmpGender='M', DeptId=2},
                new DB_List{EmpId=1, EmpName="Vinay",EmpAge=22,EmpGender='M', DeptId=3},
                new DB_List{EmpId=1, EmpName="Durga",EmpAge=15,EmpGender='F', DeptId=4},
                new DB_List{EmpId=1, EmpName="Dawood",EmpAge=22,EmpGender='M', DeptId=5},
                new DB_List{EmpId=1, EmpName="Shilpa",EmpAge=40,EmpGender='F', DeptId=6}
           };
            return listEmployee_LIst;
        }
    }
}
