using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Circle cir = new Circle(10);
            /*            PrintRectangleArea(rect);
                        PrintCircleArea(cir);*/
            PrintFigure(rect);
            PrintFigure(cir);

         /*   Figure f = rect;
            Figure f2 = cir;

            IFigurable if1 = rect;
            IFigurable if2 = cir;
            if1.Area();

            f.Area();*/
        }

       /*
        *  새로운 메서드를 계속 추가해 줘야함 (비효율적)
        * static void PrintRectangleArea(Rectangle rect)
        {
            Console.WriteLine($"사각형의 면적은 : {rect.Area()}");
        }

        static void PrintCircleArea(Circle cir)
        {
            Console.WriteLine($"원의 면적은 : {cir.Area()}");
        }*/

        // 인테페이스 응용
        static void PrintFigure(IFigurable obj)
        {
            Console.WriteLine($"{obj.GetType().FullName} 면적 : {obj.Area()}");
        }
    }
}
