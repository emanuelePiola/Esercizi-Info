using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Studente st = new Studente();
            StudenteInformatica inf = new StudenteInformatica();
            st.Nome = "Ariana";
            st.Cognome = "Grande";
            st.Matricola = "3435";
            st.mostraInformazioni();
            inf.Nome = "Marshall";
            inf.Cognome = "Mathers";
            inf.Matricola = "sl1m";
            inf.Specializzazione = "Tecnologie";
            inf.mostraInformazioni();
        }
    }
}
