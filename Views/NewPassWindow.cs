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
        UserNewPass newPass;

        public NewPassWindow()
        {
            InitializeComponent();
        }

        private void newpassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = newPass.ChangePassword(newpassBox.Text);
                if (result)
                {
                    MessageBox.Show("Пароль успешно изменён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка! Пароль не был изменён!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
