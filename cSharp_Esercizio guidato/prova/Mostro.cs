using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class Mostro
    {
        protected double punti;
        protected string verso;
        public Mostro()
        {
            punti = 25;
            verso = "grugnito";
        }
        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
