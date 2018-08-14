using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FormTagHelpers.Models
{
    public class Fruit
    {
        [Display(Name = "What is fruit name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode=true)]
        public int Qty { get; set; }

    }
}
