using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_06_IComparable {
    public partial class Form1 : Form {
        List<Persona> Persone = new List<Persona>();
        public Form1() {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e) {
            Persone.Add(new Persona {
                Nome = txtNome.Text,
                Cognome = txtCognome.Text,
                Eta = int.Parse(txtEta.Text) | 0
            });
        }

        private void btnElenco_Click(object sender, EventArgs e) {
            Persone.Sort();
            string elenco = string.Empty;

            foreach (var item in Persone) {
                elenco += $"Cognome: {item.Cognome}\tNome: {item.Nome}\tEtà: {item.Eta}\n";
            }

            MessageBox.Show(elenco);
        }
    }
}
