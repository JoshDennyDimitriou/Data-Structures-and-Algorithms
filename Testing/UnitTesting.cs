using Data_Structures_and_Algorithms;
using Data_Structures_and_Algorithms.Models;
using Newtonsoft.Json.Bson;

namespace Testing
{
    public class Tests
    {
        // Assigning students to objects with variables labeled 1 - 10
        private Student stu1, stu2, stu3, stu4, stu5, stu6, stu7, stu8, stu9, stu10;
        // Creating a fake stu11 so there are no build errors. stu11 will not be added to either array
        private Student stu11;
        // Creating the arrays for searching and sorting
        private Student[] studentArrOrdered, studentArrUnordered1, studentArrUnordered2, studentArrIdOrderedAsc, studentArrIdOrderedDesc;
        // Creating the single and double linked lists
        private SingleLinkedList<Student> singleLinkedList, singleLinkedListOneAdded, singleLinkedListBothAdded, singleLinkedListOneRemoved, singleLinkedListBothRemoved;
        private DoubleLinkedList<Student> doubleLinkedList, doubleLinkedListOneAdded,doubleLinkedListBothAdded, doubleLinkedListOneRemoved, doubleLinkedListBothRemoved;

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

            // singleLinkedList will use randomly placed students for testing
            // Data is added to the list without stu6 and stu10 as they will be used to test the adding methods
            singleLinkedList = new SingleLinkedList<Student>
            {
                stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7
            };
            // Creating an identical list as above but with stu10 added in for comparison
            singleLinkedListOneAdded = new SingleLinkedList<Student>
            {
                stu10, stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7,
            };
            // Creating an identical list as above but with stu6 added in for comparison
            singleLinkedListBothAdded = new SingleLinkedList<Student>
            {
                stu10, stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7, stu6
            };
            // Creating an identical list to singleLinkedList without stu3 to test the remove first method
            singleLinkedListOneRemoved = new SingleLinkedList<Student>
            {
                stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7, stu6
            };
            // Creating an identical list to singleLinkedList without stu7 to test the remove last method
            singleLinkedListBothRemoved = new SingleLinkedList<Student>
            {
                stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7
            };

            // doubleLinkedList will use the same order as singleLinkedList with the same students missing to test the adding methods
            doubleLinkedList = new DoubleLinkedList<Student>
            {
                stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7
            };
            // Creating an identical list as above but with stu10 added in for comparison
            doubleLinkedListOneAdded = new DoubleLinkedList<Student>
            {
                stu10, stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7
            };
            // Creating an identical list as above but with stu6 added in for comparison
            doubleLinkedListBothAdded = new DoubleLinkedList<Student>
            {
                stu10, stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7, stu6
            };
            // Creating an identical list to doubleLinkedList without stu3 to test the remove first method
            doubleLinkedListOneRemoved = new DoubleLinkedList<Student>
            {
                stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7, stu6
            };
            // Creating an identical list to doubleLinkedList without stu7 to test the remova last method
            doubleLinkedListBothRemoved = new DoubleLinkedList<Student>
            {
                stu3, stu9, stu8, stu4, stu2, stu5, stu1, stu7
            };
        }

        // Test 1 - Testing Linear Search Found on studentArr1 -> using stu4
        [Test, Order(1)]
        public void LinearSearchFound()
        {
            Assert.That(Utilities.LinearSearch(studentArrOrdered, stu4), Is.EqualTo(3));
        }

        // Test 2 - Testing Linear Search Not Found on studentArr1 -> using stu11
        [Test, Order(2)]
        public void LinearSearchNotFound()
        {
            Assert.That(Utilities.LinearSearch(studentArrOrdered, stu11), Is.EqualTo(-1));
        }

        // Test 3 - Testing Binary Search Found on studentArrOrdered -> using stu8
        [Test, Order(3)]
        public void BinarySearchFound()
        {
            Assert.That(Utilities.BinarySearch(studentArrOrdered, stu8), Is.EqualTo(7));
        }

        // Test 4 - Testing Binary Search Not Found on studentArrOrdered -> using stu11
        [Test, Order(4)]
        public void BinarySearchNotFound()
        {
            Assert.That(Utilities.BinarySearch(studentArrOrdered, stu11), Is.EqualTo(-1));
        }

