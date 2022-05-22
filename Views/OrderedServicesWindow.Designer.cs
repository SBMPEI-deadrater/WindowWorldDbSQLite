namespace WindowWorldDbSQLite.Views
{
    partial class OrderedServicesWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.priceAddBox = new System.Windows.Forms.TextBox();
            this.provisionalDateAddBox = new System.Windows.Forms.TextBox();
            this.customerAddBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provisionReleaseDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPayedCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.progressCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1081, 888);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.priceAddBox);
            this.groupBox2.Controls.Add(this.provisionalDateAddBox);
            this.groupBox2.Controls.Add(this.customerAddBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1075, 880);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(477, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(301, 539);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(478, 52);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добавить запись";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // priceAddBox
            // 
            this.priceAddBox.Location = new System.Drawing.Point(301, 500);
            this.priceAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceAddBox.Name = "priceAddBox";
            this.priceAddBox.Size = new System.Drawing.Size(477, 27);
            this.priceAddBox.TabIndex = 9;
            // 
            // provisionalDateAddBox
            // 
            this.provisionalDateAddBox.Location = new System.Drawing.Point(301, 428);
            this.provisionalDateAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.provisionalDateAddBox.Name = "provisionalDateAddBox";
            this.provisionalDateAddBox.Size = new System.Drawing.Size(477, 27);
            this.provisionalDateAddBox.TabIndex = 8;
            // 
            // customerAddBox
            // 
            this.customerAddBox.Location = new System.Drawing.Point(301, 357);
            this.customerAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerAddBox.Name = "customerAddBox";
            this.customerAddBox.Size = new System.Drawing.Size(477, 27);
            this.customerAddBox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Стоимость выполнения, руб.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(281, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Предположительная дата выполнения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Заказчик";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Дата заказа";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.serviceIdCol,
            this.orderedDateCol,
            this.customerIdCol,
            this.provisionReleaseDateCol,
            this.releaseDateCol,
            this.priceCol,
            this.isPayedCol,
            this.progressCol,
            this.deleteCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 880);
            this.dataGridView1.TabIndex = 0;
            // 
            // idCol
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.idCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.idCol.HeaderText = "ID";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // serviceIdCol
            // 
            this.serviceIdCol.HeaderText = "Услуга";
            this.serviceIdCol.MinimumWidth = 6;
            this.serviceIdCol.Name = "serviceIdCol";
            this.serviceIdCol.ReadOnly = true;
            this.serviceIdCol.Width = 125;
            // 
            // orderedDateCol
            // 
            this.orderedDateCol.HeaderText = "Дата заказа";
            this.orderedDateCol.MinimumWidth = 6;
            this.orderedDateCol.Name = "orderedDateCol";
            this.orderedDateCol.Width = 125;
            // 
            // customerIdCol
            // 
            this.customerIdCol.HeaderText = "Заказчик";
            this.customerIdCol.MinimumWidth = 6;
            this.customerIdCol.Name = "customerIdCol";
            this.customerIdCol.Width = 125;
            // 
            // provisionReleaseDateCol
            // 
            this.provisionReleaseDateCol.HeaderText = "Предпол. дата выполнения";
            this.provisionReleaseDateCol.MinimumWidth = 6;
            this.provisionReleaseDateCol.Name = "provisionReleaseDateCol";
            this.provisionReleaseDateCol.Width = 125;
            // 
            // releaseDateCol
            // 
            this.releaseDateCol.HeaderText = "Дата выполнения";
            this.releaseDateCol.MinimumWidth = 6;
            this.releaseDateCol.Name = "releaseDateCol";
            this.releaseDateCol.Width = 125;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена, руб.";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
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
            this.tabControl1.Size = new System.Drawing.Size(1214, 921);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1206, 888);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OrderedServicesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1214, 921);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderedServicesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы по услугам";
            this.Load += new System.EventHandler(this.OrderedServicesWindow_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button addBtn;
        private TextBox priceAddBox;
        private TextBox provisionalDateAddBox;
        private TextBox customerAddBox;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn serviceIdCol;
        private DataGridViewTextBoxColumn orderedDateCol;
        private DataGridViewTextBoxColumn customerIdCol;
        private DataGridViewTextBoxColumn provisionReleaseDateCol;
        private DataGridViewTextBoxColumn releaseDateCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewCheckBoxColumn isPayedCol;
        private DataGridViewCheckBoxColumn progressCol;
        private DataGridViewButtonColumn deleteCol;
    }
}