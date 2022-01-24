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
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddNode(56);
            customLinkedList.AddNode(30);
            customLinkedList.AddNode(76);
            customLinkedList.AddNode(80);
            Console.ReadLine();
        }
    }
}