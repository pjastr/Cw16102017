using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochod";

            Car car1 = new Car();
            car1.marka = "Ford";
            car1.UstawRokProdukcji(2014);

            //Car car2 = new Car();
            //car2.marka = "Skoda";
            //car2.UstawRokProdukcji(2016);

            //car2 = car1;

            //Console.WriteLine(car2.Info());
            car1.srednieSpalanie = 5.2;

            Console.WriteLine(car1.ObliczKosztSpalania(5.455, 6.78));

            Console.ReadKey();
        }


    }

    


}

    
