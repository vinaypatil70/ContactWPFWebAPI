using PrismMVVMTestProject.Models;
using PrismMVVMTestProject.Enums;
using Prism.Mvvm;
using Prism.Commands;
using System.Collections.ObjectModel;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using Microsoft.Win32;
using System.Windows.Media.Imaging;
using PrismMVVMTestProject.Properties;
using System.Linq;

namespace PrismMVVMTestProject.ViewModels
{
    public class ContactViewModel : BindableBase
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts.json";

        private int tabSelectedIndex = 0;
        private Contact contact;
        private ObservableCollection<Contact> contacts;

        public Contact Contact
        {
            get { return contact; }
            set { SetProperty(ref contact, value); }
        }

        public int TabSelectedIndex
        {
            get { return tabSelectedIndex; }
            set { SetProperty(ref tabSelectedIndex, value); }
        }
        
        public ObservableCollection<Contact> Contacts
        {
            get { return contacts; }
            set { SetProperty(ref contacts, value); }
        }
     
        public ICommand cmdSaveContact { get; set; }
        public ICommand cmdReset { get; set; }

        public ContactViewModel()
        {
            this.cmdSaveContact = new DelegateCommand(SaveContact);
            this.cmdReset = new DelegateCommand(Reset);
            Load();
        }

        private void Load()
        {
            Contact = new Contact();
            Contacts = LoadContacts();
        }

        private ObservableCollection<Contact> LoadContacts()
        {
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            if (System.IO.File.Exists(filePath))
            {
                string json = System.IO.File.ReadAllText(filePath);
                contacts = new ObservableCollection<Contact>(Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>(json));
            }
            return contacts;
        }

        private void SaveContact()
        {
            if (ValidateContact())
            {
                Contacts.Add(Contact);
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Contacts);
                System.IO.File.WriteAllText(filePath, json);
                MessageBoxResult result = MessageBox.Show(Resources.SaveMessage, Resources.Save, MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    ShowContactDetails();
                    Reset();
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(Resources.ValidationErrorMessage, Resources.Validation, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private bool ValidateContact()
        {
            if (Contact != null)
            {
                if (!string.IsNullOrEmpty(Contact.FirstName) && !string.IsNullOrEmpty(Contact.LastName))
                {
                    return true;
                }
            }

            return false;
        }

        private void Reset()
        {
            Contact = new Contact();
        }

        private void ShowContactDetails()
        {
            TabSelectedIndex = 0;
        }
    }
}


