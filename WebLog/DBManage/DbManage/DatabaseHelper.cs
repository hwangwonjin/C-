using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManage
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // 팝업창이 열린 시간과 닫힌 시간을 계산해서 DB에 기록
        public void RecordTimeInfo()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 여기에서 데이터베이스에 정보를 기록하는 SQL 쿼리를 작성
                string query = "UPDATE `table_log` SET Time = TIMESTAMPDIFF(SECOND, Popup_start, Pop_end) WHERE Pop_end IS NOT NULL AND Time IS NULL";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
