using System;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // imutable - limited to one type
            int[] scores = new int[] { 99, 96, 97, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(28);

            list.ForEach(i => Console.WriteLine(i));

            list.Sort();
            list.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("Remove from index 1, 2 elements");
            list.RemoveRange(1, 2);
            list.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("Check for number 4 in the list");
            Console.WriteLine(list.Contains(4));

            Console.WriteLine("Find the index of 4 in the list");
            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(index);

            // Remove 4
            Console.WriteLine("Remove 4 at postion " + index);
            list.RemoveAt(index);

            list.ForEach(x => Console.WriteLine(x));

            System.Collections.ArrayList arrList = new System.Collections.ArrayList();
            arrList.Add(1);
            arrList.Add(2.6);
            arrList.Add("three");
            arrList.Add(new Number { n = 4 });
        
            foreach(object o in arrList)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();

        }
    }

    class Number
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
