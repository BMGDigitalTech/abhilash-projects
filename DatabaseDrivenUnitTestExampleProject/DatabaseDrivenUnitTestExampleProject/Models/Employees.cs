using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DatabaseDrivenUnitTestExampleProject.Models
{
    public class Employees
    {
        public string Name { get; set; }
        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Regex regex = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                Match match = regex.Match(value);
                if(match.Success)
                {
                    _email = Email;
                }
                else
                {
                    throw new Exception("Invalid Email Address");
                }
            }
        }
    }
}
