using System;

namespace multidimArr
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 dimensional array
            int[,] arr2d = new int[,]
            {
                {0,1,2,3 },
                {4,5,6,7 },
                {8,9,10,11 },
                {12,13,14,15 }
            };
            Console.WriteLine(arr2d[2,2]);

            //3 dimensional array
            int[,,] arr3d = new int[,,]
            {
                {
                    {1,2,3 },
                    {4,5,6 }
                },
                {
                    {7,8,9 },
                    {10,11,12 }
                }
            };
            Console.WriteLine(arr3d[1,1,0]);
            Console.ReadKey();
        }
    }
}
