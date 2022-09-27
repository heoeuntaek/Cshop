//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Scisor
//    {
//        static int count = 0;
//        static int wincount = 0;
//        static int losecount = 0;
//        static int equalcount = 0;

//        static int onecount = 0;
//        static int twocount = 0;
//        static int threecount = 0;

//        static string win = "내가 이김";
//        static string lose = "내가 짐";
//        static string equal = "서로 비김";
//        static string result;

//        // and 
//        // switich 사용
//        //else 없애기
//        public static string check(int computer, int number)
//        {
//            switch (computer)
//            {
//                case 1: //컴퓨터가 가위라면
//                    onecount++;
//                    if (number == 1)  // 가위
//                    {

//                        equalcount++;
//                        return equal;

//                    }
//                    else if (number == 2) //바위
//                    {

//                        wincount++;
//                        return win;
//                    }
//                    else  //보
//                    {

//                        losecount++;
//                        return lose;
//                    }
//                    break;

//                case 2:  // 컴퓨터 바위

//                    twocount++;
//                    if (number == 1)  // 가위
//                    {

//                        losecount++;
//                        return lose;
//                    }
//                    else if (number == 2) //바위
//                    {

//                        equalcount++;
//                        return equal;
//                    }
//                    else if (number == 3) //보
//                    {
//                        wincount++;
//                        return equal;

//                    }
//                    else
//                    { return lose; }
//                    break;

//                case 3: // 컴터  보

//                    threecount++;
//                    if (number == 1)  // 가위
//                    {

//                        wincount++;
//                        return win;
//                    }
//                    else if (number == 2) //바위
//                    {

//                        losecount++;
//                        return lose;
//                    }
//                    else if (number == 3)  //보
//                    {

//                        equalcount++;
//                        return equal;
//                    }
//                    break;
//            }
//            return null;


//            }
//            static void Main(string[] args)
//            {



//                while (true)
//                {
//                    Console.WriteLine("1,2,3중 하나의 수 입력 : ");
//                    Console.WriteLine("가위 :1, 바위 :2, 보 : 3 :");
//                    int number = Convert.ToInt32(Console.ReadLine());


//                    if (number == -1)
//                    {
//                        break;
//                    }
//                    count++;
//                    Random rand = new Random();
//                    int computer = rand.Next(1, 4);


//                    result = check(computer,
//                                   number);

//                    Console.WriteLine(result);
//                    Console.WriteLine("컴의 선택은" + computer);

//                }
//                Console.WriteLine("컴의 가위=" + onecount + ", 컴의 바위=" + twocount + ", 컴의 보=" + threecount);
//                Console.WriteLine("서로 비김 =" + equalcount + " 내가 승 = " + wincount + "내가 패" + losecount);
//            }
//        }
//    }
