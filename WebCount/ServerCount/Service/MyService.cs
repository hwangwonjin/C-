using Microsoft.AspNetCore.SignalR;
/*
    내용 : IService를 사용하여 controller와 통신
 */
namespace MyWeb.Service
{
    public class MyService : IMyService
    {
        private readonly IHubContext<PopupHub> _hubContext;

        public MyService(IHubContext<PopupHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public void DoCounting()
        {
            Task.Run(async () => 
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromSeconds(10));

                    string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    await _hubContext.Clients.All.SendAsync("showPopup",$"현재 시간 : {currentTime}");
                }    
            });
        }
    }
}
