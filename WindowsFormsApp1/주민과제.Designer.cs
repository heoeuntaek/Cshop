namespace WindowsFormsApp1
{
    partial class 주민과제
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
            this.txtJuminOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJuminTwo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtJuminOne
            // 
            this.txtJuminOne.Location = new System.Drawing.Point(113, 84);
            this.txtJuminOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJuminOne.Name = "txtJuminOne";
            this.txtJuminOne.Size = new System.Drawing.Size(114, 25);
            this.txtJuminOne.TabIndex = 0;
            this.txtJuminOne.TextChanged += new System.EventHandler(this.txtJuminOne_TextChanged);
            this.txtJuminOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuminOne_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "주민번호 입력";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // txtJuminTwo
            // 
            this.txtJuminTwo.Location = new System.Drawing.Point(254, 84);
            this.txtJuminTwo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJuminTwo.Name = "txtJuminTwo";
            this.txtJuminTwo.Size = new System.Drawing.Size(114, 25);
            this.txtJuminTwo.TabIndex = 0;
            this.txtJuminTwo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtJuminTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuminTwo_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(123, 130);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "생년월일";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(112, 192);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(53, 25);
            this.txtYear.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "년";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(199, 192);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(53, 25);
            this.txtMonth.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "월";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(286, 192);
            this.txtDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(53, 25);
            this.txtDay.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "일";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "성별";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(112, 251);
            this.txtSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(53, 25);
            this.txtSex.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "나이";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(112, 298);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(53, 25);
            this.txtAge.TabIndex = 0;
            // 
            // 주민과제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 451);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJuminTwo);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtJuminOne);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "주민과제";
            this.Text = "주민과제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJuminOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJuminTwo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAge;
    }
}