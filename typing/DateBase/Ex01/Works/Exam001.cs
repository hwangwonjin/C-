using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Works
{
    internal class Exam001
    {

        private readonly string currentDirectory = Environment.CurrentDirectory;
        public void Run()
        {
            string dataPath = Path.Combine(currentDirectory, "data");
            DirectoryInfo directory = new DirectoryInfo(dataPath);

            FileInfo[] files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine(file.Name);
            }
        }
    }
}
