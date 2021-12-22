using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Windows.Forms;
namespace TracNghiemApp
{
    class LevelService
    {
        public void getLevel(ComboBox list)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            string sql = "SELECT title FROM levels";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = reader.GetOrdinal("title");
                        list.Items.Add(reader.GetValue(index));
                    }
                }
            }
        }
    }
}
