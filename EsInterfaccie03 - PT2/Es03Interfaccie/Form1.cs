﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es03Interfaccie
{
    public partial class Form1 : Form
    {
        List<Utente> lstUtenti = new List<Utente>();
        List<ElementoLibreria> lstElementoLibreria = new List<ElementoLibreria>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUtente_Click(object sender, EventArgs e)
        {
            lstUtenti.Add(new Utente(txtNome.Text, 
                Convert.ToInt32(txtNTessera.Text)));
            dgvUtenti.Rows.Add(txtNome.Text, txtNTessera.Text);
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            lstElementoLibreria.Add(new Libro(txtTitoloLibro.Text, txtAutoreLibro.Text, 
                Convert.ToInt32(txtNumeroPag.Text)));
            dgvElementi.Rows.Add(txtTitoloLibro.Text, txtAutoreLibro.Text, txtNumeroPag.Text);
        }

        private void btnStatoPrestiti_Click(object sender, EventArgs e)
        {
            string prestiti = "";
            foreach (var elemento in lstElementoLibreria)
            {
                if(elemento.Prestito)
                {
                    prestiti += $"Elemento {elemento.Titolo} in prestito\n";
                }
            }
            MessageBox.Show(prestiti);
        }

        private void btnPrestito_Click(object sender, EventArgs e)
        {
            string nomeUtente=txtNome.Text;
            string titolo = txtTitoloPrestito.Text;

            Utente u = lstUtenti.Find(n => nomeUtente == n.Name);
            ILibreriaItem it = lstElementoLibreria.Find(t => titolo == t.Titolo);

            u.PrendiInPrestitoItem(it);
        }

        private void btnDVD_Click(object sender, EventArgs e)
        {
            lstElementoLibreria.Add(new DVD(txtTitoloDVD.Text, txtAutoreDVD.Text,
                txtGenere.Text));
            dgvElementi.Rows.Add(txtTitoloDVD.Text, txtAutoreDVD.Text, txtGenere.Text);
        }

        private void btnRestitutisci_Click(object sender, EventArgs e)
        {
            string nomeUtente = txtNome.Text;
            string titolo = txtTitoloPrestito.Text;

            Utente u = lstUtenti.Find(n => nomeUtente == n.Name);
            ILibreriaItem it = lstElementoLibreria.Find(t => titolo == t.Titolo);

            u.RestituisciItem(it);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDGV();
        }

        private void setDGV()
        {
            dgvUtenti.ColumnCount = 2; 
            dgvUtenti.RowCount = 1;
            dgvUtenti.ReadOnly = true;

            dgvUtenti.Columns[0].HeaderText = "Nome";
            dgvUtenti.Columns[1].HeaderText = "Numero Tessera";

            dgvElementi.ColumnCount = 3;
            dgvElementi.RowCount = 1;
            dgvElementi.ReadOnly = true;

            dgvElementi.Columns[0].HeaderText = "Titolo";
            dgvElementi.Columns[1].HeaderText = "Autore";
            dgvElementi.Columns[2].HeaderText = "Numero Pagine / Genere";
        }
    }
}
