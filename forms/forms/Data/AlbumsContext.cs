using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace forms.Models
{
    public class AlbumsContext : DbContext
    {
        public AlbumsContext (DbContextOptions<AlbumsContext> options)
            : base(options)
        {
        }

        public DbSet<forms.Models.Albums> Albums { get; set; }
    }
}
