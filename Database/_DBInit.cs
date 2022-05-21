using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services;

namespace WindowWorldDbSQLite.Database
{
    public interface IDBInit
    {
        void DefaultGeneration();
    }
    public class DBInit: IDBInit
    {
        private readonly _ContextDb _context;

        public DBInit(_ContextDb context)
        {
            _context = context;
        }

        public void DefaultGeneration()
        {
            string str_init_by = "Install Wizard";
            EncryptionText et = new EncryptionText();

            if (!_context.Users.Any())
            {
                var items = new User[]
                {
                    new User
                    {
                        Id=1,
                        UserName = "admin",
                        Password = et.ComputeSha256Hash("admin"),
                        Role = "admin",
                        CreatedBy=str_init_by,
                        UpdatedBy=str_init_by,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=DateTime.Now
                    },
                    new User
                    {
                        Id=2,
                        UserName = "user",
                        Password = et.ComputeSha256Hash("user"),
                        Role = "user",
                        CreatedBy = str_init_by,
                        UpdatedBy = str_init_by,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now
                    }
                };

                _context.Users.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}
