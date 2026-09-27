using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormTask8 : Form
    {
        public FormTask8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Поле ввода числа N не может быть пустым!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtN.Text.Trim(), out int n))
            {
                MessageBox.Show("Ошибка! Введите корректное целое число.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n <= 0)
            {
                MessageBox.Show("Число N должно быть строго больше нуля (N > 0)!",
                                "Ошибка диапазона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (n > 20)
            {
                MessageBox.Show("При N > 20 происходит арифметическое переполнение 64-битного типа long!\n" +
                                "Введите число N в диапазоне от 1 до 20.",
                                "Защита от переполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstSteps.BeginUpdate();
            lstSteps.Items.Clear();

            long sum = 0;
            long currentFact = 1;

            for (int i = 1; i <= n; i++)
            {
                currentFact *= i;
                sum += currentFact;

                lstSteps.Items.Add(string.Format("{0,2}! = {1,19}  |  Текущая сумма = {2}", i, currentFact, sum));
            }

            lstSteps.EndUpdate();

            lblRes.Text = $"Итоговая сумма 1! + ... + {n}! = {sum}\n" +
                          $"Вычислено слагаемых: {n}";
        }
    }
 }
