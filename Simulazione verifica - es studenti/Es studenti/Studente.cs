using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_studenti
{
    internal class Studente
    {
        private string nome;
        private string cognome;
        private string matricola;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Matricola { get => matricola; set => matricola = value; }

        public virtual void mostraInformazioni()
        {
            MessageBox.Show($"Studente {matricola}: {nome} {cognome}");
        }
    }
}
