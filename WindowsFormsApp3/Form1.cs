using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A,B,N;
            double.TryParse(textBox1.Text, out A);
            double.TryParse(textBox2.Text, out B);
            double.TryParse(textBox3.Text, out N);
            double fx;
            string s;
            for (double Nach = A; Nach <= B || Math.Abs(B - Nach) < 10E-6; Nach += (B - A) / N)
            {
                fx = Math.Sin(Nach) * Math.Cos(Nach) * Math.Exp(Nach);
                s = Nach.ToString("#######.000");
                richTextBox1.AppendText(s.PadLeft(10));
                s = string.Empty;
                s = s.PadLeft(10) + fx.ToString("#######.########");
                richTextBox1.AppendText(s + "\n");
            }
        }
    }
}
