using System;
using System.Collections.Generic;

namespace PrismMVVMTestProject.DataModels
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public List<string> EmailIds { get; set; }
        public DateTime DOB { get; set; }
    }
}
