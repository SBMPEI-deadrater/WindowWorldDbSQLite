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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.activeChkBox = new System.Windows.Forms.CheckBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.searchGrBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgSrcCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numGoodsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.progressCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.searchGrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1316, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.searchGrBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1308, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.activeChkBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.typeBox);
            this.groupBox1.Controls.Add(this.companyBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(875, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 651);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 324);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // activeChkBox
            // 
            this.activeChkBox.AutoSize = true;
            this.activeChkBox.Location = new System.Drawing.Point(6, 270);
            this.activeChkBox.Name = "activeChkBox";
            this.activeChkBox.Size = new System.Drawing.Size(79, 19);
            this.activeChkBox.TabIndex = 11;
            this.activeChkBox.Text = "Доступно";
            this.activeChkBox.UseVisualStyleBackColor = true;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(6, 241);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(418, 23);
            this.priceBox.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(6, 187);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(418, 23);
            this.typeBox.TabIndex = 8;
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(6, 134);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(418, 23);
            this.companyBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(6, 78);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(418, 23);
            this.nameBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Цена изделия, руб.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Вид изделия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Наименование изделия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Код изделия";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(318, 20);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 23);
            this.numBox.TabIndex = 0;
            // 
            // searchGrBox
            // 
            this.searchGrBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchGrBox.Controls.Add(this.label2);
            this.searchGrBox.Controls.Add(this.label1);
            this.searchGrBox.Controls.Add(this.comboBox1);
            this.searchGrBox.Controls.Add(this.textBox1);
            this.searchGrBox.Location = new System.Drawing.Point(3, 570);
            this.searchGrBox.Name = "searchGrBox";
            this.searchGrBox.Size = new System.Drawing.Size(866, 84);
            this.searchGrBox.TabIndex = 1;
            this.searchGrBox.TabStop = false;
            this.searchGrBox.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найти запись:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать поле:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 23);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.imgSrcCol,
            this.numGoodsCol,
            this.nameGoodsCol,
            this.companyCol,
            this.typeCol,
            this.priceCol,
            this.activeCol,
            this.progressCol,
            this.deleteCol});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(863, 545);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // imgSrcCol
            // 
            this.imgSrcCol.HeaderText = "Путь к изображению";
            this.imgSrcCol.Name = "imgSrcCol";
            this.imgSrcCol.ReadOnly = true;
            this.imgSrcCol.Visible = false;
            // 
            // numGoodsCol
            // 
            this.numGoodsCol.HeaderText = "Код";
            this.numGoodsCol.Name = "numGoodsCol";
            this.numGoodsCol.Width = 50;
            // 
            // nameGoodsCol
            // 
            this.nameGoodsCol.HeaderText = "Наименование";
            this.nameGoodsCol.Name = "nameGoodsCol";
            this.nameGoodsCol.Width = 200;
            // 
            // companyCol
            // 
            this.companyCol.HeaderText = "Производитель";
            this.companyCol.Name = "companyCol";
            this.companyCol.ReadOnly = true;
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Вид изделия";
            this.typeCol.Name = "typeCol";
            this.typeCol.ReadOnly = true;
            this.typeCol.Width = 150;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена, руб.";
            this.priceCol.Name = "priceCol";
            // 
            // activeCol
            // 
            this.activeCol.HeaderText = "Доступно";
            this.activeCol.Name = "activeCol";
            this.activeCol.Width = 70;
            // 
            // progressCol
            // 
            this.progressCol.HeaderText = "В работе";
            this.progressCol.Name = "progressCol";
            this.progressCol.Width = 70;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "Удалить";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1308, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GoodsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "GoodsWindow";
            this.Text = "Изделия";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.searchGrBox.ResumeLayout(false);
            this.searchGrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox priceBox;
        private TextBox typeBox;
        private TextBox companyBox;
        private TextBox nameBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox numBox;
        private GroupBox searchGrBox;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn imgSrcCol;
        private DataGridViewTextBoxColumn numGoodsCol;
        private DataGridViewTextBoxColumn nameGoodsCol;
        private DataGridViewTextBoxColumn companyCol;
        private DataGridViewTextBoxColumn typeCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewCheckBoxColumn activeCol;
        private DataGridViewCheckBoxColumn progressCol;
        private DataGridViewButtonColumn deleteCol;
        private CheckBox activeChkBox;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}