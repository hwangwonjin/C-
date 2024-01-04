using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_1
{
    internal class Exam14_1
    {
        public void Run()
        {
            // Directory. Directoryinfo
            TestDirectory();
        }

        private void TestDirectory()
        {
            //Console.WriteLine("Directory 입력 : ");
            //string root  = Console.ReadLine();
            //createDirectory(root);
            //ReadDirectory(root);
            //DeleteDirecory(root);
            //RenameDirectory(root);
            // CRUD => Create, Read, Update, Delete
            string fileSystem = "c:";
            string directory1 = "Windows";
            string root = fileSystem + "\\"+ directory1;
            ReadDirectory(root);
        }

        private void RenameDirectory(string root)
        {
            Directory.Move(root, "d:Wkjtet");
        }

        private void DeleteDirecory(string root)
        {
            try
            {
                if (Directory.Exists(root)) Directory.Delete(root);

            }
            catch(Exception ex) 
            {
                Console.WriteLine($"오류발생 : {ex.Message}");
                return; 
            }
        }

        private void createDirectory(string root)
        {
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                return;
            }
        }

        private void ReadDirectory(string root)
        {
            if (Directory.Exists(root))
            {
                Console.WriteLine($"{root} Directory가 존재합니다");
                DirectoryInfo di = new DirectoryInfo(root);
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"파일 : {file.FullName} {file.Extension}을 찾았습니다.");
                }
                string[] dirs = Directory.GetDirectories(root);
                foreach (string dir in dirs)
                {
                    Console.WriteLine($"디렉토리 : {dir}을 찾았습니다.");
                }
            }
            else
            {
                Console.WriteLine($" {root} Directory가 존재하지 않습니다.");
                Directory.CreateDirectory(root);
                return;
            }
        }
    }
}
