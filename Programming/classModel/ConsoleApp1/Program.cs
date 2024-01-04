using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManegment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student st1 = new Student(Grade.학년_1, StudentClass.반_1, 1, "홍길동");
           StudentMgr studentMgr = new StudentMgr();
            studentMgr.Run();

        }
    }
}
