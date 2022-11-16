//namespace ConsoleApp1
//{
//    internal class Sort
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[4] { 1, 3, 2, 4 };
//            Console.WriteLine("정렬 전 데이터");

//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.Write(a[i]);
//            }
//            Console.WriteLine();

//            for (int j = 0; j < a.Length; j++)
//            {
//                for (int i = 0; i < a.Length; i++)
//                {
//                    if (a[j] < a[i])
//                    {
//                        int c = a[j];
//                        a[j] = a[i];
//                        a[i] = c;

//                    }
//                }
//            }
//            Console.WriteLine("정렬 후 데이터");

//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.Write(a[i]);
//            }
//        }
//    }
//}
