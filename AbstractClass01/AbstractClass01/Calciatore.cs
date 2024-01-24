using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass01
{
    internal class Calciatore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Ruolo { get; set; }
        public int Numero { get; set; }

        public Calciatore(string nome, string cognome,string ruolo, int numero)
        {
            Nome = nome;
            Cognome = cognome;
            Ruolo = ruolo;
            Numero = numero;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome + " " + Numero + "\nGioca come: " + Ruolo;
        }
    }
}