        // Test 5 - Testing Merge Sort Ascending on studentArrUnordered1
        [Test, Order(5)]
        public void MergeSortAsc()
        {
            Utilities.MergeSort(studentArrUnordered1, 1);
            Assert.That(studentArrUnordered1, Is.EqualTo(studentArrIdOrderedAsc));
        }

        // Test 6 - Testing Merge Sort Descending on studentArrUnordered2
        [Test, Order(6)]
        public void MergeSortDesc()
        {
            Utilities.MergeSort(studentArrUnordered2, -1);
            Assert.That(studentArrUnordered2, Is.EqualTo(studentArrIdOrderedDesc));
        }

        // Test 7 - Testing Merge Sort Ascending on studentArrUnodered2 comparing to studentArrIdOrderedDesc -> DESIGNED TO FAIL
        [Test, Order(7)]
        public void MergeSortAscFail()
        {
            Utilities.MergeSort(studentArrUnordered2, 1);
            Assert.That(studentArrUnordered2, Is.EqualTo(studentArrIdOrderedDesc));
        }

        // Test 8 - Testing Merge Sort Descending on studentArrUnordered1 comparing to studentArrIdOrderedAsc -> DESIGNED TO FAIL
        [Test, Order(8)]
        public void MergeSortDescFail()
        {
            Utilities.MergeSort(studentArrUnordered1, -1);
            Assert.That(studentArrUnordered1, Is.EqualTo(studentArrIdOrderedAsc));
        }

        // Test 9 - Testing SingleLinkedList AddFirst() method
        [Test, Order(9)]
        public void SingleListAddFirst()
        {
            singleLinkedList.AddFirst(stu10);
            Assert.That(singleLinkedList, Is.EqualTo(singleLinkedListOneAdded));
        }

        // Test 10 - Testing SingleLinkedList AddLast() method
        [Test, Order(10)]
        public void SingleListAddBoth()
        {
            singleLinkedList.AddLast(stu6);
            Assert.That(singleLinkedList, Is.EqualTo(singleLinkedListBothAdded));
        }

        // Test 11 - Testing SingleLinkedList Contains() method with stu8
        [Test, Order(11)]
        public void SingleListContains()
        {
            Assert.That(singleLinkedList.Contains(stu8), Is.EqualTo(true));
        }

        // Test 12 - Testing SingleLinkedList RemoveFirst() method
        [Test, Order(12)]
        public void SingleListRemoveFirst()
        {
            singleLinkedList.RemoveFirst();
            Assert.That(singleLinkedList, Is.EqualTo(singleLinkedListOneRemoved));
        }

        // Test 13 - Testing SingleLinkedList RemoveLast() method
        [Test, Order(13)]
        public void SingleListRemoveBoth()
        {
            singleLinkedList.RemoveLast();
            Assert.That(singleLinkedList, Is.EqualTo(singleLinkedListBothRemoved));
        }

        // Test 14 - Testing DoubleLinkedList AddFirst() method
        [Test, Order(14)]
        public void DoubleListAddFirst()
        {
            doubleLinkedList.AddFirst(stu10);
            Assert.That(doubleLinkedList, Is.EqualTo(doubleLinkedListOneAdded));
        }

        // Test 15 - Testing DoubleLinkedList AddLast() method
        [Test, Order(15)]
        public void DoubleListAddLast()
        {
            doubleLinkedList.AddLast(stu6);
            Assert.That(doubleLinkedList, Is.EqualTo(doubleLinkedListBothAdded));
        }

        // Test 16 - Testing DoubleLinkedList Contains() method with stu8
        [Test, Order(16)]
        public void DoubleListContains()
        {
            Assert.That(doubleLinkedList.Contains(stu8), Is.EqualTo(true));
        }

        // Test 17 - Testing DoubleLinkedList RemoveFirst() method
        [Test, Order(17)]
        public void DoubleListRemoveFirst()
        {
            doubleLinkedList.RemoveFirst();
            Assert.That(doubleLinkedList, Is.EqualTo(doubleLinkedListOneRemoved));
        }

        // Test 18 - Testing DoubleLinkedList RemoveLast() method
        [Test, Order(18)]
        public void DoubleListRemoveLast()
        {
            doubleLinkedList.RemoveLast();
            Assert.That(doubleLinkedList, Is.EqualTo(doubleLinkedListBothRemoved));
        }
    }
}
