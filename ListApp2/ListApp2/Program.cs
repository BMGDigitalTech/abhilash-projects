using System;
using System.Collections.Generic;
using System.Linq;

namespace ListApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 8, 1, 7, 2, 6, 9, 4, 5 };
            Console.WriteLine("Unsorted integer list");
            foreach (int i in intList) { Console.Write(i + ","); }
            intList.Sort();
            Console.WriteLine("\nSorted list");
            foreach (int i in intList) { Console.Write(i + ","); }
            Console.WriteLine("\n---------------------------------------------------------------------");


            //Full Time Employees
            Employee e1 = new Employee() { Id = 101, Name = "Abhilash", Salary = 60000, Type = "Full-time" };
            Employee e2 = new Employee() { Id = 102, Name = "Abhijeeth", Salary = 80000, Type = "Full-time" };
            Employee e3 = new Employee() { Id = 103, Name = "Abhishek", Salary = 50000, Type = "Full-time" };

            //Part Time Employees
            Employee e4 = new Employee() { Id = 104, Name = "Arjun", Salary = 6000, Type = "Part-time" };
            Employee e5 = new Employee() { Id = 105, Name = "Arun", Salary = 8000, Type = "Part-time" };

            List<Employee> allEmployee = new List<Employee>();

            List<Employee> fullTime = new List<Employee>() { e1, e2, e3 };
            List<Employee> partTime = new List<Employee>() { e4, e5 };
            allEmployee.AddRange(fullTime);
            allEmployee.AddRange(partTime);

            // Loop through all the employees 
            foreach(Employee emp in allEmployee)
            {
                Console.WriteLine("Emp Id: {0}, Emp Name: {1}, Emp Salary: {2}, Emp Type: {3}", emp.Id, emp.Name, emp.Salary, emp.Type);
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            // Get employees from specific range
            List<Employee> p1 = allEmployee.GetRange(0, 3);
            foreach(Employee emp in p1)
            {
                Console.WriteLine("Emp Id: {0}, Emp Name: {1}, Emp Salary: {2}, Emp Type: {3}", emp.Id, emp.Name, emp.Salary, emp.Type);
            }

            // Remove employees from range
            Console.WriteLine("-----------------------------------------------------------------------------");
            allEmployee.RemoveRange(3, 2);
            foreach (Employee emp in allEmployee)
            {
                Console.WriteLine("Emp Id: {0}, Emp Name: {1}, Emp Salary: {2}, Emp Type: {3}", emp.Id, emp.Name, emp.Salary, emp.Type);
            }

            //Sort employees by salary
            Console.WriteLine("-----------------------------------------------------------------------------");
            allEmployee.Sort();
            foreach(Employee emp in allEmployee)
            {
                Console.WriteLine("Emp Id: {0}, Emp Name: {1}, Emp Salary: {2}, Emp Type: {3}", emp.Id, emp.Name, emp.Salary, emp.Type);
            }

            //Sort employees by Name
            Console.WriteLine("-----------------------------------------------------------------------------");
            SortByName sbn = new SortByName();
            allEmployee.Sort(sbn);
            foreach (Employee emp in allEmployee)
            {
                Console.WriteLine("Emp Id: {0}, Emp Name: {1}, Emp Salary: {2}, Emp Type: {3}", emp.Id, emp.Name, emp.Salary, emp.Type);
            }
        }
    }
}
