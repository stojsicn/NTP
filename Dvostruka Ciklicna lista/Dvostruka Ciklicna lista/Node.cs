using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvostruka_Ciklicna_lista
{
    class Node
    {
        private int data;
        private Node next;
        private Node prev;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node Prev
        {
            get { return prev; }
            set { prev = value; }
        }
        public Node(int data = 0)
        {
            Data = data;
        }
        public Node(int data, Node next, Node prev)
        {
            Data = data;
            Next = next;
            Prev = prev;
        }
    }
}
