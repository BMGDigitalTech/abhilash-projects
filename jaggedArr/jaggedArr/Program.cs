using System;

namespace jaggedArr
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare jagged array
            int[][] jaggedArray = new int[][]
            {
                new int[] {2,3,4,5,6},
                new int[] {1,2,3},
                new int[] {7,8,9,10}
            };
            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray[1][2]);

            for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("{0} ", jaggedArray[i][j]);
                }
            }

            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Abhishek", "Karthik"},
                new string[]{"Anup","Anushree"},
                new string[]{"Raj Kishor", "Raj Kiran"}
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[1][1], friendsAndFamily[2][1]);

            Console.ReadLine();


        }
    }
}
