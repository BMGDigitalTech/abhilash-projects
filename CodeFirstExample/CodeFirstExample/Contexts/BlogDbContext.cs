using CodeFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Contexts
{
    class BlogDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PostDB;Trusted_Connection=True;");
        }
        public DbSet<Post> Posts { get; set; }
    }
}
