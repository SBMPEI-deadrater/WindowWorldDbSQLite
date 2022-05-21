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
            if (!_context.Users.Any())
            {
                var items = new User[]
                {
                    new User
                    {
                        Id=1,
                        UserName = "admin",
                        Password = "admin",
                        Role = "admin",
                    },
                    new User
                    {
                        Id=2,
                        UserName = "user",
                        Password = "user",
                        Role = "user",
                    }
                };

                _context.Users.AddRange(items);
                _context.SaveChanges();
            }
        }
    }
}
