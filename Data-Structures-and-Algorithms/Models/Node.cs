using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    public class Node<T> where T : IComparable<T>
    {
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }
        public T Data { get; set; }
    }
}
