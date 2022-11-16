//using System;
//abstract class Computer  // 추상 클래스
//{
//    public void Graphic()  // 일반메소드 가능
//    {
//        Console.WriteLine("일반메소드 호출.");
//    }

//    // 뼈대만 제시하고 상속받은데서다시만들어써라
//    public abstract void Network();
//}

//class NewComputer : Computer
//{
//    public override void Network()
//    {
//        // 상속된곳에서 Network()를 구현하여 사용
//        Console.WriteLine("추상클래스 호출.");
//    }
//}

//class 추상클래스
//{
//    public static void Main()
//    {
//        // Abstract 클래스는 인스턴스를
//        //  객체를 만들지 못함.
//        // Computer c = new Computer();

//        Computer c = new NewComputer();

//        c.Graphic();  // 일반 메소드 호출
//        c.Network();  // 추상 메소드 호출
//    }
//}

