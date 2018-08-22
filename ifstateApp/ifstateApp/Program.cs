using System;

namespace ifstateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, password, wantToLogin, username, pwd;

            Console.WriteLine("Please register to login");
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter password");
            password = Console.ReadLine();
            Console.WriteLine("Do you want to login? Press y or n");
            wantToLogin = Console.ReadLine();
            wantToLogin = wantToLogin.ToLower();
            if (wantToLogin == "y") 
            {
                Console.WriteLine("Please enter username");
                username = Console.ReadLine();
                Console.WriteLine("Please enter password");
                pwd = Console.ReadLine();
                if (username == name && pwd == password)
                {
                    Console.WriteLine("Hello " + name + " You are logged in");
                }

            } else {
                Console.Write("Bye");
            }
            Console.Read();

        }
    }
}
