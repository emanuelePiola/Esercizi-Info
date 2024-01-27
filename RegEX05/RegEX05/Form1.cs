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
            Regex regTel=new Regex(patTel);
            if(regTel.IsMatch(txtInput.Text))
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
