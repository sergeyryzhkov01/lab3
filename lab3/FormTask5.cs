using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormTask5 : Form
    {
        public FormTask5()
        {
            InitializeComponent();
            txtEps.Text = "0,0001";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtEps.Text, out double eps))
            {
                MessageBox.Show("Ошибка! Введите корректное числовое значение для eps.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (eps <= 0)
            {
                MessageBox.Show("Точность eps должна быть строго больше нуля (eps > 0)!",
                                "Ошибка диапазона", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double sum = 0.0;
            double a = 1.0;
            int n = 1;

            lstTerms.Items.Clear();

            while (a >= eps)
            {
                sum += a;
                lstTerms.Items.Add($"n = {n}: a_{n} = {a:F6}");
                n++;
                a = a / Math.Sqrt(n);
            }

            int termsCount = n - 1;

            lblResult.Text = $"Сумма ряда S = {sum:F6}\n" +
                             $"Количество слагаемых: {termsCount}\n" +
                             $"Первый отброшенный член: a_{n} = {a:F8}";
        }
    }
}
