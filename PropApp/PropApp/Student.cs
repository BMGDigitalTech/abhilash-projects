using System;
using System.Collections.Generic;
using System.Text;

namespace PropApp
{
    class Student
    {
        private int id;
        private string subject;
        private double marks;
        private const int passmark = 35;

       public void SetId(int id)
        {
            if(id < 1)
            {
                throw new Exception("Id cannot be negative");
            }
            else
            {
                this.id = id;
            }
        } 
        
        public int GetId()
        {
            return this.id;
        }

        public void SetSubject(string subject)
        {
            if(subject == null || subject == "")
            {
                throw new Exception("Please enter subject");
            } else
            {
                this.subject = subject;
            }
        }

        public string GetSubject()
        {
            return this.subject;
        }

        public void SetMarks(double marks)
        {
            if(marks < 0)
            {
                throw new Exception("Marks cannot be negative");
            } else
            {
                this.marks = marks;
            }
        }

        public void GetResult()
        {
            if(this.marks < passmark)
            {
                Console.WriteLine("You have failed the test");
            } else
            {
                Console.WriteLine("You have passed the test");
            }
        }
    }
}
