﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class PersonalLibrary
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public List<PersonalLibraryBook> PersonalLibraryBooks { get; set; }
    }
}