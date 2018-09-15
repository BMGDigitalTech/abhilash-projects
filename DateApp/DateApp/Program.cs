using System;

namespace DateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1988, 10, 13);
            Console.WriteLine("My Birthday is {0}", dt);

            // Write today on screen
            Console.WriteLine("Today's date {0}", DateTime.Today);

            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            Console.WriteLine("{0} o' clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Enter your birthday in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dt))
            {
                Console.WriteLine(dt);
                TimeSpan daysPassed = now.Subtract(dt);
                Console.WriteLine("You are {0} days older", daysPassed.Days);
            } else
            {
                Console.WriteLine("Wrong input ");
            }

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
