using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_dipendenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DipendenteTempoPieno dtpn = new DipendenteTempoPieno("Cristiano Ronaldo", 1000000000, 32);
            DipendenteTempoParziale dtprzl = new DipendenteTempoParziale("Paulo Dybala", 100000000, 32);
            MessageBox.Show($"Il dipendente a tempo pieno {dtpn.Nome} ha uno stipendio totale di {dtpn.calcolaStipendio().ToString()}");
            MessageBox.Show($"Il dipendente a tempo parziale {dtprzl.Nome} ha uno stipendio totale di {dtprzl.calcolaStipendio().ToString()}");
        }
    }
}
