//using System;
//using System.Threading;
//public class Thread_Test_1
//{
//    static object lockObject = new object();  //추가함
//                                              // lock() 의 파라미터에 사용될 의의의 객체 생성함,  주로 object 타입의 
//                                              // private 필드를 지정한다.  즉, private object lockObject = new object() 와 
//                                              // 같이  private 필드를 생성한 후, lock(lockObject) 와 같이 지정한다.
//    public static void PrintName(Object name)
//    {
//        lock (lockObject)        // Lock 지정
//        {
//            Console.Write("My Name is ");
//            Thread.Sleep(1000);
//            Console.WriteLine(name);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Thread thread1 = new Thread(PrintName);
//        Thread thread2 = new Thread(PrintName);
//        Thread thread3 = new Thread(PrintName);

//        thread1.Start("Thread1");
//        thread2.Start("Thread2");
//        thread3.Start("Thread3");
//    }
//}
