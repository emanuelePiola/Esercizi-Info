using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese03_scopa
{
    internal class Giocatore
    {
        private string nome;
        private Mano mano, prese;

        private Giocatore(string nome)
        {
            this.nome = nome;
            mano = new Mano();
            prese = new Mano();
        }

        public Carta[] lettura()
        {
            return mano.lettura();
        }

        public Carta[] cartePrese()
        {
            return prese.lettura();
        }

        public Carta gioca(Carta[] cards)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, cards.Length);
            return cards[i];
        }
    }
}
