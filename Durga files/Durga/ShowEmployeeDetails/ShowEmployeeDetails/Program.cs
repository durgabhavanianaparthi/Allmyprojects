// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
EmployeeDetails emp = new EmployeeDetails();



Console.WriteLine("Enter Employee Name");
emp.EmpName = Console.ReadLine();



Console.WriteLine("Enter Employee ID");
emp.EmpID = Console.ReadLine();



Console.WriteLine("Enter Employee Address");
emp.EmpAddress = Console.ReadLine();



Console.WriteLine("Enter Employee Salary");
emp.EmpSalary = Convert.ToDouble(Console.ReadLine());



emp.GetEmployeeDetails();

