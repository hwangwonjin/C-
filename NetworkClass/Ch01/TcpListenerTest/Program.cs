using System.Net;
using System.Net.Sockets;

namespace TcpListenerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("192.168.35.207");
            TcpListener tcpListener = new TcpListener(ip, 13);
            Console.WriteLine("{0}", tcpListener.LocalEndpoint.ToString());
            Console.ReadKey();
        }
    }
}