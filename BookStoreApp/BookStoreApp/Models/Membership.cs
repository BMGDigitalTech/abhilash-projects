using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public enum Genre
    {
        Regular,
        Silver,
        Gold
    }
    public class Membership
    {
        public int Id { get; set; }
        public DateTime Initiated { get; set; }
        public Genre Genre { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
