using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 허은택_가위바위보
{
    internal class 가위바위보
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1,2,3 중 하나의 수 입력");
            int mynumber = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int comput_number = random.Next(1, 3);

            string result = 허은택_가위바위보DLL.check(mynumber, comput_number);
            Console.WriteLine($"컴의 선택은 {comput_number}");
            Console.WriteLine($"나의 선택은 {mynumber}");
            Console.WriteLine($"결과 = {result} ");
            
        }
    }
}
