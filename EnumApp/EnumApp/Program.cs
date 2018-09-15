using System;

namespace EnumApp
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };

    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;

            Day a = Day.Fri;

            Console.WriteLine(a == fr);

            Console.WriteLine((int)Day.Fri);

        }
    }
}
