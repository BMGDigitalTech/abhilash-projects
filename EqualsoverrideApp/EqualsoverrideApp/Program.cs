using System;

namespace EqualsoverrideApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Abhilash";
            c1.LastName = "N";

            Customer c2 = new Customer();
            c2.FirstName = "Abhishek";
            c2.LastName = "N";

            if (c1.Equals(c2))
            {
                Console.WriteLine("Are Equal");
            } else
            {
                Console.WriteLine("Are not Equal");
            }
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
           if(obj == null)
            {
                return false;
            }
           if(!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName &&
                 this.LastName == ((Customer)obj).LastName;
        }
    }
}
