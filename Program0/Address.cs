//Description: This class is used to construct address objects.
//To construct address objects, we need a name, two addresses, city, state and zip code.
//This class also contains an overridden ToString method for printing address objects to console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        //Backing Fields
        private string _name = "";
        private string _address1 = "";
        private string _address2 = "";
        private string _city = "";
        private string _state = "";
        private uint _zip = 00000;

        //variables
        private const uint maxZip = 99999; //maximum value allowed for zip codes 
        //Constructor

        /*preconditions: 
        * Name = string
        * Address1 = string
        * Address2
        * City = string
        * State = string
        * Zip = non-negative unsigned integer, 5 digits*/
        //postconditions:a new Address object will be created with a name, two addresses, a city, state, and a zip

        public Address(string name, string address1, string address2,
            string city, string state, uint zip)
        {
            _name = name;
            _address1 = address1;
            _address2 = address2;
            _city = city;
            _state = state;
            _zip = zip;
        }

        //Properties

        //precondition: value must be string
        //postcondition: will return value of _name or set _name to name variable
        private string Name
        {
            //precondition: none
            //postcondition: returns Name
            get { return _name; }

            //precondition: value must = string
            //postcondition: value of Name will be set to name variable
            set
            {
                if (value is string)
                { _name = value; }
            }
        }

        //precondition: value must be string
        //postcondition: will return value of _address1 or set _address 1 to address1 variable
        private string Address1
        {
            //precondition: none
            //postdoncition: returns value of _address1
            get { return _address1; }

            //precondition: value must be string
            //postcondition: value of _address1 will be set to address1 variable
            set
            {
                if (value is string)
                {
                    _address1 = value;
                }
            }
        }

        //precondition: value must be string
        //postcondition: returns value of _address2 or sets _address2 to value of address2 variable
        private string Address2
        {
            //precondition: none
            //postcondtion: returns value of _address2
            get { return _address2; }

            //precondition: value must be string
            //postcondition: sets _address2 to value of address2 variable
            set
            {
                if (value is string)
                { _address2 = value; }
            }
        }

        //precondition: value be a string
        //postcondition: returns value of _city or sets _city to value of city variable
        private string City
        {
            //precondition: none
            //postcondition: returns value of _city
            get { return _city; }

            //precondition: value must be string
            //postcondition: sets _city to value of city variable
            set
            {
                if (value is string)
                { _city = value; }
            }
        }

        //precondition: value must be a string
        //postcondition: returns value of _state or sets state to value of state variable
        private string State
        {
            //precondition: none
            //postcondition: returns value of _state
            get { return _state; }

            //precondtion: value must be string
            //postcondition: sets _state to value of state variable
            set
            {
                if (value is string)
                { _state = value; }
            }
        }

        //precondition: value must be >= 00000 and <=99999
        //              value must also be a uint
        //postcondition: returns value of _zip or sets _zip to value of zip variable
        private uint Zip
        {
            //precondition: none
            //postcondition: returns value of _zip
            get { return _zip; }

            //precondition: value must be string
            //postcondition: sets value _zip to value of zip variable
            set
            {
                if (value >= 0 && value <= maxZip)
                { _zip = value; }
            }
        }
        //precondition:
        //1) Name, Address1, Address2, City, and State must all be strings
        //2) Zip must be a number between 0 and the MAXZIP (currently 99999)
        //postondition:
        public override string ToString()
        {
            string result = string.Format("Name: {0}\nAddress1: {1}\nAddress2: {2}\nCity/State/Zip: {3} {4}, {5:d5}\n",
                Name, Address1, Address2, City, State, Zip);
            return result;
        }
    }
}
