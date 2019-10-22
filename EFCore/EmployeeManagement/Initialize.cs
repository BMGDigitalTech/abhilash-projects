using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Initialize
    {
        public static EmployeeManagementContext GetContext()
        {
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EmployeeManagementDB;Trusted_Connection=true;";
            DbContextOptionsBuilder<EmployeeManagementContext> options = new DbContextOptionsBuilder<EmployeeManagementContext>();
            options.UseSqlServer(connectionString);
            return new EmployeeManagementContext(options.Options);
        }
    }
}
