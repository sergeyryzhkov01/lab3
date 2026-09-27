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
    public partial class FormTask6 : Form
    {
        public FormTask6()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtStep.Text, out double h))
            {
                MessageBox.Show("Ошибка! Введите корректное числовое значение для шага h.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (h <= 0)
            {
                MessageBox.Show("Шаг табуляции h должен быть строго больше нуля!",
                                "Ошибка диапазона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (h > 6.0)
            {
                MessageBox.Show("Шаг h не может превышать длину отрезка (6.0)!",
                                "Ошибка диапазона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstTable.Items.Clear();
            lstTable.Items.Add(string.Format("{0,8} | {1,12}", "x", "y = f(x)"));
            lstTable.Items.Add(new string('-', 25));

            double sum = 0.0;
            int count = 0;

            for (double x = -3.0; x <= 3.0 + h / 2.0; x += h)
            {
                double num = 2.0 * (x * x + 3.0);
                double den = x * x - 2.0 * x + 5.0;
                double y = (num / den) - 1.5;

                sum += y;
                count++;

                lstTable.Items.Add(string.Format("{0,8:F2} | {1,12:F4}", x, y));
            }

            lblResult.Text = $"Сумма значений y: S = {sum:F4}\n" +
                             $"Вычислено точек: {count}";
        }
    }
}
