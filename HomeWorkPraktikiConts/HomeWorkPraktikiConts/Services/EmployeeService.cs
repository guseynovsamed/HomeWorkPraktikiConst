using HomeWorkPraktikiConts.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktikiConts.Services
{
    internal class EmployeeService
    {
        public Employee[] GetEmployees()
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Semed",
                Surname = "Huseynov",
                Age = 27,
                Salary = 1460
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "Tunzale",
                Surname = "Memmedova",
                Age = 24,
                Salary = 1870
            };
            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "Aqsin",
                Surname = "Veliyev",
                Age = 25,
                Salary = 1500

            };
            Employee emp4 = new Employee()
            {
                Id = 4,
                Name = "Ilham",
                Surname = "Abasli",
                Age = 19,
                Salary = 849
            };

            return new Employee[] { emp1, emp2, emp3, emp4 };
        }
        public Employee[] FilterEmployeeBySalary(decimal startSalary , decimal endSalary)
        {
            return GetEmployees().Where(n=>n.Salary > startSalary && n.Salary < endSalary).ToArray();
        }





        public Employee[] SortEmployee(string sortType)
        {
            var employees = GetEmployees();

            if (sortType == "asc")

                return  employees.OrderBy(m=>m.Salary).ToArray();
               
            return employees.OrderByDescending(m=>m.Salary).ToArray();
            
        }

    }



   
}

