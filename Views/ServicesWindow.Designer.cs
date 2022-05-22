namespace WindowWorldDbSQLite.Views
{
    partial class ServicesWindow
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
            this.priceAddBox = new System.Windows.Forms.TextBox();
            this.typeAddBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchGrBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSearchBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.searchGrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // priceAddBox
            // 
            this.priceAddBox.Location = new System.Drawing.Point(101, 324);
            this.priceAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceAddBox.Name = "priceAddBox";
            this.priceAddBox.Size = new System.Drawing.Size(477, 27);
            this.priceAddBox.TabIndex = 9;
            // 
            // typeAddBox
            // 
            this.typeAddBox.Location = new System.Drawing.Point(101, 252);
            this.typeAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeAddBox.Name = "typeAddBox";
            this.typeAddBox.Size = new System.Drawing.Size(477, 27);
            this.typeAddBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Цена изделия, руб.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Тип";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.priceAddBox);
            this.groupBox2.Controls.Add(this.typeAddBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(685, 649);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(691, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabControl1.Size = new System.Drawing.Size(699, 690);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchGrBox);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(691, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchGrBox
            // 
            this.searchGrBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchGrBox.Controls.Add(this.label2);
            this.searchGrBox.Controls.Add(this.label1);
            this.searchGrBox.Controls.Add(this.comboSearchBox);
            this.searchGrBox.Controls.Add(this.searchBox);
            this.searchGrBox.Location = new System.Drawing.Point(8, 537);
            this.searchGrBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGrBox.Name = "searchGrBox";
            this.searchGrBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchGrBox.Size = new System.Drawing.Size(990, 112);
            this.searchGrBox.TabIndex = 1;
            this.searchGrBox.TabStop = false;
            this.searchGrBox.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найти запись:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать поле:";
            // 
            // comboSearchBox
            // 
            this.comboSearchBox.FormattingEnabled = true;
            this.comboSearchBox.Items.AddRange(new object[] {
            "Общий поиск",
            "Поиск по производителю",
            "Поиск по типу",
            "Поиск по цене",
            "Поиск по наименованию"});
            this.comboSearchBox.Location = new System.Drawing.Point(113, 29);
            this.comboSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboSearchBox.Name = "comboSearchBox";
            this.comboSearchBox.Size = new System.Drawing.Size(370, 28);
            this.comboSearchBox.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(113, 68);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(370, 27);
            this.searchBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.typeCol,
            this.priceCol,
            this.progressCol,
            this.saveCol,
            this.deleteCol});
            this.dataGridView.Location = new System.Drawing.Point(7, 25);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(662, 504);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "Код";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Вид услуги";
            this.typeCol.MinimumWidth = 6;
            this.typeCol.Name = "typeCol";
            this.typeCol.ReadOnly = true;
            this.typeCol.Width = 150;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена, руб.";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.Width = 125;
            // 
            // progressCol
            // 
            this.progressCol.HeaderText = "В работе";
            this.progressCol.MinimumWidth = 6;
            this.progressCol.Name = "progressCol";
            this.progressCol.Width = 90;
            // 
            // saveCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            this.saveCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.saveCol.HeaderText = "Сохранить";
            this.saveCol.MinimumWidth = 6;
            this.saveCol.Name = "saveCol";
            this.saveCol.Width = 125;
            // 
            // deleteCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteCol.HeaderText = "Удалить";
            this.deleteCol.MinimumWidth = 6;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Width = 90;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(101, 363);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(478, 52);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добавить запись";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ServicesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "ServicesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.ServicesWindow_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.searchGrBox.ResumeLayout(false);
            this.searchGrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox priceAddBox;
        private TextBox typeAddBox;
        private Label label11;
        private Label label12;
        private GroupBox groupBox2;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox searchGrBox;
        private Label label2;
        private Label label1;
        private ComboBox comboSearchBox;
        private TextBox searchBox;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn typeCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewCheckBoxColumn progressCol;
        private DataGridViewButtonColumn saveCol;
        private DataGridViewButtonColumn deleteCol;
        private Button addBtn;
    }
}