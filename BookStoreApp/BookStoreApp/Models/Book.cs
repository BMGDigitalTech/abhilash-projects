using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Isbn { get; set; }

        public string FullTitle
        {
            get
            {
                return $"{Author.FullName}'s {Title}";
            }
        }

        public List<PersonalLibraryBook> PersonalLibraryBooks { get; set; }

        /*  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public DateTime CreatedAt { get; set; } */
    }
}
