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
    class QuestionDAO
    {
        public bool addQuestion(Question q)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            try
            {
                QuestionService qs = new QuestionService();
                
                conn.Open();
                string sql = String.Format("insert into question(content,a,b,c,d,result,category_id) values " +
                    "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", q.Content, q.A, q.B, q.C, q.D, q.Result, q.category_id.id);


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader runquery;
                runquery = cmd.ExecuteReader();
                MessageBox.Show("Thêm câu hỏi thành công","Chúc mừng",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public int getCoutQuestion()
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            string sql = "SELECT count(*) FROM question";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            int size=0;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = reader.GetOrdinal("count(*)");
                        size= Convert.ToInt32(reader.GetValue(index).ToString());
                    }
                }
            }
            return size;
        }
        public bool removeQuestion(int question)
        {
            try
            {
                MySqlConnection conn = DBMySQLUtils.getDBConnection();
                conn.Open();
                QuestionService questionService = new QuestionService();

                string sql = String.Format("delete from question where id = {0}", question);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader runquery;
                runquery = cmd.ExecuteReader();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool updateQuestion(string kw, Question question)
        {
            try
            {
                MySqlConnection conn = DBMySQLUtils.getDBConnection();
                conn.Open();
                QuestionService questionService = new QuestionService();
                int id = questionService.GetIdQuestion(kw);
                
                string sql = String.Format("update question set content = '{0}',a='{1}',b='{2}',c='{3}',d='{4}',result='{5}',category_id='{6}' where id='{7}'",
                question.Content,question.A,question.B,question.C,question.D,question.Result,question.category_id.id,id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader runquery;
                runquery = cmd.ExecuteReader();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
