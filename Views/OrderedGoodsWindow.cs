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

        public OrderedGoodsWindow(User _user = null)
        {
            mUser = _user;
            InitializeComponent();
        }

        private void UpdateForm(string search = "", string field = "")
        {
            /*osItems = controller.GetAllOrderedServiceByFilter(search, field);
            if(osItems != null)
            {
                dataGridView1.Rows.Clear();
                for(int i = 0; i < osItems.Count; i++)
                {
                    dataGridView1.Rows.Add();

                    dataGridView1[0, i].Value = osItems[i].Id;

                    var srvItem = srvCtrl.GetSingleService(osItems[i].ServiceId);
                    if(srvItem != null)
                    {
                        dataGridView1[1, i].Value = srvItem.TypeService;
                    }
                    else
                    {
                        dataGridView1[1, i].Value = "Not found";
                    }

                    dataGridView1[2, i].Value = osItems[i].OrderedDate.ToShortDateString();
                    
                    var customer = customerCtrl.GetSingleCustomer(osItems[i].CustomerId);
                    if(customer != null)
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
                }
            }*/
        }

        private void OrderedGoodsWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
