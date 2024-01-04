using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    날짜 : 2023/12/05
    내용 : 구조체 실습
 */

namespace Exam12_1
{
    internal class Program
    {
        int i;
        static void Main(string[] args)
        {
            Student st = new Student();
            Student st2 = st;
            st.Name = "Lee";
            st2.Name = "Kim";
            Console.WriteLine(st.Name);
            Console.WriteLine(st2.Name);
            AAA(ref st);
            Console.WriteLine(st.Name);
        }

        static void AAA(ref Student st)
        {
            st.Name = "하나";
        }
    }

    // 참조형식으로 학생 클래스입니다.

    struct Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Student(string name, int age)
        {
            Age = age;
            Name = name;
        }
    }
}
