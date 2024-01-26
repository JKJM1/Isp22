using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр_7
{
    public partial class Form2 : Form
    {
        struct Cars
        {
            public string Name;
            public string Firm;
            public double Fuel;
            public int Weight;

        }

        List<Cars> list_cars = new List<Cars>();
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (TB_Name.Text.Trim() == "")
                    {
                        TB_Name.Focus();
                        throw new Exception("Вы не ввели название марки");
                    }

                    if (TB_Firm.Text.Trim() == "")
                    {
                        TB_Firm.Focus();
                        throw new Exception("Вы не ввели название фирмы");
                    }

                    double n1;
                    try
                    {
                        n1 = Convert.ToDouble(TB_Fuel.Text);
                    }
                    catch (FormatException)
                    {
                        TB_Fuel.Focus();
                        throw new Exception("Расход топлива должен быть вещественным числом");
                    }

                    if (n1 < 2.0|| n1 > 80.0)
                    {
                        TB_Fuel.Focus();
                        throw new Exception("Расход топлива должен быть в диапазоне от 2.0 до 80.0");
                    }

                    int n2;
                    try
                    {
                        n2 = Convert.ToInt32(TB_Weight.Text);
                    }
                    catch (FormatException)
                    {
                        TB_Weight.Focus();
                        throw new Exception("Вес должен быть целым числом");
                    }

                    if (n2 < 100 || n2 > 500000)
                    {
                        TB_Weight.Focus();
                        throw new Exception("Вес должнен быть в диапазоне от 100 до 500000");
                    }

                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");

                }
            }
        }
    }
}
