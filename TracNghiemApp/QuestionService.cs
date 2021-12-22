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
    class QuestionService
    {
        public List<Question> getQuestions(string kw = null)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            List<Question> questions = new List<Question>();
            string sql = "SELECT * FROM question ;";
            if(kw != null)
            {
                sql += " WHERE content like '%" + kw + "%';";
            }
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = reader.GetOrdinal("content");
                        string content  = reader.GetValue(index).ToString();
                        string a = reader.GetValue(reader.GetOrdinal("a")).ToString();
                        string b = reader.GetValue(reader.GetOrdinal("b")).ToString();
                        string c = reader.GetValue(reader.GetOrdinal("c")).ToString();
                        string d = reader.GetValue(reader.GetOrdinal("d")).ToString();
                        string result = reader.GetValue(reader.GetOrdinal("result")).ToString();
                        int cate_id =  Convert.ToInt32(reader.GetValue(reader.GetOrdinal("category_id")).ToString());
                        CategoryService categoryService = new CategoryService();
                        
                        Category category = categoryService.GetCategoryById(cate_id);
                        
                        questions.Add(new Question(content, a, b, c, d, result, category));
                    }
                }
            }
            return questions;
        }
        public List<Question> getQuestions(int cate_Id,string kw = null)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            List<Question> questions = new List<Question>();
            string sql = "SELECT * FROM question Where category_id=" + cate_Id + " ;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = reader.GetOrdinal("content");
                        string content = reader.GetValue(index).ToString();
                        string a = reader.GetValue(reader.GetOrdinal("a")).ToString();
                        string b = reader.GetValue(reader.GetOrdinal("b")).ToString();
                        string c = reader.GetValue(reader.GetOrdinal("c")).ToString();
                        string d = reader.GetValue(reader.GetOrdinal("d")).ToString();
                        string result = reader.GetValue(reader.GetOrdinal("result")).ToString();
                        int cate_id = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("category_id")).ToString());
                        CategoryService categoryService = new CategoryService();

                        Category category = categoryService.GetCategoryById(cate_id);

                        questions.Add(new Question(content, a, b, c, d, result, category));
                    }
                }
            }
            return questions;
        }
        public int GetIdQuestion(string kw)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            int id=0;
            string sql = String.Format("select id from question where content like '%{0}%'", kw);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = reader.GetOrdinal("id");
                         id = Convert.ToInt32(reader.GetValue(index).ToString());
                        break;
                    }
                }
            }
            return id;
        }

        public Question GetQuestion(int  id)
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();

            string sql = String.Format("select * from question where id = '%{0}%'", id);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            Question question = new Question();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int index = reader.GetOrdinal("content");
                        string content = reader.GetValue(index).ToString();
                        string a = reader.GetValue(reader.GetOrdinal("a")).ToString();
                        string b = reader.GetValue(reader.GetOrdinal("b")).ToString();
                        string c = reader.GetValue(reader.GetOrdinal("c")).ToString();
                        string d = reader.GetValue(reader.GetOrdinal("d")).ToString();
                        string result = reader.GetValue(reader.GetOrdinal("result")).ToString();
                        int cate_id = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("category_id")).ToString());
                        CategoryService categoryService = new CategoryService();

                        Category category = categoryService.GetCategoryById(cate_id);

                        question = new Question(content, a, b, c, d, result, category);
                    }
                }
            }
            return question;
        }

    }
}
