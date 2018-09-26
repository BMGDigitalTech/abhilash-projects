using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = null;
            try
            {
                stream = new StreamReader(@"C:\Users\cer\source\repos\ExceptionHandling\TextFile.txt");
                Console.WriteLine(stream.ReadToEnd());
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                if(stream != null)
                    stream.Close();
            }
        }
    }
}
