namespace Пр_7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Weight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Fuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Firm = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.B_SaveChanges = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TB_Weight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_Fuel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Firm);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.B_SaveChanges);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 470);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о машине";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Вес";
            // 
            // TB_Weight
            // 
            this.TB_Weight.Location = new System.Drawing.Point(6, 317);
            this.TB_Weight.Name = "TB_Weight";
            this.TB_Weight.Size = new System.Drawing.Size(313, 38);
            this.TB_Weight.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Расход топлива на 100км";
            // 
            // TB_Fuel
            // 
            this.TB_Fuel.Location = new System.Drawing.Point(5, 231);
            this.TB_Fuel.Name = "TB_Fuel";
            this.TB_Fuel.Size = new System.Drawing.Size(313, 38);
            this.TB_Fuel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фирма";
            // 
            // TB_Firm
            // 
            this.TB_Firm.Location = new System.Drawing.Point(6, 155);
            this.TB_Firm.Name = "TB_Firm";
            this.TB_Firm.Size = new System.Drawing.Size(313, 38);
            this.TB_Firm.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 32);
            this.label22.TabIndex = 10;
            this.label22.Text = "Марка";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(5, 79);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(313, 38);
            this.TB_Name.TabIndex = 7;
            // 
            // B_SaveChanges
            // 
            this.B_SaveChanges.Location = new System.Drawing.Point(39, 396);
            this.B_SaveChanges.Name = "B_SaveChanges";
            this.B_SaveChanges.Size = new System.Drawing.Size(313, 50);
            this.B_SaveChanges.TabIndex = 8;
            this.B_SaveChanges.Text = "Сохранить изменения";
            this.B_SaveChanges.UseVisualStyleBackColor = true;
            this.B_SaveChanges.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 519);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Fuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Firm;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button B_SaveChanges;
    }
}