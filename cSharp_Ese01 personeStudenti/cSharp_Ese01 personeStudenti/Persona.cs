using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Ese01_personeStudenti
{
    internal class Persona
    {
        protected string nome;
        protected string cognome;
        protected char sesso;
        protected int eta;

        public void Set(string name, string surname, char sex, int age)
        {
            nome = name;
            cognome = surname;
            sesso = sex;
            eta = age;
        }

        public void Get(out string name,out string surname,out char sex,out int age)
        {
            name = nome;
            surname = cognome;
            sex = sesso;
            age = eta;
        }
    }
}
