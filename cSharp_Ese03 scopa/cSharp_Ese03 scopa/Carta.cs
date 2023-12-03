using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese03_scopa
{
    internal class Carta
    {
        private int valore;
        private string seme;

        private Carta(int valore, string seme)
        {
            this.valore = valore;
            this.seme = seme;
        }

        public void scrittura(int value, string suit)
        {
            valore = value;
            seme = suit;
        }

        public void lettura(out int value, out string suit) 
        {
            value = valore;
            suit = seme;
        }
    }
}
