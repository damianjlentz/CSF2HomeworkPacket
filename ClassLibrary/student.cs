﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class student
    {
        private string _firstName;
        private string _lastName;

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }

        }

        public string lastName
        {
            get { return _lastName;  }
            set { _lastName = value; }
        }
    }
}
