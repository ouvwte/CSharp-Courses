using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovLab5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = f.ReadToEnd();
            }

            string s = textBox1.Text;
            string[] str = s.Split(' ');
            for (int i = 0; i < str.Length - 1; i += 2)
            {
                string temp = str[i];
                str[i] = str[i + 1];
                str[i + 1] = temp;
            }
            label3.Text = string.Join(" ", str);
        }
    }
}
