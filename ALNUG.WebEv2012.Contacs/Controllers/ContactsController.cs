using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ALNUG.WebEv2012.Contacs.Controllers;

namespace ALNUG.WebEv2012.Contacs.Controllers
{
    public class ContactsController : ApiController
    {
        ContactDbContex dbContext = new ContactDbContex();

        // GET api/contacts
        public HttpResponseMessage Get()
        {
            var list = dbContext.Contacts.OrderBy(c => c.FirstName).AsEnumerable();
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }

        // GET api/contacts/5
        public HttpResponseMessage Get(int id)
        {
            var contact = dbContext.Contacts.Where(c => c.Id == id);
            if (contact != null)
                return Request.CreateResponse(HttpStatusCode.OK, contact);

            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

        // PUT api/contacts/5
        public HttpResponseMessage PutContactNumber(int id, Contact contact)
        {
            if (ModelState.IsValid && id == contact.Id)
            {
                dbContext.Entry(contact).State = EntityState.Modified;
                try
                {
                    dbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, contact);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        // POST api/ContactNumbers
        public HttpResponseMessage PostContactNumber(Contact contact)
        {
            if (ModelState.IsValid)
            {
                dbContext.Contacts.Add(contact);
                dbContext.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, contact);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = contact.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/ContactNumbers/5
        public HttpResponseMessage DeleteContactNumber(int id)
        {
            Contact contact = dbContext.Contacts.Find(id);
            if (contact == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            dbContext.Contacts.Remove(contact);

            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, contact);
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}
