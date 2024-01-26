using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Пр_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            string surname12 = surname1.Text;
            string surname22 = surname2.Text;

            int length1 = surname12.Length;
            int length2 = surname22.Length;

            string result;

            if (length1 > length2)
            {
                result = $"{surname12} длиннее, чем {surname22}.";
            }
            else if (length1 < length2)
            {
                result = $"{surname22} длиннее, чем {surname12}.";
            }
            else
            {
                result = "Фамилии имеют одинаковую длину.";
            }

            MessageBox.Show(result, "Результат сравнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
    }
}
