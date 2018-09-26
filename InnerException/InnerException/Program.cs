using System;
using System.IO;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;
                    Console.WriteLine("Result = " + result);
                }
                catch (Exception ex)
                {
                    string filepath = @"C:\Users\Aer\source\repos\InnerException\InnerException\Log.txt";
                    if (File.Exists(filepath)){
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.WriteLine();
                        sw.Write(ex.StackTrace);
                        sw.Close();
                    } else
                    {
                        throw new FileNotFoundException("Log file not found or path not correct", ex);
                    }
                    Console.WriteLine("Something went wrong, please try again!");
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Current Exception:" + e.Message);
                if(e.InnerException != null)
                    Console.WriteLine("Inner Exception:" + e.InnerException.Message);
            }
        }
    }
}
