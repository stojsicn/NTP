using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static bool Swap(Stack stack)
        {
            if (stack.IsEmpty() || stack.Length() == 1)
            {
                return false;
            }
            else
            {
                int prvi = stack.Top();
                stack.Pop();
                int drugi = stack.Top();
                stack.Pop();

                stack.Push(prvi);
                stack.Push(drugi);

                return true;
            }
        }

        static bool Rotate(Stack stack, int n)
        {
            Stack temp = new Stack();
            if (stack.IsEmpty())
            {
                return false;
            }
            else if (stack.Length() < n)
            {
                return false;
            }
            else
            {
                int br;
                br = stack.Top();
                stack.Pop();

                for (int i = 0; i < n - 1; i++)
                {
                    temp.Push(stack.Top());
                    stack.Pop();
                }
                stack.Push(br);
                for (int i = 0; i < n - 1; i++)
                {
                    stack.Push(temp.Top());
                    temp.Pop();
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(6);
            stack.Push(1);


            Console.WriteLine(stack);
            Rotate(stack, 4);
            Console.WriteLine(stack);
            Console.ReadKey();
        }
    }
}
