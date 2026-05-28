using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    public class LinkedListNodeSingle<T>
    {
        public LinkedListNodeSingle(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public LinkedListNodeSingle<T> Next { get; set; }
    }
}
