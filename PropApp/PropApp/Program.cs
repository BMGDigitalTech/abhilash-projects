using System;

namespace PropApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.SetId(1);
            s1.SetSubject("Maths");
            s1.SetMarks(40);

            Console.WriteLine("Student Id: " + s1.GetId());
            Console.WriteLine("Subject: " + s1.GetSubject());
            s1.GetResult();

            Employee e1 = new Employee();
            e1.Id = 1;
            e1.Name = "Abhilash";
            e1.Salary = 50000.00;

            Console.WriteLine("Employee id: {0} ", e1.Id);
            Console.WriteLine("Employee name: {0}", e1.Name);
            Console.WriteLine("Employee salary: {0}", e1.Salary);
        }
    }
}
