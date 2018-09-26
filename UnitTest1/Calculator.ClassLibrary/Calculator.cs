using System;

namespace Calculator.ClassLibrary
{
    public class Calculator
    {
        public static int divide(int a, int b)
        {
            int r = 0;
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be Zero");
                }
                else
                {
                    r = a / b;
                }

            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Denominator cannot be Zero", ex);
                throw;
            }
            return r;
        }

        public static int Add(int fn, int sn)
        {
            if(isPositive(fn) && isPositive(sn))
            {
                return fn + sn;
            } else
            {
                throw new ArgumentException("Only positive numbers are allowed");
            }
            
        }

        private static bool isPositive(int n)
        {
            return n > 0;
        }

        public static void FindFactorial(int num)
        {
            try
            {
                if(num == 0)
                {
                    Console.WriteLine("factorial of zero = 1");
                } 
                else if(num < 0)
                {
                    Console.WriteLine("Please enter a positive number");
                } else
                {
                    double dfactResult = 1;
                    for(int i = num; i >= 1; i--)
                    {
                        dfactResult = dfactResult * 1;
                    }
                    Console.WriteLine("Factorial of {0} = {1}", num, dfactResult);
                }
            
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number", num);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter number between 1 and {0}", Int32.MaxValue);
            }
            catch (Exception)
            {
                Console.WriteLine("There is a problem! Please try again later");
            
            }
        }
    }
}
