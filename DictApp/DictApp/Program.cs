using System;
using System.Collections.Generic;
using System.Linq;

namespace DictApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { Id = 101, Name = "Abhilash", Salary = 50000.00 };
            Employee e2 = new Employee() { Id = 102, Name = "Abhishek", Salary = 45500.00 };
            Employee e3 = new Employee() { Id = 103, Name = "Arjun", Salary = 35700.50 };
            Employee[] empArr = new Employee[3] { e1, e2, e3 };
            Dictionary<int, Employee> empDictionary = new Dictionary<int, Employee>();
            empDictionary = empArr.ToDictionary(emp => emp.Id, emp => emp);
            foreach(var kvp in empDictionary)
            {
                Employee e = kvp.Value;
                Console.WriteLine("Emp Id: {0}, Emp Name: {1}, Emp Salary: {2}", e.Id, e.Name, e.Salary);
            }
           /* foreach(Employee emp in empArr)
            {
                if (!empDictionary.ContainsKey(emp.Id)){
                    empDictionary.Add(emp.Id, emp);
                }
            } */
            Console.WriteLine("Total Employees: " + empDictionary.Count);
            Employee singleEmployee;
            Console.WriteLine("Please enter employee id to search");
            int empId = Convert.ToInt32(Console.ReadLine());
            if (empDictionary.TryGetValue(empId, out singleEmployee))
            {
                Console.WriteLine("EmpId: {0}, EmpName: {1}, EmpSalary: {2}", singleEmployee.Id, singleEmployee.Name, singleEmployee.Salary);
            } else
            {
                Console.WriteLine("Employee not found");
            }
            Console.WriteLine("Total Employees earning more than 40K:" + empDictionary.Count(kvp => kvp.Value.Salary > 40000.00));
            // Remove an employee from the dictionary
            empDictionary.Remove(101);
            // Loop all the employees after removing
            foreach(KeyValuePair<int, Employee> keyValuePair in empDictionary) // var can be used instead of KeyValuePair<int, Employee>
            {
                Employee emp = empDictionary[keyValuePair.Key];
                Console.WriteLine("EmpId: {0}, EmpName: {1}, EmpSalary: {2}", emp.Id, emp.Name, emp.Salary);
            }

            // Remove all employees from the dictionary
            empDictionary.Clear();

            Console.WriteLine("Total employees now in dictionary: " + empDictionary.Count);
        }


    }
}
