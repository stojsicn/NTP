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

            list.Add(1, 0);
            list.Add(2, 1);
            list.Add(2, 2);
            list.Add(3 ,3);
            list.Add(4, 4);
            list.Add(5, 5);
            list.Add(3, 6);

            Console.WriteLine(list.GetMin());


            Console.WriteLine(list);
            Console.ReadKey();
        }
    }
}
