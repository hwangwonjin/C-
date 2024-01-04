using System.Net;
using System.Net.Sockets;

namespace AccetTcpClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.35.207"), 7);
            tcpListener.Start();
            Console.WriteLine("대기 상태 시작");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            Console.WriteLine("대기 상태 종료");
            tcpListener.Stop();
        }
    }
}