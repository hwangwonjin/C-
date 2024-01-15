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
using log4net;

namespace PopupAgent
{
    public partial class Service1 : ServiceBase
    {
        private Timer popupTimer;
        private DateTime lastPopupTime;
        private static readonly ILog log = LogManager.GetLogger(typeof(Service1));

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // 서비스 시작 확인 로그
            log.Debug("프로그램이 시작하였습니다.");
            log.Info("프로그램이 시작하였습니다.");
            log.Warn("프로그램이 시작하였습니다.");

            // 서비스 시작 시 수행할 작업
            lastPopupTime = DateTime.Now;

            // 타이머 초기화 (2초 주기로 체크)
            popupTimer = new Timer(2000);
            popupTimer.Elapsed += PopupTimerElapsed;
            popupTimer.AutoReset = true;
            popupTimer.Start();
        }

        protected override void OnStop()
        {
        }

        private void PopupTimerElapsed(object sender, ElapsedEventArgs e)
        {
            log.Debug("PopupTimerElapsed Start");
            // 타이머가 만료되면 호출되는 메서드
            ShowPopupIfNeeded();
        }

        private void ShowPopupIfNeeded()
        {
            log.Debug("ShowPopupIfNeeded Start");
            // 팝업이 열려있지 않은 경우에만 팝업을 띄움
            if (!IsPopupOpen())
            {
                log.Debug("Insert Database");

                // 여기에서 팝업을 띄우는 작업을 수행
                PopupForm popupForm = new PopupForm();
                popupForm.Show();

                // 데이터베이스에 기록
                RecordPopupInDatabase();

                // 팝업을 띄운 후 마지막 팝업 시각을 업데이트
                lastPopupTime = DateTime.Now;
            }
        }

        private bool IsPopupOpen()
        {
            // 여기에서는 팝업 폼을 생성하여 그 상태를 확인합니다.
            return PopupForm.IsPopupOpen();
        }

        private void RecordPopupInDatabase()
        {
            // 데이터베이스에 팝업 정보를 기록하는 로직을 추가
            // (실제로는 데이터베이스에 어떤 정보를 기록할지에 따라 코드를 추가해야 합니다.)
            try
            {
                // 데이터베이스 연결 문자열을 적절히 수정
                string connectionString = "Server=127.0.0.1;Database=java2db;User ID=root;Password=1234;";

                // DatabaseHelper 인스턴스 생성
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                // 팝업 정보 기록
                dbHelper.RecordPopupInfo();
            }
            catch (Exception ex)
            {
                // 예외 처리 (기록 실패 등)
                log.Error($"Failed to record popup info: {ex.Message}", ex);
            }
        }
    }
}
