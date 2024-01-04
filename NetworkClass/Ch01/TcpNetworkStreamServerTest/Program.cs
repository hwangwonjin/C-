using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpNetworkStreamServerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 13);
            tcpListener.Start();
            byte[] buffer = new byte[1024];
            int TotalByteCount = 0, ReadByteCount = 0;

            Console.WriteLine("서버");

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream ns = tcpClient.GetStream();

            while (true)
            {
                ReadByteCount = ns.Read(buffer, 0, buffer.Length);
                if(ReadByteCount == 0)
                {
                    break;  
                }
                TotalByteCount += ReadByteCount;    
                ns.Write(buffer, 0, ReadByteCount);
                Console.WriteLine(Encoding.ASCII.GetString(buffer));
            }

            ns.Close(); 
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}