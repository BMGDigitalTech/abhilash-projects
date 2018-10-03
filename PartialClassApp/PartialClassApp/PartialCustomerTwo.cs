using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassApp
{
    public partial class PartialCustomer
    {
        partial void GetFullName()
        {
            Console.WriteLine(this.FirstName + ' ' + this.LastName);
        }
    }
}
