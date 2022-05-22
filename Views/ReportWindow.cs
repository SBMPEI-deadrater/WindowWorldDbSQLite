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
using WindowWorldDbSQLite.Services;

namespace WindowWorldDbSQLite.Views
{
    public partial class ReportWindow : Form
    {
        User mUser = null;
        OrdersController ordersController = null;
        OrderedServiceController orderedServiceController = null;

        public ReportWindow(User _user)
        {
            mUser = _user;
            ordersController = new OrdersController();
            orderedServiceController = new OrderedServiceController();

            InitializeComponent();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            using(WordService wordService = new WordService())
            {
                if (radioButtonList.Checked)
                {
                    if(wordService.CreateDocOrders(ordersController.GetOrdersForDocx(dateTimePickerFrom.Value, dateTimePickerTo.Value)))
                    {
                        MessageBox.Show("Yes");
                    }
                    else
                    {
                        MessageBox.Show("No");
                    }
                }
                else if (radioButtonMax.Checked)
                {
                    if (wordService.CreateDocMaxProfit(orderedServiceController.GetOrderedServicesMaxProfitForDocx(dateTimePickerFrom.Value, dateTimePickerTo.Value)))
                    {
                        MessageBox.Show("Yes");
                    }
                    else
                    {
                        MessageBox.Show("No");
                    }
                }
            }
        }
    }
}
