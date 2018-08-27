using System;

namespace arrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            for (int i = 0; i < grades.Length; i++) {
                Console.WriteLine("Grades[{0}] = {1}",i,grades[i]);
            }
         

            int[] classA = { 20, 30, 12, 5, 8 };
            for (int i = 0; i < classA.Length; i++)
            {
                Console.WriteLine("ClassA[{0}] = {1}", i, classA[i]);
            }

            int[] classB = new int[] { 15, 25, 45, 95, 78 };
            for (int i = 0; i < classB.Length; i++)
            {
                Console.WriteLine("ClassB[{0}] = {1}", i, classB[i]);
            }

            string[] myFriends = new string[] { "Abhishek", "raj", "ravi", "rohit", "sachin", "kiran" };

            foreach(string friend in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", friend);
            }
            Console.ReadLine();
        }   
    }
}
