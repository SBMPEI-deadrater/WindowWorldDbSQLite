using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowWorldDbSQLite.Services;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Controllers;
using WindowWorldDbSQLite.Views;

namespace WindowWorldDbSQLite.Views
{
    public partial class GoodsWindow : Form
    {
        GoodController controller = null;
        List<Good> psItems = null;
        User mUser = null;
        public GoodsWindow(User _user)
        {
            mUser = _user;
            controller = new GoodController();
            InitializeComponent();
            this.Text = $"{this.Text} ({mUser.UserName})";
        }

        public void UpdateForm(string search = "", string field = "")
        {
            try
            {
                psItems = controller.GetAllGoodByFilter(search, field);
                if (psItems != null)
                {
                    dataGridView.Rows.Clear();
                    for (int i = 0; i < psItems.Count; i++)
                    {
                        dataGridView.Rows.Add(psItems[i]);
                        dataGridView[0, i].Value = psItems[i].Id;
                        dataGridView[1, i].Value = psItems[i].Name;
                        dataGridView[2, i].Value = psItems[i].Company;
                        dataGridView[3, i].Value = psItems[i].TypeGood;
                        dataGridView[4, i].Value = psItems[i].Price;
                        dataGridView[5, i].Value = psItems[i].PhotoUrl;
                        dataGridView[6, i].Value = psItems[i].IsActive;
                        dataGridView[7, i].Value = psItems[i].Progress;
                        dataGridView[8, i].Value = "Сохранить";
                        dataGridView[9, i].Value = "Удалить";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GoodController gc = new GoodController();
            if (e.ColumnIndex == 6)
            {
                Good obj = new Good
                {
                    Id = Convert.ToInt32(dataGridView[0, e.RowIndex].Value),
                    Name = dataGridView[1, e.RowIndex].Value.ToString(),
                    Company = dataGridView[2, e.RowIndex].Value.ToString(),
                    TypeGood = dataGridView[3, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(dataGridView[4, e.RowIndex].Value),
                    PhotoUrl = dataGridView[5, e.RowIndex].Value.ToString(),
                    IsActive = Convert.ToBoolean(dataGridView[6, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView[7, e.RowIndex].Value)
                };

                if()
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GoodsWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
