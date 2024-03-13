using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_07_Delegates {
    // Dichiarazione delegate che accetta 2 parametri e restituisce un intero
    public delegate int Operazione(int a, int b);
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Dichiarazione 3 funzioni che utilizzerà il delegate
        public int Addizione(int a, int b) {
            return a + b;
        }
        public int Moltiplicazione(int a, int b) {
            return a * b;
        }
        public int Sottrazione(int a, int b) {
            return a - b;
        }

        public int Modulo(int a, int b, Operazione operazione) {
            if (a >= b) {
                return operazione(a, b);
            }
            else {
                return operazione(b, a);
            }
        }

        private void btnAddizione_Click(object sender, EventArgs e) {
            // Istanziazione del delegate con parametro il nome della funzione
            Operazione operazione = new Operazione(Addizione);

            // Richiamo del delegate
            MessageBox.Show($"Somma = {operazione(10, 15)}");
        }

        private void btnMoltiplicazione_Click(object sender, EventArgs e) {
            // Istanziazione del delegate con parametro il nome della funzione
            Operazione operazione = Moltiplicazione;

            // Richiamo del delegate
            MessageBox.Show($"Prodotto = {operazione(10, 15)}");
        }

        private void btnSottrazione1_Click(object sender, EventArgs e) {
            // Istanziazione del delegate con parametro il nome della funzione
            Operazione operazione = Sottrazione;

            // Richiamo del delegate
            MessageBox.Show($"Differenza = {operazione(10, 15)}");
        }

        private void btnSottrazione2_Click(object sender, EventArgs e) {
            // Istanziazione del delegate con parametro il nome della funzione
            Operazione operazione = Sottrazione;

            // Richiamo del delegate
            MessageBox.Show($"Modulo = {Modulo(10, 15, operazione)}");
        }
    }
}
