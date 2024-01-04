using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class EX008
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;

        // MS-SQL 접속 
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

            string fileName = Path.Combine(currentDirectory, "data", DateTime.Now.ToString("yyyyMMddHHmmss"));

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("[{0}] 데이터베이스 연결 시도...", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);

                Console.Write("삭제 할 유저의 아이디를 입력하세요 : ");
                string userID = Console.ReadLine();
                string deleteSQL = string.Format(" DELETE FROM TB_USER WHERE ID='{0}'", userID);

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = deleteSQL;
                    int activeNumber =  command.ExecuteNonQuery();
                
                    sw.WriteLine("영향 받은 데이터 : " + activeNumber);
                }
                    
                sw.WriteLine("데이터 연결 끊기 시도... ", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK...", DateTime.Now);
            }

        }
    }
}
