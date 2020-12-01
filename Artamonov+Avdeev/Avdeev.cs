using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artamonov_Avdeev
{
    public partial class Avdeev : Form
    {
        public Avdeev()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form back1 = new Avdeevmenu();
            back1.Show();
            this.Hide();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avdeev_Load(object sender, EventArgs e)
        {

        }

        private void ОРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form developer = new Dev();
            developer.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Проверка, что не пустые компоненты textBox1 и textBox2
            if ((textBox3.Text != "") && (textBox4.Text != ""))
            {
                int m = Convert.ToInt32(textBox3.Text);
                int n = Convert.ToInt32(textBox4.Text);
                //Чистка столбцов компонента DataGridView, если они не пусты
                dataGridView1.Columns.Clear();
                //Заполнение компонента DataGridView столбцами
                dataGridView1.ColumnCount = n;
                //Заполнение компонента DataGridView строками
                dataGridView1.RowCount = m;
            }
            else
            {
                MessageBox.Show("Заполните, пожалуйста, данные", "Ошибка ввода данных",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Вычислить среднеарифметическое значение положительных элементов всего массива+++
            //Определить наибольший элемент среди каждых третьих элементов второго столбца массива.
            int ans1 = 0;
            float ans2 = 0;
            int p = 1;
            int count = 0;
            int buffer = 2;
            float buffer2 = 0;
            float buffer3 = 0;
            int m = Convert.ToInt32(textBox3.Text);
            int n = Convert.ToInt32(textBox4.Text);
            int[] third = new int[100];
            float[,] arr = new float[m, n];
            for(int i =0; i<99; i++)
            {
                third[i] = buffer;
                buffer += 3;
            }
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    
                    float[,] A = new float[i, j];
                    arr[i, j] = Convert.ToSingle(this.dataGridView1.Rows[i].Cells[j].Value);
                    if (arr[i, j] > 0)
                    {
                        count++;
                        buffer2 += arr[i, j];
                    }
                }
            
            if (n > 2)
            {

                for (int i = 2; i < m; i += 3)
                    
                {
                    buffer3 = arr[i, 2];
                    if (arr[i, 2] > buffer3)
                    {
                       buffer3 += arr[i,2];
                    }
                }
            }
            else
            {
                this.textBox2.Text = "Отсутствует второй столбец";
            }
            ans2 = buffer2/count;
            ans1 = Convert.ToInt32(buffer3);
            if ((checkBox1.Checked == true) && (ans2 != 0)) { this.textBox1.Text = Convert.ToString(ans2); }
            else
            {
                if (checkBox1.Checked == true) { this.textBox1.Text = Convert.ToString("нет положительных элементов"); }

            }
            if ((checkBox2.Checked == true) && (ans1 != 0)) { this.textBox2.Text = Convert.ToString(ans1); }
            else
            {
                if (checkBox2.Checked == true) { this.textBox2.Text = Convert.ToString("Ошибка"); }
                return;
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
