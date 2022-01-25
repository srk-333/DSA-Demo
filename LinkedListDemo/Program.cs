using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.LinkedListCall();
            Console.ReadLine();
        }

        public void LinkedListCall()
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLastNode(56);
            customLinkedList.AddLastNode(30);
            customLinkedList.AddLastNode(70);
            customLinkedList.DisplayLinkedList();
            Console.WriteLine("-------------------------");
            int node = customLinkedList.SearchNode(30);
            if (node != 0)
            Console.WriteLine("{0} node is present in the Linked List",node);        
        }
    }
}