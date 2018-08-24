using System;

namespace classApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person abhi = new Person();
            //abhi.firstname = "Abhilash";
            //abhi.lastname = "Narayan";
            //abhi.Intro();

            Person abhi = new Person("abhilash", "narayan","1988/10/13");
            abhi.Intro();
            abhi.CalculateAge();


            Console.Read();
        }
    }
}
