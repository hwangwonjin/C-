using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableTest
{
    public class Exam2_1
    {
        public class Student : IComparable, IDisposable
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

            public Student()
            {
            }

            public override string ToString()
            {
                return $"{Name}[{Id}][{Score}]";
            }

            public int CompareTo(object obj)
            {
                Student st = obj as Student;
                int ret = Score - st.Score;
                return ret;
            }


            ~Student()
            {
                Dispose(false);
            }
            bool disposed; // false
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            public void Dispose(bool disposing)
            {
                if (disposed) return;
                if (disposing)
                {
                    // C#에서 사용하는 IDisposable을 구현한 객체들 정리

                }
                else
                {
                    //.NET Framework 에서 관리되지 않는 자원들 정리

                }
                disposed = true;
            }
        }
    }
}
