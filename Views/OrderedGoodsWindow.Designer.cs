namespace WindowWorldDbSQLite.Views
{
    partial class OrderedGoodsWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provisionReleaseDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayedCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.progressCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.releaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.revDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customersCmbBox = new System.Windows.Forms.ComboBox();
            this.goodsCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.priceAddBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1231, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.goodIdCol,
            this.orderedDateCol,
            this.customerIdCol,
            this.provisionReleaseDateCol,
            this.releaseDateCol,
            this.priceCol,
            this.isPayedCol,
            this.progressCol,
            this.saveCol,
            this.deleteCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 633);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // goodIdCol
            // 
            this.goodIdCol.HeaderText = "Изделие";
            this.goodIdCol.MinimumWidth = 6;
            this.goodIdCol.Name = "goodIdCol";
            this.goodIdCol.ReadOnly = true;
            this.goodIdCol.Visible = false;
            this.goodIdCol.Width = 125;
            // 
            // orderedDateCol
            // 
            this.orderedDateCol.HeaderText = "Дата заказа";
            this.orderedDateCol.MinimumWidth = 6;
            this.orderedDateCol.Name = "orderedDateCol";
            this.orderedDateCol.ReadOnly = true;
            this.orderedDateCol.Width = 125;
            // 
            // customerIdCol
            // 
            this.customerIdCol.HeaderText = "Заказчик";
            this.customerIdCol.MinimumWidth = 6;
            this.customerIdCol.Name = "customerIdCol";
            this.customerIdCol.ReadOnly = true;
            this.customerIdCol.Width = 125;
            // 
            // provisionReleaseDateCol
            // 
            this.provisionReleaseDateCol.HeaderText = "Предпол. дата выполнения";
            this.provisionReleaseDateCol.MinimumWidth = 6;
            this.provisionReleaseDateCol.Name = "provisionReleaseDateCol";
            this.provisionReleaseDateCol.ReadOnly = true;
            this.provisionReleaseDateCol.Width = 125;
            // 
            // releaseDateCol
            // 
            this.releaseDateCol.HeaderText = "Дата выполнения";
            this.releaseDateCol.MinimumWidth = 6;
            this.releaseDateCol.Name = "releaseDateCol";
            this.releaseDateCol.ReadOnly = true;
            this.releaseDateCol.Width = 125;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена, руб.";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            this.priceCol.Width = 125;
            // 
            // isPayedCol
            // 
            this.isPayedCol.HeaderText = "Оплчачено";
            this.isPayedCol.MinimumWidth = 6;
            this.isPayedCol.Name = "isPayedCol";
            this.isPayedCol.Width = 125;
            // 
            // progressCol
            // 
            this.progressCol.HeaderText = "В работе";
            this.progressCol.MinimumWidth = 6;
            this.progressCol.Name = "progressCol";
            this.progressCol.Width = 125;
            // 
            // saveCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.saveCol.HeaderText = "Сохранить";
            this.saveCol.MinimumWidth = 6;
            this.saveCol.Name = "saveCol";
            this.saveCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.saveCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.saveCol.Width = 125;
            // 
            // deleteCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteCol.HeaderText = "Удалить";
            this.deleteCol.MinimumWidth = 6;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Width = 125;
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
            this.tabControl1.Size = new System.Drawing.Size(1239, 674);
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
            this.tabPage2.Size = new System.Drawing.Size(1231, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.releaseDateTimePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.revDateTimePicker);
            this.groupBox2.Controls.Add(this.customersCmbBox);
            this.groupBox2.Controls.Add(this.goodsCmbBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.orderDateTimePicker);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.priceAddBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1225, 633);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // releaseDateTimePicker
            // 
            this.releaseDateTimePicker.Location = new System.Drawing.Point(301, 338);
            this.releaseDateTimePicker.Name = "releaseDateTimePicker";
            this.releaseDateTimePicker.Size = new System.Drawing.Size(477, 27);
            this.releaseDateTimePicker.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дата выполнения";
            // 
            // revDateTimePicker
            // 
            this.revDateTimePicker.Location = new System.Drawing.Point(301, 273);
            this.revDateTimePicker.Name = "revDateTimePicker";
            this.revDateTimePicker.Size = new System.Drawing.Size(478, 27);
            this.revDateTimePicker.TabIndex = 19;
            // 
            // customersCmbBox
            // 
            this.customersCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersCmbBox.FormattingEnabled = true;
            this.customersCmbBox.Location = new System.Drawing.Point(301, 208);
            this.customersCmbBox.Name = "customersCmbBox";
            this.customersCmbBox.Size = new System.Drawing.Size(477, 28);
            this.customersCmbBox.TabIndex = 18;
            // 
            // goodsCmbBox
            // 
            this.goodsCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodsCmbBox.FormattingEnabled = true;
            this.goodsCmbBox.Location = new System.Drawing.Point(301, 74);
            this.goodsCmbBox.Name = "goodsCmbBox";
            this.goodsCmbBox.Size = new System.Drawing.Size(478, 28);
            this.goodsCmbBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Изделие";
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Location = new System.Drawing.Point(301, 138);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(477, 27);
            this.orderDateTimePicker.TabIndex = 14;
            this.orderDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(300, 453);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(478, 52);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добавить запись";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // priceAddBox
            // 
            this.priceAddBox.Location = new System.Drawing.Point(301, 402);
            this.priceAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceAddBox.Name = "priceAddBox";
            this.priceAddBox.Size = new System.Drawing.Size(477, 27);
            this.priceAddBox.TabIndex = 9;
            this.priceAddBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceAddBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Стоимость товара, руб.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(281, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Предположительная дата выполнения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Заказчик";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Дата заказа";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderedGoodsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 674);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "OrderedGoodsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы по товарам";
            this.Load += new System.EventHandler(this.OrderedGoodsWindow_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private DateTimePicker orderDateTimePicker;
        private Button addBtn;
        private TextBox priceAddBox;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn goodIdCol;
        private DataGridViewTextBoxColumn orderedDateCol;
        private DataGridViewTextBoxColumn customerIdCol;
        private DataGridViewTextBoxColumn provisionReleaseDateCol;
        private DataGridViewTextBoxColumn releaseDateCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewCheckBoxColumn isPayedCol;
        private DataGridViewCheckBoxColumn progressCol;
        private DataGridViewButtonColumn saveCol;
        private DataGridViewButtonColumn deleteCol;
        private ComboBox goodsCmbBox;
        private Label label1;
        private ComboBox customersCmbBox;
        private Label label3;
        private DateTimePicker revDateTimePicker;
        private DateTimePicker releaseDateTimePicker;
        private System.Windows.Forms.Timer timer1;
    }
}