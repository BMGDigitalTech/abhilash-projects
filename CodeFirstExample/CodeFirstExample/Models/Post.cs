using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstExample.Models
{
    class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
