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
    class HistoryDAO
    {
        public void addHistory(Histories h)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            try
            {
                QuestionService qs = new QuestionService();
 
                conn.Open();
                string sql = String.Format("insert into histories(name_id,timefinish,score) values " +
                    "('{0}','{1}','{2}')",h.id,h.timefinish,h.score);


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader runquery;
                runquery = cmd.ExecuteReader();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}
