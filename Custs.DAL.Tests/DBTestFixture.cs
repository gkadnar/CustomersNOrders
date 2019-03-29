using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custs.DAL.Tests
{
    class DBTestFixture : IDisposable
    {
        public DBTestFixture()
        {
            Db = new SqlConnection("MyConnectionString");

            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
