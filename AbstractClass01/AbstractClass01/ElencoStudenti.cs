using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass01
{
    internal class ElencoStudenti : Report
    {
        private List<Studente> lstStudenti=new List<Studente>();
        private string stampa = "";

        protected override void printBody()
        {
            foreach (var studente in lstStudenti)
            {
                stampa += studente.ToString() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "\nFINE ELENCO";
        }

        protected override void printHeader()
        {
            stampa = "";
            stampa += "ELENCO COMPLETO DEGLI STUDENTI\n\n";
        }

        public ElencoStudenti()
        {
            lstStudenti.Add(new Studente("Andrea", "Giaccardi"));
            lstStudenti.Add(new Studente("Giacomo", "Visto"));
            lstStudenti.Add(new Studente("Simone", "Cesare"));
        }

        public string ritornoStampa()
        {
            return stampa;
        }
    }
}
