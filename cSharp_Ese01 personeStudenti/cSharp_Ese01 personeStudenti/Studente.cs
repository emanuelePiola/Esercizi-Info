using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese01_personeStudenti
{
    internal class Studente : Persona
    {
        private int[] voti;

        public double media(int[] voti)
        {
            double som = 0;
            for (int i = 0; i < voti.Length; i++)
            {
                som += voti[i];
            }
            return som/voti.Length;
        }
    }
}
