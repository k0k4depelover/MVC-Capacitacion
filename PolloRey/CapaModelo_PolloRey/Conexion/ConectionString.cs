using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_PolloRey.Conexion
{
    public abstract class ConectionString
    {
        public readonly string conectionString;
        public ConectionString()
        {
            conectionString = "Dsn=MYSQL_REMOTE";
        }

        protected OdbcConnection GetConnection()
        {
            return new OdbcConnection(conectionString);
        }
    }
}
