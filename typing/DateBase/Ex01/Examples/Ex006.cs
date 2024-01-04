using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Examples
{
    internal class Ex006
    {
        private readonly string connectionStr = string.Format("Data source = {0},{1};Initial Catalog={2};User ID={3};Password={4}",
            "127.0.0.1", "1433", "testdb", "sa", "1234");

        public void Run()
        {
            string selectSQL = "SELECT ID, NAME, AGE, JOB FROM TB_USER ";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) 
                    {
                        Console.WriteLine("회원 ID : {0}", reader["ID"]);
                        Console.WriteLine("회원이름 : {0}", reader["NAME"]);
                        Console.WriteLine("회원나이 : {0}", reader["AGE"]);
                        Console.WriteLine("회원직업 : {0}", reader["JOB"]);
                        Console.WriteLine("===========");
                    }
                }
                connection.Close();
            }
        }

    }
}
