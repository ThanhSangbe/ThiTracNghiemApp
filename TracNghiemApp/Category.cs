using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemApp
{
  public  class Category
    {
        public int id { get; set; }
        public string title { get; set; }
        public Category() { }
        public Category(int id,string title)
        {
            this.id = id;
            this.title = title;
        }
    }
}
