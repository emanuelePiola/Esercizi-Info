using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_dipendenti
{
    internal class Dipendenti
    {
        private string nome;
        private int salarioBase;

        internal Dipendenti(string name, int baseSalary) 
        {
            Nome = name;
            SalarioBase = baseSalary;
        }

        public string Nome { get => nome; set => nome = value; }
        public int SalarioBase { get => salarioBase; set => salarioBase = value; }

        public virtual int calcolaStipendio()
        {
            return SalarioBase;
        }
    }
}
