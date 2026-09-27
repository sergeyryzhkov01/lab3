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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTask5 formTask5 = new FormTask5();
            formTask5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTask6 formTask6 = new FormTask6();
            formTask6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTask7 formTask7 = new FormTask7();
            formTask7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTask8 formTask8 = new FormTask8();
            formTask8.Show();
        }
    }
}
