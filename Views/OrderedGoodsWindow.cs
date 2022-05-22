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
    public partial class OrderedGoodsWindow : Form
    {
        User mUser = null;
        OrdersController controller = null;
        GoodController goodController = null;
        CustomerContrller customerContrller = null;

        List<Orders> ordersItems = null;
        List<Good> goodItems = null;
        List<Customer> customerItems = null;

        public OrderedGoodsWindow(User _user = null)
        {
            mUser = _user;
            controller = new OrdersController();
            goodController = new GoodController();
            customerContrller = new CustomerContrller();
            InitializeComponent();
        }

        private void UpdateForm(string search = "", string field = "")
        {
            ordersItems = controller.GetAllOrders();
            if(ordersItems != null)
            {
                dataGridView1.Rows.Clear();
                for(int i = 0; i < ordersItems.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = ordersItems[i].Id;

                    var good = goodController.GetSingleGood(ordersItems[i].GoodId);
                    if(good != null)
                    {
                        dataGridView1[1, i].Value = good.Name;
                    }
                    else
                    {
                        dataGridView1[1, i].Value = "Not found";
                    }

                    dataGridView1[2, i].Value = ordersItems[i].DateOrder.ToShortDateString();
                    
                    var customer = customerContrller.GetSingleCustomer(ordersItems[i].CustomerId);
                    if(customer != null)
                    {
                        string name = customer.LastName + " " + customer.FirstName[0] + "." + customer.MiddleName[0] + ".";
                        dataGridView1[3, i].Value = name;
                    }
                    else
                    {
                        dataGridView1[3, i].Value = "Not found";
                    }

                    dataGridView1[4, i].Value = ordersItems[i].ProvisionalReleaseDate.ToShortDateString();
                    dataGridView1[5, i].Value = ordersItems[i].ReleaseDate.ToShortDateString();
                    dataGridView1[6, i].Value = Math.Round(ordersItems[i].OrderPrice, 2);
                    dataGridView1[7, i].Value = ordersItems[i].IsPayed;
                    dataGridView1[8, i].Value = ordersItems[i].OrderProgress;
                    dataGridView1[9, i].Value = "Сохранить";
                    dataGridView1[10, i].Value = "Удалить";
                }
            }
        }

        private void UpdateFormTwo()
        {
            goodItems = goodController.GetAllGoodByFilter();
            if (goodItems != null)
            {
                goodsCmbBox.Items.Clear();
                foreach(var item in goodItems)
                {
                    goodsCmbBox.Items.Add(item.Name);
                }
                goodsCmbBox.SelectedIndex = 0;
            }

            customerItems = customerContrller.GetAllCustomers();
            if(customerItems != null)
            {
                customersCmbBox.Items.Clear();
                foreach(var item in customerItems)
                {
                    string name = item.LastName + " " + item.FirstName[0] + "." + item.MiddleName[0] + ".";
                    customersCmbBox.Items.Add(name);
                }
                customersCmbBox.SelectedIndex = 0;
            }
        }

        private void OrderedGoodsWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateFormTwo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                if (SaveDGV(e))
                {
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == 10)
            {
                string message = "Вы действительно хотите удалить?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteDGV(e))
                    {
                        MessageBox.Show("Успешно удалено.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool SaveDGV(DataGridViewCellEventArgs e)
        {
            bool result = false;

            try
            {
                int goodId = 0;
                foreach(var item in goodItems)
                {
                    if(item.Name == dataGridView1[1, e.RowIndex].Value.ToString())
                    {
                        goodId = item.Id;
                        break;
                    }
                }

                int customerId = 0;
                string lName = dataGridView1[3, e.RowIndex].Value.ToString().Split(' ')[0];
                foreach(var item in customerItems)
                {
                    if(item.LastName == lName)
                    {
                        customerId = item.Id;
                        break;
                    }
                }

                Orders obj = new Orders()
                {
                    Id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value),
                    GoodId = goodId,
                    DateOrder = Convert.ToDateTime(dataGridView1[2, e.RowIndex].Value),
                    CustomerId = customerId,
                    ProvisionalReleaseDate = Convert.ToDateTime(dataGridView1[4, e.RowIndex].Value),
                    ReleaseDate = Convert.ToDateTime(dataGridView1[5, e.RowIndex].Value),
                    OrderPrice = Convert.ToDecimal(dataGridView1[6, e.RowIndex].Value),
                    IsPayed = Convert.ToBoolean(dataGridView1[7, e.RowIndex].Value),
                    OrderProgress = Convert.ToBoolean(dataGridView1[8, e.RowIndex].Value)
                };

                if (controller.UpdateSingleOrder(obj))
                {
                    result = true;
                    UpdateForm();
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        private bool DeleteDGV(DataGridViewCellEventArgs e)
        {
            bool result = false;

            try
            {
                int goodId = 0;
                foreach (var item in goodItems)
                {
                    if (item.Name == dataGridView1[1, e.RowIndex].Value.ToString())
                    {
                        goodId = item.Id;
                        break;
                    }
                }

                int customerId = 0;
                string lName = dataGridView1[3, e.RowIndex].Value.ToString().Split(' ')[0];
                foreach (var item in customerItems)
                {
                    if (item.LastName == lName)
                    {
                        customerId = item.Id;
                        break;
                    }
                }

                Orders obj = new Orders()
                {
                    Id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value),
                    GoodId = goodId,
                    DateOrder = Convert.ToDateTime(dataGridView1[2, e.RowIndex].Value),
                    CustomerId = customerId,
                    ProvisionalReleaseDate = Convert.ToDateTime(dataGridView1[4, e.RowIndex].Value),
                    ReleaseDate = Convert.ToDateTime(dataGridView1[5, e.RowIndex].Value),
                    OrderPrice = Convert.ToDecimal(dataGridView1[6, e.RowIndex].Value),
                    IsPayed = Convert.ToBoolean(dataGridView1[7, e.RowIndex].Value),
                    OrderProgress = Convert.ToBoolean(dataGridView1[8, e.RowIndex].Value)
                };

                if (controller.DeleteSingleOrder(obj))
                {
                    result = true;
                    UpdateForm();
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ValidateInputSymbols(KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace || e.KeyChar == ','))
            {
                e.KeyChar = '\0';
            }
        }
        private void priceAddBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(priceAddBox.Text == String.Empty)
                {
                    throw new Exception("Поле цена должно быть заполнено!");
                }

                int goodId = 0;
                foreach(var item in goodItems)
                {
                    if(item.Name == goodsCmbBox.SelectedItem.ToString())
                    {
                        goodId = item.Id;
                        break;
                    }
                }

                int customerId = 0;
                string lName = customersCmbBox.SelectedItem.ToString().Split(' ')[0];
                foreach(var item in customerItems)
                {
                    if(item.LastName == lName)
                    {
                        customerId = item.Id;
                        break;
                    }
                }

                Orders obj = new Orders()
                {
                    GoodId = goodId,
                    DateOrder = orderDateTimePicker.Value,
                    CustomerId = customerId,
                    ProvisionalReleaseDate = revDateTimePicker.Value,
                    ReleaseDate = releaseDateTimePicker.Value,
                    OrderPrice = Convert.ToDecimal(priceAddBox.Text),
                    IsPayed = false,
                    OrderProgress = false
                };

                if (controller.AddSingleNewOrder(obj))
                {
                    UpdateForm();
                    UpdateFormTwo();
                    MessageBox.Show("Данные успешно добавлены!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Произошла ошибка при добавлении данных!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
