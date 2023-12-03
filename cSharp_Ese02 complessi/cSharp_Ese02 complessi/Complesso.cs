using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese02_complessi
{
    internal class Complesso
    {
        protected double reale;
        protected double immaginario;

        private Complesso() : this (0, 0) { }
        private Complesso(string complesso) 
        {
            this.reale = double.Parse(complesso.Split('i')[0]);
            this.immaginario = double.Parse(complesso.Split('i')[1]);
        }
        private Complesso(double reale, double immaginario)
        {
            this.reale = reale;
            this.immaginario = immaginario;
        }   

        public void Get(out double parte_reale, out double parte_immaginaria) 
        {
            parte_reale = reale;
            parte_immaginaria = immaginario;
        }

        public double modulo(double reale, double immaginario)
        {
            return Math.Sqrt(Math.Pow(reale,2)+Math.Pow(immaginario,2));
        }

        public double coniugato(double immaginario)
        {
            return -immaginario;
        }
    }
}
