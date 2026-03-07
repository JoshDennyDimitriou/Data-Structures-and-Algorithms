using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    class Utilities
    {
        // Linear Search Algorithm
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

        // Binary Search Algorithm
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
            } while (mid <= max);
            return - 1;
        }

        public static void MergeSort<T>(T[] myArray) where T : IComparable<T>
        {
            if (myArray == null || myArray.Length <= 1)
                return;
            SortArray(myArray, 0, myArray.Length - 1);
        }
        private static void SortArray<T>(T[] myArray, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                SortArray(myArray, left, middle);
                SortArray(myArray, middle + 1, right);
                Merge(myArray, left, middle, right);
            }
        }
        private static void Merge<T>(T[] myArray, int left, int middle, int right) where T : IComparable<T>
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
    }
}
