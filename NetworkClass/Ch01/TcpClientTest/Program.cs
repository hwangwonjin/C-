using System.Net.Sockets;

namespace TcpClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient("192.168.35.207",7);
            if(tcpClient.Connected)
            {
                Console.WriteLine("서버 연결 성공");
            }
            else
            {
                Console.WriteLine("서버 연결 실패");
            }

            tcpClient.Close();
            Console.ReadKey();
        }
    }
}