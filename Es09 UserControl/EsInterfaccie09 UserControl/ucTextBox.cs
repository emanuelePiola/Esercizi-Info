using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsInterfaccie09_UserControl
{
    public partial class ucTextBox: UserControl
    {
        private bool isANumber = false;
        private string texts;
        private int decimalDigit = 0;

        public bool IsANumber { get => isANumber; set => isANumber = value; }
        public string Texts 
        {
            get {
                texts = txtText.Text;
                return texts;
            }
            set
            {
                texts = value;
                txtText.Text = texts;
            }
        }
        public int DecimalDigit
        {
            get { return decimalDigit; }
            set
            {
                decimalDigit = value;
                ReimpostaTesto();
            }
        }

        private void ReimpostaTesto()
        {
            if (isANumber && Texts != "") 
            {
                try
                {
                    if (ContaVirgole() > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }

                    //controllo dei decimali
                    double number = Math.Round(Convert.ToDouble(Texts), DecimalDigit);
                    Texts = number.ToString();

                    //gestione 0 dopo ,

                }
                catch (Exception)
                {
                    throw new Exception("Valore nn valido");
                }
            }
        }

        private int ContaVirgole()
        {
            int count = 0;
            for (int i = 0; i < texts.Length; i++)
            {
                char c = Convert.ToChar(texts.Substring(i, 1));
                if(c==',')
                {
                    count++;
                }
            }
            return count;
        }

        public ucTextBox()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            Texts = "";
        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if(IsANumber)
            {
                if(!(char.IsDigit(e.KeyChar) || e.KeyChar==',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
