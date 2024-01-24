using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass01
{
    public partial class Form1 : Form
    {
        private ElencoStudenti studenti = new ElencoStudenti();
        private ElencoCalciatori calciatori = new ElencoCalciatori();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStampaStudenti_Click(object sender, EventArgs e)
        {
            studenti.print();
            MessageBox.Show(studenti.ritornoStampa());
        }

        private void btnStampaCalciatori_Click(object sender, EventArgs e)
        {
            calciatori.print();
            MessageBox.Show(calciatori.ritornoStampa());
        }
    }
}
