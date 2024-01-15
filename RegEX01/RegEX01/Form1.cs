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

namespace RegEX01
{
    public partial class Form1 : Form
    {
        string[] partNumbers = { "1298-673-4192", "A08Z-931-468A",
                                "_A90-123-129X", "12345-KKA-1230",
                                "0919-2893-1256" };
        public Form1()
        {
            InitializeComponent();

            //Regex.IsMatch...

            //(String,String)
            Regex rgx1 = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
            foreach (string partNumber in partNumbers)
            {
                string s1 = string.Format("{0} {1} a valid part number.",
                partNumber, rgx1.IsMatch(partNumber) ? "is" : "is not");
                MessageBox.Show(s1);
            }

            //(String,String,RegexOptions
            string pattern = @"^[A-Z0-9]\d{2}[A-Z0-9](-\d{3}){2}[A-Z0-9]$";
            foreach (string partNumber in partNumbers)
            {
                string s2 = string.Format("{0} {1} a valid part number.", 
                    partNumber, Regex.IsMatch(partNumber, pattern, RegexOptions.IgnoreCase) 
                    ? "is" : "is not");
                MessageBox.Show(s2);
            }

        }
    }
}
