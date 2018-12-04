using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstEFCoreApp.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public bool Completed { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime CompletedAt { get; set; }

    }
}
