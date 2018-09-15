using System;

namespace RandomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int[] score = new int[10];
            for(int i = 0; i < score.Length; i++)
            {
                score[i] = dice.Next(1, 7);
            }
            int sum = 0;
            foreach(int pt in score)
            {
                Console.WriteLine(pt);
                sum += pt;
            }

            Console.WriteLine("Score = " + sum);
        }
    }
}
