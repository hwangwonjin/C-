using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    내용 : IComparable 인터페이스 실습
 */


namespace IEnumerableTest
{
    internal class Exam1_2
    {
        public void Run()
        {
            
        }
    }

    internal class Student : IComparable
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }

        public Student(string name, int score, int id)
        {
            Name = name;
            Score = score;
            Id = id;
        }
        public override string ToString()
        {
            return $"{Name}[{Id}][{Score}]";
        }

    }
}
