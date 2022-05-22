using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WindowWorldDbSQLite.Database;

namespace WindowWorldDbSQLite.Services.Interfaces
{
    internal interface ISettingsDatabase: IDisposable
    {
        bool BackupSQLiteDbToDesktop(string _path);
        DbContextOptions<_ContextDb> GetDbContextOptions();
        //string GetDbConnectionString();
    }
}
