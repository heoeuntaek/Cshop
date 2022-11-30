using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JuminDLL

{
    public class JuminDLL
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;
            int age = 0;
            int jumin;


            Console.WriteLine("주민번호를 - 없이 7자리 입력하세요");
            jumin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"당신이 태어난 연도는 {Calculator.Year(jumin)}");
            Console.WriteLine($"당신이 태어난 월은 {Calculator.Month(jumin)}");
            Console.WriteLine($"당신이 태어난 일은 {Calculator.Day(jumin)}");
            Console.WriteLine($"당신의 나이는 {Calculator.Age(jumin)}");
            Console.WriteLine($"당신이 성별은 {Calculator.sex(jumin)}");

        }

        public class Calculator
        {
            public static int Age(int jumin)
            {
                string a = Convert.ToString(jumin);
                int b = Convert.ToInt32(a.Substring(0, 2));
                if (b <= 22) { b = b + 2000; }
                else if (b > 22) { b = b + 1900; }

                int age = 2022 - b;
                return age;

            }



            public static int Day(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(4, 2);
                return Convert.ToInt32(a);

            }

            public static int Month(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(2, 2);
                return Convert.ToInt32(a);

            }

            public static string sex(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(6, 1);
                int b = Convert.ToInt32(a);
                if (b == 1 | b == 3)
                {
                    return "남자";
                }
                else if (b == 2 | b == 4)
                {
                    return "여자";
                }
                else return "오류";
            }

            public static int Year(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(0, 2);
                int b = Convert.ToInt32(a);
                return b;

            }

            
        }
    }
}