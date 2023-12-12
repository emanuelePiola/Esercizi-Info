using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_studenti
{
    internal class StudenteInformatica : Studente
    {
        private string specializzazione;

        public string Specializzazione { get => specializzazione; set => specializzazione = value; }

        public override void mostraInformazioni()
        {
            MessageBox.Show($"Studente {Matricola}: {Nome} {Cognome} | specializzazione: {specializzazione}");
        }
    }
}
