using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_Ese02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Squadre
        {
            public string nome;
            public string citta;
            public int giocate;
            public int vinte;
            public int pareggiate;
        }

        Squadre squadraA=new Squadre();
        Squadre squadraB=new Squadre();
        Squadre squadraC=new Squadre();

        private void btnCreaA_Click(object sender, EventArgs e)
        {
            if (cittaA.Text.Length <= 0 || giocateA.Text.Length <= 0)
            {
                MessageBox.Show("Inserire le cordinate del punto che si vuole creare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                squadraA.nome = nomeA.Text;
                squadraA.citta = cittaA.Text;
                squadraA.giocate = int.Parse(giocateA.Text);
            }
        }

        private void btnCreaB_Click(object sender, EventArgs e)
        {
            if (cittaB.Text.Length <= 0 || giocateB.Text.Length <= 0)
            {
                MessageBox.Show("Inserire le cordinate del punto che si vuole creare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                squadraB.nome = nomeB.Text;
                squadraB.citta = cittaB.Text;
                squadraB.giocate = int.Parse(giocateB.Text);
            }
        }

        private void btnCreaC_Click(object sender, EventArgs e)
        {
            if (cittaC.Text.Length <= 0 || giocateC.Text.Length <= 0)
            {
                MessageBox.Show("Inserire le cordinate del punto che si vuole creare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                squadraC.nome = nomeC.Text;
                squadraC.citta = cittaC.Text;
                squadraC.giocate = int.Parse(giocateC.Text);
            }
        }
    }
}
