﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_RegEX01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Regex regMatricola;
        Regex regNomeCognome;
        Regex regMail;

        private void Form1_Load(object sender, EventArgs e)
        {
            string patMatricola = @"^{10,}[a-zA-Z]{4}[1-9]{3}[#,$,&]{1,}";
            string patNomeCognome = @"^{3,}";
            string patMail = @"[\w,.]{3,}[@]{1}\w{3,}[.]{1}\w{2,}";

            regMatricola = new Regex(patMatricola, RegexOptions.IgnoreCase);
            regNomeCognome = new Regex(patNomeCognome, RegexOptions.IgnoreCase);
            regMail = new Regex(patMail, RegexOptions.IgnoreCase);
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {

            if (!regMatricola.IsMatch(txtMatricola.Text))
            {
                MessageBox.Show("Matricola NON valida!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricola.Text = "";
                return;
            }
            else if(!regNomeCognome.IsMatch(txtNome.Text))
            {
                MessageBox.Show("Nome NON valido!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                return;
            }
            else if (!regNomeCognome.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Cognome NON valido!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCognome.Text = "";
                return;
            }
            else if (!regMail.IsMatch(txtMail.Text))
            {
                MessageBox.Show("Mail NON valida!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Text = "";
                return;
            }
            MessageBox.Show("Dati inseriti CORRETTAMENTE", "Operazione Riuscita", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtMatricola.Text = txtNome.Text = txtCognome.Text = txtMail.Text = "";
        }
    }
}
