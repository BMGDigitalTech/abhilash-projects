using System;

namespace AvgApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0, score = 0, currentScore = 0;
            string input = "";
            int counter = 0;
            try
            {
                Console.WriteLine("Please enter the score and -1 to quit");

                while (input != "-1")
                {

                    input = Console.ReadLine();
                    currentScore = double.Parse(input);
                    if (currentScore > 20)
                    {
                        Console.WriteLine("Please enter values below 20");
                        continue;
                    }
                    if (currentScore == -1)
                    {
                        break;
                    }
                    else
                    {
                        score += currentScore;
                        counter++;
                    }
                    Console.WriteLine("Total entered : " + counter);
                    Console.WriteLine("Total score " + score);
                }

                average = FindAverage(score, counter);
                Console.WriteLine("Average :" + average);

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Score should be numeral value");
            }
            catch (Exception)
            {
                Console.WriteLine("An Error occured");
            }
            Console.ReadLine();
        }

        public static double FindAverage(double tscore, int counter)
        {
            return tscore / counter;
        }
    }
}
