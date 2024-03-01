using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es03Interfaccie
{
    internal class DVD : ElementoLibreria
    {
        public string Genere { get; set; }

        public DVD(string titolo, string autore, string genere) : base(titolo, autore)
        {
            Genere = genere;
        }

        public override void PrendiInPrestito()
        {
            this.Prestito = true;
            MessageBox.Show($"Il DVD {Titolo} è stato preso in prestito");
        }

        public override void Restituisci()
        {
            this.Prestito = false;
            MessageBox.Show($"Il DVD {Titolo} è stato restituito");
        }
    }
}
