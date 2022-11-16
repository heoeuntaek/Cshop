//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1._7
//{

//    interface Calc
//    {
//        public int Calc_Area(int w, int h);

//    }

//    abstract class Calc_abstract
//    {
//        abstract public int Len(int w, int h);


//    }


//    class Area_Calc2 : Calc_abstract, Calc
//    {
//        private int _Width;
//        private int _Height;
//        private int _Area;
//        private int _Length;



//        public int Width
//        {
//            get { return _Width; }
//            set { _Width = value; }
//        }

//        public int Height
//        {
//            get { return _Height; }

//        }

//        public int Area { get { return _Area; } }

//        public Area_Calc2(int w, int h){
//            _Width = w;
//            _Height = h;
//            }

//        public int Calc_Area(int w, int h)
//        {
//            int area = w * h;
//            return area;
//        }


//        public override int Len(int w, int h)
//        {
//            int length = (2 * _Width) + (2 * _Height);
//            return length;
//        }

//        class 속성_사각형넓이
//        {


//            static void Main(string[] args)
//            {
//                Console.WriteLine("사각형 가로 입력");
//                int width = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("사각형 세로 입력");
//                int height = Convert.ToInt32(Console.ReadLine());

//                Area_Calc2 area_class = new Area_Calc2(width,height);
                
//                //면적 area
//                int area = area_class.Calc_Area(width,height);


//                //둘레 len
//                int len = area_class.Len(width, height);

//                Console.WriteLine($"Area = {area}");
//                Console.WriteLine($"len = {len}");

//            }

//            private static void Print_out(int width, int height, int area, int length)
//            {
//                Console.WriteLine("======================");
//                Console.WriteLine("가로, 세로, 면적, 둘레");
//                Console.WriteLine($"{width}  {height}  {area}  {length}");
//            }
//        }
//    }
//}

