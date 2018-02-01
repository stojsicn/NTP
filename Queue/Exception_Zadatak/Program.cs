using System;

namespace Artikli
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupac Nikola(1500);

            Nikola.DodajArtikal("Hleb", 100);
            Nikola.DodajArtikal("Mleko", 450);
            Nikola.DodajArtikal("Cokolada", 450);

            Univer Prodavnica(3);

            Kasa PrvaKasa();

            PrvaKasa.NoviKupac(Nikola);
            PrvaKasa.ResiKupca(Nikola);
        }
    }
}
