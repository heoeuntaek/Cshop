//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Switch_hakjum
//    {
//        static void Main(string[] args)
//        {
            

//            while (true)
//            {
//                Console.WriteLine("점수 입력 :");
//                int number= Convert.ToInt32(Console.ReadLine());                          
               
//                String a =Input.methode(number);
//                Console.WriteLine(a);
//            }
//        }
//    }

//    public class Input
//    {
//        public static string methode(int a)
//        {
//            a = a / 10;
            
//            switch (a)
//            {
//                case 10:
//                case 9:
//                case 8:
//                    return "A";
//                case 7:
//                case 6:
//                    return "B";
//                case 5:
//                case 4:
//                    return "C";
//                case 3:
//                case 2:
//                    return "D";
//                case 1:
//                case 0:
//                    return "F";
//                default:
//                    return "점수 범위 초과 됨";

//            }
//        }
//    }
//}
