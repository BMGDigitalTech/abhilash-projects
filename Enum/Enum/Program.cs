using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[3];
            emps[0] = new Employee { Name = "Abhilash", Gender = Gender.Male, Id = 1 };
            emps[1] = new Employee { Name = "Basu", Gender = Gender.Unknown, Id = 2 };
            emps[2] = new Employee { Name = "Chetan", Gender = Gender.Male, Id = 3 };

            foreach(Employee e in emps)
            {
                Console.WriteLine("Employee Name: {0}, Gender: {1}, Id : {2}", e.Name, e.Gender, e.Id); ;
            }

        }
    }
}
