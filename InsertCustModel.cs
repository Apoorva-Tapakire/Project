using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApplication.Models
{
    public class InsertCustModel
    {
        public int CustomerId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNo { get; set; }
        public string City { get; set; }

    }
}