using HomeWorkPraktikiConts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktikiConts.Controllers
{
    internal class EmployeeController
    {
        private EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetFilteredEmployee()
        {
            decimal startSalary = 1000;
            decimal endSalary = 2000;

            foreach(var employe in _employeeService.FilterEmployeeBySalary(startSalary, endSalary))
            {
                Console.WriteLine(employe.Name + " " + employe.Surname);
            }
        }



        public void SortEmployees()
        {
            Console.WriteLine("Choose one option for sorting: ");

            string sortText = Console.ReadLine();



            foreach (var employe in _employeeService.SortEmployee(sortText))
            {
                Console.WriteLine(employe.Name + " " + employe.Surname);
            }


        }
        

        
    }
}
