using Prism.Mvvm;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using PrismMVVMTestProject.Properties;
using PrismMVVMTestProject.DataModels;
using System.Net.Http.Headers;
using System;
using System.Linq;

namespace PrismMVVMTestProject.ViewModels
{
    public class ContactViewModel : BindableBase
    {
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
        public ICommand cmdEditContact { get; set; }
        public ICommand cmdDelete { get; set; }

        public ContactViewModel()
        {
            this.cmdSaveContact = new DelegateCommand(SaveContact);
            this.cmdReset = new DelegateCommand(Reset);
            this.cmdEditContact = new DelegateCommand(EditContact);
            this.cmdDelete = new DelegateCommand(DeleteContact);
            Load();
        }

        private async void Load()
        {
            Contact = new Contact();
            Contacts = await LoadContacts();
        }

        private async Task<ObservableCollection<Contact>> LoadContacts()
        {
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync(Resources.WebUri + "api/values").Result;


            if (response.StatusCode == HttpStatusCode.OK)
            {
                string json = await response.Content.ReadAsStringAsync();
                contacts = new ObservableCollection<Contact>(Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>(json));
            }
            return contacts;
        }

        private void SaveContact()
        {
            if (ValidateContact())
            {
                Contacts.Add(Contact);
                PostCollection();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(Resources.ValidationErrorMessage, Resources.Validation, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async void PostCollection()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new System.Uri(Resources.WebUri);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/values", Contacts);

            if (response.IsSuccessStatusCode)
            {
                MessageBoxResult result = MessageBox.Show(Resources.SaveMessage, Resources.Save, MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    ShowContactDetails();
                    Reset();
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show(Resources.SomethingWentWrong, Resources.Validation, MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void DeleteContact()
        {
            List<Contact> selectedContacts = this.Contacts.ToList().Where(c => c.IsChecked).ToList();
            foreach (var contact in selectedContacts)
            {
                int index = this.Contacts.IndexOf(contact);
                Contacts.RemoveAt(index);
            }

            PostCollection();
        }

        private void EditContact()
        {
            Contact = Contacts.ToList().FirstOrDefault(c => c.IsChecked);
            TabSelectedIndex = 0;
        }
    }
}


