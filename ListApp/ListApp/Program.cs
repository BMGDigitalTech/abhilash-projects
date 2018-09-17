using System;
using System.Collections.Generic;
using System.Linq;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { Id = 101, Name = "Abhilash", Salary = 60000.00 };
            Employee e2 = new Employee() { Id = 102, Name = "Ashish", Salary = 40000.00 };
            Employee e3 = new Employee() { Id = 103, Name = "Abhishek", Salary = 80000.00 };
            Employee e4 = new Employee() { Id = 104, Name = "Basavraj", Salary = 70000.00 };

            List<Employee> empList = new List<Employee>() { e1, e2, e3, e4 };
            /*empList.Add(e1);
            empList.Add(e2);
            empList.Add(e3);*/
            empList.Insert(0, e3);

            for(int i = 0; i < empList.Count; i++)
            {
                Employee emp = empList[i];
                Console.WriteLine("Emp Id: {0}, Emp Name {1}, Emp Salary {2}", emp.Id, emp.Name, emp.Salary);
            }

            Console.WriteLine("Index of employee e3" + empList.IndexOf(e3, 1, 3));

            if (empList.Contains(e2))
            {
                Console.WriteLine("Employee 2 object exist in the list");
            } else
            {
                Console.WriteLine("Object Does not exist");
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            // Find a Employee starting with B
            if (empList.Exists(emp => emp.Name.StartsWith("B")))
            {
                Console.WriteLine("Employee with Name starting with B exists");
            } else
            {
                Console.WriteLine("Employee with name starting B does not exists");
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            // Find an employee by name
            Employee e = empList.Find(emp => emp.Name == "Abhilash");
            Console.WriteLine("Emp Id: {0}, Emp Name {1}, Emp Salary {2}", e.Id, e.Name, e.Salary);

            Console.WriteLine("---------------------------------------------------------------------------");
            // Find the last index item from the list
            Employee lastemp = empList.FindLast(emp => emp.Salary > 60000.00);
            Console.WriteLine("Emp Id: {0}, Emp Name {1}, Emp Salary {2}", lastemp.Id, lastemp.Name, lastemp.Salary);

            // Find all from the list by specifying the condition
            Console.WriteLine("---------------------------------------------------------------------------");
            List<Employee> fAll = empList.FindAll(emp => emp.Salary > 60000.00);
            foreach(Employee empItem in fAll)
            {
                Console.WriteLine("Emp Id: {0}, Emp Name {1}, Emp Salary {2}", empItem.Id, empItem.Name, empItem.Salary);
            }
            // Find index from the list by specifying the condition
            Console.WriteLine("---------------------------------------------------------------------------");
            int index = empList.FindIndex(emp => emp.Name == "Abhilash");
            Console.WriteLine("Abhilash found at the index " + index);

            // Find the lastIndex from the list by specifying the condition
            Console.WriteLine("---------------------------------------------------------------------------");
            int lastIndex = empList.FindLastIndex(emp => emp.Salary > 60000.00);
            Console.WriteLine("Last index for the salary greater than 60K: " + lastIndex);

            empList.RemoveAt(0);
            // Convert list to dictionary
            Console.WriteLine("---------------------------------------------------------------------------");
            Dictionary<int, Employee> empDict = empList.ToDictionary(emp => emp.Id);

            foreach(KeyValuePair<int, Employee> kvp in empDict)
            {
                e = kvp.Value;
                Console.WriteLine("Emp Id: {0}, Emp Name {1}, Emp Salary {2}", e.Id, e.Name, e.Salary);
            }
        }
    }
}
