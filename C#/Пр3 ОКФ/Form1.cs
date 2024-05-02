using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр3_ОКФ
{
    public partial class Form1 : Form
    {
        private int currentX;
        private int currentY;
        private int currentH;
        private bool addEnabled = true;
        private bool editEnabled = true;
        private bool deleteEnabled = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bp;
            Graphics gr= Graphics.FromImage(bp);
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            gr.FillRectangle(solidBrush,0,0,pictureBox1.Width,pictureBox1.Height);
            pictureBox1.Refresh();
        }
        public void DrawFigures()
        {
            Graphics gr = Graphics.FromImage(pictureBox1.Image);
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            gr.FillRectangle(solidBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Refresh();
            foreach (Figura figura in listBox1.Items)
            {
                figura.Draw();
            }
            pictureBox1.Refresh();
        }  
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            try
            {
                if (addEnabled)
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        int x = Convert.ToInt32(f.textBox1.Text);
                        int y = Convert.ToInt32(f.textBox2.Text);
                        int h = Convert.ToInt32(f.textBox3.Text);
                        Figura fg = new Figura(x, y, h, pictureBox1);
                        listBox1.Items.Add(fg);
                        DrawFigures();
                    }
                    else
                    {
                        throw new Exception("Добавление объекта заблокировано.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteEnabled)
                {
                    if (listBox1.SelectedItem != null)
                    {
                        Figura selectedFigura = listBox1.SelectedItem as Figura;
                        selectedFigura.Delete();
                        listBox1.Items.Remove(selectedFigura);
                        DrawFigures();
                    }
                    else
                    {
                        throw new Exception("Не выбран объект для удаления.");
                    }
                }
                else
                {
                    throw new Exception("Удаление объекта заблокировано.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (editEnabled)
                {
                    if (listBox1.SelectedItem != null)
                    {
                        Form2 f = new Form2();
                        Figura selectedFigura = listBox1.SelectedItem as Figura;
                        currentX = selectedFigura.X;
                        currentY = selectedFigura.Y;
                        currentH = selectedFigura.H;

                        f.textBox1.Text = currentX.ToString();
                        f.textBox2.Text = currentY.ToString();
                        f.textBox3.Text = currentH.ToString();

                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            int x = Convert.ToInt32(f.textBox1.Text);
                            int y = Convert.ToInt32(f.textBox2.Text);
                            int h = Convert.ToInt32(f.textBox3.Text);

                            if (x == currentX && y == currentY && h == currentH)
                            {
                                selectedFigura.Edit(currentX, currentY, currentH);
                            }
                            else
                            {
                                selectedFigura.Edit(x, y, h);
                            }
                            DrawFigures();
                        }
                    }
                    else
                    {
                        throw new Exception("Не выбран объект для редактирования.");
                    }
                }
                else
                {
                    throw new Exception("Редактирование объекта заблокировано.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }   
}
