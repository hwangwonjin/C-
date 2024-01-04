using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class Ex003
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            string filePath = Path.Combine(currentDirectory, "data", "log.txt");

            FileInfo fileInfo  = new FileInfo(currentDirectory);

            Console.WriteLine("저장경로 : {0}", fileInfo.DirectoryName);
            Console.WriteLine(fileInfo.FullName);

            Console.WriteLine("=== 파일 내용 ===");
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
