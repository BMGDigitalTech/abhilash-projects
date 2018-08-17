using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace forms.Models
{
    public class Albums
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        [Required]
        [StringLength(60, MinimumLength =3)]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genere { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(0, 100.00)]
        public decimal Price { get; set; }
    }
}
