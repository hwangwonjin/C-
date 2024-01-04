using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class Ex007
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

            using(StreamWriter sw = new StreamWriter(fileName, true)) 
            {
                sw.WriteLine("[{0}] 데이터베이스 연결 시도...", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 ok...", DateTime.Now);

                Model.User user = SetUser();
                string updateSQL = string.Format(" UPDATE TB_USER SET NAME='{0}', AGE='{1}', JOB='{2}' WHERE ID='{3}'", user.Name, user.Age, user.Job, user.userID);
            
                // sql 명령어
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = updateSQL;
                    int activeNumber = command.ExecuteNonQuery();

                    sw.WriteLine("영향 받은 데이터 :  " + activeNumber);
                }

                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도...", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK...", DateTime.Now);

            }
        }

        private Model.User SetUser()
        {
            Model.User user = new Model.User();

            bool validate = false;
            do
            {
                Console.Write("정보 수정 할 회원의 아이디를 입력하세요: ");
                user.userID = Console.ReadLine();
                Console.Write("회원의 이름을 입력하세요: ");
                user.Name = Console.ReadLine();
                Console.Write("회원의 나이를 입력하세요: ");
                user.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("회원의 직업을 입력하세요: ");
                user.Job = Console.ReadLine();

                Console.WriteLine("수정 된 회원 : {0} / {1} / {2} / {3} 이 맞습니까? (y/n)",
                    user.userID, user.Name, user.Age, user.Job);

                validate = Console.ReadLine().ToLower() != "y";
            } while (validate);

            return user;
        }
    }
}
