﻿using System;
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
    }
}
