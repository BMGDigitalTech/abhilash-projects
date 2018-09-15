﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace LambExp
{
    class Program
    {
        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(5));

            SomeMath tenz = new SomeMath(TimesTen);
            Console.WriteLine(tenz(5));

            // Lambada expression
            SomeMath sum = new SomeMath(i => i + 3);
            Console.WriteLine(sum(2));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            Console.WriteLine("Even numbers are");
            foreach(int even in evenNumbers)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("Odd numbers are");
            List<int> oddNumbers = list.FindAll(i => i % 2 == 1);
            oddNumbers.ForEach(i => Console.WriteLine(i));

            math = new SomeMath(x => x * x * x);
            Console.WriteLine(math(3));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp( 5, new Number { n = 5 }));

            Console.ReadKey();

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int i)
        {
            return i * i;
        }

        public static int TimesTen(int i)
        {
            return i * 10;
        }
    }

    public class Number
    {
        public int n { get; set; }
    }
}
