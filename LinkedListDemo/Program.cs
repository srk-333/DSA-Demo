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
            customLinkedList.AppendLinkedList(56);
            customLinkedList.AppendLinkedList(30);
            customLinkedList.AppendLinkedList(70);
            customLinkedList.DisplayLinkedList();
        }
    }
}