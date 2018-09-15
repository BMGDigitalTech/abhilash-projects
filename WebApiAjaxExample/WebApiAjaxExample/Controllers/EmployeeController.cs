using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAjaxExample.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebApiAjaxExample.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly CompanyDbContext _context;

        public EmployeeController(CompanyDbContext context)
        {
            _context = context;
        }

        public List<Employee>Get(string searchStr)
        {
            
            List<Employee> emps = _context.Employees.Where(temp => temp.EmpName.Contains(searchStr)).ToList();
            return emps;
        }
    }
}