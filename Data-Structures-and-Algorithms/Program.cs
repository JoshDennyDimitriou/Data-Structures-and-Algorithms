using Data_Structures_and_Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Address Testing
            Console.WriteLine("----------Address Testing:----------");
            // No-args
            Console.WriteLine("No-args Address:");
            Address a1 = new Address();
            Console.WriteLine(a1);

            Console.WriteLine();
            //Property Assessors
            Console.WriteLine("Address Property Assessor Testing");
            a1.AddressStreetNum = "16";
            a1.AddressStreetName = "Lowes Str";
            a1.AddressSuburb = "Harlots";
            a1.AddressPostcode = "5006";
            a1.AddressState = "SA";
            Console.WriteLine("a1 Street Number: " + a1.AddressStreetNum);
            Console.WriteLine("a1 Street Name: " + a1.AddressStreetName);
            Console.WriteLine("a1 Suburb: " + a1.AddressSuburb);
            Console.WriteLine("a1 Postcode: " + a1.AddressPostcode);
            Console.WriteLine("a1 State: " + a1.AddressState);

            Console.WriteLine();
            // All-args
            Console.WriteLine("All-args Address:");
            Address a2 = new Address("75", "Brooksfield Ave", "Lempton", "645a", "VIC");
            Console.WriteLine(a2);

            Console.WriteLine();

            // Person Class Testing
            Console.WriteLine("----------Person Testing:----------");
            // No-args
            Console.WriteLine("No-args Person");
            Person p1 = new Person();
            Console.WriteLine(p1);

            Console.WriteLine();
            // Property Assessors
            Console.WriteLine("Person Property Assessor Testing:");
            p1.PersonName = "Josh";
            p1.PersonEmail = "josh@student.com";
            p1.PersonPhoneNumber = "000111222333";
            Console.WriteLine("p1 Name: " + p1.PersonName);
            Console.WriteLine("p1 Email: " + p1.PersonEmail);
            Console.WriteLine("p1 Phone = " + p1.PersonPhoneNumber);
            
            Console.WriteLine();
            // All-args no Address
            Console.WriteLine("All-args Person (No Address):");
            Person p2 = new Person("Marcus", "marcus@student.com", "333222111000");
            Console.WriteLine(p2);

            Console.WriteLine();
            // All-args with Addres
            Console.WriteLine("All-args Person (With Address):");
            Person p3 = new Person("Hannah", "hannah@student.com", "222333111000", a1);
            Console.WriteLine(p3);

            Console.WriteLine();

        }                          
    }                              
}                                  
                                   