using System;

namespace MulticastDelegate
{
    public delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate sd1, sd2, sd3, sd4;
            sd1 = new SampleDelegate(SampleMethod1);
            sd2 = new SampleDelegate(SampleMethod2);
            sd3 = new SampleDelegate(SampleMethod3);
            // Assign all 3 functions to sd4
            //sd4 = sd1 + sd2 + sd3;

            // Remove function 2;
            sd4 = sd1 + sd2 + sd3 - sd2;
            //sd4();

            // Method 2:
            SampleDelegate sd5 = new SampleDelegate(SampleMethod1);
            sd5 += SampleMethod2;
            sd5 += SampleMethod3;
            sd5();




        }

        public static void SampleMethod1()
        {
            Console.WriteLine("Sample Method 1");
        }

        public static void SampleMethod2()
        {
            Console.WriteLine("Sample Method 2");
        }

        public static void SampleMethod3()
        {
            Console.WriteLine("Sample Method 3");
        }




    }
}
