using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_dipendenti
{
    internal class DipendenteTempoPieno : Dipendenti
    {
        private int oreLavorate;

        internal DipendenteTempoPieno(string name, int baseSalary, int workHours) : base(name, baseSalary)
        {
            Nome = name;
            SalarioBase = baseSalary;
            oreLavorate = workHours;
        }

        public override int calcolaStipendio()
        {
            return SalarioBase + (oreLavorate * 10); //10 sono gli euro per ogni ora supposti
        }
    }
}
