using System;

namespace Artikli
{
    class Program
    {
        public class Kupac
        {
            private List<Artikal> Korpa;
            private int Novac;

            public Kupac(int n)
            {
                Korpa = new List<Artikal>();
                Novac = n;
            }

            public void DodajArtikal(Artikal a)
            {
                try
                {
                    Korpa.Add(a);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Greska pri dodavanju u korpu!");
                }
            }

            public void VratiArtikal(int pozicija)
            {
                try
                {
                    Korpa.RemoveAt(pozicija);
                }
                catch(ArgumentOutOfRangeException e)
                {
                    MessageBox.Show("Data pozicija je pogresno uneta!");
                }
            }
        }
    }
}