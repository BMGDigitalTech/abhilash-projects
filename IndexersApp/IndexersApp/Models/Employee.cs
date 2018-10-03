using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexersApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> EmployeeList;

        public Employee()
        {
            EmployeeList = new List<Employee>
            {
                new Employee { Id=1, Name="Abhilash" },
                new Employee { Id=2, Name="Abhishek"},
                new Employee {Id=3, Name="Arjun"}
            };
        }

        // Use "this" keyword to create an indexer
        // This indexer takes employeeId as parameter
        // And  returns employee name

        public string this[int employeeId]
        {
            get
            {
                return EmployeeList.FirstOrDefault(x => x.Id == employeeId).Name;
            }
            set
            {
                EmployeeList.FirstOrDefault(x => x.Id == employeeId).Name = value;
            }
        }
    }
}
