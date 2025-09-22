using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace brunovLab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random ran = new Random();
        int n = 4;
        int m = 4;
        int[,] arr = new int[4, 4];

        private void Form2_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowCount = n;
            this.dataGridView1.ColumnCount = m;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Создаем матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = ran.Next(-20, 20);
                    this.dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
            //поиск суммы элементов в тех столбцах, которые не содержат отрицательных элементов
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                bool hasNegative = false;
                int columnSum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                    columnSum += arr[i, j];
                }
                if (!hasNegative)
                {
                    sum += columnSum;
                }
            }
            if (sum == 0) label4.Text = "Таких нет";
            else label4.Text = sum.ToString();
            //поиск минимума среди сумм модулей элементов диагоналей, параллельных главной диагонали матрицы            
            int minSum = int.MaxValue;
            for (int k = -arr.GetLength(0) + 2; k < arr.GetLength(1) - 1; k++)
            {
                int sumMod = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    int j = i - k;
                    if (j >= 0 && j < arr.GetLength(1) && !(i == 0 && j == arr.GetLength(1) - 1)
                        && !(i == arr.GetLength(0) - 1 && j == 0))
                    {
                        sumMod += Math.Abs(arr[i, j]);
                    }
                }
                minSum = Math.Min(minSum, sumMod);
            } 
            
        label6.Text = minSum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Hide();
        }
    }
}
