using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPF_DEMO_QLNT
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = Constant._SERVER_NAME_;

            string database = Constant._DBNAME_;
            string username = Constant._USERNAME_;
            string password = Constant._PASSWORD_;

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
