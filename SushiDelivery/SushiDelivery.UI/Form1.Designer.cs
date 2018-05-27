namespace SushiDelivery.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Sushi = new System.Windows.Forms.ComboBox();
            this.drink = new System.Windows.Forms.ComboBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.NumberSushi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.Priсe = new System.Windows.Forms.NumericUpDown();
            this.NumerDrink = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addition = new System.Windows.Forms.ComboBox();
            this.NumberAddition = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberSushi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priсe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказчик";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Суши";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Напиток";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дополнение";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "RUB";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Адрес";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(1009, 449);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(127, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click_1);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(872, 449);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Столовые приборы";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Sushi
            // 
            this.Sushi.FormattingEnabled = true;
            this.Sushi.Location = new System.Drawing.Point(117, 12);
            this.Sushi.Name = "Sushi";
            this.Sushi.Size = new System.Drawing.Size(168, 24);
            this.Sushi.TabIndex = 2;
            this.Sushi.SelectedIndexChanged += new System.EventHandler(this.Sushi_SelectedIndexChanged);
            // 
            // drink
            // 
            this.drink.FormattingEnabled = true;
            this.drink.Location = new System.Drawing.Point(117, 96);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(168, 24);
            this.drink.TabIndex = 2;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(155, 232);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(225, 22);
            this.FullName.TabIndex = 3;
            this.FullName.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(155, 272);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(225, 22);
            this.address.TabIndex = 3;
            // 
            // NumberSushi
            // 
            this.NumberSushi.Location = new System.Drawing.Point(294, 12);
            this.NumberSushi.Name = "NumberSushi";
            this.NumberSushi.Size = new System.Drawing.Size(67, 22);
            this.NumberSushi.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(163, 310);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(122, 22);
            this.numericUpDown3.TabIndex = 4;
            // 
            // Priсe
            // 
            this.Priсe.Location = new System.Drawing.Point(77, 385);
            this.Priсe.Name = "Priсe";
            this.Priсe.Size = new System.Drawing.Size(134, 22);
            this.Priсe.TabIndex = 4;
            // 
            // NumerDrink
            // 
            this.NumerDrink.Location = new System.Drawing.Point(294, 96);
            this.NumerDrink.Name = "NumerDrink";
            this.NumerDrink.Size = new System.Drawing.Size(67, 22);
            this.NumerDrink.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 350);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // addition
            // 
            this.addition.FormattingEnabled = true;
            this.addition.Location = new System.Drawing.Point(117, 56);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(168, 24);
            this.addition.TabIndex = 2;
            // 
            // NumberAddition
            // 
            this.NumberAddition.Location = new System.Drawing.Point(294, 56);
            this.NumberAddition.Name = "NumberAddition";
            this.NumberAddition.Size = new System.Drawing.Size(67, 22);
            this.NumberAddition.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(386, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 414);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Суши";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Напиток";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Кол-во";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дополнение";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Кол-во";
            this.Column6.Name = "Column6";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(24, 137);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(337, 22);
            this.button.TabIndex = 7;
            this.button.Text = "+";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NumberAddition);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Priсe);
            this.Controls.Add(this.NumerDrink);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.NumberSushi);
            this.Controls.Add(this.address);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.Sushi);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberSushi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priсe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumerDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Sushi;
        private System.Windows.Forms.ComboBox drink;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.NumericUpDown NumberSushi;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown Priсe;
        private System.Windows.Forms.NumericUpDown NumerDrink;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox addition;
        private System.Windows.Forms.NumericUpDown NumberAddition;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
    }
}

