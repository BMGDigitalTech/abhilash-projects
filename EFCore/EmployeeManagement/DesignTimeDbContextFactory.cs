using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmployeeManagementContext>
    {
        public EmployeeManagementContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeManagementContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EmployeeManagementDB;Trusted_Connection=True;");

            return new EmployeeManagementContext(optionsBuilder.Options);
        }
    }
}
