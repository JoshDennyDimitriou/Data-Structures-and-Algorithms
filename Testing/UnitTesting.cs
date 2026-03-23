using Data_Structures_and_Algorithms;
using Data_Structures_and_Algorithms.Models;

namespace Testing
{
    public class Tests
    {
        // Assigning students to objects with variables labeled 1 - 10
        private Student stu1, stu2, stu3, stu4, stu5, stu6, stu7, stu8, stu9, stu10;
        // Creating a fake stu11 so there are no build errors. stu11 will not be added to either array
        private Student stu11;
        private Student[] studentArrOrdered, studentArrUnordered1, studentArrUnordered2, studentArrIdOrderedAsc, studentArrIdOrderedDesc;

        [OneTimeSetUp]
        public void Setup()
        {
            // Creating 10 Student objects to put into arrays.
            // As the CompareTo method for the Student class only uses StudentStudentID.GetHashCode,
            // the students will only be created with a studentID.
            stu1 = new Student("001232747"); // This student is using my studentID
            stu2 = new Student("003479346");
            stu3 = new Student("004531759");
            stu4 = new Student("009124867");
            stu5 = new Student("004532791");
            stu6 = new Student("006957426");
            stu7 = new Student("004894261");
            stu8 = new Student("009874246");
            stu9 = new Student("001265721");
            stu10 = new Student("007954216"); 

            // Using no args as stu11 will not be added to either array
            stu11 = new Student();

            // studentArrOrdered is only ordered by variable name, not by studentID
            studentArrOrdered = [stu1, stu2, stu3, stu4, stu5, stu6, stu7, stu8, stu9, stu10];
            // studentArrUnordered1 will be used for Merge Sort Ascending
            studentArrUnordered1 = [stu5, stu4, stu7, stu1, stu6, stu9, stu2, stu10, stu8, stu3];
            // studentArrUnordered2 will be used for Merge Sort Descending
            studentArrUnordered2 = [stu5, stu4, stu7, stu1, stu6, stu9, stu2, stu10, stu8, stu3];
            // studentArrIdOrderedAsc will be ordered by studentID ascending to check against the Merge Sort Ascending
            studentArrIdOrderedAsc = [stu1, stu9, stu2, stu3, stu5, stu7, stu6, stu10, stu4, stu8];
            // studentArrIdOrderedDesc will be ordered by studentID descending to check against the Merge Sort Descending
            studentArrIdOrderedDesc = [stu8, stu4, stu10, stu6, stu7, stu5, stu3, stu2, stu9, stu1];
        }

        // Test 1 - Testing Linear Search Found on studentArr1 -> using stu4
        [Test]
        public void LinearSearchFound()
        {
            Assert.That(Utilities.LinearSearch(studentArrOrdered, stu4), Is.EqualTo(3));
        }

        // Test 2 - Testing Linear Search Not Found on studentArr1 -> using stu11
        [Test]
        public void LinearSearchNotFound()
        {
            Assert.That(Utilities.LinearSearch(studentArrOrdered, stu11), Is.EqualTo(-1));
        }

        // Test 3 - Testing Binary Search Found on studentArrOrdered -> using stu8
        [Test]
        public void BinarySearchFound()
        {
            Assert.That(Utilities.BinarySearch(studentArrOrdered, stu8), Is.EqualTo(7));
        }

        // Test 4 - Testing Binary Search Not Found on studentArrOrdered -> using stu11
        [Test]
        public void BinarySearchNotFound()
        {
            Assert.That(Utilities.BinarySearch(studentArrOrdered, stu11), Is.EqualTo(-1));
        }

        // Test 5 - Testing Merge Sort Ascending on studentArrUnordered1
        [Test]
        public void MergeSortAsc()
        {
            Utilities.MergeSort(studentArrUnordered1, 1);
            Assert.That(studentArrUnordered1, Is.EqualTo(studentArrIdOrderedAsc));
        }

        // Test 6 - Testing Merge Sort Descending on studentArrUnordered2
        [Test]
        public void MergeSortDesc()
        {
            Utilities.MergeSort(studentArrUnordered2, -1);
            Assert.That(studentArrUnordered2, Is.EqualTo(studentArrIdOrderedDesc));
        }

        // Test 7 - Testing Merge Sort Ascending on studentArrUnodered2 comparing to studentArrIdOrderedDesc -> DESIGNED TO FAIL
        [Test]
        public void MergeSortAscFail()
        {
            Utilities.MergeSort(studentArrUnordered2, 1);
            Assert.That(studentArrUnordered2, Is.EqualTo(studentArrIdOrderedDesc));
        }

        // Test 8 - Testing Merge Sort Descending on studentArrUnordered1 comparing to studentArrIdOrderedAsc -> DESIGNED TO FAIL
        [Test]
        public void MergeSortDescFail()
        {
            Utilities.MergeSort(studentArrUnordered1, -1);
            Assert.That(studentArrUnordered1, Is.EqualTo(studentArrIdOrderedAsc));
        }
    }
}
