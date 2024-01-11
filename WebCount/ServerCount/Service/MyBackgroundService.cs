using Microsoft.AspNetCore.SignalR;
using MyWeb.Service;

namespace ServerCount.Service
{
    public class MyBackgroundService : BackgroundService
    {
        private readonly IHubContext<PopupHub> _hubContext;

        public MyBackgroundService(IHubContext<PopupHub> hubContext)
        {
            _hubContext = hubContext;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // 백그라운드 작업 수행
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

                if (stoppingToken.IsCancellationRequested)
                    break;

                // DoCounting의 로직을 직접 구현
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                await _hubContext.Clients.All.SendAsync("showPopup", $"현재 시간 : {currentTime}");
            }
        }
    }
}
