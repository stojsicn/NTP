using System;

namespace Artikli
{
    class Program
    {
        public class Kasa
        {
            private Queue<Kupac> Red;
            private List<Artikal> Racun;
            private const int VPA = 10; // Vreme Po Artiklu
            private int UkupnoNovca, UkupnoVreme, BrojKupaca;
            private const int RacunPapir = 0;

            public Kasa()
            {
                Red = new Queue<Kupac>();
                Racun = new List<Artikal>();
                UkupnoNovca = 0;
                UkupnoVreme = 0;
                BrojKupaca = 0;
            }

            public void NoviKupac(Kupac k)
            {
                try
                {
                    Red.Enqueue(k);
                }
                catch (OutOfMemoryException e)
                {
                    MessageBox.Show("Nema prostora za novog kupca!");
                }
            }

            public void ResiKupca(Kupac k)
            {
                try
                {
                    k = Red.Dequeue();
                }
                catch(InvalidOperationException e)
                {
                    MessageBox.Show("Red je prazan!");
                }

                Racun = k.Korpa.ToList();
                foreach(Artikal a in k.Korpa)
                {
                    UkupnoNovca += a.Cena;
                    UkupnoVreme += VPA;
                }
                BrojKupaca++;

                Console.WriteLine("Vas Racun:");
                for(int i = 0; i < Racun.Count(); ++i)
                {
                    Console.WriteLine("/tNaziv: {0}", a.Naziv);
                    Console.WriteLine("/tCena: {0}", a.Cena);
                    RacunPapir += a.Cena;
                }
                Console.WriteLine("/tUkupno: {0}", RacunPapir);
            }
        }
    }
}