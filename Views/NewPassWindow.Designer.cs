namespace WindowWorldDbSQLite.Views
{
    partial class NewPassWindow
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
            this.newpassBox = new System.Windows.Forms.TextBox();
            this.newpassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newpassBox
            // 
            this.newpassBox.Location = new System.Drawing.Point(14, 16);
            this.newpassBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newpassBox.Name = "newpassBox";
            this.newpassBox.Size = new System.Drawing.Size(283, 27);
            this.newpassBox.TabIndex = 0;
            // 
            // newpassBtn
            // 
            this.newpassBtn.Location = new System.Drawing.Point(14, 55);
            this.newpassBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newpassBtn.Name = "newpassBtn";
            this.newpassBtn.Size = new System.Drawing.Size(283, 31);
            this.newpassBtn.TabIndex = 1;
            this.newpassBtn.Text = "ИЗМЕНИТЬ";
            this.newpassBtn.UseVisualStyleBackColor = true;
            this.newpassBtn.Click += new System.EventHandler(this.newpassBtn_Click);
            // 
            // NewPassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(311, 103);
            this.Controls.Add(this.newpassBtn);
            this.Controls.Add(this.newpassBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewPassWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox newpassBox;
        private Button newpassBtn;
    }
}