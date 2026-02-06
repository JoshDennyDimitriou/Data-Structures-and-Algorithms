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
            Address add1 = new Address();
            Console.WriteLine(add1);

            Console.WriteLine();
            
            //Property Assessors
            Console.WriteLine("Address Property Assessor Testing");
            add1.AddressStreetNum = "16";
            add1.AddressStreetName = "Lowes Str";
            add1.AddressSuburb = "Harlots";
            add1.AddressPostcode = "5006";
            add1.AddressState = "SA";
            Console.WriteLine("add1 Street Number: " + add1.AddressStreetNum);
            Console.WriteLine("add1 Street Name: " + add1.AddressStreetName);
            Console.WriteLine("add1 Suburb: " + add1.AddressSuburb);
            Console.WriteLine("add1 Postcode: " + add1.AddressPostcode);
            Console.WriteLine("add1 State: " + add1.AddressState);

            Console.WriteLine();
            
            // All-args
            Console.WriteLine("All-args Address:");
            Address add2 = new Address("75", "Brooksfield Ave", "Lempton", "645a", "VIC");
            Console.WriteLine(add2);

            Console.WriteLine();

            // Person Class Testing
            Console.WriteLine("----------Person Testing:----------");
            
            // No-args
            Console.WriteLine("No-args Person");
            Person per1 = new Person();
            Console.WriteLine(per1);

            Console.WriteLine();
            // Property Assessors
            Console.WriteLine("Person Property Assessor Testing:");
            per1.PersonName = "Josh";
            per1.PersonEmail = "josh@student.com";
            per1.PersonPhoneNumber = "000111222333";
            Console.WriteLine("per1 Name: " + per1.PersonName);
            Console.WriteLine("per1 Email: " + per1.PersonEmail);
            Console.WriteLine("per1 Phone = " + per1.PersonPhoneNumber);
            
            Console.WriteLine();
            
            // All-args no Address
            Console.WriteLine("All-args Person (Without Address):");
            Person per2 = new Person("Marcus", "marcus@student.com", "333222111000");
            Console.WriteLine(per2);

            Console.WriteLine();
            
            // All-args with Addres
            Console.WriteLine("All-args Person (With Address):");
            Person per3 = new Person("Hannah", "hannah@student.com", "222333111000", add1);
            Console.WriteLine(per3);

            Console.WriteLine();

            // Subject Class Testing
            Console.WriteLine("----------Subject Testing----------");
            // No-args
            Console.WriteLine("No-args Subject");
            Subject sub1 = new Subject();
            Console.WriteLine(sub1);

            Console.WriteLine();

            // Property Assessors
            Console.WriteLine("Subject Property Assessor Testing");
            sub1.SubjectSubjectCode = "PRG546";
            sub1.SubjectSubjectName = "Advanced C#";
            sub1.SubjectCost = 265.80;
            Console.WriteLine("Sub1 Subject Code: " + sub1.SubjectSubjectCode);
            Console.WriteLine("Sub1 Subject Name: " + sub1.SubjectSubjectName);
            Console.WriteLine("Sub1 Subject Cost: " + sub1.SubjectCost);

            Console.WriteLine();

            // All-args
            Console.WriteLine("ALl-args Subject");
            Subject sub2 = new Subject("ICT246", "Learn Business Direction", 248);
            Console.WriteLine(sub2);

            Console.WriteLine();

            // Enrollment Class Testing
            Console.WriteLine("----------Enrollment Testing----------");
            // No-args
            Console.WriteLine("No-args Enrollment");
            Enrollment enr1 = new Enrollment();
            Console.WriteLine(enr1);

            Console.WriteLine();

            // Property Assessors
            Console.WriteLine("Enrollment Property Assessor Testing");
            enr1.EnrollmentDateEnrolled = "02/02/2026";
            enr1.EnrollmentGrade = "D";
            enr1.EnrollmentSemester = "Semester 1";
            enr1.EnrollmentSubject = sub1;
            Console.WriteLine(enr1);

            Console.WriteLine();

            // All-args without Subject
            Console.WriteLine("All-args Enrollment (Without Subject");
            Enrollment enr2 = new Enrollment("06/08/2024", "P", "Semester 2");
            Console.WriteLine(enr2);

            Console.WriteLine();

            // All-args with Subject
            Console.WriteLine("All-args Enrollment (With Subject)");
            Enrollment enr3 = new Enrollment("24/12/2025", "F", "Semester 2", sub2);
            Console.WriteLine(enr3);

            // Student Class Testing
            Console.WriteLine("----------Student Testing----------");
            // No-args Student
            Console.WriteLine("No-args Student");
            Student stu1 = new Student();
            Console.WriteLine(stu1);

            Console.WriteLine();

            // Property Assessors
            Console.WriteLine("Student Property Assessment Testing");
            stu1.StudentStudentID = "001232747";
            stu1.StudentProgram = "Diploma";
            stu1.StudentDateRegistered = "03/11/2025";
            stu1.StudentEnrollment = enr1;
            Console.WriteLine(stu1);

            Console.WriteLine();

            // All-args without Enrollment
            Console.WriteLine("All-args Student (Without Enrollment)");
            Student stu2 = new Student("001234759", "Cert IV", "24/10/2024");
            Console.WriteLine(stu2);

            Console.WriteLine();

            // All-args with Enrollment
            Console.WriteLine("All-args Student (With Enrollment)");
            Student stu3 = new Student("001245972", "Cert III",  "15/08/2023", enr3);
            Console.WriteLine(stu3);
        }
    }                              
}                                  
                                   