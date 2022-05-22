using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Services.Interfaces;

namespace WindowWorldDbSQLite.Services
{
    internal class SettingsDatabase : ISettingsDatabase
    {
        public bool BackupSQLiteDbToDesktop(string _path)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
