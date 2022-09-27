//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Total
//    {
//        static void Main(string[] args)
//        {

//            int even = 0;  //짝수
//            int odd = 0;
//            int evenC = 0; //짝수 개수
//            int oddC = 0; // 홀수 개수
//            int inputC = 0; //입력개수

//            // - 1은 데이터 개수에 포함하지 말 것

//            while (true)
//            {
//                Console.WriteLine("하나의 정수 입력: ");
//                int i = Convert.ToInt32(Console.ReadLine());


//                if (i == -1)  //종료
//                {
//                    break;
//                }
//                //짝수이면
//                if (i % 2 == 0)
//                {
//                    even += i;
//                    evenC++;
//                    inputC++;
//                }
//                //홀수
//                else if (i % 2 == 1)
//                {
//                    odd += i;
//                    oddC++;
//                    inputC++;
//                }

//            }
//            //짝수의 합과 홀수의 합 
//            Console.WriteLine("짝수의 합 = " + even + "\n" + "홀수의 합 = " + odd);

//            //짝수 개수와 홀수의 개수
//            Console.WriteLine("짝수의 개수 :" + evenC + "\n" + "홀수의 개수 :" + oddC);
//            Console.WriteLine("입력 개수 :" + inputC);
//        }
//    }
//}
