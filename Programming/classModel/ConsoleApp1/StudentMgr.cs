using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentMgr
    {
        public void Run()
        {
           Student st =  RegistStudent();
            st.PrintMe();
        }

        private Student RegistStudent()
        {
            Console.WriteLine("학년 [숫자만 입력]: ");
            string grade = Console.ReadLine();
            Console.WriteLine("반 : ");
            string stclass = Console.ReadLine();
            Console.WriteLine("번호 : ");
            string stnumber = Console.ReadLine();
            Console.WriteLine("이름 : ");
            string stname = Console.ReadLine();
            Student st = new Student(
               (Grade)Enum.Parse(typeof(Grade), grade),
               (StudentClass)Enum.Parse(typeof(StudentClass), stclass),
                Convert.ToInt32(stnumber),
                stname
            );
            return st;
        }
    }
}
