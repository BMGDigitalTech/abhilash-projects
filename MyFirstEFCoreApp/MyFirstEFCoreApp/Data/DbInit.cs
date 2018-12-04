using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using MyFirstEFCoreApp.Models;

namespace MyFirstEFCoreApp.Data
{
    public static class DbInit
    {
        public static void InitializeWithFakeData(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if(!context.Contacts.Any())
            {
                context.Contacts.Add(new Contact()
                {
                    FirstName = "Abhilash",
                    LastName = "N",
                    Email = "abhilash@example.com"
                });
            }

            if (!context.ToDos.Any())
            {
                context.ToDos.Add(new ToDo()
                {
                    Text = "Go to gym",
                    Completed = true
                });
            }

            context.SaveChanges();
        }
    }
}
