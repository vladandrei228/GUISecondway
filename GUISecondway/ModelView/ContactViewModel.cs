using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts.DataProvider;
using GUISecondway.Annotations;
using GUISecondway.Model;
using GUISecondway.ViewModel;
using System.Windows.Input;

namespace GUISecondway.ModelView
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        private Contact _domainObject;
        private ContactCatalog _contactCatalog;
        private Contact _selectedContact;
        private DeleteCommand _deletionCommand;
        public string _imageSource;

       


        public ContactViewModel()
        {
            _contactCatalog = new ContactCatalog();
            DomainObject();
            _selectedContact = null;
            _deletionCommand = new DeleteCommand(_contactCatalog, this);
            AddContactCommand = new RelayCommand(AddContact);
        }

        public ICommand AddContactCommand { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string ImageSource
        {
            get { return _imageSource; }
            set { _imageSource = "..\\Assets\\" + value; }
        }

        public void DomainObject()
        {
            foreach (var c in _contactCatalog.Contacts)
            {
                _domainObject = c;
            }
        }

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
                _deletionCommand.RaiseCanExecuteChanged();
            }
        }

        public DeleteCommand DeletionCommand
        {
            get { return _deletionCommand; }
        }

        public ObservableCollection<Contact> ContactsCollection
        {
            get { return _contactCatalog.Contacts; }

        }

        public void AddContact()
        {
            _contactCatalog.AddContact(new Contact(FirstName, LastName, Phone, ImageSource));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
