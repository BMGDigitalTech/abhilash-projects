using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Models
{
    public class Author
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
