using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegEX05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            string patTel = @"^\d{2} {1}\d{8}$|^\d{3} {1}\d{7}$|^\d{4} {1}\d{6}$";
            regexLauncher(patTel);
        }

        private void btnSpecializzazione_Click(object sender, EventArgs e)
        {
            string patSpec = @"^INF$|^ELT$|^MEC$";
            regexLauncher(patSpec);
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            string patClass = @"^[1-5]{1}[A-Z]{1}\s{0,1}(INF|ELT|MEC)$|^[1-5]{1} [A-Z]{1} (INF|ELT|MEC)$";
            regexLauncher(patClass);
        }

        private void btnImporto_Click(object sender, EventArgs e)
        {
            string patImp = @"^\d{1,},\d{2}$|^\d{1,}$";
            regexLauncher(patImp);
        }

        private void btnCodFiscale_Click(object sender, EventArgs e)
        {
            string patCFis = @"^[A-Z]{6}\d{2}[A-Z]{1}\d{2}([A-Z]{1}\d{3}|\d{1}[A-Z]{1}\d{2}|\d{2}[A-Z]{1}\d{1}|\d{3}[A-Z]{1})[A-Z]{1}$";
            regexLauncher(patCFis);
        }

        private void regexLauncher(string pattern)
        {
            Regex reg = new Regex(pattern);
            if (reg.IsMatch(txtInput.Text))
            {
                MessageBox.Show("L'input inserito è corretto");
            }
            else
            {
                MessageBox.Show("L'input inserito è sbagliato");
            }
        }
    }
}
