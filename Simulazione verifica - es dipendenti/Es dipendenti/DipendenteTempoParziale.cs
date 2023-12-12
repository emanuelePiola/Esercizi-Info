using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_dipendenti
{
    internal class DipendenteTempoParziale : Dipendenti
    {
        private int oreLavorate;

        internal DipendenteTempoParziale(string name, int baseSalary, int workHours) : base(name, baseSalary)
        {
            Nome = name;
            SalarioBase = baseSalary;
            oreLavorate = workHours;
        }

        public override int calcolaStipendio()
        {
            return SalarioBase + (oreLavorate * 8); //8 sono gli euro per ogni ora supposti
        }
    }
}
