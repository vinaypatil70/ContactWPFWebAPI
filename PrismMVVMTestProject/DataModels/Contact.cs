using System;

namespace PrismMVVMTestProject.DataModels
{
    public class Contact
    {
        public bool IsChecked { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public DateTime DOB { get; set; }
    }
}
