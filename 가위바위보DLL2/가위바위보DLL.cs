using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 가위바위보DLL
{

    public class 가위바위보DLL
    {
        public int _Count = 0;
        private int _User_count = 0;
        private int _Com_count = 0;
        private int _Draw_count = 0;

        private int _Com_S = 0;
        private int _Com_R = 0;
        private int _Com_P = 0;

        private int _User_S = 0;
        private int _User_R = 0;
        private int _User_P = 0;

        private string _Win = "내가 이김";
        private string _Lose = "내가 짐";
        private string _Equal = "내가 비김";
        

        public int User_count
        {
            get { return _User_count; }
            set { _User_count = value; }
        }

        public int Com_count
        {
            get { return _Com_count; }
            set { _Com_count = value; }
        }
        public int Draw_count
        {
            get { return _Draw_count; }
            set { _Draw_count = value; }
        }


        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        public int Com_S
        {
            get { return _Com_S; }
            set { _Com_S = value; }
        }

        public int Com_R
        {
            get { return _Com_R; }
            set { _Com_R = value; }
        }

        public int Com_P
        {
            get { return _Com_P; }
            set
            {
                _Com_P = value;
            }
        }




        // and 
        // switich 사용
        //else 없애기
        public string check(int computer, int number)
        {
            switch (computer)
            {
                case 1: //컴퓨터가 가위라면
                    _Com_S++;
                    Count++;
                    if (number == 1)  // 가위
                    {

                        _Draw_count++;
                        return _Equal;

                    }
                    else if (number == 2) //바위
                    {

                        _User_count++;
                        return _Win;
                    }
                    else  //보
                    {

                        _Com_count++;
                        return _Lose;
                    }
                    break;

                case 2:  // 컴퓨터 바위
                    Count++;
                    _Com_R++;
                    if (number == 1)  // 가위
                    {

                        _Com_count++;
                        return _Lose;
                    }
                    else if (number == 2) //바위
                    {

                        _Draw_count++;
                        return _Equal;
                    }
                    else if (number == 3) //보
                    {
                        _User_count++;
                        return _Win;

                    }
                    else
                    { return _Lose; }
                    break;

                case 3: // 컴터  보
                    Count++;
                    _Com_P++;
                    if (number == 1)  // 가위
                    {

                        _User_count++;
                        return _Win;
                    }
                    else if (number == 2) //바위
                    {

                        _Com_count++;
                        return _Lose;
                    }
                    else if (number == 3)  //보
                    {

                        _Draw_count++;
                        return _Equal;
                    }
                    break;
            }
            return null;


        }

    }

    public class 가위바위보
    {
        static void Main(string[] args)
        {
            가위바위보DLL A = new 가위바위보DLL();

            while (true)
            {
                Console.WriteLine("1,2,3중 하나의 수 입력 : ");
                Console.WriteLine("가위 :1, 바위 :2, 보 : 3 :");
                int number = Convert.ToInt32(Console.ReadLine());



                if (number == -1)
                {
                    break;
                }
                A.Count = 2;
                Random rand = new Random();
                int computer = rand.Next(1, 4);


                string result = A.check(computer,
                               number);

                Console.WriteLine(result);
                Console.WriteLine("컴의 선택은" + computer);

            }
            Console.WriteLine("컴의 가위=" + A.Com_S + ", 컴의 바위=" + A.Com_R + ", 컴의 보=" + A.Com_P);
            Console.WriteLine("서로 비김 =" + A.User_count + " 내가 승 = "+A.Com_count + "  " + "내가 패 = " + A.Draw_count);
        }
    }

}
