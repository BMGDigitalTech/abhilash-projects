using System;
using System.Collections.Generic;

namespace CountryCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Country c1 = new Country() { Code = "AUS", Name = "Australia", Captial = "Canberra" };
            Country c2 = new Country() { Code = "IND", Name = "India", Captial = "Delhi" };
            Country c3 = new Country() { Code = "USA", Name = "United States", Captial = "Washington D.C" };
            Country c4 = new Country() { Code = "GBR", Name = "United Kingdom", Captial = "London" };
            Country c5 = new Country() { Code = "CAN", Name = "Canada", Captial = "Ottawa" };

            Dictionary<string, Country> dicCtry = new Dictionary<string, Country>();
            dicCtry.Add(c1.Code, c1);
            dicCtry.Add(c2.Code, c2);
            dicCtry.Add(c3.Code, c3);
            dicCtry.Add(c4.Code, c4);
            dicCtry.Add(c5.Code, c5);

            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter the country code");
                string usercode = Console.ReadLine().ToUpper();
                if (dicCtry.ContainsKey(usercode))
                {
                    Country resultCountry = dicCtry[usercode];
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Captial);
                } else
                {
                    Console.WriteLine("Invalid country code");
                }
                do
                {
                    Console.WriteLine("Press Yes to continue No to quit");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "YES" && userChoice != "NO");
                    
                
                
                
            } while (userChoice == "YES" && userChoice != "NO");

        }
    }
}
