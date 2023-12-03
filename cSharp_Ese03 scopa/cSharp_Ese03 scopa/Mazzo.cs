using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese03_scopa
{
    internal class Mazzo
    {
        Random rnd = new Random();

        private Carta[] collezioneCarte;

        private Mazzo()
        {
            collezioneCarte = new Carta[40];
        }

        public void mescola(ref Carta[] cards)
        {
            int n=rnd.Next(1, 100);
            for (int i = 0; i < n; i++)
            {
                int newIndex = rnd.Next(0, cards.Length);
                Carta aux = cards[newIndex];
                cards[newIndex] = cards[i];
                cards[i] = aux;
            }
        }

        public Carta estrai(Carta[] cards)
        {
            int i=rnd.Next(0, cards.Length);
            return cards[i];
        }
    }
}
