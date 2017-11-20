//This class is used to construct Letter objects using Parcel as a base class.
//This class takes the origin address, destination address, and a fixed cost and drom those constructs Letter objects.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Letter : Parcel
    {
        //Backing Fields
        private decimal _fixedCost;

        //Constructor

        //precondition: requires originAddress Address object, destinationAddress Address object, 
        //and a decimal for the fixed Cost
        //postcondition: a new Letter object will be created
        public Letter(Address originAddress, Address destinationAddress, decimal fixedCost)
            : base(originAddress, destinationAddress)
        {
            _fixedCost = fixedCost;
        }

        //Properties

        //precondition: 
        //1) value must be a decimal
        //2) value must be >=0
        //postcondition: returns value of _fixedCost or sets _fixedCost value of fixedCost variable
        public decimal FixedCost
        {
            //precondition: none
            //postcondition: returns the value of _fixedCost
            get { return _fixedCost; }
            //precondition:
            //1) value must be a decimal
            //2) value must be >=0
            //postcondition: sets the value of _fixedCost to fixedCost
            set
            {
                if (value >= 0)
                { _fixedCost = value; }
            }

        }
        //precondition: must pass a decimal value >=0
        //postcondition: returns the cost calculate for the Letter
        public override decimal CalcCost()
        {
            decimal result = (FixedCost);
            return result;
        }
        //precondition: all that is required is the base class .ToString()
        //postcondition: a string containing the Letter object will be returned
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
