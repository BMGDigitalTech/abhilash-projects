using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonsoftJsonApp
{
    class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime createdDate { get; set; }
        public IList<string>Roles { get; set; }
    }
}
