using System;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post();
            Post p2 = new Post("Thanks for the birthday wishes", "Abhilash");
            Post p3 = new Post("Hello everyone", "ABhilash");
            ImagePost ip1 = new ImagePost("My new shoes", "http://images/shoes", "Abhishek");
            VideoPost vp1 = new VideoPost("Funny Video", "http://videos/funny", 20, "Rahul");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(ip1.ToString());
            Console.WriteLine(vp1.ToString());
            p1.sendMessage("Hello there");
            Console.WriteLine(p1.getDate());
            vp1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            vp1.Stop();
            Console.Read();
        }
    }
}
