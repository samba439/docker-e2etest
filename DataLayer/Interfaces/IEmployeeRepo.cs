using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
   public interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee emp);
        bool RemoveEmployee(string id);
    }
}
