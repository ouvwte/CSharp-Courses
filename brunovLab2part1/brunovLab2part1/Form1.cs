using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovLab2part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            Hide();
            int n = Convert.ToInt32(textBox1.Text);
            if (n % 10 == 1 && n % 100 != 11)
            {
                f2.label1.Text = Convert.ToString(n) + " рубль";
            }
            else if ((n % 10 == 2 && n % 100 != 12) ||
                     (n % 10 == 3 && n % 100 != 13) ||
                     (n % 10 == 4 && n % 100 != 14))
            {
                f2.label1.Text = Convert.ToString(n) + " рубля";
            }
            else
            {
                f2.label1.Text = Convert.ToString(n) + " рублей";
            }
        }
    }
}
