using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    class Utilities
    {
        // Linear Search Algorithm
        static int LinearSearch<T>(T[]myArray, T criteria) where T : IComparable<T>
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
        static int BinarySearch<T>(T[] myArray, T criteria) where T : IComparable<T>
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
    }
}
