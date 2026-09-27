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
    public partial class FormTask7 : Form
    {
        public FormTask7()
        {
            InitializeComponent();
        }

        private void FormTask7_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Поле ввода числа не может быть пустым!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = txtN.Text.Trim();

            if (!long.TryParse(input, out long n))
            {
                MessageBox.Show("Ошибка! Введите корректное целое число без букв, точек и запятых.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n == long.MinValue)
            {
                MessageBox.Show("Число выходит за допустимые границы типа данных!",
                                "Ошибка диапазона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isNegative = n < 0;
            long temp = Math.Abs(n);

            long resultNumber = 0;
            long multiplier = 1;
            int removedCount = 0;
            int keptCount = 0;

            if (temp == 0)
            {
                removedCount = 1;
            }

            while (temp > 0)
            {
                long digit = temp % 10;

                if (digit == 0 || digit == 5)
                {
                    removedCount++;
                }
                else
                {
                    resultNumber += digit * multiplier;
                    multiplier *= 10;
                    keptCount++;
                }

                temp /= 10;
            }

            if (isNegative)
            {
                resultNumber = -resultNumber;
            }

            if (keptCount == 0)
            {
                lblRes.Text = $"Исходное число: {n}\n" +
                              $"Результат: Все цифры удалены (число состояло только из 0 и 5)\n" +
                              $"Удалено цифр: {removedCount}";
            }
            else
            {
                lblRes.Text = $"Исходное число: {n}\n" +
                              $"Преобразованное число: {resultNumber}\n" +
                              $"Удалено цифр (0 и 5): {removedCount}";
            }
        }
    }
}
