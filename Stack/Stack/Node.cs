using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data = 0, Node next = null)
        {
            Data = data;
            Next = next;
        }
        public Node(int data = 0)
        {
            Data = data;
            Next = null;
        }
    }
}
