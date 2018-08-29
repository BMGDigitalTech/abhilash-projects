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
            Console.ReadLine();


        }
    }
}
