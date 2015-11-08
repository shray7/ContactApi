using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactAPI.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneTypeCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}