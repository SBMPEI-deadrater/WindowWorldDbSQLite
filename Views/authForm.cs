using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Controllers;
using WindowWorldDbSQLite.Views;

namespace WindowWorldDbSQLite.Views
{
    public partial class authForm : Form
    {
        AuthCTRL authCTRL;
        public authForm()
        {
            authCTRL = new AuthCTRL();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text != String.Empty)
            {
                if (passwordBox.Text != String.Empty)
                {

                }
            }
        }
    }
}
