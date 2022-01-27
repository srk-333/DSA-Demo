using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    /// <summary>
    /// Normal Class for Node Creation
    /// </summary>
    public class Node
    {
        //Instance var.
        public int data;
        public Node next;
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    /// <summary>
    /// Generic class for Node creation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SortedNode<T>
    {
        public T data;
        public SortedNode<T> next;
        /// <summary>
        /// Initializes a new instance of the <see cref="SortedNode{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public SortedNode(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
