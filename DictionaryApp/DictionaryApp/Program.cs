using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                Id = 101,
                Name = "Abhilash",
                Salary = 50000.00
            };

            Employee e2 = new Employee()
            {
                Id = 102,
                Name = "Abhishek",
                Salary = 60000.00
            };

            Employee e3 = new Employee()
            {
                Id = 103,
                Name = "Basavraj",
                Salary = 300000.00
            };

            List<Employee> emplist = new List<Employee>() { e1, e2, e3 };

            Dictionary<int, Employee> empDict = new Dictionary<int, Employee>();
            foreach(Employee emp in emplist)
            {
                if (!empDict.ContainsKey(emp.Id))
                {
                    empDict.Add(emp.Id, emp);
                }
            }
            /*
            empDict.Add(e1.Id, e1);
            empDict.Add(e2.Id, e2);
            empDict.Add(e3.Id, e3);
            */
            foreach(KeyValuePair<int, Employee> keyValuePair in empDict)
            {
                Console.WriteLine("Key :" + keyValuePair.Key );
                Employee emp = empDict[keyValuePair.Key];
                Console.WriteLine("Emp Id = {0}, Emp Name = {1}, Emp Salary = {2}", emp.Id, emp.Name, emp.Salary);
                Console.WriteLine("---------------------------------------------------------------------");
            }

            Console.WriteLine("Please enter Id to search employee");
            int eid = Convert.ToInt32(Console.ReadLine());
            if (empDict.ContainsKey(eid))
            {
                Employee emp = empDict[eid];
                Console.WriteLine("Emp Id = {0}, Emp Name = {1}, Emp Salary = {2}", emp.Id, emp.Name, emp.Salary);
            } else
            {
                Console.WriteLine("Employee not found");
            }

        }
    }
}
