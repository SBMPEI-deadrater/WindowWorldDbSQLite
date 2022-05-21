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
        }

        private void сменаПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPassWindow newPass = new NewPassWindow();
            newPass.Show();
        }

        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsWindow goodsWindow = new GoodsWindow();
            goodsWindow.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderedServicesWindow orderedServicesWindow = new OrderedServicesWindow();
            orderedServicesWindow.Show();
        }
    }
}
