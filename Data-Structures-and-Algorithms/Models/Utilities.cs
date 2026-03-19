using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    public class Utilities
    {
        // **********Psuedocode for Linear Search**********
        // 
        // take in an array myArray
        // take in a value criteria
        // 
        // declare int i
        // declare boolean found
        // 
        // while not found and i less than array length
        //    if criteria is equal to value at array i
        //        found equals true
        //    else
        //        increase i by 1
        // END while
        // if i is less than arrays length
        //    return i
        // else
        //    return -1
        // 
        // *****************Psuedocode END*****************

        // Linear Search Algorithm
        /// <summary>
        /// Linear search takes in an array and a search criteria, it then iterates through the
        /// array one by one till it finds the criteria or reaches the end of the array.
        /// Linear Search works on both sorted and unsorted arrays.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="criteria"></param>
        /// <returns>The Criteria's index if found and -1 if not found</returns>
        public static int LinearSearch<T>(T[]myArray, T criteria) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            while (!found && i < myArray.Length)
            {
                if (criteria.CompareTo(myArray[i]) == 0)
                    found = true;
                else
                    i++;
            }
            if (i < myArray.Length)
                return i;
            else
                return -1;
        }

        // **********Psuedocode for Binary Search**********
        // 
        // take in an array myArray
        // take in a value criteria
        // 
        // declare int min
        // declare int max
        // declare int mid
        // 
        // do
        //    mid equals (min + max) divided by 2
        //    if array at index mid compared to criteria is 0
        //        return mid
        //    if criteria compared to array at index mid is greater than 0
        //        min equals mid minus 1
        //    else
        //        max equals mid minus 1
        // while min is less than or equal to max
        // return -1 if not found
        // 
        // *****************Psuedocode END*****************

        // Binary Search Algorithm
        /// <summary>
        /// Binary Search takes in an array and a search criteria, it looks at the middle of the
        /// array and determines whether the criteria is in the right or left half of the array,
        /// it then cuts out the other half of the array and repeats the process.
        /// Binary Search only works on a sorted array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="criteria"></param>
        /// <returns>The Criteria's index if found and -1 if not found</returns>
        public static int BinarySearch<T>(T[] myArray, T criteria) where T : IComparable<T>
        {
            int min = 0;
            int max = myArray.Length - 1;
            int mid;

            do
            {
                mid = (min + max) / 2;
                if (myArray[mid].CompareTo(criteria) == 0)
                    return mid;
                if (criteria.CompareTo(myArray[mid]) > 0)
                    min = mid + 1;
                else
                    max = mid - 1;
            } while (min <= max);
            return - 1;
        }
        /// <summary>
        /// Merge sort takes in an array and an order direction. It will then recursively split the
        /// array up into many subarrays, until each subarray only consists of 1 value. It then merges
        /// them together while sorting the array subarray by subarray.
        /// Order will define the sorting order as either Ascending or Descending: 1 for Ascending and -1 for descending.
        /// If any other order is input, it will default to Ascending.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="order"></param>
        public static void MergeSort<T>(T[] myArray, int order) where T : IComparable<T>
        {
            if (myArray == null || myArray.Length <= 1)
                return;
            SortArray(myArray, 0, myArray.Length - 1, order);
        }
        private static void SortArray<T>(T[] myArray, int left, int right, int order) where T : IComparable<T>
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                SortArray(myArray, left, middle, order);
                SortArray(myArray, middle + 1, right, order);
                if (order == 1)
                    MergeAsc(myArray, left, middle, right);
                else if (order == -1)
                    MergeDesc(myArray, left, middle, right);
                else
                    MergeAsc(myArray, left, middle, right);
            }
        }
        private static void MergeAsc<T>(T[] myArray, int left, int middle, int right) where T : IComparable<T>
        {
            int leftPointer = left;
            int rightPointer = middle + 1;
            int position = 0;

            T[] temp = new T[right - left + 1];

            while (leftPointer <= middle && rightPointer <= right)
            {
                if (myArray[leftPointer].CompareTo(myArray[rightPointer]) <= 0)
                    temp[position++] = myArray[leftPointer++];
                else
                    temp[position++] = myArray[rightPointer++];
            }

            while (leftPointer <= middle)
            {
                temp[position++] = myArray[leftPointer++];
            }

            while (rightPointer <= right)
            {
                temp[position++] = myArray[rightPointer++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                myArray[left + i] = temp[i];
            }
        }
        private static void MergeDesc<T>(T[] myArray, int left, int middle, int right) where T : IComparable<T>
        {
            int leftPointer = left;
            int rightPointer = middle + 1;
            int position = 0;

            T[] temp = new T[right - left + 1];

            while (leftPointer <= middle && rightPointer <= right)
            {
                if (myArray[leftPointer].CompareTo(myArray[rightPointer]) >= 0)
                    temp[position++] = myArray[leftPointer++];
                else
                    temp[position++] = myArray[rightPointer++];
            }

            while (leftPointer <= middle)
            {
                temp[position++] = myArray[leftPointer++];
            }

            while (rightPointer <= right)
            {
                temp[position++] = myArray[rightPointer++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                myArray[left + i] = temp[i];
            }
        }

        public static void PrintArray<T>(T[] myArray) where T : IComparable<T>
        {
            Console.WriteLine();
            Console.WriteLine("Array output:");
            foreach (T item in myArray)
            {
                if (item is Student)
                    Console.Write(item.GetHashCode() + " ");
                else
                    Console.Write(item + " ");
            }
        }

        public static void PrintStudents(Student[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Array Output:");
            foreach (Student student in students)
                Console.Write(student.StudentStudentID + " ");
        }

        // Different Sorting Algorithms for testing
        public static void BubbleSortINT(int[] myArray)
        {
            int temp;
            for (int j = 0; j < myArray.Length - 1; j++)
            {
                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        temp = myArray[i + 1];
                        myArray[i + 1] = myArray[i];
                        myArray[i] = temp;
                    }
                }
            }
        }
        public static void SelectionSortINT(int[] myArray)
        {
            int temp, minIndex;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                minIndex = i;
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                temp = myArray[minIndex];
                myArray[minIndex] = myArray[i];
                myArray[i] = temp;
            }
        }

    }
}
