using System;
using System.Collections.Generic;

namespace delegateApp
{
    public delegate void DelegateMethod(string msg);
    class Program
    {
        public static void Message(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            DelegateMethod dm = new DelegateMethod(Message);
            dm("Hello from delegate");

            List<Employee> empList = new List<Employee>()
            {
                new Employee {Id = 101, Name="Abhilash", Salary=60000, Experience=6.9},
                new Employee {Id = 102, Name="Abhishek", Salary=80000, Experience=5.0},
                new Employee {Id = 103, Name="Ajay", Salary=40000, Experience=4.0},
                new Employee {Id = 104, Name="Arjun", Salary=70000, Experience=9.2},
                new Employee {Id = 105, Name="Abhijeeth", Salary=10000, Experience=1.7 },
            };

            IsPromotable dobj = new IsPromotable(promoteEmp);

            

            Employee.PromoteEmployee(empList, dobj);
        }

        public static bool promoteEmp(Employee e)
        {
            if (e.Salary < 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
