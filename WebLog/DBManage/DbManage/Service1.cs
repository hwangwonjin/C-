using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DbManage
{
    public partial class Service1 : ServiceBase
    {
        private Timer dbTimer;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            dbTimer = new Timer();
            dbTimer.Interval = 5000;
            dbTimer.Elapsed += Timer_Elased;
            dbTimer.AutoReset = true;
            dbTimer.Start();
        }

        private void Timer_Elased(object sender, ElapsedEventArgs e)
        {
            try
            {
                // 데이터베이스 연결 문자열을 적절히 수정
                string connectionString = "Server=127.0.0.1;Database=java2db;User ID=root;Password=1234;";

                // DatabaseHelper 인스턴스 생성
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                // 팝업 정보 기록
                dbHelper.RecordTimeInfo();
            }
            catch (Exception ex)
            {
                // 예외 처리 (기록 실패 등)
                Console.WriteLine($"Failed to record popup info: {ex.Message}");
            }
        }

        protected override void OnStop()
        {
        }
    }
}
