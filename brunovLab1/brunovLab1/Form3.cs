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

namespace brunovLab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string textbox = Convert.ToString(textBox1.Text);
            if (textbox != "")
            {
                int n;
                bool etochislo = int.TryParse(textbox, out n);
                if (etochislo == false) MessageBox.Show("Введите число негодяи!");
            }*/
            int value;
            if (Int32.TryParse(textBox1.Text, out value))
            {
                // работаем с value
            }
            else
            {
                MessageBox.Show("Введите число");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*string textbox = Convert.ToString(textBox2.Text);
            if (textbox != "")
            {
                int n;
                bool etochislo = int.TryParse(textbox, out n);
                if (etochislo == false) MessageBox.Show("Введите число негодяи!");
            }*/
            int value;
            if (Int32.TryParse(textBox2.Text, out value))
            {
                // работаем с value
            }
            else
            {
                MessageBox.Show("Введите число");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*string textbox = Convert.ToString(textBox3.Text);
            if (textbox != "")
            {
                int n;
                bool etochislo = int.TryParse(textbox, out n);
                if (etochislo == false) MessageBox.Show("Введите число негодяи!");
            }*/
            int value;
            if (Int32.TryParse(textBox3.Text, out value))
            {
                // работаем с value
            }
            else
            {
                MessageBox.Show("Введите число");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
