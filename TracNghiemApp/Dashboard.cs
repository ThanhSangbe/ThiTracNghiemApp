using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace TracNghiemApp
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
            getCategory(cbxCategories);
            getQuestions();
        }

        private void button4_Click(object sender, EventArgs e)//SEARCH
        {

        }

        private void button1_Click(object sender, EventArgs e)//SAVE
        {
            string erro = checkInvalidate();
            if(!erro.Equals(""))
            {
                MessageBox.Show(erro, "Cảnh báo",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                string content = txtContent.Text;
                string choiceA = a.Text;
                string choiceB = b.Text;
                string choiceC = c.Text;
                string choiceD = d.Text;
                string result = cbxResult.SelectedItem.ToString();
                int category_id = cbxCategories.SelectedIndex + 1;
                CategoryService categoryService = new CategoryService();
                Category category = categoryService.GetCategoryById(category_id);
                Question question = new Question(content, choiceA, choiceB, choiceC, choiceD, result, category);

                QuestionDAO dao = new QuestionDAO();

                bool isFinish = dao.addQuestion(question);
                if(isFinish)
                {
                    refeshQuestion();
                }
                txtContent.Text = a.Text = b.Text = c.Text = d.Text = "";
                cbxCategories.SelectedIndex = -1;
                cbxResult.SelectedIndex = -1;
            }
        }

        //init Categories
        public void getCategory(ComboBox cbx)
        {
            CategoryService service = new CategoryService();
            List<Category> categories = service.getCategories();
            foreach(Category c in categories)
            {
                cbx.Items.Add(c.title);
            }
        }

        //init listview Question
        public void getQuestions()
        {
            listQuestions.Columns.Add("Nội dung", 319, HorizontalAlignment.Left);
            listQuestions.Columns.Add("Đáp án A", 120, HorizontalAlignment.Left);
            listQuestions.Columns.Add("Đáp án B", 120, HorizontalAlignment.Left);
            listQuestions.Columns.Add("Đáp án C", 120, HorizontalAlignment.Left);
            listQuestions.Columns.Add("Đáp án D", 120, HorizontalAlignment.Left);
            listQuestions.Columns.Add("Môn", 120, HorizontalAlignment.Left);
            listQuestions.Columns.Add("Kết quả", 52, HorizontalAlignment.Left);


            refeshQuestion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string content = txtContent.Text;
            string choiceA = a.Text;
            string choiceB = b.Text;
            string choiceC = c.Text;
            string choiceD = d.Text;
            string result = cbxResult.SelectedItem.ToString();
            int category_id = cbxCategories.SelectedIndex + 1;
            CategoryService categoryService = new CategoryService();
            Category category = categoryService.GetCategoryById(category_id);
            Question question = new Question(content, choiceA, choiceB, choiceC, choiceD, result, category);

            QuestionDAO dao = new QuestionDAO();

            bool isFinish = dao.updateQuestion(question.Content,question);
            if (isFinish)
            {
                MessageBox.Show("Cập nhật thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refeshQuestion();
            }
            txtContent.Text = a.Text = b.Text = c.Text = d.Text = "";
            cbxCategories.SelectedIndex = cbxResult.SelectedIndex = -1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn xóa chưa?", "Xác nhận", MessageBoxButtons.YesNo))
            {
                QuestionService questionService = new QuestionService();
                int id = questionService.GetIdQuestion(txtContent.Text);
                QuestionDAO questionDAO = new QuestionDAO();
                bool isDeleted = questionDAO.removeQuestion(id);
                if (isDeleted)
                {
                    MessageBox.Show("Xóa thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refeshQuestion();
            }
        }

        public String checkInvalidate()
        {
            string erro = "";
            if(txtContent.Text.Equals(""))
            {
                erro += "Chưa nhập nội dung câu hỏi\n";
            }
            if(a.Text.Equals(""))
            {
                erro += "Chưa nhập câu trả lời A\n";
            }
            if (b.Text.Equals(""))
            {
                erro += "Chưa nhập câu trả lời B\n";
            }
            if (c.Text.Equals(""))
            {
                erro += "Chưa nhập câu trả lời C\n";
            }
            if (d.Text.Equals(""))
            {
                erro += "Chưa nhập câu trả lời D\n";
            }
            return erro;
        }

        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listQuestions.SelectedItems.Count >0)
            {
                txtContent.Text = listQuestions.SelectedItems[0].Text;
                a.Text = listQuestions.SelectedItems[0].SubItems[1].Text;
                b.Text = listQuestions.SelectedItems[0].SubItems[2].Text;
                c.Text = listQuestions.SelectedItems[0].SubItems[3].Text;
                d.Text = listQuestions.SelectedItems[0].SubItems[4].Text;
                cbxResult.SelectedItem = listQuestions.SelectedItems[0].SubItems[6].Text;
                cbxCategories.SelectedItem = listQuestions.SelectedItems[0].SubItems[5].Text;
            }
        }
        public void refeshQuestion()
        {
            listQuestions.Items.Clear();
            List<Question> questions = new List<Question>();
            QuestionService questionService = new QuestionService();
            questions = questionService.getQuestions();
            foreach (Question q in questions)
            {
                ListViewItem item = new ListViewItem(q.Content);
                item.SubItems.Add(q.A);
                item.SubItems.Add(q.B);
                item.SubItems.Add(q.C);
                item.SubItems.Add(q.D);
                item.SubItems.Add(q.category_id.title);
                item.SubItems.Add(q.Result.ToUpper());

                listQuestions.Items.Add(item);
            }
        }
        public void refeshQuestion(string kw)
        {
            listQuestions.Items.Clear();
            List<Question> questions = new List<Question>();
            QuestionService questionService = new QuestionService();
            questions = questionService.getQuestions(kw);
            foreach (Question q in questions)
            {
                ListViewItem item = new ListViewItem(q.Content);
                item.SubItems.Add(q.A);
                item.SubItems.Add(q.B);
                item.SubItems.Add(q.C);
                item.SubItems.Add(q.D);
                item.SubItems.Add(q.category_id.title);
                item.SubItems.Add(q.Result.ToUpper());

                listQuestions.Items.Add(item);
            }
        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
                refeshQuestion(txtSearch.Text);
            else
                refeshQuestion();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtContent.Text = a.Text = b.Text = c.Text = d.Text = "";
            cbxCategories.SelectedIndex = -1;
            cbxResult.SelectedIndex = -1;
        }

        private void btnThemBangFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel file (*.xlsx)|*.xlsx";
            string src = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                src += dlg.FileName;
            }
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@src);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            //Mo file 
;
            List<Question> questions = new List<Question>();
            // Lay sheet dau tien de thao tac

            for(int i = 2; i<= rowCount; i++)
            {
               


                    try
                    {
                        int j = 1;
                        Question q = new Question();
                        q.Content = xlRange.Cells[i, j++].Value2.ToString();
                        q.A = xlRange.Cells[i, j++].Value2.ToString();
                        q.B = xlRange.Cells[i, j++].Value2.ToString();
                        q.C = xlRange.Cells[i, j++].Value2.ToString();
                        q.D = xlRange.Cells[i, j++].Value2.ToString();
                        q.Result = xlRange.Cells[i, j++].Value2.ToString();
                        Category c = new Category();
                        c.id = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString());

                        q.category_id = c;
                        questions.Add(q);
                    }
                    catch
                    {
                        MessageBox.Show("Đọc file không được");
                    }
                
                
            }
            QuestionDAO questionDAO = new QuestionDAO();
            questionDAO.addQuestion(null,questions);
            
        }
    }
}
