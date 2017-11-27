using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvostruka_Ciklicna_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista list = new Lista();

            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(5);

            list.Remove(3);

            Console.WriteLine(list.Find(2));

            Console.WriteLine(list.Length());



            Console.WriteLine(list);
            Console.ReadKey();
        }
    }
}
