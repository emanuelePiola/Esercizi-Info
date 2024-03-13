using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsInterfaccie07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestioneSalvataggio gestioneSalvataggio = new GestioneSalvataggio();
            
            gestioneSalvataggio.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione);
            gestioneSalvataggio.salvataggioEseguito += new salvataggioEseguitoEventHandler(MiaFunzione2);

            gestioneSalvataggio.SalvaSuFile(5);
        }

        private void MiaFunzione(int id)
        {
            MessageBox.Show("Elemento " + id + " salvato correttamente");
        }

        private void MiaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore evento");
        }
    }
}
