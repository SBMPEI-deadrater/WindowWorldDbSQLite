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
                    User myUser = authCTRL.AuthToApp(usernameBox.Text, passwordBox.Text);
                    if (myUser != null)
                    {
                        myUser.Password = passwordBox.Text;
                        this.Hide();
                        MainWindow mainWindow = new MainWindow(myUser, this);
                        mainWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка авторизации! Проверьте корректность данных!","Auth Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка ввода! Введите пароль!","Input Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода! Введите логин!","Input Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void authForm_Load(object sender, EventArgs e)
        {

        }
    }
}
