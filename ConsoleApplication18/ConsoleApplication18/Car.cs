using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Car
    {
        public string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDzrwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public void UstawRokProdukcji(int rok)
        {
            this.rokProdukcji = rok;
        }

        public string Info()
        {
            return marka + " " + rokProdukcji;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }

        public double ObliczKosztSpalania(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
    }
}
