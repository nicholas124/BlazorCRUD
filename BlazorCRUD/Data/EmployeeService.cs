using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for crud

        //Get All the Employees

        public List<EmployeeInfo> GetEmployee()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

        //insert employee info
        public string create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        //Get Employee by Id
        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }

        //Update Employee
        public string UpdateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Update has been made successfully";
        }

        //Delete Employee
        public string DeleteEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Remove(objEmployee);
            _db.SaveChanges();
            return "Deletion has been made successfully";
        }


    }
}
