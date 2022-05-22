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
                    //dataGridCustomers[0, i].Value = psItems[i].Id;
                    dataGridCustomers[0, i].Value = psItems[i].LastName;
                    dataGridCustomers[1, i].Value = psItems[i].FirstName;
                    dataGridCustomers[2, i].Value = psItems[i].MiddleName;
                    dataGridCustomers[3, i].Value = psItems[i].Adress;
                    dataGridCustomers[4, i].Value = psItems[i].PhoneNumber;
                    dataGridCustomers[5, i].Value = "Удалить";
                }
            }
        }

        private void CustomersWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
