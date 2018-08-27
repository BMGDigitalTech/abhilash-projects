using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace cprops
{
    class Members
    {
        //member - private fields
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        //member - public field
        public int age;

        //member - property - exposes jobTitle safely
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;    
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}",salary);
        }

        //public member Method - can be called from other classes
        public void Introducting(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, jobTitle, age);

            }
        }

        //Constructor
        public Members()
        {
            age = 30;
            memberName = "Abhilash";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statement
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of members object");
        }
    }
}
