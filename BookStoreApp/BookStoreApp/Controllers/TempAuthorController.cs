using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;

namespace BookStoreApp.Controllers
{
    [Route("temp-authors")]
    public class TempAuthorController : Controller
    {
        private readonly AppDbContext _context;

        public TempAuthorController(AppDbContext context)
        {
            _context = context;
        }

        [Route("create")]
        public async Task<string> CreateTempAuthor()
        {
            var author = new Author()
            {
                FirstName = "Mark",
                LastName = "Robinson",
                Dob = new DateTime(1926, 01, 12),
                Nationality = "Candian"
            };

            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return "Author successfully added";
        }

        
        [Route("update")]
        public async Task<string> UpdateTempAuthor()
        {
            var author = await (from a in _context.Authors
                                where a.FirstName.Equals("Mark") && a.LastName.Equals("Robinson")
                                select a).SingleOrDefaultAsync();
            if(author == null)
            {
                return "Update failed";
            } else
            {
                if(author.MiddleName == null)
                {
                    author.MiddleName = "jake";
                }
                else
                {
                    author.MiddleName = null;
                }
                _context.Update(author);
                await _context.SaveChangesAsync();
                return "Temp author updated";
            }
        }

       
        [Route("delete")]
        public async Task<string> DeleteTempAuthor()
        {
            var author = await (from a in _context.Authors
                                where a.FirstName.Equals("Mark") && a.LastName.Equals("Robinson")
                                select a).FirstOrDefaultAsync();
            if(author == null)
            {
                return "Author not found";
            }
            else
            {
                _context.Remove(author);
                await _context.SaveChangesAsync();
                return "Author Removed";
            }
        } 
    }
}