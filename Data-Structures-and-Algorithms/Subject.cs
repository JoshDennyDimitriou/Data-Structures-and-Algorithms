using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Josh Denny-Dimitriou
// Date: 05/02/2026
// Purpose: Subject class for the program

namespace Data_Structures_and_Algorithms
{
    class Subject
    {
        // Instance Variables
        private string subjectCode;
        private string subjectName;
        private double cost;

        // Default Values
        const string DEF_SUBJECT_CODE = "None Provided";
        const string DEF_SUBJECT_NAME = "None Provided";
        const double DEF_COST = -1.00;

        // Property Assessor Methods
        public string SubjectSubjectCode
        {
            get
            { return subjectCode; }
            set
            { subjectCode = value; }
        }
        public string SubjectSubjectName
        {
            get
            { return subjectName; }
            set
            { subjectName = value; }
        }
        public double SubjectCost
        {
            get
            { return cost; }
            set
            { cost = value; }
        }

        // Constructors
        // All-args
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectSubjectCode = subjectCode;
            SubjectSubjectName = subjectName;
            SubjectCost = cost;
        }
        //
        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_COST)
        {

        }

        // ToString Override
        public override string ToString()
        {
            return "Subject Code: " + SubjectSubjectCode +
                "\nSubject Name: " + SubjectSubjectName +
                "\nSubject Cost: " + SubjectCost;
        }
    }
}