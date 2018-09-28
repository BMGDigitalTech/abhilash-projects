using Newtonsoft.Json;
using System;

namespace Newtonsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var definition = new { Name = "" };

            string json1 = @"{'Name':'James'}";
            var customer1 = JsonConvert.DeserializeAnonymousType(json1, definition);

            Console.WriteLine(customer1.Name);

            string json2 = @"{'Name':'Mike'}";
            var customer2 = JsonConvert.DeserializeAnonymousType(json2, definition);

            Console.WriteLine(customer2.Name);

            string json = @"{
    ""Username"": ""domain\\username"",
    ""Enabled"":true
}";

          // User user = JsonConvert.DeserializeObject<User>(json);

            // Console.WriteLine(user.UserName);

            User user1 = new User(@"domain\abhilash", true);

            string json3 = JsonConvert.SerializeObject(user1, Formatting.Indented);
            Console.WriteLine(json3);

            User user2 = new User(@"domain\anup", true)
            {
                Status = UserStatus.Deleted
            };

            string json4 = JsonConvert.SerializeObject(user2, Formatting.Indented);

            Console.WriteLine(json4);

            Console.ReadKey();
        }
    }
}
