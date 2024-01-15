using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupAgent
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // 팝업 창이 뜰때 팝업창이 뜨는 시간을 DB에 기록
        public void RecordPopupInfo()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 여기에서 데이터베이스에 정보를 기록하는 SQL 쿼리를 작성
                string query = "INSERT INTO `table_log` (Popup_start) VALUES (NOW())";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // 팝업창이 닫힐때 팝업창이 닫히는 시간을 DB에 기록
        public void RecordPopupCloseTime()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 데이터베이스에 팝업 닫힌 시간을 기록하는 SQL 쿼리를 작성
                string query = "UPDATE `table_log` SET `Pop_end` = NOW() ORDER BY `idx` DESC LIMIT 1;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
