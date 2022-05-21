using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowWorldDbSQLite.Services.Interfaces
{
    internal interface IFaceBackupDatabase: IDisposable
    {
        bool BackupSQLiteDbToDesktop(string _path);
    }
}
