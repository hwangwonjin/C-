using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        // 필드. 프로퍼티
        public Grade Grade { get; set; }
        public StudentClass StCalss{ get; set; }
        public int StNumber { get; set; }
        public string StName { get; set; } // NotNull
        public string StAddress { get; set; }
        public int StHigh { get; set; }
        public int StWeight { get; set; }
        public int StAge { get; set; }
        public Sex StSex { get; set; }  // Enum Sex 참조

        // 생성자
        
        public Student(Grade grade, StudentClass stclass, int stunumber, string stname, Sex sex)
        {
            this.Grade = grade;
            this.StCalss = stclass;
            this.StNumber = stunumber;
            this.StName = stname;
        }

        public Student(Grade grade, StudentClass stclass, int stunumber, string stname)
            : this(grade, stclass, stunumber, stname, Sex.미확인)
        {

        }

        public void PrintMe()
        {
            Console.WriteLine(Grade + " , " + StCalss + " , " + StNumber + "[" + StName + "]");
        }
    }
}
