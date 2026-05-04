using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Models
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public bool Add(T value)
        {
            Node<T> before = null;
            Node<T> after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.Data) < 0)
                    after = after.LeftNode;
                else if (value.CompareTo(after.Data) > 0)
                    after = after.RightNode;
                else
                    return false;
            }

            Node<T> newNode = new Node<T>();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value.CompareTo(before.Data) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }

        public Node<T> Find(T value)
        {
            return this.Find(value, this.Root);
        }
        private Node<T> Find(T value, Node<T> parent)
        {
            if (parent != null)
            {
                if (value.CompareTo(parent.Data) == 0) return parent;
                if (value.CompareTo(parent.Data) < 0)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        public Node<T> Remove(T value)
        {
            return this.Remove(this.Root, value);
        }
        private Node<T> Remove(Node<T> parent, T key)
        {
            if (parent == null) return parent;
            if (key.CompareTo(parent.Data) < 0)
                parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key.CompareTo(parent.Data) > 0)
                parent.RightNode = Remove(parent.RightNode, key);
            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;
                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }
            return parent;
        }

        private T MinValue(Node<T> node)
        {
            T minv = node.Data;
            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }
        private int GetTreeDepth(Node<T> current)
        {
            return current == null ? 0 : Math.Max(GetTreeDepth(current.LeftNode), GetTreeDepth(current.RightNode)) + 1;
        }

        public void TraversePreOrder(Node<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }
        public void TraverseInOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }
        public void TraversePostOrder(Node<T> parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }
}
