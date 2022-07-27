using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Linkedlist
{
    internal class LinkedList
    {
        internal Node head; //new 
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        public void AddatFirst(int element)
        {
            Node newnode = new Node(element);
            newnode.next = head;
            head = newnode;
        }
        public void append(int newdata)
        {
            Node new_node = new Node(newdata);
            if (head == null)
            {
                head = new Node(newdata);
                return;
            }
            new_node.next = null;
            Node last = head;
            while (last.next != null)
                last = last.next;
            last.next = new_node;
            return;
        }
        public void printList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.data + " ");
                tnode = tnode.next;
            }
        }
    }
}

        