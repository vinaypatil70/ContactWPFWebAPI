﻿using ContactWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;

namespace ContactWebAPI.Controllers
{
    public class ContactController : ApiController
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts.json";

        private List<Contact> LoadContacts()
        {
            List<Contact> contacts = new List<Contact>();
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                contacts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>(json);
            }
            return contacts;
        }

        // GET api/contact
        public IEnumerable<Contact> Get()
        {
            return LoadContacts();
        }

        // GET api/contact/00000000-0000-0000-0000-000000000000
        public Contact GetContact(Guid id)
        {
            var contact = LoadContacts().FirstOrDefault((p) => p.Id == id);
            if (contact == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return contact;
        }

        //POST api/contact
        public void Post([FromBody]List<Contact> lstcontact)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(lstcontact);
            System.IO.File.WriteAllText(filePath, json);
        }

        //POST api/contact
        public bool UpdateContact([FromBody]Contact objContact)
        {
            var lstcontact = LoadContacts();
            int index = lstcontact.IndexOf(objContact);
            lstcontact.RemoveAt(index);
            lstcontact.Insert(index, objContact);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(lstcontact);
            System.IO.File.WriteAllText(filePath, json);
            return true;
        }

        //
        public void DeleteAllContacts()
        {
            System.IO.File.Delete(filePath);
        }

        public void DeleteContact(Guid id)
        {
            var lstcontact = LoadContacts().ToList();
            Contact objContact = lstcontact.Where(x => x.Id == id).FirstOrDefault();
            int index = lstcontact.IndexOf(objContact);
            lstcontact.RemoveAt(index);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(lstcontact);
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}