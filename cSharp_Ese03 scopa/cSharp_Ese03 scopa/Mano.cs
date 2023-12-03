using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese03_scopa
{
    internal class Mano
    {
        Random rnd = new Random();

        private Carta[] collezioneCarte;

        public Mano()
        {
            for (int i = 0; i < collezioneCarte.Length; i++)
            {
                collezioneCarte[i] = null;
            }
        }

        public Carta[] lettura()
        {
            collezioneCarte = new Carta[40];
            for (int i = 0; i < collezioneCarte.Length; i++)
            { 
                int value = rnd.Next(1, 11);
                int n_suit= rnd.Next(0, 4);
                string suit="";
                switch(n_suit)
                {
                    case 0:
                        suit = "Picche";
                        break;
                    case 1:
                        suit = "Cuori";
                        break;
                    case 2:
                        suit = "Fiori";
                        break;
                    case 3:
                        suit = "Rombi";
                        break;
                }
                collezioneCarte[i].scrittura(value, suit);
            }
            return collezioneCarte;
        }

        public Carta gioca(Carta[] cards)
        {
            int i = rnd.Next(0, cards.Length);
            return cards[i];
        }
    }
}
