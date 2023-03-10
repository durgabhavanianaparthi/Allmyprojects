using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_DBLayer.Model;

namespace Interface.DataRepository
{
    public class EmployeeDataManager : IDataRepository<Employee>
    {
        //readonly Employee_DbContext _employee;
        readonly Employee_DbContext _employee;
        public EmployeeDataManager(Employee_DbContext employeeContext)
        {
            _employee = employeeContext;
        }
        public void Add(Employee entity)
        {
            _employee.Add(entity);
            _employee.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _employee.Employees.FirstOrDefault(x => x.EmployeeId == id);
            if (result != null)
            {
                _employee.Employees.Remove(result);
                _employee.SaveChanges();
            }
        }

       public IEnumerable<Employee> GetAllEmployees()
       {
                return _employee.Employees.ToList();
       }

        public Employee GetEmployeebyId(int id)
        {
                var obj = _employee.Employees.FirstOrDefault(x => x.EmployeeId == id);
                return obj;
            }

        public void Update(Employee dbentity, Employee entity)
        {
            dbentity.EmployeeName = entity.EmployeeName;
            dbentity.EmployeeAge = entity.EmployeeAge;
            dbentity.EmployeeSalary = entity.EmployeeSalary;

            _employee.SaveChanges();


        }
    }
}
