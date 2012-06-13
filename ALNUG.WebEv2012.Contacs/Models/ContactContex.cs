using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ALNUG.WebEv2012.Contacs.Controllers
{
    public class ContactDbContex : DbContext 
    {
        public ContactDbContex()
            : base("alnug")
        {
            //Database.SetInitializer(new ContactManagerInitializer());
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        
    }

    public class ContactManagerInitializer : DropCreateDatabaseAlways<ContactDbContex>
    {
        protected override void Seed(ContactDbContex context)
        {
            var list = new FakeContacts().GetConntacts();

            foreach(var c in list)
            {
                context.Contacts.Add(c);
            }

            context.SaveChanges();
        }
    }
}