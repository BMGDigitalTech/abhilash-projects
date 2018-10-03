using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Indexers
{
    public enum Gender { Male, Female };
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        private List<Employee> empList;

        public Employee()
        {
             empList = new List<Employee>()
            {
                new Employee{ Id=1, Name="Abhilash", Gender=Gender.Male},
                new Employee{ Id=2, Name="Abhishek", Gender=Gender.Male},
                new Employee{ Id=3, Name="Anup", Gender=Gender.Male},
                new Employee{ Id=4, Name="Arjun", Gender=Gender.Male},
                new Employee{ Id=5, Name="Anusha", Gender=Gender.Female},
                new Employee{ Id=6, Name="Ashish", Gender=Gender.Male},
                new Employee{ Id=7, Name="Abhijeeth", Gender=Gender.Male},
                new Employee{ Id=8, Name="Bipasha", Gender=Gender.Female},
                new Employee{ Id=9, Name="Chaitra", Gender=Gender.Female},
                new Employee{ Id=10, Name="Deepa", Gender=Gender.Female}
            };
        }

        public string this[int empId]
        {
            get
            {
                return empList.FirstOrDefault(emp => emp.Id == empId).Name;
            }
            set
            {
                empList.FirstOrDefault(emp => emp.Id == empId).Name = value;
            }
        }


    }
}
