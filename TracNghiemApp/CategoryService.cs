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
    class CategoryService
    {
        public List<Category> getCategories()
        {
            MySqlConnection conn = DBMySQLUtils.getDBConnection();
            conn.Open();
            string sql = "SELECT * FROM category";
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
                        int index = reader.GetOrdinal("title");
                        categories.Add(new Category(Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id"))),reader.GetValue(index).ToString()));
                    }
                }
            }
            return categories;
        }
        public Category GetCategoryById(int index)
        {
            List<Category> categories = getCategories();
            Category category = new Category();
            foreach (Category cate in categories)
            {
                if (cate.id == index)
                {
                    category.id = index;
                    category.title = cate.title;
                }

            }
            return category;
        }
    }
}
