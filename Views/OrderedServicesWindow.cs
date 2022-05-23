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
    public partial class OrderedServicesWindow : Form
    {
        User mUser = null;
        OrderedServiceController controller = null;
        ServiceController srvCtrl = null;
        CustomerContrller customerCtrl = null;
        List<OrderedService> osItems = null;
        List<Service> srvItems = null;
        List<Customer> customerItems = null;

        public OrderedServicesWindow(User _user = null)
        {
            mUser = _user;
            controller = new OrderedServiceController();
            srvCtrl = new ServiceController();
            customerCtrl = new CustomerContrller();
            InitializeComponent();
        }

        private void UpdateForm(string search = "", string field = "")
        {
            osItems = controller.GetAllOrderedServiceByFilter(search, field);
            if (osItems != null)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < osItems.Count; i++)
                {
                    dataGridView1.Rows.Add();

                    dataGridView1[0, i].Value = osItems[i].Id;

                    var srvItem = srvCtrl.GetSingleService(osItems[i].ServiceId);
                    if (srvItem != null)
                    {
                        dataGridView1[1, i].Value = srvItem.TypeService;
                    }
                    else
                    {
                        dataGridView1[1, i].Value = "Not found";
                    }

                    dataGridView1[2, i].Value = osItems[i].OrderedDate.ToShortDateString();

                    var customer = customerCtrl.GetSingleCustomer(osItems[i].CustomerId);
                    if (customer != null)
                    {
                        string fullName = customer.LastName + " " + customer.FirstName[0] + "." + customer.MiddleName[0] + ".";
                        dataGridView1[3, i].Value = fullName;
                    }
                    else
                    {
                        dataGridView1[3, i].Value = "Not found";
                    }

                    dataGridView1[4, i].Value = osItems[i].ProvisionalReleaseDate.ToShortDateString();
                    dataGridView1[5, i].Value = osItems[i].ReleaseDate.ToShortDateString();
                    dataGridView1[6, i].Value = Math.Round(osItems[i].Price, 2).ToString();
                    dataGridView1[7, i].Value = osItems[i].IsPayed;
                    dataGridView1[8, i].Value = osItems[i].Progress;
                    dataGridView1[9, i].Value = "Удалить";
                    dataGridView1[10, i].Value = "Сохранить";
                }
            }
        }

        public void UpdateFormTwo()
        {
            srvItems = srvCtrl.GetAllServicesByFilter();
            if(srvItems != null)
            {
                serviceCmbBox.Items.Clear();
                foreach(var item in srvItems)
                {
                    serviceCmbBox.Items.Add(item.TypeService);
                }
                serviceCmbBox.SelectedIndex = 0;
            }

            customerItems = customerCtrl.GetAllCustomers();
            if(customerItems != null)
            {
                customerCmbBox.Items.Clear();
                foreach(var item in customerItems)
                {
                    string name = item.LastName + " " + item.FirstName[0] + "." + item.MiddleName[0] + ".";
                    customerCmbBox.Items.Add(name);
                }
                customerCmbBox.SelectedIndex = 0;
            }
        }

        private void OrderedServicesWindow_Load(object sender, EventArgs e)
        {
            switch (mUser.Role)
            {
                case "user":
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    break;
            }
            
            UpdateForm();
            UpdateFormTwo();
            timer1.Start();
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
                if(priceAddBox.Text == "")
                {
                    throw new Exception("Необходимо заполнить поле \"Цена\"!!");
                }

                int serviceId = 0;
                foreach(var item in srvItems)
                {
                    if (serviceCmbBox.SelectedItem == item.TypeService)
                    {
                        serviceId = item.Id;
                        break;
                    }
                }

                int customerId = 0;
                string lName = customerCmbBox.SelectedItem.ToString().Split(' ')[0];
                foreach(var item in customerItems)
                {
                    if(item.LastName == lName)
                    {
                        customerId = item.Id;
                        break;
                    }
                }

                OrderedService obj = new OrderedService()
                {
                    ServiceId = serviceId,
                    CustomerId = customerId,
                    OrderedDate = orderDateTimePicker.Value,
                    ProvisionalReleaseDate = provisionalReleaseDateTimePicker.Value,
                    ReleaseDate = releaseDateTimePicker.Value,
                    Price = Convert.ToDecimal(priceAddBox.Text),
                    IsPayed = false,
                    Progress = false
                };

                if (controller.AddSingleNewOrderedService(obj))
                {
                    UpdateForm();
                    MessageBox.Show("Новый заказ по услуге успешно добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные в БД!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveChangesDataGridView(DataGridViewCellEventArgs e)
        {
            bool result = false;

            try
            {
                int serviceId = 0;
                foreach (var item in srvItems)
                {
                    if (item.TypeService == dataGridView1[1, e.RowIndex].Value.ToString())
                    {
                        serviceId = item.Id;
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

                OrderedService obj = new OrderedService()
                {
                    Id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value),
                    ServiceId = serviceId,
                    OrderedDate = Convert.ToDateTime(dataGridView1[2, e.RowIndex].Value),
                    CustomerId = customerId,
                    ProvisionalReleaseDate = Convert.ToDateTime(dataGridView1[4, e.RowIndex].Value),
                    ReleaseDate = Convert.ToDateTime(dataGridView1[5, e.RowIndex].Value),
                    Price = Convert.ToDecimal(dataGridView1[6, e.RowIndex].Value),
                    IsPayed = Convert.ToBoolean(dataGridView1[7, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView1[8, e.RowIndex].Value)
                };

                if (controller.UpdateSingleOrderedService(obj))
                {
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        private bool DeleteSingleDGV(DataGridViewCellEventArgs e)
        {
            bool result = false;

            try
            {
                int serviceId = 0;
                foreach (var item in srvItems)
                {
                    if (item.TypeService == dataGridView1[1, e.RowIndex].Value)
                    {
                        serviceId = item.Id;
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

                OrderedService obj = new OrderedService()
                {
                    Id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value),
                    ServiceId = serviceId,
                    OrderedDate = Convert.ToDateTime(dataGridView1[2, e.RowIndex].Value),
                    CustomerId = customerId,
                    ProvisionalReleaseDate = Convert.ToDateTime(dataGridView1[4, e.RowIndex].Value),
                    ReleaseDate = Convert.ToDateTime(dataGridView1[5, e.RowIndex].Value),
                    Price = Convert.ToDecimal(dataGridView1[6, e.RowIndex].Value),
                    IsPayed = Convert.ToBoolean(dataGridView1[7, e.RowIndex].Value),
                    Progress = Convert.ToBoolean(dataGridView1[8, e.RowIndex].Value)
                };

                if (controller.DeleteSingleOrderedService(obj))
                {
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {
                if (SaveChangesDataGridView(e))
                {
                    UpdateForm();
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if(e.ColumnIndex == 9)
            {
                string message = "Вы действительно хотите удалить?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteSingleDGV(e))
                    {
                        UpdateForm();
                        MessageBox.Show("Успешно удалёно.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateFormTwo();
        }
    }
}
