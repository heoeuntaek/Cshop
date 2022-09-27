// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
//
// namespace ConsoleApp1
// {
//     internal class Hap_Min_Max_Aver
//     {
//         public Hap_Min_Max_Aver()
//         {
//         }
//
//         static void Main(string[] args)
//         {
//             int max = 0;
//             int min = 1000;
//             int hap = 0;
//             int ave = 0;
//
//             int[] su = new int[] { 1, 3 ,4 , 2,3,10 } ;
//             Console.WriteLine(su.Length);
//             
//             for(int i = 0; i < su.Length; i++)
//             {
//                 hap+=su[i];
//             }
//             //합
//             //    최대
//             //    최소
//             //    평균
//             max = su[0];
//
//             for(int i=1; i <su.Length; i++)
//             {
//                 if (max < su[i])
//                 {
//                     max = su[i];
//                 }
//             }
//
//             min = su[0];
//             for(int i=1; i < su.Length; i++)
//             {
//                 if(min > su[i])
//                 {
//                     min = su[i];
//                 }
//             }
//
//             ave = hap / su.Length;
//
//             Console.WriteLine("Hap ="+hap);
//             Console.WriteLine("min =" + min);
//             Console.WriteLine("max =" + max);
//             Console.WriteLine("ave =" + ave);
//
//             
//             Console.WriteLine("ave =" + ave);
//             Console.WriteLine("ave =" + ave);
//             Console.WriteLine("ave =" + ave);
//             
//             
//             
//             
//
//
//
//         }
//     }
// }
