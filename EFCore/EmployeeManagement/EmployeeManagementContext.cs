﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeManagementContext : DbContext
    {
        

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }
        */

        public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> options) : base (options)
        {
            Database.Migrate();
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
