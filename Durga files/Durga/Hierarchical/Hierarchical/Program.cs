// See https://aka.ms/new-console-template for more information
using Hierarchical;


EmployeeSalaryDetails1 objEmployeeSalaryDetails1 = new EmployeeSalaryDetails1();
//Console.WriteLine("Enter name:");
//objEmployeeSalaryDetails1.EName = Console.ReadLine();  
Console.WriteLine("Enter salary");
objEmployeeSalaryDetails1.Salary=Convert.ToInt32(Console.ReadLine());
objEmployeeSalaryDetails1.BonusDetails();

EmployeeSalaryDetails3 objEmployeeSalaryDetails3 = new EmployeeSalaryDetails3();
   objEmployeeSalaryDetails3.PrintEmployeeDetails();

