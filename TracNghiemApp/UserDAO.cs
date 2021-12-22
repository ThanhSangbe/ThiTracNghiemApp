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
    class UserDAO
    {
        public void addUser(string fullname)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            try
            {
                QuestionService qs = new QuestionService();

                conn.Open();
                string sql = String.Format("insert into users(fullname) values " +
                    "('{0}')", fullname);


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
