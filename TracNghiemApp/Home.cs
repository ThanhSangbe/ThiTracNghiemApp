using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace TracNghiemApp
{
    public partial class Home : Form
    {
        
       
        public Home()
        {
            InitializeComponent();
            CategoryService cate = new CategoryService();
            getCategory(listCategory);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string erro="";
            if(txtFullName.Text.Equals(""))
            {
                erro += "Vui lòng nhập tên của bạn\n";
            }
            if(listCategory.SelectedIndex<0)
            {
                erro += "Vui lòng chọn đề tài!";
            }
            if(!erro.Equals(""))
            {
                MessageBox.Show(erro, "Thông báo");
            }
            else
            {
                UserDAO userDAO = new UserDAO();
                userDAO.addUser(txtFullName.Text);
                Room room = new Room(txtFullName.Text, listCategory.SelectedIndex + 1);
                room.ShowDialog();
                this.Hide();
            }    
        }
        public void initTop10()
        {
            HistoryService historyDAO = new HistoryService();
            List<Histories> histories = historyDAO.getTop10();
            foreach (Histories item in histories)
            {
                ListViewItem listViewItem = new ListViewItem(item.fullname);
                listViewItem.SubItems.Add(item.timefinish);
                listViewItem.SubItems.Add(item.score.ToString());

                listTop.Items.Add(listViewItem);
            }
        }
        public void initColunmListViewTop10()
        {
            listTop.Columns.Add("Họ và tên", 194, HorizontalAlignment.Left);
            listTop.Columns.Add("Thời gian", 70, HorizontalAlignment.Left);
            listTop.Columns.Add("Điểm số", 70, HorizontalAlignment.Left);
        }
        public void getCategory(ComboBox cbx)
        {
            CategoryService service = new CategoryService();
            List<Category> categories = service.getCategories();
            foreach (Category c in categories)
            {
                cbx.Items.Add(c.title);
            }
        }
    }
}
