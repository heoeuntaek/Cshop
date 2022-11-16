//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class 로또번호생성기
//    {
//        static void Main(string[] args)
//        {
//            // 랜덤 클래스의 객체 randNum 생성
//            Random randNum = new Random();

//            int t = 0;
//            int resultNum = 0;
//            // 랜덤 생성된 숫자 임시 저장
//            int[] arr = new int[6];
//            int num = 0;
//            Console.WriteLine("로또 번호 생성기 ");
//            while (true)
//            {


//                for (int i = 0; i < 6; i++)
//                {
//                    t = 0;
//                    resultNum = randNum.Next(1, 46);

//                    for (int j = 0; j < arr.Length; j++)
//                    {
//                        if (resultNum == arr[j])
//                        {
//                            i--;
//                            t = 1;
//                            break;
//                        }

//                    }

//                    if (t != 1)
//                    {
//                        arr[i] = resultNum;

//                    }


//                }

//                //정렬

//                for (int i = 0; i < arr.Length; i++)
//                {
//                    for (int j = 0; j < arr.Length; j++)
//                    {
//                        if (arr[i] < arr[j])
//                        {
//                            int c = arr[j];
//                            arr[j] = arr[i];
//                            arr[i] = c;
//                        }
//                    }
//                }

//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.Write(arr[i] + "\t");
//                }
//                Console.WriteLine();
//                num++;
//                if (num == 21) break;
//            }

//        }


//    }
//}
