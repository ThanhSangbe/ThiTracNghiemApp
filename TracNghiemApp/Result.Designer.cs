
namespace TracNghiemApp
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listTop = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết quả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listTop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(504, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 380);
            this.panel2.TabIndex = 8;
            // 
            // listTop
            // 
            this.listTop.HideSelection = false;
            this.listTop.Location = new System.Drawing.Point(3, 43);
            this.listTop.Name = "listTop";
            this.listTop.Size = new System.Drawing.Size(436, 334);
            this.listTop.TabIndex = 2;
            this.listTop.UseCompatibleStateImageBehavior = false;
            this.listTop.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(383, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Top 10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 380);
            this.panel1.TabIndex = 9;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(127, 171);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(99, 30);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "Số điểm: ";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(127, 129);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(86, 30);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "Số câu: ";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 84);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chúc mừng bạn đã hoàn thành bài thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button26.Location = new System.Drawing.Point(160, 252);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(167, 43);
            this.button26.TabIndex = 1;
            this.button26.Text = "Đồng ý";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Label label2;
    }
}