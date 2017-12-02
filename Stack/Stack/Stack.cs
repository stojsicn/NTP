using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private Node top;
        private int len;
        private int capacity;

        public Stack(int capacity = 100)
        {
            this.capacity = capacity;
        }

        public int Length()
        {
            return len;
        }

        public bool IsEmpty()
        {
            return (len == 0);
        }

        public bool IsFull()
        {
            return (len == capacity);
        }

        public int Top()
        {
            if (top == null)
            {
                return 666;
            }
            else
            {
                return top.Data;
            }
        }

        public bool Push(int data)
        {
            Node novi = new Node(data);
            if (top == null)
            {
                top = novi;
                len++;
                return true;
            }
            else if (len == capacity)
            {
                return false;
            }

            else
            {
                novi.Next = top;
                top = novi;
                len++;
                return true;
            }
        }

        public bool Pop()
        {
            if (top == null)
            {
                return false;
            }
            else
            {
                top = top.Next;
                len--;
                return true;
            }
        }

        public override string ToString()
        {
            string s = "";
            Node temp = top;
            if (top == null)
            {
                s = "Prazna lista";
                return s;
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    s += (temp.Data + " ");
                    temp = temp.Next;
                }
                return s;
            }

        }
    }
}