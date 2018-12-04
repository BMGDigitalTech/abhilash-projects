using System;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            var hmac = new System.Security.Cryptography.HMACSHA512();
            byte[] saltkey = hmac.Key;
            string salt = "";
            string pwdHash = "";
            foreach(var ele in saltkey)
            {
                salt += ele.ToString();
            }

           var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("password"));
            foreach(var ele in passwordHash)
            {
                pwdHash += ele.ToString();
            }
            Console.WriteLine(pwdHash);
            Console.WriteLine(salt);

            Console.ReadLine();
        }
    }
}
