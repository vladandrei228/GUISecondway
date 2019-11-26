using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace GUISecondway.Model
{
    public class Contact
    {
        public Contact(string firstname, string lastname, string phonenumber, string imagesource)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phonenumber;
            ImageSource = imagesource;
        }

        public string ImageSource
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
