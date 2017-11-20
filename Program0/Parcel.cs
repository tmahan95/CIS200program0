//This class is an abstract class that will be used to construct different parcel objects later on.
//This class sets the foundation for creating parcels by requiring an origin address, a destination address, and a CalCost method.
//This class also contain an overridden ToString method to print Parcel objects to the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class  Parcel
    {
        //Backing fields
        private Address _originAddress;
        private Address _destinationAddress;

        //Constructor

        //preconditions:
        //1) must have originAddress Address object
        //2) must have destinationAddress Address object
        //postconditions: Basic parcel object structure will be created for use in derived classes
        public Parcel(Address originAddress, Address destinationAddress)
        {
            _originAddress = originAddress;
            _destinationAddress = destinationAddress;
        }

        //Properties

            //precondition: value must be an Address object
            //postcondition: returns the value of _originAddress or sets the value to OriginAddress
        private Address OriginAddress
        {
            //precondition: none
            //postcondition: returns the value _originAddress
            get { return _originAddress; }

            //precondition: value must be an Address object
            //postcondition:sets _originAddress to value of originAddress 
            set
            {
                if (value is Address)
                { _originAddress = value; }
            }
        }

        private Address DestinationAddress
        {
            //precondition: none
            //postcondition: returns value of _destinationAddress
            get { return _destinationAddress; }

            //precondition: value must be an Address object
            //postcondition: sets _desinationAddress to value of destinationAddress
            set
            {
                if (value is Address)
                { _destinationAddress = value; }
            }
        }

        //precondition: none
        //postcondition: none
        public abstract decimal CalcCost();

        //precondition: requires OriginAddress, DestinationAddress, and the results from the CalcCost method
        //postcondition: formats the OriginAddress, DestinationAddress and CalCost method as strings, also displays the CalcCost as currency
        public override string ToString()
        {
            string result = string.Format("{0}\n{1}\nCost of Shipping: {2:c2}\n",OriginAddress,DestinationAddress,CalcCost());
            return result;
        }

    }
}
