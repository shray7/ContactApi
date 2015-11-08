using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactAPI.Models
{
    public class ContactContext  : DbContext
    {
        public DbSet<Contact> ContactSet { get; set; }
        public ContactContext() : base("DefaultConnection")
        { }

        public virtual void Delete(Contact contact)
        {
            ContactSet.Attach(contact);
            ContactSet.Remove(contact);
            SaveChanges();
        }
    }
}