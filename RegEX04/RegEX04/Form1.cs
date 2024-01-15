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

namespace RegEX04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Regex.Replace(String,String)
            string input = "This is text with far too much whitespace.";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            string s = string.Format("Original String: {0}\n", input);
            s += string.Format("Replacement String: {0}", result);
            MessageBox.Show(s);
        }
    }
}
