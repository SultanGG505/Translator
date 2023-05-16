namespace TransForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.TokenText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecialText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConstText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumbersText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DivisorsText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OpersText = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.VarsText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputText.Location = new System.Drawing.Point(28, 107);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(136, 554);
            this.InputText.TabIndex = 1;
            // 
            // TokenText
            // 
            this.TokenText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TokenText.Location = new System.Drawing.Point(189, 107);
            this.TokenText.Multiline = true;
            this.TokenText.Name = "TokenText";
            this.TokenText.Size = new System.Drawing.Size(169, 554);
            this.TokenText.TabIndex = 2;
            this.TokenText.TextChanged += new System.EventHandler(this.TokenText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Token";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Special";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SpecialText
            // 
            this.SpecialText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SpecialText.Location = new System.Drawing.Point(378, 107);
            this.SpecialText.Multiline = true;
            this.SpecialText.Name = "SpecialText";
            this.SpecialText.Size = new System.Drawing.Size(159, 554);
            this.SpecialText.TabIndex = 5;
            this.SpecialText.TextChanged += new System.EventHandler(this.SpecialText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Const";
            // 
            // ConstText
            // 
            this.ConstText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ConstText.Location = new System.Drawing.Point(554, 107);
            this.ConstText.Multiline = true;
            this.ConstText.Name = "ConstText";
            this.ConstText.Size = new System.Drawing.Size(100, 554);
            this.ConstText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numbers";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NumbersText
            // 
            this.NumbersText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NumbersText.Location = new System.Drawing.Point(787, 107);
            this.NumbersText.Multiline = true;
            this.NumbersText.Name = "NumbersText";
            this.NumbersText.Size = new System.Drawing.Size(100, 554);
            this.NumbersText.TabIndex = 9;
            this.NumbersText.TextChanged += new System.EventHandler(this.NumbersText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Divisors";
            // 
            // DivisorsText
            // 
            this.DivisorsText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DivisorsText.Location = new System.Drawing.Point(910, 107);
            this.DivisorsText.Multiline = true;
            this.DivisorsText.Name = "DivisorsText";
            this.DivisorsText.Size = new System.Drawing.Size(217, 554);
            this.DivisorsText.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1155, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Opers";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // OpersText
            // 
            this.OpersText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OpersText.Location = new System.Drawing.Point(1133, 107);
            this.OpersText.Multiline = true;
            this.OpersText.Name = "OpersText";
            this.OpersText.Size = new System.Drawing.Size(182, 554);
            this.OpersText.TabIndex = 13;
            this.OpersText.TextChanged += new System.EventHandler(this.OpersText_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(691, 76);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 17);
            this.label.TabIndex = 16;
            this.label.Text = "Variable";
            // 
            // VarsText
            // 
            this.VarsText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VarsText.Location = new System.Drawing.Point(672, 107);
            this.VarsText.Multiline = true;
            this.VarsText.Name = "VarsText";
            this.VarsText.Size = new System.Drawing.Size(100, 554);
            this.VarsText.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1360, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "ОПЗ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1360, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Перевод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1321, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 80);
            this.button4.TabIndex = 19;
            this.button4.Text = "Синтаксический анализатор";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1462, 673);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.VarsText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OpersText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DivisorsText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumbersText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConstText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecialText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TokenText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox TokenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SpecialText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConstText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumbersText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DivisorsText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OpersText;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox VarsText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

