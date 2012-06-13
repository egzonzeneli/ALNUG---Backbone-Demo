using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALNUG.WebEv2012.Contacs.Controllers
{
    public class FakeContacts
    {
        public IEnumerable<Contact> GetConntacts()
        {
            var contacts = new List<Contact>();

            contacts.Add(new Contact
            {
                FirstName = "Egzon",
                LastName = "Zeneli",
                Number = "04x100100"
            });

            contacts.Add(new Contact
            {
                FirstName = "Valon",
                LastName = "Canhasi",
                Number = "04x100200"
            });

            contacts.Add(new Contact
            {
                FirstName = "Betim",
                LastName = "Drenica",
                Number = "04x100300"
            });

            contacts.Add(new Contact
            {
                FirstName = "Xhelal",
                LastName = "Jashari",
                Number = "04x100400"
            });

            contacts.Add(new Contact
            {
                FirstName = "Dukagjin",
                LastName = "Maloku",
                Number = "04x100500"
            });


            contacts.Add(new Contact
            {
                FirstName = "Arian",
                LastName = "Celina",
                Number = "04x100600"
            });

            contacts.Add(new Contact
            {
                FirstName = "Rexhep",
                LastName = "Kqiku",
                Number = "04x100700"
            });
            contacts.Add(new Contact
            {
                FirstName = "Adem",
                LastName = "Gashi",
                Number = "04x100800"
            });
            contacts.Add(new Contact
            {
                FirstName = "Qendrim",
                LastName = "Jusufi",
                Number = "04x100900"
            });

            return contacts;
        }
    }
}