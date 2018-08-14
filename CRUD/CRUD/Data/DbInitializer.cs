using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class DbInitializer
    {
        public static void Initialize(CrudContext context)
        {
            context.Database.EnsureCreated();

            if(context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {
                new Person {FirstName = "John", LastName = "Johnson", Email = "john@example.com", Age = 32, Subscribed = true},
                new Person {FirstName = "Bob", LastName = "Bobson", Email = "bob@example.com", Age = 35, Subscribed = true},
                new Person {FirstName = "Sally", LastName = "Stevens", Email = "sally@example.com", Age = 24, Subscribed = false},
            };

            foreach(Person p in people)
            {
                context.People.Add(p);
            }
            context.SaveChanges();
        }
    }
}
