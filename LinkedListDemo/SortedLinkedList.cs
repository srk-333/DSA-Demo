using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class SortedLinkedList<T> where T : IComparable
    {
        public SortedNode<T> head = null;
        public SortedNode<T> tail = null;
        /// <summary>
        /// Adds the specified new node.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        public void Add(SortedNode<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }
        /// <summary>
        /// Sorts the Linked list in ascending order.
        /// </summary>
        public void SortedList()
        {
            SortedNode<T> current = head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        /// <summary>
        /// Displays each node from Linked List.
        /// </summary>
        public void Display()
        {
            SortedNode<T> node = this.head;
            if (node == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (node != null)
            {
                Console.WriteLine("Nodes are : " + node.data);
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
