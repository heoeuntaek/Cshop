//using System;
//using System.Collections.Generic;
//using System.Formats.Asn1;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class MethodOut
//    {
//        static void Main(string[] args)
//        {
//            //width vertical area circumference
//            int area = 0;
//            double circum = 0;


//            Console.Write("사각형의 가로의 길이를 입력하세요");
//            int width = Convert.ToInt32(Console.ReadLine());

//            Console.Write("사각형의 세로의 길이를 입력하세요");
//            int vertical = Convert.ToInt32(Console.ReadLine());

//            Cal(width, vertical, out area, out circum);
//            Console.WriteLine("사각형의 둘레의 길이는 " + area + "이고");

//            Console.WriteLine("사각형의 면적의 반은 " + circum + "이고");

//            Console.WriteLine("직각사각형 이다.");


//        }

//        private static void Cal(int width, int vertical, out int area, out double circum)
//        {
//            circum = (double)(width * vertical) / 2;
//            area = (width + vertical) * 2;
//        }


//    }
//}