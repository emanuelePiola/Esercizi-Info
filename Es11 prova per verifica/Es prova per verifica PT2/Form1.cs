using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Es11_prova_per_verifica;

namespace Es_prova_per_verifica_PT2
{
    public partial class Form1 : Form
    {
        public delegate void RegistrazioneEffettuata(string output);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            ucInvia.Reimposta();
        }

        //private void ucInvia_Leave(object sender, EventArgs e)
        //{
        //    RegistrazioneEffettuata registrazione = new RegistrazioneEffettuata(Conclusione);

        //    registrazione("Registrazione effettuata!\nTi ringraziamo per esserti iscritto");
        //}

        //static void Conclusione(string output)
        //{
        //    MessageBox.Show(output);
        //}
    }
}
