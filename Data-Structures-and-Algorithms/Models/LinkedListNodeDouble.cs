using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    public class LinkedListNodeDouble<T>
    {
        public LinkedListNodeDouble(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public LinkedListNodeDouble<T> Next { get; set; }
        public LinkedListNodeDouble<T> Previous { get; set; }
    }
}
