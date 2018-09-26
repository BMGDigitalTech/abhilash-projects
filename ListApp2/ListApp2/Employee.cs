using System;
using System.Collections.Generic;
using System.Text;

namespace ListApp2
{
    class Employee: IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Type { get; set; }

        public int CompareTo(Employee obj)
        {
            //if(this.Salary > obj.Salary)
            //{
            //    return 1;
            //} else if(this.Salary < obj.Salary)
            //{
            //    return -1;

            //} else
            //{
            //    return 0;
            //}

            return this.Salary.CompareTo(obj.Salary);
        }
    }

    class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
