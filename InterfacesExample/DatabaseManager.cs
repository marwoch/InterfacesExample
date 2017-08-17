using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    //Pretending this class manages a db connection
    class DatabaseManager : IDisposable
    {
        public void OpenConnection()
        {
            //code inside to open db
        }

        public void CloseConnection()
        {
            //code inside to close connection to db
        }

        public void Dispose()
        {
            CloseConnection();
            //clean up all unmanaged resources here.
        }
    }
}
