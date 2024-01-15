using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using ContentAlignment = System.Drawing.ContentAlignment;
using Label = System.Windows.Forms.Label;

namespace PopupAgent
{
    public class PopupForm : Form
    {
        private Label label1;
        private static bool isPopupOpen = false;

        public PopupForm()
        {
            // 팝업의 초기화 코드
            InitializeComponent();
            Text = "Popup Form";
            Size = new System.Drawing.Size(452, 307);

            // 팝업 내용 추가 (라벨 등)
            Label label = new Label
            {
                Text = "팝업창이 띄워져 있습니다,",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(label);

            isPopupOpen = true; // 폼이 열릴 때 true로 설정
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // 폼이 닫힐 때 호출되는 이벤트 핸들러
            base.OnFormClosed(e);

            // 폼이 닫힌 경우 팝업 상태를 업데이트
            isPopupOpen = false;

            // 닫힌 시간을 데이터베이스에 기록
            RecordCloseTimeInDatabase();
        }

        public static bool IsPopupOpen()
        {
            // 팝업이 열려있는지 여부를 반환
            return isPopupOpen;
        }

        private void RecordCloseTimeInDatabase()
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
                dbHelper.RecordPopupCloseTime();
            }
            catch (Exception ex)
            {
                // 예외 처리 (기록 실패 등)
                Console.WriteLine($"Failed to record popup info: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "팝업창이 표시되었습니다.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PopupForm
            // 
            this.ClientSize = new System.Drawing.Size(416, 190);
            this.Controls.Add(this.label1);
            this.Name = "PopupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
