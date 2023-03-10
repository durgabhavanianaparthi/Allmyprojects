// See https://aka.ms/new-console-template for more information
using CalculateSalaryUsingConstructer;

Console.WriteLine("Hello, World!");
CalculateSalary objCalculateSalary = new CalculateSalary(30000);
objCalculateSalary.CalculateSalaryMethod();
Console.WriteLine("Hra is :" + objCalculateSalary.HRA);
Console.WriteLine("TAis :" + objCalculateSalary.TA);
Console.WriteLine("DA is :" + objCalculateSalary.DA);
Console.WriteLine("Tax is :" + objCalculateSalary.Tax);
Console.WriteLine("netsalary  is :" + objCalculateSalary.Netsalary);
Console.WriteLine("salary is :" + objCalculateSalary.Salary);