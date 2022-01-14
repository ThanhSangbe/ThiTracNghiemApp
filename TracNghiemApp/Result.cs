using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiemApp
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            initColunmListViewTop10();
            initTop10();
        }
        public Result(int result, double score):this()
        {
            txtResult.Text += String.Format(" {0}/30 Câu", result);
            txtScore.Text += String.Format(" {0:0.0} Điểm", score);
        }
        public void initTop10()
        {
            HistoryService historyDAO = new HistoryService();
            List<Histories> histories = historyDAO.getTop10();
            foreach(Histories item in histories)
            {
                ListViewItem listViewItem = new ListViewItem(item.fullname);
                listViewItem.SubItems.Add(item.timefinish);
                listViewItem.SubItems.Add(String.Format(" {0:0.00}", item.score));

                listTop.Items.Add(listViewItem);
            }
        }
        public void initColunmListViewTop10()
        {
            listTop.Columns.Add("Họ và tên", 200, HorizontalAlignment.Left);
            listTop.Columns.Add("Thời gian", 150, HorizontalAlignment.Left);
            listTop.Columns.Add("Điểm số", 100, HorizontalAlignment.Left);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
