using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CarClass
{
    class Car
    {
        private string _year;
        private string _make;
        private int _speed;

        // constructor
        public Car()
        {
            _year = "";
            _make = "";
            _speed = 0;

        } // end constructor

        // accelerate method
        public void Accelerate()
        {
            _speed += 5;
        }

        // brake method
        public void Brake()
        {
            _speed -= 5;
        }

        public int CurrentSpeed()
        {
            return _speed;
        }

        public String Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public String Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

    } // end class

} // end namespace
