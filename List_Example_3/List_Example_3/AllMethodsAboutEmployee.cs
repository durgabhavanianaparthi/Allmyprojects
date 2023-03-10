using List_Example_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace List_Example_3
{
        public class AllMethodsAboutEmployee : Employee
        {
            List<Employee> employeesList = new List<Employee>(); 
             public void Add()
             {
                 Employee objemployee = new Employee(); 
                 Console.WriteLine("How many Employees do you want's to Add"); 
                 int noOfEmployees = int.Parse(Console.ReadLine());

                bool RecordStatus = false; 
                 for (int loopVariable = 1; loopVariable <= noOfEmployees; loopVariable++)
                 { 
                objemployee.AddEmployees();
                employeesList.Add(objemployee);
                RecordStatus = true;
                 }
                if (RecordStatus) 
                { 
                Console.WriteLine(Environment.NewLine + "Employee Record Inserted Successfully..\n");
                 }
             }

            public void Search()
            {
                Console.WriteLine("Enter employee Id to Search"); 
                 int searchVariable = int.Parse(Console.ReadLine());

                Employee objEmployee = new Employee(); 
                 bool isSearchVariableFound = false;

                 foreach (Employee emp in employeesList)
                 {
                    if (searchVariable == emp.EmployeeId)
                    { 
                    objEmployee = emp;
                    isSearchVariableFound = true;
                    } 
                 }
                    if (isSearchVariableFound)
                    { 
                       objEmployee.DisplayEmployeeDetails();
                        Console.WriteLine("-----------------------"); 
                    } 
                    else 
                    { 
                       Console.WriteLine(" Please enter valid employee ID ");
                    }
            }

            public void Remove()
            {
                Console.WriteLine("Enter employee ID to Remove from records");
                  int removeVariable = int.Parse(Console.ReadLine());

                bool isRemoveVariableFound = false; 
                 foreach (Employee emp in employeesList)
                 { 
                    if (removeVariable == emp.EmployeeId)
                    { 
                         employeesList.Remove(emp);
                    isRemoveVariableFound = true;
                          break;
                     } 
                 }
                    if (isRemoveVariableFound)
                    { 
                         Console.WriteLine(" Record deleted successfully ");
                    }
                      else 
                      {
                         Console.WriteLine(" Please enter valid employee ID ");
                      }

            }
            public void RemoveAtIndex()
            {
                Console.WriteLine("Enter employee Index number to Remove from records"); 
            int indexVariable = int.Parse(Console.ReadLine());

                bool isRemoveVariableFound = false; 
            foreach (Employee emp in employeesList)
            {
                employeesList.RemoveAt(indexVariable);
                isRemoveVariableFound |= true; 
                break; 
            }
                if (isRemoveVariableFound)
            {
                Console.WriteLine(" Record deleted by Index number successfully ");
            } 
            else
            { 
                Console.WriteLine(" Please enter valid employee Index Number ");
            }
            }
            public void Insert()
            {
                Console.WriteLine("No of records exists in List  : " + employeesList.Count());
            Console.WriteLine("Enter Index number where you wants to Insert record, index like 0,1,2...."); 
            int insertVariable = int.Parse(Console.ReadLine());

                bool RecordStatus = false;
            Employee objEmployee = new Employee();
            objEmployee.AddEmployees();
            employeesList.Insert(insertVariable, objEmployee);
            }
            public void Count() 
            {
            Console.WriteLine("No of records exists in the List  : " + employeesList.Count());
             }
            public void Display() 
            { 
                 Console.WriteLine("********All Employees information*******");
                  foreach (Employee abc in employeesList) 
                  { 
                     abc.DisplayEmployeeDetails(); 
                     //Console.WriteLine("-----------------------");
                  }
            }

        }
    }

 


