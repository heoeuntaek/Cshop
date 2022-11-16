//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class 빈도수_최빈값
//    {
//        static void Main(string[] args)
//        {
//            //            (0부터 9사이의 값 중에서)   
//            //처음 데이터 1이면 1번 인덱스에 1증가
//            //두번째 데이터 3이므로 3번 인덱스에 1증가

//            int max = 0;
//            int[] num = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
//            int count = -1;
//            for (int i = 0; i < 10; i++)
//            {
//                Console.Write("0부터 9까지 사이 값 10개 입력 : ");

//                int a = Convert.ToInt32(Console.ReadLine());
//                num[a]++;
//            }




//            Console.WriteLine("입력값\t 빈도수");
//            for (int i = 0; i < num.Length; i++)
//            {
//                Console.WriteLine(i + "\t" + num[i]);
//            }

//            for (int i = 0; i < num.Length; i++)
//            {
//                if (max < num[i])
//                {
//                    max = num[i];
//                }
//            }
//            for (int i = 0; i < num.Length; i++)
//            {
//                if (max == num[i])
//                {
//                    count = i;
//                }
//            }

//            Console.WriteLine("최빈값은 " + count + "가 " + max + " 번 나타남");




//        }
//    }
//}
