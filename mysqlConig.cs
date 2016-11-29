using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.Entity;

namespace EntifyForm
{
    public class mysqlConig : DbConfiguration
    {
        public mysqlConig()
        {
            SetHistoryContext("MySql.Data.MySqlClient",
                (conn, shema) => new MySqlHistoryContext(conn, shema));
        }
    }
}
