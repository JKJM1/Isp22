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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool AreFirstAndLastLettersEqual(string firstWord, string secondWord)
        {
            if (!string.IsNullOrEmpty(firstWord) && !string.IsNullOrEmpty(secondWord))
            {
                char firstLetter = firstWord[0];
                char lastLetter = secondWord[secondWord.Length - 1]; 

                return char.ToLower(firstLetter) == char.ToLower(lastLetter);
            }

            return false;
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            string word1 = wordT1.Text;
            string word2 = wordT2.Text;

            bool result = AreFirstAndLastLettersEqual(word1, word2);

            if (result)
            {
                MessageBox.Show($"Первое слово ({word1}) начинается на ту же букву, которой оканчивается второе слово ({word2}).", "Результат сравнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Первое слово ({word1}) НЕ начинается на ту же букву, которой оканчивается второе слово ({word2}).", "Результат сравнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form3 form3 = new Form3();
                form3.Show();
                this.Visible = false;
        }
    }
}
