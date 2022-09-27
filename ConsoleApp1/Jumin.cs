//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Jumin {
//        static void ain(string[] args)
//        {


//            string jumin;
//            string gubun1 = "";
//            string this_year;

//            int year;
//            int month;
//            int day;
//            int gubun =0;
//            int age =0;
//            int c_year;



//            Console.WriteLine("주민번호 7자리를 입력하세요");
//            jumin = Console.ReadLine();

//            year = Convert.ToInt32(jumin.Substring(0, 2));
//            month = Convert.ToInt32(jumin.Substring(2, 2));
//            day = Convert.ToInt32(jumin.Substring(4, 2));
//            gubun = Convert.ToInt32(jumin.Substring(6, 1));

//            this_year = DateTime.Now.ToString();
//            c_year = Convert.ToInt32(this_year.Substring(0, 4));
//            year = Method.Calc_Year(year, gubun);  // 출생년도 계산
//            age = Method.Calc_age(year, gubun, age, c_year);
//            gubun1 = Method.Calc_Gubun(gubun, gubun1); //성별 계산


//            Console.WriteLine("년도는 : " + year);
//            Console.WriteLine("월은 :  " + month);
//            Console.WriteLine("일은 : " + day);
//            Console.WriteLine("나이는 : " + age);
//            Console.WriteLine("성별은 :  " + gubun1);


//        } 

//    }

//    public static class Method
//    {
//        public static int Calc_Year(int year, int gubun)
//        {
//            if (gubun.Equals(1) || gubun.Equals(2))
//            {
//                return year+1900;
//            }
//            else
//            {
//                return year + 2000;
//            }
//        }
        
        
//        public static int Calc_age(int year, int gubun, int age, int c_year)
//        {
//            age = c_year - year;
//            return age;
//        }

//        public static string Calc_Gubun(int gubun, string gubun1)
//        {
//            if (gubun.Equals(1) || gubun.Equals(3))
//            {
//                gubun1 = "남자";
//            }
//            else
//                gubun1 = "여자";
//            return gubun1;
//        }

        
//    }


//}
