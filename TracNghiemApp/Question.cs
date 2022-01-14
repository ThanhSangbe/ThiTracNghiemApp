using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemApp
{
   public class Question
    {
        public string Content { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Result { get; set; }
        public Category category_id { get; set; }
        public Question() { }
        public Question(string content, string a, string b, string c, string d, string result, Category cate_Id)
        {
            this.Content = content;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.Result = result;
            this.category_id = cate_Id;
        }
        public Question(String content, string result, Category cate_id, List<String> choices)
        {
            this.Content = content;
            this.Result = result;
            this.category_id = cate_id;
            this.A = choices[0];
            this.B = choices[1];
            this.C = choices[2];
            this.D = choices[3];
        }

    }
}
