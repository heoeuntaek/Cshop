namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.IbName = new System.Windows.Forms.Label();
            this.IbResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbName
            // 
            this.IbName.AutoSize = true;
            this.IbName.Location = new System.Drawing.Point(38, 69);
            this.IbName.Name = "IbName";
            this.IbName.Size = new System.Drawing.Size(37, 15);
            this.IbName.TabIndex = 0;
            this.IbName.Text = "이름";
            this.IbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // IbResult
            // 
            this.IbResult.AutoSize = true;
            this.IbResult.Location = new System.Drawing.Point(38, 117);
            this.IbResult.Name = "IbResult";
            this.IbResult.Size = new System.Drawing.Size(37, 15);
            this.IbResult.TabIndex = 1;
            this.IbResult.Text = "결과";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(46, 25);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "이름을 입력하세요";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(100, 117);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(46, 25);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(162, 69);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "출력하기";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(162, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.IbResult);
            this.Controls.Add(this.IbName);
            this.Name = "MainForm";
            this.Text = "ㅁ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbName;
        private System.Windows.Forms.Label IbResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnReset;
    }
}

