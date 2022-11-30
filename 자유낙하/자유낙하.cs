using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 자유낙하
{
    public partial class 자유낙하: Form
    {
        private Point B;
        private Point R;
        private Point Y;
        private Point BL;

        double distanceR;   //검은공과의 거리
        double distanceY;
        double distanceBL;
        int score;

        Random random = new Random();


        public 자유낙하()
        {
            InitializeComponent();
            B.X = 150;
            B.Y = 400;

            R.X = 50;
            R.Y = 50;

            BL.X = 250;
            BL.Y = 70;

            Y.X = 100;
            Y.Y = 200;

            //초기 좌표 지정




        }

       

        private void 자유낙하_Paint_1(object sender, PaintEventArgs e)
        {
            // 공 그리기
            e.Graphics.FillEllipse(Brushes.Black, B.X, B.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Red, R.X, R.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Yellow, Y.X, Y.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Blue, BL.X, BL.Y, 40, 40);
        }

        private void 자유낙하_Load(object sender, EventArgs e)
        {

            //검정, 파랑, 노란 공 왔다갔다 쓰레드
            Thread myThread = new Thread(Rfun);
            myThread.IsBackground = true;
            myThread.Start();

            Thread myThread2 = new Thread(BLfun);
            myThread2.IsBackground = true;
            myThread2.Start();

            Thread myThread3 = new Thread(Yfun);
            myThread3.IsBackground = true;
            myThread3.Start();



            //충돌 쓰레드
            ThreadStart ts = new ThreadStart(Func);
            Thread worker = new Thread(ts);

            worker.IsBackground = true;
            worker.Start();



        }

        private void Yfun()
        {
            bool down = true;
            //true - 내려감
            //     false -올라감

            while (true)
            {

                if (Y.Y >= 400) down = false;
                else if (Y.Y <= 50) down = true;

                if (down)
                {
                    Y.Y += 10;
                }
                else if (!down)  //내려감
                {
                    Y.Y -= 10;
                }



                Thread.Sleep(30);
                Invalidate();
            }
        }

        private void BLfun()
        {
            bool down = true;

            while (true)
            {

                if (BL.Y >= 400) down = false;
                else if (BL.Y <= 50) down = true;

                if (down)
                {
                    BL.Y += 10;
                }
                else if (!down)
                {
                    BL.Y -= 10;
                }



                Thread.Sleep(30);
                Invalidate();
            }
        }

        public void Func()
        {

            while (score != 5)
            {
                //검은 공과의 거리 공식 (충돌공식)
                distanceR = Math.Sqrt((Math.Pow(B.X - R.X, 2) + Math.Pow(B.Y - R.Y, 2)));
                distanceBL = Math.Sqrt((Math.Pow(B.X - BL.X, 2) + Math.Pow(B.Y - BL.Y, 2)));
                distanceY = Math.Sqrt((Math.Pow(B.X - Y.X, 2) + Math.Pow(B.Y - Y.Y, 2)));



                Thread.Sleep(50);

                if (40 > distanceR)  //반지름 * 2 = 40     (40보다 작으면 충돌한 것)
                {
                    score++;  //점수 플러스
                    R.X = random.Next(30, 280);
                    R.Y = random.Next(20, 400);

                }

                if (40 > distanceBL)  //파란공
                {
                    score++;
                    BL.X = random.Next(30, 280);
                    BL.Y = random.Next(20, 400);

                }

                if (40 > distanceY)
                {
                    score++;
                    Y.X = random.Next(30, 280);
                    Y.Y = random.Next(20, 400);

                }
                lbScore.Text = Convert.ToString("현재상태 : 점수" + score);
                Invalidate();

            }
            MessageBox.Show("게임종료");
            Application.Exit();


        }

        public void Rfun()
        {
            bool down = true;

            while (true)
            {

                if (R.Y >= 400) down = false;
                else if (R.Y <= 50) down = true;

                if (down)
                {
                    R.Y += 10;
                }
                else if (!down)
                {
                    R.Y -= 10;
                }



                Thread.Sleep(30);
                Invalidate();
            }

        }

       

        private void 자유낙하_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Invalidate: 컨트롤의 화면을 다시 그림.
                //공을 왼쪽 끝으로 가면 오른쪽으로 나오게 하려면 각 case문의 if값을 달아서 x값이 뭐일때 조절
                case Keys.Left:
                    if (B.X <= 0)
                    {
                        B.X = 300;
                        break;
                    }
                    B.X -= 20; Invalidate(); break;
                case Keys.Right:
                    if (B.X >= 300)
                    {
                        B.X = 0;
                        break;
                    }

                    B.X += 20; Invalidate(); break;

                default:

                    break;
            }
        }

        private void lbScore_Click(object sender, EventArgs e)
        {

        }
    }
}
