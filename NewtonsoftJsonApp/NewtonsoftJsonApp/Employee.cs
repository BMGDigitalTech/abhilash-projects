using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonsoftJsonApp
{
    class Employee
    {
        public string Name { get; set; }
        public Employee Manager { get; set; }

        public bool ShouldSerializeManager()
        {
            // don't serialize the Manager property if an employee is their own manager
            return (Manager != this);
        }
    }
}
    