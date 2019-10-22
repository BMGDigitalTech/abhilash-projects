using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Models;

namespace BookStoreApp.Data
{
    public static class AppDbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this AppDbContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.AddRange(new Author[]
                {
                    new Author()
                    {
                        FirstName = "Sunil",
                        LastName = "Dutt",
                        Dob = new DateTime(1985, 2, 5),
                        Nationality = "Indian"
                    },
                    new Author()
                    {
                        FirstName = "Akshay",
                        LastName = "Khana",
                        Dob = new DateTime(1955, 2, 8),
                        Nationality = "Indian"
                    }
                });
                    context.SaveChanges();
                    //throw new Exception("Fake exception");

                    if (!context.Books.Any())
                    {
                        var author1 = context.Authors.SingleOrDefault(a => a.FirstName.Equals("Sunil") && a.LastName.Equals("Dutt"));
                        var author2 = context.Authors.SingleOrDefault(a => a.FirstName.Equals("Akshay") && a.LastName.Equals("Khana"));

                        context.Books.AddRange(new Book[]
                        {
                    new Book()
                    {
                        AuthorId = author1.Id,
                        Isbn = "111111",
                        Title= "Book 1"
                    },
                    new Book()
                    {
                        AuthorId = author2.Id,
                        Isbn = "222222",
                        Title = "Book 2"
                    }
                        });
                        context.SaveChanges();
                        transaction.Commit();
                    }
                }
                catch(Exception e)
                {
                    transaction.Rollback();
                }
                
            }
            
            
        }

       
    }
}
