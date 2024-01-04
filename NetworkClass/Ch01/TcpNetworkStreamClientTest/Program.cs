using System.Net.Sockets;
using System.Text;

namespace TcpNetworkStreamClientTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient("localhost", 13);
            NetworkStream ns = tcpClient.GetStream();
            Console.WriteLine("클라이언트");
            byte[] buffer = new byte[1024];
            byte[] sendMeassage = Encoding.ASCII.GetBytes("Hello World");
            ns.Write(sendMeassage, 0, sendMeassage.Length);
            int TotalCount = 0, ReadCount = 0;

            while (TotalCount < sendMeassage.Length) 
            { 
                ReadCount = ns.Read(buffer, 0, buffer.Length);
                TotalCount += ReadCount;

                string RecvMessage = Encoding.ASCII.GetString(buffer);
                Console.WriteLine(RecvMessage);

            }

            Console.WriteLine("받은 문자열 바이트 수 : {0}", TotalCount);
            ns.Close();
            tcpClient.Close();
        }
    }
}