using System;
using System.Collections.Generic;

namespace AnonymousFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>()
            {
                new Employee {ID = 101, Name="Abhilash"},
                new Employee {ID= 102, Name="Abhishek"},
                new Employee {ID=103, Name="Anup"}
            };

            Employee employee = listEmployee.Find(delegate (Employee emp)
            {
                return emp.ID == 102;
            });
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
