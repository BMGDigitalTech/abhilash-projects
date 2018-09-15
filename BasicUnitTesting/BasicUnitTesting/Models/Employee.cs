using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BasicUnitTesting.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public interface ICompanyDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }

    public class CompanyDbContext:DbContext, ICompanyDbContext
    {
        private readonly string connectionString;

        public CompanyDbContext(string connectionString) : base()
        {
            this.connectionString = connectionString;
        }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }

    
}
