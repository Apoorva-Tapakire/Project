using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalLibrary
{
    public class CustomerBAL
    {
        public int CustomerId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNo { get; set; }
        public string City { get; set; }

        public string AdminId { get; set; }
        public string AdminPassword { get; set; }

    }
}

