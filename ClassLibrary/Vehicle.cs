using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
