using System;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("ReflectionApp.Customer");
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine("Properties of class customer");
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }

            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Methods of class customer");
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Constructors of class customer");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }
        }
    }
}
