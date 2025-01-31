﻿using EmployeeDirectoryDemoCaliburnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectoryDemoCaliburnApp.Services
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployees();
        public void AddEmployee(Employee employee);
        public void DeleteEmployee(int employeeId);
        public void UpdateEmployee(Employee updatedEmployee);
     }
}
