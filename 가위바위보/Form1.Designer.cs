namespace 가위바위보
{
    partial class 가위바위보
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(가위바위보));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.gawei = new System.Windows.Forms.Button();
            this.bawei = new System.Windows.Forms.Button();
            this.bo = new System.Windows.Forms.Button();
            this.Timer_View_Result = new System.Windows.Forms.Timer(this.components);
            this.btn_View_Result = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.GroupBox();
            this.lb_Me_Score = new System.Windows.Forms.Label();
            this.lb_Com_Score = new System.Windows.Forms.Label();
            this.lb_Draw_Score = new System.Windows.Forms.Label();
            this.lb_Total_Count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Me_S = new System.Windows.Forms.Label();
            this.lb_Me_R = new System.Windows.Forms.Label();
            this.lb_Me_P = new System.Windows.Forms.Label();
            this.lb_Com_S = new System.Windows.Forms.Label();
            this.lb_Com_R = new System.Windows.Forms.Label();
            this.lb_Com_P = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.lb_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "컴";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "나";
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(107, 38);
            this.PB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(121, 96);
            this.PB1.TabIndex = 1;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.Location = new System.Drawing.Point(107, 140);
            this.PB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(121, 91);
            this.PB2.TabIndex = 1;
            this.PB2.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(240, 164);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 15);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "결과";
            this.lbResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // gawei
            // 
            this.gawei.Font = new System.Drawing.Font("굴림", 20F);
            this.gawei.ForeColor = System.Drawing.Color.Red;
            this.gawei.Image = ((System.Drawing.Image)(resources.GetObject("gawei.Image")));
            this.gawei.Location = new System.Drawing.Point(11, 238);
            this.gawei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gawei.Name = "gawei";
            this.gawei.Size = new System.Drawing.Size(110, 88);
            this.gawei.TabIndex = 1;
            this.gawei.Text = "1";
            this.gawei.UseVisualStyleBackColor = true;
            this.gawei.Click += new System.EventHandler(this.button1_Click);
            // 
            // bawei
            // 
            this.bawei.Font = new System.Drawing.Font("굴림", 20F);
            this.bawei.ForeColor = System.Drawing.Color.Red;
            this.bawei.Image = ((System.Drawing.Image)(resources.GetObject("bawei.Image")));
            this.bawei.Location = new System.Drawing.Point(128, 238);
            this.bawei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bawei.Name = "bawei";
            this.bawei.Size = new System.Drawing.Size(109, 88);
            this.bawei.TabIndex = 2;
            this.bawei.Text = "2";
            this.bawei.UseVisualStyleBackColor = true;
            this.bawei.Click += new System.EventHandler(this.bawei_Click);
            // 
            // bo
            // 
            this.bo.Font = new System.Drawing.Font("굴림", 20F);
            this.bo.ForeColor = System.Drawing.Color.Red;
            this.bo.Image = ((System.Drawing.Image)(resources.GetObject("bo.Image")));
            this.bo.Location = new System.Drawing.Point(243, 238);
            this.bo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bo.Name = "bo";
            this.bo.Size = new System.Drawing.Size(97, 88);
            this.bo.TabIndex = 2;
            this.bo.Text = "3";
            this.bo.UseVisualStyleBackColor = true;
            this.bo.Click += new System.EventHandler(this.bo_Click);
            // 
            // Timer_View_Result
            // 
            this.Timer_View_Result.Tick += new System.EventHandler(this.Timer_View_Result_Tick);
            // 
            // btn_View_Result
            // 
            this.btn_View_Result.Location = new System.Drawing.Point(243, 192);
            this.btn_View_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_Result.Name = "btn_View_Result";
            this.btn_View_Result.Size = new System.Drawing.Size(75, 22);
            this.btn_View_Result.TabIndex = 3;
            this.btn_View_Result.Text = "결과보기";
            this.btn_View_Result.UseVisualStyleBackColor = true;
            this.btn_View_Result.Click += new System.EventHandler(this.btn_View_Result_Click);
            // 
            // lb_result
            // 
            this.lb_result.Controls.Add(this.lb_Me_P);
            this.lb_result.Controls.Add(this.lb_Me_R);
            this.lb_result.Controls.Add(this.lb_Com_P);
            this.lb_result.Controls.Add(this.lb_Com_R);
            this.lb_result.Controls.Add(this.lb_Com_S);
            this.lb_result.Controls.Add(this.lb_Me_S);
            this.lb_result.Controls.Add(this.label9);
            this.lb_result.Controls.Add(this.label8);
            this.lb_result.Controls.Add(this.label7);
            this.lb_result.Controls.Add(this.lb_Total_Count);
            this.lb_result.Controls.Add(this.lb_Draw_Score);
            this.lb_result.Controls.Add(this.lb_Com_Score);
            this.lb_result.Controls.Add(this.lb_Me_Score);
            this.lb_result.Location = new System.Drawing.Point(378, 13);
            this.lb_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_result.Name = "lb_result";
            this.lb_result.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_result.Size = new System.Drawing.Size(229, 327);
            this.lb_result.TabIndex = 4;
            this.lb_result.TabStop = false;
            this.lb_result.Text = "게임결과";
            this.lb_result.Enter += new System.EventHandler(this.lb_Draw_Score_Enter);
            // 
            // lb_Me_Score
            // 
            this.lb_Me_Score.AutoSize = true;
            this.lb_Me_Score.Location = new System.Drawing.Point(24, 38);
            this.lb_Me_Score.Name = "lb_Me_Score";
            this.lb_Me_Score.Size = new System.Drawing.Size(107, 15);
            this.lb_Me_Score.TabIndex = 0;
            this.lb_Me_Score.Text = "내가 이긴 횟수";
            this.lb_Me_Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Com_Score
            // 
            this.lb_Com_Score.AutoSize = true;
            this.lb_Com_Score.Location = new System.Drawing.Point(24, 70);
            this.lb_Com_Score.Name = "lb_Com_Score";
            this.lb_Com_Score.Size = new System.Drawing.Size(107, 15);
            this.lb_Com_Score.TabIndex = 0;
            this.lb_Com_Score.Text = "컴이 이긴 횟수";
            this.lb_Com_Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Draw_Score
            // 
            this.lb_Draw_Score.AutoSize = true;
            this.lb_Draw_Score.Location = new System.Drawing.Point(25, 99);
            this.lb_Draw_Score.Name = "lb_Draw_Score";
            this.lb_Draw_Score.Size = new System.Drawing.Size(72, 15);
            this.lb_Draw_Score.TabIndex = 0;
            this.lb_Draw_Score.Text = "비긴 횟수";
            this.lb_Draw_Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Total_Count
            // 
            this.lb_Total_Count.AutoSize = true;
            this.lb_Total_Count.Location = new System.Drawing.Point(24, 127);
            this.lb_Total_Count.Name = "lb_Total_Count";
            this.lb_Total_Count.Size = new System.Drawing.Size(92, 15);
            this.lb_Total_Count.TabIndex = 0;
            this.lb_Total_Count.Text = "총 게임 횟수";
            this.lb_Total_Count.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "-----------------------";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "나";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "컴";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Me_S
            // 
            this.lb_Me_S.AutoSize = true;
            this.lb_Me_S.Location = new System.Drawing.Point(24, 225);
            this.lb_Me_S.Name = "lb_Me_S";
            this.lb_Me_S.Size = new System.Drawing.Size(67, 15);
            this.lb_Me_S.TabIndex = 0;
            this.lb_Me_S.Text = "가위횟수";
            this.lb_Me_S.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Me_R
            // 
            this.lb_Me_R.AutoSize = true;
            this.lb_Me_R.Location = new System.Drawing.Point(24, 256);
            this.lb_Me_R.Name = "lb_Me_R";
            this.lb_Me_R.Size = new System.Drawing.Size(67, 15);
            this.lb_Me_R.TabIndex = 0;
            this.lb_Me_R.Text = "바위횟수";
            this.lb_Me_R.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Me_P
            // 
            this.lb_Me_P.AutoSize = true;
            this.lb_Me_P.Location = new System.Drawing.Point(24, 287);
            this.lb_Me_P.Name = "lb_Me_P";
            this.lb_Me_P.Size = new System.Drawing.Size(52, 15);
            this.lb_Me_P.TabIndex = 0;
            this.lb_Me_P.Text = "보횟수";
            this.lb_Me_P.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Com_S
            // 
            this.lb_Com_S.AutoSize = true;
            this.lb_Com_S.Location = new System.Drawing.Point(137, 225);
            this.lb_Com_S.Name = "lb_Com_S";
            this.lb_Com_S.Size = new System.Drawing.Size(67, 15);
            this.lb_Com_S.TabIndex = 0;
            this.lb_Com_S.Text = "가위횟수";
            this.lb_Com_S.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Com_R
            // 
            this.lb_Com_R.AutoSize = true;
            this.lb_Com_R.Location = new System.Drawing.Point(137, 256);
            this.lb_Com_R.Name = "lb_Com_R";
            this.lb_Com_R.Size = new System.Drawing.Size(67, 15);
            this.lb_Com_R.TabIndex = 0;
            this.lb_Com_R.Text = "바위횟수";
            this.lb_Com_R.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Com_P
            // 
            this.lb_Com_P.AutoSize = true;
            this.lb_Com_P.Location = new System.Drawing.Point(137, 287);
            this.lb_Com_P.Name = "lb_Com_P";
            this.lb_Com_P.Size = new System.Drawing.Size(52, 15);
            this.lb_Com_P.TabIndex = 0;
            this.lb_Com_P.Text = "보횟수";
            this.lb_Com_P.Click += new System.EventHandler(this.label1_Click);
            // 
            // 가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 353);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_View_Result);
            this.Controls.Add(this.bo);
            this.Controls.Add(this.bawei);
            this.Controls.Add(this.gawei);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "가위바위보";
            this.Text = "가위바위보";
            this.Load += new System.EventHandler(this.가위바위보_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.lb_result.ResumeLayout(false);
            this.lb_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button gawei;
        private System.Windows.Forms.Button bawei;
        private System.Windows.Forms.Button bo;
        private System.Windows.Forms.Timer Timer_View_Result;
        private System.Windows.Forms.Button btn_View_Result;
        private System.Windows.Forms.GroupBox lb_result;
        private System.Windows.Forms.Label lb_Me_P;
        private System.Windows.Forms.Label lb_Me_R;
        private System.Windows.Forms.Label lb_Me_S;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Total_Count;
        private System.Windows.Forms.Label lb_Draw_Score;
        private System.Windows.Forms.Label lb_Com_Score;
        private System.Windows.Forms.Label lb_Me_Score;
        private System.Windows.Forms.Label lb_Com_P;
        private System.Windows.Forms.Label lb_Com_R;
        private System.Windows.Forms.Label lb_Com_S;
    }
}

