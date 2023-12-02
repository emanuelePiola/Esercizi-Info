using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova
{
    public partial class Form1 : Form
    {
        internal Mostro mos1;
        internal Mannaro man1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            mos1 = new Mostro();
            MessageBox.Show($"Valore: {mos1.Valore()}\nVerso: {mos1.Verso()}");
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            man1 = new Mannaro();
            MessageBox.Show($"Valore: {man1.Valore()}\nVerso: {man1.Verso()}");
            man1.Muta();
            MessageBox.Show($"Valore: {man1.Valore()}\nVerso: {man1.Verso()}");
        }
    }
}
