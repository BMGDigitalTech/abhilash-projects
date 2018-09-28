using System;
using System.Reflection;

namespace ReflectionLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("ReflectionLateBinding.Customer");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Abhilash";
            parameters[1] = "N";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);

        }
    }

    class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }

}
