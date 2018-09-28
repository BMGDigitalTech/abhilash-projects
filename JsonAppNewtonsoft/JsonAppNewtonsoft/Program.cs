using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Converters;
using System.Linq;

namespace JsonAppNewtonsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGame game1 = new VideoGame
            {
                Name = "Starcraft",
                ReleaseDate = new DateTime(1998, 1, 1),
                Price = 100.00
            };

            string json = JsonConvert.SerializeObject(game1, Formatting.Indented);

            Console.WriteLine(json);

            Account account = new Account
            {
                Email = "abhilash@example.com",
                Active = true,
                CreatedDate = new DateTime(2014, 1, 2, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                    "User",
                    "Admin"
                }
            };

            string json1 = JsonConvert.SerializeObject(account, Formatting.Indented);

            Console.WriteLine(json1);

            // Serialize a collection
            List<string> videoGames = new List<string>()
            {
                "WarCraft", "Age Of Empires", "GTA 4", "GTA 5", "Total Overdose", "Max Payne", "Call Of Duty", "Need for Speed Most Wanted", "Counter strike" 
            };

            string json2 = JsonConvert.SerializeObject(videoGames);

            Console.WriteLine(json2);

            // Serialize a Dictionary
            Dictionary<string, int> points = new Dictionary<string, int>
            {
                {"Abhilash", 1988 },
                {"Arun", 1991 },
                {"Nikhil", 2000 }
            };

            string json3 = JsonConvert.SerializeObject(points, Formatting.Indented);

            Console.WriteLine(json3);

            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"C:\Users\Acer\source\repos\JsonAppNewtonsoft\JsonAppNewtonsoft\movie.json", JsonConvert.SerializeObject(movie, Formatting.Indented));

            // Serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"C:\Users\Acer\source\repos\JsonAppNewtonsoft\JsonAppNewtonsoft\movie2.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }

            // Serialize with JsonConverters

            List<StringComparison> stringComparisons = new List<StringComparison>
            {
                StringComparison.CurrentCulture,
                StringComparison.Ordinal
            };

            string jsonWithoutConverter = JsonConvert.SerializeObject(stringComparisons);

            Console.WriteLine(jsonWithoutConverter);

            string jsonwithConverter = JsonConvert.SerializeObject(stringComparisons, new StringEnumConverter());

            Console.WriteLine(jsonwithConverter);

            List<StringComparison> newStringComparisons = JsonConvert.DeserializeObject<List<StringComparison>>(
                jsonwithConverter, new StringEnumConverter()
                );

            Console.WriteLine(string.Join(", ", newStringComparisons.Select(c => c.ToString()).ToArray()));


        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    class VideoGame
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        public double Price { get; set; }

    }
}
