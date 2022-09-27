//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class 성적처리
//    {
//        static void Main(string[] args)
//        {

//            string[] name = new string[] { "KBS", "SBS", "YTN", "MBC" };

//            Console.WriteLine("학번    이름    국어    영어    수학    총점    평균    석차");
//            Console.WriteLine("--------------------------------------------------------");
//            int[,] jumsu = new int[4, 7] 
//            {{1,33,44,57,0,0,1},
//            { 2,77,88,99,0,0,1 },
//            { 3,55,66,77,0,0,1},
//            {4,66,77,88,0,0,1 }};


//            int sumA =0;
//            int sumB =0;
//            int sumC =0;
//            int sumD =0;

            

//            for (int i = 1; i < 4; i++)
//            {
//                sumA += jumsu[0,i];
//                sumB += jumsu[1, i];
//                sumC += jumsu[2, i];
//                sumD += jumsu[3, i];
//            }

//            jumsu[0, 4] = sumA;
//            jumsu[1, 4] = sumB;
//            jumsu[2, 4] = sumC;
//            jumsu[3, 4] = sumD;

//            jumsu[0, 5] = sumA/3;
//            jumsu[1, 5] = sumB/3;
//            jumsu[2, 5] = sumC/3;
//            jumsu[3, 5] = sumD / 3;




//            for (int i = 0; i < 4; i++)
//            {
//                for(int j = 0; j < 4; j++)
//                {
//                    if(jumsu[i,5]< jumsu[j, 5])
//                    {
//                        jumsu[i, 6]++;
//                    }
//                }

//            }
//            for (int i=0; i<jumsu.Length; i++)
//            {
//                for (int j=0; j < 7; j++)
//                {
//                    if (j == 1)
//                    {
//                        Console.Write(name[i]+"\t");
//                    }
//                    Console.Write(jumsu[i, j]+"\t");
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}
