using System;
using System.Collections.Generic;

namespace ContactWebAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public List<string> EmailIds { get; set; }
        public DateTime DOB { get; set; }
    }
}