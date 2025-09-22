using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zad1 f2 = new Zad1();
        Zad2 f3 = new Zad2();
        Zad3 f4 = new Zad3();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            Hide();
            /*
            double x1 = Convert.ToDouble(f2.textBox1.Text);
            double x2 = Convert.ToDouble(f2.textBox2.Text);
            double dx = Convert.ToDouble(f2.textBox3.Text);
            double y = 0;
            chart1.Series[0].Points.Clear();
            int r = 3;
            for (double x = x1; x <= x2; x += dx)
            {
                if ((x > -8) && (x <= -5)) y = -3;
                if ((x > -5) && (x <= -3)) y = x + 3;
                if ((x > -3) && (x <= 3)) y = Math.Sqrt((r * r) - (x * x));
                if ((x > 3) && (x <= 8)) y = 0.6 * x - 1.8;
                if ((x > 8) && (x <= 10)) y = 3;
                dataGridView1.Rows.Add(String.Format("{0:0.0}", x), String.Format("{0:0.00}", y));
                chart1.Series[0].Points.AddXY(x, y);
            }
            */
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            Hide();
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
            Hide();
        }
    }
}
