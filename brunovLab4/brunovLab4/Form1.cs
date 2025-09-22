using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace brunovLab4
{
    public partial class Form1 : Form
    {
        int[] mas;
        int n;
        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView2.RowCount = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            dataGridView1.ColumnCount = n;
            mas = new int[n];
            for (int i = 0; i < n; i++) {
                mas[i] = ran.Next(-100, 100);//Заполняем случайными числами в диапазоне
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Находим максимальный элемент массива
            double max = mas.Max();

            // Ищем последний положительный элемент и считаем сумму элементов до него
            double sum = 0;
            int lastPositiveIndex = -1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    lastPositiveIndex = i;
                }
            }
            for (int i = 0; i < lastPositiveIndex; i++) {
                if (lastPositiveIndex >= 0 && i < lastPositiveIndex)
                {
                    sum += mas[i];
                }
            }
            label5.Text = Convert.ToString(max);
            label7.Text = Convert.ToString(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Сжатие массива
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            dataGridView2.ColumnCount = n;
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(mas[i]) < a || Math.Abs(mas[i]) > b)
                {
                    mas[index++] = mas[i];
                }
            }

            Array.Resize(ref mas, index);
            Array.Resize(ref mas, n + (n - index));

            for (int i = index; i < n; i++)
            {
                mas[i] = 0;
            }
            for (int i = 0; i < n; i++) dataGridView2.Rows[0].Cells[i].Value = mas[i];
        }
    }
}
