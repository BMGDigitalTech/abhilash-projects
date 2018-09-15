using System;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing to text file
            string[] lines1 = { "first line", "second line", "third line" };

            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("Current Directory" + path);
            File.WriteAllLines(path + @"\Text1.txt",  lines1);

            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"c:\users\acer\source\repos\ReadFile\ReadFile\" + fileName + ".txt", input);

            using (StreamWriter file = new StreamWriter(@"c:\users\acer\source\repos\ReadFile\ReadFile\Text2.txt"))
            {
                foreach(string line in lines1)
                {
                    if(line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Example 1 - reading text

            string text = System.IO.File.ReadAllText(@"c:\users\acer\source\repos\ReadFile\ReadFile\Text.txt");

            Console.WriteLine("Textfile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"c:\users\acer\source\repos\ReadFile\ReadFile\Text.txt");

            Console.WriteLine("Contents of textfile.txt = ");

            foreach(string line in lines)
            {
                Console.WriteLine("\t " + line);
            }
            Console.ReadKey();
        }
    }
}
