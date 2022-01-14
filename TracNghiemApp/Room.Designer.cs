
namespace TracNghiemApp
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChoiceD = new System.Windows.Forms.RadioButton();
            this.ChoiceC = new System.Windows.Forms.RadioButton();
            this.ChoiceB = new System.Windows.Forms.RadioButton();
            this.ChoiceA = new System.Windows.Forms.RadioButton();
            this.txtContent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1110, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đề thi trắc nghiệm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategory.Location = new System.Drawing.Point(14, 80);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(68, 28);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.Text = "Dạng: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Location = new System.Drawing.Point(14, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 569);
            this.panel1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(544, 508);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 45);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Câu sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(127, 508);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(131, 45);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Câu trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(337, 508);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(131, 45);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "Nộp bài";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ChoiceD);
            this.panel3.Controls.Add(this.ChoiceC);
            this.panel3.Controls.Add(this.ChoiceB);
            this.panel3.Controls.Add(this.ChoiceA);
            this.panel3.Location = new System.Drawing.Point(3, 193);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 307);
            this.panel3.TabIndex = 1;
            // 
            // ChoiceD
            // 
            this.ChoiceD.AutoSize = true;
            this.ChoiceD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceD.Location = new System.Drawing.Point(16, 233);
            this.ChoiceD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoiceD.Name = "ChoiceD";
            this.ChoiceD.Size = new System.Drawing.Size(143, 29);
            this.ChoiceD.TabIndex = 4;
            this.ChoiceD.TabStop = true;
            this.ChoiceD.Text = "radioButton1";
            this.ChoiceD.UseVisualStyleBackColor = true;
            // 
            // ChoiceC
            // 
            this.ChoiceC.AutoSize = true;
            this.ChoiceC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceC.Location = new System.Drawing.Point(16, 153);
            this.ChoiceC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoiceC.Name = "ChoiceC";
            this.ChoiceC.Size = new System.Drawing.Size(143, 29);
            this.ChoiceC.TabIndex = 3;
            this.ChoiceC.TabStop = true;
            this.ChoiceC.Text = "radioButton1";
            this.ChoiceC.UseVisualStyleBackColor = true;
            // 
            // ChoiceB
            // 
            this.ChoiceB.AutoSize = true;
            this.ChoiceB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceB.Location = new System.Drawing.Point(16, 81);
            this.ChoiceB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(143, 29);
            this.ChoiceB.TabIndex = 2;
            this.ChoiceB.TabStop = true;
            this.ChoiceB.Text = "radioButton1\r\n";
            this.ChoiceB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChoiceB.UseVisualStyleBackColor = true;
            // 
            // ChoiceA
            // 
            this.ChoiceA.AutoSize = true;
            this.ChoiceA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceA.Location = new System.Drawing.Point(16, 9);
            this.ChoiceA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(143, 29);
            this.ChoiceA.TabIndex = 1;
            this.ChoiceA.TabStop = true;
            this.ChoiceA.Text = "radioButton1";
            this.ChoiceA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChoiceA.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContent.Location = new System.Drawing.Point(3, 15);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(798, 175);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "Nội dung câu hỏi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(825, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 615);
            this.panel2.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.Indigo;
            this.txtTime.Location = new System.Drawing.Point(95, 104);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(99, 46);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "00:00";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(67, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thời gian làm bài";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(232, 479);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "30";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button26_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(232, 431);
            this.button26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(35, 40);
            this.button26.TabIndex = 1;
            this.button26.Text = "25";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(232, 383);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 40);
            this.button21.TabIndex = 1;
            this.button21.Text = "20";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button26_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(232, 335);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 40);
            this.button16.TabIndex = 1;
            this.button16.Text = "15";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button26_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(232, 287);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 40);
            this.button11.TabIndex = 1;
            this.button11.Text = "10";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(232, 239);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 40);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button26_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 479);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "29";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(178, 431);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(35, 40);
            this.button25.TabIndex = 1;
            this.button25.Text = "24";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button26_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(178, 383);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 40);
            this.button20.TabIndex = 1;
            this.button20.Text = "19";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button26_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(178, 335);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 40);
            this.button15.TabIndex = 1;
            this.button15.Text = "14";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(178, 287);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 40);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(178, 239);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 40);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button26_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 479);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "28";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button26_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(125, 431);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(35, 40);
            this.button24.TabIndex = 1;
            this.button24.Text = "23";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button26_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(125, 383);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 40);
            this.button19.TabIndex = 1;
            this.button19.Text = "18";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button26_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(125, 335);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 40);
            this.button14.TabIndex = 1;
            this.button14.Text = "13";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(125, 287);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 40);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(125, 239);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 40);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button26_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 479);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "27";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button26_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(71, 431);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(35, 40);
            this.button23.TabIndex = 1;
            this.button23.Text = "22";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button26_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(71, 383);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(35, 40);
            this.button18.TabIndex = 1;
            this.button18.Text = "17";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button26_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(71, 335);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 40);
            this.button13.TabIndex = 1;
            this.button13.Text = "12";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(71, 287);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 40);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(71, 239);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button26_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 480);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "26";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button26_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(17, 432);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(35, 40);
            this.button22.TabIndex = 1;
            this.button22.Text = "21";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button26_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(17, 384);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 40);
            this.button17.TabIndex = 1;
            this.button17.Text = "16";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button26_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(17, 336);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 40);
            this.button12.TabIndex = 1;
            this.button12.Text = "11";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(17, 288);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 40);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button26_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 240);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 40);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button26_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(82, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sơ đồ câu hỏi";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(825, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 31);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 695);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton ChoiceD;
        private System.Windows.Forms.RadioButton ChoiceC;
        private System.Windows.Forms.RadioButton ChoiceB;
        private System.Windows.Forms.RadioButton ChoiceA;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}