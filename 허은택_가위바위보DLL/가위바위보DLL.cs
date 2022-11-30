using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class 가위바위보DLL
{
    private int _Count = 0;
    private int _Wincount = 0;
    private int _Losecount = 0;
    private int _Equalcount = 0;

    private int _Onecount = 0;
    private int _Twocount = 0;
    private int _Threecount = 0;

    private string _Win = "내가 이김";
    private string _Lose = "내가 짐";
    private string _Equal = "서로 비김";
    private string _Result;




    public int Onecount   // 속성에 괄호 ()가 없다.          
    {
        get { return _Onecount; }   // get  -읽어올때
        set { _Onecount = value; }  // set - 저장할때 
    }




    // and 
    // switich 사용
    //else 없애기
    public string check(int computer, int number)
    {
        switch (computer)
        {
            case 1: //컴퓨터가 가위라면
                Onecount++;
                if (number == 1)  // 가위
                {

                    _Equalcount++;
                    return _Equal;

                }
                else if (number == 2) //바위
                {

                    _Wincount++;
                    return _Win;
                }
                else  //보
                {

                    _Losecount++;
                    return _Lose;
                }
                break;

            case 2:  // 컴퓨터 바위

                _Twocount++;
                if (number == 1)  // 가위
                {

                    _Losecount++;
                    return _Lose;
                }
                else if (number == 2) //바위
                {

                    _Equalcount++;
                    return _Equal;
                }
                else if (number == 3) //보
                {
                    _Wincount++;
                    return _Equal;

                }
                else
                { return _Lose; }
                break;

            case 3: // 컴터  보

                _Threecount++;
                if (number == 1)  // 가위
                {

                    _Wincount++;
                    return _Win;
                }
                else if (number == 2) //바위
                {

                    _Losecount++;
                    return _Lose;
                }
                else if (number == 3)  //보
                {

                    _Equalcount++;
                    return _Equal;
                }
                break;
        }
        return null;


    }



    static void Main(string[] args)
    {



        //    while (true)
        //    {
        //        Console.WriteLine("1,2,3중 하나의 수 입력 : ");
        //        Console.WriteLine("가위 :1, 바위 :2, 보 : 3 :");
        //        int number = Convert.ToInt32(Console.ReadLine());


        //        if (number == -1)
        //        {
        //            break;
        //        }
        //        count++;
        //        Random rand = new Random();
        //        int computer = rand.Next(1, 4);


        //        result = check(computer,
        //                       number);

        //        Console.WriteLine(result);
        //        Console.WriteLine("컴의 선택은" + computer);

        //    }
        //    Console.WriteLine("컴의 가위=" + onecount + ", 컴의 바위=" + twocount + ", 컴의 보=" + threecount);
        //    Console.WriteLine("서로 비김 =" + equalcount + " 내가 승 = " + wincount + "내가 패" + losecount);
        //}
    }

}