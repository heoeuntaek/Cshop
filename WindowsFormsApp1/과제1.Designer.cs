namespace WindowsFormsApp1
{
    partial class 과제1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputName = new System.Windows.Forms.TextBox();
            this.outputAge = new System.Windows.Forms.TextBox();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.finalName = new System.Windows.Forms.Label();
            this.finalAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "나이";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "입력한 이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "입력한 나이";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "전송하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputName
            // 
            this.outputName.Location = new System.Drawing.Point(173, 107);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(100, 25);
            this.outputName.TabIndex = 2;
            this.outputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputAge
            // 
            this.outputAge.Location = new System.Drawing.Point(173, 252);
            this.outputAge.Name = "outputAge";
            this.outputAge.Size = new System.Drawing.Size(100, 25);
            this.outputAge.TabIndex = 2;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(173, 196);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(100, 25);
            this.inputAge.TabIndex = 2;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(173, 56);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 25);
            this.inputName.TabIndex = 2;
            this.inputName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // finalName
            // 
            this.finalName.AutoSize = true;
            this.finalName.Location = new System.Drawing.Point(302, 279);
            this.finalName.Name = "finalName";
            this.finalName.Size = new System.Drawing.Size(0, 15);
            this.finalName.TabIndex = 3;
            this.finalName.Click += new System.EventHandler(this.label5_Click);
            // 
            // finalAge
            // 
            this.finalAge.AutoSize = true;
            this.finalAge.Location = new System.Drawing.Point(302, 320);
            this.finalAge.Name = "finalAge";
            this.finalAge.Size = new System.Drawing.Size(0, 15);
            this.finalAge.TabIndex = 4;
            // 
            // 과제1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.finalAge);
            this.Controls.Add(this.finalName);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.outputAge);
            this.Controls.Add(this.outputName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "과제1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.과제1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputName;
        private System.Windows.Forms.TextBox outputAge;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label finalName;
        private System.Windows.Forms.Label finalAge;
    }
}