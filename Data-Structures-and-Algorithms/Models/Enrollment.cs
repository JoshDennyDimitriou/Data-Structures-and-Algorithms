using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Josh Denny-Dimitriou
// Date: 05/02/2026
// Purpose: Enrollment class for the program

namespace Data_Structures_and_Algorithms
{
    class Enrollment
    {
        // Instance variables
        private string dateEnrolled;
        private string grade;
        private string semester;
        private Subject subject;

        // Default values
        const string DEF_DATE_ENROLLED = "None Provided";
        const string DEF_GRADE = "None Provided";
        const string DEF_SEMESTER = "None Provided";

        // Property Assessor Methods
        public string EnrollmentDateEnrolled
        {
            get
            { return dateEnrolled; }
            set
            { dateEnrolled = value; }
        }
        public string EnrollmentGrade
        {
            get
            { return grade; }
            set
            { grade = value; }
        }
        public string EnrollmentSemester
        {
            get
            { return semester; }
            set
            { semester = value; }
        }
        public Subject EnrollmentSubject
        {
            get
            { return subject; }
            set
            { subject = value; }
        }

        // Constructors
        // All-args
        public Enrollment(string dateEnrolled, string grade, string semester, Subject subject)
        {
            EnrollmentDateEnrolled = dateEnrolled;
            EnrollmentGrade = grade;
            EnrollmentSemester = semester;
            EnrollmentSubject = subject;
        }
        // All-args --> Subject
        public Enrollment(string dateEnrolled, string grade, string semester) : this(dateEnrolled, grade, semester, new Subject())
        {

        }
        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER)
        {

        }

        // ToString Override
        public override string ToString()
        {
            return "Date Enrolled: " + EnrollmentDateEnrolled +
                "\nGrade: " + EnrollmentGrade +
                "\nSemester: " + EnrollmentSemester +
                "\nSubject: {\n" + EnrollmentSubject + "\n\t}";
        }
    }
}
