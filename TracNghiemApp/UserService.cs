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
    class UserService
    {
        public User getUserByName(string kw)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            List<Question> questions = new List<Question>();
            string sql = "SELECT * FROM question ;";

                sql += " WHERE content like '%" + kw + "%';";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            User user = new User();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int id =  Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id")));
                        string fullname = reader.GetValue(reader.GetOrdinal("fullname")).ToString();

                        user.id = id;
                        user.fullname = fullname;
                    }
                }
            }
            return user;
        }
    }
}
