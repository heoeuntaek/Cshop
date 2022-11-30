using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch13_계산기
{
    public partial class 은택계산기 : Form
    {
        // 계산기에서 사용할  전역 변수 선언
        double num1, num2; // 두 수 저장할 변수  
        double numRest; //*, /  먼저 처리할 떄 *,/ 하지 않을나머지 수를 저장할 변수
        string buff = "";         // 임시 보관 할 변수
        string output = "";      // 임시 출력 할 변수
        char oper;               // 연산자 저장할 변수 + , - , * , /
        char oper2;            //2번쨰 연산자 저장할 변수 + , - , * , /
        double result;          // 결과 값 저장할 변수 
        // 3 + 8 = 11 계산일 경우 예를 들어 설명함

        public 은택계산기()
        {
            InitializeComponent();
        }

        private void Bt_num_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            // 숫자 키 중 어느 것이 눌러졌는지를 저장
            buff += btn.Text;           // 3    // 8
            output += btn.Text;       // 3    // 3 + 8
            textBox1.Text = output;  // 3    // 3 + 8
                                     //  buff=3, output=3, textbox1=3
                                     //  뒤에서 buff=0, output=3+, textbox1=3+  로 되어 있는 상태에서 8 입력하면
                                     //  buff=8, output=3+8, textbox1=3+8 이고 = 입력하면 [3] 으로 감

        }

        private void Bt_oper_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (num5 !=null) 
            {
                num4 = Convert.ToSingle(buff);
            }
            else
            {
                if (num4 != null)
                {

                }
            }
            else if(num)
            num1 = Convert.ToSingle(buff); // 3
            buff = "";                     // 0
            output += btn.Text;            // 3 + 
            textBox1.Text = output;        // 3 + 
            oper = btn.Text[0];            // +  
            // buff=3, num1=3, buff=0, output=3+, textbox1=3+, oper = +
            //다음에 8을 입력하면 다시[1] 앞 페이지 로 감

        }

        private void Bt_clear_Cick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            num1 = 0;
            num2 = 0;
            buff = "";
            output = "";
            result = 0.0;
        }

        private void Bt_calc_Click(object sender, MouseEventArgs e)
        {
            // num1=3, oper = +, buff=8,
            // output += btn.Text;      // 3    // 3 + 8
            // textBox1.Text = output;  // 3    // 3 + 8
            // 인 상태에서 = 이 입렫되면 btn에는 = 가 저장됨
            Button btn = (Button)sender;      // btn에는 = 가 저장됨
            num2 = Convert.ToInt32(buff);    // num2 =  8  buff(8)

            switch (oper)  // +
            {
                case '+': result = num1 + num2; break;  // result=11
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;


                case '/':
                    if (num2 == 0)
                    {
                        textBox1.Text = "0으로 나눌수 없음";
                        return;
                    }
                    result = num1 / num2; break;
            }
            //  btn에는 = 가 저장됨
            output += btn.Text + result.ToString();   //  =  결과값 
            textBox1.Text = output;
            buff = "";
            buff += result;
            // num2=8이고 result=3+8 btn(=)11,  
            // output=3+8 btn(=)11,Textbox1=3+8=11
        }
        private void 은택계산기_Load(object sender, EventArgs e)
        {
            textBox1.Text = output;

        }
    }
}
