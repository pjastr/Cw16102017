using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Koszyk
    {
        List<Produkt> lista = new List<Produkt>();

        public void DodajeProduktDoKoszyka(string nazwaProduktu, double cenaProduktu)
        {
            Produkt temp = new Produkt();
            temp.nazwa = nazwaProduktu;
            temp.cena = cenaProduktu;
            lista.Add(temp);
            Console.WriteLine("Dodano produkt: {0} {1}", nazwaProduktu, cenaProduktu);
        }
    }
}
