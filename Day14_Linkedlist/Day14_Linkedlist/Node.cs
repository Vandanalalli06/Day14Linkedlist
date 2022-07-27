using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Linkedlist
{
    internal class Node//2 global variables
    {
        public int data;//if we would not initialize the data value then the default value will be 0 as this is having datatype Int
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}








