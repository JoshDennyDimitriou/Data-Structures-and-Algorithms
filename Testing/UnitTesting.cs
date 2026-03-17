using Data_Structures_and_Algorithms;
using Data_Structures_and_Algorithms.Models;

namespace Testing
{
    public class Tests
    {
        private Student stu1, stu2, stu3, stu4, stu5, stu6, stu7, stu8, stu9, stu10;
        // Creating a fake stu11 so there are no build errors. stu11 will not be added to either array
        private Student stu11;
        private Student[] studentArr1, studentArr2;

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


            // Creating 2 arrays for the Merge Sort Methods, studentArr1 will be used for all searching tests.
            studentArr1 = new Student[] {stu5, stu4, stu7, stu1, stu6, stu9, stu2, stu10, stu8, stu3};
            studentArr2 = new Student[] { stu5, stu4, stu7, stu1, stu6, stu9, stu2, stu10, stu8, stu3 };
        }

        // Test 1 - Testing Linear Search Found on studentArr1
        [Test]
        public void LinearSearchFound()
        {
            Assert.That(Utilities.LinearSearch(studentArr1, stu4), Is.EqualTo(1));
        }

        // Test 2 - Testing Linear Search Not Found on studentArr1
        [Test]
        public void LinearSearchNotFound()
        {
            Assert.That(Utilities.LinearSearch(studentArr1, stu11), Is.EqualTo(-1));
        }

        // **********Need to sort the arrays before the Binary Search testing**********
        // Test 3 - Testing Merge Sort Ascending on studentArr1
        [Test]
        public void MergeSortAsc()
        {
            Assert.Pass();
        }

        // Test 4 - Testing Merge Sort Descending on studentArr2
        [Test]
        public void MergeSortDesc()
        {
            Assert.Pass();
        }

        // Test 5 - Testing Binary Search Found on studentArr1
        [Test]
        public void BinarySearchFound()
        {
            Assert.Pass();
        }

        // Test 6 - Testing Binary Search Not Found on studentArr1
        [Test]
        public void BinarySearchNotFound()
        {
            Assert.Pass();
        }
    }
}
