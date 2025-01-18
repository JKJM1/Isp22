using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1._1
{
    public partial class ОС : Form
    {
        public ОС()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSystemInfo();
        }
        private void LoadSystemInfo()
        {
            dataGridViewSystemInfo.Rows.Clear();
            dataGridViewSystemInfo.Rows.Add("Версия Windows", Environment.OSVersion);
            dataGridViewSystemInfo.Rows.Add("64-битная ОС", Environment.Is64BitOperatingSystem);
            dataGridViewSystemInfo.Rows.Add("Имя компьютера", Environment.MachineName);
            dataGridViewSystemInfo.Rows.Add("Число процессоров", Environment.ProcessorCount);
            dataGridViewSystemInfo.Rows.Add("Системная папка", Environment.SystemDirectory);
            dataGridViewSystemInfo.Rows.Add("Логические диски", string.Join(", ", Environment.GetLogicalDrives()));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Вы уверены что хотите выйти?",
                                 "Подтверждение",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (rez == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
