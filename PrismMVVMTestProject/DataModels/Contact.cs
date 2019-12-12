using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMVVMTestProject.DataModels
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public List<string> EmailIds { get; set; }
        public DateTime DOB { get; set; }
    }
}
