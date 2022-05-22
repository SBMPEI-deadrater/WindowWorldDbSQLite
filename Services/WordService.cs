using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowWorldDbSQLite.Database.Models;
using WindowWorldDbSQLite.Services.Interfaces;

namespace WindowWorldDbSQLite.Services
{
    public class WordService : IWordService
    {
        public bool CreateDocOrders(Dictionary<Type, List<Orders>> _dict, string _nameOrders = "")
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
