using System.Net.Sockets;
using System.Text;

namespace TcpClientGetServerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient("192.168.35.207", 13);
            if(tcpClient.Connected)
            {
                Console.WriteLine("서버 연결 성공");
                NetworkStream ns = tcpClient.GetStream();
                string Message = "Hello Wolrd";
                byte[] SendMessage = Encoding.ASCII.GetBytes(Message);
                ns.Write(SendMessage, 0, SendMessage.Length);

                byte[] ReceiveByMessage = new byte[32];
                ns.Read(ReceiveByMessage, 0, ReceiveByMessage.Length);  
                string ReceiveMessage = Encoding.ASCII.GetString(ReceiveByMessage);
                Console.WriteLine(ReceiveMessage);
                ns.Close();

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