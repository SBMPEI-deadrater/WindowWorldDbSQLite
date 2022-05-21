using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowWorldDbSQLite.Services.Interfaces
{
    public interface IFaceEncryptionText: IDisposable
    {
        string ComputeSha256Hash(string s);
    }
}
