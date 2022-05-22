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
    public partial class MainWindow : Form
    {
        User mUser = null;
        authForm aForm = null;

        public MainWindow(User _user, authForm _form)
        {
            mUser = _user;
            aForm = _form;
            InitializeComponent();
            this.Text = $"{this.Text} ({mUser.Role})";
        }

        private void сменаПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPassWindow newPass = new NewPassWindow(mUser);
            newPass.Show();
        }

        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsWindow goodsWindow = new GoodsWindow(mUser);
            goodsWindow.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            aForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesWindow servicesWindow = new ServicesWindow(mUser);
            servicesWindow.Show();
        }

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersWindow customersWindow = new CustomersWindow(mUser);
            customersWindow.Show();
        }

        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            aForm.Show();
        }

        private void поИзделиямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderedGoodsWindow ordersWindow = new OrderedGoodsWindow(mUser);
            ordersWindow.Show();
        }

        private void поУслугамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderedServicesWindow orderedServicesWindow = new OrderedServicesWindow(mUser);
            orderedServicesWindow.Show();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow(mUser);
            reportWindow.Show();
        }

        private void резервноеКопированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SettingsDatabase sdb = new SettingsDatabase())
            {
                if (sdb.BackupSQLiteDbToDesktop())
                {
                    MessageBox.Show("Бэкап удался!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Бэкап не удался!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            switch (mUser.Role)
            {
                case "user":
                    резервноеКопированиеToolStripMenuItem.Available = false;
                    break;
            }
        }

        private void pendingPaidSecondBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OrdersController ordersController = new OrdersController();

            StringBuilder sb = new StringBuilder();

            var dict = ordersController.GetListOrdersMaxProfit();
            var maxDict = new Dictionary<string, decimal>();
            for(int i = 0; i < dict.Count; i++)
            {
                Dictionary<string, decimal> item = dict.OrderByDescending(d => d.Value).ToString();
                MessageBox.Show(item.Values.ToString());*/
                //sb.Append(item. + " -- " + item.Value + "\n");

            //}
            /*foreach (var item in dict)
            {
                dict.Max(d => d.Value);

            }
            MessageBox.Show(.ToString());*/
        }
    }
}
