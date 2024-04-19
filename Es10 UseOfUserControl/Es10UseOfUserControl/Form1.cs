using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10UseOfUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMiaTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore del Testo: " + txtMiaTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImpostaProperty(false);
        }

        private void ImpostaProperty(bool numero)
        {
            try
            {
                txtMiaTextBox.Clear();
                numericUpDown1.Value = 0;
                checkBox1.Checked = numero;
                txtMiaTextBox.IsANumber = numero;
                txtMiaTextBox.DecimalDigit = Convert.ToInt32(numericUpDown1.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ImpostaProperty(checkBox1.Checked);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtMiaTextBox.DecimalDigit = Convert.ToInt32(numericUpDown1.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
