using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUISecondway.Model
{
    public class ContactCatalog
    {
        private static Contact _selectedContact;

        private static ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>()
        {
            new Contact("Vladimir", "Putin", "17171717", "..\\Assets\\daniel.jpg"),
            new Contact("Donald", "Trump", "16161616", "..\\Assets\\benny.jpg"),
            new Contact("Barrack", "Obama", "15151515", "..\\Assets\\carol.jpg")
        };

        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
        }

        public void AddContact(Contact c)
        {
            _contacts.Add(c);
        }

        public void Delete(string phonenumber)
        {
            var contact = _contacts.FirstOrDefault(c => c.PhoneNumber == phonenumber);
            _contacts.Remove(contact);
        }

    }
}
