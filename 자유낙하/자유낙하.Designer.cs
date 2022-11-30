namespace 자유낙하
{
    partial class 자유낙하
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
            this.lbScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(12, 425);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(53, 12);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "현재상태";
            this.lbScore.Click += new System.EventHandler(this.lbScore_Click);
            // 
            // 자유낙하
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.lbScore);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "자유낙하";
            this.Text = "자유낙하";
            this.Load += new System.EventHandler(this.자유낙하_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.자유낙하_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.자유낙하_KeyDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScore;
    }
}

