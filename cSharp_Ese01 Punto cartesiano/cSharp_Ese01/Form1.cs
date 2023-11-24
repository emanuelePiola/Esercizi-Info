using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_Ese01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Punti
        {
            public double x;
            public double y;            
        }

        Punti puntoA = new Punti();
        Punti puntoB = new Punti();
        Punti puntoC = new Punti();

        private void btnCreaA_Click(object sender, EventArgs e)
        {
            if(xPuntoA.Text.Length<=0 || yPuntoA.Text.Length<=0)
            {
                MessageBox.Show("Inserire le cordinate del punto che si vuole creare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                puntoA.x = double.Parse(xPuntoA.Text);
                puntoA.y = double.Parse(yPuntoA.Text);
            }
        }

        private void btnCreaB_Click(object sender, EventArgs e)
        {
            if (xPuntoB.Text.Length <= 0 || yPuntoB.Text.Length <= 0)
            {
                MessageBox.Show("Inserire le cordinate del punto che si vuole creare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                puntoB.x = double.Parse(xPuntoB.Text);
                puntoB.y = double.Parse(yPuntoB.Text);
            }
        }

        private void btnCreaC_Click(object sender, EventArgs e)
        {
            if (xPuntoC.Text.Length <= 0 || yPuntoC.Text.Length <= 0)
            {
                MessageBox.Show("Inserire le cordinate del punto che si vuole creare", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                puntoA.x = double.Parse(xPuntoC.Text);
                puntoA.y = double.Parse(yPuntoC.Text);
            }
        }
    }
}
