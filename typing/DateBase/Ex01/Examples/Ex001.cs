using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class Ex001
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            string dataPath = Path.Combine(currentDirectory, "data");

            DirectoryInfo directoryInfo = new DirectoryInfo(dataPath);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("디렉토리가 생성되었습니다.");
            }

            Console.WriteLine("생성 경로 : {0}", directoryInfo.FullName);
        }

    }
}
