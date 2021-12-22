using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TracNghiemApp
{
    class DBMySQLUtils
    {
        public static MySqlConnection getDBConnection()
        {
            String conn = String.Format("Server={0};Database={1};port={2};User Id={3};password={4}",
                "localhost","tracnghiemapp",3306,"root","123456");
            return new MySqlConnection(conn);
        }
    }
}
