using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactAPI.Controllers
{
    public class AddressBookController : ApiController
    {
        [HttpGet]
        public Contact GetContact()
        {
            return new Contact
            {
                FirstName = "Shreyas",
                LastName = "Hirekhan",
                Email = "shray@umich.edu",
                PhoneNumber = 1112223333,
                PhoneTypeCode = "MOBILE"
            };
        }

        [HttpPost]
        public IHttpActionResult AddContact(Contact contact)
        {
            if (contact == null) return BadRequest();
            using (var db = new ContactContext())
            {
                db.ContactSet.Add(contact);
                db.SaveChanges();
            }
            return Ok();
        }
    }
}
