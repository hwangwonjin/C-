using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Rectangle : Figure
    {
        int x1, y1; // x2 - x1 = width
        int x2, y2; // y2 - y1 = height
        public Double Width { get; set; }
        public Double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// 사각형의 면적을 반환
        /// </summary>
        /// <returns></returns>

        public override double Area()
        {
            return Width * Height;
        }

    }
}
