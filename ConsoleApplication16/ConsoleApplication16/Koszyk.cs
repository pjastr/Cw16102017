using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Koszyk
    {
        public List<Produkt> lista = new List<Produkt>();

        public void DodajeProduktDoKoszyka(string nazwaProduktu, int cenaProduktu)
        {
            Produkt temp = new Produkt();
            temp.cena = cenaProduktu;
            temp.nazwa = nazwaProduktu;
            lista.Add(temp);
            Console.WriteLine("Dodano produkt: {0} {1}", nazwaProduktu, cenaProduktu);
        }

        public int IleProduktowWKoszyku()
        {
            return lista.Count;
        }

        public int Suma()
        {
            int suma = 0;
            foreach(var element in lista)
            {
                suma += element.cena;
            }
            return suma;
        }
    }
}
