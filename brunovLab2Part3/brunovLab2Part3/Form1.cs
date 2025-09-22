using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovLab2Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double r = Convert.ToDouble(textBox3.Text);
            if ((y >= 0 || x <= 0) && (x * x + y * y < r * r) && (x + y > -r)) 
            {
                label5.Text = Convert.ToString("Точка попала в закрашенную область.");
            }
            else label5.Text = Convert.ToString("Точка не попала в закрашенную область.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
