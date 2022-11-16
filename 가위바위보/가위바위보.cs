using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 허은택_가위바위보
{
    internal class 가위바위보
    {
        static int count = 0;
        static int wincount = 0;
        static int losecount = 0;
        static int equalcount = 0;

        static int onecount = 0;
        static int twocount = 0;
        static int threecount = 0;

        static string win = "내가 이김";
        static string lose = "내가 짐";
        static string equal = "서로 비김";
        static string result;

        static void Main(string[] args)
        {
            Console.WriteLine("1,2,3 중 하나의 수 입력");
            int mynumber = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int comput_number = random.Next(1, 3);


            Console.WriteLine($"결과 = {허은택_가위바위보DLL.check(mynumber, comput_number)}"); 
        }
    }
}
