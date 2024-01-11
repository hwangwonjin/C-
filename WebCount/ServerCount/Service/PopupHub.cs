using Microsoft.AspNetCore.SignalR;

namespace MyWeb.Service
{
    public class PopupHub : Hub
    {
        // 서버에서 클라이언트로 메시지를 보내는 메서드
        public async Task SendMessageToClients(string message)
        {
            // 연결된 모든 클라이언트에게 메시지를 보냄
            await Clients.All.SendAsync("ReceiveMessageFromServer", message);
        }
    }
}
