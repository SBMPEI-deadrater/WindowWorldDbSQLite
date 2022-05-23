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
    public partial class CustomersWindow : Form
    {
        CustomerContrller controller = null;
        List<Customer> psItems = null;
        User mUser = null;


        public CustomersWindow(User _user)
        {
            mUser = _user;
            controller = new CustomerContrller();
            InitializeComponent();
        }

        public void UpdateForm(string search = "", string field = "")
        {
            psItems = controller.GetAllCustomers(search, field);
            if (psItems != null)
            {
                dataGridCustomers.Rows.Clear();
                for(int i = 0; i < psItems.Count; i++)
                {
                    dataGridCustomers.Rows.Add();
                    dataGridCustomers[0, i].Value = psItems[i].Id;
                    dataGridCustomers[1, i].Value = psItems[i].LastName;
                    dataGridCustomers[2, i].Value = psItems[i].FirstName;
                    dataGridCustomers[3, i].Value = psItems[i].MiddleName;
                    dataGridCustomers[4, i].Value = psItems[i].Adress;
                    dataGridCustomers[5, i].Value = psItems[i].PhoneNumber;
                    dataGridCustomers[6, i].Value = "Сохранить";
                    dataGridCustomers[7, i].Value = "Удалить";
                }
            }
        }

        private void CustomersWindow_Load(object sender, EventArgs e)
        {
            switch (mUser.Role)
            {
                case "user":
                    dataGridCustomers.Columns[6].Visible = false;
                    dataGridCustomers.Columns[7].Visible = false;
                    break;
            }
            
            comboSearchBox.SelectedIndex = 0;
            UpdateForm();
            timer1.Start();
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerContrller cc = new CustomerContrller();
            if (e.ColumnIndex == 6)
            {
                Customer obj = new Customer
                {
                    Id = Convert.ToInt32(dataGridCustomers[0, e.RowIndex].Value),
                    LastName = dataGridCustomers[1, e.RowIndex].Value.ToString(),
                    FirstName = dataGridCustomers[2, e.RowIndex].Value.ToString(),
                    MiddleName = dataGridCustomers[3, e.RowIndex].Value.ToString(),
                    Adress = dataGridCustomers[4, e.RowIndex].Value.ToString(),
                    PhoneNumber = dataGridCustomers[5, e.RowIndex].Value.ToString()
                };

                if (cc.UpdateSingleCustomer(obj))
                {
                    UpdateForm();
                    //MessageBox.Show("Покупатель успешно обновлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("При удалении обновлении ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 7)
            {
                Customer obj = new Customer
                {
                    Id = Convert.ToInt32(dataGridCustomers[0, e.RowIndex].Value),
                    LastName = dataGridCustomers[1, e.RowIndex].Value.ToString(),
                    FirstName = dataGridCustomers[2, e.RowIndex].Value.ToString(),
                    MiddleName = dataGridCustomers[3, e.RowIndex].Value.ToString(),
                    Adress = dataGridCustomers[4, e.RowIndex].Value.ToString(),
                    PhoneNumber = dataGridCustomers[5,e.RowIndex].Value.ToString()
                };

                if (cc.DeleteSingleCustomer(obj))
                {
                    UpdateForm();
                    //MessageBox.Show("Покупатель успешно удален!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("При удалении произошла ошибка","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            CustomerContrller cc = new CustomerContrller();
            Customer obj = new Customer
            {
                //Id = ,
                LastName = lastNameAddBox.Text,
                FirstName = firstnameAddBox.Text,
                MiddleName = middleNameAddBox.Text,
                Adress = adressAddBox.Text,
                PhoneNumber = phoneNumberAddBox.Text
            };

            if(lastNameAddBox.Text != String.Empty)
            {
                if (firstnameAddBox.Text != String.Empty)
                {
                    if(middleNameAddBox.Text != String.Empty)
                    {
                        if (adressAddBox.Text != String.Empty)
                        {
                            if(phoneNumberAddBox.Text != String.Empty)
                            {
                                if (cc.AddSingleNewCustomer(obj))
                                {
                                    lastNameAddBox.Text = String.Empty;
                                    firstnameAddBox.Text = String.Empty;
                                    middleNameAddBox.Text = String.Empty;
                                    adressAddBox.Text = String.Empty;
                                    phoneNumberAddBox.Text = String.Empty;
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
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustomerContrller cc = new CustomerContrller();
            switch (comboSearchBox.SelectedIndex)
            {
                case 0:
                    UpdateForm(searchBox.Text, "common");
                    break;
                case 1:
                    UpdateForm(searchBox.Text, "adress");
                    break;
                case 2:
                    UpdateForm(searchBox.Text, "phone");
                    break;
            }
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            switch (comboSearchBox.TabIndex)
            {
                case 1:
                    controller.GetAllCustomers(searchBox.Text, "common");
                    break;
                case 2:
                    controller.GetAllCustomers(searchBox.Text, "adress");
                    break;
                case 3:
                    controller.GetAllCustomers(searchBox.Text, "phone");
                    break;
                default:
                    controller.GetAllCustomers(searchBox.Text, "common");
                    break;
            }
        }

        private void comboSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
