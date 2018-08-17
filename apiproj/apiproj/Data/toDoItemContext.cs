using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace apiproj.Models
{
    public class toDoItemContext : DbContext
    {
        public toDoItemContext (DbContextOptions<toDoItemContext> options)
            : base(options)
        {
        }

        public DbSet<apiproj.Models.TodoItem> TodoItem { get; set; }
    }
}
