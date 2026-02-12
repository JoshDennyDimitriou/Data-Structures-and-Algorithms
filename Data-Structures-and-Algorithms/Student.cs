using Data_Structures_and_Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Josh Denny-Dimitriou
// Date: 05/02/2026
// Purpose: Student class for the program

namespace Data_Structures_and_Algorithms
{
    class Student : Person
    {
        // Instance Variables
        private string studentID;
        private string program;
        private string dateRegistered;
        private Enrollment enrollment;

        // Default values
        const string DEF_STUDENT_ID = "None Provided";
        const string DEF_PROGRAM = "None Provided";
        const string DEF_DATE_REGISTERED = "None Provided";

        // Property Assessors
        public string StudentStudentID
        {
            get
            { return studentID; }
            set
            { studentID = value; }
        }
        public string StudentProgram
        {
            get
            { return program; }
            set
            { program = value; }
        }
        public string StudentDateRegistered
        {
            get
            { return dateRegistered; }
            set
            { dateRegistered = value; }
        }
        public Enrollment StudentEnrollment
        {
            get
            { return enrollment; }
            set
            { enrollment = value; }
        }

        // Constructors
        // All-args
        public Student(string studentID, string program, string dateRegistered, Enrollment enrollment) : base()
        {
            StudentStudentID = studentID;
            StudentProgram = program;
            StudentDateRegistered = dateRegistered;
            StudentEnrollment = enrollment;
        }
        // All-args --> Address
        public Student(string studentID, string program, string dateRegistered) : this(studentID, program, dateRegistered, new Enrollment())
        {

        }
        // Partial-args --> Only studentID
        public Student(string studentID)
        {
            StudentStudentID = studentID;
        }
        // No-args
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED)
        {

        }

        // ToString Override
        public override string ToString()
        {
            return base.ToString() + "Student ID: " + StudentStudentID +
                "\nProgram: " + StudentProgram +
                "\nDate Registered:" + StudentDateRegistered +
                "\nEnrollment: [\n" + StudentEnrollment + "\n\t\t]";
         }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student student = (Student)obj;
            return student.StudentStudentID == this.StudentStudentID;
        }
        public static bool operator == (Student stu1, Student stu2)
        {
            return object.Equals(stu1, stu2);
        }
        public static bool operator != (Student stu1, Student stu2)
        {
            return !object.Equals(stu1, stu2);
        }
        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == obj2)
                return true;
            if (obj1 == null || obj2 == null)
                return false;
            else
                return obj1.Equals(obj2);
        }

        public override int GetHashCode()
        {
            return this.StudentStudentID.GetHashCode();
        }
    }
}