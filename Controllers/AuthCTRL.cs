using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services;
using Microsoft.EntityFrameworkCore;

namespace WindowWorldDbSQLite.Controllers
{
    /// <summary>
    /// Контроллер авторизации
    /// </summary>
    public class AuthCTRL
    {
        public User AuthToApp(string _username, string _password)
        {
            User user = null;
            EncryptionText et = new EncryptionText(); // SHA256

            try
            {
                //Проверка связки логин-пароль
                using (_ContextDb db = new _ContextDb())
                {
                    var res = db.Users.FirstOrDefault(x => x.UserName == _username && x.Password == et.ComputeSha256Hash(_password));
                    if (res != null) user = res;
                }
            }
            catch
            {
                return null;
            }

            return user;
        }
    }
}
