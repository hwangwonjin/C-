using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_1
{
    internal class Student : IComparable
    {
        public string Name { get; set; }
        public int StudentSex { get; set; }
        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            Student st1 = obj as Student;
            //return Name.CompareTo(st1.Name);    // 이름순 정렬
            return Score - st1.Score;             // 성적순 정렬      
        }

        public override string ToString()
        {
            return $"{Name} [{StudentSex}] [{Score}]";
        }
    }
}
