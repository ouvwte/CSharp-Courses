using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Kyrsovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label3.Text = "";
            dataGridView1.Hide();
            button2.Hide();
            button3.Hide();
            chart1.Hide();
            Size = new Size(470, 130);
        }

        Form2 f2 = new Form2();


        private void button1_Click(object sender, EventArgs e)
        {
            Size = new Size(470, 420);
            dataGridView1.Show();
            button2.Show();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            int i = 1;
            int n = 0;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                label2.Text = "Введено некорректное количество точек";
            }
            if (n >= 2)
            {
                label2.Text = "Введите координаты точек в таблицу";
                for (i = 1; i <= n; i++)
                {
                    dataGridView1.Rows.Add(String.Format("{0:0}", i));
                }
            }
            if (n == 1) { label2.Text = "Нельзя найти аппроксимирующую функцию по одной точке"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            double n = 0, l, m;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch { }
            for (int x = 1; x < 3; x++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (dataGridView1.Rows[i].Cells[x].Value == null)
                    {
                        label3.Text = "Вы не ввели данные";
                    }
                }
            }
            if (label3.Text != "Вы не ввели данные")
            {
                Size = new Size(470, 646);
                button3.Show();
                chart1.Show();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                for (int y = 0; y < n; y++)
                {
                    l = Convert.ToDouble(dataGridView1.Rows[y].Cells[1].Value.ToString());
                    m = Convert.ToDouble(dataGridView1.Rows[y].Cells[2].Value.ToString());
                    chart1.Series[0].Points.AddXY(l, m);
                    chart1.Series[1].Points.AddXY(l, m);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.Show();
            Hide();
            double x_sum = 0, y_sum = 0, xy_sum = 0, xx_sum = 0, d_x, a = 0, b = 0, x, y;
            int n = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < n; i++)
            {
                x_sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                y_sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
                xy_sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
                xx_sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            d_x = n * xx_sum - Math.Pow(x_sum, 2);
            if (d_x != 0)
            {
                a = (n * xy_sum - x_sum * y_sum) / d_x;
                b = (y_sum * xx_sum - x_sum * xy_sum) / d_x;
                f2.label1.Text = "Аппроксимирующая функция: y = " + a + " * x + (" + b + ")";
            }
            else f2.label1.Text = "Линия вертикальна";
            f2.chart1.Series[1].Points.Clear();
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                y = a * x + b;
                f2.chart1.Series[1].Points.AddXY(x, y);
            }
            double d, k;
            for (int m = 0; m < n; m++)
            {
                d = Convert.ToDouble(dataGridView1.Rows[m].Cells[1].Value.ToString());
                k = Convert.ToDouble(dataGridView1.Rows[m].Cells[2].Value.ToString());
                f2.chart1.Series[0].Points.AddXY(d, k);
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Size = new Size(470, 420);
            dataGridView1.Show();
            button2.Show();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            StreamReader sr;
            Stream stream;
            String filename = "";
            String str;
            int nc = 0;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = " txt file(*.txt)| *.txt | All files(*.*) | *.* ";
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    filename = openFileDialog1.FileName;
                    stream.Close();
                }
                else
                {
                    MessageBox.Show("No FileName", "dataGridChart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No SaveFuleDialog", "dataGridChart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sr = new StreamReader(filename);
            int i = 0;


            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                nc = str.IndexOf(' ');
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].SetValues((i+1), str.Substring(0, nc), str.Substring(nc));
                i++;
            }
        }
    }
}