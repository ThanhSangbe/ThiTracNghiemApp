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
    class HistoryService
    {
        public List<Histories> getTop10()
        {
            List<Histories> histories = new List<Histories>();
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            string sql = "SELECT * FROM histories, users where users.id = histories.name_id LIMIT 10 ORDER BY score DESC";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            List<Category> categories = new List<Category>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        /*                       int index = reader.GetOrdinal("title");

                                               categories.Add(new Category(Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id"))), reader.GetValue(index).ToString()));
                       */
                        int id =Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id")));
                        string fullname = reader.GetValue(reader.GetOrdinal("fullname")).ToString();
                        string timefinish = reader.GetValue(reader.GetOrdinal("timefinish")).ToString();
                        int score = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("score")));
                        histories.Add(new Histories(id, fullname, timefinish, score));
                    }
                }
            }
            return histories;
        }
    }
}
