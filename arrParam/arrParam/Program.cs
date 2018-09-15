using System;

namespace arrParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studGrades = new int[] { 10, 25, 34, 75, 78, 45 };
            double avg = FindAverage(studGrades);
            foreach(int grade in studGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("The average is {0}", avg);
            Console.ReadLine();
        }

        public static double FindAverage(int[] grades)
        {
            int sum = 0;
            double average;
            int size = grades.Length;
            for(int i=0; i < size; i++)
            {
                sum += grades[i];
            }

            average = (double)sum / size;
            return average;
        }
    }
}
