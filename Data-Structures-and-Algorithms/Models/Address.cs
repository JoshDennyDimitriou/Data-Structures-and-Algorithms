using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    class Address
    {
        // Instance Variables
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postcode;
        private string state;

        // Default values
        const string DEF_STREET_NUM = "None Provided";
        const string DEF_STREET_NAME = "None Provided";
        const string DEF_SUBURB = "None Provided";
        const string DEF_POSTCODE = "None Provided";
        const string DEF_STATE = "None Provided";

        // Property Assessor Methods
        public string AddressStreetNum
        {
            get
            { return streetNum; }
            set
            { streetNum = value; }
        }
        public string AddressStreetName
        {
            get
            { return streetName; }
            set
            { streetName = value; }
        }
        public string AddressSuburb
        {
            get
            { return suburb; }
            set
            { suburb = value; }
        }
        public string AddressPostcode
        {
            get
            { return postcode; }
            set
            {  postcode = value; }
        }
        public string AddressState
        {
            get
            { return state; }
            set
            { state = value; }
        }

        // Constructors
        // All-args
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            AddressStreetNum = streetNum;
            AddressStreetName = streetName;
            AddressSuburb = suburb;
            AddressPostcode = postcode;
            AddressState = state;
        }
        // No-args
        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }

        // ToString Override
        public override string ToString()
        {
            return "Street Number: " + AddressStreetNum +
                "\nStreet Name: " + AddressStreetName +
                "\nSuburb: " + AddressSuburb +
                "\nPostcode: " + AddressPostcode +
                "\nState: " + AddressState;
        }
    }
}
