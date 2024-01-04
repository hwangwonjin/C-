using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkStreamServerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.35.207"), 13);
            tcpListener.Start();
            Console.WriteLine("대기 상태");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream ns = tcpClient.GetStream();
            byte[] ReceiveMessage = new byte[100];
            ns.Read(ReceiveMessage, 0, ReceiveMessage.Length);
            string strMassage = Encoding.ASCII.GetString(ReceiveMessage);
            Console.WriteLine(strMassage);

            string EchoMassage = "Hi";
            byte[] sebdMessage = Encoding.ASCII.GetBytes(EchoMassage);
            ns.Write(sebdMessage, 0, sebdMessage.Length);
            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();
            Console.ReadKey();
        
        }

    }
}