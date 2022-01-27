using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class CustomLinkedList
    {
        public Node head;
        //Method to Add Node at Last in Linked List
        public void AddLastNode(int data)
        {
            Node node = new Node(data);
            //condition to Check head and add first Node.
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                //Temp Node to work.
                Node temp = head;
                //Loop to check next pointer in Node.
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        //Display Method
        public void DisplayLinkedList()
        {
            Console.WriteLine("Display nodes of Linked List");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Nodes are : " + temp.data);
                temp = temp.next;
            }
        }
        //Method to Add Node at First in Linked List
        public void AddFirstNode(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} : Nodes inserted in Linked list ", newNode.data);
        }
        //Method to Append Linked List
        public void AppendLinkedList(int data)
        {
            AddLastNode(data);
            Console.WriteLine("{0} node Appended", data);
        }
        //Method to Add Data in Middle
        public Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            //Node Exchange
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }
        //Method To delete First Node
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;
        }
        //Method to delete Last Node
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }
            //checking for tail Node.
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int deleteLastNode = newNode.next.data;
            newNode.next = null;
            return deleteLastNode;
        }
        //Method to search any given Node
        public int SearchNode(int value)
        {
            Node temp = this.head;
            int count = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return count;
        }
        //Method to Delete a Node from specific position
        public void DeleteAtParticularPosition(int position)
        {
            Node temp = this.head;
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
        //Method to get size of a Linked List
        public void Size()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Size of Linked List:" + count);
        }
    }
}