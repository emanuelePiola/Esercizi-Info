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

namespace RegEX02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Regex.Match...

            //(String)
            string text = "One car red car blue car";
            string pat = @"(\w+)\s+(car)";
            string s1 = "";
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            Match m1 = r.Match(text);
            int matchCount = 0;
            while (m1.Success)
            {
                s1 = "Match" + (++matchCount));
                for (int i = 1; i <= 2; i++)
                {
                    Group g = m1.Groups[i];
                    s1 += string.Format("Group" + i + "='" + g + "'");
                    CaptureCollection cc = g.Captures;
                    for (int j = 0; j < cc.Count; j++)
                    {
                        Capture c = cc[j];
                        s1 += string.Format("Capture" + j + "='" + c + "', position=" + c.Index);
                    }
                    s1 += "\n";
                }
                m1 = m1.NextMatch();
                s1 += "\n\n";
            }
            MessageBox.Show(s1);

            //(String,String)
            string input1 = "ablaze beagle choral dozen elementary fanatic " +
                        "glaze hunger inept jazz kitchen lemon minus " +
                        "night optical pizza quiz restoration stamina " +
                        "train unrest vertical whiz xray yellow zealous";

            string pattern1 = @"\b\w*z+\w*\b";
            string s2 = "";
            Match m2 = Regex.Match(input1, pattern1);
            while (m2.Success)
            {
                s2 += string.Format("'{0}' found at position {1}\n", m2.Value, m2.Index);
                m2 = m2.NextMatch();
            }

            //(String, String, RegexOptions)
            string pattern2 = @"\ba\w*\b";
            string input2 = "An extraordinary day dawns with each new day.";
            Match m3 = Regex.Match(input2, pattern2, RegexOptions.IgnoreCase);
            if (m3.Success)
            {
                MessageBox.Show(string.Format("Found '{0}' at position {1}.", m3.Value, m3.Index));
            }
        }
    }
}
