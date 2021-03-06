﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvostruka_Ciklicna_lista
{
    class Lista
    {
        private Node head;
        private int len;
        
        public void AddFirst(int data)
        {
            Node temp = head;
            Node novi = new Node(data);
            if(head == null)
            {
                head = novi;
                head.Next = head;
                head.Prev = head;
                len++;
            }
            else
            {
                novi.Next = head;
                novi.Prev = head.Prev;
                (head.Prev).Next = novi;
                head.Prev = novi;
                head = novi;
                len++;
                
            }
        } //RADI

        public void AddLast(int data)
        {
            Node temp = head;
            Node novi = new Node(data);
            if (head == null)
            {
                head = novi;
                head.Next = head;
                head.Prev = head;
                len++;
            }
            else
            {
                novi.Next = head;
                novi.Prev = head.Prev;
                (head.Prev).Next = novi;
                head.Prev = novi;
                len++;
            }
        } //RADI

        public void Add(int data, int index)
        {
            Node temp = head;
            Node novi = new Node(data);
            if(head == null)
            {
                head = novi;
                head.Next = head;
                head.Prev = head;
                len++;
            }
            else
            {
                for(int i = 0; i <= index - 1; i++) // ZSATO MORAM -1 DA STAVIM
                {
                    temp = temp.Next;
                }

                novi.Next = temp.Prev.Next;
                novi.Prev = temp.Prev;
                temp.Prev.Next = novi;
                temp.Prev = novi;
                len++;
            }
        } //RADI ALI NE KONTAM (-1)

        public void Remove(int index)
        {
            Node temp = head;
            if(head == null)
            {
                Console.WriteLine("Nema sta da se brise");
            }
            else
            {
                for (int i = 0; i < index - 1; i++) // OPET ZASTO MORAM INDEX - 1
                {
                    temp = temp.Next;
                }

                (temp.Next.Next).Prev = temp;
                temp.Next = temp.Next.Next;
                len--;
                
            }
        } //RADI ALI NE KONTAM (-1)

        public int Find(int index)
        {
            Node temp = head;
            if(head == null)
            {
                Console.WriteLine("Nema sta da se pronadje");
                return 0;
            }
            else
            {
                for (int i = 0; i <= index - 1; i++) // ZASTO - 1
                {
                    temp = temp.Next;
                }

                return temp.Data;
            }
        } //RADI ALI NE KONTAM (-1)

        public void Reverse()
        {
           
            if(head == null)
            {
                return;
            }
            else
            {
                head = head.Prev;
                Node temp = head;
                for (int i = 0; i < len; i++)
                {
                    temp.Next = temp.Prev;
                    temp = temp.Next;
                }
            }
        } // RADI ALI NISAM SIGURAN STA SE DESILO SA PREV-OVIMA

        public int Length()
        {
            return len;
        } //RADI

        public int GetMax()
        {
            Node temp = head;
            Node max = head;
            int i = 0;
            if (head == null)
            {
                return -1;
            }
            else
            {
                do
                {
                    if (temp.Data > max.Data)
                    {
                        max = temp;
                        temp = temp.Next;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                } while (temp != head);

                return max.Data;
            }
        } //RADI

        public int GetMin()
        {
            Node temp = head;
            Node min = head;
            if (head == null)
            {
                return -1;
            }
            else
            {
                do
                {
                    if (temp.Data < min.Data)
                    {
                        min = temp;
                        temp = temp.Next;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                } while (temp != head);

                return min.Data;
            }
        } //RADI

        public void RemoveDuplicates()
        {
            Node temp = head;
            if (head == null)
            {
                return;
            }
            else
            {
                Node temp2 = head.Next;
                for (int i = 0; i < len; i++)
                {
                    int j = i + 1;
                    do
                    {
                        if (temp.Data == temp2.Data)
                        {
                            Remove(j);
                            temp2 = temp2.Next;
                        }
                        else
                        {
                            temp2 = temp2.Next;
                            j++;
                        }
                    } while (j != len);
                    temp = temp.Next;
                }
            }
        } //NE RADI

        public void Zamena()
        {
            Node temp = head;
            if(head == null || len == 1)
            {
                Console.WriteLine("Nema sta da se zameni");
            }
            else
            {
                (head.Prev.Prev).Next = head;
                (head.Next).Prev = head.Prev;
                (head.Prev).Prev = head;
                (head.Prev).Next = head.Next;
                head.Prev = head.Prev.Prev;
                head.Next = head.Prev;

            }
        } //NE RADI

        public override string ToString()
        {
            string s = "";
            Node temp = head;
            if (head == null)
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
        } //RADI
    }
}
