using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class IfTest
    {
        public static void Main()
        {
            int num = 0;

            if (num > 0)
            {
                Console.WriteLine("양수");
            }
            else if (num < 0)
            {
                Console.WriteLine("음수");
            }
            else
            {
                Console.WriteLine("영");
            }
        }
    }
}
