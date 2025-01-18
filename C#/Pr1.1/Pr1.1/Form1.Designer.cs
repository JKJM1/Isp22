namespace Pr1._1
{
    partial class ОС
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridViewSystemInfo = new System.Windows.Forms.DataGridView();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Свойство = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(623, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewSystemInfo
            // 
            this.dataGridViewSystemInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSystemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSystemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Значение,
            this.Свойство});
            this.dataGridViewSystemInfo.Location = new System.Drawing.Point(48, 12);
            this.dataGridViewSystemInfo.Name = "dataGridViewSystemInfo";
            this.dataGridViewSystemInfo.ReadOnly = true;
            this.dataGridViewSystemInfo.RowHeadersVisible = false;
            this.dataGridViewSystemInfo.RowHeadersWidth = 51;
            this.dataGridViewSystemInfo.RowTemplate.Height = 24;
            this.dataGridViewSystemInfo.Size = new System.Drawing.Size(651, 355);
            this.dataGridViewSystemInfo.TabIndex = 1;
            // 
            // Значение
            // 
            this.Значение.HeaderText = "Значение";
            this.Значение.MinimumWidth = 6;
            this.Значение.Name = "Значение";
            this.Значение.ReadOnly = true;
            // 
            // Свойство
            // 
            this.Свойство.HeaderText = "Свойство";
            this.Свойство.MinimumWidth = 6;
            this.Свойство.Name = "Свойство";
            this.Свойство.ReadOnly = true;
            // 
            // ОС
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSystemInfo);
            this.Controls.Add(this.btnExit);
            this.Name = "ОС";
            this.Text = "ОС";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSystemInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridViewSystemInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;
        private System.Windows.Forms.DataGridViewTextBoxColumn Свойство;
    }
}

