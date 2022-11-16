//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _9_exception
//{
//    internal class Class1
//    {
//        static void Main(string[] args)
//        {

//            int i = 3;
//            int j = 0;
//            int k = 0;

//            try
//            {
//                if (j != 0)
//                {
//                    k = i / j;
//                }
//                else
//                {
//                    throw new Exception("제로가 오면 안되요");
//                    k = i / j;
//                }
                    

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("에러 발생");
//                Console.WriteLine(ex.Message);
//                //throw;
//            }
//            finally
//            {
//                Console.WriteLine("실행");
//            }
            
//        }
//    }
//}
