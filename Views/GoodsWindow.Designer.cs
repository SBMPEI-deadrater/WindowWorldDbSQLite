namespace WindowWorldDbSQLite.Views
{
    partial class GoodsWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.searchGrBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSearchBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgSrcCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.progressCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgUrlBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.imageAddBox = new System.Windows.Forms.PictureBox();
            this.priceAddBox = new System.Windows.Forms.TextBox();
            this.typeAddBox = new System.Windows.Forms.TextBox();
            this.companyAddBox = new System.Windows.Forms.TextBox();
            this.nameAddBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.searchGrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAddBox)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1595, 913);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.searchGrBox);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1587, 880);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.imageBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1101, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(483, 872);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox.Location = new System.Drawing.Point(6, 21);
            this.imageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(471, 432);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 12;
            this.imageBox.TabStop = false;
            // 
            // searchGrBox
            // 
            this.searchGrBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchGrBox.Controls.Add(this.label2);
            this.searchGrBox.Controls.Add(this.label1);
            this.searchGrBox.Controls.Add(this.comboSearchBox);
            this.searchGrBox.Controls.Add(this.searchBox);
            this.searchGrBox.Location = new System.Drawing.Point(3, 760);
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
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найти запись:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
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
            this.nameGoodsCol,
            this.companyCol,
            this.typeCol,
            this.priceCol,
            this.imgSrcCol,
            this.activeCol,
            this.progressCol,
            this.saveCol,
            this.deleteCol});
            this.dataGridView.Location = new System.Drawing.Point(7, 25);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1088, 727);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
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
            // nameGoodsCol
            // 
            this.nameGoodsCol.HeaderText = "Наименование";
            this.nameGoodsCol.MinimumWidth = 6;
            this.nameGoodsCol.Name = "nameGoodsCol";
            this.nameGoodsCol.Width = 200;
            // 
            // companyCol
            // 
            this.companyCol.HeaderText = "Производитель";
            this.companyCol.MinimumWidth = 6;
            this.companyCol.Name = "companyCol";
            this.companyCol.ReadOnly = true;
            this.companyCol.Width = 125;
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Вид изделия";
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
            // imgSrcCol
            // 
            this.imgSrcCol.HeaderText = "Путь к изображению";
            this.imgSrcCol.MinimumWidth = 6;
            this.imgSrcCol.Name = "imgSrcCol";
            this.imgSrcCol.ReadOnly = true;
            this.imgSrcCol.Visible = false;
            this.imgSrcCol.Width = 125;
            // 
            // activeCol
            // 
            this.activeCol.HeaderText = "Доступно";
            this.activeCol.MinimumWidth = 6;
            this.activeCol.Name = "activeCol";
            this.activeCol.Width = 90;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1587, 880);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.imgUrlBox);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.imageAddBox);
            this.groupBox2.Controls.Add(this.priceAddBox);
            this.groupBox2.Controls.Add(this.typeAddBox);
            this.groupBox2.Controls.Add(this.companyAddBox);
            this.groupBox2.Controls.Add(this.nameAddBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1581, 872);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "URL изображения";
            // 
            // imgUrlBox
            // 
            this.imgUrlBox.Location = new System.Drawing.Point(806, 608);
            this.imgUrlBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgUrlBox.Name = "imgUrlBox";
            this.imgUrlBox.Size = new System.Drawing.Size(390, 27);
            this.imgUrlBox.TabIndex = 14;
            this.imgUrlBox.Click += new System.EventHandler(this.imgUrlBox_Click);
            this.imgUrlBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // imageAddBox
            // 
            this.imageAddBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAddBox.Location = new System.Drawing.Point(806, 205);
            this.imageAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageAddBox.Name = "imageAddBox";
            this.imageAddBox.Size = new System.Drawing.Size(390, 385);
            this.imageAddBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAddBox.TabIndex = 12;
            this.imageAddBox.TabStop = false;
            this.imageAddBox.Click += new System.EventHandler(this.imageAddBox_Click);
            // 
            // priceAddBox
            // 
            this.priceAddBox.Location = new System.Drawing.Point(301, 500);
            this.priceAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceAddBox.Name = "priceAddBox";
            this.priceAddBox.Size = new System.Drawing.Size(477, 27);
            this.priceAddBox.TabIndex = 9;
            // 
            // typeAddBox
            // 
            this.typeAddBox.Location = new System.Drawing.Point(301, 428);
            this.typeAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeAddBox.Name = "typeAddBox";
            this.typeAddBox.Size = new System.Drawing.Size(477, 27);
            this.typeAddBox.TabIndex = 8;
            // 
            // companyAddBox
            // 
            this.companyAddBox.Location = new System.Drawing.Point(301, 357);
            this.companyAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companyAddBox.Name = "companyAddBox";
            this.companyAddBox.Size = new System.Drawing.Size(477, 27);
            this.companyAddBox.TabIndex = 7;
            // 
            // nameAddBox
            // 
            this.nameAddBox.Location = new System.Drawing.Point(301, 283);
            this.nameAddBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameAddBox.Name = "nameAddBox";
            this.nameAddBox.Size = new System.Drawing.Size(477, 27);
            this.nameAddBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Цена изделия, руб.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Вид изделия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Производитель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Наименование изделия";
            // 
            // GoodsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 913);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GoodsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.GoodsWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.searchGrBox.ResumeLayout(false);
            this.searchGrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAddBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox searchGrBox;
        private Label label2;
        private Label label1;
        private ComboBox comboSearchBox;
        private TextBox searchBox;
        private PictureBox imageBox;
        private GroupBox groupBox2;
        private Button addBtn;
        private PictureBox imageAddBox;
        private TextBox priceAddBox;
        private TextBox typeAddBox;
        private TextBox companyAddBox;
        private TextBox nameAddBox;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameGoodsCol;
        private DataGridViewTextBoxColumn companyCol;
        private DataGridViewTextBoxColumn typeCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewTextBoxColumn imgSrcCol;
        private DataGridViewCheckBoxColumn activeCol;
        private DataGridViewCheckBoxColumn progressCol;
        private DataGridViewButtonColumn saveCol;
        private DataGridViewButtonColumn deleteCol;
        private Label label3;
        private TextBox imgUrlBox;
    }
}