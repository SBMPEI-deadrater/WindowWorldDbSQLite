﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowWorldDbSQLite.Views
{
    public partial class OrderedServicesWindow : Form
    {
        public OrderedServicesWindow()
        {
            InitializeComponent();
            orderDateBox.Text = DateTime.Now.ToString();
        }
    }
}
