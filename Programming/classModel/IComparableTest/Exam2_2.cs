using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IComparableTest.Exam2_1;

/*
    내용 : IComparable 인터페이스 실습
 */


namespace IComparableTest
{
    internal class Exam2_2
    {
        public void Run()
        {
            Student[] students = new Student[]
            {
                new Student("홍강", 87, 2),
                new Student("김영", 76, 1)

            };
            Array.Sort(students);
            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }
            FileStream stream = new FileStream(@"c:\\Temp\\aa.txt", FileMode.Open);
            using(StreamReader reader = new StreamReader(stream))
            {
                string buffer;
                while ((buffer = reader.ReadLine()) != null)
                {

                }
            }
        }
    }



    

}
