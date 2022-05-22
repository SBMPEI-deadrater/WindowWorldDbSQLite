namespace WindowWorldDbSQLite.Views
{
    partial class CustomersWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchGrBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phoneNumberAddBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.adressAddBox = new System.Windows.Forms.TextBox();
            this.middleNameAddBox = new System.Windows.Forms.TextBox();
            this.firstnameAddBox = new System.Windows.Forms.TextBox();
            this.lastNameAddBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchGrBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найти запись:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать поле:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 27);
            this.textBox1.TabIndex = 0;
            // 
            // searchGrBox
            // 
            this.searchGrBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchGrBox.Controls.Add(this.label2);
            this.searchGrBox.Controls.Add(this.label1);
            this.searchGrBox.Controls.Add(this.comboBox1);
            this.searchGrBox.Controls.Add(this.textBox1);
            this.searchGrBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchGrBox.Location = new System.Drawing.Point(3, 589);
            this.searchGrBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGrBox.Name = "searchGrBox";
            this.searchGrBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGrBox.Size = new System.Drawing.Size(904, 112);
            this.searchGrBox.TabIndex = 1;
            this.searchGrBox.TabStop = false;
            this.searchGrBox.Text = "Поиск";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchGrBox);
            this.tabPage1.Controls.Add(this.dataGridCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(910, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameCol,
            this.firstNameCol,
            this.middleNameCol,
            this.adressCol,
            this.phoneNumberCol,
            this.deleteCol});
            this.dataGridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomers.Location = new System.Drawing.Point(3, 4);
            this.dataGridCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.RowTemplate.Height = 25;
            this.dataGridCustomers.Size = new System.Drawing.Size(904, 697);
            this.dataGridCustomers.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 738);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(910, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.phoneNumberAddBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.adressAddBox);
            this.groupBox2.Controls.Add(this.middleNameAddBox);
            this.groupBox2.Controls.Add(this.firstnameAddBox);
            this.groupBox2.Controls.Add(this.lastNameAddBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(904, 697);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // phoneNumberAddBox
            // 
            this.phoneNumberAddBox.Location = new System.Drawing.Point(197, 461);
            this.phoneNumberAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumberAddBox.Name = "phoneNumberAddBox";
            this.phoneNumberAddBox.Size = new System.Drawing.Size(477, 27);
            this.phoneNumberAddBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Номер телефона";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(197, 496);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(478, 52);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добавить запись";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // adressAddBox
            // 
            this.adressAddBox.Location = new System.Drawing.Point(197, 392);
            this.adressAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adressAddBox.Name = "adressAddBox";
            this.adressAddBox.Size = new System.Drawing.Size(477, 27);
            this.adressAddBox.TabIndex = 9;
            // 
            // middleNameAddBox
            // 
            this.middleNameAddBox.Location = new System.Drawing.Point(197, 320);
            this.middleNameAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.middleNameAddBox.Name = "middleNameAddBox";
            this.middleNameAddBox.Size = new System.Drawing.Size(477, 27);
            this.middleNameAddBox.TabIndex = 8;
            // 
            // firstnameAddBox
            // 
            this.firstnameAddBox.Location = new System.Drawing.Point(197, 249);
            this.firstnameAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstnameAddBox.Name = "firstnameAddBox";
            this.firstnameAddBox.Size = new System.Drawing.Size(477, 27);
            this.firstnameAddBox.TabIndex = 7;
            // 
            // lastNameAddBox
            // 
            this.lastNameAddBox.Location = new System.Drawing.Point(197, 175);
            this.lastNameAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameAddBox.Name = "lastNameAddBox";
            this.lastNameAddBox.Size = new System.Drawing.Size(477, 27);
            this.lastNameAddBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Адрес";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Фамилия";
            // 
            // lastNameCol
            // 
            this.lastNameCol.HeaderText = "Фамилия";
            this.lastNameCol.MinimumWidth = 6;
            this.lastNameCol.Name = "lastNameCol";
            this.lastNameCol.Width = 125;
            // 
            // firstNameCol
            // 
            this.firstNameCol.HeaderText = "Имя";
            this.firstNameCol.MinimumWidth = 6;
            this.firstNameCol.Name = "firstNameCol";
            this.firstNameCol.Width = 125;
            // 
            // middleNameCol
            // 
            this.middleNameCol.HeaderText = "Отчество";
            this.middleNameCol.MinimumWidth = 6;
            this.middleNameCol.Name = "middleNameCol";
            this.middleNameCol.Width = 125;
            // 
            // adressCol
            // 
            this.adressCol.HeaderText = "Адрес";
            this.adressCol.MinimumWidth = 6;
            this.adressCol.Name = "adressCol";
            this.adressCol.Width = 125;
            // 
            // phoneNumberCol
            // 
            this.phoneNumberCol.HeaderText = "Номер телефона";
            this.phoneNumberCol.MinimumWidth = 6;
            this.phoneNumberCol.Name = "phoneNumberCol";
            this.phoneNumberCol.Width = 200;
            // 
            // deleteCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.deleteCol.HeaderText = "Удалить";
            this.deleteCol.MinimumWidth = 6;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Width = 125;
            // 
            // CustomersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 738);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказчики";
            this.Load += new System.EventHandler(this.CustomersWindow_Load);
            this.searchGrBox.ResumeLayout(false);
            this.searchGrBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private GroupBox searchGrBox;
        private ComboBox comboBox1;
        private TabPage tabPage1;
        private DataGridView dataGridCustomers;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button addBtn;
        private TextBox adressAddBox;
        private TextBox middleNameAddBox;
        private TextBox firstnameAddBox;
        private TextBox lastNameAddBox;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label9;
        private TextBox phoneNumberAddBox;
        private Label label3;
        private DataGridViewTextBoxColumn lastNameCol;
        private DataGridViewTextBoxColumn firstNameCol;
        private DataGridViewTextBoxColumn middleNameCol;
        private DataGridViewTextBoxColumn adressCol;
        private DataGridViewTextBoxColumn phoneNumberCol;
        private DataGridViewButtonColumn deleteCol;
    }
}