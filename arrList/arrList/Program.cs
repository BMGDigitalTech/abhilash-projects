using System;
using System.Collections;

namespace arrList
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring array list with undefined amount of object
            ArrayList myArrayList = new ArrayList();

            //declaring array list with defined amount of object
            ArrayList myArrayList2 = new ArrayList(10);


            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            Console.WriteLine("Total items in ArrayList {0}", myArrayList.Count);

            Console.WriteLine("Items in ArrayList are");
            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }
            double sum=0.0;
            foreach(object ob in myArrayList)
            {
                if(ob is int)
                {
                    sum += Convert.ToDouble(ob);
                }

                if(ob is double)
                {
                    sum += (double)ob;
                }

                if(ob is string)
                {
                    Console.WriteLine(ob);
                }
            }

            Console.WriteLine("Sum of numbers in array list is "+ sum);
            Console.ReadLine();

            //delete element with specific  value from the arraylist
            myArrayList.Remove(13);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine("Items after Deletion in ArrayList are");
            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
