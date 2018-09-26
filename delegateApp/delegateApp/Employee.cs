using System;
using System.Collections.Generic;
using System.Text;

namespace delegateApp
{
    public delegate bool IsPromotable(Employee emp);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Experience { get; set; }

        public static void PromoteEmployee(List<Employee> obj, IsPromotable checkPromotable)
        {
            foreach(Employee emp in obj)
            {
                if(checkPromotable(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }
        }
    }
}
