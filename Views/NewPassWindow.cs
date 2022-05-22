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

namespace WindowWorldDbSQLite.Views
{
    public partial class NewPassWindow : Form
    {
        User mUser = null;
        AuthCTRL authCTRL = null;

        public NewPassWindow(User _user)
        {
            mUser = _user;
            authCTRL = new AuthCTRL();
            InitializeComponent();
            this.Text = $"{this.Text} ({mUser.UserName})";
        }

        private void newpassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(newpassBox.Text == String.Empty)
                {
                    throw new Exception("Поле пароля не может быь пустым!");
                }
                if (authCTRL.UpdateUserPassword(mUser, newpassBox.Text))
                {
                    MessageBox.Show("Пароль успешно сменен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
