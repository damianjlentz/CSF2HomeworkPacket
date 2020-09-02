using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastName
        {
            get { return _lastName}
            set { _lastName = value; }
        }

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
    }
}
