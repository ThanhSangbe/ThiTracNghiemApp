
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
            this.button26 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(971, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đề thi trắc nghiệm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategory.Location = new System.Drawing.Point(12, 60);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(54, 21);
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
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 427);
            this.panel1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(476, 381);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 34);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Câu sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(111, 381);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(115, 34);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Câu trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(295, 381);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(115, 34);
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
            this.panel3.Location = new System.Drawing.Point(3, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 230);
            this.panel3.TabIndex = 1;
            // 
            // ChoiceD
            // 
            this.ChoiceD.AutoSize = true;
            this.ChoiceD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceD.Location = new System.Drawing.Point(14, 175);
            this.ChoiceD.Name = "ChoiceD";
            this.ChoiceD.Size = new System.Drawing.Size(114, 24);
            this.ChoiceD.TabIndex = 4;
            this.ChoiceD.TabStop = true;
            this.ChoiceD.Text = "radioButton1";
            this.ChoiceD.UseVisualStyleBackColor = true;
            // 
            // ChoiceC
            // 
            this.ChoiceC.AutoSize = true;
            this.ChoiceC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceC.Location = new System.Drawing.Point(14, 115);
            this.ChoiceC.Name = "ChoiceC";
            this.ChoiceC.Size = new System.Drawing.Size(114, 24);
            this.ChoiceC.TabIndex = 3;
            this.ChoiceC.TabStop = true;
            this.ChoiceC.Text = "radioButton1";
            this.ChoiceC.UseVisualStyleBackColor = true;
            // 
            // ChoiceB
            // 
            this.ChoiceB.AutoSize = true;
            this.ChoiceB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceB.Location = new System.Drawing.Point(14, 61);
            this.ChoiceB.Name = "ChoiceB";
            this.ChoiceB.Size = new System.Drawing.Size(114, 24);
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
            this.ChoiceA.Location = new System.Drawing.Point(14, 7);
            this.ChoiceA.Name = "ChoiceA";
            this.ChoiceA.Size = new System.Drawing.Size(114, 24);
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
            this.txtContent.Location = new System.Drawing.Point(3, 11);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(698, 131);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "Nội dung câu hỏi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(722, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 461);
            this.panel2.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.Indigo;
            this.txtTime.Location = new System.Drawing.Point(83, 78);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(83, 37);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "00:00";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thời gian làm bài";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(203, 323);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(31, 30);
            this.button26.TabIndex = 1;
            this.button26.Text = "25";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(203, 287);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(31, 30);
            this.button21.TabIndex = 1;
            this.button21.Text = "20";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(203, 251);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(31, 30);
            this.button16.TabIndex = 1;
            this.button16.Text = "15";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(203, 215);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 30);
            this.button11.TabIndex = 1;
            this.button11.Text = "10";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(203, 179);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 30);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(156, 323);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(31, 30);
            this.button25.TabIndex = 1;
            this.button25.Text = "24";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(156, 287);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(31, 30);
            this.button20.TabIndex = 1;
            this.button20.Text = "19";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(156, 251);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(31, 30);
            this.button15.TabIndex = 1;
            this.button15.Text = "14";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(156, 215);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 30);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(156, 179);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 30);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(109, 323);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(31, 30);
            this.button24.TabIndex = 1;
            this.button24.Text = "23";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(109, 287);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(31, 30);
            this.button19.TabIndex = 1;
            this.button19.Text = "18";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(109, 251);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(31, 30);
            this.button14.TabIndex = 1;
            this.button14.Text = "13";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(109, 215);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 30);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(109, 179);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 30);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(62, 323);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(31, 30);
            this.button23.TabIndex = 1;
            this.button23.Text = "22";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(62, 287);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(31, 30);
            this.button18.TabIndex = 1;
            this.button18.Text = "17";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(62, 251);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(31, 30);
            this.button13.TabIndex = 1;
            this.button13.Text = "12";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(62, 215);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 30);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(62, 179);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 30);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(15, 324);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(31, 30);
            this.button22.TabIndex = 1;
            this.button22.Text = "21";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(15, 288);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(31, 30);
            this.button17.TabIndex = 1;
            this.button17.Text = "16";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(15, 252);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 30);
            this.button12.TabIndex = 1;
            this.button12.Text = "11";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(15, 216);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 30);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(15, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 30);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
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
            this.txtName.Location = new System.Drawing.Point(355, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(361, 23);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Name";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 521);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Room";
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
    }
}