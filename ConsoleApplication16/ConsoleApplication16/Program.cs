using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszykJana = new Koszyk();
            koszykJana.DodajeProduktDoKoszyka("Mleko", 2);
            koszykJana.DodajeProduktDoKoszyka("Chleb", 2);
            koszykJana.DodajeProduktDoKoszyka("Jabłko", 2);
            Console.WriteLine(koszykJana.IleProduktowWKoszyku());
            Console.WriteLine(koszykJana.Suma());
            Console.ReadKey();
        }
    }
}
