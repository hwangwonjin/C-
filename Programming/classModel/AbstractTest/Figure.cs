using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    abstract class Figure : IFigurable
    {
       abstract public Double Area();
        // width, height 사각형
        // 반지름 PhiR^2

        public override string ToString()
        {
            return base.ToString();
        } 
    }
}
