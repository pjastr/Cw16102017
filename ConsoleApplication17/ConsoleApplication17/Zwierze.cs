using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Zwierze
    {
        private string nazwa;
        internal int liczbaNog;
        public bool ogon;

        public string Info()
        {
            return "Opis zwierzeta";
        }
        internal bool CzyPotrzebnySpacer(int h)
        {
            if (h < 12) return true;
            else return false;
        }

        public void UstawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }
    }
}
