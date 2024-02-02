using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр_8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public double CalculateVowelPercentage(string word)
        {
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

            int vowelCount = word.ToLower().Count(c => vowels.Contains(c));

            double totalLetters = word.Length;
            double vowelPercentage = (vowelCount / totalLetters) * 100;

            return vowelPercentage;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string word = wordText.Text;

            if (!string.IsNullOrEmpty(word))
            {
                double vowelPercentage = CalculateVowelPercentage(word);
                MessageBox.Show($"Процент гласных букв в слове: {vowelPercentage:F2}%", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Введите слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Visible = false;
        }
    }
}
