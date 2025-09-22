using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
            Hide();
            int a = Convert.ToInt32(textBox1.Text);
            if ( a % 10 == 1)
            {
                f2.label2.Text = Convert.ToString(a) + " рубль";
            }
            if (a % 10 == 2 && a % 10 == 4)
            {
                f2.label2.Text = Convert.ToString(a) + " рубля";
            }
            if (a == 1)
            {
                f2.label2.Text = Convert.ToString(a) + " рубль";
            }
            else
            {
                f2.label2.Text = Convert.ToString(a) + " рублей";
            }
        }
    }
}
