using System;

namespace tcfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, numtemp;
            double result;
            try
            {
                Console.WriteLine("Please enter first number");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out numtemp))
                {
                    num1 = numtemp;
                } else
                {
                    num1 = 0;
                }
                Console.WriteLine("Please enter second number");
                input = Console.ReadLine();
                if(Int32.TryParse(input, out numtemp))
                {
                    num2 = numtemp;
                } else
                {
                    num2 = 0;
                }
                Console.WriteLine("Please enter operator to perform calculation");
                input = Console.ReadLine();
                switch (input)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter valid number");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Could not run");
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
