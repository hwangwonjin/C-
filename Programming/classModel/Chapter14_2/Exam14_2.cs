using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_2
{
    internal class Exam14_2 : Object
    {
        Student[] students = new Student[3];
        public void Run()
        {
            
            ReadStudent();
            PrintStudent();
            WriteStudent();
        }

        private void WriteStudent()
        {
            FileStream stream = new FileStream(@"C:\\Temp\\Test.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream, Encoding.Default);
            foreach (Student st in students)
            {
                writer.WriteLine($"{st.Name}#{st.StudentSex}#{st.Score}");
            }
            writer.Close();
        }

        private void PrintStudent()
        {
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        private void ReadStudent()
        {
            FileStream stream = new FileStream("C:\\Temp\\student.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream, UTF8Encoding.UTF8);
            string buffer = null;
            int index = 0;
            while((buffer =  reader.ReadLine()) != null)
            {
                InsertStudent(buffer, index++);
            }
            reader.Close();
        }

        private void InsertStudent(string buffer, int index)
        {
            Student st = new Student();
            string[] tmp = buffer.Split('#');
            if(tmp.Length != 3) { throw new Exception("텍스트 내용에 오류가 있습니다 : " + buffer); }
            st.Name = tmp[0];
            st.Score = Convert.ToInt32(tmp[2]); //int.Parse()
            int iSex = int.Parse(tmp[1]);
            st.StudentSex = (Sex)Enum.ToObject(typeof(Sex), iSex);
            students[index] = st;

        }
    }
}
