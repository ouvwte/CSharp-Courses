using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brunovKpSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a;
        int n = 5;
        Random ran = new Random();

        Form f2 = new Form2();
        Form f3 = new Form3();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = n;
            dataGridView2.ColumnCount = n;
        }

        private void описаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сортировка вставками
            Hide();
            f2.Show();
        }

        private void запускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сортировка вставками
            int j, buf;
            for (int i = 1; i < n; i++)
            {
                buf = a[i];
                j = i - 1;
                while (j >= 0 && a[j] > buf)
                {
                    a[j + 1] = a[j];
                    a[j] = buf;
                    j--;

                }
            }
            for (int i = 0; i < n; i++) dataGridView2[i, 0].Value = a[i];
        }

        private void описаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //пузырьком
            Hide();
            f3.Show();
        }

        private void запускToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //пузырьком
            int buf;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 2; j >= i; j--)
                {
                    if (a[j] > a[j + 1])
                    {
                        buf = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = buf;
                    }
                }
            }
            for (int i = 0; i < n; i++) dataGridView2[i, 0].Value = a[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = n;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = ran.Next(-100, 100);//Заполняем случайными числами в диапазоне
                dataGridView1.Rows[0].Cells[i].Value = a[i];
            }
        }

        
    }
}
