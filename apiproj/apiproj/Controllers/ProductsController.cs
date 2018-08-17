using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiproj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private static List<Product> p = new List<Product>(new[]
        {
            new Product() { ID = 1, Name = "Sauce"},
            new Product() { ID = 2, Name = "Maggie"},
            new Product() {ID = 3, Name = "Wheat floor"}
        });

        [HttpGet]
        public List<Product> Get()
        {
            return p;
        }

        [HttpGet("{id}")] //capture route parameter
        public IActionResult Get(int id)
        {
            var product = p.SingleOrDefault(p => p.ID == id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            p.Add(product);
            return CreatedAtAction(nameof(Get),
                new { id = product.ID }, product);
        }
    }
}