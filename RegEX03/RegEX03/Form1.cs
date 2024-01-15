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

namespace RegEX03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Regex.Split...

            //(String)
            string pattern1 = @"\d+";
            Regex rgx = new Regex(pattern1);
            string input1 = "123ABCDE456FGHIJKL789MNOPQ012";
            string[] result1 = rgx.Split(input1);
            for (int ctr = 0; ctr < result1.Length; ctr++)
            {
                Console.Write("'{0}'", result1[ctr]);
                if (ctr < result1.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
            //(String, String)
            string input2 = "plum--pear";
            string pattern2 = "-"; // Split on hyphens
            string[] substrings = Regex.Split(input2, pattern2);
            foreach (string match in substrings)
            {
                Console.WriteLine("'{0}'", match);
            }

            //(String, String, RegexOptions)
            string pattern3 = "[a-z]+";
            string input3 = "Abc1234Def5678Ghi9012Jklm";
            string[] result3 = Regex.Split(input3, pattern3,
            RegexOptions.IgnoreCase);
            for (int ctr = 0; ctr < result3.Length; ctr++)
            {
                Console.Write("'{0}'", result3[ctr]);
                if (ctr < result3.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
