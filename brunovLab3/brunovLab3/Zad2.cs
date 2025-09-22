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
    public partial class Zad2 : Form
    {
        public Zad2()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
                dataGridView1.Rows.Add();
        }

        private void Zad2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zad3 newForm = new Zad3();
            newForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double r = 3;
            for (int i = 0; i < 10; i++)
            {
                dataGridView1[2, i].Value = "";
                double x = Convert.ToDouble(dataGridView1[0, i].Value);
                double y = Convert.ToDouble(dataGridView1[1, i].Value);
                if ((y >= 0 || x <= 0) && (x * x + y * y < r * r) && (x + y > -r))
                    dataGridView1[2, i].Value = "Попал!";
                else dataGridView1[2, i].Value = "Мимо!";
            }
        }
    }
}
