using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using PrismMVVMTestProject.Enums;

namespace PrismMVVMTestProject.Models
{
    public class Contact : BindableBase
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                SetProperty(ref firstName, value);
                OnPropertyChanged("FullName");
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                SetProperty(ref lastName, value);
                OnPropertyChanged("FullName");
            }
        }

        public string FullName { get { return string.Format("{0} {1}", firstName, lastName); } }

        private List<string> phoneNumbers;
        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
            set
            {
                SetProperty(ref phoneNumbers, value);
            }
        }

        private List<string> emails;
        public List<string> Emails
        {
            get { return emails; }
            set
            {
                SetProperty(ref emails, value);
            }
        }

        private DateTime dob = DateTime.Now;
        public DateTime DOB
        {
            get { return dob.Date; }
            set
            {
                SetProperty(ref dob, value);
            }
        }
    }
}
