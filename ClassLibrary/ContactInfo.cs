using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class ContactInfo
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        public string zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
