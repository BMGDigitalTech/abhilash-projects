using System;

namespace structApp
{
    public struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game name is: {0}", name);
            Console.WriteLine("Game was developed by: {0}", developer);
            Console.WriteLine("Game rating is: {0}", rating);
            Console.WriteLine("Game was released in: {0}", releaseDate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon go";
            game1.developer = "poke";
            game1.rating = 3.5;
            game1.releaseDate = "March 2016";
            game1.Display();


        }
    }
}
