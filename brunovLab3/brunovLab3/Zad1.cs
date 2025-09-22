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
    public partial class Zad1 : Form
    {
        public Zad1()
        {
            InitializeComponent();
            /*for (int i = 0; i < 10; i++)
                dataGridView1.Rows.Add();*/
        }

        private void Zad1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zad2 newForm = new Zad2();
            newForm.Show();
            Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double y = 0;
            int r = 3;
            dataGridView1.Rows.Clear();
            for (double x = x1; x <= x2; x += dx)
            {
                if ((x > -8) && (x <= -5)) y = -3;
                if ((x > -5) && (x <= -3)) y = x + 3;
                if ((x > -3) && (x <= 3)) y = Math.Sqrt((r * r) - (x * x));
                if ((x > 3) && (x <= 8)) y = 0.6 * x - 1.8;
                if ((x > 8) && (x <= 10)) y = 3;
                dataGridView1.Rows.Add(String.Format("{0:0.0}", x), String.Format("{0:0.00}", y));
            }
        }
    }
}
