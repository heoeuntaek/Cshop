using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가위바위보
{
    public partial class 가위바위보 : Form
    {
        public 가위바위보()
        {
            InitializeComponent();
        }

        bool result_view;  // 결과 보기 플래그
        int User_count = 0, Com_count = 0, Draw_count = 0;
        // 내가 승,              컴승                비김 수 

        int User_S = 0, User_R = 0, User_P = 0;  // 나의 가위 바위 보 수
        int Com_S = 0, Com_R = 0, Com_P = 0; // 컴의 가위 바위 보 수

        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        private void Timer_View_Result_Tick(object sender, EventArgs e)
        {
            int size = 20;
            if (!result_view)
            {
                if (Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기 ◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if (Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기 ▶";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Draw_Score_Enter(object sender, EventArgs e)
        {

        }

        private void 가위바위보_Load(object sender, EventArgs e)
        {

        }

        가위바위보DLL.가위바위보DLL A = new 가위바위보DLL.가위바위보DLL();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int my_num = 1;
            PB2.ImageLocation = "Images/gawei.jpg";

            Random rand = new Random();
            int com_num = rand.Next(1, 4);

            switch (com_num)
            {
                case 1:
                    Com_S++;
                    PB1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    Com_R++;
                    PB1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    Com_P++;
                    PB1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            switch (my_num)
            {
                case 1:
                    User_S++;
                    break;
                case 2:
                    User_R++;
                    break;
                case 3:
                    User_P++;
                    break;
                default:
                    break;
            }

            string result = A.check(com_num, my_num);
            lbResult.Text = result;

            switch (result)
            {
                case "내가 이김":
                    User_count++;
                    break;
                case "내가 짐":
                    Com_count++;
                    break;
                case "내가 비김":
                    Draw_count++;
                    break;
                default:
                    break;

            }

            lb_Me_Score.Text = "내가 이긴 횟수"+":" +User_count+ "번";
            lb_Com_Score.Text = "컴이 이긴  횟수"+":" + Com_count + "번";
            lb_Draw_Score.Text = "비긴 횟수"+":" + Draw_count+ "번";
            lb_Total_Count.Text = "총 게임 횟수"+":" + A.Count + "번";

            lb_Me_S.Text = "가위 수"+":" + User_S + "번";
            lb_Me_R.Text = "바위 수" + ":" + User_R + "번";
            lb_Me_P.Text = "보 수" + ":" + User_P + "번";

            lb_Com_S.Text = "가위 수" + ":" + Com_S + "번";
            lb_Com_R.Text = "바위 수" + ":" + Com_R + "번";
            lb_Com_P.Text = "보 수" + ":" + Com_P + "번";


        }

        private void bawei_Click(object sender, EventArgs e)
        {
            int my_num = 2;
            PB2.ImageLocation = "Images/bawei.jpg";


            Random rand = new Random();
            int com_num = rand.Next(1, 4);

            switch (com_num)
            {
                case 1:
                    Com_S++;
                    PB1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    Com_R++;
                    PB1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    Com_P++;
                    PB1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            switch (my_num)
            {
                case 1:
                    User_S++;
                    break;
                case 2:
                    User_R++;
                    break;
                case 3:
                    User_P++;
                    break;
                default:
                    break;
            }

            string result = A.check(com_num, my_num);
            lbResult.Text = result;

            switch (result)
            {
                case "내가 이김":
                    User_count++;
                    break;
                case "내가 짐":
                    Com_count++;
                    break;
                case "내가 비김":
                    Draw_count++;
                    break;
                default:
                    break;

            }

            lb_Me_Score.Text = "내가 이긴 횟수" + ":" + User_count + "번";
            lb_Com_Score.Text = "컴이 이긴  횟수" + ":" + Com_count + "번";
            lb_Draw_Score.Text = "비긴 횟수" + ":" + Draw_count + "번";
            lb_Total_Count.Text = "총 게임 횟수" + ":" + A.Count + "번";

            lb_Me_S.Text = "가위 수" + ":" + User_S + "번";
            lb_Me_R.Text = "바위 수" + ":" + User_R + "번";
            lb_Me_P.Text = "보 수" + ":" + User_P + "번";

            lb_Com_S.Text = "가위 수" + ":" + Com_S + "번";
            lb_Com_R.Text = "바위 수" + ":" + Com_R + "번";
            lb_Com_P.Text = "보 수" + ":" + Com_P + "번";
        }

        private void bo_Click(object sender, EventArgs e)
        {
            int my_num = 3;
            PB2.ImageLocation = "Images/bo.jpg";

            Random rand = new Random();
            int com_num = rand.Next(1, 4);

            switch (com_num)
            {
                case 1:
                    Com_S++;
                    PB1.ImageLocation = "Images/gawei.jpg";
                    break;
                case 2:
                    Com_R++;
                    PB1.ImageLocation = "Images/bawei.jpg";
                    break;
                case 3:
                    Com_P++;
                    PB1.ImageLocation = "Images/bo.jpg";
                    break;
            }

            switch (my_num)
            {
                case 1:
                    User_S++;
                    break;
                case 2:
                    User_R++;
                    break;
                case 3:
                    User_P++;
                    break;
                default:
                    break;
            }

            string result = A.check(com_num, my_num);
            lbResult.Text = result;

            switch (result)
            {
                case "내가 이김":
                    User_count++;
                    break;
                case "내가 짐":
                    Com_count++;
                    break;
                case "내가 비김":
                    Draw_count++;
                    break;
                default:
                    break;

            }

            lb_Me_Score.Text = "내가 이긴 횟수" + ":" + User_count + "번";
            lb_Com_Score.Text = "컴이 이긴  횟수" + ":" + Com_count + "번";
            lb_Draw_Score.Text = "비긴 횟수" + ":" + Draw_count + "번";
            lb_Total_Count.Text = "총 게임 횟수" + ":" + A.Count + "번";

            lb_Me_S.Text = "가위 수" + ":" + User_S + "번";
            lb_Me_R.Text = "바위 수" + ":" + User_R + "번";
            lb_Me_P.Text = "보 수" + ":" + User_P + "번";

            lb_Com_S.Text = "가위 수" + ":" + Com_S + "번";
            lb_Com_R.Text = "바위 수" + ":" + Com_R + "번";
            lb_Com_P.Text = "보 수" + ":" + Com_P + "번";
        }
    }


}

