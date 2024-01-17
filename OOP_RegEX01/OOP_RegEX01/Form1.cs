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

namespace OOP_RegEX01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string pat = "^{10,}[a-zA-Z]{4}[1-9]{3}[#,$,&]{1,}";
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
        }
    }
}
