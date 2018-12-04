using System;
using System.Linq;

namespace console_webapiclient2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // Update existing data in table
            using(var context  = new SchoolContext())
            {
                var std = context.Students.First<Student>();
                std.Name = "Abhilash";
                context.SaveChanges();
            };

            // Find student name with bill
            /*var context = new SchoolContext();
            var studentWithSameName = context.Students.Where(s => s.Name == GetName()).ToList();
            Console.WriteLine(studentWithSameName.Count);*/


            // Inserting data to student table
            /*using(var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }*/
        }

        public static string GetName()
        {
            return "Bill";
        }
    }
}
