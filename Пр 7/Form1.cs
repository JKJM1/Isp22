using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр_7
{
    public partial class Form1 : Form
    {
        struct Cars
        {
            public string Name; 
            public string Firm;
            public double Fuel;
            public int Weight;
            
        }

        List<Cars> list_cars = new List<Cars>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            Form2 Dialog = new Form2();
            Dialog.Text = "Добавление машины";
            Dialog.TB_Name.Text = "";
            Dialog.TB_Firm.Text = "";
            Dialog.TB_Fuel.Text = "";
            Dialog.TB_Weight.Text = "";

            if(Dialog.ShowDialog() == DialogResult.OK)
            {
                Cars s = new Cars();
                s.Name = Dialog.TB_Name.Text;
                s.Firm = Dialog.TB_Firm.Text;
                s.Fuel = Convert.ToDouble(Dialog.TB_Fuel.Text);
                s.Weight = Convert.ToInt32(Dialog.TB_Weight.Text);
                list_cars.Add(s);

                DGV_List.RowCount = list_cars.Count;
                for (int i = 0; i < list_cars.Count; i++)
                {
                    DGV_List[0, i].Value = list_cars[i].Name;
                    DGV_List[1, i].Value = list_cars[i].Firm;
                    DGV_List[2, i].Value = list_cars[i].Fuel.ToString();
                    DGV_List[3, i].Value = list_cars[i].Weight.ToString();
                }
            }    
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_List.CurrentRow != null)
            {
                list_cars.RemoveAt(DGV_List.CurrentRow.Index);

                DGV_List.RowCount = list_cars.Count;
                for (int i = 0; i < list_cars.Count; i++)
                {
                    DGV_List[0, i].Value = list_cars[i].Name;
                    DGV_List[1, i].Value = list_cars[i].Firm;
                    DGV_List[2, i].Value = list_cars[i].Fuel.ToString();
                    DGV_List[3, i].Value = list_cars[i].Weight.ToString();
                }
            }
            else
                MessageBox.Show("Вы не выделили строку");
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("1.txt");
            for (int i = 0; i < list_cars.Count; i++)
            {
                sw.WriteLine(DGV_List[0, i].Value.ToString());
                sw.WriteLine(DGV_List[1, i].Value.ToString());
                sw.WriteLine(DGV_List[2, i].Value.ToString());
                sw.WriteLine(DGV_List[3, i].Value.ToString());
            }
            sw.Close();
        }

        private void B_Changes_Click(object sender, EventArgs e)
        {
            if (DGV_List.CurrentRow != null)
            {
                Form2 Dialog = new Form2();
                Dialog.Text = "Изменение данных машины";

                int n = DGV_List.CurrentRow.Index;
                Dialog.TB_Name.Text = DGV_List[0, n].Value.ToString();
                Dialog.TB_Firm.Text = DGV_List[1, n].Value.ToString();
                Dialog.TB_Fuel.Text = DGV_List[2, n].Value.ToString();
                Dialog.TB_Weight.Text = DGV_List[3, n].Value.ToString();

                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    Cars s = new Cars();
                    s.Name = Dialog.TB_Name.Text;
                    s.Firm = Dialog.TB_Firm.Text;
                    s.Fuel = Convert.ToDouble(Dialog.TB_Fuel.Text);
                    s.Weight = Convert.ToInt32(Dialog.TB_Weight.Text);
                    list_cars[DGV_List.CurrentRow.Index] = s;

                    DGV_List.RowCount = list_cars.Count;
                    for (int i = 0; i < list_cars.Count; i++)
                    {
                        DGV_List[0, i].Value = list_cars[i].Name;
                        DGV_List[1, i].Value = list_cars[i].Firm;
                        DGV_List[2, i].Value = list_cars[i].Fuel.ToString();
                        DGV_List[3, i].Value = list_cars[i].Weight.ToString();
                    }
                }
            }
            else
                MessageBox.Show("Вы не выделили строку");
        }

        private void B_Load_Click(object sender, EventArgs e)
        {
            list_cars.Clear();
            StreamReader sr = new StreamReader("1.txt");
            while (sr.EndOfStream == false)
            {
                Cars s = new Cars();
                s.Name = sr.ReadLine();
                s.Firm = sr.ReadLine();
                s.Fuel = Convert.ToDouble(sr.ReadLine());
                s.Weight = Convert.ToInt32(sr.ReadLine());
                list_cars.Add(s);
            }

            DGV_List.RowCount = list_cars.Count;
            for (int i = 0; i < list_cars.Count; i++)
            {
                DGV_List[0, i].Value = list_cars[i].Name;
                DGV_List[1, i].Value = list_cars[i].Firm;
                DGV_List[2, i].Value = list_cars[i].Fuel;
                DGV_List[3, i].Value = list_cars[i].Weight;
            }
            sr.Close();
        }

        private void B_Sort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_cars.Count; i++)
            {
                for (int j = 0; j < list_cars.Count - i - 1; j++)
                {
                    if (list_cars[j].Weight < list_cars[j + 1].Weight)
                    {
                        Cars s = list_cars[j];
                        list_cars[j] = list_cars[j + 1];
                        list_cars[j + 1] = s;
                    }
                }
            }
            DGV_List.RowCount = list_cars.Count;
            for (int i = 0; i < list_cars.Count; i++)
            {
                DGV_List[0, i].Value = list_cars[i].Name;
                DGV_List[1, i].Value = list_cars[i].Firm;
                DGV_List[2, i].Value = list_cars[i].Fuel.ToString();
                DGV_List[3, i].Value = list_cars[i].Weight.ToString();
            }
        }
    }
}
