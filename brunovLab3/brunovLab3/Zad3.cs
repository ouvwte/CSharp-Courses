using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace brunovLab3
{
    public partial class Zad3 : Form
    {
        public Zad3()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
                dataGridView1.Rows.Add();
        }

        private void Zad3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double E = Convert.ToDouble(textBox4.Text);
            double s;
            for (double x = x1; x <= x2; x += dx)
            {
                double el = x;
                s = 0;
                int n = 1;
                int el_kol = 0;
                while (Math.Abs(el) > E)
                {
                    s += el;
                    n++;
                    el_kol++;
                    el = Math.Pow(x, n) / n;
                }
                dataGridView1.Rows.Add(String.Format("{0:0.0}", x), String.Format("{0:0.00}", -s), String.Format("{0:0.00}", el_kol));
            }
        }
    }
}