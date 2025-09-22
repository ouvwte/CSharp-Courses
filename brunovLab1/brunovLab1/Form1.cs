using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            Hide();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            Hide();
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
            Hide();
            int a = Convert.ToInt32(f3.textBox1.Text);
            int b = Convert.ToInt32(f3.textBox2.Text);
            int c = Convert.ToInt32(f3.textBox3.Text);
            if (f3.checkBox1.Checked)
            {
                int s = a + b + c;
                f4.label1.Text = "Сумма чисел равна " + Convert.ToString(s);
            }
            if (f3.checkBox2.Checked)
            {
                int nok, nod;
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                nod = a;
                nok = (a*b) / nod;

                f4.label1.Text = "Наименьший общий делитель первых двух чисел равен " + Convert.ToString(nok);
            }
        }
    }
}
