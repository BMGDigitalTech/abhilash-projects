using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Data;
using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var books = await _context.Books.AsNoTracking().ToListAsync();
            return View(books);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            else
            {
                int bookId = (int)id;
                var book = await _context.Books.AsNoTracking().SingleOrDefaultAsync(b => b.Id == bookId);
                if(book == null)
                {
                    return NotFound();
                } else
                {
                    return View(book);
                }
            }
        }

        [Route("books/author/{id}")]
        public async Task<IActionResult> GetBookByAuthor(int? id)
        {
            if(id == null)
            {
                return NotFound();
            } else
            {
                int authorId = (int)id;
                var books = await (from b in _context.Books
                             where b.AuthorId == authorId
                             orderby b.Isbn descending
                             select b).ToListAsync();
                if(books == null)
                {
                    return NotFound();
                } else
                {
                    return View("ByAuthor",books);
                }
            }
        }

        [Route("Books/Explicit")]
        public async Task<IActionResult> BooksExplicit()
        {
            var books = await _context.Books.ToListAsync();
            foreach(var book in books)
            {
                await _context.Entry(book).Reference(b => b.Author).LoadAsync();
            }
            return View("Index", books);
        }

        [Route("Books/Eager")]
        public async Task<IActionResult> BooksEager()
        {
            var books = await _context.Books.Include(b => b.Author).ToListAsync();
            return View("Index", books);
        }

        [Route("Books/Raw")]
        public async Task<IActionResult> BooksRaw()
        {
            var books = await _context.Books.FromSql("SELECT * FROM dbo.books")
                .Include(b => b.Author)
                        .AsNoTracking()
                        .ToListAsync();
            return View("Index", books);
        }

        [Route("Books/Raw/Author/{id}")]
        public async Task<IActionResult> BooksByAuthorRaw(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            else
            {
                int authorId = (int)id;
                var books = await _context.Books.FromSql(@"SELECT * FROM dbo.Books Where AuthorId={authorId}")
                            .Include(b => b.Author)
                            .AsNoTracking()
                            .ToListAsync();
                return View("Index", books);

            }
        }

        [Route("books/sp/{firstName}/{lastName}")]
        public async Task<IActionResult> BooksSp(string firstName, string lastName)
        {
            var books = await _context.Books.FromSql($"EXECUTE dbo.BooksByAuthor {firstName}, {lastName}")
                .ToListAsync();
            return View("Index", books);
        }

        // GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Title, AuthorId, Isbn")] Book book)
        {
            if(ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

    }
}