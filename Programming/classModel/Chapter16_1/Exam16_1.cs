using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IComparableTest.Exam2_1;

/*
    내용 : 제네릭 실습
 */
namespace Chapter16_1
{
    internal class Exam16_1
    {
        public void Run()
        {
            PrintAny1 p1 = new PrintAny1();
            p1.Print<int>(1);       //제네릭 메서드
            p1.Print(3);
            PrintAny<int, string> p2 = new PrintAny<int, string>(); // 제너릭 메서드
            p2.Print(5, "오오");
            //PrintAny<Double> p2 = new PrintAny<Double>();
            //p2.Print(3.23324);
            //PrintAny<Student> p3 = new PrintAny<Student>();
            //Student st = new Student();
            //st.Name = "홍길동";
            //p3.Print(st);
        }
    }

    // 제네릭 클레스
    class PrintAny<T, U> where T : IComparable  // where을 이용하여 제한조건을 부여
    {
        public void Print(T val1, U val2) 
        {
            Console.WriteLine($"val1 = {val1}, val2 = {val2}");
        }
    }

    class PrintAny1
    {
        public void Print<T> (T val)
        {
            Console.WriteLine($"val = {val}");
        }
    }

    class PrintInteger
    {
        public void Print(int val)
        {
            Console.WriteLine($"val = {val}");
        }
    }
    class PrintDuble
    {
        public void Print(int val)
        {
            Console.WriteLine($"val = {val}");
        }
    }
}
