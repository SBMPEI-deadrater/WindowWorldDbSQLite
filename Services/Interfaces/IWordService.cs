using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database.Models;

namespace WindowWorldDbSQLite.Services.Interfaces
{
    internal interface IWordService: IDisposable
    {
        bool CreateDocOrders(Dictionary<Type, List<Orders>> _dict, string _nameOrders = "");
    }
}
