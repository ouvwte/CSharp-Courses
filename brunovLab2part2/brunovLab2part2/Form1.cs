using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovLab2part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = 0;
            int r = 3;
            if ((x > 10) || (x <- 8)) {
                MessageBox.Show("Аргумент не входит в область определения! Введите корректное значение (в диапазоне [-8; 10]).");
            }
            else
            {
                if ((x > -8) && (x <= -5)) y = -3;
                if ((x > -5) && (x <= -3)) y = x + 3;
                if ((x > -3) && (x <= 3)) y = Math.Sqrt((r*r)-(x*x));
                if ((x > 3) && (x <= 8)) y = 0.6*x - 1.8;
                if ((x > 8) && (x <= 10)) y = 3;

                label4.Text = Convert.ToString(y);
            }
        }
    }
}
