using System;
using Prism.Mvvm;

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

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                SetProperty(ref phoneNumber, value);
            }
        }

        private string emailId;
        public string EmailId
        {
            get { return emailId; }
            set
            {
                SetProperty(ref emailId, value);
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
