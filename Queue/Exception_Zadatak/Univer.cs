using System;

namespace Artikli
{
    class Program
    {
        public class Univer
        {
            public Kasa[] Kase;
            private int brKasa;

            public Univer(int brk)
            {
                Kase = new Kasa[brk];
            }

            public void OtvoriKasu()
            {
                brKasa++;
                Kase = new Kasa[brKasa];
            }

            public void ZatvoriKasu()
            {
                brKasa--;
                Kase = new Kasa[brKasa];
            }
        }
    }
}