using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class Ex002
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            string filePath = Path.Combine(currentDirectory, "data", "log.txt");

            // StreamWriter에서 파일이 없으면 자동으로 생성됩니다.
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("프로그램 실행 시간 : {0}", DateTime.Now);
            }
        }

    }
}
