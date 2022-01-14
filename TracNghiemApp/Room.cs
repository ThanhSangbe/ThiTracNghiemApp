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
    public partial class Room : Form
    {
        List<Question> listQuestion;
        List<SaveChoice> listSaveChoice;
        int QuestionCurrent=0;
        int sizeQuestion = 30;
        int Category_Id;
        public Room()
        {
            InitializeComponent();
           
        }
        public Room(String name, int cate_id):this()
        {
            txtName.Text += ": " + name;
            this.Category_Id = cate_id;
        }
        int minute = 45;
        int second = 00;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minute == 40 && second == 0)
            {
                string time1 = String.Format("{0}:{1}", minute, second);
                txtTime.Text = time1;
                minute -= 1; second = 60;
            }
            else
            {//00:00
                if (minute >= 0 && second == 0)
                {
                    minute -= 1; second = 60;
                }
                if (minute >= 0 && second > 0)
                {
                    second--;
                }
                if (minute == 0 && second == 0)
                {
                    timer1.Enabled = false;
                   
                }
                string minutes = "" + minute;
                if(minute<10)
                {
                    minutes = "0" + minute;
                }
                string seconds = "" + second;
                if (second < 10)
                {
                    seconds = "0" + second;
                }
                string time = String.Format("{0}:{1}", minutes, seconds);
                txtTime.Text = time;
                if(!timer1.Enabled)
                {
                    MessageBox.Show("Hết giờ!!!");
                }    
            }



        }
        
        //Init Question
        public void initQuestion()
        {
            
            QuestionService questionService = new QuestionService();
            List<Question> questions = questionService.getQuestions(this.Category_Id);
            listQuestion = new List<Question>();
            listSaveChoice = new List<SaveChoice>();
            HashSet<int> hasSet = new HashSet<int>();
            while (hasSet.Count() < sizeQuestion)
            {
                Random rand = new Random();
                int x = rand.Next(0, questions.Count());
                hasSet.Add(x);
            }
            foreach (int x in hasSet)
            {
                listQuestion.Add(questions[x]);
                listSaveChoice.Add(new SaveChoice(listSaveChoice.Count, questions[x].Result));
            }
        }
        public void WriteOneQuestion(List<Question> qu, int current) 
        {
            txtContent.Text = String.Format("Câu {0}: {1}", current+1, qu[current].Content);
            ChoiceA.Text = String.Format("A. {0}", qu[current].A);
            ChoiceB.Text = String.Format("B. {0}", qu[current].B);
            ChoiceC.Text = String.Format("C. {0}", qu[current].C);
            ChoiceD.Text = String.Format("D. {0}", qu[current].D);
            CheckChoice(listSaveChoice[current].YourChoice);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            saveChoice(QuestionCurrent);
            QuestionCurrent--;
            WriteOneQuestion(listQuestion, QuestionCurrent);
            if (QuestionCurrent != 0)
            {

                this.btnNext.Enabled = true;
            }
            else
            {
                this.btnPrevious.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // 2            3
            saveChoice(QuestionCurrent);
            QuestionCurrent++;
            WriteOneQuestion(listQuestion, QuestionCurrent);
            if (QuestionCurrent != sizeQuestion-1 )
            {
                this.btnPrevious.Enabled = true;
            }
            else
            {
                this.btnNext.Enabled = false;

            }
        }
        public void CheckChoice(string choice)
        {
            if(choice == null)
            {
                ChoiceA.Checked = ChoiceB.Checked = ChoiceC.Checked = ChoiceD.Checked = false;
            }
            else
            {
                switch (choice)
                {
                    case "A": ChoiceA.Checked = true;
                    break;
                    case "B": ChoiceB.Checked = true;
                    break;
                    case "C": ChoiceC.Checked = true;
                    break;
                    case "D": ChoiceD.Checked = true;
                    break;
                }
                
            }
        }
        public void saveChoice(int numberQuestion)
        {
            if (ChoiceA.Checked || ChoiceB.Checked || ChoiceC.Checked || ChoiceD.Checked)
            {
                if (ChoiceA.Checked)
                {
                    listSaveChoice[numberQuestion].YourChoice = "A";
                }
                else if (ChoiceB.Checked)
                {
                    listSaveChoice[numberQuestion].YourChoice = "B";
                }
                else if (ChoiceC.Checked)
                {
                    listSaveChoice[numberQuestion].YourChoice = "C";
                }
                else
                {
                    listSaveChoice[numberQuestion].YourChoice = "D";
                }
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;

            var result = SumScore();
            int results=0;
            double score=0;
            foreach(var item in result)
            {
                results = item.Key;
                score = item.Value;
                break;
            }
            Result re = new Result(results, score);
            UserService userService = new UserService();
            String name = txtName.Text.Substring(txtName.Text.LastIndexOf(':') + 1).Trim();
            User user = userService.getUserByName(name);
            string timeCurrent = getTime(txtTime.Text);
            Histories histories = new Histories(user.id,user.fullname,timeCurrent,score);
            HistoryDAO historyDAO = new HistoryDAO();
            historyDAO.addHistory(histories);
            re.ShowDialog();
            this.Hide();
        }
        public Dictionary<int,double> SumScore()
        {
            var x = new Dictionary<int, double>();
            int sum = 0;
            double result = 0;
            foreach (SaveChoice temp in listSaveChoice)
            {
                if (temp.Result == temp.YourChoice)
                {
                    sum ++;
                    result+= 0.33;
                }
            }
            x.Add(sum, result);
            return x;
        }
        public string getTime(String time)
        {
            
            int minute = 44;
            int second = 60;
            string[] timearr = time.Split(":");
            int minuteCurrent = Convert.ToInt32(timearr[0]); // 39:00
            int seccondCurrent = Convert.ToInt32(timearr[1]);
            minute = 44 - minuteCurrent;
            //10:00
            if (seccondCurrent != 0) //10:45
            {
                second = 60 - seccondCurrent;
            }
            if(minute == 0)
            {
                return String.Format("{0} Giây",second);
            }
            else if(second == 0)
            {
                return String.Format("{0} Phút", minute);
            }
            else 
            return String.Format("{0} Phút {1} Giây", minute, second);

        }

        private void Room_Load(object sender, EventArgs e)
        {
            initQuestion();
            WriteOneQuestion(listQuestion, QuestionCurrent);
            txtCategory.Text += listQuestion[0].category_id.title;
            btnPrevious.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            saveChoice(QuestionCurrent);
            QuestionCurrent = Convert.ToInt32(btn.Text) - 1;
            WriteOneQuestion(listQuestion, QuestionCurrent);
            
            if (QuestionCurrent == sizeQuestion - 1)
            {
                this.btnPrevious.Enabled = true;
                this.btnNext.Enabled = false;
            }
            else if(QuestionCurrent == 0)
            {
                this.btnPrevious.Enabled = false;
                this.btnNext.Enabled = true;

            }
            else
            {
                this.btnNext.Enabled = true;
                this.btnPrevious.Enabled = true;
            }

        }
    }
}
