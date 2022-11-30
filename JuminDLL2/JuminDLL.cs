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
            Calculator cal = new Calculator();


            Console.WriteLine("주민번호를 - 없이 7자리 입력하세요");
            cal.Jumin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"당신이 태어난 연도는 {Calculator.CalYear(cal.Jumin)}");
            Console.WriteLine($"당신이 태어난 월은 {Calculator.CalMonth(cal.Jumin)}");
            Console.WriteLine($"당신이 태어난 일은 {Calculator.CalDay(cal.Jumin)}");
            Console.WriteLine($"당신의 나이는 {Calculator.CalAge(cal.Jumin)}");
            Console.WriteLine($"당신이 성별은 {Calculator.CalSex(cal.Jumin)}");

        }

        public class Calculator
        {
            private int _Year;
            private int _Month;
            private int _Day;
            private int _Age;
            private int _Jumin;

            public int  Year
            {
                get { return _Year; }
                set { _Year = value; }
            }

            public int Jumin
            {
                get { return _Jumin; }
                set { _Jumin = value; }
            }

            public static int CalYear(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(0, 2);
                int b = Convert.ToInt32(a);
                return b;

            }

            public static int CalMonth(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(2, 2);
                return Convert.ToInt32(a);

            }

            public static int CalDay(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(4, 2);
                return Convert.ToInt32(a);

            }

            public static int CalAge(int jumin)
            {
                string a = Convert.ToString(jumin);
                int b = Convert.ToInt32(a.Substring(0, 2));
                if (b <= 22) { b = b + 2000; }
                else if (b > 22) { b = b + 1900; }

                int age = 2022 - b;
                return age;

            }


            public static string CalSex(int jumin)
            {
                string a = Convert.ToString(jumin);
                a = a.Substring(0, 1);
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

            


        }
    }
}