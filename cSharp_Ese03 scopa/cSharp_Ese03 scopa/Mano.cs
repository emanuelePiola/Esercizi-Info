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
            return collezioneCarte;
        }

        public Carta gioca(Carta[] cards)
        {
            int i = rnd.Next(0, cards.Length);
            return cards[i];
        }

        public Carta[] generaMazzo(int numCarte=40)
        {
            collezioneCarte = new Carta[numCarte];
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < numCarte/4; j++)
                {
                    int value = i;
                    int n_suit = j;
                    string suit = "";
                    switch (n_suit)
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
                    collezioneCarte[k++].scrittura(value, suit);
                }
            }
            return collezioneCarte;
        }
    }
}
