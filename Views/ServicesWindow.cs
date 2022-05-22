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
    public partial class ServicesWindow : Form
    {
        User mUser = null;
        ServiceController controller = null;
        List<Service> psItems = null;


        public ServicesWindow(User _user)
        {
            mUser = _user;
            controller = new ServiceController();
            InitializeComponent();
        }

        public void UpdateForm(string search = "", string field = "")
        {
            psItems = controller.GetAllServicesByFilter(search, field);
            if (psItems != null)
            {
                dataGridView.Rows.Clear();
                for (int i = 0; i < psItems.Count; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView[0, i].Value = psItems[i].Id;
                    dataGridView[1, i].Value = psItems[i].TypeService;
                    dataGridView[2, i].Value = psItems[i].Price;
                    dataGridView[3, i].Value = psItems[i].Progress;
                    dataGridView[4, i].Value = "Сохранить";
                    dataGridView[5, i].Value = "Удалить";
                }
            }
        }

        private void ServicesWindow_Load(object sender, EventArgs e)
        {
            switch (mUser.Role)
            {
                case "user":
                    dataGridView.Columns[4].Visible = false;
                    dataGridView.Columns[5].Visible = false;
                    break;
            }
            
            UpdateForm();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceController controler = new ServiceController();
            if (e.ColumnIndex == 4)
            {
                Service obj = new Service
                {
                    Id = Convert.ToInt32(dataGridView[0, e.RowIndex].Value),
                    TypeService = dataGridView[1, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(dataGridView[2, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView[3, e.RowIndex].Value)
                };

                if (controller.UpdateSingleService(obj))
                {
                    UpdateForm();
                    //MessageBox.Show("Покупатель успешно обновлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("При удалении обновлении ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 5)
            {
                Service obj = new Service
                {
                    Id = Convert.ToInt32(dataGridView[0, e.RowIndex].Value),
                    TypeService = dataGridView[1, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(dataGridView[2, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView[3, e.RowIndex].Value)
                };

                if (controller.DeleteSingleService(obj))
                {
                    UpdateForm();
                    //MessageBox.Show("Покупатель успешно удален!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("При удалении произошла ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ServiceController controller = new ServiceController();
            Service obj = new Service
            {
                TypeService = typeAddBox.Text,
                Price = Convert.ToInt32(priceAddBox.Text)
            };

            if (typeAddBox.Text != String.Empty)
            {
                if (priceAddBox.Text != String.Empty)
                {
                    if (controller.AddSingleNewService(obj))
                    {
                        typeAddBox.Text = string.Empty;
                        priceAddBox.Text = string.Empty;
                        tabControl1.SelectTab(0);
                        UpdateForm();
                        //MessageBox.Show("Покупатель успешно добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("При добавлении произошла ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ServiceController controller = new ServiceController();
            switch (comboSearchBox.TabIndex)
            {
                case 1:
                    UpdateForm(searchBox.Text, "common");
                    break;
                case 2:
                    UpdateForm(searchBox.Text, "type");
                    break;
                case 3:
                    UpdateForm(searchBox.Text, "price");
                    break;
                default:
                    UpdateForm(searchBox.Text, "common");
                    break;
            }
        }
    }
}
