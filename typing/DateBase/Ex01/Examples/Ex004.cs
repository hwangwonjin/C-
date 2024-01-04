using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class Ex004
    {

        private readonly string currentDirectory = Environment.CurrentDirectory;

        private readonly string connectionStr = string.Format("Data source = {0},{1};Initial Catalog={2};User ID={3};Password={4}", 
            "127.0.0.1", "1433", "testdb", "sa", "1234");

        public void Run()
        {
            CheckedDirectory();
            TryConnectToDatabase();
        }

        private void CheckedDirectory()
        {
            string dataPath = Path.Combine(currentDirectory, "data");

            DirectoryInfo directoryInfo = new DirectoryInfo(dataPath);

            if (!directoryInfo.Exists) { directoryInfo.Create(); }
        }

        private void TryConnectToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionStr);

            string fileName = Path.Combine(currentDirectory, "data", DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt");

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("[{0}] 데이터베이스 연결 시도...", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);

                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도...", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK...", DateTime.Now);
            }

            Console.WriteLine("생성 경로 : {0}", currentDirectory);
        }

    }
}
