namespace MyClassLibrary_Test2
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }



        public void SetEmployeeDetails()
        {
            Console.WriteLine("Enter Employee ID");
            this.EmployeeID = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Employee Name");
            this.EmployeeName = Console.ReadLine();



            Console.WriteLine("Enter Employee Salary");
            this.EmployeeSalary = double.Parse(Console.ReadLine());
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + this.EmployeeID);
            Console.WriteLine("Employee Name : " + this.EmployeeName);
            Console.WriteLine("Employee Salary : " + this.EmployeeSalary);
        }




    }
}
