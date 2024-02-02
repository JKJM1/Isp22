namespace Пр_7
{
    partial class Form1
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
            this.B_Sort = new System.Windows.Forms.Button();
            this.B_Load = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.DGV_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Changes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Sort
            // 
            this.B_Sort.Location = new System.Drawing.Point(701, 155);
            this.B_Sort.Name = "B_Sort";
            this.B_Sort.Size = new System.Drawing.Size(204, 50);
            this.B_Sort.TabIndex = 18;
            this.B_Sort.Text = "Сортировать";
            this.B_Sort.UseVisualStyleBackColor = true;
            this.B_Sort.Click += new System.EventHandler(this.B_Sort_Click);
            // 
            // B_Load
            // 
            this.B_Load.Location = new System.Drawing.Point(490, 398);
            this.B_Load.Name = "B_Load";
            this.B_Load.Size = new System.Drawing.Size(204, 50);
            this.B_Load.TabIndex = 16;
            this.B_Load.Text = "Загрузить";
            this.B_Load.UseVisualStyleBackColor = true;
            this.B_Load.Click += new System.EventHandler(this.B_Load_Click);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(8, 398);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(204, 50);
            this.B_Save.TabIndex = 15;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(700, 98);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(204, 50);
            this.B_Delete.TabIndex = 14;
            this.B_Delete.Text = "Удалить";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // DGV_List
            // 
            this.DGV_List.AllowUserToAddRows = false;
            this.DGV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGV_List.Location = new System.Drawing.Point(12, 42);
            this.DGV_List.Name = "DGV_List";
            this.DGV_List.RowHeadersVisible = false;
            this.DGV_List.RowHeadersWidth = 51;
            this.DGV_List.RowTemplate.Height = 24;
            this.DGV_List.Size = new System.Drawing.Size(682, 350);
            this.DGV_List.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Марка";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фирма";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Расход топлива";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Вес";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Список машин";
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(700, 42);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(204, 50);
            this.B_Add.TabIndex = 11;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Changes
            // 
            this.B_Changes.Location = new System.Drawing.Point(700, 211);
            this.B_Changes.Name = "B_Changes";
            this.B_Changes.Size = new System.Drawing.Size(204, 50);
            this.B_Changes.TabIndex = 19;
            this.B_Changes.Text = "Редактировать";
            this.B_Changes.UseVisualStyleBackColor = true;
            this.B_Changes.Click += new System.EventHandler(this.B_Changes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 468);
            this.Controls.Add(this.B_Changes);
            this.Controls.Add(this.B_Sort);
            this.Controls.Add(this.B_Load);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.DGV_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Sort;
        private System.Windows.Forms.Button B_Load;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.DataGridView DGV_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button B_Changes;
    }
}

