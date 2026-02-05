using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    class Person
    {
        private string name;
        private string email;
        private string phoneNumber;
        private Address address;

        // Default Values
        const string DEF_NAME = "None Provided";
        const string DEF_EMAIL = "None Provided";
        const string DEF_PHONE_NUMBER = "None Provided";

        // Property Assessor Methods
        public string PersonName
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public string PersonEmail
        {
            get
            { return email; }
            set
            { email = value; }
        }
        public string PersonPhoneNumber
        {
            get
            { return phoneNumber; }
            set
            { phoneNumber = value; }
        }
        public Address PersonAddress
        {
            get
            { return address; }
            set
            { address = value; }
        }

        // Constructors
        // All-args
        public Person(string name, string email, string phoneNumber, Address address)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phoneNumber;
            PersonAddress = address;
        }
        // No-args
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHONE_NUMBER)
        {

        }
        public Person(string name, string email, string phoneNumber) : this(name, email, phoneNumber, new Address())
        {

        }

        // ToString Override
        public override string ToString()
        {
            return "Name: " + PersonName +
                "\nEmail: " + PersonEmail +
                "\nPhone Number: " + PersonPhoneNumber + 
                "\nAddress: {\n" + PersonAddress + "\n\t}";
        }
    }
}
