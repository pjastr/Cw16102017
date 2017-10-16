using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszykJana = new Koszyk();
            koszykJana.DodajeProduktDoKoszyka("Mleko", 3);
            koszykJana.DodajeProduktDoKoszyka("chleb", 2);
            Console.ReadKey();
        }
    }
}
