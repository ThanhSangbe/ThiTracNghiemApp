using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemApp
{
   public class Histories
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string timefinish { get; set; }
        public int score { get; set; }
        public Histories() { }
        public Histories(int id,string fullname, string time, int score)
        {
            this.id = id;
            this.fullname = fullname;
            this.score = score;
            this.timefinish = time;
        }

    }
}
