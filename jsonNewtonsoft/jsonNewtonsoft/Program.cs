using Newtonsoft.Json;
using System;

namespace jsonNewtonsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory
            {
                Name = "My Documents",
                Files =
                {
                    "ImportantLegalDocuments.docx",
                    "WiseFinancialAdvice.xlsx"
                }
            };

            string json = JsonConvert.SerializeObject(directory, Formatting.Indented);

            Console.WriteLine(json);


            User user = new User
            {
                FirstName = "Abhilash",
                LastName = "Narayan",
                SnakeRating = 10
            };

            string json1 = JsonConvert.SerializeObject(user, Formatting.Indented);

            Console.WriteLine(json1);

            Videogame starcraft = new Videogame
            {
                Name = "Starcraft",
                ReleaseDate = new DateTime(1998, 1, 1)
            };

            string json2 = JsonConvert.SerializeObject(starcraft, Formatting.Indented);

            Console.WriteLine(json2);
        }
    }
}
