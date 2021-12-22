using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemApp
{
   public class SaveChoice
    {
        public int NumberQuestion { get; set; }
        public string Result { get; set; }
        public string YourChoice { get; set; }
        public SaveChoice() { }
        public SaveChoice(int num, string Result)
        {
            this.NumberQuestion = num;
            this.Result = Result;
            this.YourChoice = null;
        }
    }
}
