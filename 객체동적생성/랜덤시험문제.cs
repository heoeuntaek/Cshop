using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 객체동적생성
{
    public partial class 랜덤시험문제 : Form
    {
        GroupBox[] GB = new GroupBox[2]; // 그룹 박스 2문제
        RadioButton[,] Bogi = new RadioButton[2, 5];  // 보기 5개
        Label[] Quiz = new Label[2];            // 2 문제
        Label lbScore = new Label();     // 점수 표시 Label  
        Button button = new Button();  // Button 
        int Score = 0;

        public 랜덤시험문제()
        {
            InitializeComponent();
            string aa = "[문제 ";   // 1]  은 소스에서 추가 해야 함
            string[,] Question = new string[2, 6] {
               {"다음중 1+1 = ?","일","이","삼","사","이" },
               {"인천에 있는 산은 ?","한라산","백두산","계양산" ,"금강산","계양산" }
            };
            //# regiton
            //lbScore = new Label();
            this.lbScore.Name = "IbScore";
            this.lbScore.Text = "Score : ";
            this.lbScore.Size = new Size(90, 30);
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(30, 370);
            this.Controls.Add(lbScore);
            //#endregion

            this.button.Name = "btnSubmit";
            this.button.Text = "채점하기";
            this.button.Size = new Size(90, 30);
            this.button.AutoSize = true;
            this.button.Location = new System.Drawing.Point(180, 370);
            this.button.Click += new EventHandler(button_Click);
            this.Controls.Add(button);

            for (int n = 0; n < GB.Length; n++)
            {
                GB[n] = new GroupBox();
                this.GB[n].AutoSize = true;
                this.GB[n].Location = new System.Drawing.Point(10, 10 + (n * 150));
                this.GB[n].Size = new System.Drawing.Size(300, 120);
                this.GB[n].TabIndex = 0;
                this.GB[n].TabStop = false;
                this.GB[n].Text = aa + (n + 1) + "]" + Question[n, 0];  //문제1에서 뒷]추가
                this.Controls.Add(GB[n]);

                for (int i = 0; i < 4; i++)
                {
                    Bogi[n, i] = new RadioButton();
                    this.Bogi[n, i].Location = new System.Drawing.Point(30, 30 + (i * 20));
                    this.Bogi[n, i].Size = new System.Drawing.Size(100, 20);
                    this.Bogi[n, i].Text = Question[n, i + 1];

                    if (i == 4) Bogi[n, 4].Visible = false;
                    this.Controls.Add(Bogi[n, i]);
                    this.GB[n].Controls.Add(this.Bogi[n, i]);
                }
            }



        }
        void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)

                {
                    //답 맞으면 카운트 증가}
                    if (Bogi[i, j].Checked == true|| (Bogi[i, j].Checked == true))
                    {
                        Score++;
                    }

                  

                }
                lbScore.Text = "Score : " + Convert.ToString(Score);
            }
        }

        private void 랜덤시험문제_Load(object sender, EventArgs e)
        {

        }
    }
}
