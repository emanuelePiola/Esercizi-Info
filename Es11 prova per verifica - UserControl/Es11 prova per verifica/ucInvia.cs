using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Es11_prova_per_verifica
{
    public partial class ucInvia: UserControl
    {
        public ucInvia()
        {
            InitializeComponent();
        }

        private bool inviata = false;
        private string valore; 

        public bool Inviata { get => inviata; set => inviata = value; }

        public string Valore
        {
            get
            {
                valore = txtTestoDaInviare.Text;
                return valore;
            }
            set
            {
                valore = value;
                txtTestoDaInviare.Text = valore;
            }
        }

        public string Invia()
        {
            if(Valore!="")
            {
                if (Inviata)
                {
                    return "Contenuto appena inviato!\nCambiare il contenuto per procedere ad un nuovo invio";
                }
                else
                {
                    Inviata = true;
                    return "Il valore inviato corrisponde a: " + Valore;
                }
            }
            else
            {
                return "Contenuto non esistente!";
            }
        }

        private void txtTestoDaInviare_TextChanged(object sender, EventArgs e)
        {
            Inviata = false;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Invia());
        }

        public void Reimposta()
        {
            Inviata = false;
            txtTestoDaInviare.Text = "";
            Valore = "";
        }
    }
}
