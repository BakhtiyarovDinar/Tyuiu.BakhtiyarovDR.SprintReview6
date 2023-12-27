using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BakhtiyarovDR.Sprint6.TaskReview.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint6.TaskReview.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        DataService ds = new DataService();

        int[,] mrtx;
        private void buttonDone_BDR_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_N_BDR.Text) > 1 && Convert.ToInt32(textBox_M_BDR.Text) > 1)
            {
                int N = Convert.ToInt32(textBox_N_BDR.Text);
                int M = Convert.ToInt32(textBox_M_BDR.Text);
                int K = Convert.ToInt32(textBox_k_BDR.Text);
                int L = Convert.ToInt32(textBox_l_BDR.Text);
                int C = Convert.ToInt32(textBox_c_BDR.Text);
                int n1 = Convert.ToInt32(textBox_n1_BDR.Text);
                int n2 = Convert.ToInt32(textBox_n2_BDR.Text);
                int x = Convert.ToInt32(textBox_x_BDR.Text);

                


                // Подсчет нечетных элементов в заданном столбце C с номерами от K до L
                int oddCount = 0;
                for (int i = K; i <= L; i++)
                {
                    if (mrtx[i, C] % 2 != 0)
                    {
                        oddCount++;
                    }
                }

                // Вывод результата в текстовое поле
                textBoxResult_BDR.Text = oddCount.ToString();


            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_l_BDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТаскРевью 6 выполнил студент группы АСОиУб-23-3 Бахтияров Динар Русланович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonMatrix_BDR_Click(object sender, EventArgs e)
        {

            int N = Convert.ToInt32(textBox_N_BDR.Text);
            int M = Convert.ToInt32(textBox_M_BDR.Text);
            int n1 = Convert.ToInt32(textBox_n1_BDR.Text);
            int n2 = Convert.ToInt32(textBox_n2_BDR.Text);
            int x = Convert.ToInt32(textBox_x_BDR.Text);

            mrtx = new int[N, M];

            Random rnd = new Random();

            // Заполнение массива с чередованием числа X
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (j % 2 == 0)
                    {
                        mrtx[i, j] = x;
                    }
                    else
                    {
                        mrtx[i, j] = rnd.Next(n1, n2);
                    }
                }
            }


            // Отображение массива в DataGridView
            dataGridViewMatrix_BDR.RowCount = N;
            dataGridViewMatrix_BDR.ColumnCount = M;
            for (int i = 0; i < N; i++)
            {
                dataGridViewMatrix_BDR.Columns[i].Width = 25;
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < M; c++)
                {
                    dataGridViewMatrix_BDR.Rows[r].Cells[c].Value = mrtx[r, c];
                }
            }
        }

        private void textBoxTask_BDR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
