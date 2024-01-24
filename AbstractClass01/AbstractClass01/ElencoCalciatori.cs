using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass01
{
    internal class ElencoCalciatori : Report
    {
        private List<Calciatore> lstCalciatori = new List<Calciatore>();
        private string stampa = "";

        protected override void printBody()
        {
            foreach (var calciatore in lstCalciatori)
            {
                stampa += calciatore.ToString() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "\nFINE ELENCO";
        }

        protected override void printHeader()
        {
            stampa = "";
            stampa += "ELENCO DEI CALCIATORI\n\n";
        }

        public ElencoCalciatori()
        {
            lstCalciatori.Add(new Calciatore("Paulo", "Dybala", "Seconda Punta", 21));
            lstCalciatori.Add(new Calciatore("Gianluigi", "Buffon", "Portiere", 1));
            lstCalciatori.Add(new Calciatore("Silvio", "Piola", "Punta", 9));
        }

        public string ritornoStampa()
        {
            return stampa;
        }
    }
}
