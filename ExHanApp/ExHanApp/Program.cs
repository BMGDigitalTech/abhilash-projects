using System;

namespace ExHanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool flag1 = true, flag2 = true;
                do
                {
                    Console.WriteLine("Please enter Numberator value");
                    int num;
                    bool nsuccess = Int32.TryParse(Console.ReadLine(), out num);
                    if (nsuccess)
                    {
                        flag1 = false;
                        do
                        {
                            Console.WriteLine("Please enter Denominator value");
                            int den;
                            bool dsuccess = Int32.TryParse(Console.ReadLine(), out den);
                            if (dsuccess && den != 0)
                            {
                                flag2 = false;
                                double result = num / den;
                                Console.WriteLine("Result =" + result);
                            }
                            else if (den == 0)
                            {
                                Console.WriteLine("Denominator cannot be zero");
                            }
                            else
                            {
                                Console.WriteLine("Please enter valid numbers between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                            }
                        } while (flag2);
                        
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid numbers between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                    }
                } while (flag1);          
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numerical value");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter values between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
